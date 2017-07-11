Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Threading.Tasks

Public MustInherit Class ReadonlyRepository(Of TModel As {Class, New}, TRecord As {Class, New})
    Implements IReadonlyRepository(Of TModel)

    Protected ReadOnly DbFactory As DbFactory
    Public Sub New(dbFactory As DbFactory)
        If dbFactory Is Nothing Then
            Throw New NullReferenceException()
        End If
        Me.DbFactory = dbFactory
    End Sub

    Public Overridable Function GetAll() As IEnumerable(Of TModel) Implements IReadonlyRepository(Of TModel).GetAll
        Using ctx = DbFactory.GetDbInstance()
            Dim records = ctx.Set(Of TRecord)
            Return AutoMap(records.ToList())
        End Using
    End Function
    Public Overridable Async Function GetAllAsync() As Task(Of IEnumerable(Of TModel)) Implements IReadonlyRepository(Of TModel).GetAllAsync
        Using ctx = DbFactory.GetDbInstance()
            Dim records = ctx.Set(Of TRecord)
            Return AutoMap(Await records.ToListAsync())
        End Using
    End Function

    Protected Function Retrieve(ByVal predicate As Expression(Of Func(Of TRecord, Boolean))) As IEnumerable(Of TModel)
        Using ctx = DbFactory.GetDbInstance()
            Dim query As IQueryable(Of TRecord)
            Dim records = ctx.Set(Of TRecord)
            If predicate Is Nothing Then
                query = records
            Else
                query = records.Where(predicate)
            End If
            Return AutoMap(query.ToList())
        End Using
    End Function
    Protected Async Function RetrieveAsync(ByVal predicate As Expression(Of Func(Of TRecord, Boolean))) As Task(Of IEnumerable(Of TModel))
        Using ctx = DbFactory.GetDbInstance()
            Dim query As IQueryable(Of TRecord)
            Dim records = ctx.Set(Of TRecord)
            If predicate Is Nothing Then
                query = records
            Else
                query = records.Where(predicate)
            End If
            Return AutoMap(Await query.ToListAsync())
        End Using
    End Function





    Private Function AutoMap(query As IEnumerable(Of TRecord)) As List(Of TModel)
        Dim results As New List(Of TModel)
        For Each record In query.ToList()
            Dim model As New TModel()
            results.Add(MapOutModel(record, model))
        Next record
        Return results
    End Function
    Protected MustOverride Function MapOutModel(ByVal inRecord As TRecord, ByVal outModel As TModel) As TModel

End Class

Public Interface IReadonlyRepository(Of TModel As {Class})
    Function GetAll() As IEnumerable(Of TModel)
    Function GetAllAsync() As Task(Of IEnumerable(Of TModel))
End Interface