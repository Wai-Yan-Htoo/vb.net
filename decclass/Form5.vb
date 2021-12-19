Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            MsgBox("I like animals")
        ElseIf CheckBox2.Checked = True Then
            MsgBox("I like Board Games")
        ElseIf CheckBox3.Checked = True Then
            MsgBox("I love watching movie")
        ElseIf CheckBox4.Checked = True Then
            MsgBox("I love reading")
        ElseIf CheckBox5.Checked = True Then
            MsgBox("Programming is best for me")
        End If

    End Sub
End Class