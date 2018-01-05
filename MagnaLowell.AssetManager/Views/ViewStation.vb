Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class ViewStation
    Implements IView(Of StationViewModel)

    Public ReadOnly Property Title As String Implements IView.Title
        Get
            Return "Stations"
        End Get
    End Property

    Public ReadOnly Property Control As UserControl Implements IView.Control
        Get
            Return Me
        End Get
    End Property

    Private _data As StationViewModel
    Private ReadOnly Property _selectedStations As IEnumerable(Of Station)
        Get
            Return _data.FilteredStations.ToList()
        End Get
    End Property
    Private ReadOnly Property SelectedStation As Station
        Get
            Dim R = GridView1.GetSelectedRows(0)
            Return TryCast(GridView1.GetRow(R), Station)
        End Get
    End Property

    Public Sub LoadView(data As StationViewModel) Implements IView(Of StationViewModel).LoadView
        _data = data
        StationBindingSource.DataSource = _selectedStations
        ErgonomicCategoryBindingSource.DataSource = _data.ErgoCategories
        CfgTagBindingSource.DataSource = _data.Tags
    End Sub

    Public Function Save() As Boolean Implements IView.Save
        For Each sta In _selectedStations.Where(Function(x) x.EditState <> EditState.None)
            If sta.EditState = EditState.Create Then
                sta.LineId = _data.SelectedLine.Id
            End If
        Next
        Return True
    End Function


    Private Sub eButton_ButtonClick(sender As Object, e As EventArgs) Handles eButton.ButtonClick, BtnEdit.Click
        Dim dilg = New StationEdit()
        dilg.LoadData(_data, SelectedStation)
        dilg.ShowDialog()
        StationBindingSource.DataSource = _selectedStations
        StationBindingSource.ResetBindings(False)
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim dilg = New StationEdit()
        Dim newstation = New Station() With {.LineId = _data.SelectedLine.Id,
                                            .ErgonomicId = _data.ErgoCategories.First().ErgId,
                                            .EditState = EditState.Create,
                                            .MinTrainingHours = 16,
                                            .DaysofConsideration = 180}
        dilg.LoadData(_data, newstation)
        If dilg.ShowDialog() = DialogResult.OK Then
            _data.AllStations.Add(newstation)
        End If
        StationBindingSource.DataSource = _selectedStations
        StationBindingSource.ResetBindings(False)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If SelectedStation.EditState = EditState.Delete Then
            SelectedStation.EditState = EditState.None
        ElseIf SelectedStation.EditState <> EditState.Create Then
            SelectedStation.EditState = EditState.Delete
        Else
            _data.AllStations.Remove(SelectedStation)
        End If
        StationBindingSource.DataSource = _selectedStations
        StationBindingSource.ResetBindings(False)
        CheckDeleteButtonText()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        CheckDeleteButtonText()
    End Sub

    Private Sub CheckDeleteButtonText()
        If SelectedStation?.EditState = EditState.Delete Then
            BtnDelete.Text = "Undo Delete"
        Else
            BtnDelete.Text = "Delete"
        End If
    End Sub
End Class


