<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsWindow))
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.DeleteUserLabel = New System.Windows.Forms.Label()
        Me.CheckBoxPIC3 = New System.Windows.Forms.PictureBox()
        Me.DTEFADLabel = New System.Windows.Forms.Label()
        Me.CheckBoxPIC2 = New System.Windows.Forms.PictureBox()
        Me.DTOFAELabel = New System.Windows.Forms.Label()
        Me.HiddenTextBox = New System.Windows.Forms.TextBox()
        Me.HiddenLabel = New System.Windows.Forms.Label()
        Me.CheckBoxPIC1 = New System.Windows.Forms.PictureBox()
        Me.SPALabel = New System.Windows.Forms.Label()
        Me.GeneralSettingsLabel = New System.Windows.Forms.Label()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentPasswordOrUserTextBox = New System.Windows.Forms.TextBox()
        Me.NewPasswordLabel = New System.Windows.Forms.Label()
        Me.CurrentPasswordOrUserLabel = New System.Windows.Forms.Label()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.CancelLabel = New System.Windows.Forms.Label()
        Me.SaveLabel = New System.Windows.Forms.Label()
        Me.TitlePanel.SuspendLayout()
        Me.SettingsPanel.SuspendLayout()
        CType(Me.CheckBoxPIC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBoxPIC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBoxPIC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.White
        Me.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitlePanel.Controls.Add(Me.TitleLabel)
        Me.TitlePanel.Location = New System.Drawing.Point(-2, 14)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(378, 59)
        Me.TitlePanel.TabIndex = 0
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.White
        Me.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.Crimson
        Me.TitleLabel.Location = New System.Drawing.Point(6, 14)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(198, 28)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "iEncryptor - Settings"
        '
        'SettingsPanel
        '
        Me.SettingsPanel.AutoScroll = True
        Me.SettingsPanel.BackColor = System.Drawing.Color.White
        Me.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SettingsPanel.Controls.Add(Me.DeleteUserLabel)
        Me.SettingsPanel.Controls.Add(Me.CheckBoxPIC3)
        Me.SettingsPanel.Controls.Add(Me.DTEFADLabel)
        Me.SettingsPanel.Controls.Add(Me.CheckBoxPIC2)
        Me.SettingsPanel.Controls.Add(Me.DTOFAELabel)
        Me.SettingsPanel.Controls.Add(Me.HiddenTextBox)
        Me.SettingsPanel.Controls.Add(Me.HiddenLabel)
        Me.SettingsPanel.Controls.Add(Me.CheckBoxPIC1)
        Me.SettingsPanel.Controls.Add(Me.SPALabel)
        Me.SettingsPanel.Controls.Add(Me.GeneralSettingsLabel)
        Me.SettingsPanel.Controls.Add(Me.NewPasswordTextBox)
        Me.SettingsPanel.Controls.Add(Me.CurrentPasswordOrUserTextBox)
        Me.SettingsPanel.Controls.Add(Me.NewPasswordLabel)
        Me.SettingsPanel.Controls.Add(Me.CurrentPasswordOrUserLabel)
        Me.SettingsPanel.Controls.Add(Me.LoginLabel)
        Me.SettingsPanel.Location = New System.Drawing.Point(-2, 84)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Size = New System.Drawing.Size(378, 146)
        Me.SettingsPanel.TabIndex = 1
        '
        'DeleteUserLabel
        '
        Me.DeleteUserLabel.AutoSize = True
        Me.DeleteUserLabel.BackColor = System.Drawing.Color.White
        Me.DeleteUserLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteUserLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserLabel.ForeColor = System.Drawing.Color.Maroon
        Me.DeleteUserLabel.Location = New System.Drawing.Point(32, 103)
        Me.DeleteUserLabel.Name = "DeleteUserLabel"
        Me.DeleteUserLabel.Size = New System.Drawing.Size(95, 21)
        Me.DeleteUserLabel.TabIndex = 78
        Me.DeleteUserLabel.Text = "Delete User"
        Me.DeleteUserLabel.Visible = False
        '
        'CheckBoxPIC3
        '
        Me.CheckBoxPIC3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPIC3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxPIC3.Image = Global.iEncryptor.My.Resources.Resources.CheckBox_UnChecked
        Me.CheckBoxPIC3.Location = New System.Drawing.Point(33, 243)
        Me.CheckBoxPIC3.Name = "CheckBoxPIC3"
        Me.CheckBoxPIC3.Size = New System.Drawing.Size(17, 17)
        Me.CheckBoxPIC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CheckBoxPIC3.TabIndex = 76
        Me.CheckBoxPIC3.TabStop = False
        '
        'DTEFADLabel
        '
        Me.DTEFADLabel.AutoSize = True
        Me.DTEFADLabel.BackColor = System.Drawing.Color.Transparent
        Me.DTEFADLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DTEFADLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DTEFADLabel.Location = New System.Drawing.Point(54, 243)
        Me.DTEFADLabel.Name = "DTEFADLabel"
        Me.DTEFADLabel.Size = New System.Drawing.Size(259, 17)
        Me.DTEFADLabel.TabIndex = 77
        Me.DTEFADLabel.Text = "Delete the encrypted file after decryption"
        '
        'CheckBoxPIC2
        '
        Me.CheckBoxPIC2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPIC2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxPIC2.Image = Global.iEncryptor.My.Resources.Resources.CheckBox_UnChecked
        Me.CheckBoxPIC2.Location = New System.Drawing.Point(33, 212)
        Me.CheckBoxPIC2.Name = "CheckBoxPIC2"
        Me.CheckBoxPIC2.Size = New System.Drawing.Size(17, 17)
        Me.CheckBoxPIC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CheckBoxPIC2.TabIndex = 74
        Me.CheckBoxPIC2.TabStop = False
        '
        'DTOFAELabel
        '
        Me.DTOFAELabel.AutoSize = True
        Me.DTOFAELabel.BackColor = System.Drawing.Color.Transparent
        Me.DTOFAELabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DTOFAELabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DTOFAELabel.Location = New System.Drawing.Point(54, 212)
        Me.DTOFAELabel.Name = "DTOFAELabel"
        Me.DTOFAELabel.Size = New System.Drawing.Size(242, 17)
        Me.DTOFAELabel.TabIndex = 75
        Me.DTOFAELabel.Text = "Delete the original file after encryption"
        '
        'HiddenTextBox
        '
        Me.HiddenTextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.HiddenTextBox.Location = New System.Drawing.Point(5, -20)
        Me.HiddenTextBox.Name = "HiddenTextBox"
        Me.HiddenTextBox.ReadOnly = True
        Me.HiddenTextBox.Size = New System.Drawing.Size(10, 20)
        Me.HiddenTextBox.TabIndex = 73
        '
        'HiddenLabel
        '
        Me.HiddenLabel.AutoSize = True
        Me.HiddenLabel.BackColor = System.Drawing.Color.Transparent
        Me.HiddenLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.HiddenLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HiddenLabel.Location = New System.Drawing.Point(13, 266)
        Me.HiddenLabel.Name = "HiddenLabel"
        Me.HiddenLabel.Size = New System.Drawing.Size(0, 17)
        Me.HiddenLabel.TabIndex = 72
        '
        'CheckBoxPIC1
        '
        Me.CheckBoxPIC1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPIC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxPIC1.Image = Global.iEncryptor.My.Resources.Resources.CheckBox_UnChecked
        Me.CheckBoxPIC1.Location = New System.Drawing.Point(33, 181)
        Me.CheckBoxPIC1.Name = "CheckBoxPIC1"
        Me.CheckBoxPIC1.Size = New System.Drawing.Size(17, 17)
        Me.CheckBoxPIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CheckBoxPIC1.TabIndex = 70
        Me.CheckBoxPIC1.TabStop = False
        '
        'SPALabel
        '
        Me.SPALabel.AutoSize = True
        Me.SPALabel.BackColor = System.Drawing.Color.Transparent
        Me.SPALabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SPALabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SPALabel.Location = New System.Drawing.Point(54, 180)
        Me.SPALabel.Name = "SPALabel"
        Me.SPALabel.Size = New System.Drawing.Size(252, 17)
        Me.SPALabel.TabIndex = 71
        Me.SPALabel.Text = "Start iEncryptor when computer startup"
        '
        'GeneralSettingsLabel
        '
        Me.GeneralSettingsLabel.AutoSize = True
        Me.GeneralSettingsLabel.BackColor = System.Drawing.Color.White
        Me.GeneralSettingsLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.GeneralSettingsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralSettingsLabel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GeneralSettingsLabel.Location = New System.Drawing.Point(7, 144)
        Me.GeneralSettingsLabel.Name = "GeneralSettingsLabel"
        Me.GeneralSettingsLabel.Size = New System.Drawing.Size(128, 21)
        Me.GeneralSettingsLabel.TabIndex = 26
        Me.GeneralSettingsLabel.Text = "General settings"
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(108, 72)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(237, 20)
        Me.NewPasswordTextBox.TabIndex = 25
        Me.NewPasswordTextBox.UseSystemPasswordChar = True
        '
        'CurrentPasswordOrUserTextBox
        '
        Me.CurrentPasswordOrUserTextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.CurrentPasswordOrUserTextBox.Location = New System.Drawing.Point(111, 41)
        Me.CurrentPasswordOrUserTextBox.Name = "CurrentPasswordOrUserTextBox"
        Me.CurrentPasswordOrUserTextBox.Size = New System.Drawing.Size(234, 20)
        Me.CurrentPasswordOrUserTextBox.TabIndex = 24
        '
        'NewPasswordLabel
        '
        Me.NewPasswordLabel.AutoSize = True
        Me.NewPasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NewPasswordLabel.Location = New System.Drawing.Point(32, 71)
        Me.NewPasswordLabel.Name = "NewPasswordLabel"
        Me.NewPasswordLabel.Size = New System.Drawing.Size(75, 19)
        Me.NewPasswordLabel.TabIndex = 23
        Me.NewPasswordLabel.Text = "Password :"
        Me.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CurrentPasswordOrUserLabel
        '
        Me.CurrentPasswordOrUserLabel.AutoSize = True
        Me.CurrentPasswordOrUserLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CurrentPasswordOrUserLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrentPasswordOrUserLabel.Location = New System.Drawing.Point(32, 40)
        Me.CurrentPasswordOrUserLabel.Name = "CurrentPasswordOrUserLabel"
        Me.CurrentPasswordOrUserLabel.Size = New System.Drawing.Size(78, 19)
        Me.CurrentPasswordOrUserLabel.TabIndex = 22
        Me.CurrentPasswordOrUserLabel.Text = "Username :"
        Me.CurrentPasswordOrUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.BackColor = System.Drawing.Color.White
        Me.LoginLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LoginLabel.Location = New System.Drawing.Point(7, 8)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(113, 21)
        Me.LoginLabel.TabIndex = 21
        Me.LoginLabel.Text = "Login settings"
        '
        'CancelLabel
        '
        Me.CancelLabel.AutoSize = True
        Me.CancelLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelLabel.Location = New System.Drawing.Point(312, 241)
        Me.CancelLabel.Name = "CancelLabel"
        Me.CancelLabel.Size = New System.Drawing.Size(54, 20)
        Me.CancelLabel.TabIndex = 5
        Me.CancelLabel.Text = "Cancel"
        '
        'SaveLabel
        '
        Me.SaveLabel.AutoSize = True
        Me.SaveLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveLabel.ForeColor = System.Drawing.Color.Black
        Me.SaveLabel.Location = New System.Drawing.Point(255, 241)
        Me.SaveLabel.Name = "SaveLabel"
        Me.SaveLabel.Size = New System.Drawing.Size(41, 20)
        Me.SaveLabel.TabIndex = 4
        Me.SaveLabel.Text = "Save"
        '
        'SettingsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(374, 272)
        Me.Controls.Add(Me.CancelLabel)
        Me.Controls.Add(Me.SaveLabel)
        Me.Controls.Add(Me.SettingsPanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iEncryptor"
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.SettingsPanel.ResumeLayout(False)
        Me.SettingsPanel.PerformLayout()
        CType(Me.CheckBoxPIC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBoxPIC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBoxPIC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents SettingsPanel As System.Windows.Forms.Panel
    Friend WithEvents LoginLabel As System.Windows.Forms.Label
    Friend WithEvents NewPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrentPasswordOrUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentPasswordOrUserLabel As System.Windows.Forms.Label
    Friend WithEvents GeneralSettingsLabel As System.Windows.Forms.Label
    Friend WithEvents CheckBoxPIC1 As System.Windows.Forms.PictureBox
    Friend WithEvents SPALabel As System.Windows.Forms.Label
    Friend WithEvents HiddenLabel As System.Windows.Forms.Label
    Friend WithEvents CancelLabel As System.Windows.Forms.Label
    Friend WithEvents SaveLabel As System.Windows.Forms.Label
    Friend WithEvents HiddenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxPIC3 As System.Windows.Forms.PictureBox
    Friend WithEvents DTEFADLabel As System.Windows.Forms.Label
    Friend WithEvents CheckBoxPIC2 As System.Windows.Forms.PictureBox
    Friend WithEvents DTOFAELabel As System.Windows.Forms.Label
    Friend WithEvents DeleteUserLabel As System.Windows.Forms.Label
End Class
