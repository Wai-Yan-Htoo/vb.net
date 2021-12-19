Public Class holiday_planer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Do
            num = TextBox1.Text '("Please enter the number 50")

        Loop While (num <> 50)
        lbloutput.Text = "GoodBye"
    End Sub
End Class