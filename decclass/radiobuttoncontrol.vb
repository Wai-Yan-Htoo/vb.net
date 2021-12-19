Public Class radiobuttoncontrol
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MsgBox(" youngest boy ")
        ElseIf RadioButton2.Checked = True Then
            MsgBox(" teenage ")
        ElseIf RadioButton3.Checked = True Then
            MsgBox(" middle age ")
        ElseIf RadioButton4.Checked = True Then
            MsgBox(" old age ")
        End If
    End Sub
End Class