Public Class Form2
    Private Sub btn_evenodd_Click(sender As Object, e As EventArgs) Handles btn_evenodd.Click
        Dim age As Int32
        age = txt_number.Text
        '!=
        'if condition then
        If age > 50 Then
            MessageBox.Show("Old man")
        ElseIf age > 25 And age <= 50 Then
            MessageBox.Show("Middle man")
        Else
            MessageBox.Show("Yound man")
        End If

    End Sub


End Class