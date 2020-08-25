Imports MagnaLowell.AssetManager

Public Class StationRepository
    Inherits EditRepository(Of Station, eqp_Stations)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function Key(model As Station) As Object()
        Return New Object() {model.Id}
    End Function

    Public Function GetStationsWithTags() As IEnumerable(Of Station)
        Return Retrieve(Function(x) x.StatusTagId IsNot Nothing).ToList()
    End Function

    Protected Overrides Function MapOutRecord(inModel As Station, outRecord As eqp_Stations) As eqp_Stations
        'outRecord.StationId = inModel.Id
        outRecord.LineId = inModel.LineId
        outRecord.ErgonomicId = inModel.ErgonomicId
        outRecord.MinTrainingHours = inModel.MinTrainingHours
        outRecord.DaysofConsideration = inModel.DaysofConsideration
        outRecord.ShopLogixFolderName = inModel.ShopLogixFolderName
        outRecord.Name = inModel.Name
        outRecord.Description = inModel.Description
        outRecord.StatusTagId = inModel.StatusTagId
        Return outRecord
    End Function

    Protected Overrides Function MapOutModel(inRecord As eqp_Stations, outModel As Station) As Station
        outModel.Id = inRecord.StationId
        outModel.LineId = inRecord.LineId
        outModel.ErgonomicId = inRecord.ErgonomicId
        outModel.MinTrainingHours = inRecord.MinTrainingHours
        outModel.DaysofConsideration = inRecord.DaysofConsideration
        outModel.ShopLogixFolderName = inRecord.ShopLogixFolderName
        outModel.Name = inRecord.Name
        outModel.Description = inRecord.Description
        outModel.StatusTagId = inRecord.StatusTagId
        outModel.EditState = EditState.None
        Return outModel
    End Function
End Class


