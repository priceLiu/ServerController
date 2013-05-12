Option Strict On
Option Explicit On

Imports System.Management

Public Class UserControlServices

    Private Structure ServiceData
        Dim Caption As String
        Dim Description As String
        Dim Name As String
        Dim PathName As String
        Dim ProcessId As String
        Dim Started As Boolean
        Dim StartName As String
        Dim StartMode As String
        Dim State As String
    End Structure

    Dim serviceList() As ServiceData
    Dim serviceCount As Integer



    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetServices()

    End Sub

    Public Sub GetServices()

        Dim wmi As New ManagementClass("Win32_Service")
        Dim Win32_ServiceProperties() As String = {"Caption", "Description", "Name", "PathName", "ProcessID", "Started", "StartName", "StartMode", "State"}
        Dim propertyIndex As Integer

        Try
            For Each obj As ManagementObject In Wmi.GetInstances()

                ReDim Preserve serviceList(serviceCount)

                propertyIndex = 0
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).Caption = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                propertyIndex = 1
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).Description = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                propertyIndex = 2
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).Name = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                propertyIndex = 3
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).PathName = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                propertyIndex = 4
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).ProcessId = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                propertyIndex = 5
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).Started = CBool(obj(Win32_ServiceProperties(propertyIndex)))
                End If

                propertyIndex = 6
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).StartName = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                propertyIndex = 7
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).StartMode = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                propertyIndex = 8
                If obj(Win32_ServiceProperties(propertyIndex)) IsNot Nothing Then
                    serviceList(serviceCount).State = obj(Win32_ServiceProperties(propertyIndex)).ToString
                End If

                serviceCount += 1
            Next
        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, wmi.ClassPath.ClassName(), Win32_ServiceProperties(propertyIndex))
            Exit Sub
        End Try

        serviceCount -= 1

        ' Sort the list of services based on the service Caption property.
        Dim cache As ServiceData
        Dim sorted As Boolean

        ' Not the most efficient sort routine in the world, but hey, it's simple and gets the job done.
        Do
            sorted = True
            For n As Integer = 0 To serviceCount - 1
                If serviceList(n).Caption.ToUpperInvariant > serviceList(n + 1).Caption.ToUpperInvariant Then
                    cache = serviceList(n)
                    serviceList(n) = serviceList(n + 1)
                    serviceList(n + 1) = cache
                    sorted = False
                End If
            Next
        Loop While sorted = False

        For n = 0 To serviceCount
            Dim lvi As New ListViewItem

            lvi.Text = serviceList(n).Caption
            lstServices.Items.Add(lvi)
        Next

    End Sub

    Private Sub lstServices_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstServices.SelectedIndexChanged

        ' Display the selected services's properties.

        If lstServices.SelectedIndices.Count > 0 Then
            Dim item As ListViewItem = DirectCast(lstServices.Items(lstServices.SelectedIndices.Item(0)), ListViewItem)

            ' Get the selected service's properties.
            lblServiceName.Text = serviceList(item.Index).Name
            lblServicePathName.Text = serviceList(item.Index).PathName
            lblServiceProcessID.Text = serviceList(item.Index).ProcessId
            lblServiceStarted.Text = serviceList(item.Index).Started.ToString
            lblServiceStartMode.Text = serviceList(item.Index).StartMode
            lblServiceStartName.Text = serviceList(item.Index).StartName

            txtServiceDescription.Text = serviceList(item.Index).Description
        End If

    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        For n As Integer = 0 To serviceCount
            newReport.WriteItem("Service Name", serviceList(n).Name)
            newReport.WriteItem("Path", serviceList(n).PathName)
            newReport.WriteItem("Process Identifier", serviceList(n).ProcessId)
            newReport.WriteItem("Started?", serviceList(n).Started.ToString)
            newReport.WriteItem("Start Mode", serviceList(n).StartMode)
            newReport.WriteItem("Started By", serviceList(n).StartName)

            newReport.WriteSubtitle("")
        Next

    End Sub

End Class
