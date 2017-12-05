Public MustInherit Class EditModel
    Public Property EditState As EditState

    'Protected Overridable Sub TrySetEditToUpdate(setToEdit As Boolean)
    '    If setToEdit AndAlso EditState = EditState.None Then
    '        EditState = EditState.Edit
    '    End If
    'End Sub

    'Public Sub MarkAsDelete()
    '    EditState = EditState.Delete
    'End Sub
    'Public Sub ClearState()
    '    EditState = EditState.None
    'End Sub


End Class
Public Interface ICopy(Of T As Class)
    Sub CopyTo(item As T)
End Interface
Public Enum EditState
    None
    Create
    Edit
    Delete
End Enum

Public Enum SchedulerMode
    None = 0
    Wcf = 1
    Sql = 2
End Enum