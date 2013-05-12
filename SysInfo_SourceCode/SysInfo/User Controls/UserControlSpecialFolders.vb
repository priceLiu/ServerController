Option Strict On
Option Explicit On

Imports System.Environment


Public Class UserControlSpecialFolders

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetSpecialFolders()

    End Sub

    Dim folderList As New Dictionary(Of String, String)

    Private Sub GetSpecialFolders()

        Dim folderNames As String() = System.Enum.GetNames(GetType(Environment.SpecialFolder))

        For Each folder As String In folderNames
            Dim lvi As New ListViewItem

            ' Alternate each items' background colour.
            If lstSpecialFolders.Items.Count Mod 2 <> 0 Then
                lvi.BackColor = Color.White
            Else
                lvi.BackColor = Color.Ivory
            End If

            folderList.Add(folder, GetFolderPath(CType(System.Enum.Parse(GetType(SpecialFolder), CType(folder, String)), SpecialFolder)))

            lvi.Text = folder
            lvi.SubItems.Add(folderList.Item(folder))
            lstSpecialFolders.Items.Add(lvi)
        Next

    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        For Each folderEntry As KeyValuePair(Of String, String) In folderList
            newReport.WriteItem(folderEntry.Key, folderEntry.Value)
        Next

        newReport.WriteSubtitle("")

    End Sub

End Class
