Imports MagnaLowell.AssetManager

Public Class PartResult
    Inherits EditModel
    Implements ICopy(Of PartResult)

    Public Sub New()

    End Sub
    Public Sub New(partRes As PartResult)
        partRes.CopyTo(Me)
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


    Public Property Code As Integer
    '    Get
    '        Return _code
    '    End Get
    '    Set(value As Integer)
    '        TrySetEditToUpdate(value <> _code)
    '        _code = value
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
    Public Property Description As String

    Public Sub CopyTo(item As PartResult) Implements ICopy(Of PartResult).CopyTo
        item.Id = Id
        item.Code = Code
        item.LineId = LineId
        item.Description = Description
        item.EditState = EditState
    End Sub
    '    Get
    '        Return _description
    '    End Get
    '    Set(value As String)
    '        TrySetEditToUpdate(value <> _description)
    '        _description = value
    '    End Set
    'End Property

    'Private Property _id As Integer
    'Private Property _code As Integer
    'Private Property _lineId As Integer
    'Private Property _description As String
End Class
