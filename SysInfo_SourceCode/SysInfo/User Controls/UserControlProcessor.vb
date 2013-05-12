Option Strict On
Option Explicit On

Imports SysInfo.Wmi
Imports System.Management

Public Class UserControlProcessor

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetProcessorInformation()

    End Sub

    Private Sub GetProcessorInformation()

        lblCPUL1CacheSize.Text = RetrieveProcessorCacheInfo("L1")
        lblCPUL2CacheSize.Text = RetrieveProcessorCacheInfo("L2")
        lblCPUL3CacheSize.Text = RetrieveProcessorCacheInfo("L3")

        lblCPUVendor.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "Manufacturer")
        lblCPUName.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "Name")
        lblCPUIdent.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "Caption")
        lblCPUSocket.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "SocketDesignation")
        lblCPUArchitecture.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "Architecture")
        lblCPUCores.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "NumberOfCores")
        lblCPUMaxSpeed.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "MaxClockSpeed")
        lblCPUCurrentSpeed.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "CurrentClockSpeed")
        lblCPUExtClkSpeed.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "ExtClock")
        lblCPUDataWidth.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "DataWidth")
        lblCPUAddressWidth.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "AddressWidth")
        lblCPUVoltage.Text = Win32ClassInfo.GetClassProperty("Win32_Processor", "CurrentVoltage")

        ' Display CPU vendor logo on Processor page.
        If lblCPUVendor.Text.Contains("AMD") Then
            pctCPULogo.BackgroundImage = My.Resources.AMD_Logo
        ElseIf lblCPUVendor.Text.Contains("Intel") Then
            pctCPULogo.BackgroundImage = My.Resources.Intel_Logo
        Else
            pctCPULogo.BackgroundImage = My.Resources.cpu
        End If

    End Sub

    Private Shared Function RetrieveProcessorCacheInfo(ByVal cache As String) As String

        ' Gets the processor cache information for the specified cache level.

        Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_CacheMemory Where InstalledSize > 0")
        Dim queryCollection As ManagementObjectCollection = query.Get()

        Dim cacheSize As String = notAvailable
        Dim purpose As String

        Try
            For Each mo As ManagementObject In queryCollection
                If mo("Purpose") IsNot Nothing Then
                    purpose = mo("Purpose").ToString

                    If purpose.Contains(cache) Then
                        cacheSize = mo("InstalledSize").ToString & " KBytes"
                        Exit For
                    End If

                End If
            Next
        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, "Win32_CacheMemory", "Getting Processor Cache Info for: " & cache)
        End Try

        Return cacheSize

    End Function

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        newReport.WriteSubtitle(vbTab & "[Processor]")
        newReport.WriteItem("Processor", lblCPUName.Text)
        newReport.WriteItem("Manufacturer", lblCPUVendor.Text)
        newReport.WriteItem("Indentifier", lblCPUIdent.Text)
        newReport.WriteItem("Socket Designation", lblCPUSocket.Text)
        newReport.WriteItem("Architecture", lblCPUArchitecture.Text)
        newReport.WriteItem("Cores", lblCPUCores.Text)
        newReport.WriteItem("Data Width", lblCPUDataWidth.Text)
        newReport.WriteItem("Address Width", lblCPUAddressWidth.Text)
        newReport.WriteItem("L1 Cache Size", lblCPUL1CacheSize.Text)
        newReport.WriteItem("L2 Cache Size", lblCPUL2CacheSize.Text)
        newReport.WriteItem("L3 Cache Size", lblCPUL3CacheSize.Text)
        newReport.WriteItem("Max Speed", lblCPUMaxSpeed.Text)
        newReport.WriteItem("Current Speed", lblCPUCurrentSpeed.Text)
        newReport.WriteItem("External Clock Speed", lblCPUExtClkSpeed.Text)
        newReport.WriteItem("Core Voltage", lblCPUVoltage.Text)

    End Sub

End Class
