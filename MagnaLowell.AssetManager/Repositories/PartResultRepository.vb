Imports MagnaLowell.AssetManager

Public Class PartResultRepository
    Inherits EditRepository(Of PartResult, PartResultRecord)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function Key(model As PartResult) As Object()
        Return New Object() {model.Id}
    End Function

    Protected Overrides Function MapOutRecord(inModel As PartResult, outRecord As PartResultRecord) As PartResultRecord
        outRecord.Id = inModel.Id
        outRecord.Code = inModel.Code
        outRecord.LineId = inModel.LineId
        outRecord.Description = inModel.Description
        Return outRecord
    End Function

    Protected Overrides Function MapOutModel(inRecord As PartResultRecord, outModel As PartResult) As PartResult
        outModel.Id = inRecord.Id
        outModel.Code = inRecord.Code
        outModel.LineId = inRecord.LineId
        outModel.Description = inRecord.Description
        outModel.EditState = EditState.None
        Return outModel
    End Function
End Class
