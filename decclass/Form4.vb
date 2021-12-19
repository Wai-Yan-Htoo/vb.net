

Public Class Form4
    Private Sub btn_google_Click(sender As Object, e As EventArgs) Handles btn_chrome.Click
        System.Diagnostics.Process.Start(" https://www.google.com/ ")
    End Sub

    Private Sub btn_edge_Click(sender As Object, e As EventArgs) Handles btn_edge.Click

        System.Diagnostics.Process.Start(" https://www.google.com/ ")
    End Sub
End Class