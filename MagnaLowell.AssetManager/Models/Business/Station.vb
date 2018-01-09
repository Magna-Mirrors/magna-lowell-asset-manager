Imports MagnaLowell.AssetManager

Public Class Station
    Implements ICopy(Of Station), IEditModel

    Public Sub New(s As Station)
        s.CopyTo(Me)
    End Sub
    Public Sub New()

    End Sub

    Public Sub CopyTo(item As Station) Implements ICopy(Of Station).CopyTo
        item.Id = Id
        item.LineId = LineId
        item.ErgonomicId = ErgonomicId
        item.MinTrainingHours = MinTrainingHours
        item.DaysofConsideration = DaysofConsideration
        item.ShopLogixFolderName = ShopLogixFolderName
        item.Name = Name
        item.Description = Description
        item.StatusTagId = StatusTagId
        item.EditState = EditState
    End Sub

    Public Property Id As Integer
    Public Property LineId As Integer
    Public Property ErgonomicId As Integer
    Public Property MinTrainingHours As Integer
    Public Property DaysofConsideration As Integer
    Public Property ShopLogixFolderName As String
    Public Property Name As String
    Public Property Description As String
    Public Property StatusTagId As Integer?
    Public Property EditState As EditState Implements IEditModel.EditState

End Class
