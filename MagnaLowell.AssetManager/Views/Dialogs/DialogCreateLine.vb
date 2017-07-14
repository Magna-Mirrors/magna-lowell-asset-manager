Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class DialogCreateLine
    Implements IEditControl(Of LineViewModel)

    Public Sub LoadView(data As LineViewModel) Implements IEditControl(Of LineViewModel).LoadView
        ViewLine1.LoadView(data)
    End Sub

    Public Function DataValidated() As Boolean Implements IEditControl(Of LineViewModel).DataValidated
        Return ViewLine1.DataValidated()
    End Function

    Public Function Save() As Boolean Implements IEditControl(Of LineViewModel).Save
        Return ViewLine1.Save()
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ViewLine1.DataValidated() Then
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class