Imports MagnaLowell.AssetManager

Public Class DisplayCfgTag
    Inherits CfgTag
    Implements ICopy(Of DisplayCfgTag)

    Public Sub New()

    End Sub

    Public Sub New(tag As CfgTag, usingstation As IEnumerable(Of Station))
        MyBase.New(tag)
        _usedByStation = usingstation?.ToList()
    End Sub
    Public ReadOnly Property DisplayName As String
        Get
            Return $"{Me.TagId}: {DeviceName}/{GroupName}/{Me.TagName}"
        End Get
    End Property


    Public ReadOnly Property InUse As Boolean
        Get
            Return _usedByStation IsNot Nothing AndAlso _usedByStation.Any()
        End Get
    End Property
    Public ReadOnly Property DisplayUsedByStation As String
        Get
            If (_usedByStation.Count = 1) Then
                Return $"{_usedByStation.First.Id}: {_usedByStation.First.Name}"
            Else
                Return If(Not InUse, String.Empty, "USED BY MULTIPLE STATIONS")
            End If
        End Get
    End Property
    Private ReadOnly _usedByStation As IEnumerable(Of Station)


    Public Overloads Sub CopyTo(item As DisplayCfgTag) Implements ICopy(Of DisplayCfgTag).CopyTo
        MyBase.CopyTo(item)
    End Sub
End Class
