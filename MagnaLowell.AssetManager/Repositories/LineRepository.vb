Imports MagnaLowell.AssetManager

Public Class LineRepository
    Inherits EditRepository(Of Line, eqp_Lines)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function Key(model As Line) As Object()
        Return New Object() {model.Id}
    End Function

    Protected Overrides Function MapOutRecord(inModel As Line, outRecord As eqp_Lines) As eqp_Lines
        outRecord.Id = inModel.Id
        outRecord.LineName = inModel.LineName
        outRecord.Dept = inModel.Dept
        outRecord.MaxConcurrentLogins = inModel.MaxConcurrentLogins
        outRecord.LineDefinition = inModel.Definition
        outRecord.WcfFileName = inModel.WcfFileName
        outRecord.SelectCmd = inModel.SelectCommand
        outRecord.ScheduleFolder = inModel.ScheduleFolder
        outRecord.SchedulerMethod = inModel.SchedulerMethod
        outRecord.WorkBufferMinutes = inModel.WorkBufferMinutes
        outRecord.ReOrderPercentThreshold = inModel.ReOrderPercentThreshold
        outRecord.Workcell = inModel.Workcell
        Return outRecord
    End Function

    Protected Overrides Function MapOutModel(inRecord As eqp_Lines, outModel As Line) As Line
        outModel.Id = inRecord.Id
        outModel.LineName = inRecord.LineName
        outModel.Dept = inRecord.Dept
        outModel.MaxConcurrentLogins = inRecord.MaxConcurrentLogins
        outModel.Definition = inRecord.LineDefinition
        outModel.EditState = EditState.None
        outModel.WcfFileName = inRecord.WcfFileName
        outModel.SelectCommand = inRecord.SelectCmd
        outModel.ScheduleFolder = inRecord.ScheduleFolder
        outModel.SchedulerMethod = CType(inRecord.SchedulerMethod, SchedulerMode)
        outModel.WorkBufferMinutes = inRecord.WorkBufferMinutes
        outModel.ReOrderPercentThreshold = inRecord.ReOrderPercentThreshold
        outModel.Workcell = inRecord.Workcell
        Return outModel
    End Function
End Class
