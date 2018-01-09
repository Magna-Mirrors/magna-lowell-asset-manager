Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class ViewPartResults
    Implements IView(Of PartResultsViewModel)

    Public ReadOnly Property Title As String Implements IView.Title
        Get
            Return "Part Results"
        End Get
    End Property

    Public ReadOnly Property Control As UserControl Implements IView.Control
        Get
            Return Me
        End Get
    End Property

    Private Property _originalData As PartResultsViewModel
    Private Property _workingData As PartResultsViewModel
    Public Sub LoadView(data As PartResultsViewModel) Implements IView(Of PartResultsViewModel).LoadView
        _originalData = data
        _workingData = New PartResultsViewModel(_originalData.PartResultsFiltered.Select(Function(x) New PartResult(x)).ToList(), data.Line)
        PartResultBindingSource.DataSource = _workingData.PartResultsAll
    End Sub

    Public Function Save() As Boolean Implements IView.Save

        If _workingData.PartResultsAll.GroupBy(Function(x) x.Code).Any(Function(x) x.Count > 1) Then
            MessageBox.Show("There is a code being used multiple times. Data not saved.")
            Return False
        End If

        For Each i In _workingData.PartResultsFiltered.Where(Function(x) x.EditState <> EditState.None)
            Dim res = _originalData.PartResultsAll.SingleOrDefault(Function(x) x.Id = i.Id)
            If res IsNot Nothing Then
                i.CopyTo(res)
            Else
                _originalData.PartResultsAll.Add(New PartResult(i) With {.EditState = EditState.Create})
            End If
        Next
        Return True
    End Function

    Private Sub GridView1_RowDeleting(sender As Object, e As DevExpress.Data.RowDeletingEventArgs) Handles GridView1.RowDeleting
        e.Cancel = True
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim item = TryCast(GridView1.GetRow(e.RowHandle), PartResult)
        If item.Id = 0 Then
            item.EditState = EditState.Create
            item.LineId = _originalData.Line.Id
        ElseIf item.EditState = EditState.None Then
            item.EditState = EditState.Edit
        End If
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim val = TryCast(e.Row, PartResult)
        If val Is Nothing Then
            Return
        End If
        e.Valid = Not _workingData.PartResultsFiltered.Any(Function(x) x IsNot val AndAlso val.Code = x.Code)
    End Sub
End Class


