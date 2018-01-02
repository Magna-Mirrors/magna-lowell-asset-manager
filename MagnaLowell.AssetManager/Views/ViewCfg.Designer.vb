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
            Me.ChkScannerLogin = New DevExpress.XtraEditors.CheckEdit()
            Me.TxtPwd = New DevExpress.XtraEditors.TextEdit()
            Me.TxtUser = New DevExpress.XtraEditors.TextEdit()
            Me.TxtDb = New DevExpress.XtraEditors.TextEdit()
            Me.TxtServer = New DevExpress.XtraEditors.TextEdit()
            Me.TxtConnStr = New DevExpress.XtraEditors.TextEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LciChkEnableScanner = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LciPw = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciSqlServer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciDb = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciUserName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LciConnStr = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.LayoutCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutCtrl.SuspendLayout()
            CType(Me.ChkScannerLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtPwd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtConnStr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LciChkEnableScanner, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LciPw, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LciSqlServer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LciDb, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LciUserName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LciConnStr, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            'ChkScannerLogin
            '
            Me.ChkScannerLogin.Location = New System.Drawing.Point(173, 204)
            Me.ChkScannerLogin.Name = "ChkScannerLogin"
            Me.ChkScannerLogin.Properties.Caption = ""
            Me.ChkScannerLogin.Size = New System.Drawing.Size(480, 19)
            Me.ChkScannerLogin.StyleController = Me.LayoutCtrl
            Me.ChkScannerLogin.TabIndex = 7
            '
            'TxtPwd
            '
            Me.TxtPwd.Location = New System.Drawing.Point(185, 132)
            Me.TxtPwd.Name = "TxtPwd"
            Me.TxtPwd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtPwd.Properties.Appearance.Options.UseFont = True
            Me.TxtPwd.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.TxtPwd.Size = New System.Drawing.Size(456, 26)
            Me.TxtPwd.StyleController = Me.LayoutCtrl
            Me.TxtPwd.TabIndex = 6
            '
            'TxtUser
            '
            Me.TxtUser.Location = New System.Drawing.Point(185, 102)
            Me.TxtUser.Name = "TxtUser"
            Me.TxtUser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtUser.Properties.Appearance.Options.UseFont = True
            Me.TxtUser.Size = New System.Drawing.Size(456, 26)
            Me.TxtUser.StyleController = Me.LayoutCtrl
            Me.TxtUser.TabIndex = 5
            '
            'TxtDb
            '
            Me.TxtDb.Location = New System.Drawing.Point(185, 72)
            Me.TxtDb.Name = "TxtDb"
            Me.TxtDb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtDb.Properties.Appearance.Options.UseFont = True
            Me.TxtDb.Size = New System.Drawing.Size(456, 26)
            Me.TxtDb.StyleController = Me.LayoutCtrl
            Me.TxtDb.TabIndex = 4
            '
            'TxtServer
            '
            Me.TxtServer.Location = New System.Drawing.Point(185, 42)
            Me.TxtServer.Name = "TxtServer"
            Me.TxtServer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtServer.Properties.Appearance.Options.UseFont = True
            Me.TxtServer.Size = New System.Drawing.Size(456, 26)
            Me.TxtServer.StyleController = Me.LayoutCtrl
            Me.TxtServer.TabIndex = 1
            '
            'TxtConnStr
            '
            Me.TxtConnStr.Location = New System.Drawing.Point(185, 162)
            Me.TxtConnStr.Name = "TxtConnStr"
            Me.TxtConnStr.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtConnStr.Properties.Appearance.Options.UseFont = True
            Me.TxtConnStr.Properties.ReadOnly = True
            Me.TxtConnStr.Size = New System.Drawing.Size(456, 26)
            Me.TxtConnStr.StyleController = Me.LayoutCtrl
            Me.TxtConnStr.TabIndex = 6
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LciChkEnableScanner, Me.LayoutControlGroup2})
            Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(665, 482)
            '
            'LciChkEnableScanner
            '
            Me.LciChkEnableScanner.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LciChkEnableScanner.AppearanceItemCaption.Options.UseFont = True
            Me.LciChkEnableScanner.Control = Me.ChkScannerLogin
            Me.LciChkEnableScanner.Location = New System.Drawing.Point(0, 192)
            Me.LciChkEnableScanner.Name = "LciChkEnableScanner"
            Me.LciChkEnableScanner.Size = New System.Drawing.Size(645, 270)
            Me.LciChkEnableScanner.Text = "Enable Scanner Login:"
            Me.LciChkEnableScanner.TextSize = New System.Drawing.Size(158, 19)
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LciPw, Me.LciSqlServer, Me.LciDb, Me.LciUserName, Me.LciConnStr})
            Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(645, 192)
            Me.LayoutControlGroup2.Text = "Sql Settings"
            '
            'LciPw
            '
            Me.LciPw.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LciPw.AppearanceItemCaption.Options.UseFont = True
            Me.LciPw.Control = Me.TxtPwd
            Me.LciPw.Location = New System.Drawing.Point(0, 90)
            Me.LciPw.Name = "LciPw"
            Me.LciPw.Size = New System.Drawing.Size(621, 30)
            Me.LciPw.Text = "Password:"
            Me.LciPw.TextSize = New System.Drawing.Size(158, 19)
            '
            'LciSqlServer
            '
            Me.LciSqlServer.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LciSqlServer.AppearanceItemCaption.Options.UseFont = True
            Me.LciSqlServer.Control = Me.TxtServer
            Me.LciSqlServer.Location = New System.Drawing.Point(0, 0)
            Me.LciSqlServer.Name = "LciSqlServer"
            Me.LciSqlServer.Size = New System.Drawing.Size(621, 30)
            Me.LciSqlServer.Text = "Server Instance:"
            Me.LciSqlServer.TextSize = New System.Drawing.Size(158, 19)
            '
            'LciDb
            '
            Me.LciDb.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LciDb.AppearanceItemCaption.Options.UseFont = True
            Me.LciDb.Control = Me.TxtDb
            Me.LciDb.Location = New System.Drawing.Point(0, 30)
            Me.LciDb.Name = "LciDb"
            Me.LciDb.Size = New System.Drawing.Size(621, 30)
            Me.LciDb.Text = "Database Name:"
            Me.LciDb.TextSize = New System.Drawing.Size(158, 19)
            '
            'LciUserName
            '
            Me.LciUserName.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LciUserName.AppearanceItemCaption.Options.UseFont = True
            Me.LciUserName.Control = Me.TxtUser
            Me.LciUserName.Location = New System.Drawing.Point(0, 60)
            Me.LciUserName.Name = "LciUserName"
            Me.LciUserName.Size = New System.Drawing.Size(621, 30)
            Me.LciUserName.Text = "User Name:"
            Me.LciUserName.TextSize = New System.Drawing.Size(158, 19)
            '
            'LciConnStr
            '
            Me.LciConnStr.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LciConnStr.AppearanceItemCaption.Options.UseFont = True
            Me.LciConnStr.Control = Me.TxtConnStr
            Me.LciConnStr.CustomizationFormText = "Password:"
            Me.LciConnStr.Location = New System.Drawing.Point(0, 120)
            Me.LciConnStr.Name = "LciConnStr"
            Me.LciConnStr.Size = New System.Drawing.Size(621, 30)
            Me.LciConnStr.Text = "Connection String:"
            Me.LciConnStr.TextSize = New System.Drawing.Size(158, 19)
            '
            'ViewCfg
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutCtrl)
            Me.Name = "ViewCfg"
            Me.Size = New System.Drawing.Size(665, 482)
            CType(Me.LayoutCtrl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutCtrl.ResumeLayout(False)
            CType(Me.ChkScannerLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtPwd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtConnStr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LciChkEnableScanner, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LciPw, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LciSqlServer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LciDb, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LciUserName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LciConnStr, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

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