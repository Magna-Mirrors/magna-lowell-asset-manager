Imports MagnaLowell.AssetManager.Tools

Public Class DbFactory
    Private ReadOnly _cfgMgr As ICfgInterface
    Public Sub New(cfgMgr As ICfgInterface)
        Me._cfgMgr = cfgMgr
    End Sub


    Const str = "metadata=res://*/Models.Db.MagnaLowell.csdl|res://*/Models.Db.MagnaLowell.ssdl|res://*/Models.Db.MagnaLowell.msl;provider=System.Data.SqlClient;provider connection string=""{0}"""
    Const connstr = "data source={0};initial catalog={1};persist security info=True;user id={2};password={3};MultipleActiveResultSets=True;"

    Public Function GetDbInstance() As Magna_LowellEntities
        Dim cfg = _cfgMgr.Cfg
        Dim baseConn = String.Format(connstr, cfg.ServerInstance, cfg.DataBase, cfg.UserName, cfg.PasswordDecrypted)
        Dim db = New Magna_LowellEntities(String.Format(str, baseConn))
        Return db
    End Function
End Class
