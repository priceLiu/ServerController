Option Strict On
Option Explicit On

Imports System.Management
Imports System.Windows.Forms


Structure DesktopMonitor
    Dim Manufacturer As String
    Dim ModelName As String
    Dim ScreenHeight As String
    Dim ScreenWidth As String
    Dim PixelsX As String
    Dim PixelsY As String
End Structure

Structure VideoCard
    Dim Manufacturer As String
    Dim Chipset As String
    Dim Memory As String
    Dim Model As String
    Dim ColourDepth As String
    Dim DriverVersion As String
    Dim RefreshRate As String
    Dim ScanMode As String
End Structure


Public Class UserControlVideo

    Dim monitorCount As Integer
    Dim videoCount As Integer

    Dim desktopMonitors() As DesktopMonitor
    Dim videoCards() As VideoCard

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetVideoInformation()
        GetMonitorInformation()

    End Sub

    Private Sub GetVideoInformation()

        Dim mc As New ManagementClass("Win32_VideoController")
        Dim Win32_VideoControllerProperties() As String = {"AdapterCompatibility", "Caption", "VideoProcessor", "CurrentBitsPerPixel", _
                                                           "DriverVersion", "AdapterRAM", "CurrentRefreshRate", "CurrentScanMode"}
        Dim propertyIndex As Integer

        Try
            For Each obj As ManagementObject In mc.GetInstances()

                ReDim Preserve videoCards(videoCount)

                ' Initialise 
                videoCards(videoCount).Manufacturer = notAvailable
                videoCards(videoCount).Model = notAvailable
                videoCards(videoCount).Chipset = notAvailable
                videoCards(videoCount).ColourDepth = notAvailable
                videoCards(videoCount).DriverVersion = notAvailable
                videoCards(videoCount).Memory = notAvailable
                videoCards(videoCount).RefreshRate = notAvailable
                videoCards(videoCount).ScanMode = notAvailable

                propertyIndex = 0
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).Manufacturer = obj(Win32_VideoControllerProperties(propertyIndex)).ToString
                End If

                propertyIndex = 1
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).Model = obj(Win32_VideoControllerProperties(propertyIndex)).ToString
                End If

                propertyIndex = 2
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).Chipset = obj(Win32_VideoControllerProperties(propertyIndex)).ToString
                End If

                propertyIndex = 3
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).ColourDepth = Wmi.Win32ClassInfo.FormatWmiData("Win32_VideoController", _
                                                         Win32_VideoControllerProperties(propertyIndex), obj(Win32_VideoControllerProperties(propertyIndex)))
                End If

                propertyIndex = 4
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).DriverVersion = obj(Win32_VideoControllerProperties(propertyIndex)).ToString
                End If

                propertyIndex = 5
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).Memory = Wmi.Win32ClassInfo.FormatWmiData("Win32_VideoController", _
                                                    Win32_VideoControllerProperties(propertyIndex), obj(Win32_VideoControllerProperties(propertyIndex)))
                End If

                propertyIndex = 6
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).RefreshRate = Wmi.Win32ClassInfo.FormatWmiData("Win32_VideoController", _
                                                         Win32_VideoControllerProperties(propertyIndex), obj(Win32_VideoControllerProperties(propertyIndex)))
                End If

                propertyIndex = 7
                If obj(Win32_VideoControllerProperties(propertyIndex)) IsNot Nothing Then
                    videoCards(videoCount).ScanMode = Wmi.Win32ClassInfo.FormatWmiData("Win32_VideoController", _
                                                      Win32_VideoControllerProperties(propertyIndex), obj(Win32_VideoControllerProperties(propertyIndex)))
                End If

                cmbVideoCards.Items.Add(videoCards(videoCount).Model.ToString)

                videoCount += 1
            Next
        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, mc.ClassPath.ClassName(), Win32_VideoControllerProperties(propertyIndex))
            Exit Sub
        End Try

        cmbVideoCards.Text = videoCards(0).Model
        cmbVideoCards.SelectedItem = 0

    End Sub

    Private Sub GetMonitorInformation()

        Dim mc As New ManagementClass("Win32_DesktopMonitor")
        Dim Win32_DesktopMonitorProperties() As String = {"MonitorType", "MonitorManufacturer", "ScreenHeight", "ScreenWidth", _
                                                          "PixelsPerXLogicalInch", "PixelsPerYLogicalInch"}
        Dim propertyIndex As Integer

        Try
            For Each obj As ManagementObject In mc.GetInstances()

                ReDim Preserve desktopMonitors(monitorCount)

                desktopMonitors(monitorCount).ModelName = notAvailable
                desktopMonitors(monitorCount).Manufacturer = notAvailable
                desktopMonitors(monitorCount).ScreenHeight = notAvailable
                desktopMonitors(monitorCount).ScreenWidth = notAvailable
                desktopMonitors(monitorCount).PixelsX = notAvailable
                desktopMonitors(monitorCount).PixelsY = notAvailable

                propertyIndex = 0
                If obj(Win32_DesktopMonitorProperties(propertyIndex)) IsNot Nothing Then
                    desktopMonitors(monitorCount).ModelName = obj(Win32_DesktopMonitorProperties(propertyIndex)).ToString
                End If

                propertyIndex = 1
                If obj(Win32_DesktopMonitorProperties(propertyIndex)) IsNot Nothing Then
                    desktopMonitors(monitorCount).Manufacturer = obj(Win32_DesktopMonitorProperties(propertyIndex)).ToString
                End If

                propertyIndex = 2
                If obj(Win32_DesktopMonitorProperties(propertyIndex)) IsNot Nothing Then
                    desktopMonitors(monitorCount).ScreenHeight = obj(Win32_DesktopMonitorProperties(propertyIndex)).ToString & " Pixels"
                End If

                propertyIndex = 3
                If obj(Win32_DesktopMonitorProperties(propertyIndex)) IsNot Nothing Then
                    desktopMonitors(monitorCount).ScreenWidth = obj(Win32_DesktopMonitorProperties(propertyIndex)).ToString & " Pixels"
                End If

                propertyIndex = 4
                If obj(Win32_DesktopMonitorProperties(propertyIndex)) IsNot Nothing Then
                    desktopMonitors(monitorCount).PixelsX = obj(Win32_DesktopMonitorProperties(propertyIndex)).ToString
                End If

                propertyIndex = 5
                If obj(Win32_DesktopMonitorProperties(propertyIndex)) IsNot Nothing Then
                    desktopMonitors(monitorCount).PixelsY = obj(Win32_DesktopMonitorProperties(propertyIndex)).ToString
                End If

                cmbMonitors.Items.Add(desktopMonitors(monitorCount).ModelName.ToString)

                monitorCount += 1
            Next

        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, mc.ClassPath.ClassName(), Win32_DesktopMonitorProperties(propertyIndex))
            Exit Sub
        End Try

        cmbMonitors.Text = desktopMonitors(0).ModelName
        cmbMonitors.SelectedItem = 0

    End Sub

    Private Sub cmbMonitors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonitors.SelectedIndexChanged

        lblMonitorManufacturer.Text = desktopMonitors(cmbMonitors.SelectedIndex).Manufacturer
        lblMonitorName.Text = desktopMonitors(cmbMonitors.SelectedIndex).ModelName

        lblVideoHorizontalRes.Text = desktopMonitors(cmbMonitors.SelectedIndex).ScreenWidth
        lblVideoVerticalRes.Text = desktopMonitors(cmbMonitors.SelectedIndex).ScreenHeight

        lblVideoPixelsX.Text = desktopMonitors(cmbMonitors.SelectedIndex).PixelsX
        lblVideoPixelsY.Text = desktopMonitors(cmbMonitors.SelectedIndex).PixelsY

    End Sub

    Private Sub cmbVideoCards_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVideoCards.SelectedIndexChanged

        lblVideoManufacturer.Text = videoCards(cmbVideoCards.SelectedIndex).Manufacturer
        lblVideoCard.Text = videoCards(cmbVideoCards.SelectedIndex).Model
        lblVideoMem.Text = videoCards(cmbVideoCards.SelectedIndex).Memory

        lblVideoColourDepth.Text = videoCards(cmbVideoCards.SelectedIndex).ColourDepth
        lblVideoRefreshRate.Text = videoCards(cmbVideoCards.SelectedIndex).RefreshRate

        lblVideoScanMode.Text = videoCards(cmbVideoCards.SelectedIndex).ScanMode
        lblVideoDriverVersion.Text = videoCards(cmbVideoCards.SelectedIndex).DriverVersion

    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        newReport.WriteSubtitle(vbTab & "[Monitor]")

        For n As Integer = 0 To monitorCount - 1
            newReport.WriteItem("Manufacturer", desktopMonitors(n).Manufacturer)
            newReport.WriteItem("Model", desktopMonitors(n).ModelName)
            newReport.WriteItem("Horizontal Resolution", desktopMonitors(n).ScreenWidth)
            newReport.WriteItem("Vertical Resolution", desktopMonitors(n).ScreenHeight)
            newReport.WriteItem("Pixels Per Inch X", desktopMonitors(n).PixelsX)
            newReport.WriteItem("Pixels Per Inch Y", desktopMonitors(n).PixelsY)
        Next

        newReport.WriteSubtitle("")
        newReport.WriteSubtitle(vbTab & "[Graphics Card]")

        For n As Integer = 0 To videoCount - 1
            newReport.WriteItem("Manufacturer", videoCards(n).Manufacturer)
            newReport.WriteItem("Model", videoCards(n).Model)
            newReport.WriteItem("Driver Version", videoCards(n).DriverVersion)
            newReport.WriteItem("Video Memory", videoCards(n).Memory)
            newReport.WriteItem("Colour Depth", videoCards(n).ColourDepth)
            newReport.WriteItem("Refresh Rate", videoCards(n).RefreshRate)
            newReport.WriteItem("Scan Mode", videoCards(n).ScanMode)
        Next
    End Sub
End Class
