Public Class LoginWindow
    Dim TitleStatus, LoginWindowStatus As String

    Private Sub LoginWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not LoginWindowStatus = "LoggingIn" Then
            MainWindow.Close()
        End If
    End Sub

    Private Sub LoginWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TitleTimer.Start()
    End Sub

    Private Sub TitleTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleTimer.Tick
        TitleTimer.Stop()
        Me.Focus()
        If TitleStatus = "" Then
            If TitlePanel.Left = -5 Then
                TitleStatus = "MoveBack"
            Else
                TitlePanel.Left += 5
            End If
            TitleTimer.Start()
        Else
            If TitlePanel.Left = -17 Then
                TitleStatus = ""
            Else
                TitlePanel.Left -= 2
                TitleTimer.Start()
            End If
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UserNameTextBox.KeyDown, PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If My.Settings.UserName = UserNameTextBox.Text And My.Settings.Password = PasswordTextBox.Text Then
                MainWindow.Show()
                MainWindow.Opacity = 1
                MainWindow.ShowInTaskbar = True
                MainWindow.Text = "MyCoding - User : " & UserNameTextBox.Text
                SettingsWindow.Text = "MyCoding - User : " & UserNameTextBox.Text
                LoginWindowStatus = "LoggingIn"
                MainWindow.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub UserNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserNameTextBox.TextChanged, PasswordTextBox.TextChanged
        If Not UserNameTextBox.Text = "" And Not PasswordTextBox.Text = "" Then
            LoginLabel.ForeColor = Color.Black
            LoginLabel.Cursor = Cursors.Hand
        Else
            LoginLabel.ForeColor = Color.Gray
            LoginLabel.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ShowPasswordPIC_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShowPasswordPIC.MouseDown
        PasswordTextBox.UseSystemPasswordChar = False
    End Sub

    Private Sub ShowPasswordPIC_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShowPasswordPIC.MouseUp
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub

    Private Sub LoginLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginLabel.Click
        If My.Settings.UserName = UserNameTextBox.Text And My.Settings.Password = PasswordTextBox.Text Then
            MainWindow.Show()
            MainWindow.Opacity = 1
            MainWindow.ShowInTaskbar = True
            MainWindow.Focus()
            MainWindow.Text = "MyCoding - User : " & UserNameTextBox.Text
            SettingsWindow.Text = "MyCoding - User : " & UserNameTextBox.Text
            LoginWindowStatus = "LoggingIn"
            Me.Close()
        End If
    End Sub

    Private Sub CancelLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelLabel.Click
        MainWindow.Close()
    End Sub
End Class