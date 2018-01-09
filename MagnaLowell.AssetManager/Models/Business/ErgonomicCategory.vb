Imports MagnaLowell.AssetManager

Public Class ErgonomicCategory
    Implements ICopy(Of ErgonomicCategory), IEditModel


    Public Property ErgId As Integer
    Public Property Name As String
    Public Property DurrationHrs As Decimal
    Public Property SpanHrs As Decimal
    Public Property RestHrs As Decimal
    Public Property EditState As EditState Implements IEditModel.EditState

    Public Sub CopyTo(item As ErgonomicCategory) Implements ICopy(Of ErgonomicCategory).CopyTo
        item.ErgId = ErgId
        item.Name = Name
        item.DurrationHrs = DurrationHrs
        item.SpanHrs = SpanHrs
        item.RestHrs = RestHrs
        item.EditState = EditState
    End Sub
End Class
