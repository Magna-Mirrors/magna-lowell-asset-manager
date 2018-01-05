Imports MagnaLowell.AssetManager.Models
Imports MagnaLowell.AssetManager.Tools

Public Class DbgCfgInterface
    Implements ICfgInterface

    Private Shared Property _cfg As CfgSettings

    Public Function ReadCfg() As CfgSettings Implements ICfgInterface.ReadCfg

        If _cfg Is Nothing Then
            _cfg = New CfgSettings With {.DataBase = "Magna_Lowell",
                                            .PasswordDecrypted = "123456789",
                                            .UserName = "debuguser",
                                            .ServerInstance = ".\sqlexpress"}

            '_cfg = New CfgSettings With {.DataBase = "MagnaLowell",
            '                          .PasswordDecrypted = "Winston",
            '                          .UserName = "sa",
            '                          .ServerInstance = "10.69.104.20"}
        End If
        Return _cfg
    End Function




    Public Function WriteConfig(c As CfgSettings) As Boolean Implements ICfgInterface.WriteConfig
        _cfg = c
        Return True
    End Function
End Class
