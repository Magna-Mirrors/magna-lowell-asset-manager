Public Class DialogEditStationState



    Public Sub New()
        InitializeComponent()

    End Sub

    Private states As IEnumerable(Of StatusEnum)
    Private state As StatusEnum

    Public Sub LoadData(state As StatusEnum, allStatusEnums As IEnumerable(Of StatusEnum))
        If state.StationId = 0 Then
            Throw New Exception()
        End If
        Me.states = allStatusEnums
        Me.state = state
        TxtDescription.Text = Me.state.Description
        NudState.Value = Me.state.State
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not statevalueValid Then
            MessageBox.Show($"State: {CInt(NudState.Value)} is already used")
            Return
        End If
        state.State = CInt(NudState.Value)
        state.Description = TxtDescription.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Dim statevalueValid As Boolean

    Private Sub NudState_EditValueChanged(sender As Object, e As EventArgs) Handles NudState.EditValueChanged
        Dim used = states.Any(Function(x) x IsNot state AndAlso x.StationId = state.StationId AndAlso x.State = CInt(NudState.Value))
        NudState.BackColor = If(used, Color.PaleVioletRed, Color.PaleGreen)
        statevalueValid = Not used
    End Sub
End Class