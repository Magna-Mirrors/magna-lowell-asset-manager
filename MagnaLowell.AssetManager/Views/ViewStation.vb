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
                _data.AllStations.Add(sta)
            ElseIf sta.EditState = EditState.Edit Then
                Dim found As Station = _data.AllStations.Single(Function(x) x.Id = sta.Id)
                sta.CopyTo(found)
            End If
        Next
        Return True
    End Function

    Private Sub eButton_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles eButton.ButtonClick
        Dim R = GridView1.GetSelectedRows(0)
        Dim selectedStation = TryCast(GridView1.GetRow(R), Station)
        Dim dilg = New StationEdit()
        dilg.LoadData(_data, selectedStation)
        dilg.ShowDialog()
        StationBindingSource.DataSource = _selectedStations
        StationBindingSource.ResetBindings(False)
        'get the Row
        'open a dialog
        'edit your stuff
    End Sub
End Class


