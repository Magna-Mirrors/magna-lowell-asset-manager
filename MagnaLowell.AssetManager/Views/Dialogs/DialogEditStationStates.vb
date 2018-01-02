Imports System.Windows.Forms

Public Class DialogEditStationStates

    Private _States As List(Of StatusEnum)
    Private _Data As Station
    Private _Line As Line


    Public ReadOnly Property States As List(Of StatusEnum)
        Get
            Return _States
        End Get
    End Property

    Public Sub New(Line As Line, Data As Station, States As List(Of StatusEnum))
        ' This call is required by the designer.
        InitializeComponent()
        Me._Line = Line
        Me._Data = Data
        Me._States = States
        Label1.Text = String.Format(Label1.Tag.ToString, _Line.name, _Data.Name)
        Bs_StationStates.DataSource = _States
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogEditStationStates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
