Public Class LineViewModel

    Public Sub New(selectedLine As Line, allLines As List(Of Line))
        Me.SelectedLine = selectedLine
        Me.AllLines = allLines
    End Sub
    Public ReadOnly Property SelectedLine As Line
    Public ReadOnly Property AllLines As List(Of Line)

End Class