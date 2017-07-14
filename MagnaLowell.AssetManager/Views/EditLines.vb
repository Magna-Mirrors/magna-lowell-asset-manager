Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class EditLines
    Implements IView(Of EditLinesViewModel)

    Public ReadOnly Property Control As UserControl Implements IView.Control
        Get
            Return Me
        End Get
    End Property

    Private ReadOnly Property Title As String Implements IView.Title
        Get
            Return "Edit Line"
        End Get
    End Property

    Private _data As EditLinesViewModel
    Dim currentView As IView
    Private lastSelectedTag As Object
    Private ReadOnly _ctrlManager As ControllerManager

    Public Sub New(ctrlManager As ControllerManager)
        InitializeComponent()
        _ctrlManager = ctrlManager
    End Sub

    Public Sub LoadView(data As EditLinesViewModel) Implements IView(Of EditLinesViewModel).LoadView
        _data = data
        TreeView1.Nodes.Clear()
        Dim nodes = New List(Of TreeNode)()
        For Each l In _data.Lines
            Dim n = New TreeNode($"{l.Dept}: {l.LineName}") With {.Tag = New LineViewModel(l, _data.Lines)}
            Dim subNPartResults = New TreeNode($"Part Results") With {.Tag = New PartResultsViewModel(_data.PartResults, l)}
            Dim subNStations = New TreeNode($"Stations") With {.Tag = New StationViewModel(l, _data.Stations, _data.ErgonomicCategories, _data.GetTags())}
            n.Nodes.Add(subNPartResults)
            n.Nodes.Add(subNStations)
            nodes.Add(n)
        Next
        TreeView1.Nodes.AddRange(nodes.ToArray())

    End Sub

    Public Function Save() As Boolean Implements IView(Of EditLinesViewModel).Save
        If dilgSave Then
            dilgSave = False
            Return True
        End If

        Return If(currentView?.Save(), False)
    End Function
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node IsNot Nothing AndAlso e.Node.Tag IsNot Nothing Then
            If TryCast(e.Node.Tag, LineViewModel) IsNot Nothing Then
                ChangeSubView(Of ViewLine, LineViewModel)(DirectCast(e.Node.Tag, LineViewModel))
            ElseIf TryCast(e.Node.Tag, PartResultsViewModel) IsNot Nothing Then
                ChangeSubView(Of ViewPartResults, PartResultsViewModel)(DirectCast(e.Node.Tag, PartResultsViewModel))
            ElseIf TryCast(e.Node.Tag, StationViewModel) IsNot Nothing Then
                ChangeSubView(Of ViewStation, StationViewModel)(DirectCast(e.Node.Tag, StationViewModel))
            End If
        End If
        lastSelectedTag = e.Node.Tag
    End Sub

    Private Sub ChangeSubView(Of T As {New, IView(Of Tm)}, Tm As Class)(data As Tm)
        Dim newview = New T()
        newview.LoadView(data)
        Panel1.Controls.Clear()
        currentView = newview
        Panel1.Controls.Add(currentView.Control)
        currentView.Control.Dock = DockStyle.Fill
        currentView.Control.AutoSize = True
        currentView.Control.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub
    Private Sub ClearView()
        currentView = Nothing
        Panel1.Controls.Clear()
    End Sub

    Dim dilgSave As Boolean
    Private Async Sub AddLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddLineToolStripMenuItem.Click
        Dim dilg = New DialogCreateLine()
        Dim line = New Line()
        Dim lvm = New LineViewModel(line, _data.Lines)
        dilg.LoadView(lvm)
        If dilg.ShowDialog(Me) = DialogResult.OK AndAlso dilg.Save() Then
            line.EditState = EditState.Create
            _data.Lines.Add(line)
            dilgSave = True
            Await _ctrlManager.Controller.Save()

        End If
    End Sub
End Class
