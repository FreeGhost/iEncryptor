Public Class AboutWindow

    Private Sub AboutMePIC_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AboutMePIC.Click
        Process.Start("https://mousa.alfhaily.me/")
    End Sub

    Private Sub TwitterPIC_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles TwitterPIC.Click
        Process.Start("https://twitter.com/FreeGh0o0st")
    End Sub

    Private Sub YoutubePIC_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles YoutubePIC.Click
        Process.Start("https://www.youtube.com/channel/UCWeRjXP-I7OmAwKKF8xHCFQ")
    End Sub

    Private Sub AboutWindow_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        MainWindow.Enabled = True
    End Sub
End Class