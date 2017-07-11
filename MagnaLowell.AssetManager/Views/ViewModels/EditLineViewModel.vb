Public Class EditLinesViewModel

    Public Sub New(lines As IEnumerable(Of Line), partResults As IEnumerable(Of PartResult),
                   stations As IEnumerable(Of Station), ergoCategories As IEnumerable(Of ErgonomicCategory),
                   tags As IEnumerable(Of CfgTag),
                    Devices As IEnumerable(Of SeDataProDevice),
                   groups As IEnumerable(Of SeDataProGroup))
        Me.Stations.AddRange(stations)
        Me.Lines.AddRange(lines)
        Me.PartResults.AddRange(partResults)
        Me.ErgonomicCategories = ergoCategories
        _originaltags = tags
        If tags.Count <> 26 Then
            Debug.Print("adsf")
        End If
        _devices = Devices.ToList()
        _groups = groups.ToList()
    End Sub
    Private ReadOnly _devices As IEnumerable(Of SeDataProDevice)
    Private ReadOnly _groups As IEnumerable(Of SeDataProGroup)
    Private ReadOnly _originaltags As IEnumerable(Of CfgTag)

    Public Property ErgonomicCategories As IEnumerable(Of ErgonomicCategory)
    Public Function GetTags() As IEnumerable(Of DisplayCfgTag)
        Return _originaltags.Select(Function(x)
                                        Dim sta = Stations.FirstOrDefault(Function(y) y.StatusTagId.HasValue AndAlso CInt(y.StatusTagId) = x.TagId)
                                        Return New DisplayCfgTag(x, sta)
                                    End Function)
    End Function
    Public Property Lines As New List(Of Line)
    Public Property PartResults As New List(Of PartResult)
    Public Property Stations As New List(Of Station)

    Public Function PartResultsForLine(l As Line) As IEnumerable(Of PartResult)
        Return PartResults.Where(Function(x) x.LineId = l.Id)
    End Function

    Public Function LineForPartResult(p As PartResult) As Line
        Return Lines.Single(Function(x) x.Id = p.LineId)
    End Function
    Public Function LineForStation(s As Station) As Line
        Return Lines.Single(Function(x) x.Id = s.LineId)
    End Function
    Public Function StationsForLine(l As Line) As IEnumerable(Of Station)
        Return Stations.Where(Function(x) x.LineId = l.Id)
    End Function

End Class