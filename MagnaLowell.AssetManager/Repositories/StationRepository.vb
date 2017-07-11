﻿Imports MagnaLowell.AssetManager

Public Class StationRepository
    Inherits EditRepository(Of Station, StationRecord)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function Key(model As Station) As Object()
        Return New Object() {model.Id}
    End Function

    Protected Overrides Function MapOutRecord(inModel As Station, outRecord As StationRecord) As StationRecord
        outRecord.StationId = inModel.Id
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

    Protected Overrides Function MapOutModel(inRecord As StationRecord, outModel As Station) As Station
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


