Imports MagnaLowell.AssetManager

Public Class LineRepository
    Inherits EditRepository(Of Line, LineRecord)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function Key(model As Line) As Object()
        Return New Object() {model.Id}
    End Function

    Protected Overrides Function MapOutRecord(inModel As Line, outRecord As LineRecord) As LineRecord
        outRecord.Id = inModel.Id
        outRecord.LineName = inModel.LineName
        outRecord.MaxConcurrentLogins = inModel.MaxConcurrentLogins
        outRecord.Dept = inModel.Dept
        outRecord.Description = inModel.Description
        Return outRecord
    End Function

    Protected Overrides Function MapOutModel(inRecord As LineRecord, outModel As Line) As Line
        outModel.Id = inRecord.Id
        outModel.LineName = inRecord.LineName
        outModel.MaxConcurrentLogins = inRecord.MaxConcurrentLogins
        outModel.Dept = inRecord.Dept
        outModel.Description = inRecord.Description
        outModel.EditState = EditState.None
        Return outModel
    End Function
End Class
