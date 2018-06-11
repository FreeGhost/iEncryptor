Imports Microsoft.Win32

Public Class SettingsWindow
    Dim Value As String = Application.ExecutablePath
    Dim CheckBox1Status, CheckBox2Status, CheckBox3Status As Boolean
    Dim KeyName As String = "Software\Microsoft\Windows\CurrentVersion\Run"

    Private Sub SettingsWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = MainWindow.Location
        If Not My.Settings.UserName = "" Then
            CurrentPasswordOrUserTextBox.Left = 159
            CurrentPasswordOrUserTextBox.Width = 186
            CurrentPasswordOrUserLabel.Text = "Current password :"
            CurrentPasswordOrUserTextBox.UseSystemPasswordChar = True
            NewPasswordTextBox.Left = 142
            NewPasswordTextBox.Width = 203
            NewPasswordLabel.Text = "New Password :"
            DeleteUserLabel.Visible = True
        Else
            CurrentPasswordOrUserTextBox.Text = My.Settings.UserName
            GeneralSettingsLabel.Top = NewPasswordLabel.Top + 47
            CheckBoxPIC1.Top = GeneralSettingsLabel.Top + 37
            SPALabel.Top = CheckBoxPIC1.Top - 1
            CheckBoxPIC2.Top = CheckBoxPIC1.Top + 29
            DTOFAELabel.Top = CheckBoxPIC2.Top - 1
            CheckBoxPIC3.Top = CheckBoxPIC2.Top + 29
            DTEFADLabel.Top = CheckBoxPIC3.Top - 1
            HiddenLabel.Top = CheckBoxPIC3.Top + 23
        End If
        If My.Settings.CheckBox1Status = True Then
            CheckBox1Status = True
            CheckBoxPIC1.Image = My.Resources.CheckBox_Checked
        Else
            CheckBox1Status = False
            CheckBoxPIC1.Image = My.Resources.CheckBox_UnChecked
        End If
        If My.Settings.CheckBox2Status = True Then
            CheckBox2Status = True
            CheckBoxPIC2.Image = My.Resources.CheckBox_Checked
        Else
            CheckBox2Status = False
            CheckBoxPIC2.Image = My.Resources.CheckBox_UnChecked
        End If
        If My.Settings.CheckBox3Status = True Then
            CheckBox3Status = True
            CheckBoxPIC3.Image = My.Resources.CheckBox_Checked
        Else
            CheckBox2Status = False
            CheckBoxPIC3.Image = My.Resources.CheckBox_UnChecked
        End If
        NewPasswordTextBox.Focus()
    End Sub

    Private Sub SettingsWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainWindow.Enabled = True
    End Sub

    Private Sub CurrentPasswordOrUserTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CurrentPasswordOrUserTextBox.KeyDown, NewPasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CurrentPasswordOrUserLabel.Text = "Username :" Then
                If CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                    MsgBox("Please enter a username.", 48, "MyCoding - ERROR")
                    GoTo Wrong
                ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And NewPasswordTextBox.Text = "" Then
                    MsgBox("Please enter a password.", 48, "MyCoding - ERROR")
                    GoTo Wrong
                ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                    My.Settings.UserName = CurrentPasswordOrUserTextBox.Text
                    My.Settings.Password = NewPasswordTextBox.Text
                End If
            Else
                If CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                    MsgBox("Please enter the current password.", 48, "MyCoding - ERROR")
                    GoTo Wrong
                ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And NewPasswordTextBox.Text = "" Then
                    If CurrentPasswordOrUserTextBox.Text = My.Settings.Password Then
                        MsgBox("Please enter the new password.", 48, "MyCoding - ERROR")
                        GoTo Wrong
                    Else
                        MsgBox("Wrong password" & vbCrLf & "Please re-check your password", 48, "MyCoding - ERROR")
                        GoTo Wrong
                    End If
                ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                    If CurrentPasswordOrUserTextBox.Text = My.Settings.Password Then
                        My.Settings.Password = NewPasswordTextBox.Text
                    Else
                        MsgBox("Wrong password" & vbCrLf & "Please re-check your password", 48, "MyCoding - ERROR")
                        GoTo Wrong
                    End If
                End If
            End If
            If CheckBox1Status = False Then
                If My.Settings.CheckBox1Status = True Then
                    My.Settings.CheckBox1Status = False
                    My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).DeleteValue(Application.ProductName, True)
                End If
            Else
                My.Settings.CheckBox1Status = True
                My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).SetValue(Application.ProductName, Value)
            End If
            If CheckBox2Status = False Then
                My.Settings.CheckBox2Status = False
            Else
                My.Settings.CheckBox2Status = True
            End If
            If CheckBox3Status = False Then
                My.Settings.CheckBox3Status = False
            Else
                My.Settings.CheckBox3Status = True
            End If
            CurrentPasswordOrUserTextBox.Text = ""
            NewPasswordTextBox.Text = ""
            HiddenTextBox.Focus()
            CurrentPasswordOrUserTextBox.Focus()
            Me.Close()
