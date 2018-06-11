<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginWindow))
        Me.TitleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.ShowPasswordPIC = New System.Windows.Forms.PictureBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.CancelLabel = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        CType(Me.ShowPasswordPIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleTimer
        '
        Me.TitleTimer.Interval = 1
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.ShowPasswordPIC)
        Me.MainPanel.Controls.Add(Me.PasswordTextBox)
        Me.MainPanel.Controls.Add(Me.PasswordLabel)
        Me.MainPanel.Controls.Add(Me.UserNameTextBox)
        Me.MainPanel.Controls.Add(Me.UserNameLabel)
        Me.MainPanel.Location = New System.Drawing.Point(-1, 101)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(376, 129)
        Me.MainPanel.TabIndex = 1
        '
        'ShowPasswordPIC
        '
        Me.ShowPasswordPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShowPasswordPIC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPasswordPIC.Image = Global.iEncryptor.My.Resources.Resources.EyePIC
        Me.ShowPasswordPIC.Location = New System.Drawing.Point(217, 88)
        Me.ShowPasswordPIC.Name = "ShowPasswordPIC"
        Me.ShowPasswordPIC.Size = New System.Drawing.Size(20, 20)
        Me.ShowPasswordPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ShowPasswordPIC.TabIndex = 5
        Me.ShowPasswordPIC.TabStop = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.PasswordTextBox.Location = New System.Drawing.Point(11, 88)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(207, 20)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(8, 67)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(73, 17)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password :"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.UserNameTextBox.Location = New System.Drawing.Point(11, 35)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(207, 20)
        Me.UserNameTextBox.TabIndex = 2
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLabel.Location = New System.Drawing.Point(8, 14)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(76, 17)
        Me.UserNameLabel.TabIndex = 1
        Me.UserNameLabel.Text = "Username :"
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.Color.Gray
        Me.LoginLabel.Location = New System.Drawing.Point(255, 241)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(47, 20)
        Me.LoginLabel.TabIndex = 2
        Me.LoginLabel.Text = "Login"
        '
        'CancelLabel
        '
        Me.CancelLabel.AutoSize = True
        Me.CancelLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelLabel.Location = New System.Drawing.Point(312, 241)
        Me.CancelLabel.Name = "CancelLabel"
        Me.CancelLabel.Size = New System.Drawing.Size(54, 20)
        Me.CancelLabel.TabIndex = 3
        Me.CancelLabel.Text = "Cancel"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.BackgroundImage = Global.iEncryptor.My.Resources.Resources.Title___BG
        Me.TitlePanel.Controls.Add(Me.TitleLabel)
        Me.TitlePanel.Location = New System.Drawing.Point(-210, 12)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(209, 79)
        Me.TitlePanel.TabIndex = 0
        Me.TitlePanel.Tag = "-210, 12"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(21, 26)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(166, 25)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "MyCoding - Login"
        '
        'LoginWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(374, 272)
        Me.Controls.Add(Me.CancelLabel)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "iEncryptor"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.ShowPasswordPIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents TitleTimer As System.Windows.Forms.Timer
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameLabel As System.Windows.Forms.Label
    Friend WithEvents LoginLabel As System.Windows.Forms.Label
    Friend WithEvents CancelLabel As System.Windows.Forms.Label
    Friend WithEvents ShowPasswordPIC As System.Windows.Forms.PictureBox
End Class
