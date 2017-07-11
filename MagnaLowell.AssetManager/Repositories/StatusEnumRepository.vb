Imports MagnaLowell.AssetManager

Public Class StatusEnumRepository
    Inherits EditRepository(Of StatusEnum, StatusEnumRecord)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function Key(model As StatusEnum) As Object()
        Return New Object() {model.StationId, model.State}
    End Function

    Protected Overrides Function MapOutRecord(inModel As StatusEnum, outRecord As StatusEnumRecord) As StatusEnumRecord
        outRecord.Id = inModel.Id
        outRecord.Description = inModel.Description
        outRecord.State = inModel.State
        outRecord.StationId = inModel.StationId
        Return outRecord
    End Function

    Protected Overrides Function MapOutModel(inRecord As StatusEnumRecord, outModel As StatusEnum) As StatusEnum
        outModel.Id = inRecord.Id
        outModel.Description = inRecord.Description
        outModel.State = inRecord.State
        outModel.StationId = inRecord.StationId
        outModel.EditState = EditState.None
        Return outModel
    End Function
End Class
