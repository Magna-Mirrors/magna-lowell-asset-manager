Public Class EditLinesViewModel

    Public Sub New(lines As IEnumerable(Of Line),
                   partResults As IEnumerable(Of PartResult),
                   stations As IEnumerable(Of Station),
                   ergoCategories As IEnumerable(Of ErgonomicCategory),
                   tags As IEnumerable(Of DisplayCfgTag),
                   statusEnums As IEnumerable(Of StatusEnum))
        Me.Stations.AddRange(stations)
        Me.Lines.AddRange(lines)
        Me.PartResults.AddRange(partResults)
        Me.ErgonomicCategories = ergoCategories
        Me.Statuses = statusEnums.ToList()
        Me._originaltags = tags
        If tags.Count <> 26 Then
            Debug.Print("adsf")
        End If
    End Sub

    Private ReadOnly _originaltags As IEnumerable(Of DisplayCfgTag)
    Public Property ErgonomicCategories As IEnumerable(Of ErgonomicCategory)

    Public Function GetTags() As IEnumerable(Of DisplayCfgTag)
        Return _originaltags.ToList()
    End Function
    Public Property Lines As New List(Of Line)
    Public Property PartResults As New List(Of PartResult)
    Public Property Stations As New List(Of Station)
    Public Property Statuses As New List(Of StatusEnum)
End Class