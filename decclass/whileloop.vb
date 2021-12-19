Public Class whileloop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Int32
        num1 = 0
        Dim num2 As Int32
        'tracing
        While num1 < 5               '5<5
            num2 = 0                 '0
            While num2 < num1        '4<4
                Label1.Text += "*"   '*
                '                     **
                '                     ***
                '                     ****
                '                     
                num2 += 1            '4
            End While                '
            Label1.Text += vbNewLine '
            num1 += 1                '5
        End While
    End Sub
End Class