Wrong:
        End If
    End Sub

    Private Sub CheckBoxPIC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPIC1.Click
        If CheckBox1Status = False Then
            CheckBox1Status = True
            CheckBoxPIC1.Image = My.Resources.CheckBox_Checked
        Else
            CheckBox1Status = False
            CheckBoxPIC1.Image = My.Resources.CheckBox_UnChecked
        End If
    End Sub

    Private Sub CheckBoxPIC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPIC2.Click
        If CheckBox2Status = False Then
            CheckBox2Status = True
            CheckBoxPIC2.Image = My.Resources.CheckBox_Checked
        Else
            CheckBox2Status = False
            CheckBoxPIC2.Image = My.Resources.CheckBox_UnChecked
        End If
    End Sub

    Private Sub CheckBoxPIC3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPIC3.Click
        If CheckBox3Status = False Then
            CheckBox3Status = True
            CheckBoxPIC3.Image = My.Resources.CheckBox_Checked
        Else
            CheckBox3Status = False
            CheckBoxPIC3.Image = My.Resources.CheckBox_UnChecked
        End If
    End Sub

    Private Sub SaveLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveLabel.Click
        If CurrentPasswordOrUserLabel.Text = "Username :" Then
            If CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                MsgBox("Please enter a username.", 48, "MyCoding - ERROR")
                GoTo Wrong
            ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And NewPasswordTextBox.Text = "" Then
                MsgBox("Please enter a password.", 48, "MyCoding - ERROR")
                GoTo Wrong
            ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                My.Settings.UserName = CurrentPasswordOrUserTextBox.Text
                My.Settings.Password = NewPasswordTextBox.Text
            End If
        Else
            If CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                MsgBox("Please enter the current password.", 48, "MyCoding - ERROR")
                GoTo Wrong
            ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And NewPasswordTextBox.Text = "" Then
                If CurrentPasswordOrUserTextBox.Text = My.Settings.Password Then
                    MsgBox("Please enter the new password.", 48, "MyCoding - ERROR")
                    GoTo Wrong
                Else
                    MsgBox("Wrong password" & vbCrLf & "Please re-check your password", 48, "MyCoding - ERROR")
                    GoTo Wrong
                End If
            ElseIf Not CurrentPasswordOrUserTextBox.Text = "" And Not NewPasswordTextBox.Text = "" Then
                If CurrentPasswordOrUserTextBox.Text = My.Settings.Password Then
                    My.Settings.Password = NewPasswordTextBox.Text
                Else
                    MsgBox("Wrong password" & vbCrLf & "Please re-check your password", 48, "MyCoding - ERROR")
                    GoTo Wrong
                End If
            End If
        End If
        If CheckBox1Status = False Then
            If My.Settings.CheckBox1Status = True Then
                My.Settings.CheckBox1Status = False
                My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).DeleteValue(Application.ProductName, True)
            End If
        Else
            My.Settings.CheckBox1Status = True
            My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).SetValue(Application.ProductName, Value)
        End If
        If CheckBox2Status = False Then
            My.Settings.CheckBox2Status = False
        Else
            My.Settings.CheckBox2Status = True
        End If
        If CheckBox3Status = False Then
            My.Settings.CheckBox3Status = False
        Else
            My.Settings.CheckBox3Status = True
        End If
        CurrentPasswordOrUserTextBox.Text = ""
        NewPasswordTextBox.Text = ""
        HiddenTextBox.Focus()
        CurrentPasswordOrUserTextBox.Focus()
        Me.Close()
Wrong:
    End Sub

    Private Sub CancelLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelLabel.Click
        CurrentPasswordOrUserTextBox.Text = ""
        NewPasswordTextBox.Text = ""
        HiddenTextBox.Focus()
        CurrentPasswordOrUserTextBox.Focus()
        Me.Close()
    End Sub

    Private Sub DeleteUserLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserLabel.Click
        CurrentPasswordOrUserTextBox.Left = 111
        CurrentPasswordOrUserTextBox.Width = 186
        CurrentPasswordOrUserLabel.Text = "Username :"
        CurrentPasswordOrUserTextBox.UseSystemPasswordChar = True
        CurrentPasswordOrUserTextBox.Text = ""
        NewPasswordTextBox.Left = 108
        NewPasswordTextBox.Width = 203
        NewPasswordLabel.Text = "Password :"
        NewPasswordTextBox.Text = ""
        DeleteUserLabel.Visible = False
        My.Settings.UserName = ""
        My.Settings.Password = ""
        CurrentPasswordOrUserTextBox.Text = My.Settings.UserName
        GeneralSettingsLabel.Top = NewPasswordLabel.Top + 47
        CheckBoxPIC1.Top = GeneralSettingsLabel.Top + 37
        SPALabel.Top = CheckBoxPIC1.Top - 1
        CheckBoxPIC2.Top = CheckBoxPIC1.Top + 29
        DTOFAELabel.Top = CheckBoxPIC2.Top - 1
        CheckBoxPIC3.Top = CheckBoxPIC2.Top + 29
        DTEFADLabel.Top = CheckBoxPIC3.Top - 1
        HiddenLabel.Top = CheckBoxPIC3.Top + 23
        Me.Text = "MyCoding"
        MainWindow.Text = "MyCoding"
    End Sub
End Class