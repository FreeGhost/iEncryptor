<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutWindow))
        Me.AboutMePIC = New System.Windows.Forms.PictureBox()
        Me.TwitterPIC = New System.Windows.Forms.PictureBox()
        Me.YoutubePIC = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.AboutMePIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwitterPIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YoutubePIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutMePIC
        '
        Me.AboutMePIC.BackColor = System.Drawing.Color.Transparent
        Me.AboutMePIC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutMePIC.Location = New System.Drawing.Point(59, 207)
        Me.AboutMePIC.Name = "AboutMePIC"
        Me.AboutMePIC.Size = New System.Drawing.Size(56, 53)
        Me.AboutMePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AboutMePIC.TabIndex = 0
        Me.AboutMePIC.TabStop = False
        Me.ToolTip.SetToolTip(Me.AboutMePIC, "Feedback on my Website")
        '
        'TwitterPIC
        '
        Me.TwitterPIC.BackColor = System.Drawing.Color.Transparent
        Me.TwitterPIC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TwitterPIC.Location = New System.Drawing.Point(258, 207)
        Me.TwitterPIC.Name = "TwitterPIC"
        Me.TwitterPIC.Size = New System.Drawing.Size(58, 53)
        Me.TwitterPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TwitterPIC.TabIndex = 1
        Me.TwitterPIC.TabStop = False
        Me.ToolTip.SetToolTip(Me.TwitterPIC, "Follow Me!")
        '
        'YoutubePIC
        '
        Me.YoutubePIC.BackColor = System.Drawing.Color.Transparent
        Me.YoutubePIC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YoutubePIC.Location = New System.Drawing.Point(132, 207)
        Me.YoutubePIC.Name = "YoutubePIC"
        Me.YoutubePIC.Size = New System.Drawing.Size(111, 53)
        Me.YoutubePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.YoutubePIC.TabIndex = 2
        Me.YoutubePIC.TabStop = False
        Me.ToolTip.SetToolTip(Me.YoutubePIC, "My YouTube Channel")
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 1
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 1
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ReshowDelay = 0
        '
        'AboutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.iEncryptor.My.Resources.Resources.AboutWindow___BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(374, 272)
        Me.Controls.Add(Me.YoutubePIC)
        Me.Controls.Add(Me.TwitterPIC)
        Me.Controls.Add(Me.AboutMePIC)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iEncryptor"
        Me.TopMost = True
        CType(Me.AboutMePIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwitterPIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YoutubePIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AboutMePIC As System.Windows.Forms.PictureBox
    Friend WithEvents TwitterPIC As System.Windows.Forms.PictureBox
    Friend WithEvents YoutubePIC As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
