Option Strict On
Option Explicit On

Imports System
Imports System.Text

' This class is used to compile a list of errors that may have occured during data collection
' and to present this list to the user. The class is also useful as a debugging aid.
Public NotInheritable Class ErrorList

    Shared exErrorList As New List(Of ExceptionError)

    Private Sub New()
    End Sub

    ' Create a new exception error object and add it to our list of errors.
    Public Shared Sub AddErrorToList(ByVal exMessage As String, ByVal exClass As String, ByVal exProperty As String)

        Dim exError As New ExceptionError
        exError.ExceptionMessage = exMessage
        exError.ExceptionClass = exClass
        exError.ExceptionProperty = exProperty

        exErrorList.Add(exError)

    End Sub

    Public Shared Sub DisplayErrorList()

        If exErrorList.Count > 0 Then
            Dim errorListText As New StringBuilder

            ' Concatenate all the errors found and present them to the user in a message box.
            For Each exError As ExceptionError In exErrorList
                errorListText.AppendLine("The WMI Property: " & exError.ExceptionProperty & " in WMI Class: " & exError.ExceptionClass & _
                                         " caused the following error: " & exError.ExceptionMessage & Environment.NewLine)
            Next

            MsgBox("The following errors occured retrieving information from your system: " & Environment.NewLine & Environment.NewLine & _
                                errorListText.ToString, MsgBoxStyle.Information, "Errors Occured During Data Collection.")
        End If
    End Sub


End Class

' A class for storing error information.
Public Class ExceptionError

    Public Property ExceptionMessage() As String
        Get
            Return myExceptionMessage
        End Get
        Set(ByVal value As String)
            myExceptionMessage = value
        End Set
    End Property

    Public Property ExceptionClass() As String
        Get
            Return myExceptionClass
        End Get
        Set(ByVal value As String)
            myExceptionClass = value
        End Set
    End Property

    Public Property ExceptionProperty() As String
        Get
            Return myExceptionProperty
        End Get
        Set(ByVal value As String)
            myExceptionProperty = value
        End Set
    End Property

    Dim myExceptionMessage As String
    Dim myExceptionClass As String
    Dim myExceptionProperty As String

    Public Sub New()
    End Sub

End Class


