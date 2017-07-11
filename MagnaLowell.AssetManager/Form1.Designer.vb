Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, true, true, true)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BtnEditItems = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEditAssetResults = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEditStationEnums = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEditLines = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.BarUser = New DevExpress.XtraBars.Bar()
        Me.BtnLogOut = New DevExpress.XtraBars.BarButtonItem()
        Me.LblUser = New DevExpress.XtraBars.BarHeaderItem()
        Me.LblUserLevel = New DevExpress.XtraBars.BarHeaderItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarToolbarsListItem1 = New DevExpress.XtraBars.BarToolbarsListItem()
        Me.BarToolbarsListItem2 = New DevExpress.XtraBars.BarToolbarsListItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.LblCtrlName = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCtrlName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCtrlName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(12, 36)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1076, 523)
        Me.PanelControl1.TabIndex = 1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PictureEdit1)
        Me.LayoutControl1.Controls.Add(Me.LblCtrlName)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3799, 427, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1100, 571)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.Location = New System.Drawing.Point(130, 12)
        Me.PictureEdit1.MenuManager = Me.BarManager1
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.NullText = " "
        Me.PictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(958, 20)
        Me.PictureEdit1.StyleController = Me.LayoutControl1
        Me.PictureEdit1.TabIndex = 8
        Me.PictureEdit1.Visible = False
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.BarUser})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarToolbarsListItem1, Me.BarToolbarsListItem2, Me.BarSubItem1, Me.BarSubItem2, Me.BtnEditItems, Me.BtnEditStationEnums, Me.BarBtnSave, Me.BtnSettings, Me.BtnLogOut, Me.LblUser, Me.LblUserLevel, Me.BtnEditAssetResults, Me.BtnEdit, Me.BtnDelete, Me.BtnEditLines})
        Me.BarManager1.MaxItemId = 20
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.BarBtnSave, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnDelete)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "View"
        Me.BarSubItem2.Id = 3
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEditItems), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEditAssetResults), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEditStationEnums), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnSettings), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEditLines)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BtnEditItems
        '
        Me.BtnEditItems.Caption = "Edit schema"
        Me.BtnEditItems.Id = 4
        Me.BtnEditItems.Name = "BtnEditItems"
        Me.BtnEditItems.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BtnEditAssetResults
        '
        Me.BtnEditAssetResults.Caption = "Edit Asset Result Enums"
        Me.BtnEditAssetResults.Id = 14
        Me.BtnEditAssetResults.Name = "BtnEditAssetResults"
        Me.BtnEditAssetResults.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BtnEditStationEnums
        '
        Me.BtnEditStationEnums.Caption = "Edit Station Enums"
        Me.BtnEditStationEnums.Id = 6
        Me.BtnEditStationEnums.Name = "BtnEditStationEnums"
        Me.BtnEditStationEnums.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BtnSettings
        '
        Me.BtnSettings.Caption = "Settings"
        Me.BtnSettings.Id = 8
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BtnEditLines
        '
        Me.BtnEditLines.Caption = "Edit Lines"
        Me.BtnEditLines.Id = 19
        Me.BtnEditLines.Name = "BtnEditLines"
        '
        'BarBtnSave
        '
        Me.BarBtnSave.Caption = "SAVE "
        Me.BarBtnSave.Id = 7
        Me.BarBtnSave.ImageOptions.Image = Global.MagnaLowell.AssetManager.My.Resources.Resources.database_save
        Me.BarBtnSave.Name = "BarBtnSave"
        '
        'BtnEdit
        '
        Me.BtnEdit.Caption = "Edit"
        Me.BtnEdit.Id = 16
        Me.BtnEdit.ImageOptions.Image = Global.MagnaLowell.AssetManager.My.Resources.Resources.database_edit
        Me.BtnEdit.Name = "BtnEdit"
        '
        'BtnDelete
        '
        Me.BtnDelete.Caption = "Delete"
        Me.BtnDelete.Id = 17
        Me.BtnDelete.ImageOptions.Image = Global.MagnaLowell.AssetManager.My.Resources.Resources.database_delete
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarUser
        '
        Me.BarUser.BarName = "User"
        Me.BarUser.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.BarUser.DockCol = 1
        Me.BarUser.DockRow = 0
        Me.BarUser.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.BarUser.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnLogOut), New DevExpress.XtraBars.LinkPersistInfo(Me.LblUser), New DevExpress.XtraBars.LinkPersistInfo(Me.LblUserLevel)})
        Me.BarUser.OptionsBar.AllowQuickCustomization = False
        Me.BarUser.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.BarUser.OptionsBar.DisableCustomization = True
        Me.BarUser.OptionsBar.DrawDragBorder = False
        Me.BarUser.Text = "User"
        Me.BarUser.Visible = False
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Caption = "Log Out"
        Me.BtnLogOut.Enabled = False
        Me.BtnLogOut.Id = 10
        Me.BtnLogOut.Name = "BtnLogOut"
        '
        'LblUser
        '
        Me.LblUser.Caption = "User:"
        Me.LblUser.Id = 11
        Me.LblUser.Name = "LblUser"
        '
        'LblUserLevel
        '
        Me.LblUserLevel.Caption = "User Level: "
        Me.LblUserLevel.Id = 13
        Me.LblUserLevel.Name = "LblUserLevel"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1100, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 618)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1100, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 571)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1100, 47)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 571)
        '
        'BarToolbarsListItem1
        '
        Me.BarToolbarsListItem1.Caption = "View"
        Me.BarToolbarsListItem1.Id = 0
        Me.BarToolbarsListItem1.Name = "BarToolbarsListItem1"
        '
        'BarToolbarsListItem2
        '
        Me.BarToolbarsListItem2.Caption = "BarToolbarsListItem2"
        Me.BarToolbarsListItem2.Id = 1
        Me.BarToolbarsListItem2.Name = "BarToolbarsListItem2"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 2
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'LblCtrlName
        '
        Me.LblCtrlName.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCtrlName.Appearance.Options.UseFont = True
        Me.LblCtrlName.Location = New System.Drawing.Point(12, 12)
        Me.LblCtrlName.Name = "LblCtrlName"
        Me.LblCtrlName.Size = New System.Drawing.Size(114, 19)
        Me.LblCtrlName.StyleController = Me.LayoutControl1
        Me.LblCtrlName.TabIndex = 7
        Me.LblCtrlName.Text = "LabelControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AllowCustomizeChildren = False
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.lciCtrlName, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Disable
        Me.LayoutControlGroup1.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Disable
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1100, 571)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1080, 527)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lciCtrlName
        '
        Me.lciCtrlName.Control = Me.LblCtrlName
        Me.lciCtrlName.Location = New System.Drawing.Point(0, 0)
        Me.lciCtrlName.Name = "lciCtrlName"
        Me.lciCtrlName.Size = New System.Drawing.Size(118, 24)
        Me.lciCtrlName.Text = " "
        Me.lciCtrlName.TextSize = New System.Drawing.Size(0, 0)
        Me.lciCtrlName.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PictureEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(118, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(962, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'AlertControl1
        '
        Me.AlertControl1.AutoFormDelay = 2000
        Me.AlertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical
        Me.AlertControl1.PopupMenu = Me.PopupMenu1
        Me.AlertControl1.ShowPinButton = False
        Me.AlertControl1.ShowToolTips = False
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 618)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.LayoutControl1.ResumeLayout(false)
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lciCtrlName,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PopupMenu1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarToolbarsListItem1 As DevExpress.XtraBars.BarToolbarsListItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarToolbarsListItem2 As DevExpress.XtraBars.BarToolbarsListItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BtnEditItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEditStationEnums As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LblCtrlName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lciCtrlName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarUser As DevExpress.XtraBars.Bar
    Friend WithEvents BtnLogOut As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LblUser As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents LblUserLevel As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BtnEditAssetResults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEditLines As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents LblUserLvl As DevExpress.XtraBars.BarStaticItem

#End Region

End Class
