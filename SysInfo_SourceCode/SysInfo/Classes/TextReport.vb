Option Explicit On
Option Strict On

Imports SysInfo
Imports System.Globalization.CultureInfo
Imports System.IO
Imports System.Text

' A class that creates a text file report on the information found.
Public Class TextReport

    Implements IDisposable

    Public Property Success() As Boolean
        Get
            Return mySuccess
        End Get
        Private Set(ByVal value As Boolean)
            mySuccess = value
        End Set
    End Property

    Dim report As New StringBuilder(200 * 1024) ' 200Kbytes initial filesize.
    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim mySuccess As Boolean

    Public Sub New(ByVal fileName As String)

        mySuccess = True

        Try
            fs = New FileStream(fileName, FileMode.Create, FileAccess.Write)
            sw = New StreamWriter(fs)
        Catch ex As ArgumentException
            Me.Success = False
            Exit Sub
        End Try

        Dim version As String = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor

        report.Append("SysInfo v" & version & " Text Report").AppendLine()
        report.Append("Author: Paul Wilcox").AppendLine()
        report.Append("Email: wilcoxp@btinternet.com").AppendLine()
        report.Append("Report Date: " & Date.Now.ToString(CurrentCulture)).AppendLine()
        report.AppendLine()
        'report.Append("System Report For Computer: " & FormMain.userControlNetwork.lblHostName.Text).AppendLine()
        report.AppendLine()

    End Sub

    Public Sub WriteSubtitle(ByVal text As String)
        report.Append(vbTab & text).AppendLine()
    End Sub

    Public Sub WriteItem(ByVal item As String, ByVal value As String)
        report.Append(vbTab & vbTab & item & ":" & "".PadLeft(30 - item.Length) & value).AppendLine()
    End Sub

    Public Sub WriteTextToFile()

        sw.Write(report.ToString)
        Me.Dispose()

    End Sub

    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If sw IsNot Nothing Then
                sw.Close()
            End If
            If fs IsNot Nothing Then
                fs.Close()
            End If
        End If
    End Sub

    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

End Class