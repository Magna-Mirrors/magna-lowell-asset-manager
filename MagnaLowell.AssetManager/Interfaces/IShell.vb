
Imports System.Threading.Tasks

Namespace Interfaces
    Public Interface IShell
        Function ChangeController(Of T As IController)() As Task(Of T)
        Function ChangeView(Of T As IView)() As T
    End Interface
End Namespace
