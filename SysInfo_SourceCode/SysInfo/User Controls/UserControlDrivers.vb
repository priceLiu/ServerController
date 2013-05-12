Option Strict On
Option Explicit On

Imports System.Management
Imports SysInfo.Misc


Public Class UserControlDrivers

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetSystemDrivers()

    End Sub

    Private Structure DriverData
        Dim Name As String
        Dim Description As String
        Dim Path As String
        Dim Type As String
        Dim StartMode As String
        Dim Publisher As String
    End Structure

    Dim driverList() As DriverData
    Dim driverCount As Integer


    Private Sub GetSystemDrivers()

        Dim mc As New ManagementClass("Win32_SystemDriver")

        Dim Win32_SystemDriverProperties() As String = {"StartMode", "Name", "Description", "PathName", "ServiceType", "StartMode"}
        Dim propertyIndex As Integer

        Try
            For Each mo As ManagementObject In mc.GetInstances()

                ReDim Preserve driverList(driverCount)

                propertyIndex = 0 ' StartMode.
                If mo(Win32_SystemDriverProperties(propertyIndex)).ToString <> "Disabled" Then

                    propertyIndex = 1 ' Name.
                    If mo(Win32_SystemDriverProperties(propertyIndex)) IsNot Nothing Then
                        driverList(driverCount).Name = mo(Win32_SystemDriverProperties(propertyIndex)).ToString
                    End If

                    propertyIndex = 2 ' Description.
                    If mo(Win32_SystemDriverProperties(propertyIndex)) IsNot Nothing Then
                        driverList(driverCount).Description = mo(Win32_SystemDriverProperties(propertyIndex)).ToString
                    Else
                        driverList(driverCount).Description = notAvailable
                    End If

                    propertyIndex = 3 ' PathName.
                    If mo(Win32_SystemDriverProperties(propertyIndex)) IsNot Nothing Then
                        driverList(driverCount).Path = mo(Win32_SystemDriverProperties(propertyIndex)).ToString

                        ' Get the publisher of this driver.
                        Dim fi As New Misc.FileInfo(driverList(driverCount).Path)
                        driverList(driverCount).Publisher = fi.CompanyName
                    Else
                        driverList(driverCount).Path = notAvailable
                    End If

                    propertyIndex = 4 ' ServiceType.
                    If mo(Win32_SystemDriverProperties(propertyIndex)) IsNot Nothing Then
                        driverList(driverCount).Type = mo(Win32_SystemDriverProperties(propertyIndex)).ToString
                    Else
                        driverList(driverCount).Type = notAvailable
                    End If

                    propertyIndex = 5 ' StartMode.
                    If mo(Win32_SystemDriverProperties(propertyIndex)) IsNot Nothing Then
                        driverList(driverCount).StartMode = mo(Win32_SystemDriverProperties(propertyIndex)).ToString
                    Else
                        driverList(driverCount).StartMode = notAvailable
                    End If

                    driverCount += 1

                End If

            Next

        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, mc.ClassPath.ClassName(), Win32_SystemDriverProperties(propertyIndex))
            Exit Sub
        End Try

        driverCount -= 1

        ' Sort the list of drivers based on the driver Name property.
        Dim cache As DriverData
        Dim sorted As Boolean

        Do
            sorted = True
            For n As Integer = 0 To driverCount - 1
                If driverList(n).Name.ToUpperInvariant > driverList(n + 1).Name.ToUpperInvariant Then
                    cache = driverList(n)
                    driverList(n) = driverList(n + 1)
                    driverList(n + 1) = cache
                    sorted = False
                End If
            Next
        Loop While sorted = False

        ' Add the sorted list of drivers to the listview control.
        For n = 0 To driverList.GetUpperBound(0) - 1

            Dim lvi As New ListViewItem

            lvi.Text = driverList(n).Name
            lvi.SubItems.Add(driverList(n).Path)
            lvi.SubItems.Add(driverList(n).Type)
            lvi.SubItems.Add(driverList(n).StartMode)

            If lstDrivers.Items.Count Mod 2 <> 0 Then
                lvi.BackColor = Color.White
            Else
                lvi.BackColor = Color.Ivory
            End If

            lstDrivers.Items.Add(lvi)

        Next

    End Sub

    Private Sub lstDrivers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDrivers.SelectedIndexChanged

        If lstDrivers.SelectedIndices.Count > 0 Then
            Dim item As ListViewItem = DirectCast(lstDrivers.Items(lstDrivers.SelectedIndices.Item(0)), ListViewItem)

            lblPublisher.Text = driverList(item.Index).Publisher

            ' Sometimes the driver's description isn't available from WMI so we display a message instead.
            If driverList(item.Index).Description = driverList(item.Index).Name Or driverList(item.Index).Description = "" Then
                lblDescription.Text = "No description available."
            Else
                lblDescription.Text = driverList(item.Index).Description
            End If
        End If

    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        For n As Integer = 0 To driverCount
            newReport.WriteItem("Driver Name", driverList(n).Name)
            newReport.WriteItem("Path", driverList(n).Path)
            newReport.WriteItem("Type", driverList(n).Type)
            newReport.WriteItem("Description", driverList(n).Description)
            newReport.WriteItem("Start Mode", driverList(n).StartMode)
            newReport.WriteItem("Publisher", driverList(n).Publisher)

            newReport.WriteSubtitle("")
        Next

    End Sub

End Class
