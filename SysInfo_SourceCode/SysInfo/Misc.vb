Option Explicit On
Option Strict On

Imports System.IO
Imports System.Security.Principal
Imports System.Threading


Module Misc

    Public Const notAvailable As String = "No information available"
    Public Const errorText As String = "The following error occured retrieving information from: "

    ' A function that retrieves the product key used to install Windows.
    Public Function GetProductKey(ByVal regKey As String) As String

        ' This function will retreive the digital product ID from the registry 
        ' and decode it into the CD key used to install a Microsoft product.
        ' All that is needed is the registry path to the digital proudct ID block
        ' for the product in question.

        Dim validChars() As String = {"B", "C", "D", "F", "G", "H", "J", "K", "M", _
                                      "P", "Q", "R", "T", "V", "W", "X", "Y", "2", _
                                      "3", "4", "6", "7", "8", "9"}
        Dim CDKey As String = ""

        Dim encodedKey(15) As Byte
        Dim digitalProductID As Byte()
        Dim dpidDataBlock As Object

        ' Get the Digital Product ID data-block from the registry.
        dpidDataBlock = My.Computer.Registry.GetValue(regKey, "DigitalProductId", 0)

        If dpidDataBlock Is Nothing Then Return notAvailable

        digitalProductID = DirectCast(dpidDataBlock, Byte())

        ' Extract the encoded CD key (15 bytes) from the digital product ID block.
        For n As Integer = 52 To 67
            encodedKey(n - 52) = digitalProductID(n)
        Next

        ' Decode the CD key.
        ' Note: The actual CD key is not stored in the registry; only the positions  
        ' within the validChars() array of the characters that make up the CD key
        ' are stored and encoded.

        For i As Integer = 28 To 0 Step -1
            ' Calculate where the dashes are.
            If ((i + 1) Mod 6) = 0 Then
                CDKey += " - "
            Else
                Dim j As Integer = 0
                For k As Integer = 14 To 0 Step -1
                    Dim Value As Integer = CInt(CLng(j * 2 ^ 8) Or encodedKey(k))
                    encodedKey(k) = CByte(Value \ 24)
                    ' Position within the validChar() array of the character to add to the CD key string.
                    j = Value Mod 24
                Next
                CDKey += validChars(j)
            End If
        Next
        Return StrReverse(CDKey)

    End Function

    ' A function to return the Admin status of the user running our program.
    Public Function IsAdmin() As Boolean

        IsAdmin = False
        Dim securityGroup As WindowsPrincipal

        ' Get the security credentials of the user that is running our program.
        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        securityGroup = CType(Thread.CurrentPrincipal, WindowsPrincipal)

        ' Are they a member of the Administrators Group?
        If securityGroup.IsInRole(WindowsBuiltInRole.Administrator) Then
            IsAdmin = True
        End If
        Return IsAdmin

    End Function

    ' A public class that retrieves information about a file.
    Class FileInfo

        ' Returns the publisher of the file.
        ReadOnly Property CompanyName() As String
            Get
                Return myCompanyName
            End Get

        End Property


        ' Returns the file version.
        ReadOnly Property Version() As String
            Get
                Return myVersion
            End Get

        End Property

        Dim myCompanyName As String
        Dim myVersion As String

        Public Sub New(ByVal fileName As String)

            Dim fi As FileVersionInfo
            Try

                If File.Exists(fileName) Then

                    ' Get the file info.
                    fi = FileVersionInfo.GetVersionInfo(fileName)

                    myCompanyName = fi.CompanyName

                    If fi.FileVersion <> "" Then
                        myVersion = fi.FileVersion
                    Else
                        myVersion = fi.FileMajorPart & "." & fi.FileMinorPart & "." & fi.FileBuildPart
                    End If
                Else
                    myCompanyName = "Weird, File Does Not Exist!"
                End If

            Catch ex As InvalidOperationException

                ' Return an error message if the routine fails.
                Dim errorMsg As String = "The following error occured: "
                myCompanyName = errorMsg & ex.Message
                myVersion = errorMsg & ex.Message
            End Try

        End Sub
    End Class

End Module
