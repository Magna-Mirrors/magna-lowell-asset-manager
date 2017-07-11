Imports System.Threading
Imports System.Threading.Tasks

Namespace Tools

    Public Interface ITaskManager
        Function StartNewTask(obj As Action(Of CancellationToken)) As Task
        Event Busy As Action(Of Boolean)
    End Interface
    Public Class TaskManager
        Implements ITaskManager
        Dim _source As CancellationTokenSource
        Dim _ctoken As CancellationToken
        Dim _currentload As Task

        Public Event Busy As Action(Of Boolean) Implements ITaskManager.Busy

        Public Async Function StartNewTask(obj As Action(Of CancellationToken)) As Task Implements ITaskManager.StartNewTask
            If _source IsNot Nothing Then
                _source.Cancel(False)
            End If
            _source = New CancellationTokenSource()
            _ctoken = _source.Token
            RaiseEvent Busy(True)
            _currentload = Task.Run(Sub() obj(_ctoken))
            Await _currentload
            RaiseEvent Busy(False)
        End Function
    End Class
End NameSpace