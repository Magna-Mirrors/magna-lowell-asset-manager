Imports MagnaLowell.AssetManager

Public Class StatusEnum
    Inherits EditModel
    Implements ICopy(Of StatusEnum)

    Public Sub New(se As StatusEnum)
        se.CopyTo(Me)
    End Sub
    Public Sub New()

    End Sub

    Public Sub CopyTo(item As StatusEnum) Implements ICopy(Of StatusEnum).CopyTo
        item.Id = Id
        item.StationId = StationId
        item.State = State
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
    Public Property StationId As Integer
    '    Get
    '        Return _stationId
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _stationId)
    '        _stationId = value
    '    End Set
    'End Property
    Public Property State As Integer
    '    Get
    '        Return _state
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _state)
    '        _state = value
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

    'Private Property _id As Integer
    'Private Property _stationId As Integer
    'Private Property _state As Integer
    'Private Property _description As String
End Class
