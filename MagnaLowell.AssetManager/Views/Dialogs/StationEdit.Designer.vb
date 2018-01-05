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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(511, 205)
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(654, 196)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ComboStatusTag
        '
        Me.ComboStatusTag.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboStatusTag.Location = New System.Drawing.Point(184, 159)
        Me.ComboStatusTag.Name = "ComboStatusTag"
        Me.ComboStatusTag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboStatusTag.Properties.DataSource = Me.DisplayCfgTagBindingSource
        Me.ComboStatusTag.Properties.DisplayMember = "DeviceName"
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
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 26)
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
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ergonomic Category"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Min. Training Hours"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Days of Consideration"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 26)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Shop Logix Folder Path"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 26)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(660, 237)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'StationEdit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(660, 237)
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
End Class
