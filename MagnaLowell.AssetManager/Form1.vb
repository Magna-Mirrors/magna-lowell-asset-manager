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
    'Dim _currentUser As Security_UserTable
    'ReadOnly _userLevels As New List(Of Security_LevelEnum)
    'Dim _cfg As CfgSettings
    'ReadOnly _db As IDbInterface

    ReadOnly _cfgFile As ICfgInterface
    ReadOnly _tskmgr As ITaskManager
    Dim currentController As IController

    'Property CurrentUser As Security_UserTable
    '    Get
    '        Return _currentUser
    '    End Get
    '    Set(value As Security_UserTable)
    '        _currentUser = value
    '        LblUser.Caption = "User: " + If(_currentUser Is Nothing, String.Empty, _currentUser.UserName)
    '        LblUserLevel.Caption = "User Level: " + If(_currentUser Is Nothing, String.Empty, _userLevels.First(Function(x) x.Enum = _currentUser.DefaultLevel).LevelName)
    '        BtnLogOut.Enabled = value IsNot Nothing

    '    End Set
    'End Property
    'Private ReadOnly Property CurrentUserLvl() As Integer
    '    Get
    '        Return If(CurrentUser Is Nothing, 0, CurrentUser.DefaultLevel)
    '    End Get
    'End Property

    ReadOnly kernal As IKernel = New StandardKernel()
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()
        'kernal.Load(Assembly.GetExecutingAssembly())
        kernal.Load(New Bindings())

        '_db = CType(kernal.Get(GetType(IDbInterface)), IDbInterface)
        kernal.Bind(Of IShell).ToConstant(Me)
        _cfgFile = CType(kernal.Get(GetType(ICfgInterface)), ICfgInterface)

        _tskmgr = CType(kernal.Get(GetType(ITaskManager)), ITaskManager)
        ClearView()
        AddHandler _tskmgr.Busy, AddressOf OnBusyChanged
        'ChangeView(Of ViewEditResultEnums)()
    End Sub

    Private Sub OnBusyChanged(obj As Boolean)
        'Debug.Print("OnBusyChanged " + obj.ToString())
        SetState(Not obj)
    End Sub

    Private Async Sub BtnHandler(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnSave.ItemClick,
                                                                                                    BtnEditStationEnums.ItemClick,
                                                                                                    BtnEditItems.ItemClick, BtnSettings.ItemClick,
                                                                                                    BtnEditAssetResults.ItemClick,
                                                                                                    BtnEdit.ItemClick, BtnLogOut.ItemClick,
                                                                                                    BtnEditLines.ItemClick
        If e.Item Is BarBtnSave Then
            '_ctrl.Save()
            Await currentController.Save()
        ElseIf e.Item Is BtnEditLines Then
            Await ChangeController(Of EditLineController)()
        ElseIf e.Item Is BtnEditStationEnums Then
            'ChangeView(Of ViewStationEnums)()
            'ElseIf e.Item Is BtnEditUserPerm Then
            '    ChangeView(Of ViewLinePermissions)()
        ElseIf e.Item Is BtnEditItems Then
            'ChangeView(Of ViewEditItems)()
        ElseIf e.Item Is BtnSettings Then
            ChangeView(Of ViewCfg)()
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
        ClearView()
        Dim newview = kernal.Get(Of T)
        _ctrl = newview
        LblCtrlName.Text = _ctrl.Title
        _ctrl.Control.Dock = DockStyle.Fill
        PanelControl1.Controls.Add(_ctrl.Control)
        Return newview
        'Dim login = _cfgFile.Cfg.ScannerLogin
        'PanelControl1.Enabled = login AndAlso _ctrl.UserLevl <= CurrentUserLvl OrElse Not login
        'BarBtnSave.Enabled = login AndAlso _ctrl.UserLevl <= CurrentUserLvl OrElse Not login
        'CheckLogin()
    End Function

    Private Sub ClearView()
        Dim run = Sub()
                      If _ctrl IsNot Nothing Then _ctrl.Control.Dispose()
                      PanelControl1.Controls.Clear()
                      LblCtrlName.Text = "Select a view"
                  End Sub
        If InvokeRequired Then Invoke(run) Else run()
    End Sub

    Private Sub SetState(active As Boolean)
        Dim run = Sub()
                      PictureEdit1.EditValue = If(active, Nothing, My.Resources.spinner)
                      PanelControl1.Enabled = active
                  End Sub
        If InvokeRequired Then Me.Invoke(run) Else run()
    End Sub

    'Public Sub TryLogin(badgeNumber As String)
    '    If _cfgFile.Cfg.ScannerLogin Then
    '        Dim users As New List(Of Security_UserTable)
    '        Dim res = _db.FillList(users)
    '        If res.NoErrors Then
    '            Dim tmp = users.FirstOrDefault(Function(x) x.BadgeNumber = badgeNumber)
    '            _userLevels.Clear()
    '            _db.FillList(_userLevels)
    '            If tmp IsNot Nothing Then
    '                CurrentUser = tmp
    '                If _ctrl IsNot Nothing Then
    '                    PanelControl1.Enabled = _ctrl.UserLevl <= CurrentUserLvl
    '                    BarBtnSave.Enabled = _ctrl.UserLevl <= CurrentUserLvl
    '                End If
    '            Else
    '                PanelControl1.Enabled = False
    '                BarBtnSave.Enabled = False
    '            End If
    '        End If
    '    Else
    '        AlertControl1.Show(Me, "Hey", "Login setting is disabled", My.Resources.database_error.ToBitmap())
    '    End If
    'End Sub

    'Public Async Sub CheckLogin()
    '    BtnSettings.Enabled = Not _cfgFile.Cfg.ScannerLogin
    '    BarUser.Visible = _cfgFile.Cfg.ScannerLogin
    '    If _cfgFile.Cfg.ScannerLogin Then
    '        SetState(False)
    '        BtnSettings.Enabled = Not Await Task.Factory.StartNew(Of Boolean)(Function() _db.TestConnection().Result)
    '        SetState(True)
    '    End If
    '    If CurrentUser Is Nothing AndAlso BtnSettings.Enabled = False Then
    '        ClearView()
    '    End If

    'End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'Await TryLogin("1234")
        '_cfgFile.ReadConfig()
    End Sub

    Private Sub BtnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDelete.ItemClick
        'If _ctrl IsNot Nothing Then
        '    _ctrl.Delete()
        'End If
    End Sub
    Public Async Function ChangeController(Of T As IController)() As Task(Of T) Implements IShell.ChangeController
        Dim newController = kernal.Get(Of T)
        currentController = newController
        Await newController.Load()
        Return newController
    End Function
End Class
