Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Globalization
Imports System.Management
Imports System.Threading


Namespace Wmi

    ' A class for accessing and formatting WMI Win32 Class properties.
    Public NotInheritable Class Win32ClassInfo

        Private Structure wmiProperty
            Dim name As String
            Dim value As Object
        End Structure

        ' Because we run our routine that gets the selected class's properties on a background thread using the
        ' BackgroundWorker component, we can't update our listview directly using this thread, if we try, we get 
        ' a cross-threading exception; our listview was created on the program's main thread and can't be changed 
        ' directly by our background thread.

        ' To get round this little problem, we create delegate routines and then call the listview control's 
        ' invoke method which uses the delegated routine to update the listview control on the main thread.

        Private Delegate Sub AddItem(ByVal lv As ListView, ByVal lvi As ListViewItem)
        Private Delegate Function AddItemGroup(ByVal lv As ListView, ByVal key As String, ByVal header As String) As ListViewGroup

        Private Sub New()
        End Sub

        Public Shared Sub ListClassProperties(ByVal bw As BackgroundWorker, ByVal listViewCtrl As ListView, ByVal wmiClass As String)

            ' This sub walks the WMI class passed to it and processes the class's properties. The property name,
            ' along with its value are added to the listview if, and only if the property exists and the property
            ' has a value associated with it. The value, where relevant, is formatted or enumerated to make it more
            ' meaningful.

            ' Those properties that yield multiple values are processed here and given a seperate group listing in
            ' the listview control. Those properties that don't yield multiple values are processed in the 
            ' FormatWmiData function and then added to the listview control.

            ' This code is based, in part, on the codeproject article "How To Get Hardware Information (CPU ID, MainBoard Info, Hard Disk Serial, System Information...)"
            ' By Alireza Shirazi. http://www.codeproject.com/KB/system/GetHardwareInformation.aspx

            ' I have added grouping, formatting, additional error checking and running on a background thread to the original C# code.

            Dim searcher As New ManagementObjectSearcher("Select * From " & wmiClass)
            Dim classHasData As Boolean = False
            Dim count As Integer = 0

            Try
                ' Walk the list of properties.
                For Each WmiProperty As ManagementObject In searcher.Get

                    Dim listViewGroup As New ListViewGroup
                    classHasData = True

                    ' Report the progress as to how many items we've found so far.
                    count += 1
                    bw.ReportProgress(count)

                    ' Stop collecting the data if the user clicked the cancel button.
                    If bw.CancellationPending Then Exit Sub

                    Try
                        'Add a group heading to the listview control. We put this in a Try...Catch...End Try construct because
                        'the "Caption" property isn't available in some WMI classes.

                        If WmiProperty("Caption") IsNot Nothing Then

                            listViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                                 {listViewCtrl, WmiProperty("Caption").ToString, WmiProperty("Caption").ToString}), ListViewGroup)
                        Else
                            ' This is in case the Caption property does exist but doesn't contain anything.
                            listViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                                 {listViewCtrl, "  ", "  "}), ListViewGroup)
                        End If

                        ' And this will catch if the Caption property doesn't exist at all; amongst other things.
                    Catch ex As ManagementException

                        listViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                             {listViewCtrl, "  ", "  "}), ListViewGroup)
                    End Try

                    ' Walk the list of property data in the class.
                    For Each pd As PropertyData In WmiProperty.Properties

                        ' Stop collecting the data if the user clicked the cancel button.
                        If bw.CancellationPending Then Exit Sub

                        ' Create a list view item for our group.
                        Dim listViewItem As New ListViewItem(listViewGroup)

                        ' Alternate each property's background colour.
                        If listViewCtrl.Items.Count Mod 2 <> 0 Then
                            listViewItem.BackColor = Color.White
                        Else
                            listViewItem.BackColor = Color.Ivory
                        End If

                        ' Add the property name to the list view control.
                        listViewItem.Text = pd.Name

                        ' Has the property got an associated value?
                        If pd.Value IsNot Nothing AndAlso pd.Value.ToString <> "" Then

                            ' Format or enumerate the property value based on the property name (pd.name).
                            Select Case pd.Name

                                Case "AccessMask" ' Win32_Directory
                                    Dim heading As String = WmiProperty("Caption").ToString

                                    ' Create a new group to list the Access Rights under.
                                    Dim lvGroup As ListViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                                                        {listViewCtrl, "Access Permissions For " & heading, "Access Permissions For " & heading}), ListViewGroup)

                                    Dim accessRightsBitMask As UInt32 = CType(pd.Value, UInt32)
                                    Dim accessRights() As String = {"FILE_READ_DATA (file), FILE_LIST_DIRECTORY (directory)", _
                                                                    "FILE_WRITE_DATA (file), FILE_ADD_FILE (directory)", _
                                                                    "FILE_APPEND_DATA", "FILE_READ_EA", "FILE_WRITE_EA", _
                                                                    "FILE_EXECUTE (file), FILE_TRAVERSE (directory)", _
                                                                    "FILE_DELETE_CHILD", "FILE_READ_ATTRIBUTES", _
                                                                    "FILE_WRITE_ATTRIBUTES", "", "", "", "", "", "", "", _
                                                                    "DELETE", "READ_CONTROL", "WRITE_DAC", "WRITE_OWNER", "SYNCHRONIZE"}

                                    ' Decode the Access Rights Bit Mask.
                                    For rights = 0 To UBound(accessRights)
                                        If CBool(CLng(2 ^ rights) And accessRightsBitMask) Then

                                            Dim lvGroupItem As New ListViewItem(lvGroup)
                                            lvGroupItem.SubItems.Add(accessRights(rights))
                                            listViewCtrl.Invoke(New AddItem(AddressOf AddListViewItem), New Object() {listViewCtrl, lvGroupItem})

                                        End If
                                    Next

                                Case "AutorecoverMofs" ' Win32_WMISetting.
                                    AddListViewGroupStringArray("Qualified MOF file names", pd.Value, listViewCtrl)

                                Case "Flags"

                                    Dim heading As String = WmiProperty("Caption").ToString

                                    ' Create a new group to list the Access Rights under.
                                    Dim lvGroup As ListViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                                                        {listViewCtrl, "Network Profile Flags For " & heading, "Network Profile Flags For " & heading}), ListViewGroup)

                                    Dim networkProfileBitMask As UInt32 = CType(pd.Value, UInt32)
                                    Dim networkProfileFlags() As String = {"Script", "Account Disabled", "", "Home Directory Required", _
                                                                           "The account is currently locked out", "Password Not Required", _
                                                                           "Password Cannot Change", "Encrypted Test Password Allowed", _
                                                                           "Temp Duplicate Account", "Normal Account", "", "Interdomain Trust Account", _
                                                                           "Workstation Trust Account", "Server Trust Account", "", "", "Do Not Expire Password", _
                                                                           "MNS Logon Account", "Smartcard Required", "Trusted for Delegation", "Not Delegated", _
                                                                           "Use DES Key Only", "Do Not Require Preauthorization", "Password Expired"}

                                    ' Decode the network profile Bit Mask.
                                    For flags = 0 To UBound(networkProfileFlags)
                                        If CBool(CLng(2 ^ flags) And networkProfileBitMask) Then

                                            Dim lvGroupItem As New ListViewItem(lvGroup)
                                            lvGroupItem.SubItems.Add(networkProfileFlags(flags))
                                            listViewCtrl.Invoke(New AddItem(AddressOf AddListViewItem), New Object() {listViewCtrl, lvGroupItem})

                                        End If
                                    Next

                                Case "BiosCharacteristics"

                                    ' Bios Characteristics consists of an array of uint16 (ushort) values depicting various BIOS capabilities.
                                    Dim BiosCharacteristics() As String = {"Reserved", "Reserved", "Unknown", "BIOS Characteristics Not Supported", _
                                                                           "ISA is supported", "MCA is supported", "EISA is supported", "PCI is supported", _
                                                                           "pd Card (PCMCIA) is supported", "Plug and Play is supported", "APM is supported", _
                                                                           "BIOS is Upgradable (Flash)", "BIOS shadowing is allowed", "VL-VESA is supported", _
                                                                           "ESCD support is available", "Boot from CD is supported", "Selectable Boot is supported", _
                                                                           "BIOS ROM is socketed", "Boot From pd Card (PCMCIA) is supported", _
                                                                           "EDD (Enhanced Disk Drive) Specification is supported", _
                                                                           "Int 13h - Japanese Floppy for NEC 9800 1.2mb (3.5, 1k Bytes/Sector, 360 RPM) is supported", _
                                                                           "Int 13h - Japanese Floppy for Toshiba 1.2mb (3.5, 360 RPM) is supported", _
                                                                           "Int 13h - 5.25 / 360 KB Floppy Services are supported", _
                                                                           "Int 13h - 5.25 /1.2MB Floppy Services are supported", "Int 13h - 3.5 / 720 KB Floppy Services are supported", _
                                                                           "Int 13h - 3.5 / 2.88 MB Floppy Services are supported", "Int 5h, Print Screen Service is supported", _
                                                                           "Int 9h, 8042 Keyboard services are supported", "Int 14h, Serial Services are supported", _
                                                                           "Int 17h, printer services are supported", "Int 10h, CGA/Mono Video Services are supported", _
                                                                           "NEC pd-98", "ACPI is supported", "USB Legacy is supported", "AGP is supported", "I2O boot is supported", _
                                                                           "LS-120 boot is supported", "ATAPI ZIP Drive boot is supported", "1394 boot is supported", _
                                                                           "Smart Battery is supported"}

                                    Dim shortData As UShort() = CType(pd.Value, UShort())

                                    ' Create a new group to list the BIOS charateristics under.
                                    Dim lvGroup As ListViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                                                        {listViewCtrl, "Supported BIOS Capabilites", "Supported BIOS Capabilites"}), ListViewGroup)

                                    ' Walk the list. Only the first 39 characteristics are supported, the 
                                    ' remainder are reserved for BIOS vendor and System vendor usage and
                                    ' therfore, we don't list them; basically, because we don't know what 
                                    ' they mean.
                                    For Each sd As UShort In shortData
                                        If sd <= 39 Then
                                            Dim lvGroupItem As New ListViewItem(lvGroup)

                                            lvGroupItem.SubItems.Add(BiosCharacteristics(sd))
                                            listViewCtrl.Invoke(New AddItem(AddressOf AddListViewItem), New Object() {listViewCtrl, lvGroupItem})
                                        Else
                                            Exit For
                                        End If
                                    Next

                                Case "BIOSVersion"

                                    ' From MSDN: "Windows Server 2003 and Windows XP:  Array of the complete system BIOS information. 
                                    ' In many computers there can be several version strings that are stored in the registry and 
                                    ' represent the system BIOS information."
                                    AddListViewGroupStringArray("BIOS Version Strings", pd.Value, listViewCtrl)

                                Case "CapabilityDescriptions"
                                    AddListViewGroupStringArray("Device Capabilities", pd.Value, listViewCtrl)

                                Case "ChassisTypes" ' Win32_SystemEnclosure.
                                    Dim chassisTypes As String() = {"Other", "Unknown", "Desktop", "Low Profile Desktop", "Pizza Box", "Mini Tower", "Tower", _
                                                                  "Portable", "Laptop", "Notebook", "Hand Held", "Docking Station", "All in One", "Sub Notebook", _
                                                                  "Space-Saving", "Lunch Box", "Main System Chassis", "Expansion Chassis", "SubChassis", _
                                                                  "Bus Expansion Chassis", "Peripheral Chassis", "Storage Chassis", "Rack Mount Chassis", _
                                                                  "Sealed-Case PC"}

                                    AddListViewGroupUInt16Array("Chassis Types", pd.Value, chassisTypes, listViewCtrl)

                                Case "ConnectorType" ' Win32_SystemSlot.
                                    Dim connectorTypeList As String() = {"Unknown", "Other", "Male", "Female", "Shielded", "Unshielded", "SCSI (A) High-Density (50 pins)", _
                                                                   "SCSI (A) Low-Density (50 pins)", "SCSI (P) High-Density (68 pins)", "SCSI SCA-I (80 pins)", _
                                                                   "SCSI SCA-II (80 pins)", "SCSI Fibre Channel (DB-9, Copper)", "SCSI Fibre Channel (Fibre)", _
                                                                   "SCSI Fibre Channel SCA-II (40 pins)", "SCSI Fibre Channel SCA-II (20 pins)", "SCSI Fibre Channel BNC", _
                                                                   "ATA 3-1/2 Inch (40 pins)", "ATA 2-1/2 Inch (44 pins)", "ATA-2", "ATA-3", "ATA/66", "DB-9", _
                                                                   "DB-15", "DB-25", "DB-36", "RS-232C", "RS-422", "RS-423", "RS-485", "RS-449", "V.35", "X.21", "IEEE-488", _
                                                                   "AUI", "UTP Category 3", "UTP Category 4", "UTP Category 5", "BNC", "RJ11", "RJ45", "Fiber MIC", "Apple AUI", _
                                                                   "Apple GeoPort", "PCI", "ISA", "EISA", "VESA", "PCMCIA", "PCMCIA Type I", "PCMCIA Type II", "PCMCIA Type III", _
                                                                   "ZV Port", "CardBus", "USB", "IEEE 1394", "HIPPI", "HSSDC (6 pins)", "GBIC", "DIN", "Mini-DIN", "Micro-DIN", _
                                                                   "PS/2", "Infrared", "HP-HIL", "Access.bus", "NuBus", "Centronics", "Mini-Centronics", "Mini-Centronics Type-14", _
                                                                   "Mini-Centronics Type-20", "Mini-Centronics Type-26", "Bus Mouse", "ADB", "AGP", "VME Bus", "VME64", "Proprietary", _
                                                                   "Proprietary Processor Card Slot", "Proprietary Memory Card Slot", "Proprietary I/O Riser Slot", "PCI-66MHZ", _
                                                                   "AGP2X", "AGP4X", "PC-98", "PC-98 - Hireso", "PC-H98", "PC-98Note", "PC-98Full", "PCI-X", "SSA SCSI", "Circular", _
                                                                   "On-Board IDE Connector", "On-Board Floppy Connector", "9 Pin Dual Inline", "25 Pin Dual Inline", "50 Pin Dual Inline", _
                                                                   "68 Pin Dual Inline", "On-Board Sound Connector", "Mini-Jack", "PCI-X", "Sbus IEEE 1396-1993 32 Bit", _
                                                                   "Sbus IEEE 1396-1993 64 Bit", "MCA", "GIO", "XIO", "HIO", "NGIO", "PMC", "MTRJ", "VF-45", "Future I/O", "SC", "SG", _
                                                                   "electrical", "Optical", "Ribbon", "GLM", "1x9", "Mini SG", "LC", "HSSC", "VHDCI Shielded (68 pins)", "InfiniBand", _
                                                                   "AGP8X", "PCI-E"}

                                    AddListViewGroupUInt16Array("Physical Connector Types", pd.Value, connectorTypeList, listViewCtrl)

                                Case "SupportedSRAM"
                                    Dim ramType() As String = {"Other", "Unknown", "Non-Burst", "Burst", "Pipeline Burst", "Synchronous", "Asynchronous"}
                                    AddListViewGroupUInt16Array("Supported Cache Memory Types", pd.Value, ramType, listViewCtrl)

                                Case "CurrentSRAM"
                                    Dim ramType() As String = {"Other", "Unknown", "Non-Burst", "Burst", "Pipeline Burst", "Synchronous", "Asynchronous"}
                                    AddListViewGroupUInt16Array("Current Cache Memory Types", pd.Value, ramType, listViewCtrl)

                                Case "CompatibleID"
                                    AddListViewGroupStringArray("Compatible Identification Strings", pd.Value, listViewCtrl)

                                Case "ConfigOptions"
                                    AddListViewGroupStringArray("Configuration Options", pd.Value, listViewCtrl)

                                Case "GatewayCostMetric"
                                    Dim metric As UInt16() = CType(pd.Value, UInt16())
                                    Dim tmp As String = ""

                                    For Each m As String In metric
                                        tmp += m.ToString & " "
                                    Next
                                    listViewItem.SubItems.Add(tmp)
                                    listViewCtrl.Invoke(New AddItem(AddressOf AddListViewItem), New Object() {listViewCtrl, listViewItem})

                                Case "HardwareID"
                                    AddListViewGroupStringArray("Hardware Identification Strings", pd.Value, listViewCtrl)

                                Case "InsertionStrings"
                                    AddListViewGroupStringArray("Event Log Insertion Strings", pd.Value, listViewCtrl)

                                Case "ListOfLanguages"
                                    AddListViewGroupStringArray("Supported Languages", pd.Value, listViewCtrl)

                                Case "OEMStringArray"
                                    ' OEM support strings.
                                    AddListViewGroupStringArray("OEM Support Information", pd.Value, listViewCtrl)

                                Case "Roles"
                                    AddListViewGroupStringArray("Computer Roles", pd.Value, listViewCtrl)

                                Case "Sources"
                                    AddListViewGroupStringArray("NT Eventlog Sources", pd.Value, listViewCtrl)

                                Case "VccMixedVoltageSupport" ' Win32_SystemSlot.
                                    Dim VccVoltageList() As String = {"Unknown", "Other", "3.3 Volts", "5.0 Volts"}
                                    AddListViewGroupUInt16Array("Supported Vcc Voltages", pd.Value, VccVoltageList, listViewCtrl)

                                Case "VppMixedVoltageSupport" ' Win32_SystemSlot.
                                    Dim VppVoltageList() As String = {"Unknown", "Other", "3.3 Volts", "5.0 Volts", "12.0 Volts"}
                                    AddListViewGroupUInt16Array("Supported Vpp Voltages", pd.Value, VppVoltageList, listViewCtrl)

                                Case Else
                                    listViewItem.SubItems.Add(FormatWmiData(wmiClass, pd.Name, pd.Value))
                                    listViewCtrl.Invoke(New AddItem(AddressOf AddListViewItem), New Object() {listViewCtrl, listViewItem})

                            End Select
                        End If
                    Next
                Next

                If Not classHasData Then
                    MsgBox("Class " & wmiClass & " doesn't contain any readable data.", MsgBoxStyle.Critical, "Error Retrieving Data.")
                    bw.ReportProgress(-1)
                End If

            Catch ex As ManagementException
                MsgBox("The following error occured while trying to obtain information from WMI Class " & _
                       wmiClass & Environment.NewLine & Environment.NewLine & ex.Message, _
                       MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Error.")
                bw.ReportProgress(-1)
            End Try


        End Sub

        ' A function to return a value for the named Property from the named WMI class.
        Public Shared Function GetClassProperty(ByVal wmiClass As String, ByVal wmiProperty As String) As String

            Dim queryResult As Object = Nothing
            Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("Select " & wmiProperty & " from " & wmiClass)

            Try
                For Each mo As ManagementObject In searcher.Get()
                    For Each pd As PropertyData In mo.Properties
                        queryResult = pd.Value
                    Next
                Next

            Catch ex As ManagementException
                ' If an error has occurred we return with 'Not Available", else we go on to format the result. 
                ' We don't display an error message here as some queries are likely to fail because they don't  
                ' exist on certain platforms; such as: 'L3CacheSize' is not available on Windows XP.
                Return notAvailable
            End Try

            If queryResult Is Nothing Then
                Return notAvailable
            Else
                Return FormatWmiData(wmiClass, wmiProperty, queryResult)
            End If

        End Function

        ' This function returns a string from the list of possible property items as indicated by the item's 
        ' position within the list. We use the offset to correctly align the list with the wmi data value.
        ' For example, some wmi lists start with the first item equating to 1 and others start at zero.
        '
        ' For lists that start at 0, set offset to 0. For those lists that start at 1, set offset to -1.
        '
        ' If a list has an associated qualifier, we add that to the returned string as well. A qualifier
        ' would be something like Volts, Bits or Mbytes etc.

        Private Shared Function EnumeratePropertyList(ByVal wmiData As Object, ByVal List As String(), ByVal Offset As Integer, ByVal Qualifier As String) As String
            Try
                Dim value As Long = CType(wmiData, Long)
                Dim upperBound As Integer = List.GetUpperBound(0)

                ' Adjust the upper bound of the list array if the offset is -1.
                If Offset = -1 Then
                    upperBound += 1
                End If

                ' A little error checking on the value returned from the wmi class.
                If (Offset = -1 AndAlso value <= 0) Or (value > upperBound) Then
                    Return "Invalid data passed. The data was: " & value.ToString(CultureInfo.InvariantCulture)
                Else
                    Return List(CInt(value + Offset)) & Qualifier
                End If
            Catch ex As Exception
                Throw
                Return "Error: " & ex.Message
            End Try
        End Function

        Private Shared Function CastToString(ByVal wmiData As Object, ByVal Qualifier As String) As String

            Dim returnData As String = wmiData.ToString

            If Qualifier = "" Then
                Return returnData
            Else
                Return returnData & Qualifier
            End If

        End Function

        Private Shared Function CastToStringArray(ByVal wmiData As Object) As String()

            Return CType(wmiData, String())

        End Function

        Public Shared Function FormatWmiData(ByVal wmiClass As String, ByVal wmiPropertyName As String, ByVal wmiData As Object) As String

            Select Case wmiPropertyName

                Case "IPAddress", "IPSubnet"
                    Dim IP As String() = CastToStringArray(wmiData)

                    ' Element 0 contains the IPv4 notation.
                    ' Element 1 contains the IPv6 hexadecimal notation which we don't use.
                    Return IP(0).ToString(CultureInfo.InvariantCulture)

                Case "IPSecPermitIPProtocols", "IPSecPermitTCPPorts", "IPSecPermitUDPPorts"
                    Return ConcatStringArray(CastToStringArray(wmiData))

                Case "DNSDomainSuffixSearchOrder", "DNSServerSearchOrder", "DefaultIPGateway"
                    Return ConcatStringArray(CastToStringArray(wmiData))


                Case "Access" ' Win32_CacheMemory & Win32_Volume.
                    Dim list As String() = {"Unknown", "Readable", "Writable", "Read/Write Supported,", "Write Once"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "Associativity" ' Win32_CacheMemory
                    Dim list As String() = {"Other", "Unknown", "Direct Mapped", "2-way Set-Associative", "4-way Set-Associative", _
                                            "Fully Associative", "8-way Set-Associative", "16-way Set-Associative"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")


                Case "AcceleratorCapabilities" ' CIM_VideoController Class.
                    Dim list As String() = {"Unknown", "Other", "Graphics Accelerator", "3-D Accelerator"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "AccountType" ' Win32_UserAccount.
                    Select Case CType(wmiData, UInt32)
                        Case 256
                            Return "Local user account for users who have a primary account in another domain."
                        Case 512
                            Return "Default account type that represents a typical user."
                        Case 2048
                            Return "Account for a system domain that trusts other domains."
                        Case 4096
                            Return "Computer account for a computer system running Windows 2000 or Windows NT that is a member of this domain."
                        Case 8192
                            Return "Account for a system backup domain controller that is a member of this domain."
                        Case Else
                            Return CastToString(wmiData, "")
                    End Select

                Case "AdminPasswordStatus" ' Win32_ComputerSystem.
                    Dim list As String() = {"Disabled", "Enabled", "Not Implemented", "Unknown"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "Architecture" ' Win32_Processor.
                    Select Case CType(wmiData, Int16)
                        Case 0
                            Return "x86"
                        Case 1
                            Return "MIPS"
                        Case 2
                            Return "Alpha"
                        Case 3
                            Return "PowerPC"
                        Case 6
                            Return "Intel Itanium"
                        Case 9
                            Return "x64"
                        Case Else
                            Return "Unknown"
                    End Select

                    ' The MSDN info for the Attributes property appears to be wrong or is out of date. 
                    ' My system returns results of 4, 17, & 20 in addition to the ones listed at 
                    ' http://msdn.microsoft.com/en-us/library/aa394458%28VS.85%29.aspx. 

                Case "Attributes" ' Win32_SoftwareFeature.
                    Dim list As String() = {"ifrsFavorLocal - Install components locally, if possible.", _
                                            "ifrsFavorSource - Install components to run from the source CD/server, if possible.", _
                                            "ifrsFollowParent - Follow the remote execution option of the parent feature."}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "Availability" ' CIM_LogicalDevice Class.
                    Dim list As String() = {"Other", "Unknown", "Running or Full Power", "Warning", "In Test", _
                                            "Not Applicable", "Power Off", "Off Line", "Off Duty", "Degraded", _
                                            "Not Installed", "Install Error", "Power Save - Unknown", _
                                            "Power Save - Low Power Mode", "Power Save - Standby", "Power Cycle", "Power Save - Warning"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "CacheType" ' Win32_CacheMemory.
                    Dim list As String() = {"Other", "Unknown", "Instruction", "Data", "Unified"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "ConfigManagerErrorCode" ' CIM_Controller Class.
                    Dim list As String() = {"Device is working properly.", "Device is not configured correctly.", _
                                                "Windows cannot load the driver for this device.", _
                                                "Driver for this device might be corrupted or the system may be low on memory or other resources.", _
                                                "Device is not working properly. One of its drivers or the registry might be corrupted.", _
                                                "Driver for the device requires a resource that Windows cannot manage.", _
                                                "Boot configuration for the device conflicts with other devices.", _
                                                "Cannot filter.", "Driver loader for the device is missing.", _
                                                "Device is not working properly. The controlling firmware is incorrectly reporting the resources for the device.", _
                                                "Device cannot start.", "Device failed.", "Device cannot find enough free resources to use.", _
                                                "Windows cannot verify the device's resources.", "Device cannot work properly until the computer is restarted.", _
                                                "Device is not working properly due to a possible re-enumeration problem.", _
                                                "Windows cannot identify all of the resources that the device uses.", _
                                                "Device is requesting an unknown resource type.", "Device drivers must be reinstalled.", _
                                                "Failure using the VxD loader.", "Registry might be corrupted.", _
                                                "System failure. If changing the device driver is ineffective, see the hardware documentation. Windows is removing the device.", _
                                                "Device is disabled.", "System failure. If changing the device driver is ineffective, see the hardware documentation.", _
                                                "Device is not present, not working properly, or does not have all of its drivers installed.", _
                                                "Windows is still setting up the device.", "Windows is still setting up the device.", _
                                                "Device does not have valid log configuration.", "Device drivers are not installed.", _
                                                "Device is disabled. The device firmware did not provide the required resources.", _
                                                "Device is using an IRQ resource that another device is using.", _
                                                "Device is not working properly. Windows cannot load the required device drivers."}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "CpuStatus" ' Win32_Processor.
                    Dim list As String() = {"Unknown", "CPU Enabled", "CPU Disabled by User via BIOS Setup", _
                                              "CPU Disabled by BIOS (POST Error)", "CPU Is Idle", "Reserved", "Reserved", "Other"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "CurrentScanMode" ' Win32_VideoController.
                    Dim list As String() = {"Other", "Unknown", "Interlaced", "Non Interlaced"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                    ' Pixels.
                Case "CurrentVerticalResolution", "CurrentHorizontalResolution"
                    Return CastToString(wmiData, " Pixels")

                    ' Bits.
                Case "DataWidth", "EncryptionLevel", "AddressWidth", "CurrentBitsPerPixel"
                    Return CastToString(wmiData, " Bits")

                    ' Bytes.
                Case "MaxLogFileSize", "MTU", "FileSize", "ForwardBufferMemory", "BlockSize", "TcpWindowSize"
                    Return CastToString(wmiData, " Bytes")

                    ' Kbytes.
                Case "L2CacheSize", "L3CacheSize", "InstalledSize", "MaxCacheSize"
                    Return CastToString(wmiData, " Kbytes")

                    ' Mbytes.
                Case "TotalPhysicalMemory", "FreeSpace", "WarningLimit", "Limit", "FreeAndZeroPageListBytes", "DiskSpaceUsed", "Capacity", "AdapterRAM"
                    Dim amount As Long = CLng(wmiData)
                    Return CastToString(CLng((amount / (1024 ^ 2))), " MBytes")

                Case "MaxCapacity"
                    Dim amount As Long = CLng(wmiData)
                    Return CastToString(CLng(amount / 1024), " MBytes")

                Case "TotalPhysicalMemory"
                    Dim amount As Long = CLng(wmiData)
                    Return CastToString(CLng((amount / (1024 ^ 2))), "")

                Case "AvailableMbytes"
                    Return CastToString(wmiData, "")

                    ' Hertz.
                Case "CurrentRefreshRate", "MaxRefreshRate", "MinRefreshRate"
                    Return CastToString(wmiData, " Hertz")

                    ' MHz.
                Case "ExtClock", "CurrentClockSpeed", "L2CacheSpeed", "L3CacheSpeed", "MaxClockSpeed"
                    Return CastToString(wmiData, " MHz")

                    ' Volts.
                Case "CurrentVoltage"
                    Dim cv As UInt16 = CType(wmiData, UInt16)
                    Return CastToString((cv * 0.1), " Volts")

                    ' Nanoseconds.
                Case "CacheSpeed"
                    Return CastToString(wmiData, " Nanoseconds")

                    ' Milliseconds.
                Case "KeepAliveInterval", "KeepAliveTime", "MaxWaitOnEvents"
                    Return CastToString(wmiData, " Milliseconds")

                    ' Seconds.
                Case "UserInputDelay"
                    Return CastToString(wmiData, " Seconds")

                    ' Events/Second.
                Case "LowThresholdOnEvents", "HighThresholdOnEvents"
                    Return CastToString(wmiData, " Events/Second")

                    ' Percent (%).
                Case "LoadPercentage"
                    Return CastToString(wmiData, " %")

                Case "DitherType" ' Win32_VideoController.
                    Dim list As String() = {"No dithering", "Dithering with a coarse brush", "Dithering with a fine brush", "Line art dithering", "Device does gray scaling"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "DomainRole" ' Win32_ComputerSystem.
                    Dim list As String() = {"Standalone Workstation", "Member Workstation", "Standalone Server", _
                                             "Member Server", "Backup Domain Controller", "Primary Domain Controller"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "DriveType" ' Win32_Volume
                    Dim list As String() = {"Unknown", "No Root Directory", "Removable Disk", "Local Disk", "Network Drive", "Compact Disk", "Ram Disk"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "EventType" ' Win32_NTLogEvent.
                    Dim list As String() = {"Error", "Warning", "Information", "Security Audit Success", "Security Audit Failure"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                    ' Some CPU families in this list have been omitted because they were either redundant (8086 etc) or really obscure.
                    ' Who has ever heard of the Hobbit family of CPUs? Certaninly not me.

                Case "Family" ' Win32_Processor
                    Select Case CType(wmiData, Int16)
                        Case 1
                            Return "Other"
                        Case 2
                            Return "Unknown"
                        Case 11
                            Return "Pentium Brand"
                        Case 12
                            Return "Pentium Pro"
                        Case 13
                            Return "Pentium II"
                        Case 14
                            Return "Pentium Processor with MMX™ Technology"
                        Case 15
                            Return "Celeron™"
                        Case 16
                            Return "Pentium II Xeon™"
                        Case 17
                            Return "Pentium III"
                        Case 24
                            Return "AMD Duron™ Processor Family"
                        Case 29
                            Return "AMD Athlon™ Processor Family"
                        Case 120
                            Return "Crusoe™ TM5000 Family"
                        Case 121
                            Return "Crusoe™ TM3000 Family"
                        Case 122
                            Return "Efficeon™ TM8000 Family"
                        Case 128
                            Return "Weitek"
                        Case 130
                            Return "Itanium™ Processor"
                        Case 131
                            Return "AMD Athlon™ 64 Processor Famiily"
                        Case 132
                            Return "AMD Opteron™ Processor Family"
                        Case 176
                            Return "Pentium III Xeon™ Processor"
                        Case 177
                            Return "Pentium III Processor with Intel SpeedStep™ Technology"
                        Case 178
                            Return "Pentium 4"
                        Case 179
                            Return "Intel Xeon™"
                        Case 181
                            Return "Intel Xeon™ Processor MP"
                        Case 182
                            Return "AMD Athlon™ XP Family"
                        Case 183
                            Return "AMD Athlon™ MP Family"
                        Case 184
                            Return "Intel Itanium 2"
                        Case 185
                            Return "Intel Pentium M Processor"
                        Case 281
                            Return "StrongARM"
                        Case Else
                            Return "Not Known. Probably Deleted From List ;-)"
                    End Select


                Case "FormFactor" ' Win32__PhysicalMemory.
                    Dim list As String() = {"Unknown", "Other", "SIP", "DIP", "ZIP", "SOJ", "Proprietry", _
                                            "SIMM", "DIMM", "TSOP", "PGA", "RIMM", "SODIMM", "SRIMM", "SMD", "SSMP", _
                                            "QFP", "TQFP", "SOIC", "LLC", "PLCC", "BGA", "FPBGA", "LGA"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "IGMPLevel" ' Win32_NetworkAdapterConfiguration.
                    Dim list As String() = {"No Multicast", "IP Multicast", "IP and IGMP Multicast (default)"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "LastBootUpTime"
                    Return CastToString(ManagementDateTimeConverter.ToDateTime(CastToString(wmiData, "")), "")

                Case "LastUse" 'Win32_SoftwareFeature.
                    Return ManagementDateTimeConverter.ToDmtfTimeInterval(CType(wmiData, System.TimeSpan))

                Case "LoggingLevel" ' Win32_WMISetting.
                    Dim list As String() = {"Off", "Error Logging", "Verbose Error Logging"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "PasswordAge"
                    Return CInt(ManagementDateTimeConverter.ToTimeSpan(CastToString(wmiData, "")).TotalDays).ToString(CultureInfo.CurrentCulture) & " Days old"

                Case "Privileges"
                    Dim list As String() = {"Guest", "User", "Administrator"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "Level"

                    If wmiClass = "Win32CacheMemory" Then
                        Dim list As String() = {"Other", "Unknown", "Primary", "Secondary", "Tertiary", "Not Applicable"}
                        Return EnumeratePropertyList(wmiData, list, -1, "")
                    End If

                Case "MaxDataWidth" ' Win32_SystemSlot
                    Dim list As String() = {"8", "16", "32", "64", "128"}
                    Return EnumeratePropertyList(wmiData, list, 0, " Bits")



                Case "MemoryType"
                    If wmiClass = "Win32_DeviceMemoryAddress" Or wmiClass = "Win32_SystemMemoryResource" Then
                        ' Do nothing as MSDN reports that this class returns a string here.
                    Else
                        Dim list As String() = {"Unknown", "Other", "DRAM", "Synchronous DRAM", "Cache DRAM", "EDO", "EDRAM", "VRAM", "SRAM", _
                                                                  "RAM", "ROM", "Flash", "EEPROM", "FEPROM", "EPROM", "CDRAM", "3DRAM", "SDRAM", "SGRAM", "RDRAM", _
                                                                  "DDR", "DDR2"}
                        Return EnumeratePropertyList(wmiData, list, 0, "")
                    End If

                Case "Organization"
                    If wmiData Is Nothing Then
                        Return notAvailable
                    End If

                Case "ProcessorType"
                    Dim list As String() = {"Other", "Unknown", "Central Processor", "Math Processor", "DSP Processor", "Video Processor"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "ProductType"
                    Dim list As String() = {"Work Station", "Domain Controller", "Server"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "ProtocolSupported" ' CIM_Controller Class.
                    Dim list As String() = {"Other", "Unknown", "EISA", "ISA", "PCI", "ATA/ATAPI", _
                                            "Flexible Diskette", "1496", "SCSI Parallel Interface", "SCSI Fibre Channel Protocol", _
                                            "SCSI Serial Bus Protocol", "SCSI Serial Bus Protocol-2 (1394)", "SCSI Serial Storage Architecture", _
                                            "VESA", "PCMCIA", "Universal Serial Bus", "Parallel Protocol", "ESCON", "Diagnostic", "I2C", "Power", _
                                            "HIPPI", "Multi Bus", "VME", "IPI", "IEEE-488", "RS232", "IEEE 802.3 10BASE 5", "IEEE 802.3 10BASE 2", _
                                            "IEEE 802.3 1BASE 5", "IEEE 802.3 10BROAD 36", "IEEE 802.3 100BASEVG", "IEEE 802.5 Token-Ring", "ANSI X3T9.5 FDDI", _
                                            "MCA", "ESDI", "IDE", "CMD", "ST506", "DSSI", "QIC2", "Enhanced ATA/IDE", "AGP", "TWIRP (two-way infrared)", _
                                            "FIR (fast infrared)", "SIR (serial infrared)", "IrBus"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "PowerManagementCapabilities" ' CIM_LogicalDevice Class.
                    Dim list As String() = {"Unknown", "Not Supported", "Disabled", "Enabled", "Power Saving Modes Entered Automatically", _
                                            "Power State Settable", "Power Cycling Supported", "Timed Power-On Supported"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "Purpose"
                    If wmiClass = "Win32_CacheMemory" Then
                        Return CastToString(wmiData, "")
                    Else
                        ' Win32_CIMLogicalDeviceCIMDataFile.
                        Dim list As String() = {"Unknown", "Other", "Driver", "Configuration Software", "Application Software", "Instrumentation", "Firmware"}
                        Return EnumeratePropertyList(wmiData, list, -1, "")
                    End If

                Case "ReadPolicy" ' Win32_CacheMemory.
                    Dim list As String() = {"Other", "Unknown", "Read", "Read-Ahead", "Read and Read-Ahead", "Determination Per I/O"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "SecurityStatus" ' Win32_SystemEnclosure.
                    Dim list As String() = {"Other", "Unknown", "None", "External Interface Locked Out", "External Interface Enabled"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "SerialNumber" 'Win32_OperatingSystem & Win32_Volume.
                    If wmiClass = "Win32_Volume" Then
                        Return Hex(CType(wmiData, UInt32))
                    End If

                Case "SIDType" ' Win32_UserAccount, Win32_Account.
                    Dim list As String() = {"User", "Group", "Domain", "Alias", "Well Known Group", "Deleted Account", "Invalid", "Unknown", "Computer"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "SoftwareElementState"
                    Dim list As String() = {"Deployable", "Installable", "Executable", "Running"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "Status"
                    If wmiClass = "Win32_UserProfile" Then
                        Dim list As String() = {"Temporary", "Roaming", "Mandatory", "Corrupted"}
                        Return EnumeratePropertyList(wmiData, list, 0, "")
                    End If

                Case "StatusInfo" ' CIM_LogicalDevice Class
                    Dim list As String() = {"Other", "Unknown", "Enabled", "Disabled", "Not Applicable"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "SystemUpTime"
                    Dim seconds As Long = CLng(wmiData)
                    Dim span As TimeSpan = New TimeSpan(TimeSpan.TicksPerSecond * seconds)
                    Return span.Hours.ToString("00") + " Hours " + span.Minutes.ToString("00") + " Minutes " + span.Seconds.ToString("00") + " Seconds"

                Case "TargetOperatingSystem" ' Win32_BIOS, Win32_SoftwareElement, Win32_RegistryAction, Win32_FileSpecification.
                    Dim list As String() = {"Unknown", "Other", "MACOS", "ATTUNIX", "DGUX", "DECNT", _
                                            "Digital Unix", "OpenVMS", "HPUX", "AIX", "MVS", "OS400", "OS/2", "JavaVM", "MSDOS", _
                                            "WIN3x", "WIN95", "WIN98", "WINNT", "WINCE", "NCR3000", "NetWare", "OSF", "DC/OS", _
                                            "Reliant UNIX", "SCO UnixWare", "SCO OpenServer", "Sequent", "IRIX", "Solaris", "SunOS", _
                                            "U6000", "ASERIES", "TandemNSK", "TandemNT", "BS2000", "LINUX", "Lynx", "XENIX", _
                                            "VM/ESA", "Interactive UNIX", "BSDUNIX", "FreeBSD", "NetBSD", "GNU Hurd", "OS9", _
                                            "MACH Kernel", "Inferno", "QNX", "EPOC", "IxWorks", "VxWorks", "MiNT", "BeOS", "HP MPE", _
                                            "NextStep", "PalmPilot", "Rhapsody", "Windows 2000", "Dedicated", "VSE", "TPF"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "TcpipNetbiosOptions"
                    Dim list As String() = {"Enable NetBios Via DHCP", "Enable Netbios", "Disable NetBios"}
                    Return EnumeratePropertyList(wmiData, list, 0, "")

                Case "TimeOfLastReset", "TimeGenerated", "TimeWritten", "ReleaseDate", "LastAccessed", "LastModified", "LastLogon", _
                     "DriverDate", "DHCPLeaseExpires", "DHCPLeaseObtained", "CreationDate"
                    Return CastToString(ManagementDateTimeConverter.ToDateTime(CastToString(wmiData, "")), "")

                Case "InstallDate"
                    If wmiClass = "Win32_Product" AndAlso Not FormMain.OSName.Contains("2000") Then
                        Return "Obsoleted From Windows XP Onward"
                    Else
                        Return CastToString(ManagementDateTimeConverter.ToDateTime(CastToString(wmiData, "")), "")
                    End If

                Case "UpgradeMethod" ' Win32_Processor.
                    Dim list As String() = {"Other", "Unknown", "Daughter Board", "ZIF Socket", "Replacement or Piggy Back", "None", "LIF Socket", _
                                            "Slot 1", "Slot 2", "370 Pin Socket", "Slot A", "Slot M", "Socket 423", "Socket A (Socket 462)", _
                                            "Socket 478", "Socket 754", "Socket 940", "Socket 939"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "VideoArchitecture" ' Win32_VideoController.
                    Dim list As String() = {"Other", "Unknown", "CGA", "EGA", "VGA", "SVGA", "MDA", _
                                            "HGC", "MCGA", "8514A", "XGA", "Linear Frame Buffer", "PC-98"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "VideoMemoryType" ' Win32_VideoController.
                    Dim list As String() = {"Other", "Unknown", "VRAM", "DRAM", "SRAM", "WRAM", "EDO RAM", _
                                            "Burst Synchronous DRAM", "Pipelined Burst SRAM", "CDRAM", "3DRAM", "SDRAM", "SGRAM"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")

                Case "WritePolicy" ' CIM_CacheMemory.
                    Dim list As String() = {"Other", "Unknown", "Write Back", "Write Through", "Varies with Address", "Determination Per I/O"}
                    Return EnumeratePropertyList(wmiData, list, -1, "")
            End Select

            ' Return the property's data unformatted if it's not in our list.
            Return CastToString(wmiData, "")

        End Function

        ' Used to convert a string array into one concatenated string.
        Private Shared Function ConcatStringArray(ByVal stringArray As String()) As String

            Dim tmp As String = ""
            For Each sa As String In stringArray
                tmp += sa & " "
            Next
            Return tmp

        End Function

        Private Shared Sub AddListViewItem(ByVal listViewCtrl As ListView, ByVal lvi As ListViewItem)
            listViewCtrl.Items.Add(lvi)
        End Sub

        Private Shared Function AddListViewItemGroup(ByVal listViewCtrl As ListView, ByVal key As String, ByVal header As String) As ListViewGroup
            Return listViewCtrl.Groups.Add(key, header)
        End Function

        Private Shared Sub AddListViewGroupStringArray(ByVal groupName As String, ByVal value As Object, ByVal listViewCtrl As ListView)

            Dim lvGroup As ListViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                                {listViewCtrl, groupName, groupName}), ListViewGroup)

            Dim stringArray As String() = CType(value, String())

            For Each [string] As String In stringArray
                Dim lvGroupItem As New ListViewItem(lvGroup)

                lvGroupItem.SubItems.Add([string])
                listViewCtrl.Invoke(New AddItem(AddressOf AddListViewItem), New Object() {listViewCtrl, lvGroupItem})
            Next

        End Sub

        Private Shared Sub AddListViewGroupUInt16Array(ByVal groupName As String, ByVal value As Object, ByVal valueArray As String(), ByVal listViewCtrl As ListView)

            Dim lvGroup As ListViewGroup = CType(listViewCtrl.Invoke(New AddItemGroup(AddressOf AddListViewItemGroup), New Object() _
                                                {listViewCtrl, groupName, groupName}), ListViewGroup)

            Dim UInt16Array As UInt16() = CType(value, UInt16())

            For Each [UInt16] As UInt16 In UInt16Array
                Dim lvGroupItem As New ListViewItem(lvGroup)

                lvGroupItem.SubItems.Add(valueArray([UInt16]))
                listViewCtrl.Invoke(New AddItem(AddressOf AddListViewItem), New Object() {listViewCtrl, lvGroupItem})
            Next

        End Sub

    End Class

End Namespace

