
Imports System.Threading.Tasks

Public Interface IEditRepository(Of TModel)
    Function Save(model As TModel) As Task(Of TransactionResult(Of TModel))
    Function GetAll() As TModel
    Function GetAllAsync() As Task(Of TModel)
End Interface