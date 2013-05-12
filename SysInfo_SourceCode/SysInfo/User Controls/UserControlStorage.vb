Option Strict On
Option Explicit On

Imports System.Globalization.CultureInfo
Imports System.Management
Imports System.IO
Imports System.Text

Public Class UserControlStorage

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetDiskDriveInformation()
        GetCDDriveInformation()

    End Sub

    Private Structure DiskData
        Dim AvailableCapacity As Long
        Dim Caption As String
        Dim Capacity As Long
        Dim FirmwareRevision As String
        Dim Partitions As Integer
        Dim SerialNumber As String
        Dim InterfaceType As String
    End Structure

    Private Structure CDRomData
        Dim Name As String
        Dim DriveLetter As String
        Dim MediaLoaded As String
        Dim MediaType As String
    End Structure

    Dim diskList() As DiskData
    Dim cdList() As CDRomData

    Dim diskCount As Integer
    Dim cdCount As Integer

    Private Sub GetDiskDriveInformation()

        Dim wmi As New ManagementClass("Win32_DiskDrive")
        Dim Win32_DiskDriveProperties() As String = {"Caption", "FirmwareRevision", "Size", "Partitions", "SerialNumber", "InterfaceType"}
        Dim propertyIndex As Integer

        Try
            For Each obj As ManagementObject In wmi.GetInstances()

                ReDim Preserve diskList(diskCount)

                ' Get the disk information.
                propertyIndex = 0
                If obj(Win32_DiskDriveProperties(propertyIndex)) IsNot Nothing Then
                    diskList(diskCount).Caption = obj(Win32_DiskDriveProperties(propertyIndex)).ToString
                End If

                ' Firmware property isn't available before Windows Vista.
                propertyIndex = 1
                If CLng(FormMain.OSVersion) >= 6.0 Then
                    If obj(Win32_DiskDriveProperties(propertyIndex)) IsNot Nothing Then
                        diskList(diskCount).FirmwareRevision = obj(Win32_DiskDriveProperties(propertyIndex)).ToString
                    End If
                Else
                    diskList(diskCount).FirmwareRevision = notAvailable
                End If

                propertyIndex = 2
                If obj(Win32_DiskDriveProperties(propertyIndex)) IsNot Nothing Then
                    diskList(diskCount).Capacity = CType(obj(Win32_DiskDriveProperties(propertyIndex)), Long)
                End If

                propertyIndex = 3
                If obj(Win32_DiskDriveProperties(propertyIndex)) IsNot Nothing Then
                    diskList(diskCount).Partitions = CType(obj(Win32_DiskDriveProperties(propertyIndex)), Integer)
                End If

                ' Serial number property isn't available before Windows Vista.
                propertyIndex = 4
                If CLng(FormMain.OSVersion) >= 6.0 Then
                    If obj(Win32_DiskDriveProperties(propertyIndex)) IsNot Nothing Then
                        diskList(diskCount).SerialNumber = obj(Win32_DiskDriveProperties(propertyIndex)).ToString
                    End If
                Else
                    diskList(diskCount).SerialNumber = notAvailable
                End If

                propertyIndex = 5
                If obj(Win32_DiskDriveProperties(propertyIndex)) IsNot Nothing Then
                    diskList(diskCount).InterfaceType = obj(Win32_DiskDriveProperties(propertyIndex)).ToString
                End If

                diskCount += 1
            Next

        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, wmi.ClassPath.ClassName(), Win32_DiskDriveProperties(propertyIndex))
            Exit Sub
        End Try

        For n = 0 To diskCount - 1
            Dim lvi As New ListViewItem

            lvi.Text = diskList(n).Caption
            lvi.SubItems.Add((diskList(n).Capacity / (1024 ^ 3)).ToString("###0.###", InvariantCulture))
            lvi.SubItems.Add(diskList(n).Partitions.ToString(InvariantCulture))
            lvi.SubItems.Add(diskList(n).SerialNumber)
            lvi.SubItems.Add(diskList(n).FirmwareRevision)

            If diskList(n).InterfaceType <> "USB" Then
                lstPhysicalDisks.Items.Add(lvi)
            ElseIf diskList(n).InterfaceType = "USB" Then
                lstUSBDisks.Items.Add(lvi)
            End If
        Next

    End Sub

    Private Sub GetCDDriveInformation()

        Dim wmi As New ManagementClass("Win32_CDROMDrive")
        Dim Win32_CDROMDriveProperties() As String = {"Caption", "Drive", "MediaLoaded", "MediaType"}
        Dim propertyIndex As Integer

        Try
            For Each obj As ManagementObject In wmi.GetInstances()

                ReDim Preserve cdList(cdCount)

                ' Get the disk information.
                propertyIndex = 0
                If obj(Win32_CDROMDriveProperties(propertyIndex)) IsNot Nothing Then
                    cdList(cdCount).Name = obj(Win32_CDROMDriveProperties(propertyIndex)).ToString
                End If

                propertyIndex = 1
                If obj(Win32_CDROMDriveProperties(propertyIndex)) IsNot Nothing Then
                    cdList(cdCount).DriveLetter = obj(Win32_CDROMDriveProperties(propertyIndex)).ToString
                End If

                propertyIndex = 2
                If obj(Win32_CDROMDriveProperties(propertyIndex)) IsNot Nothing Then
                    cdList(cdCount).MediaLoaded = obj(Win32_CDROMDriveProperties(propertyIndex)).ToString
                End If

                propertyIndex = 3
                If obj(Win32_CDROMDriveProperties(propertyIndex)) IsNot Nothing Then
                    cdList(cdCount).MediaType = obj(Win32_CDROMDriveProperties(propertyIndex)).ToString
                End If

                cdCount += 1
            Next

        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, wmi.ClassPath.ClassName(), Win32_CDROMDriveProperties(propertyIndex))
            Exit Sub
        End Try

        For n = 0 To cdCount - 1
            Dim lvi As New ListViewItem

            lvi.Text = cdList(n).Name
            lvi.SubItems.Add(cdList(n).DriveLetter)
            lvi.SubItems.Add(cdList(n).MediaLoaded)
            lvi.SubItems.Add(cdList(n).MediaType)

            lstCDDrives.Items.Add(lvi)
        Next
    End Sub


    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        newReport.WriteSubtitle(vbTab & "[Disk & USB Drives]")

        For n As Integer = 0 To diskCount - 1
            newReport.WriteItem("Model", diskList(n).Caption)
            newReport.WriteItem("Capacity", (diskList(n).Capacity / (1024 ^ 3)).ToString("###0.### GBytes", InvariantCulture))
            newReport.WriteItem("Interface", diskList(n).InterfaceType)
            newReport.WriteItem("Firmware Revision", diskList(n).FirmwareRevision)
            newReport.WriteItem("Partitions", diskList(n).Partitions.ToString(InvariantCulture))
            newReport.WriteItem("Serial Number", diskList(n).SerialNumber)

            newReport.WriteSubtitle("")
        Next

        newReport.WriteSubtitle(vbTab & "[CD/DVD Drives]")

        For n = 0 To cdCount - 1
            newReport.WriteItem("Model", cdList(n).Name)
            newReport.WriteItem("Drive Letter", cdList(n).DriveLetter)
            newReport.WriteItem("Media Loaded", cdList(n).MediaLoaded)
            newReport.WriteItem("Drive Type", cdList(n).MediaType)
        Next

    End Sub

End Class
