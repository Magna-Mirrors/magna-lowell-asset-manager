Public Class LineViewModel

    Public Sub New(selectedLine As Line, allLines As List(Of Line), customers As IEnumerable(Of Customer))
        Me.SelectedLine = selectedLine
        Me.AllLines = allLines
        Me.Customers = customers.ToList()
    End Sub
    Public ReadOnly Property SelectedLine As Line
    Public ReadOnly Property AllLines As List(Of Line)
    Public ReadOnly Property Customers As IEnumerable(Of Customer)
End Class