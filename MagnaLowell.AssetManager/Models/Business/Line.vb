Imports MagnaLowell.AssetManager

Public Class Line
    Inherits EditModel
    Implements ICopy(Of Line)

    Public Sub New(l As Line)
        l.CopyTo(Me)
    End Sub
    Public Sub New()

    End Sub

    Public Sub CopyTo(item As Line) Implements ICopy(Of Line).CopyTo
        item.Id = Id
        item.LineName = LineName
        item.MaxConcurrentLogins = MaxConcurrentLogins
        item.Definition = Definition
        item.EditState = EditState
    End Sub

    Public Property Id As Integer '
    Public Property LineName As String '
    Public Property Dept As String '
    Public Property Definition As String '
    Public Property MaxConcurrentLogins As Integer '
    Public Property WcfFileName As String '
    Public Property SelectCommand As String '
    Public Property ScheduleFolder As String '
    Public Property SchedulerMethod As SchedulerMode
    Public Property WorkBufferMinutes As Decimal '
    Public Property ReOrderPercentThreshold As Decimal '
    Public Property Workcell As String '
End Class
