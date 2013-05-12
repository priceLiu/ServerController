Option Strict On
Option Explicit On

Public Class FormMsdn

    ' Show a webpage containing the URL.
    Public Sub ShowUrl(ByVal url As System.Uri)
        lblURL.Text = url.ToString
        WebBrowser.Url = url
        WebBrowser.Navigate(url)
    End Sub

End Class