Public Class TransactionResult(Of TModel)
    Public Sub New()
    End Sub
    Public Sub New(item As TModel)
        Me.Item = item
    End Sub

    Public Property Item As TModel
    Public Property ResultString As String
End Class
