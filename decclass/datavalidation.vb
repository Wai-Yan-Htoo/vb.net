Public Class datavalidation
    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Dim number As Int32
        number = txt_data.Text
        If number > 20 And number < 45 Then
            MsgBox(" good age ")
        ElseIf number < 20 Then
            MsgBox("too young")
        Else
            MsgBox(" too old ")
        End If
    End Sub
End Class