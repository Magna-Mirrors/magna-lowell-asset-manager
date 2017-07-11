Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class EditLineController
    Implements IController

    Private ReadOnly _shell As IShell
    Private view As EditLines
    Private ReadOnly _linerepo As LineViewModelRepository

    Public Sub New(shell As IShell, linerepo As LineViewModelRepository)
        _shell = shell
        _linerepo = linerepo
    End Sub

    Private DataContext As EditLinesViewModel

    Public Async Function Load() As Task Implements IController.Load
        Dim lineT = _linerepo.GetAllAsync()

        DataContext = Await lineT
        view = _shell.ChangeView(Of EditLines)()
        view.LoadView(DataContext)
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


