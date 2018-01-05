Public Class StationViewModel



    Public Sub New(line As Line,
                   stations As List(Of Station),
                   ErgoCategories As IEnumerable(Of ErgonomicCategory),
                   tags As IEnumerable(Of DisplayCfgTag))
        Me.Tags = tags
        Me.SelectedLine = line
        Me.AllStations = stations
        Me.ErgoCategories.AddRange(ErgoCategories)

    End Sub


    Public ReadOnly Property Tags As IEnumerable(Of DisplayCfgTag)

    'Private ReadOnly _devices As IEnumerable(Of SeDataProDevice)
    'Private ReadOnly _groups As IEnumerable(Of SeDataProGroup)

    Public ReadOnly Property ErgoCategories As New List(Of ErgonomicCategory)
    Public ReadOnly Property AllStations As List(Of Station)
    Public ReadOnly Property SelectedLine As Line
    Public ReadOnly Property FilteredStations As IEnumerable(Of Station)
        Get
            Return AllStations.Where(Function(x) x.LineId = SelectedLine.Id)
        End Get
    End Property

End Class