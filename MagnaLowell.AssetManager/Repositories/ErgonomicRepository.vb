Imports MagnaLowell.AssetManager

Public Class ErgonomicRepository
    Inherits EditRepository(Of ErgonomicCategory, Eqp_ErgonomicCategories)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function Key(model As ErgonomicCategory) As Object()
        Return New Object() {model.ErgId}
    End Function

    Protected Overrides Function MapOutRecord(inModel As ErgonomicCategory, outRecord As Eqp_ErgonomicCategories) As Eqp_ErgonomicCategories
        outRecord.ErgId = inModel.ErgId
        outRecord.Name = inModel.Name
        outRecord.erg_Durration_Hrs = inModel.DurrationHrs
        outRecord.erg_Span_Hrs = inModel.SpanHrs
        outRecord.erg_Rest_Hrs = inModel.RestHrs
        Return outRecord
    End Function

    Protected Overrides Function MapOutModel(inRecord As Eqp_ErgonomicCategories, outModel As ErgonomicCategory) As ErgonomicCategory

        outModel.ErgId = inRecord.ErgId
        outModel.Name = inRecord.Name
        outModel.DurrationHrs = inRecord.erg_Durration_Hrs
        outModel.SpanHrs = inRecord.erg_Span_Hrs
        outModel.RestHrs = inRecord.erg_Rest_Hrs
        outModel.EditState = EditState.None
        Return outModel
    End Function
End Class
