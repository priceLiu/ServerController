Option Strict On
Option Explicit On

Imports System.Globalization

Public NotInheritable Class FormSplash

    ' Display our splash screen to the user and update which information we're currently getting.
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Version.Text = System.String.Format(CultureInfo.CurrentCulture, Version.Text, My.Application.Info.Version.Major, _
                                            My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Me.Cursor = Cursors.WaitCursor

    End Sub

    ' Our declared delegate routine for updating the splash screen on a different thread.
    Private Delegate Sub UpdateStatus(ByVal text As String)

    Private Sub UpdateStatusText(ByVal text As String)
        lblLoading.Text = text
    End Sub

    Public Sub Status(ByVal text As String)

        ' Had to put this check in because on some slow machines the main form thread would be
        ' trying to update the status text before the splash form had been created.
        If Me.Created Then
            lblLoading.Invoke(New UpdateStatus(AddressOf UpdateStatusText), New Object() {text})
        End If

    End Sub
End Class
