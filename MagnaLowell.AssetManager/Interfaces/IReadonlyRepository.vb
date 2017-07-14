Imports System.Threading.Tasks

Public Interface IReadonlyRepository(Of TModel As {Class})
    Function GetAll() As IEnumerable(Of TModel)
    Function GetAllAsync() As Task(Of IEnumerable(Of TModel))
End Interface