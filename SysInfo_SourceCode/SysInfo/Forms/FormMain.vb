Option Strict On
Option Explicit On

Imports System.Globalization
Imports Microsoft.VisualBasic.Devices
Imports System.Environment

Public Class FormMain

    Dim userControlHome As UserControlHome
    Dim userControlOS As UserControlOS
    Dim userControlSystem As UserControlSystem
    Dim userControlMemory As UserControlMemory
    Dim userControlNetwork As UserControlNetwork
    Dim userControlVideo As UserControlVideo
    Dim userControlFolders As UserControlSpecialFolders
    Dim userControlEnv As UserControlEnvironmentVariables
    Dim userControlDetailed As UserControlDetailed
    Dim userControlStorage As UserControlStorage
    Dim userControlProcessor As UserControlProcessor
    Dim userControlDevices As UserControlDevices
    Dim userControlServices As UserControlServices
    Dim userControlProcesses As UserControlProcesses
    Dim userControlDrivers As UserControlDrivers

    Dim lastLabelClicked As LinkLabel
    Dim newReport As TextReport
    Dim IsAdministrator As Boolean = Misc.IsAdmin


#Region "Publicly Accessible Properties"

    Public Shared ReadOnly Property OSName() As String
        Get
            Dim ci As New ComputerInfo
            OSName = ci.OSFullName
        End Get
    End Property

    Public Shared ReadOnly Property OSVersion() As String

        ' Windows version numbers.
        ' Windows 95 = 4.0
        ' Windows 98 = 4.1
        ' Windows Millennium Edition = 4.9
        ' Windows 2000 = 5.0
        ' Windows XP = 5.1
        ' Windows server 2003 and R2 AND XP x64 = 5.2
        ' Windows Vista = 6.0
        ' Windows Server 2008 = 6.0
        ' Windows 7 = 6.1
        ' Windows server 2008 R2 = 6.1

        Get
            OSVersion = Environment.OSVersion.Version.Major.ToString(CultureInfo.InvariantCulture) _
            & "." & Environment.OSVersion.Version.Minor.ToString(CultureInfo.InvariantCulture)
        End Get
    End Property

    Public Shared ReadOnly Property OSArchitecture() As String

        ' Determine whether we are running on a 32 or 64 bit OS.

        ' You would have thought Microsoft would have introduced a proper 
        ' method for determining the OS architecture when they first released
        ' a 64-bit OS. On Vista and upwards, the WMI can be consulted to 
        ' determine OS architecture. However, we use this method instead.
        Get
            Select Case IntPtr.Size
                Case 4
                    OSArchitecture = "x86"
                Case 8
                    OSArchitecture = "x64"
                Case Else
                    ' x128? 
                    OSArchitecture = "Not Known"
            End Select
        End Get
    End Property

    Public ReadOnly Property TextReportFile() As TextReport
        Get
            Return newReport
        End Get
    End Property

