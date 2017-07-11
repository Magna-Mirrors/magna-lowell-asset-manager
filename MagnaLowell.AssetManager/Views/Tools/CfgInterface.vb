Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports MagnaLowell.AssetManager.Models
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Helpers

Namespace Tools
    Public Interface ICfgInterface
        Event FileChanged As Action
        'Function ReadConfig() As CfgSettings
        Function WriteConfig(c As CfgSettings) As Boolean
        Property Cfg() As CfgSettings
        Sub CheckFolders()
    End Interface
    Public Class DbgCfgInterface
        Implements ICfgInterface

        Private Shared Property _cfg As CfgSettings

        Public Property Cfg As CfgSettings Implements ICfgInterface.Cfg
            Get
                If _cfg Is Nothing Then
                    '_cfg = New CfgSettings With {.DataBase = "Magna_Lowell",
                    '                            .PasswordDecrypted = "yaaOt0883BhyOBskJe5t",
                    '                            .UserName = "sa",
                    '                            .ServerInstance = "fzse"}

                    _cfg = New CfgSettings With {.DataBase = "MagnaLowell",
                                              .PasswordDecrypted = "Winston",
                                              .UserName = "sa",
                                              .ServerInstance = "10.69.104.20"}
                End If
                Return _cfg
            End Get
            Set(value As CfgSettings)
                _cfg = value
                RaiseEvent FileChanged()
            End Set
        End Property

        Public Event FileChanged As Action Implements ICfgInterface.FileChanged

        Public Sub CheckFolders() Implements ICfgInterface.CheckFolders

        End Sub

        Public Function WriteConfig(c As CfgSettings) As Boolean Implements ICfgInterface.WriteConfig
            _cfg = c
            RaiseEvent FileChanged()
            Return True
        End Function
    End Class
    Public Class CfgInterface
        Implements ICfgInterface

        'Const Fz = "FeyenZylstra"
        'Const AppFolder = "ConfigUtil"
        Const FileName = "config.xml"
        Shared ReadOnly CfgFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), My.Resources.DataFolder)
        Shared ReadOnly Filepath As String = Path.Combine(CfgFolder, FileName)

        ReadOnly _fsw As FileSystemWatcher
        Public Event FileChanged As Action Implements ICfgInterface.FileChanged
        Public Property Cfg As CfgSettings Implements ICfgInterface.Cfg

        'Public Event FileChanged As Action Implements ICfgInterface.FileChanged

        Public Sub New()
            CheckFolders()
            _fsw = New FileSystemWatcher(CfgFolder) With {.EnableRaisingEvents = True, .Filter = FileName}
            '"C:\ProgramData\Feyen-Zylstra\ConfigUtil")
            AddHandler _fsw.Changed, AddressOf OnChanged
            AddHandler _fsw.Deleted, AddressOf OnDeleted

            Dim tmp = ReadConfig()
            If tmp.NoErrors Then
                Cfg = tmp.Result
            End If
        End Sub

        Private Sub OnDeleted(sender As Object, e As FileSystemEventArgs)
            CheckFolders()
        End Sub

        Private Sub OnChanged(sender As Object, e As FileSystemEventArgs)
            Debug.Print("File changed")
            Dim tmp = ReadConfig()
            If tmp.NoErrors Then
                Cfg = tmp.Result
            End If
            RaiseEvent FileChanged()
        End Sub

        Private Function WriteFile(c As CfgSettings) As Boolean
            Try
                Using writer As New StreamWriter(Filepath)
                    Dim x As New XmlSerializer(GetType(CfgSettings))
                    x.Serialize(writer, c)
                End Using
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        Private Function ReadConfig() As DbResult(Of CfgSettings) ' Implements ICfgInterface.ReadConfig
            CheckFolders()
            Using fs As New FileStream(Filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Using writer As New StreamReader(fs)
                    Dim x As New XmlSerializer(GetType(CfgSettings))
                    Try
                        Return New DbResult(Of CfgSettings)(TryCast(x.Deserialize(writer), CfgSettings))
                    Catch ex As Exception
                        Return New DbResult(Of CfgSettings)(ex)
                    End Try
                End Using
            End Using
        End Function
        Public Function WriteConfig(c As CfgSettings) As Boolean Implements ICfgInterface.WriteConfig
            Try
                CheckFolders()
                Return WriteFile(c)
            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Sub CheckFolders() Implements ICfgInterface.CheckFolders
            If Not My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(CfgFolder)) Then
                My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(CfgFolder))
            End If
            If Not My.Computer.FileSystem.DirectoryExists(CfgFolder) Then
                My.Computer.FileSystem.CreateDirectory(CfgFolder)
            End If
            If Not My.Computer.FileSystem.FileExists(Filepath) Then
                WriteFile(New CfgSettings())
            End If
        End Sub
    End Class
End Namespace