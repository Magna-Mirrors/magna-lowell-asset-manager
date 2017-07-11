Imports MagnaLowell.AssetManager.Tools
Imports Ninject.Modules

Namespace Interfaces

    Public Class Bindings
        Inherits NinjectModule

        Public Overrides Sub Load()
            If My.Application.CommandLineArgs.Contains("debug") Then
                Bind(Of ICfgInterface).To(Of DbgCfgInterface)()
            Else
                Bind(Of ICfgInterface).To(Of CfgInterface)()
            End If
            Bind(Of EditLineController).ToSelf()
            Bind(GetType(ITaskManager)).To(GetType(TaskManager)).InSingletonScope()

        End Sub
    End Class
End Namespace