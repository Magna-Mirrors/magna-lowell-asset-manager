Imports MagnaLowell.AssetManager

Public Class Station
    Inherits EditModel
    Implements ICopy(Of Station)

    Public Sub New(s As Station)
        s.CopyTo(Me)
    End Sub
    Public Sub New()

    End Sub

    Public Sub CopyTo(item As Station) Implements ICopy(Of Station).CopyTo
        item.Id = Id
        item.LineId = LineId
        item.ErgonomicId = ErgonomicId
        item.MinTrainingHours = MinTrainingHours
        item.DaysofConsideration = DaysofConsideration
        item.ShopLogixFolderName = ShopLogixFolderName
        item.Name = Name
        item.Description = Description
        item.StatusTagId = StatusTagId

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
    '        Return _stationId
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _stationId)
    '        _stationId = value
    '    End Set
    'End Property
    Public Property LineId As Integer
    '    Get
    '        Return _lineId
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _lineId)
    '        _lineId = value
    '    End Set
    'End Property
    Public Property ErgonomicId As Integer
    '    Get
    '        Return _ergonomicId
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _ergonomicId)
    '        _ergonomicId = value
    '    End Set
    'End Property
    Public Property MinTrainingHours As Integer
    '    Get
    '        Return _minTrainingHours
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _minTrainingHours)
    '        _minTrainingHours = value
    '    End Set
    'End Property
    Public Property DaysofConsideration As Integer
    '    Get
    '        Return _daysofConsideration
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _daysofConsideration)
    '        _daysofConsideration = value
    '    End Set
    'End Property
    Public Property ShopLogixFolderName As String
    '    Get
    '        Return _shopLogixFolderName
    '    End Get
    '    Set(value As Integer?)
    '        TrySetEditToUpdate(CBool(value <> _shopLogixFolderName))
    '        _shopLogixFolderName = value
    '    End Set
    'End Property
    Public Property Name As String
    '    Get
    '        Return _name
    '    End Get
    '    Set(value As String)
    '        TrySetEditToUpdate(value <> _name)
    '        _name = value
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
    Public Property StatusTagId As Integer?
    '    Get
    '        Return _statusTagId
    '    End Get
    '    Set(value As Integer?)
    '        TrySetEditToUpdate(CBool(value <> _statusTagId))
    '        _statusTagId = value
    '    End Set
    'End Property

    'Private Property _stationId As Integer
    'Private Property _lineId As Integer
    'Private Property _ergonomicId As Integer
    'Private Property _minTrainingHours As Integer
    'Private Property _daysofConsideration As Integer
    'Private Property _shopLogixFolderName As Integer?
    'Private Property _name As String
    'Private Property _description As String
    'Private Property _statusTagId As Integer?
End Class
