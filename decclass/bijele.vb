Public Class bijele
    Private Sub btn_answer_Click(sender As Object, e As EventArgs) Handles btn_answer.Click
        Dim king As Int32
        Dim queen As Int32
        Dim rook As Int32
        Dim bishop As Int32
        Dim knight As Int32
        Dim pawn As Int32
        'original number
        king = 1
        queen = 1
        rook = 2
        bishop = 2
        knight = 2
        pawn = 8
        'input current founded number
        Dim k As Int32
        Dim q As Int32
        Dim r As Int32
        Dim b As Int32
        Dim kn As Int32
        Dim p As Int32
        k = txt_king.Text
        q = txt_queen.Text
        r = txt_rook.Text
        b = txt_bisho.Text
        kn = txt_knight.Text
        p = txt_pawn.Text

        king -= k
        queen -= q
        rook -= r
        bishop -= b
        knight -= kn
        pawn -= p

        MsgBox(king.ToString + " " + queen.ToString + " " + rook.ToString + " " + bishop.ToString + " " + knight.ToString + " " + pawn.ToString)



    End Sub
End Class