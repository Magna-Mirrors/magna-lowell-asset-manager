Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class ViewLine
    Implements IView(Of LineViewModel)
    Implements IEditControl(Of LineViewModel)

    Public ReadOnly Property Title As String Implements IView.Title
        Get
            Return "Line Data"
        End Get
    End Property

    Public ReadOnly Property Control As UserControl Implements IView.Control
        Get
            Return Me
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        NudMaxLogins.Properties.MaxValue = Decimal.MaxValue - 1
        ComboSchedulerMode.Properties.AddEnum(Of SchedulerMode)()
    End Sub

    Dim _data As LineViewModel
    Public Sub LoadView(data As LineViewModel) Implements IView(Of LineViewModel).LoadView, IEditControl(Of LineViewModel).LoadView
        _data = data
        CustomerBindingSource.DataSource = _data.Customers
        CustomerBindingSource.ResetBindings(True)
        TxtId.Text = _data.SelectedLine.Id.ToString()
        TxtName.Text = _data.SelectedLine.LineName
        TxtWcf.Text = _data.SelectedLine.WcfFileName
        NudMaxLogins.Value = _data.SelectedLine.MaxConcurrentLogins
        TxtDept.Text = _data.SelectedLine.Dept
        TxtDefinition.Text = _data.SelectedLine.Definition
        TxtSelectCmd.Text = _data.SelectedLine.SelectCommand
        TxtScheduleFolder.Text = _data.SelectedLine.ScheduleFolder
        TxtWorkCell.Text = _data.SelectedLine.Workcell
        NudBufferMin.Value = _data.SelectedLine.WorkBufferMinutes
        NudReorderPercent.Value = _data.SelectedLine.ReOrderPercentThreshold
        ComboSchedulerMode.EditValue = _data.SelectedLine.SchedulerMethod
        ComboCustomer.EditValue = _data.SelectedLine.CustomerId
    End Sub

    Public Function Save() As Boolean Implements IView(Of LineViewModel).Save, IEditControl(Of LineViewModel).Save
        If _namepass Then
            _data.SelectedLine.LineName = TxtName.Text
            _data.SelectedLine.WcfFileName = TxtWcf.Text
            _data.SelectedLine.MaxConcurrentLogins = CInt(NudMaxLogins.Value)
            _data.SelectedLine.Dept = TxtDept.Text
            _data.SelectedLine.Definition = TxtDefinition.Text
            _data.SelectedLine.SelectCommand = TxtSelectCmd.Text
            _data.SelectedLine.ScheduleFolder = TxtScheduleFolder.Text
            _data.SelectedLine.Workcell = TxtWorkCell.Text
            _data.SelectedLine.WorkBufferMinutes = NudBufferMin.Value
            _data.SelectedLine.ReOrderPercentThreshold = NudReorderPercent.Value
            _data.SelectedLine.SchedulerMethod = CType(ComboSchedulerMode.EditValue, SchedulerMode)
            _data.SelectedLine.CustomerId = CType(ComboCustomer.EditValue, Integer?)

            If _data.SelectedLine.Id = 0 Then
                _data.SelectedLine.EditState = EditState.Create
            Else
                _data.SelectedLine.EditState = EditState.Edit
            End If
            Return True
        End If
        Return False
    End Function


    Private _namepass As Boolean
    Private Sub TxtName_EditValueChanged(sender As Object, e As EventArgs) Handles TxtName.EditValueChanged
        Dim val = TxtName.Text
        Dim nameUnique = Not _data.AllLines.Any(Function(x) x.Id <> _data.SelectedLine.Id AndAlso x.LineName = val)
        Dim nameNotBlank = Not String.IsNullOrWhiteSpace(TxtName.Text)
        _namepass = nameUnique AndAlso nameNotBlank
        If Not _namepass Then
            TxtName.BackColor = Color.PaleVioletRed
        Else
            TxtName.ResetBackColor()
        End If
    End Sub

    Public Function DataValidated() As Boolean Implements IEditControl(Of LineViewModel).DataValidated
        Return _namepass
    End Function
End Class


