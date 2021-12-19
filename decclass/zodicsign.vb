Public Class zodicsign
    Dim girlZodiac As String = ""
    Dim boyZodiac As String = ""


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If cmdProg.Value >= 100 Then

            cmdProg.Value = 0

        Else

            cmdProg.Value += 1
            txtResult.Text = cmdProg.Value & "% Completing...."

            If cmdProg.Value = 100 Then
                Timer1.Stop()
            End If

        End If
    End Sub

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        'Timer1.Start()
        If boyZodiac = "Aries" And girlZodiac = "Aries" Then
            cmdProg.Value = 50
            txtResult.Text = 50 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Taurus" Then
            cmdProg.Value = 38
            txtResult.Text = 38 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Gemini" Then
            cmdProg.Value = 83
            txtResult.Text = 83 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Cancer" Then
            cmdProg.Value = 42
            txtResult.Text = 42 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Leo" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Virgo" Then
            cmdProg.Value = 63
            txtResult.Text = 63 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Libra" Then
            cmdProg.Value = 85
            txtResult.Text = 85 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 50
            txtResult.Text = 50 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 93
            txtResult.Text = 93 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 47
            txtResult.Text = 47 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 78
            txtResult.Text = 78 & "%"
        ElseIf boyZodiac = "Aries" And girlZodiac = "Pisces" Then
            cmdProg.Value = 67
            txtResult.Text = 67 & "%"
        End If

        If boyZodiac = "Taurus" And girlZodiac = "Aries" Then
            cmdProg.Value = 38
            txtResult.Text = 38 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Taurus" Then
            cmdProg.Value = 65
            txtResult.Text = 65 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Gemini" Then
            cmdProg.Value = 33
            txtResult.Text = 33 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Cancer" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Leo" Then
            cmdProg.Value = 73
            txtResult.Text = 73 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Virgo" Then
            cmdProg.Value = 90
            txtResult.Text = 90 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Libra" Then
            cmdProg.Value = 65
            txtResult.Text = 65 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 30
            txtResult.Text = 30 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 98
            txtResult.Text = 98 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 58
            txtResult.Text = 58 & "%"
        ElseIf boyZodiac = "Taurus" And girlZodiac = "Pisces" Then
            cmdProg.Value = 85
            txtResult.Text = 85 & "%"
        End If

        If boyZodiac = "Leo" And girlZodiac = "Aries" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Taurus" Then
            cmdProg.Value = 73
            txtResult.Text = 73 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Gemini" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Leo" Then
            cmdProg.Value = 35
            txtResult.Text = 35 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Leo" Then
            cmdProg.Value = 45
            txtResult.Text = 45 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Virgo" Then
            cmdProg.Value = 35
            txtResult.Text = 35 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Libra" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 58
            txtResult.Text = 58 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 93
            txtResult.Text = 93 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 35
            txtResult.Text = 35 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Leo" And girlZodiac = "Pisces" Then
            cmdProg.Value = 38
            txtResult.Text = 38 & "%"
        End If

        If boyZodiac = "Gemini" And girlZodiac = "Aries" Then
            cmdProg.Value = 83
            txtResult.Text = 83 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Taurus" Then
            cmdProg.Value = 33
            txtResult.Text = 33 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Gemini" Then
            cmdProg.Value = 60
            txtResult.Text = 60 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Cancer" Then
            cmdProg.Value = 65
            txtResult.Text = 65 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Leo" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Virgo" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Libra" Then
            cmdProg.Value = 93
            txtResult.Text = 93 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 28
            txtResult.Text = 28 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 60
            txtResult.Text = 60 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 85
            txtResult.Text = 85 & "%"
        ElseIf boyZodiac = "Gemini" And girlZodiac = "Pisces" Then
            cmdProg.Value = 53
            txtResult.Text = 53 & "%"
        End If

        If boyZodiac = "Cancer" And girlZodiac = "Aries" Then
            cmdProg.Value = 42
            txtResult.Text = 42 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Taurus" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Gemini" Then
            cmdProg.Value = 65
            txtResult.Text = 65 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Cancer" Then
            cmdProg.Value = 75
            txtResult.Text = 75 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Leo" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Virgo" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Libra" Then
            cmdProg.Value = 93
            txtResult.Text = 93 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 28
            txtResult.Text = 28 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 60
            txtResult.Text = 60 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 85
            txtResult.Text = 85 & "%"
        ElseIf boyZodiac = "Cancer" And girlZodiac = "Pisces" Then
            cmdProg.Value = 53
            txtResult.Text = 53 & "%"
        End If

        If boyZodiac = "Virgo" And girlZodiac = "Aries" Then
            cmdProg.Value = 63
            txtResult.Text = 63 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Taurus" Then
            cmdProg.Value = 90
            txtResult.Text = 90 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Gemini" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Cancer" Then
            cmdProg.Value = 90
            txtResult.Text = 90 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Leo" Then
            cmdProg.Value = 35
            txtResult.Text = 35 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Virgo" Then
            cmdProg.Value = 65
            txtResult.Text = 65 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Libra" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 48
            txtResult.Text = 48 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 95
            txtResult.Text = 95 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 30
            txtResult.Text = 30 & "%"
        ElseIf boyZodiac = "Virgo" And girlZodiac = "Pisces" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        End If

        If boyZodiac = "Libra" And girlZodiac = "Aries" Then
            cmdProg.Value = 85
            txtResult.Text = 85 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Taurus" Then
            cmdProg.Value = 65
            txtResult.Text = 65 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Gemini" Then
            cmdProg.Value = 93
            txtResult.Text = 93 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Cancer" Then
            cmdProg.Value = 43
            txtResult.Text = 43 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Leo" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Virgo" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Libra" Then
            cmdProg.Value = 75
            txtResult.Text = 75 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 35
            txtResult.Text = 35 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 73
            txtResult.Text = 73 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 55
            txtResult.Text = 55 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 90
            txtResult.Text = 90 & "%"
        ElseIf boyZodiac = "Libra" And girlZodiac = "Pisces" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        End If

        If boyZodiac = "Scorpio" And girlZodiac = "Aries" Then
            cmdProg.Value = 50
            txtResult.Text = 50 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Taurus" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Gemini" Then
            cmdProg.Value = 28
            txtResult.Text = 28 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Cancer" Then
            cmdProg.Value = 94
            txtResult.Text = 94 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Leo" Then
            cmdProg.Value = 58
            txtResult.Text = 58 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Virgo" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Libra" Then
            cmdProg.Value = 35
            txtResult.Text = 35 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 80
            txtResult.Text = 80 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 28
            txtResult.Text = 28 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 95
            txtResult.Text = 95 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 73
            txtResult.Text = 73 & "%"
        ElseIf boyZodiac = "Scorpio" And girlZodiac = "Pisces" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        End If

        If boyZodiac = "Sagittarius" And girlZodiac = "Aries" Then
            cmdProg.Value = 93
            txtResult.Text = 93 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Taurus" Then
            cmdProg.Value = 30
            txtResult.Text = 30 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Gemini" Then
            cmdProg.Value = 60
            txtResult.Text = 60 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Cancer" Then
            cmdProg.Value = 53
            txtResult.Text = 53 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Leo" Then
            cmdProg.Value = 93
            txtResult.Text = 93 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Virgo" Then
            cmdProg.Value = 48
            txtResult.Text = 48 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Libra" Then
            cmdProg.Value = 73
            txtResult.Text = 73 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 28
            txtResult.Text = 28 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 45
            txtResult.Text = 45 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 60
            txtResult.Text = 60 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 90
            txtResult.Text = 90 & "%"
        ElseIf boyZodiac = "Sagittarius" And girlZodiac = "Pisces" Then
            cmdProg.Value = 63
            txtResult.Text = 63 & "%"
        End If

        If boyZodiac = "Capricorn" And girlZodiac = "Aries" Then
            cmdProg.Value = 47
            txtResult.Text = 47 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Taurus" Then
            cmdProg.Value = 98
            txtResult.Text = 98 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Gemini" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Cancer" Then
            cmdProg.Value = 83
            txtResult.Text = 83 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Leo" Then
            cmdProg.Value = 35
            txtResult.Text = 35 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Virgo" Then
            cmdProg.Value = 95
            txtResult.Text = 95 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Libra" Then
            cmdProg.Value = 55
            txtResult.Text = 55 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 95
            txtResult.Text = 95 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 60
            txtResult.Text = 60 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 75
            txtResult.Text = 75 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Capricorn" And girlZodiac = "Pisces" Then
            cmdProg.Value = 45
            txtResult.Text = 45 & "%"
        End If

        If boyZodiac = "Aquarius" And girlZodiac = "Aries" Then
            cmdProg.Value = 78
            txtResult.Text = 78 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Taurus" Then
            cmdProg.Value = 58
            txtResult.Text = 58 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Gemini" Then
            cmdProg.Value = 85
            txtResult.Text = 85 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Cancer" Then
            cmdProg.Value = 27
            txtResult.Text = 27 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Leo" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Virgo" Then
            cmdProg.Value = 30
            txtResult.Text = 30 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Libra" Then
            cmdProg.Value = 90
            txtResult.Text = 90 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 73
            txtResult.Text = 73 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 90
            txtResult.Text = 90 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 68
            txtResult.Text = 68 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 45
            txtResult.Text = 45 & "%"
        ElseIf boyZodiac = "Aquarius" And girlZodiac = "Pisces" Then
            cmdProg.Value = 45
            txtResult.Text = 45 & "%"
        End If

        If boyZodiac = "Pisces" And girlZodiac = "Aries" Then
            cmdProg.Value = 67
            txtResult.Text = 67 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Taurus" Then
            cmdProg.Value = 85
            txtResult.Text = 85 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Gemini" Then
            cmdProg.Value = 53
            txtResult.Text = 53 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Cancer" Then
            cmdProg.Value = 98
            txtResult.Text = 98 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Leo" Then
            cmdProg.Value = 38
            txtResult.Text = 38 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Virgo" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Libra" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Scorpio" Then
            cmdProg.Value = 97
            txtResult.Text = 97 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Sagittarius" Then
            cmdProg.Value = 63
            txtResult.Text = 63 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Capricorn" Then
            cmdProg.Value = 88
            txtResult.Text = 88 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Aquarius" Then
            cmdProg.Value = 45
            txtResult.Text = 45 & "%"
        ElseIf boyZodiac = "Pisces" And girlZodiac = "Pisces" Then
            cmdProg.Value = 60
            txtResult.Text = 60 & "%"
        End If

        cmdProg.Refresh()


    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged


        Dim month As String = DateTimePicker1.Value.ToString("MMMM").ToLower
        Dim day As Int32 = DateTimePicker1.Value.Day
        'MsgBox(month & day)

        If month = "december" Then
            If day < 22 Then
                boyZodiac = "Sagittarius"
            Else
                boyZodiac = "capricorn"
            End If

        ElseIf month = "january" Then
            If day < 20 Then
                boyZodiac = "Capricorn"
            Else
                boyZodiac = "Aquarius"
            End If

        ElseIf month = "february" Then
            If day < 19 Then
                boyZodiac = "Aquarius"
            Else
                boyZodiac = "Pisces"
            End If

        ElseIf month = "march" Then
            If day < 21 Then
                boyZodiac = "Pisces"
            Else
                boyZodiac = "Aries"
            End If

        ElseIf month = "april" Then
            If day < 20 Then
                boyZodiac = "Aries"
            Else
                boyZodiac = "Taurus"
            End If

        ElseIf month = "may" Then
            If day < 21 Then
                boyZodiac = "Taurus"
            Else
                boyZodiac = "Gemini"
            End If

        ElseIf month = "june" Then
            If day < 21 Then
                boyZodiac = "Gemini"
            Else
                boyZodiac = "Cancer"
            End If

        ElseIf month = "july" Then
            If day < 23 Then
                boyZodiac = "Cancer"
            Else
                boyZodiac = "Leo"
            End If
        ElseIf month = "august" Then
            If day < 23 Then
                boyZodiac = "Leo"
            Else
                boyZodiac = "Virgo"
            End If

        ElseIf month = "september" Then
            If day < 23 Then
                boyZodiac = "Virgo"
            Else
                boyZodiac = "Libra"
            End If

        ElseIf month = "october" Then
            If day < 23 Then
                boyZodiac = "Libra"
            Else
                boyZodiac = "Scorpio"
            End If

        ElseIf month = "november" Then
            If day < 22 Then
                boyZodiac = "Scorpio"
            Else
                boyZodiac = "Sagittarius"
            End If

        End If


        Label1.Text = boyZodiac

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

        Dim month As String = DateTimePicker2.Value.ToString("MMMM").ToLower
        Dim day As Int32 = DateTimePicker2.Value.Day


        If month = "december" Then
            If day < 22 Then
                girlZodiac = "Sagittarius"
            Else
                girlZodiac = "capricorn"
            End If
        ElseIf month = "january" Then
            If day < 20 Then
                girlZodiac = "Capricorn"
            Else
                girlZodiac = "Aquarius"
            End If
        ElseIf month = "february" Then
            If day < 19 Then
                girlZodiac = "Aquarius"
            Else
                girlZodiac = "Pisces"
            End If
        ElseIf month = "march" Then
            If day < 21 Then
                girlZodiac = "Pisces"
            Else
                girlZodiac = "Aries"
            End If
        ElseIf month = "april" Then
            If day < 20 Then
                girlZodiac = "Aries"
            Else
                girlZodiac = "Taurus"
            End If
        ElseIf month = "may" Then
            If day < 21 Then
                girlZodiac = "Taurus"
            Else
                girlZodiac = "Gemini"
            End If
        ElseIf month = "june" Then
            If day < 21 Then
                girlZodiac = "Gemini"
            Else
                girlZodiac = "Cancer"
            End If
        ElseIf month = "july" Then
            If day < 23 Then
                girlZodiac = "Cancer"
            Else
                girlZodiac = "Leo"
            End If
        ElseIf month = "august" Then
            If day < 23 Then
                girlZodiac = "Leo"
            Else
                girlZodiac = "Virgo"
            End If
        ElseIf month = "september" Then
            If day < 23 Then
                girlZodiac = "Virgo"
            Else
                girlZodiac = "Libra"
            End If
        ElseIf month = "october" Then
            If day < 23 Then
                girlZodiac = "Libra"
            Else
                girlZodiac = "Scorpio"
            End If
        ElseIf month = "november" Then
            If day < 22 Then
                girlZodiac = "Scorpio"
            Else
                girlZodiac = "Sagittarius"
            End If

        End If


        Label2.Text = girlZodiac
    End Sub
End Class