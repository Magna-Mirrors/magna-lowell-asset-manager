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
            nodes.Add(CreateLineNode(l, _data))
        Next
        TreeView1.Nodes.AddRange(nodes.ToArray())

    End Sub
    Private Sub SetLineNodeText(node As TreeNode)
        Dim l = TryCast(node.Tag, LineViewModel)
        If l IsNot Nothing Then
            node.Text = $"{l.SelectedLine.Dept}: {l.SelectedLine.LineName}"
            Select Case l.SelectedLine.EditState
                Case EditState.Create
                    node.BackColor = Color.PaleGreen
                Case EditState.Delete
                    node.BackColor = Color.PaleVioletRed
                Case EditState.Edit
                    node.BackColor = Color.PaleGoldenrod
            End Select
        End If
    End Sub
    Private Shared Function CreateLineNode(l As Line, data As EditLinesViewModel) As TreeNode
        Dim n = New TreeNode($"{l.Dept}: {l.LineName}") With {.Tag = New LineViewModel(l, data.Lines)}
        Select Case l.EditState
            Case EditState.Create
                n.BackColor = Color.PaleGreen
            Case EditState.Delete
                n.BackColor = Color.PaleVioletRed
            Case EditState.Edit
                n.BackColor = Color.PaleGoldenrod
        End Select
        Dim subNPartResults = New TreeNode($"Part Results") With {.Tag = New PartResultsViewModel(data.PartResults, l)}
        Dim subNStations = New TreeNode($"Stations") With {.Tag = New StationViewModel(l, data.Stations, data.ErgonomicCategories, data.GetTags(), data.Statuses)}
        n.Nodes.Add(subNPartResults)
        n.Nodes.Add(subNStations)
        Return n
    End Function


    Public Function Save() As Boolean Implements IView(Of EditLinesViewModel).Save
        If dilgSave Then
            dilgSave = False
            Return True
        End If

        Return If(currentView?.Save(), False)
    End Function

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node IsNot Nothing AndAlso e.Node.Tag IsNot Nothing Then
            TreeView1.ContextMenuStrip = Nothing
            If TryCast(e.Node.Tag, LineViewModel) IsNot Nothing Then
                ChangeSubView(Of ViewLine, LineViewModel)(DirectCast(e.Node.Tag, LineViewModel))
                Panel1.Enabled = False
                TreeView1.ContextMenuStrip = ContextMenuStripLine
            ElseIf TryCast(e.Node.Tag, PartResultsViewModel) IsNot Nothing Then
                ChangeSubView(Of ViewPartResults, PartResultsViewModel)(DirectCast(e.Node.Tag, PartResultsViewModel))
                Panel1.Enabled = True
            ElseIf TryCast(e.Node.Tag, StationViewModel) IsNot Nothing Then
                ChangeSubView(Of ViewStation, StationViewModel)(DirectCast(e.Node.Tag, StationViewModel))
                Panel1.Enabled = True
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
            'TreeView1.Nodes.Add(CreateLineNode(line, _data))
            Await _ctrlManager.Controller.Save()
        End If
    End Sub

    Private Async Sub EditLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditLineToolStripMenuItem.Click
        Dim dilg = New DialogCreateLine()
        Dim line = TryCast(TreeView1.SelectedNode.Tag, LineViewModel)
        dilg.LoadView(line)
        If dilg.ShowDialog(Me) = DialogResult.OK AndAlso dilg.Save() Then
            dilgSave = True
            SetLineNodeText(TreeView1.SelectedNode)
            'ChangeSubView(Of ViewLine, LineViewModel)(DirectCast(TreeView1.SelectedNode.Tag, LineViewModel))
            Await _ctrlManager.Controller.Save()
        End If
    End Sub


    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        TreeView1.SelectedNode = e.Node
    End Sub
End Class
