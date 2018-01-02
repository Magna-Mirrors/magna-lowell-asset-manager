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
        item.name = name
        item.Description = Description
        item.EditState = EditState
    End Sub
    'Protected Overrides Sub TrySetEditToUpdate(setToEdit As Boolean)
    '    MyBase.TrySetEditToUpdate(setToEdit)
    '    If Id = 0 Then
    '        EditState = EditState.Create
    '    End If
    'End Sub
    Public Property Id As Integer
    '    Get
    '        Return _id
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _id)
    '        _id = value
    '    End Set
    'End Property
    Public Property LineName As String
    '    Get
    '        Return _lineName
    '    End Get
    '    Set(value As String)
    '        TrySetEditToUpdate(value <> _lineName)
    '        _lineName = value
    '    End Set
    'End Property
    Public Property MaxConcurrentLogins As Integer
    '    Get
    '        Return _maxConcurrentLogins
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _maxConcurrentLogins)
    '        _maxConcurrentLogins = value
    '    End Set
    'End Property
    Public Property name As String
    '    Get
    '        Return _dept
    '    End Get
    '    Set(value As String)
    '        TrySetEditToUpdate(value <> _dept)
    '        _dept = value
    '    End Set
    'End Property
    Public Property Description As String
    '    Get
    '        Return _description
    '    End Get
    '    Set(value As String)
    '        TrySetEditToUpdate(value <> _description)
    '        _description = value
    '    End Set
    'End Property
    Public Property WcfFileName As String

    Public Property SelectCommand As String
    Public Property ScheduleFolder As String
    Public Property SchedulerMethod As SchedulerMode
    Public Property WorkBufferMinutes As Decimal
    Public Property ReOrderPercentThreshold As Decimal
    Public Property Workcell As String


    'Private _id As Integer
    'Private _lineName As String
    'Private _maxConcurrentLogins As Integer
    'Private _dept As String
    'Private _description As String
End Class
