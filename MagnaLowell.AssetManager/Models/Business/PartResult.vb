Imports MagnaLowell.AssetManager

Public Class PartResult
    Implements ICopy(Of PartResult), IEditModel

    Public Sub New()

    End Sub
    Public Sub New(partRes As PartResult)
        partRes.CopyTo(Me)
    End Sub

    Public Property Id As Integer
    Public Property Code As Integer
    Public Property LineId As Integer
    Public Property Description As String
    Public Property EditState As EditState Implements IEditModel.EditState

    Public Sub CopyTo(item As PartResult) Implements ICopy(Of PartResult).CopyTo
        item.Id = Id
        item.Code = Code
        item.LineId = LineId
        item.Description = Description
        item.EditState = EditState
    End Sub
End Class
