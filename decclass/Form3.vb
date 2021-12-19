Public Class Form3

    Private Sub btn_rect_Click(sender As Object, e As EventArgs) Handles btn_rect.Click
        Dim row As Double
        Dim col As Double
        row = txt_row.Text '2
        col = txt_column.Text '3
        's
        For i = 1 To row

            For j = 1 To col

                lbl_star.Text += "*"

            Next
            lbl_star.Text += vbNewLine
        Next

    End Sub
End Class