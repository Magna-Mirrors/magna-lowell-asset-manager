Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports MagnaLowell.AssetManager.Models
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Helpers

Namespace Tools
    Public Class CfgInterface
        Implements ICfgInterface
        Const FileName = "config.xml"
        ReadOnly CfgFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), My.Resources.DataFolder)
        ReadOnly Filepath As String = Path.Combine(CfgFolder, FileName)
        Private Shared _cfg As CfgSettings

        Public Sub New()
            CheckFolders()
            If _cfg Is Nothing Then
                _cfg = ReadCfg()
            End If
        End Sub
        Public Function ReadCfg() As CfgSettings Implements ICfgInterface.ReadCfg
            If _cfg IsNot Nothing Then
                Return _cfg
            End If

            CheckFolders()
            Using fs As New FileStream(Filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Using reader As New StreamReader(fs)
                    Dim x As New XmlSerializer(GetType(CfgSettings))
                    _cfg = DirectCast(x.Deserialize(reader), CfgSettings)
                End Using
            End Using

            If Not String.IsNullOrEmpty(_cfg.SetPassword) Then
                _cfg.PasswordDecrypted = _cfg.SetPassword
                _cfg.SetPassword = String.Empty
                WriteConfig(_cfg)
            End If
            Return _cfg
        End Function

        Public Function WriteConfig(c As CfgSettings) As Boolean Implements ICfgInterface.WriteConfig
            CheckFolders()
            WriteFile(c, Filepath)
            _cfg = c
            Return True
        End Function

        Private Sub CheckFolders()
            If Not Directory.Exists(CfgFolder) Then
                Directory.CreateDirectory(CfgFolder)
            End If
            If Not File.Exists(Filepath) Then
                WriteFile(New CfgSettings(), Filepath)
            End If
        End Sub

        Private Shared Function WriteFile(c As CfgSettings, path As String) As Boolean
            Using writer As New StreamWriter(path)
                Dim x As New XmlSerializer(GetType(CfgSettings))
                x.Serialize(writer, c)
            End Using
            Return True
        End Function
    End Class
End Namespace