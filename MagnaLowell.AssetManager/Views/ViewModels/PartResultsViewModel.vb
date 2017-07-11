Public Class PartResultsViewModel
    Public Sub New(results As List(Of PartResult), line As Line)

        If results Is Nothing OrElse line Is Nothing Then
            Throw New ArgumentNullException()
        End If

        Me.Line = line
        PartResultsAll = results
    End Sub
    Public ReadOnly Property Line As Line
    Public ReadOnly Property PartResultsAll As List(Of PartResult)
    Public ReadOnly Property PartResultsFiltered As IEnumerable(Of PartResult)
        Get
            Return PartResultsAll.Where(Function(x) x.LineId = Line.Id)
        End Get
    End Property

End Class