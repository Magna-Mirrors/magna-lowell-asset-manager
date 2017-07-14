Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class EditLineController
    Implements IController

    Private ReadOnly _shell As IShell
    Private view As EditLines
    Private ReadOnly _linerepo As LineViewModelRepository

    Private DataContext As EditLinesViewModel

    Public Sub New(shell As IShell, linerepo As LineViewModelRepository)
        _shell = shell
        _linerepo = linerepo
    End Sub
    Public Async Function Load() As Task Implements IController.Load
        Dim sw = Stopwatch.StartNew()
        Dim lineT = _linerepo.GetAllAsync()
        Debug.Print($"Load 1: {sw.ElapsedMilliseconds} ms")
        sw.Restart()
        view = _shell.ChangeView(Of EditLines)()
        Debug.Print($"Load 2: {sw.ElapsedMilliseconds} ms")
        sw.Restart()
        DataContext = Await lineT
        Debug.Print($"Load 3: {sw.ElapsedMilliseconds} ms")
        sw.Restart()
        view.LoadView(DataContext)
        Debug.Print($"Load 4: {sw.ElapsedMilliseconds} ms")
        sw.Restart()
    End Function

    Public Async Function Save() As Task Implements IController.Save

        If view.Save() Then
            Dim result = (Await _linerepo.Save(DataContext))
            DataContext = result.Item
            view.LoadView(DataContext)
        End If
    End Function
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls
    Public Sub Dispose() Implements IDisposable.Dispose
        If Not disposedValue Then
            If view IsNot Nothing Then
                view.Dispose()
            End If
        End If
        disposedValue = True
    End Sub

#End Region
End Class


