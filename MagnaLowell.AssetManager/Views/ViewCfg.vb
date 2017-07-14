Imports System.Threading
Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager.Interfaces
Imports MagnaLowell.AssetManager.Models
Imports MagnaLowell.AssetManager.Tools
Imports DevExpress.XtraEditors

Namespace Views

    Public Class ViewCfg
        Implements IView(Of CfgSettings)

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
            TxtConnStr.Text = String.Format(DbFactory.connstr, TxtServer.Text, TxtDb.Text, TxtUser.Text, String.Join("", Enumerable.Repeat("*", TxtPwd.Text.Length)))
        End Sub

        Private _data As CfgSettings

        Public Sub LoadView(data As CfgSettings) Implements IView(Of CfgSettings).LoadView
            If InvokeRequired Then
                Invoke(Sub() LoadView(data))
                Return
            End If
            _data = data
            TxtUser.Text = _data.UserName
            TxtPwd.Text = _data.PasswordDecrypted
            TxtServer.Text = _data.ServerInstance
            TxtDb.Text = _data.DataBase
            ChkScannerLogin.Checked = _data.ScannerLogin
        End Sub

        Public Function Save() As Boolean Implements IView(Of CfgSettings).Save
            'Dim cfg As New CfgSettings()
            With _data
                .ServerInstance = TxtServer.Text
                .DataBase = TxtDb.Text
                .UserName = TxtUser.Text
                .PasswordDecrypted = TxtPwd.Text
                .ScannerLogin = ChkScannerLogin.Checked
            End With
            Return True 'cfgFile.WriteConfig(cfg)

            '_tsk.StartNewTask(Sub(c As CancellationToken)
            '                      DirectCast(Me.ParentForm, Form1).CheckLogin()
            '                  End Sub)
        End Function
    End Class
End Namespace