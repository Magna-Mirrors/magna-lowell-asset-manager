Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager.Interfaces
Imports MagnaLowell.AssetManager.Models
Imports MagnaLowell.AssetManager.Views

Public Class EditCfgController
    Implements IController

    Private ReadOnly _cfg As ICfgInterface
    Private ReadOnly _shell As IShell

    Private dataContext As CfgSettings
    Private currentView As ViewCfg
    Public Sub New(cfg As ICfgInterface, shell As IShell)
        _shell = shell
        _cfg = cfg
    End Sub

    Public Function Load() As Task Implements IController.Load
        Return Task.Factory.StartNew(Sub()
                                         currentView = _shell.ChangeView(Of ViewCfg)()
                                         dataContext = _cfg.ReadCfg()
                                         currentView.LoadView(dataContext)
                                     End Sub)

    End Function

    Public Function Save() As Task Implements IController.Save
        Return Task.Factory.StartNew(Sub()
                                         If currentView.Save() Then
                                             _cfg.WriteConfig(dataContext)
                                         End If
                                     End Sub)
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
#End Region


End Class
