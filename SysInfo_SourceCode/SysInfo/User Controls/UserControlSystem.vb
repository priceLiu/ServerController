Option Strict On
Option Explicit On

Imports System.IO
Imports System.Globalization
Imports System.Management
Imports SysInfo.Wmi

Public Class UserControlSystem

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetSystemInformation()

    End Sub

    Private Sub GetSystemInformation()

        ' Display an OEM Logo image if one exists.
        Dim OEMLogoFile As String = CType(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", 0), String)

        If OEMLogoFile <> "0" AndAlso File.Exists(OEMLogoFile) Then
            pctOEMBitmap.ImageLocation = OEMLogoFile
        Else
            pctOEMBitmap.BackgroundImage = My.Resources.computer
        End If

        lblMoBoMake.Text = Win32ClassInfo.GetClassProperty("Win32_BaseBoard", "Manufacturer")
        lblMoBoModel.Text = Win32ClassInfo.GetClassProperty("Win32_BaseBoard", "Product")
        lblMoBoRevision.Text = Win32ClassInfo.GetClassProperty("Win32_BaseBoard", "Version")
        lblMoBoSerialNumber.Text = Win32ClassInfo.GetClassProperty("Win32_BaseBoard", "SerialNumber")

        lblBiosMake.Text = Win32ClassInfo.GetClassProperty("Win32_BIOS", "Manufacturer")
        lblSMBiosVersion.Text = Win32ClassInfo.GetClassProperty("Win32_BIOS", "SMBIOSBIOSVersion")
        lblBiosDate.Text = Win32ClassInfo.GetClassProperty("Win32_BIOS", "ReleaseDate")
        lblBiosVersion.Text = Win32ClassInfo.GetClassProperty("Win32_BIOS", "Version")

        lblSysProcesses.Text = Win32ClassInfo.GetClassProperty("Win32_PerfRawData_PerfOS_System", "Processes")
        lblSysThreads.Text = Win32ClassInfo.GetClassProperty("Win32_PerfRawData_PerfOS_System", "Threads")

        lblSysUUID.Text = Win32ClassInfo.GetClassProperty("Win32_ComputerSystemProduct", "UUID")
        lblSysIdentifier.Text = Win32ClassInfo.GetClassProperty("Win32_ComputerSystemProduct", "IdentifyingNumber")
        lblSysName.Text = Win32ClassInfo.GetClassProperty("Win32_ComputerSystemProduct", "Name")
        lblSysVendor.Text = Win32ClassInfo.GetClassProperty("Win32_ComputerSystemProduct", "Vendor")
        lblSysVersion.Text = Win32ClassInfo.GetClassProperty("Win32_ComputerSystemProduct", "Version")

        lblSysLastBoot.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "LastBootUpTime")
        lblSysPrinter.Text = GetDefaultPrinter()
        lblSysUptime.Text = Win32ClassInfo.GetClassProperty("Win32_PerfFormattedData_PerfOS_System", "SystemUpTime")

        ' Display BIOS manufacturer logo.
        If lblBiosMake.Text.ToLower(CultureInfo.CurrentCulture).Contains("american megatrends") Or lblBiosMake.Text.ToLower(CultureInfo.CurrentCulture).Contains("ami") Then
            pctBiosMake.BackgroundImage = My.Resources.AmiBios

        ElseIf lblBiosMake.Text.ToLower(CultureInfo.CurrentCulture).Contains("phoenix") Then
            pctBiosMake.BackgroundImage = My.Resources.Phoenix

        ElseIf lblBiosMake.Text.ToLower(CultureInfo.CurrentCulture).Contains("insyde") Then
            pctBiosMake.BackgroundImage = My.Resources.insyde

        End If

    End Sub

    Private Shared Function GetDefaultPrinter() As String

        Dim defaultPrinter As String = notAvailable
        Try
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_Printer WHERE Default = TRUE")
            Dim queryCollection As ManagementObjectCollection = query.Get()

            For Each mo As ManagementObject In queryCollection
                defaultPrinter = mo("Name").ToString
            Next
        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, "Win32_Printer", "Getting Default Printer Info.")
        End Try

        Return defaultPrinter

    End Function

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        newReport.WriteSubtitle(vbTab & "[Motherboard]")
        newReport.WriteItem("Model", lblMoBoModel.Text)
        newReport.WriteItem("Manufacturer", lblMoBoMake.Text)
        newReport.WriteItem("Version", lblMoBoRevision.Text)
        newReport.WriteItem("Serial Number", lblMoBoSerialNumber.Text)

        newReport.WriteSubtitle("")

        newReport.WriteSubtitle(vbTab & "[BIOS]")
        newReport.WriteItem("Manufacturer", lblBiosMake.Text)
        newReport.WriteItem("Release Date", lblBiosDate.Text)
        newReport.WriteItem("Version", lblBiosVersion.Text)
        newReport.WriteItem("System Management Version", lblSMBiosVersion.Text)

        newReport.WriteSubtitle("")

        newReport.WriteSubtitle(vbTab & "[System]")
        newReport.WriteItem("Manufacturer", lblSysVendor.Text)
        newReport.WriteItem("Model", lblSysName.Text)
        newReport.WriteItem("Version", lblSysVersion.Text)
        newReport.WriteItem("Serial Number", lblSysIdentifier.Text)
        newReport.WriteItem("Universally Unique Identifer", lblSysUUID.Text)

        newReport.WriteSubtitle("")

        newReport.WriteSubtitle(vbTab & "[Miscellaneous]")
        newReport.WriteItem("Processes Snapshot", lblSysProcesses.Text & " Processes")
        newReport.WriteItem("Threads Snapshot", lblSysThreads.Text & " Threads")
        newReport.WriteItem("Last Boot Time", lblSysLastBoot.Text)
        newReport.WriteItem("System Uptime", lblSysUptime.Text)

        newReport.WriteSubtitle("")

        newReport.WriteSubtitle(vbTab & "[Default Printer]")
        newReport.WriteItem("Printer", lblSysPrinter.Text)

    End Sub

End Class