#End Region

    Public Sub New()

        InitializeComponent()

        ' We check here whether the user logged on has Administrator Group membership.
        ' We need admin rights to be able to access various registry keys and other system areas.
        ' If we haven't got admin rights, then its time to go.

        If Not IsAdministrator Then

            MessageBox.Show("This program requires the user to have administrative privileges to function correctly. " & _
                            vbNewLine & vbNewLine & "Please logon as a member of the Administrators Group to run this program.", _
                            "Administrative Privileges Required.", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            ' Initialise user controls and collect the information.
            FormSplash.Status("Retrieving Operating System Information")
            userControlOS = New UserControlOS

            FormSplash.Status("Retrieving System Information")
            userControlSystem = New UserControlSystem

            FormSplash.Status("Retrieving Memory Information")
            userControlMemory = New UserControlMemory

            FormSplash.Status("Retrieving Network Information")
            userControlNetwork = New UserControlNetwork

            FormSplash.Status("Retrieving Video Information")
            userControlVideo = New UserControlVideo

            FormSplash.Status("Retrieving Special Folder Locations")
            userControlFolders = New UserControlSpecialFolders

            FormSplash.Status("Retrieving Environment Variables")
            userControlEnv = New UserControlEnvironmentVariables

            FormSplash.Status("Retrieving Disk Information")
            userControlStorage = New UserControlStorage

            FormSplash.Status("Retrieving Processor Information")
            userControlProcessor = New UserControlProcessor

            FormSplash.Status("Retrieving Device Information")
            userControlDevices = New UserControlDevices

            FormSplash.Status("Retrieving Services Information")
            userControlServices = New UserControlServices

            FormSplash.Status("Retrieving Processes Information")
            userControlProcesses = New UserControlProcesses

            FormSplash.Status("Retrieving System && Device Driver Information")
            userControlDrivers = New UserControlDrivers

            FormSplash.Status("Retrieving Detailed Information")
            userControlDetailed = New UserControlDetailed

            FormSplash.Status("Loading Main Form")
            userControlHome = New UserControlHome

            ' Display the operating system and architecture on the 'home' form. 
            userControlHome.lblOS.Text = OSName

            ' Display any errors that occured during data collection to the user.

            ErrorList.DisplayErrorList()

        End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsAdministrator Then
            lastLabelClicked = LinkLabelHome
            LinkLabelHome.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)
            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlHome)
        Else
            Me.Close()
        End If

    End Sub


    Private Sub LinkLabelOS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelOS.LinkClicked

        If Not pnlUserCtrls.Contains(userControlOS) Then
            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelOS

            LinkLabelOS.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlOS)
        End If

    End Sub

    Private Sub LinkLabelSystem_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelSystem.LinkClicked

        If Not pnlUserCtrls.Contains(userControlSystem) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelSystem

            LinkLabelSystem.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlSystem)

        End If

    End Sub

    Private Sub LinkLabelMemory_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelMemory.LinkClicked

        If Not pnlUserCtrls.Contains(userControlMemory) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelMemory

            LinkLabelMemory.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlMemory)

        End If

    End Sub

    Private Sub LinkLabelNetwork_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelNetwork.LinkClicked

        If Not pnlUserCtrls.Contains(userControlNetwork) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelNetwork

            LinkLabelNetwork.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlNetwork)

        End If

    End Sub

    Private Sub LinkLabelVideo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelVideo.LinkClicked

        If Not pnlUserCtrls.Contains(userControlVideo) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelVideo

            LinkLabelVideo.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlVideo)

        End If

    End Sub

    Private Sub LinkLabelSpecialFolders_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelSpecialFolders.LinkClicked

        If Not pnlUserCtrls.Contains(userControlFolders) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelSpecialFolders

            LinkLabelSpecialFolders.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlFolders)

        End If

    End Sub

    Private Sub LinkLabelEnvVariables_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelEnvVariables.LinkClicked

        If Not pnlUserCtrls.Contains(userControlEnv) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelEnvVariables

            LinkLabelEnvVariables.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlEnv)

        End If

    End Sub

    Private Sub LinkLabelDetailed_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelDetailed.LinkClicked

        If Not pnlUserCtrls.Contains(userControlDetailed) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelDetailed

            LinkLabelDetailed.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlDetailed)
        End If

    End Sub

    Private Sub LinkLabelStorage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelStorage.LinkClicked

        If Not pnlUserCtrls.Contains(userControlStorage) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelStorage

            LinkLabelStorage.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlStorage)

        End If

    End Sub

    Private Sub LinkLabelHome_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelHome.LinkClicked

        If Not pnlUserCtrls.Contains(userControlHome) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelHome

            LinkLabelHome.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlHome)
        End If

    End Sub

    Private Sub LinkLabelProcessor_LinkClicked(ByVal sender As System.Object, _
                                               ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) _
                                               Handles LinkLabelProcessor.LinkClicked

        If Not pnlUserCtrls.Contains(userControlProcessor) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelProcessor

            LinkLabelProcessor.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlProcessor)

        End If

    End Sub

    Private Sub LinkLabelDevices_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelDevices.LinkClicked

        If Not pnlUserCtrls.Contains(userControlDevices) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelDevices

            LinkLabelDevices.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlDevices)

        End If

    End Sub

    Private Sub LinkLabelServices_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelServices.LinkClicked

        If Not pnlUserCtrls.Contains(userControlServices) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelServices

            LinkLabelServices.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlServices)

        End If

    End Sub

    Private Sub LinkLabelProcesses_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelProcesses.LinkClicked

        If Not pnlUserCtrls.Contains(userControlProcesses) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelProcesses

            LinkLabelProcesses.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlProcesses)

        End If

    End Sub

    Private Sub LinkLabelDrivers_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelDrivers.LinkClicked

        If Not pnlUserCtrls.Contains(userControlDrivers) Then

            lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
            lastLabelClicked = LinkLabelDrivers

            LinkLabelDrivers.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

            pnlUserCtrls.Controls.Clear()
            pnlUserCtrls.Controls.Add(userControlDrivers)
        End If

    End Sub

    ' Format the text report and gather the information.
    Private Sub LinkLabelReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelReport.LinkClicked

        lastLabelClicked.Font = New Font("Tahoma", 9.0, FontStyle.Regular, GraphicsUnit.Point)
        lastLabelClicked = LinkLabelReport

        LinkLabelReport.Font = New Font("Tahoma", 9.0, FontStyle.Bold, GraphicsUnit.Point)

        ' Write the text report.
        SaveFileDialog.Title = "Select or enter a file name for the report."
        SaveFileDialog.Filter = "txt file|*.txt"
        SaveFileDialog.OverwritePrompt = True
        SaveFileDialog.ShowDialog()

        Dim reportFile As String = SaveFileDialog.FileName
        If reportFile = "" Then Exit Sub

        newReport = New TextReport(reportFile)

        If newReport.Success Then

            newReport.WriteSubtitle("*** Operating System ***")
            userControlOS.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** Computer System ***")
            userControlSystem.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** Hardware ***")

            ' Processor.
            userControlProcessor.CollectReportData()

            ' Memory.
            newReport.WriteSubtitle("")
            userControlMemory.CollectReportData()

            ' Video.
            newReport.WriteSubtitle("")
            userControlVideo.CollectReportData()

            ' Devices.
            newReport.WriteSubtitle("")
            userControlDevices.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** System Drivers ***")
            userControlDrivers.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** Environment Variables ***")
            userControlEnv.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** Services ***")
            userControlServices.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** Networking ***")
            userControlNetwork.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** System Processes ***")
            userControlProcesses.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** Spcecial Folders ***")
            userControlFolders.CollectReportData()

            newReport.WriteSubtitle("")

            newReport.WriteSubtitle("*** Storage Devices ***")
            userControlStorage.CollectReportData()

            newReport.WriteTextToFile()
            MsgBox("Report Successfully Written To File.", MsgBoxStyle.Information)
        Else
            MsgBox("An Error Occurred Creating The Report.", MsgBoxStyle.Critical)
        End If

    End Sub

End Class
