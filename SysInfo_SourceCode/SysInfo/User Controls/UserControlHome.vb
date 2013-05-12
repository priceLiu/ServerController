Option Strict On
Option Explicit On

Public Class UserControlHome

    Dim frm_License As New FormLicense

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnLicense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLicense.Click
        frm_License.ShowDialog()
    End Sub
End Class
