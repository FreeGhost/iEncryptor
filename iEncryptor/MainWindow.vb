Imports System.IO
Imports System.Security.Cryptography
Imports System.Threading

Public Class MainWindow
    Dim FirstRun As Boolean
    Dim CR, StopOrResume, LapOrReset, WindowStatus As String
    Dim MutexOBJ As Mutex, MutexKey As String = "jA0ECQMC5GFsxVyaTxWz0j4BO31+2uBUeiK3ZPwJT0PslVTTXncyTvbrBFpOsxIBGR44gBd/weChuh6QfZuqXapRvfnkRcIjzH+1HWYzTA===e2bj"

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MutexOBJ = New Mutex(False, MutexKey)
        If MutexOBJ.WaitOne(0, False) = False Then
            MutexOBJ.Close()
            MutexOBJ = Nothing
            MsgBox("Could not launch MyEncrypt" & vbCrLf & "Only one instance of iEncryptor can be run at a time.", MsgBoxStyle.Critical, "iEncryptor - ERROR")
            Close()
        End If
        If My.Settings.UserName = "" Then
            Me.Opacity = 1
            Me.ShowInTaskbar = True
        Else
            LoginWindow.Show()
        End If
    End Sub

    Function CloseTA()
        End
        Return 0
    End Function

    Private Sub EncryptLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptLabel.Click
        EDLabel.Left += 1
        EDLabel.Text = "Encrypt"
        EncryptPanel.Visible = True
        DecryptPanel.Visible = False
        LockFoldersPanel.Visible = False
        DecryptLabel.ForeColor = Color.Black
        EncryptLabel.ForeColor = Color.CadetBlue
        LockFoldersLabel.ForeColor = Color.Black
    End Sub

    Private Sub DecryptLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptLabel.Click
        EDLabel.Left -= 1
        EDLabel.Text = "Decrypt"
        DecryptPanel.Visible = True
        EncryptPanel.Visible = False
        LockFoldersPanel.Visible = False
        EncryptLabel.ForeColor = Color.Black
        DecryptLabel.ForeColor = Color.CadetBlue
        LockFoldersLabel.ForeColor = Color.Black
    End Sub

    Private Sub LockFoldersLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockFoldersLabel.Click
        EDLabel.Visible = False
        DecryptPanel.Visible = False
        EncryptPanel.Visible = False
        LockFoldersPanel.Visible = True
        FoldersOptionsPanel.Visible = True
        If Not My.Settings.LockFoldersPass = "" Then
            LFCPLabel.Visible = False
            LFCPTextBox.Visible = False
            SetEnterBUT.Text = "Enter"
        End If
        EncryptLabel.ForeColor = Color.Black
        DecryptLabel.ForeColor = Color.Black
        LockFoldersLabel.ForeColor = Color.CadetBlue
    End Sub

#Region "1. Global Variables "
    Dim FileToEncrypt As String
    Dim FileToDecrypt As String
    Dim OutputEncrypt As String
    Dim OutputDecrypt As String
    Dim FileSInput As FileStream
    Dim FileSOutput As FileStream
#End Region

#Region "2. Create A Key "
    Private Function CreateKey(ByVal strPassword As String) As Byte()
        Dim chrData() As Char = strPassword.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytKey(31) As Byte
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next
        Return bytKey
    End Function
#End Region

#Region "3. Create An IV "
    Private Function CreateIV(ByVal strPassword As String) As Byte()
        Dim chrData() As Char = strPassword.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytIV(15) As Byte
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next
        Return bytIV
    End Function
#End Region

