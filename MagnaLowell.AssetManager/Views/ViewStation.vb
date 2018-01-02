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
    Private _workingData As List(Of Station)
    Public Sub LoadView(data As StationViewModel) Implements IView(Of StationViewModel).LoadView

        _data = data
        _workingData = data.FilteredStations.Select(Function(x) New Station(x)).ToList()
        '= New StationViewModel(New Line(data.SelectedLine),
        '                                data.FilteredStations.Select(Function(x) New Station(x)).ToList(),
        '                                data.ErgoCategories, data.Tags)
        StationBindingSource.DataSource = _workingData
        ErgonomicCategoryBindingSource.DataSource = _data.ErgoCategories
        CfgTagBindingSource.DataSource = _data.Tags
    End Sub

    Public Function Save() As Boolean Implements IView.Save

        For Each sta In _workingData.Where(Function(x) x.EditState <> EditState.None)
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


    Private Sub GridView1_ShownEditor(sender As Object, e As EventArgs) Handles GridView1.ShownEditor
        Dim view = TryCast(sender, GridView)
        If view.FocusedColumn Is colStatusTagId Then ' view.ActiveEditor Is LookUpEditStatusTag Then



            Dim otherStations = _data.AllStations.Where(Function(x) Not _workingData.Select(Function(y) y.Id).Contains(x.Id))
            Dim allStations = _workingData.Union(otherStations)

            For Each t In _data.Tags

                Dim sta = allStations.FirstOrDefault(Function(x) x.StatusTagId IsNot Nothing AndAlso
                                                                CInt(x.StatusTagId) = t.TagId)
            Next
            'Dim tags = _workingData.Tags.Where(Function(x) Not usedTagIds.Contains(x.TagId))
            Dim lookup = TryCast(view.ActiveEditor, LookUpEdit)


            lookup.Properties.DataSource = _data.Tags
            'CfgTagBindingSource.DataSource = tags
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim item = TryCast(GridView1.GetRow(e.RowHandle), Station)
        If item IsNot Nothing AndAlso item.EditState = EditState.None Then
            'item.EditState = If(item.Id = 0, EditState.Create, EditState.Edit)
            If item.StatusTagId.HasValue Then
                Dim tagid = item.StatusTagId.Value
                Dim found = _workingData.Where(Function(x) x IsNot item AndAlso
                                                 x.StatusTagId.HasValue AndAlso
                                                 x.StatusTagId.Value = tagid)
                For Each f In found
                    f.StatusTagId = Nothing
                    f.EditState = EditState.Edit
                Next
            End If
            StationBindingSource.ResetBindings(False)
        End If
    End Sub
    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        Dim item = TryCast(GridView1.GetRow(e.RowHandle), Station)
        If item Is Nothing Then
            Return
        End If
        Dim different As Boolean = False
        If e.Value.GetType Is GetType(Integer) Then
            Dim oldvalue = CInt(GridView1.GetFocusedRowCellValue(e.Column))
            Dim newValue = CInt(e.Value)
            different = oldvalue <> newValue
        ElseIf e.Value.GetType Is GetType(String) Then
            Dim oldvalue = CStr(GridView1.GetFocusedRowCellValue(e.Column))
            Dim newValue = CStr(e.Value)
            different = oldvalue <> newValue
        End If
        If different Then
            item.EditState = If(item.Id = 0, EditState.Create, EditState.Edit)
        End If
    End Sub

    Private Sub GridView1_ValidatingEditor(sender As Object, e As Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        If GridView1.FocusedColumn Is colStatusTagId Then

            Dim item = TryCast(GridView1.GetFocusedRow, Station)
            Dim tagid As Integer? = CType(e.Value, Integer?)
            If tagid.HasValue Then
                Dim tid = tagid.Value

                Dim otherStations = _data.AllStations.Where(Function(x) Not _workingData.Select(Function(y) y.Id).Contains(x.Id))


                Dim foundOtherUses = otherStations.Any(Function(x) x.StatusTagId.HasValue AndAlso x.StatusTagId.Value = tid)
                If foundOtherUses Then
                    Dim dilgRes = MessageBox.Show(Me, "The selected tag is already in use. Selecting yes will null the other station's status tag id value.", "Tag Conflict", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk)
                    If dilgRes <> DialogResult.Yes Then
                        'e.Valid = False
                        Dim value = CInt(GridView1.GetFocusedRowCellValue(colStatusTagId))

                        If CInt(e.Value) = item.StatusTagId Then
                            Throw New Exception()
                        End If
                        e.Value = item.StatusTagId

                        'GridView1.SetFocusedRowCellValue(colStatusTagId, item.StatusTagId)
                        'GridView1.SetFocusedValue(item.StatusTagId)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub eButton_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles eButton.ButtonClick
        Dim R = GridView1.GetSelectedRows(0)
        'get the Row
        'open a dialog
        'edit your stuff
    End Sub
End Class


