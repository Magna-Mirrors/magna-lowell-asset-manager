Imports System.Xml.Serialization
Imports Effortless.Net.Encryption

Namespace Models
    Public Class CfgSettings
        Private ReadOnly key As Byte() = {164, 80, 80, 113, 114, 158, 65, 119, 154, 208, 247, 202, 154, 36, 29, 145, 247, 129, 189, 54, 224, 18, 178, 27, 179, 215, 113, 151, 30, 31, 117, 68}
        Private ReadOnly iv As Byte() = {211, 249, 64, 194, 22, 205, 110, 252, 253, 173, 112, 171, 217, 136, 15, 178, 115, 9, 84, 245, 215, 173, 84, 165, 15, 36, 69, 166, 110, 123, 170, 137}

        Public Sub New()
            ServerInstance = String.Empty
            DataBase = String.Empty
            UserName = String.Empty
            PasswordEncrypted = String.Empty
            ScannerLogin = False
        End Sub

        Public Property ServerInstance() As String
        Public Property DataBase() As String
        Public Property UserName() As String

        <XmlIgnore()>
        Public Property PasswordDecrypted() As String
            Get
                If String.IsNullOrEmpty(PasswordEncrypted) Then
                    Return String.Empty
                End If
                Return Strings.Decrypt(PasswordEncrypted, key, iv)
            End Get
            Set(value As String)
                If Not String.IsNullOrEmpty(value) Then
                    PasswordEncrypted = Strings.Encrypt(value, key, iv)
                End If
            End Set
        End Property

        Public Property PasswordEncrypted() As String
        Public Property ScannerLogin() As Boolean
    End Class
End Namespace