#Region "4. Encrypt / Decrypt File "
    Private Enum CryptoAction
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, ByVal strOutputFile As String, ByVal bytKey() As Byte, ByVal bytIV() As Byte, ByVal Direction As CryptoAction)
        Try
            FileSInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            FileSOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            FileSOutput.SetLength(0)
            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = FileSInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim csCryptoStream As CryptoStream
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(FileSOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(FileSOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
            End Select
            While lngBytesProcessed < lngFileLength
                intBytesInCurrentBlock = FileSInput.Read(bytBuffer, 0, 4096)
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
            End While
            csCryptoStream.Close()
            FileSInput.Close()
            FileSOutput.Close()
            If Direction = CryptoAction.ActionEncrypt Then
                If My.Settings.CheckBox2Status = True Then
                    Dim OriginalFile As New FileInfo(FileToEncrypt)
                    OriginalFile.Delete()
                End If
            End If
            If Direction = CryptoAction.ActionDecrypt Then
                If My.Settings.CheckBox3Status = True Then
                    Dim EncryptedFile As New FileInfo(FileToDecrypt)
                    EncryptedFile.Delete()
                End If
            End If
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                MsgBox("Encryption Complete" + Wrap + Wrap + "Total bytes processed = " + lngBytesProcessed.ToString, MsgBoxStyle.Information, "Done")
                FileDTextBox.Text = ""
                EPasswordTextBox.Text = ""
                EConfirmPasswordTextBox.Text = ""
                FileTETextBox.Text = ""
                EDLabel.Enabled = False
                EDLabel.ForeColor = Color.Gray
            Else
                MsgBox("Decryption Complete" + Wrap + Wrap + lngBytesProcessed.ToString, MsgBoxStyle.Information, "Done")
                FileDTextBox2.Text = ""
                DPasswordTextBox.Text = ""
                DConfirmPasswordTextBox.Text = ""
                FileTDTextBox.Text = ""
                EDLabel.Enabled = False
                EDLabel.ForeColor = Color.Gray
            End If
        Catch When Err.Number = 53
            MsgBox("Please check to make sure the path and filename" + "are correct and if the file exists.", MsgBoxStyle.Exclamation, "Invalid Path or Filename")
        Catch
            FileSInput.Close()
            FileSOutput.Close()
            If Direction = CryptoAction.ActionDecrypt Then
                DPasswordTextBox.Text = ""
                DConfirmPasswordTextBox.Text = ""
                MsgBox("Please check to make sure that you entered the correct" + "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                EPasswordTextBox.Text = ""
                EConfirmPasswordTextBox.Text = ""
                MsgBox("This file cannot be encrypted.", MsgBoxStyle.Exclamation, "Invalid File")
            End If
        End Try
    End Sub
#End Region

#Region "5. Browse / Change Button "
    Private Sub BFileTELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFileTELabel.Click
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to encrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "All Files (*.*) | *.*"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            FileToEncrypt = OpenFileDialog.FileName
            FileTETextBox.Text = FileToEncrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0
            While FileToEncrypt.IndexOf("\"c, i) <> -1
                iPosition = FileToEncrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While
            OutputEncrypt = FileToEncrypt.Substring(iPosition + 1)
            Dim S As String = FileToEncrypt.Substring(0, iPosition + 1)
            OutputEncrypt = OutputEncrypt.Replace("."c, "_"c)
            FileDTextBox.Text = S + OutputEncrypt + ".encrypt"
            EDLabel.Enabled = True
            ChangeFileDLabel.Enabled = True
            ChangeFileDLabel.ForeColor = Color.Black
        End If
        EDLabel.Visible = True
    End Sub

    Private Sub BFileTDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFileTDLabel.Click
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to decrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            FileToDecrypt = OpenFileDialog.FileName
            FileTDTextBox.Text = FileToDecrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0
            While FileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = FileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While
            OutputDecrypt = FileToDecrypt.Substring(0, FileToDecrypt.Length - 8)
            Dim S As String = FileToDecrypt.Substring(0, iPosition + 1)
            OutputDecrypt = OutputDecrypt.Substring((iPosition + 1))
            FileDTextBox2.Text = S + OutputDecrypt.Replace("_"c, "."c)
            EDLabel.Enabled = True
            ChangeFileDLabel2.Enabled = True
            ChangeFileDLabel2.ForeColor = Color.Black
        End If

        EDLabel.Visible = True
    End Sub

    Private Sub ChangeFileDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFileDLabel.Click
        FolderBrowserDialog.Description = "Select a folder to place the encrypted file in."
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            FileDTextBox.Text = FolderBrowserDialog.SelectedPath + "\" + OutputEncrypt + ".encrypt"
        End If
    End Sub

    Private Sub ChangeFileDLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFileDLabel2.Click
        FolderBrowserDialog.Description = "Select a folder for to place the decrypted file in."
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            FileDTextBox2.Text = FolderBrowserDialog.SelectedPath + "\" + OutputDecrypt.Replace("_"c, "."c)
        End If
    End Sub
#End Region

#Region "6.Encrypt / Decrypt Button"
    Private Sub EDLabel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EDLabel.Click
        If EDLabel.Text = "Encrypt" Then
            If EConfirmPasswordTextBox.Text = EPasswordTextBox.Text Then
                Dim bytKey As Byte()
                Dim bytIV As Byte()
                bytKey = CreateKey(EPasswordTextBox.Text)
                bytIV = CreateIV(EPasswordTextBox.Text)
                EncryptOrDecryptFile(FileToEncrypt, FileDTextBox.Text, bytKey, bytIV, CryptoAction.ActionEncrypt)
            Else
                MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
                EPasswordTextBox.Text = ""
                EPasswordTextBox.Text = ""
            End If
        ElseIf EDLabel.Text = "Decrypt" Then
            If DConfirmPasswordTextBox.Text = DPasswordTextBox.Text Then
                Dim bytKey As Byte()
                Dim bytIV As Byte()
                bytKey = CreateKey(DPasswordTextBox.Text)
                bytIV = CreateIV(DPasswordTextBox.Text)
                EncryptOrDecryptFile(FileToDecrypt, FileDTextBox2.Text, bytKey, bytIV, CryptoAction.ActionDecrypt)
            Else
                MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
                DPasswordTextBox.Text = ""
                DConfirmPasswordTextBox.Text = ""
            End If
        ElseIf EDLabel.Text = "Lock" Then
            Shell("cmd /c" & "ren """ & FolderPathTextBox.Text & """ """ & FolderNameTextBox.Text & """.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
            Shell("cmd /c" & "attrib +s +h """ & FolderPathTextBox.Text & """.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\*.*" & " /S /D")
            Shell("cmd /c" & "attrib +s +h """ & FolderPathTextBox.Text & """.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}" & " /S /D")
        ElseIf EDLabel.Text = "Unlock" Then
            Shell("cmd /c" & "attrib -s -h """ & FolderPathTextBox.Text & """.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}" & " /S /D")
            Shell("cmd /c" & "attrib -s -h """ & FolderPathTextBox.Text & """.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\*.*" & " /S /D")
            Thread.Sleep(1000)
            Shell("cmd /c" & "ren """ & FolderPathTextBox.Text & """.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}" & " """ & FolderNameTextBox.Text & """")
        End If
    End Sub

    Private Sub BrowsFoldersBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BrowsFoldersBUT.Click
        LockFoldersBrowserDialog.ShowDialog()
        FolderPathTextBox.Text = LockFoldersBrowserDialog.SelectedPath
        FolderNameTextBox.Text = Path.GetFileName(LockFoldersBrowserDialog.SelectedPath)
        FolderPathTextBox.Text = FolderPathTextBox.Text.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "")
        FolderNameTextBox.Text = FolderNameTextBox.Text.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "")
        EDLabel.Enabled = True
    End Sub

#End Region

    Private Sub EPasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles EPasswordTextBox.TextChanged
        If Not EPasswordTextBox.Text = "" And Not EConfirmPasswordLabel.Text = "" Then
            EDLabel.Enabled = True
            EDLabel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub EConfirmPasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles EConfirmPasswordTextBox.TextChanged
        If Not EPasswordTextBox.Text = "" And Not EConfirmPasswordLabel.Text = "" Then
            EDLabel.Enabled = True
            EDLabel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub DPasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DPasswordTextBox.TextChanged
        If Not DPasswordTextBox.Text = "" And Not DConfirmPasswordLabel.Text = "" Then
            EDLabel.Enabled = True
            EDLabel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub DConfirmPasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DConfirmPasswordTextBox.TextChanged
        If Not DPasswordTextBox.Text = "" And Not DConfirmPasswordLabel.Text = "" Then
            EDLabel.Enabled = True
            EDLabel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SettingsPIC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsPIC.Click
        Me.Enabled = False
        SettingsWindow.Show()
    End Sub

    Private Sub AboutMePIC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMePIC.Click
        Me.Enabled = False
        AboutWindow.Show()
    End Sub

    Private Sub CancelLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelLabel.Click
        Close()
    End Sub

    Private Sub LockOptionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockOptionLabel.Click
        EDLabel.Text = "Lock"
        EDLabel.Visible = True
        FoldersOptionsPanel.Visible = False
    End Sub

    Private Sub UnlockOptionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlockOptionLabel.Click
        EDLabel.Text = "Unlock"
        EDLabel.Visible = True
        FoldersOptionsPanel.Visible = False
    End Sub

    Private Sub SetEnterBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetEnterBUT.Click
        If SetEnterBUT.Text = "Set" Then
            If LFPTextBox.Text = LFCPTextBox.Text Then
                My.Settings.LockFoldersPass = LFPTextBox.Text
                LFSecurityPanel.Visible = False
                LockOptionLabel.Enabled = True
                UnlockOptionLabel.Enabled = True
            Else
                Beep()
                LFCPTextBox.Text = ""
            End If
        Else
            If LFPTextBox.Text = My.Settings.LockFoldersPass Then
                LFSecurityPanel.Visible = False
                LockOptionLabel.Enabled = True
                UnlockOptionLabel.Enabled = True
            Else
                Beep()
                LFCPTextBox.Text = ""
            End If
        End If
    End Sub

    Private Sub LFPTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LFPTextBox.TextChanged
        If SetEnterBUT.Text = "Enter" Then
            If Not LFPTextBox.Text = "" Then
                SetEnterBUT.Enabled = True
            Else
                SetEnterBUT.Enabled = False
            End If
        Else
            If Not LFPTextBox.Text = "" And Not LFCPTextBox.Text = "" Then
                SetEnterBUT.Enabled = True
            Else
                SetEnterBUT.Enabled = False
            End If
        End If
    End Sub

    Private Sub LFCPTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LFCPTextBox.TextChanged
        If SetEnterBUT.Text = "Enter" Then
            If Not LFPTextBox.Text = "" Then
                SetEnterBUT.Enabled = True
            Else
                SetEnterBUT.Enabled = False
            End If
        Else
            If Not LFPTextBox.Text = "" And Not LFCPTextBox.Text = "" Then
                SetEnterBUT.Enabled = True
            Else
                SetEnterBUT.Enabled = False
            End If
        End If
    End Sub
End Class