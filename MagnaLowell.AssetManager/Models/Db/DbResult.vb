Namespace Models
    Public Class DbResult(Of T As {New})
        Public ReadOnly Property NoErrors As Boolean
            Get
                Return (Err Is Nothing)
            End Get
        End Property
        Public ReadOnly Property Result As T
        Public ReadOnly Property Err As Exception = Nothing

        Public Sub New(exception As Exception)
            Err = exception
        End Sub

        Public Sub New(val As T)
            Result = val
        End Sub
    End Class
End NameSpace