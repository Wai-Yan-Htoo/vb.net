Public Class login

    Public Function length(pass As String) As Boolean
        If pass.Length > 8 Then
            MsgBox("length is nice")
            Return True
        End If
    End Function

    Public Function uppercase(pass As String) As Boolean
        For i = 0 To pass.Length
            If Char.IsUpper(pass(i)) = True Then
                MsgBox("password have upper")
                Return True
            End If
        Next
    End Function

    Public Function lowercase(pass As String) As Boolean
        For i = 0 To pass.Length
            If Char.IsLower(pass(i)) = True Then
                MsgBox("password have lower")
                Return True
            End If
        Next
    End Function

    'Hello123/


    Public Function specialcharacter(pass As String) As Boolean
        Dim spec() As String = {"!", "@", "#", "$", "%", "^", "&", "*", "/", "-", "_"}
        For i = 0 To 11
            For j = 0 To pass.Length
                If pass(j) = spec(i) Then
                    MsgBox("special character found = " & spec(i))
                    Return True
                End If
            Next
        Next
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pwd As String = "Hello123!@"
        Dim password As String = TextBox1.Text

        If length(password) = True And uppercase(password) = True And lowercase(password) = True And specialcharacter(password) Then
            MsgBox("password strong not all")
        End If

    End Sub
End Class