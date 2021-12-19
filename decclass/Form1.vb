Public Class Form1

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click


        Dim num1 As Double
        Dim num2 As Double
        Dim ans As Double
        num1 = 10
        num2 = 20
        num1 = txt_first_number.Text
        num2 = txt_second_number.Text

        ans = num1 * num2
        lbl_answer.Text = ans
    End Sub

    Private Sub btn_substract_Click(sender As Object, e As EventArgs) Handles btn_substract.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim ans As Double
        num1 = txt_first_number.Text
        num2 = txt_second_number.Text

        ans = num1 - num2
        lbl_answer.Text = ans
    End Sub

    Private Sub btn_division_Click(sender As Object, e As EventArgs) Handles btn_division.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim ans As Double
        num1 = txt_first_number.Text
        num2 = txt_second_number.Text

        ans = num1 / num2
        lbl_answer.Text = ans
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim ans As Double
        num1 = txt_first_number.Text
        num2 = txt_second_number.Text

        ans = num1 + num2
        lbl_answer.Text = ans
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        ' InputBox("Enter Product key")
        ' MsgBox("hello form1")
        zodicsign.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim times As Int32

        times = InputBox("enter times ")

        Dim data(times) As String

        '1000111
        '0       4
        For i = 0 To times - 1
            data(i) = InputBox("")  'data(0)="hello"
        Next


        For i = 0 To times - 1
            If i Mod 2 = 0 Then
                MsgBox(data(i))
            End If
        Next


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '                          0  1  2  3  4  5  6  7  8   9
        Dim number() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        'midpoint 
        '9/2= index (4)
        '(left index + right index) / 2

        For j = 0 To 10
            MsgBox("for loop" + number(j).ToString())
        Next

        MsgBox(number(5))
        MsgBox(number(0))
        MsgBox(number(9))
        MsgBox(number(1))
        MsgBox(number(2))
        MsgBox(number(9))
        MsgBox(number(3))
        MsgBox(number(4))

        MsgBox(number(6))





        Dim Lind As Int32 = 0
        Dim Rind As Int32 = 9
        Dim mid As Int32 = (Lind + Rind) / 2
        MsgBox(number(mid.ToString()))


        'array = class sort = function
        'array.sort
        Array.Sort(number) 'parameter or attribute array variable
        ' 0 1 2 3 4 5 6 7  8 9
        '{1,2,3,4,5,6,7,9,10,11}
        '  0     9
        For i = 0 To 9 '                       3
            lb_after_sort.Text += " " + number(i).ToString() ' 1 2 3 4 5 6 7 8 9
        Next
    End Sub
End Class

