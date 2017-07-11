<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewStation
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleUniqueDuplicate1 As DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate = New DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.StationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colErgonomicId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditErgonomic = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ErgonomicCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colMinTrainingHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SpinEditMinTrainingHours = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colDaysofConsideration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SpinEditDaysOfConsideration = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colShopLogixFolderName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatusTagId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditStatusTag = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CfgTagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colEditState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditErgonomic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErgonomicCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEditMinTrainingHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEditDaysOfConsideration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditStatusTag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CfgTagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1024, 380)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.StationBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SpinEditMinTrainingHours, Me.SpinEditDaysOfConsideration, Me.LookUpEditErgonomic, Me.LookUpEditStatusTag})
        Me.GridControl1.Size = New System.Drawing.Size(1000, 356)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StationBindingSource
        '
        Me.StationBindingSource.DataSource = GetType(MagnaLowell.AssetManager.Station)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colErgonomicId, Me.colMinTrainingHours, Me.colDaysofConsideration, Me.colShopLogixFolderName, Me.colName, Me.colDescription, Me.colStatusTagId, Me.colEditState})
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleUniqueDuplicate1.Appearance.BackColor = System.Drawing.Color.IndianRed
        FormatConditionRuleUniqueDuplicate1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatConditionRuleUniqueDuplicate1.Appearance.Options.HighPriority = True
        FormatConditionRuleUniqueDuplicate1.Appearance.Options.UseBackColor = True
        FormatConditionRuleUniqueDuplicate1.Appearance.Options.UseFont = True
        GridFormatRule1.Rule = FormatConditionRuleUniqueDuplicate1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colErgonomicId
        '
        Me.colErgonomicId.ColumnEdit = Me.LookUpEditErgonomic
        Me.colErgonomicId.FieldName = "ErgonomicId"
        Me.colErgonomicId.Name = "colErgonomicId"
        Me.colErgonomicId.Visible = True
        Me.colErgonomicId.VisibleIndex = 0
        '
        'LookUpEditErgonomic
        '
        Me.LookUpEditErgonomic.AutoHeight = False
        Me.LookUpEditErgonomic.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditErgonomic.DataSource = Me.ErgonomicCategoryBindingSource
        Me.LookUpEditErgonomic.DisplayMember = "Name"
        Me.LookUpEditErgonomic.KeyMember = "ErgId"
        Me.LookUpEditErgonomic.Name = "LookUpEditErgonomic"
        Me.LookUpEditErgonomic.ValueMember = "ErgId"
        '
        'ErgonomicCategoryBindingSource
        '
        Me.ErgonomicCategoryBindingSource.DataSource = GetType(MagnaLowell.AssetManager.ErgonomicCategory)
        '
        'colMinTrainingHours
        '
        Me.colMinTrainingHours.ColumnEdit = Me.SpinEditMinTrainingHours
        Me.colMinTrainingHours.FieldName = "MinTrainingHours"
        Me.colMinTrainingHours.Name = "colMinTrainingHours"
        Me.colMinTrainingHours.Visible = True
        Me.colMinTrainingHours.VisibleIndex = 1
        '
        'SpinEditMinTrainingHours
        '
        Me.SpinEditMinTrainingHours.AutoHeight = False
        Me.SpinEditMinTrainingHours.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEditMinTrainingHours.IsFloatValue = False
        Me.SpinEditMinTrainingHours.Mask.EditMask = "N00"
        Me.SpinEditMinTrainingHours.Name = "SpinEditMinTrainingHours"
        '
        'colDaysofConsideration
        '
        Me.colDaysofConsideration.ColumnEdit = Me.SpinEditDaysOfConsideration
        Me.colDaysofConsideration.FieldName = "DaysofConsideration"
        Me.colDaysofConsideration.Name = "colDaysofConsideration"
        Me.colDaysofConsideration.Visible = True
        Me.colDaysofConsideration.VisibleIndex = 2
        '
        'SpinEditDaysOfConsideration
        '
        Me.SpinEditDaysOfConsideration.AutoHeight = False
        Me.SpinEditDaysOfConsideration.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEditDaysOfConsideration.IsFloatValue = False
        Me.SpinEditDaysOfConsideration.Mask.EditMask = "N00"
        Me.SpinEditDaysOfConsideration.Name = "SpinEditDaysOfConsideration"
        '
        'colShopLogixFolderName
        '
        Me.colShopLogixFolderName.FieldName = "ShopLogixFolderName"
        Me.colShopLogixFolderName.Name = "colShopLogixFolderName"
        Me.colShopLogixFolderName.Visible = True
        Me.colShopLogixFolderName.VisibleIndex = 3
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 4
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        '
        'colStatusTagId
        '
        Me.colStatusTagId.ColumnEdit = Me.LookUpEditStatusTag
        Me.colStatusTagId.FieldName = "StatusTagId"
        Me.colStatusTagId.Name = "colStatusTagId"
        Me.colStatusTagId.Visible = True
        Me.colStatusTagId.VisibleIndex = 6
        '
        'LookUpEditStatusTag
        '
        Me.LookUpEditStatusTag.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEditStatusTag.AutoHeight = False
        Me.LookUpEditStatusTag.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditStatusTag.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Display Name", 87, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InUse", "In Use", 41, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayUsedByStation", "Used By Station", 123, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEditStatusTag.DataSource = Me.CfgTagBindingSource
        Me.LookUpEditStatusTag.DisplayMember = "DisplayName"
        Me.LookUpEditStatusTag.KeyMember = "TagId"
        Me.LookUpEditStatusTag.Name = "LookUpEditStatusTag"
        Me.LookUpEditStatusTag.ValueMember = "TagId"
        '
        'CfgTagBindingSource
        '
        Me.CfgTagBindingSource.DataSource = GetType(MagnaLowell.AssetManager.DisplayCfgTag)
        '
        'colEditState
        '
        Me.colEditState.FieldName = "EditState"
        Me.colEditState.Name = "colEditState"
        Me.colEditState.OptionsColumn.AllowEdit = False
        Me.colEditState.OptionsColumn.ReadOnly = True
        Me.colEditState.Visible = True
        Me.colEditState.VisibleIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1024, 380)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1004, 360)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'ViewStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ViewStation"
        Me.Size = New System.Drawing.Size(1024, 380)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditErgonomic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErgonomicCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEditMinTrainingHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEditDaysOfConsideration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditStatusTag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CfgTagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents StationBindingSource As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colErgonomicId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinTrainingHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpinEditMinTrainingHours As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colDaysofConsideration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpinEditDaysOfConsideration As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colShopLogixFolderName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusTagId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LookUpEditErgonomic As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ErgonomicCategoryBindingSource As BindingSource
    Friend WithEvents LookUpEditStatusTag As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CfgTagBindingSource As BindingSource
End Class
