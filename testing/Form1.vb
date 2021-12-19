Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For counter = 0 To 10
            TextBox1.Text = TextBox1.Text + counter.ToString()
        Next
    End Sub
End Class
