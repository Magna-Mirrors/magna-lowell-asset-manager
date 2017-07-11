Imports System.Threading.Tasks

Namespace Interfaces
    Public Interface IController
        Inherits IDisposable
        Function Load() As Task
        Function Save() As Task
    End Interface
End Namespace
