﻿Imports MagnaLowell.AssetManager

Public Class Line
    Implements ICopy(Of Line), IEditModel

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

    Public Property Id As Integer
    Public Property LineName As String
    Public Property Dept As String
    Public Property Definition As String
    Public Property MaxConcurrentLogins As Integer
    Public Property WcfFileName As String
    Public Property SelectCommand As String
    Public Property ScheduleFolder As String
    Public Property SchedulerMethod As SchedulerMode
    Public Property WorkBufferMinutes As Decimal
    Public Property ReOrderPercentThreshold As Decimal
    Public Property Workcell As String
    Public Property CustomerId As Integer?
    Public Property EditState As EditState Implements IEditModel.EditState
    'Public Property Customer As 

End Class
