Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ViewCfg
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.LayoutCtrl = New DevExpress.XtraLayout.LayoutControl()
            Me.TxtPwd = New DevExpress.XtraEditors.TextEdit()
            Me.TxtUser = New DevExpress.XtraEditors.TextEdit()
            Me.TxtDb = New DevExpress.XtraEditors.TextEdit()
            Me.TxtServer = New DevExpress.XtraEditors.TextEdit()
            Me.TxtConnStr = New DevExpress.XtraEditors.TextEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LciPw = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciSqlServer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciDb = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciUserName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciConnStr = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ChkScannerLogin = New DevExpress.XtraEditors.CheckEdit()
            Me.LciChkEnableScanner = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.LayoutCtrl,System.ComponentModel.ISupportInitialize).BeginInit
            Me.LayoutCtrl.SuspendLayout
            CType(Me.TxtPwd.Properties,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TxtUser.Properties,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TxtDb.Properties,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TxtServer.Properties,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TxtConnStr.Properties,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LayoutControlGroup2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LciPw,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LciSqlServer,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LciDb,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LciUserName,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LciConnStr,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.ChkScannerLogin.Properties,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.LciChkEnableScanner,System.ComponentModel.ISupportInitialize).BeginInit
            Me.SuspendLayout
            '
            'LayoutCtrl
            '
            Me.LayoutCtrl.Controls.Add(Me.ChkScannerLogin)
            Me.LayoutCtrl.Controls.Add(Me.TxtPwd)
            Me.LayoutCtrl.Controls.Add(Me.TxtUser)
            Me.LayoutCtrl.Controls.Add(Me.TxtDb)
            Me.LayoutCtrl.Controls.Add(Me.TxtServer)
            Me.LayoutCtrl.Controls.Add(Me.TxtConnStr)
            Me.LayoutCtrl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutCtrl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutCtrl.Name = "LayoutCtrl"
            Me.LayoutCtrl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3797, 253, 517, 350)
            Me.LayoutCtrl.Root = Me.LayoutControlGroup1
            Me.LayoutCtrl.Size = New System.Drawing.Size(665, 482)
            Me.LayoutCtrl.TabIndex = 0
            Me.LayoutCtrl.Text = "Connection String:"
            '
            'TxtPwd
            '
            Me.TxtPwd.Location = New System.Drawing.Point(133, 114)
            Me.TxtPwd.Name = "TxtPwd"
            Me.TxtPwd.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.TxtPwd.Size = New System.Drawing.Size(508, 20)
            Me.TxtPwd.StyleController = Me.LayoutCtrl
            Me.TxtPwd.TabIndex = 6
            '
            'TxtUser
            '
            Me.TxtUser.Location = New System.Drawing.Point(133, 90)
            Me.TxtUser.Name = "TxtUser"
            Me.TxtUser.Size = New System.Drawing.Size(508, 20)
            Me.TxtUser.StyleController = Me.LayoutCtrl
            Me.TxtUser.TabIndex = 5
            '
            'TxtDb
            '
            Me.TxtDb.Location = New System.Drawing.Point(133, 66)
            Me.TxtDb.Name = "TxtDb"
            Me.TxtDb.Size = New System.Drawing.Size(508, 20)
            Me.TxtDb.StyleController = Me.LayoutCtrl
            Me.TxtDb.TabIndex = 4
            '
            'TxtServer
            '
            Me.TxtServer.Location = New System.Drawing.Point(133, 42)
            Me.TxtServer.Name = "TxtServer"
            Me.TxtServer.Size = New System.Drawing.Size(508, 20)
            Me.TxtServer.StyleController = Me.LayoutCtrl
            Me.TxtServer.TabIndex = 1
            '
            'TxtConnStr
            '
            Me.TxtConnStr.Location = New System.Drawing.Point(133, 138)
            Me.TxtConnStr.Name = "TxtConnStr"
            Me.TxtConnStr.Properties.ReadOnly = true
            Me.TxtConnStr.Size = New System.Drawing.Size(508, 20)
            Me.TxtConnStr.StyleController = Me.LayoutCtrl
            Me.TxtConnStr.TabIndex = 6
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = false
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LciChkEnableScanner, Me.LayoutControlGroup2})
            Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(665, 482)
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LciPw, Me.LciSqlServer, Me.LciDb, Me.LciUserName, Me.LciConnStr})
            Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(645, 162)
            Me.LayoutControlGroup2.Text = "Sql Settings"
            '
            'LciPw
            '
            Me.LciPw.Control = Me.TxtPwd
            Me.LciPw.Location = New System.Drawing.Point(0, 72)
            Me.LciPw.Name = "LciPw"
            Me.LciPw.Size = New System.Drawing.Size(621, 24)
            Me.LciPw.Text = "Password:"
            Me.LciPw.TextSize = New System.Drawing.Size(106, 13)
            '
            'LciSqlServer
            '
            Me.LciSqlServer.Control = Me.TxtServer
            Me.LciSqlServer.Location = New System.Drawing.Point(0, 0)
            Me.LciSqlServer.Name = "LciSqlServer"
            Me.LciSqlServer.Size = New System.Drawing.Size(621, 24)
            Me.LciSqlServer.Text = "Server Instance:"
            Me.LciSqlServer.TextSize = New System.Drawing.Size(106, 13)
            '
            'LciDb
            '
            Me.LciDb.Control = Me.TxtDb
            Me.LciDb.Location = New System.Drawing.Point(0, 24)
            Me.LciDb.Name = "LciDb"
            Me.LciDb.Size = New System.Drawing.Size(621, 24)
            Me.LciDb.Text = "Database Name:"
            Me.LciDb.TextSize = New System.Drawing.Size(106, 13)
            '
            'LciUserName
            '
            Me.LciUserName.Control = Me.TxtUser
            Me.LciUserName.Location = New System.Drawing.Point(0, 48)
            Me.LciUserName.Name = "LciUserName"
            Me.LciUserName.Size = New System.Drawing.Size(621, 24)
            Me.LciUserName.Text = "User Name:"
            Me.LciUserName.TextSize = New System.Drawing.Size(106, 13)
            '
            'LciConnStr
            '
            Me.LciConnStr.Control = Me.TxtConnStr
            Me.LciConnStr.CustomizationFormText = "Password:"
            Me.LciConnStr.Location = New System.Drawing.Point(0, 96)
            Me.LciConnStr.Name = "LciConnStr"
            Me.LciConnStr.Size = New System.Drawing.Size(621, 24)
            Me.LciConnStr.Text = "Connection String:"
            Me.LciConnStr.TextSize = New System.Drawing.Size(106, 13)
            '
            'CheckEdit1
            '
            Me.ChkScannerLogin.Location = New System.Drawing.Point(121, 174)
            Me.ChkScannerLogin.Name = "ChkScannerLogin"
            Me.ChkScannerLogin.Properties.Caption = ""
            Me.ChkScannerLogin.Size = New System.Drawing.Size(532, 19)
            Me.ChkScannerLogin.StyleController = Me.LayoutCtrl
            Me.ChkScannerLogin.TabIndex = 7
            '
            'LciChkEnableScanner
            '
            Me.LciChkEnableScanner.Control = Me.ChkScannerLogin
            Me.LciChkEnableScanner.Location = New System.Drawing.Point(0, 162)
            Me.LciChkEnableScanner.Name = "LciChkEnableScanner"
            Me.LciChkEnableScanner.Size = New System.Drawing.Size(645, 300)
            Me.LciChkEnableScanner.Text = "Enable Scanner Login:"
            Me.LciChkEnableScanner.TextSize = New System.Drawing.Size(106, 13)
            '
            'ViewCfg
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutCtrl)
            Me.Name = "ViewCfg"
            Me.Size = New System.Drawing.Size(665, 482)
            CType(Me.LayoutCtrl,System.ComponentModel.ISupportInitialize).EndInit
            Me.LayoutCtrl.ResumeLayout(false)
            CType(Me.TxtPwd.Properties,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TxtUser.Properties,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TxtDb.Properties,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TxtServer.Properties,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TxtConnStr.Properties,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LayoutControlGroup2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LciPw,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LciSqlServer,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LciDb,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LciUserName,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LciConnStr,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.ChkScannerLogin.Properties,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.LciChkEnableScanner,System.ComponentModel.ISupportInitialize).EndInit
            Me.ResumeLayout(false)

        End Sub

        Friend WithEvents LayoutCtrl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents TxtPwd As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TxtUser As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TxtDb As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TxtServer As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LciPw As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LciSqlServer As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LciDb As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LciUserName As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents TxtConnStr As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LciConnStr As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ChkScannerLogin As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LciChkEnableScanner As DevExpress.XtraLayout.LayoutControlItem
    End Class
End NameSpace