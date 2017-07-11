Imports System.Threading
Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager.Interfaces
Imports MagnaLowell.AssetManager.Models
Imports MagnaLowell.AssetManager.Tools
Imports DevExpress.XtraEditors

Namespace Views

    Public Class ViewCfg
        Implements IView(Of CfgSettings)

        ReadOnly cfgFile As ICfgInterface
        ReadOnly _tsk As ITaskManager
        Public Sub New(icfg As ICfgInterface, tsk As ITaskManager)
            InitializeComponent()
            cfgFile = icfg
            _tsk = tsk

            Dim cfg = cfgFile.Cfg()
            TxtUser.Text = cfg.UserName
            TxtPwd.Text = cfg.PasswordDecrypted
            TxtServer.Text = cfg.ServerInstance
            TxtDb.Text = cfg.DataBase
            ChkScannerLogin.Checked = cfg.ScannerLogin
        End Sub


        Private ReadOnly Property IView_Name As String Implements IView.Title
            Get
                Return "Settings"
            End Get
        End Property


        Public ReadOnly Property Control As UserControl Implements IView.Control
            Get
                Return Me
            End Get
        End Property



        Private Sub SqlTxtChange(sender As Object, e As EventArgs) Handles TxtServer.EditValueChanged, TxtDb.EditValueChanged, TxtUser.EditValueChanged, TxtPwd.EditValueChanged
            Throw New NotImplementedException()
            'TxtConnStr.Text = String.Format(DbInterface.ConnString, TxtServer.Text, TxtDb.Text, TxtUser.Text, String.Join("", Enumerable.Repeat("*", TxtPwd.Text.Length)))
        End Sub


        Public Sub LoadView(data As CfgSettings) Implements IView(Of CfgSettings).LoadView
            Throw New NotImplementedException()
        End Sub

        Private Function IView_Save() As Boolean Implements IView(Of CfgSettings).Save
            Dim cfg As New CfgSettings()
            With cfg
                .ServerInstance = TxtServer.Text
                .DataBase = TxtDb.Text
                .UserName = TxtUser.Text
                .PasswordDecrypted = TxtPwd.Text
                .ScannerLogin = ChkScannerLogin.Checked
            End With
            Return cfgFile.WriteConfig(cfg)

            '_tsk.StartNewTask(Sub(c As CancellationToken)
            '                      DirectCast(Me.ParentForm, Form1).CheckLogin()
            '                  End Sub)
        End Function
    End Class
End Namespace
'Public ReadOnly Property View As XtraUserControl Implements IView.View
'    Get
'        Return Me
'    End Get
'End Property
'Public ReadOnly Property UserLevl As Integer Implements IView.UserLevl
'    Get
'        Return 20
'    End Get
'End Property
'Public Sub Save() Implements IView.Save
'    Dim cfg As New CfgSettings()
'    With cfg
'        .ServerInstance = TxtServer.Text
'        .DataBase = TxtDb.Text
'        .UserName = TxtUser.Text
'        .PasswordDecrypted = TxtPwd.Text
'        .ScannerLogin = ChkScannerLogin.Checked
'    End With
'    cfgFile.WriteConfig(cfg)

'    _tsk.StartNewTask(Sub(c As CancellationToken)
'                          DirectCast(Me.ParentForm, Form1).CheckLogin()
'                      End Sub)
'End Sub
'Public Sub Edit() Implements IView.Edit
'End Sub

'Public Sub Delete() Implements IView.Delete
'    TxtUser.Text = String.Empty
'    TxtPwd.Text = String.Empty
'    TxtServer.Text = String.Empty
'    TxtDb.Text = String.Empty
'    ChkScannerLogin.Checked = False
'End Sub