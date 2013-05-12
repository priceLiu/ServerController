Option Strict On
Option Explicit On

Imports SysInfo.Wmi

Public Class UserControlOS

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetOperatingSystemInformation()

    End Sub


    Private Sub GetOperatingSystemInformation()

        Dim osEdition As String = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "Caption")
        Dim osArchitecture As String = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "OSArchitecture")
        Dim osServicePack As String = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "CSDVersion")

        ' We do this for the benefit of Windows XP as they don't report the OS Architecture through WMI.
        If osArchitecture = notAvailable Then
            If osEdition.Contains("x64") Then
                osArchitecture = "64-Bit"
            Else
                osArchitecture = "32-Bit"
            End If
        End If

        If osServicePack <> notAvailable Then
            osEdition += " - " & osServicePack
        End If

        lblOSEdition.Text = osEdition
        lblOSVersion.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "Version") & " (Build " & Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "BuildNumber") & ")"

        lblOSPlatform.Text = osArchitecture
        lblOSRole.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "ProductType")
        lblOSEncryptionLevel.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "EncryptionLevel")
        lblOSSystemDir.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "SystemDirectory")
        lblOSWindowsDir.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "WindowsDirectory")
        lblOSBootDevice.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "SystemDevice")
        lblOSSerialNumber.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "SerialNumber")
        lblOSProductKey.Text = Misc.GetProductKey("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\")
        lblOSInstallationDate.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "InstallDate")
        lblOSRegUser.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "RegisteredUser")
        lblOSOrganisation.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "Organization")
        lblOSBuildType.Text = Win32ClassInfo.GetClassProperty("Win32_OperatingSystem", "BuildType")

        ' Display the OS logo on the OS page.
        Select Case FormMain.OSVersion
            Case "5.0"
                pctOSLogo.BackgroundImage = My.Resources.windows_2000_logo

            Case "5.1"
                pctOSLogo.BackgroundImage = My.Resources.windows_xp_logo

            Case "5.2" ' Applies to Windows XP x64 AND Windows Server 2003! Therefore, we need an additional test.
                If osEdition.Contains("XP") Then
                    pctOSLogo.BackgroundImage = My.Resources.windows_xp_logo
                Else
                    pctOSLogo.BackgroundImage = My.Resources.Windows_2003_logo
                End If

            Case "6.0"
                pctOSLogo.BackgroundImage = My.Resources.windows_vista_logo

            Case "6.1"
                pctOSLogo.BackgroundImage = My.Resources.win7_logo
        End Select

    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        newReport.WriteItem("Edition", lblOSEdition.Text)
        newReport.WriteItem("Version", lblOSVersion.Text)
        newReport.WriteItem("Architecture", lblOSPlatform.Text)
        newReport.WriteItem("Product Type", lblOSRole.Text)
        newReport.WriteItem("Encryption Level", lblOSEncryptionLevel.Text)
        newReport.WriteItem("System Directory", lblOSSystemDir.Text)
        newReport.WriteItem("Boot Device", lblOSBootDevice.Text)
        newReport.WriteItem("Windows Directory", lblOSWindowsDir.Text)
        newReport.WriteItem("Serial Number", lblOSSerialNumber.Text)
        newReport.WriteItem("Product Key", lblOSProductKey.Text)
        newReport.WriteItem("Installation Date", lblOSInstallationDate.Text)
        newReport.WriteItem("Registered User", lblOSRegUser.Text)
        newReport.WriteItem("Organisation", lblOSOrganisation.Text)
        newReport.WriteItem("Build Type", lblOSBuildType.Text)

    End Sub

End Class
