Public Class StationViewModel



    Public Sub New(line As Line,
                   stations As List(Of Station),
                   ErgoCategories As IEnumerable(Of ErgonomicCategory),
                   tags As IEnumerable(Of CfgTag),
                   statuses As List(Of StatusEnum))
        Me.Tags = tags
        Me.SelectedLine = line
        Me.AllStations = stations
        Me.ErgoCategories.AddRange(ErgoCategories)
        Me.AllStatuses = statuses
    End Sub


    Public ReadOnly Property Tags As IEnumerable(Of CfgTag)
    Public ReadOnly Property ErgoCategories As New List(Of ErgonomicCategory)
    Public ReadOnly Property AllStations As List(Of Station)
    Public ReadOnly Property AllStatuses As List(Of StatusEnum)
    Public ReadOnly Property SelectedLine As Line
    Public ReadOnly Property FilteredStations As IEnumerable(Of Station)
        Get
            Return AllStations.Where(Function(x) x.LineId = SelectedLine.Id)
        End Get
    End Property

    Public Function FilteredStatuses(station As Station) As IEnumerable(Of StatusEnum)
        Return AllStatuses.Where(Function(x) x.StationId = station.Id)
    End Function

End Class