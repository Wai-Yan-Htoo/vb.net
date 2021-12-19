Public Class dowhihle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Int32
        number = 6
        'if false condition break
        While number < 5 'false
            MsgBox(number.ToString)
            number += 1
        End While

        Do
            MsgBox("do while " + number.ToString)
            number += 1
        Loop While (number < 5)


    End Sub
End Class