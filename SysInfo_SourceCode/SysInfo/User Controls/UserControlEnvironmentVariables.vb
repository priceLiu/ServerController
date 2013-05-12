Option Strict On
Option Explicit On

Public Class UserControlEnvironmentVariables

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetEnvironmentVariables()

    End Sub

    Private Sub GetEnvironmentVariables()

        Dim variables As IDictionary = Environment.GetEnvironmentVariables()

        For Each variable As DictionaryEntry In variables
            Dim lvi As New ListViewItem

            lvi.Text = variable.Key.ToString
            lvi.SubItems.Add(variable.Value.ToString)
            lstEnvVariables.Items.Add(lvi)
        Next

    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile
        Dim variables As IDictionary = Environment.GetEnvironmentVariables()

        newReport.WriteItem("Variable", "Value")

        For Each variable As DictionaryEntry In variables
            newReport.WriteItem(variable.Key.ToString, variable.Value.ToString)
        Next

    End Sub

End Class
