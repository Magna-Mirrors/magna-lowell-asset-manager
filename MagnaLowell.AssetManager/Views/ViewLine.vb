Imports MagnaLowell.AssetManager
Imports MagnaLowell.AssetManager.Interfaces

Public Class ViewLine
    Implements IView(Of LineViewModel)

    Public ReadOnly Property Title As String Implements IView.Title
        Get
            Return "Line Data"
        End Get
    End Property

    Public ReadOnly Property Control As UserControl Implements IView.Control
        Get
            Return Me
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        NudMaxLogins.Properties.MaxValue = Decimal.MaxValue - 1
    End Sub

    Dim _data As LineViewModel
    Public Sub LoadView(data As LineViewModel) Implements IView(Of LineViewModel).LoadView
        _data = data
        TxtId.Text = _data.SelectedLine.Id.ToString()
        TxtName.Text = _data.SelectedLine.LineName
        NudMaxLogins.Value = _data.SelectedLine.MaxConcurrentLogins
        TxtDescription.Text = _data.SelectedLine.Description
        TxtDept.Text = _data.SelectedLine.Dept

    End Sub

    Public Function Save() As Boolean Implements IView(Of LineViewModel).Save
        If Not _namepass Then
            _data.SelectedLine.LineName = TxtName.Text
            _data.SelectedLine.MaxConcurrentLogins = CInt(NudMaxLogins.Value)
            _data.SelectedLine.Description = TxtDescription.Text
            _data.SelectedLine.Dept = TxtDept.Text
            Return True
        End If
        Return False
    End Function


    Private _namepass As Boolean
    Private Sub TxtName_EditValueChanged(sender As Object, e As EventArgs) Handles TxtName.EditValueChanged
        Dim val = TxtName.Text
        Dim res = _data.AllLines.Any(Function(x) x.Id <> _data.SelectedLine.Id AndAlso x.LineName = val)
        _namepass = Not res AndAlso String.IsNullOrWhiteSpace(TxtName.Text)
        If _namepass Then
            TxtName.BackColor = Color.PaleVioletRed
        Else
            TxtName.ResetBackColor()
        End If
    End Sub


End Class


