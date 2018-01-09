
Imports System.Linq.Expressions
Imports System.Threading.Tasks

Public MustInherit Class EditRepository(Of TModel As {Class, IEditModel, New}, TRecord As {Class, New})
    Inherits ReadonlyRepository(Of TModel, TRecord)
    Implements IRepository(Of TModel)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overridable Function Add(models As IEnumerable(Of TModel)) As Integer
        Using ctx = DbFactory.GetDbInstance()

            Dim records = ctx.Set(Of TRecord)
            Dim foundrecords As New List(Of Pair(Of TModel, TRecord))

            For Each model In models
                Dim record As New TRecord()
                foundrecords.Add(New Pair(Of TModel, TRecord)(model, record))
                MapOutRecord(model, record)
                records.Add(record)
            Next model
            Dim res = ctx.SaveChanges()
            For Each found In foundrecords
                MapOutModel(found.B, found.A)
                found.A.EditState = EditState.None
            Next
            Return res
        End Using
    End Function

    Protected Overridable Function Add(model As TModel) As TransactionResult(Of TModel)
        Using ctx = DbFactory.GetDbInstance()

            Dim records = ctx.Set(Of TRecord)

            Dim record = records.Create()
            records.Add(record)
            MapOutRecord(model, record)
            ctx.SaveChanges()
            MapOutModel(record, model)
            model.EditState = EditState.None
            Return New TransactionResult(Of TModel)(model)
        End Using
    End Function

    Protected Overridable Function Update(mdls As IEnumerable(Of TModel)) As Integer
        Dim models = mdls.ToList()
        Using ctx = DbFactory.GetDbInstance()
            Dim records = ctx.Set(Of TRecord)
            Dim foundrecords As New List(Of Pair(Of TModel, TRecord))
            For Each model In models
                Dim record = records.Find(Key(model))
                If record IsNot Nothing Then
                    foundrecords.Add(New Pair(Of TModel, TRecord)(model, record))
                    MapOutRecord(model, record)
                    'Database.Entry(record).State = EntityState.Modified
                End If
            Next model
            Dim res = ctx.SaveChanges()
            For Each rec In foundrecords
                MapOutModel(rec.B, rec.A)
                rec.A.EditState = EditState.None
            Next
            Return res
        End Using
    End Function

    Protected Overridable Function Update(model As TModel) As TransactionResult(Of TModel)
        Using ctx = DbFactory.GetDbInstance()
            Dim records = ctx.Set(Of TRecord)
            Dim record = records.Find(Key(model))
            If record IsNot Nothing Then
                MapOutRecord(model, record)
            End If
            ctx.SaveChanges()
            MapOutModel(record, model)
            model.EditState = EditState.None
            Return New TransactionResult(Of TModel)(model)
        End Using
    End Function

    Public Overridable Function Save(model As IEnumerable(Of TModel)) As TransactionResult(Of IEnumerable(Of TModel)) Implements IRepository(Of TModel).Save
        Update(model.Where(Function(x) x.EditState = EditState.Edit))
        Add(model.Where(Function(x) x.EditState = EditState.Create))
        Return New TransactionResult(Of IEnumerable(Of TModel))(model)
    End Function

    Public Overridable Function Save(model As TModel) As TransactionResult(Of TModel) Implements IRepository(Of TModel).Save
        Dim found As Boolean
        Using ctx = DbFactory.GetDbInstance
            Dim find = ctx.Set(Of TRecord).Find(Key(model))
            found = find IsNot Nothing
        End Using
        If found Then
            Return Update(model)
        Else
            Return Add(model)
        End If
        Return New TransactionResult(Of TModel)() With {.ResultString = "No changes"}
    End Function

    Protected Overridable Function Key(ByVal model As TModel) As Object()
        Throw New NotImplementedException()
    End Function
    Protected Overridable Function MapOutRecord(ByVal inModel As TModel, ByVal outRecord As TRecord) As TRecord
        Throw New NotImplementedException()
    End Function

    Private Class Pair(Of TA, TB)
        Public Sub New(a As TA, b As TB)
            Me.A = a
            Me.B = b
        End Sub
        Public Property A() As TA
        Public Property B() As TB
    End Class
End Class