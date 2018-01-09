Public Interface IRepository(Of TModel)
    Function Save(model As IEnumerable(Of TModel)) As TransactionResult(Of IEnumerable(Of TModel))
    Function Save(model As TModel) As TransactionResult(Of TModel)
End Interface