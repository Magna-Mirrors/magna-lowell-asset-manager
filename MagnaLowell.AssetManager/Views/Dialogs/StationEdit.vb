Imports System.Windows.Forms

Public Class StationEdit

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        _selectedStation.Name = TxtName.Text
        _selectedStation.Description = TxtDescription.Text
        _selectedStation.ShopLogixFolderName = TxtShopLogixPath.Text

        _selectedStation.DaysofConsideration = CInt(NudDaysOfConsideration.Value)
        _selectedStation.MinTrainingHours = CInt(NudMinTrainingHours.Value)

        _selectedStation.ErgonomicId = CInt(ComboErgoCategory.EditValue)
        _selectedStation.StatusTagId = CInt(ComboStatusTag.EditValue)

        _selectedStation.EditState = If(_selectedStation.Id = 0, EditState.Create, EditState.Edit)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private _data As StationViewModel
    Private _selectedStation As Station
    Public Sub LoadData(data As StationViewModel, selectedStation As Station)
        NudDaysOfConsideration.Maximum = Decimal.MaxValue
        NudMinTrainingHours.Maximum = Decimal.MaxValue

        _data = data
        _selectedStation = selectedStation

        ErgonomicCategoryBindingSource.DataSource = _data.ErgoCategories
        DisplayCfgTagBindingSource.DataSource = _data.Tags

        'Dim selectedStation = _data.AllStations.Single(Function(x) x Is _selectedStationId)
        TxtName.Text = _selectedStation.Name
        TxtDescription.Text = _selectedStation.Description
        TxtShopLogixPath.Text = _selectedStation.ShopLogixFolderName

        NudDaysOfConsideration.Value = _selectedStation.DaysofConsideration
        NudMinTrainingHours.Value = _selectedStation.MinTrainingHours

        ComboErgoCategory.EditValue = _selectedStation.ErgonomicId
        ComboStatusTag.EditValue = _selectedStation.StatusTagId


    End Sub

    Private Sub ComboStatusTag_EditValueChanged(sender As Object, e As EventArgs) Handles ComboStatusTag.EditValueChanged
        Dim tid = CInt(ComboStatusTag.EditValue)
        Dim otherStations = _data.AllStations.Where(Function(x) x IsNot _selectedStation) 'Not _selectedStations.Select(Function(y) y.Id).Contains(x.Id))
        Dim foundOtherUses = otherStations.Any(Function(x) x.StatusTagId.HasValue AndAlso x.StatusTagId.Value = tid)
        If foundOtherUses Then
            Dim dilgRes = MessageBox.Show(Me, "The selected tag is already in use. Selecting yes will null the other station's status tag id value.", "Tag Conflict", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk)
            If dilgRes <> DialogResult.Yes Then
                ComboStatusTag.EditValue = Nothing
            End If
        End If
    End Sub
End Class
