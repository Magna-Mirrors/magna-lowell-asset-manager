Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager.Interfaces
Imports Ninject

Public Class ControllerManager


    Private _currentController As IController
    Private ReadOnly _kernel As IKernel
    Public Sub New(kernel As IKernel)
        _kernel = kernel
    End Sub

    Public Async Function ChangeControler(Of T As IController)() As Task
        _currentController = _kernel.Get(Of T)
        Await _currentController.Load()
    End Function

    Public ReadOnly Property Controller As IController
        Get
            Return _currentController
        End Get
    End Property

End Class
