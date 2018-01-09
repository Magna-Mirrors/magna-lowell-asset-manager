Imports MagnaLowell.AssetManager

Public Class StatusEnum
    Implements ICopy(Of StatusEnum), IEditModel

    Public Sub New(se As StatusEnum)
        se.CopyTo(Me)
    End Sub
    Public Sub New()

    End Sub

    Public Sub CopyTo(item As StatusEnum) Implements ICopy(Of StatusEnum).CopyTo
        item.Id = Id
        item.StationId = StationId
        item.State = State
        item.Description = Description
        item.EditState = EditState
    End Sub

    Public Property Id As Integer
    Public Property StationId As Integer
    Public Property State As Integer
    Public Property Description As String
    Public Property EditState As EditState Implements IEditModel.EditState
End Class
