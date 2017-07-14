
Imports System.Threading.Tasks

Namespace Interfaces
    Public Interface IShell
        Function ChangeView(Of T As IView)() As T
    End Interface
End Namespace
