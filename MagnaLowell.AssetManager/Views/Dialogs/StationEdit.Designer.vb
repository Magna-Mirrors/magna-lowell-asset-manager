<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StationEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.StationBs = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboStatusTag = New DevExpress.XtraEditors.LookUpEdit()
        Me.DisplayCfgTagBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboErgoCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.ErgonomicCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.NudMinTrainingHours = New System.Windows.Forms.NumericUpDown()
        Me.NudDaysOfConsideration = New System.Windows.Forms.NumericUpDown()
        Me.TxtShopLogixPath = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.StatusEnumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoNudState = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.BtnAddState = New System.Windows.Forms.Button()
        Me.BtnEditState = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.StationBs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ComboStatusTag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayCfgTagBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboErgoCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErgonomicCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMinTrainingHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDaysOfConsideration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusEnumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoNudState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(511, 443)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'StationBs
        '
        Me.StationBs.DataSource = GetType(MagnaLowell.AssetManager.Station)
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ComboStatusTag, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboErgoCategory, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtDescription, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NudMinTrainingHours, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.NudDaysOfConsideration, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtShopLogixPath, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(654, 434)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ComboStatusTag
        '
        Me.ComboStatusTag.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboStatusTag.Location = New System.Drawing.Point(184, 159)
        Me.ComboStatusTag.Name = "ComboStatusTag"
        Me.ComboStatusTag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboStatusTag.Properties.DataSource = Me.DisplayCfgTagBindingSource
        Me.ComboStatusTag.Properties.DisplayMember = "DisplayName"
        Me.ComboStatusTag.Properties.ValueMember = "TagId"
        Me.ComboStatusTag.Size = New System.Drawing.Size(467, 20)
        Me.ComboStatusTag.TabIndex = 3
        '
        'DisplayCfgTagBindingSource
        '
        Me.DisplayCfgTagBindingSource.DataSource = GetType(MagnaLowell.AssetManager.DisplayCfgTag)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboErgoCategory
        '
        Me.ComboErgoCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboErgoCategory.Location = New System.Drawing.Point(184, 55)
        Me.ComboErgoCategory.Name = "ComboErgoCategory"
        Me.ComboErgoCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboErgoCategory.Properties.DataSource = Me.ErgonomicCategoryBindingSource
        Me.ComboErgoCategory.Properties.DisplayMember = "Name"
        Me.ComboErgoCategory.Properties.ValueMember = "ErgId"
        Me.ComboErgoCategory.Size = New System.Drawing.Size(467, 20)
        Me.ComboErgoCategory.TabIndex = 2
        '
        'ErgonomicCategoryBindingSource
        '
        Me.ErgonomicCategoryBindingSource.DataSource = GetType(MagnaLowell.AssetManager.ErgonomicCategory)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ergonomic Category"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Min. Training Hours"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Days of Consideration"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Shop Logix Folder Path"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status Tag Assignment"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.Location = New System.Drawing.Point(184, 3)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(467, 20)
        Me.TxtName.TabIndex = 8
        '
        'TxtDescription
        '
        Me.TxtDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescription.Location = New System.Drawing.Point(184, 29)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(467, 20)
        Me.TxtDescription.TabIndex = 9
        '
        'NudMinTrainingHours
        '
        Me.NudMinTrainingHours.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NudMinTrainingHours.Location = New System.Drawing.Point(184, 81)
        Me.NudMinTrainingHours.Name = "NudMinTrainingHours"
        Me.NudMinTrainingHours.Size = New System.Drawing.Size(467, 20)
        Me.NudMinTrainingHours.TabIndex = 11
        '
        'NudDaysOfConsideration
        '
        Me.NudDaysOfConsideration.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NudDaysOfConsideration.Location = New System.Drawing.Point(184, 107)
        Me.NudDaysOfConsideration.Name = "NudDaysOfConsideration"
        Me.NudDaysOfConsideration.Size = New System.Drawing.Size(467, 20)
        Me.NudDaysOfConsideration.TabIndex = 12
        '
        'TxtShopLogixPath
        '
        Me.TxtShopLogixPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtShopLogixPath.Location = New System.Drawing.Point(184, 133)
        Me.TxtShopLogixPath.Name = "TxtShopLogixPath"
        Me.TxtShopLogixPath.Size = New System.Drawing.Size(467, 20)
        Me.TxtShopLogixPath.TabIndex = 13
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GridControl1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnAddState, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnEditState, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(184, 185)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(467, 246)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.StatusEnumBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(45, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoNudState})
        Me.TableLayoutPanel4.SetRowSpan(Me.GridControl1, 2)
        Me.GridControl1.Size = New System.Drawing.Size(419, 240)
        Me.GridControl1.TabIndex = 14
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StatusEnumBindingSource
        '
        Me.StatusEnumBindingSource.DataSource = GetType(MagnaLowell.AssetManager.StatusEnum)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colState, Me.colDescription, Me.colEditState})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.OptionsColumn.ReadOnly = True
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 47
        '
        'colState
        '
        Me.colState.FieldName = "State"
        Me.colState.Name = "colState"
        Me.colState.Visible = True
        Me.colState.VisibleIndex = 1
        Me.colState.Width = 117
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 117
        '
        'colEditState
        '
        Me.colEditState.FieldName = "EditState"
        Me.colEditState.Name = "colEditState"
        Me.colEditState.OptionsColumn.AllowEdit = False
        Me.colEditState.OptionsColumn.ReadOnly = True
        Me.colEditState.Visible = True
        Me.colEditState.VisibleIndex = 3
        Me.colEditState.Width = 120
        '
        'RepoNudState
        '
        Me.RepoNudState.AutoHeight = False
        Me.RepoNudState.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepoNudState.IsFloatValue = False
        Me.RepoNudState.Mask.EditMask = "N00"
        Me.RepoNudState.Name = "RepoNudState"
        '
        'BtnAddState
        '
        Me.BtnAddState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddState.AutoSize = True
        Me.BtnAddState.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnAddState.Location = New System.Drawing.Point(3, 97)
        Me.BtnAddState.Name = "BtnAddState"
        Me.BtnAddState.Size = New System.Drawing.Size(36, 23)
        Me.BtnAddState.TabIndex = 15
        Me.BtnAddState.Text = "Add"
        Me.BtnAddState.UseVisualStyleBackColor = True
        '
        'BtnEditState
        '
        Me.BtnEditState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditState.AutoSize = True
        Me.BtnEditState.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEditState.Location = New System.Drawing.Point(3, 126)
        Me.BtnEditState.Name = "BtnEditState"
        Me.BtnEditState.Size = New System.Drawing.Size(36, 23)
        Me.BtnEditState.TabIndex = 16
        Me.BtnEditState.Text = "Edit"
        Me.BtnEditState.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "State Enums"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(660, 475)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'StationEdit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(660, 475)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StationEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StationEdit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.StationBs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ComboStatusTag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayCfgTagBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboErgoCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErgonomicCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMinTrainingHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDaysOfConsideration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusEnumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoNudState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents StationBs As BindingSource
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents NudMinTrainingHours As NumericUpDown
    Friend WithEvents NudDaysOfConsideration As NumericUpDown
    Friend WithEvents TxtShopLogixPath As TextBox
    Friend WithEvents ComboErgoCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ComboStatusTag As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ErgonomicCategoryBindingSource As BindingSource
    Friend WithEvents DisplayCfgTagBindingSource As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StatusEnumBindingSource As BindingSource
    Friend WithEvents RepoNudState As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BtnAddState As Button
    Friend WithEvents BtnEditState As Button
End Class
