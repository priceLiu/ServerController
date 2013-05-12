Option Strict On
Option Explicit On

Imports System.Management

Public Class UserControlProcesses

    ' Instantiate a web form for displaying information from the Internet on the selected process.
    Dim frm_ProcessCheck As New FormMsdn

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ToolTips.SetToolTip(Me.btnAdditionalInfo, "Retrieves additional information from the Internet about the process. " & vbNewLine & _
                            "This can be useful in identifying programs that are running that shouldn't be; such as spyware etc.")

        DisplayProcesses()

    End Sub

    ' Create a UDT to hold the collected information.
    Private Structure ProcessData
        Dim Caption As String
        Dim CommandLine As String
        Dim Owner As String
        Dim Priority As String
        Dim ProcessId As String
        Dim ThreadCount As String
        Dim HandleCount As String
    End Structure

    Dim processList() As ProcessData
    Dim processCount As Integer

    Private Sub DisplayProcesses()

        ' Instantiate a Win32_Process object
        Dim wmi As New ManagementClass("Win32_Process")

        ' Create a list of the properties we're interested in.
        Dim Win32_ProcessProperties() As String = {"Caption", "CommandLine", "HandleCount", "ProcessID", "Priority", "ThreadCount"}
        Dim propertyIndex As Integer

        Try
            ' Get each process in turn.
            For Each obj As ManagementObject In wmi.GetInstances()

                ReDim Preserve processList(processCount)

                propertyIndex = 0 ' Caption property.
                If obj(Win32_ProcessProperties(propertyIndex)) IsNot Nothing Then
                    processList(processCount).Caption = obj(Win32_ProcessProperties(propertyIndex)).ToString
                End If

                propertyIndex = 1 ' Commadline property.
                If obj(Win32_ProcessProperties(propertyIndex)) IsNot Nothing Then
                    processList(processCount).CommandLine = obj(Win32_ProcessProperties(propertyIndex)).ToString.Replace(Chr(34), "")
                End If

                propertyIndex = 2 ' HandleCount property.
                If obj(Win32_ProcessProperties(propertyIndex)) IsNot Nothing Then
                    processList(processCount).HandleCount = obj(Win32_ProcessProperties(propertyIndex)).ToString
                End If

                propertyIndex = 3 ' ProcessID property.
                If obj(Win32_ProcessProperties(propertyIndex)) IsNot Nothing Then
                    processList(processCount).ProcessId = obj(Win32_ProcessProperties(propertyIndex)).ToString
                    processList(processCount).Owner = GetProcessOwner(CInt(obj(Win32_ProcessProperties(propertyIndex))))
                End If

                propertyIndex = 4 ' Priority property.
                If obj(Win32_ProcessProperties(propertyIndex)) IsNot Nothing Then
                    processList(processCount).Priority = obj(Win32_ProcessProperties(propertyIndex)).ToString
                End If

                propertyIndex = 5 ' ThreadCount property.
                If obj(Win32_ProcessProperties(propertyIndex)) IsNot Nothing Then
                    processList(processCount).ThreadCount = obj(Win32_ProcessProperties(propertyIndex)).ToString
                End If

                processCount += 1
            Next
        Catch ex As ManagementException
            ' Keep a record of any errors that may have occurred.
            ErrorList.AddErrorToList(ex.Message, wmi.ClassPath.ClassName(), Win32_ProcessProperties(propertyIndex))
            Exit Sub
        End Try

        ' Adjust the processCount to reflect the true number of processes.
        processCount -= 1

        ' Sort the list of processes based on the process Caption property.
        Dim cache As ProcessData
        Dim sorted As Boolean

        Do
            sorted = True
            For n As Integer = 0 To processCount - 1
                If processList(n).Caption.ToUpperInvariant > processList(n + 1).Caption.ToUpperInvariant Then
                    cache = processList(n)
                    processList(n) = processList(n + 1)
                    processList(n + 1) = cache
                    sorted = False
                End If
            Next
        Loop While sorted = False

        ' Add the sorted list of processes to our listview control.
        For n = 0 To processList.GetUpperBound(0) - 1

            Dim lvi As New ListViewItem
            lvi.Text = processList(n).Caption
            lvi.SubItems.Add(processList(n).ProcessId)
            lvi.SubItems.Add(processList(n).Owner)
            lvi.SubItems.Add(processList(n).Priority)
            lvi.SubItems.Add(processList(n).ThreadCount)
            lvi.SubItems.Add(processList(n).HandleCount)

            ' Alternate backgroung colour.
            If lstProcesses.Items.Count Mod 2 <> 0 Then
                lvi.BackColor = Color.White
            Else
                lvi.BackColor = Color.Ivory
            End If
            lstProcesses.Items.Add(lvi)
        Next

    End Sub

    Private Shared Function GetProcessOwner(ByVal ProcessId As Integer) As String

        ' Get the process's owner.
        Dim processOwner As String = notAvailable

        Try
            Dim mo As New ManagementObject("root\CIMV2", "Win32_Process.Handle=" & ProcessId, Nothing)
            Dim methodResult As ManagementBaseObject = mo.InvokeMethod("GetOwner", Nothing, Nothing)

            ' Method executed successfully.
            If CInt(methodResult("ReturnValue")) = 0 Then
                processOwner = methodResult("Domain").ToString & "\" & methodResult("User").ToString
            End If
        Catch ex As ManagementException
            ' Record any errors.
            ErrorList.AddErrorToList(ex.Message, "Win32_Process.Handle= " & ProcessId, "Getting Process Owner Info.")
        End Try
        Return processOwner

    End Function

    Private Sub lstProcesses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProcesses.SelectedIndexChanged

        ' Display the command line for the selected process.
        If lstProcesses.SelectedIndices.Count > 0 Then
            Dim item As ListViewItem = DirectCast(lstProcesses.Items(lstProcesses.SelectedIndices.Item(0)), ListViewItem)
            lblCommandLine.Text = processList(item.Index).CommandLine
        End If

    End Sub

    ' Display additional information from the Internet on the selected process.
    Private Sub btnAdditionalInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdditionalInfo.Click

        ' Here we instantiate a new form from class FormMsdn for displaying the info.
        If lstProcesses.SelectedIndices.Count > 0 Then
            Dim item As ListViewItem = DirectCast(lstProcesses.Items(lstProcesses.SelectedIndices.Item(0)), ListViewItem)
            If frm_ProcessCheck.IsDisposed Then
                frm_ProcessCheck = New FormMsdn
            End If

            ' Form and sanitize the URL for our process.
            Dim URL As New System.Uri("http://www.processlibrary.com/directory/files/" & item.Text.Remove(Len(item.Text) - 4) & "/")

            frm_ProcessCheck.ShowUrl(URL)
            frm_ProcessCheck.Show()
        End If

    End Sub

    Public Sub CollectReportData()

        ' Write the collected information to the report file.
        Dim newReport As TextReport = FormMain.TextReportFile

        For n = 0 To processCount
            newReport.WriteItem("Process", processList(n).Caption)
            newReport.WriteItem("Process ID", processList(n).ProcessId)
            newReport.WriteItem("Owner", processList(n).Owner)
            newReport.WriteItem("Priority Level", processList(n).Priority)

            newReport.WriteSubtitle("")
        Next
    End Sub

End Class
