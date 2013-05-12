Option Strict On
Option Explicit On

Imports System.Management
Imports Microsoft.Win32

Public Class UserControlDevices

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetDevices()

    End Sub

    Private Structure DeviceData
        Dim Category As String
        Dim ClassGuid As String
        Dim DeviceId As String
        Dim DriverPath As String
        Dim DriverVersion As String
        Dim Manufacturer As String
        Dim Name As String
        Dim Service As String
    End Structure

    Dim deviceList() As DeviceData
    Dim deviceCount As Integer

    Private Sub GetDevices()

        Dim wmi As New ManagementClass("Win32_PnPEntity")

        Dim HKLM As RegistryKey = Registry.LocalMachine
        Dim HKLM_DeviceClass As RegistryKey = HKLM.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class")

        Dim key As RegistryKey
        Dim device As New DeviceData

        Dim Win32_PnPEntityProperties() As String = {"ClassGUID", "DeviceID", "Manufacturer", "Name", "Service"}
        Dim propertyIndex As Integer

        Try

            For Each obj As ManagementObject In wmi.GetInstances()

                ReDim Preserve deviceList(deviceCount)

                propertyIndex = 0
                If obj(Win32_PnPEntityProperties(propertyIndex)) IsNot Nothing Then
                    device.ClassGuid = obj(Win32_PnPEntityProperties(propertyIndex)).ToString
                End If

                ' Filter out non-plug and play hardware.
                If device.ClassGuid <> "{8ECC055D-047F-11D1-A537-0000F8753ED1}" Then

                    propertyIndex = 1
                    If obj(Win32_PnPEntityProperties(propertyIndex)) IsNot Nothing Then
                        device.DeviceId = obj(Win32_PnPEntityProperties(propertyIndex)).ToString
                    End If

                    propertyIndex = 2
                    If obj(Win32_PnPEntityProperties(propertyIndex)) IsNot Nothing Then
                        device.Manufacturer = obj(Win32_PnPEntityProperties(propertyIndex)).ToString
                    End If

                    propertyIndex = 3
                    If obj(Win32_PnPEntityProperties(propertyIndex)) IsNot Nothing Then
                        device.Name = obj(Win32_PnPEntityProperties(propertyIndex)).ToString
                    End If
                    device.DriverPath = notAvailable

                    propertyIndex = 4
                    If obj(Win32_PnPEntityProperties(propertyIndex)) IsNot Nothing Then
                        device.Service = obj(Win32_PnPEntityProperties(propertyIndex)).ToString
                    Else
                        device.Service = notAvailable
                    End If

                    ' Get the associated driver for the device in question.
                    Try
                        For Each related In obj.GetRelated("Win32_SystemDriver")
                            If related("PathName") IsNot Nothing Then
                                device.DriverPath = related("PathName").ToString
                            End If
                        Next
                    Catch ex As ManagementException
                        ErrorList.AddErrorToList(ex.Message, "Win32_SystemDriver", "PathName")
                    End Try

                    ' Get the device category from the registry: HKEY_LM\SYSTEM\CurrentControlSet\Control\Class\ClassGUID\ which is contained in the "(Default)" value.
                    key = HKLM_DeviceClass.OpenSubKey(device.ClassGuid)

                    device.Category = key.GetValue("").ToString

                    deviceList(deviceCount) = device
                    deviceCount += 1
                End If
            Next

        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, wmi.ClassPath.ClassName(), Win32_PnPEntityProperties(propertyIndex))
            Exit Sub
        End Try

        deviceCount -= 1

        ' Sort the list of devices based on the device Name property.
        Dim cache As DeviceData
        Dim sorted As Boolean

        Do
            sorted = True
            For n As Integer = 0 To deviceCount - 1
                If deviceList(n).Name.ToUpperInvariant > deviceList(n + 1).Name.ToUpperInvariant Then
                    cache = deviceList(n)
                    deviceList(n) = deviceList(n + 1)
                    deviceList(n + 1) = cache
                    sorted = False
                End If
            Next
        Loop While sorted = False

        ' Add the sorted list of devices to the listview control.
        For n = 0 To deviceList.GetUpperBound(0) - 1
            Dim lvi As New ListViewItem
            lvi.Text = deviceList(n).Name
            lstDevices.Items.Add(lvi)
        Next

    End Sub

    Private Sub lstDevices_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDevices.SelectedIndexChanged

        If lstDevices.SelectedIndices.Count > 0 Then
            Dim item As ListViewItem = DirectCast(lstDevices.Items(lstDevices.SelectedIndices.Item(0)), ListViewItem)

            lblDevCategory.Text = deviceList(item.Index).Category
            lblDevPnpId.Text = deviceList(item.Index).DeviceId
            lblDevDriverPath.Text = deviceList(item.Index).DriverPath
            lblDevManufacturer.Text = deviceList(item.Index).Manufacturer
            lblDevService.Text = deviceList(item.Index).Service
            lblDevClassGuid.Text = deviceList(item.Index).ClassGuid

            ' Is there a driver asscoicated with this device?
            ' We get the driver details on the fly to help speed things up.
            If deviceList(item.Index).DriverPath = "Not Applicable" Then
                lblDevDriverVersion.Text = "Not Applicable"
            Else
                Dim fi As New Misc.FileInfo(deviceList(item.Index).DriverPath)

                lblDevDriverVersion.Text = fi.Version
            End If

        End If
    End Sub


    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        newReport.WriteSubtitle(vbTab & "[Hardware Devices]")

        For n As Integer = 0 To deviceCount
            newReport.WriteItem("Device", deviceList(n).Name)
            newReport.WriteItem("Category", deviceList(n).Category)
            newReport.WriteItem("Manufacturer", deviceList(n).Manufacturer)
            newReport.WriteItem("PnP Identifier", deviceList(n).DeviceId)
            newReport.WriteItem("Driver Path", deviceList(n).DriverPath)
            newReport.WriteItem("Associated Service", deviceList(n).Service)
            newReport.WriteItem("Class GUID", deviceList(n).ClassGuid)
            newReport.WriteSubtitle("")
        Next

    End Sub

End Class
