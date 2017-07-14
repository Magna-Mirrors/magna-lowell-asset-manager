Imports System.ComponentModel
Imports System.ComponentModel.Composition.Hosting
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager.Interfaces
Imports MagnaLowell.AssetManager.Models
Imports MagnaLowell.AssetManager.Tools
Imports MagnaLowell.AssetManager.Views
Imports DevExpress.XtraEditors
Imports Ninject


Partial Public Class Form1
    Inherits XtraForm
    Implements IShell

    Dim _ctrl As IView
    ReadOnly _cfgFile As ICfgInterface
    ReadOnly _controllerManager As ControllerManager
    ReadOnly _tskmgr As ITaskManager
    ReadOnly kernal As IKernel = New StandardKernel()



    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()


        If My.Application.CommandLineArgs.Contains("debug") Then
            Me.Text = "Debug Mode"
        Else
            Me.Text = "Magna Asset Manager"
        End If

        kernal.Load(New Bindings())
        kernal.Bind(Of IShell).ToConstant(Me)
        _cfgFile = CType(kernal.Get(GetType(ICfgInterface)), ICfgInterface)
        _tskmgr = CType(kernal.Get(GetType(ITaskManager)), ITaskManager)
        _controllerManager = kernal.Get(Of ControllerManager)
        ClearView()
        AddHandler _tskmgr.Busy, AddressOf OnBusyChanged
    End Sub

    Private Sub OnBusyChanged(active As Boolean)
        Dim run = Sub()
                      PictureEdit1.EditValue = If(Not active, Nothing, My.Resources.spinner)
                      PanelControl1.Enabled = Not active
                  End Sub
        If InvokeRequired Then Me.Invoke(run) Else run()
    End Sub

    Private Async Sub BtnHandler(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnSave.ItemClick,
                                                                                                    BtnEditStationEnums.ItemClick,
                                                                                                    BtnEditItems.ItemClick,
                                                                                                    BtnSettings.ItemClick,
                                                                                                    BtnEditAssetResults.ItemClick,
                                                                                                    BtnEdit.ItemClick,
                                                                                                    BtnLogOut.ItemClick,
                                                                                                    BtnEditLines.ItemClick
        If e.Item Is BarBtnSave Then
            '_ctrl.Save()
            Await _controllerManager.Controller.Save()
        ElseIf e.Item Is BtnEditLines Then
            Await _controllerManager.ChangeControler(Of EditLineController)()
        ElseIf e.Item Is BtnEditStationEnums Then
            'ChangeView(Of ViewStationEnums)()
            'ElseIf e.Item Is BtnEditUserPerm Then
            '    ChangeView(Of ViewLinePermissions)()
        ElseIf e.Item Is BtnEditItems Then
            'ChangeView(Of ViewEditItems)()
        ElseIf e.Item Is BtnSettings Then
            Await _controllerManager.ChangeControler(Of EditCfgController)()
            'ChangeView(Of ViewCfg)()
        ElseIf e.Item Is BtnEditAssetResults Then
            'ChangeView(Of ViewEditResultEnums)()
            'ElseIf e.Item Is BtnEditProductionItems Then
            '    ChangeView(Of ViewEditProductLine)()
            'ElseIf e.Item Is BtnEditUsers Then
            '    ChangeView(Of ViewEditUsers)()
        ElseIf e.Item Is BtnEdit Then
            If _ctrl IsNot Nothing Then
                '_ctrl.Edit()
            End If
            'ElseIf e.Item Is BtnLogOut Then
            '    CurrentUser = Nothing
        End If
    End Sub

    Public Function ChangeView(Of T As {IView})() As T Implements IShell.ChangeView
        Dim run = Function() As T
                      ClearView()
                      Dim newview = kernal.Get(Of T)
                      _ctrl = newview
                      LblCtrlName.Text = _ctrl.Title
                      _ctrl.Control.Dock = DockStyle.Fill
                      PanelControl1.Controls.Add(_ctrl.Control)
                      Return newview
                  End Function
        If InvokeRequired Then
            Return DirectCast(Invoke(run), T)
        Else
            Return run()
        End If
    End Function

    Private Sub ClearView()
        Dim run = Sub()
                      If _ctrl IsNot Nothing Then _ctrl.Control.Dispose()
                      PanelControl1.Controls.Clear()
                      LblCtrlName.Text = "Select a view"
                  End Sub
        If InvokeRequired Then Invoke(run) Else run()
    End Sub
End Class
