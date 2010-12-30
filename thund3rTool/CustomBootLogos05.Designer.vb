<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomBootLogos05
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomBootLogos05))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BootLogo = New System.Windows.Forms.TabPage()
        Me.BootPicture = New System.Windows.Forms.PictureBox()
        Me.RecoveryLogo = New System.Windows.Forms.TabPage()
        Me.RecoveryPicture = New System.Windows.Forms.PictureBox()
        Me.CustomBootCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomRecoveryLogoCheck = New System.Windows.Forms.CheckBox()
        Me.BrowseBoot = New System.Windows.Forms.Button()
        Me.BrowseRecovery = New System.Windows.Forms.Button()
        Me.blackthund3rBootLogoCheck = New System.Windows.Forms.CheckBox()
        Me.blackthund3rRecoveryLogoCheck = New System.Windows.Forms.CheckBox()
        Me.OpenBootLogo = New System.Windows.Forms.OpenFileDialog()
        Me.OpenRecoveryLogo = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NextButtonLogos = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.BootLogo.SuspendLayout()
        CType(Me.BootPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecoveryLogo.SuspendLayout()
        CType(Me.RecoveryPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BootLogo)
        Me.TabControl1.Controls.Add(Me.RecoveryLogo)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(388, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(334, 514)
        Me.TabControl1.TabIndex = 6
        '
        'BootLogo
        '
        Me.BootLogo.BackColor = System.Drawing.Color.Black
        Me.BootLogo.Controls.Add(Me.BootPicture)
        Me.BootLogo.Location = New System.Drawing.Point(4, 25)
        Me.BootLogo.Name = "BootLogo"
        Me.BootLogo.Padding = New System.Windows.Forms.Padding(3)
        Me.BootLogo.Size = New System.Drawing.Size(326, 485)
        Me.BootLogo.TabIndex = 0
        Me.BootLogo.Text = "Boot Logo"
        '
        'BootPicture
        '
        Me.BootPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BootPicture.ImageLocation = ""
        Me.BootPicture.Location = New System.Drawing.Point(3, 3)
        Me.BootPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.BootPicture.Name = "BootPicture"
        Me.BootPicture.Size = New System.Drawing.Size(320, 479)
        Me.BootPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BootPicture.TabIndex = 0
        Me.BootPicture.TabStop = False
        '
        'RecoveryLogo
        '
        Me.RecoveryLogo.BackColor = System.Drawing.Color.Black
        Me.RecoveryLogo.Controls.Add(Me.RecoveryPicture)
        Me.RecoveryLogo.Location = New System.Drawing.Point(4, 25)
        Me.RecoveryLogo.Name = "RecoveryLogo"
        Me.RecoveryLogo.Padding = New System.Windows.Forms.Padding(3)
        Me.RecoveryLogo.Size = New System.Drawing.Size(326, 485)
        Me.RecoveryLogo.TabIndex = 1
        Me.RecoveryLogo.Text = "Recovery Logo"
        '
        'RecoveryPicture
        '
        Me.RecoveryPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecoveryPicture.Location = New System.Drawing.Point(3, 3)
        Me.RecoveryPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.RecoveryPicture.Name = "RecoveryPicture"
        Me.RecoveryPicture.Size = New System.Drawing.Size(320, 479)
        Me.RecoveryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.RecoveryPicture.TabIndex = 0
        Me.RecoveryPicture.TabStop = False
        '
        'CustomBootCheck
        '
        Me.CustomBootCheck.AutoSize = True
        Me.CustomBootCheck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomBootCheck.ForeColor = System.Drawing.Color.White
        Me.CustomBootCheck.Location = New System.Drawing.Point(12, 108)
        Me.CustomBootCheck.Name = "CustomBootCheck"
        Me.CustomBootCheck.Size = New System.Drawing.Size(200, 26)
        Me.CustomBootCheck.TabIndex = 7
        Me.CustomBootCheck.Text = "Custom Boot Logo?"
        Me.CustomBootCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Custom Boot and Recovery Logos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 44)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "The area on the right represents your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "iPhone / iPod's screen"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CustomRecoveryLogoCheck
        '
        Me.CustomRecoveryLogoCheck.AutoSize = True
        Me.CustomRecoveryLogoCheck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomRecoveryLogoCheck.ForeColor = System.Drawing.Color.White
        Me.CustomRecoveryLogoCheck.Location = New System.Drawing.Point(12, 211)
        Me.CustomRecoveryLogoCheck.Name = "CustomRecoveryLogoCheck"
        Me.CustomRecoveryLogoCheck.Size = New System.Drawing.Size(241, 26)
        Me.CustomRecoveryLogoCheck.TabIndex = 10
        Me.CustomRecoveryLogoCheck.Text = "Custom Recovery Logo?"
        Me.CustomRecoveryLogoCheck.UseVisualStyleBackColor = True
        '
        'BrowseBoot
        '
        Me.BrowseBoot.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBoot.Location = New System.Drawing.Point(279, 108)
        Me.BrowseBoot.Name = "BrowseBoot"
        Me.BrowseBoot.Size = New System.Drawing.Size(103, 26)
        Me.BrowseBoot.TabIndex = 11
        Me.BrowseBoot.Text = "Browse"
        Me.BrowseBoot.UseVisualStyleBackColor = True
        '
        'BrowseRecovery
        '
        Me.BrowseRecovery.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseRecovery.Location = New System.Drawing.Point(279, 211)
        Me.BrowseRecovery.Name = "BrowseRecovery"
        Me.BrowseRecovery.Size = New System.Drawing.Size(103, 26)
        Me.BrowseRecovery.TabIndex = 12
        Me.BrowseRecovery.Text = "Browse"
        Me.BrowseRecovery.UseVisualStyleBackColor = True
        '
        'blackthund3rBootLogoCheck
        '
        Me.blackthund3rBootLogoCheck.AutoSize = True
        Me.blackthund3rBootLogoCheck.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blackthund3rBootLogoCheck.ForeColor = System.Drawing.Color.White
        Me.blackthund3rBootLogoCheck.Location = New System.Drawing.Point(27, 140)
        Me.blackthund3rBootLogoCheck.Name = "blackthund3rBootLogoCheck"
        Me.blackthund3rBootLogoCheck.Size = New System.Drawing.Size(200, 23)
        Me.blackthund3rBootLogoCheck.TabIndex = 13
        Me.blackthund3rBootLogoCheck.Text = "blackthund3r Boot Logo"
        Me.blackthund3rBootLogoCheck.UseVisualStyleBackColor = True
        '
        'blackthund3rRecoveryLogoCheck
        '
        Me.blackthund3rRecoveryLogoCheck.AutoSize = True
        Me.blackthund3rRecoveryLogoCheck.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blackthund3rRecoveryLogoCheck.ForeColor = System.Drawing.Color.White
        Me.blackthund3rRecoveryLogoCheck.Location = New System.Drawing.Point(27, 243)
        Me.blackthund3rRecoveryLogoCheck.Name = "blackthund3rRecoveryLogoCheck"
        Me.blackthund3rRecoveryLogoCheck.Size = New System.Drawing.Size(236, 23)
        Me.blackthund3rRecoveryLogoCheck.TabIndex = 14
        Me.blackthund3rRecoveryLogoCheck.Text = "blackthund3r Recovery Logo"
        Me.blackthund3rRecoveryLogoCheck.UseVisualStyleBackColor = True
        '
        'OpenBootLogo
        '
        Me.OpenBootLogo.Filter = "PNG Images| *.png"
        '
        'OpenRecoveryLogo
        '
        Me.OpenRecoveryLogo.Filter = "PNG Images|*.png"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.thund3rTool.My.Resources.Resources.Cancel
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NextButtonLogos
        '
        Me.NextButtonLogos.BackgroundImage = Global.thund3rTool.My.Resources.Resources._Next
        Me.NextButtonLogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NextButtonLogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButtonLogos.Location = New System.Drawing.Point(318, 436)
        Me.NextButtonLogos.Name = "NextButtonLogos"
        Me.NextButtonLogos.Size = New System.Drawing.Size(64, 64)
        Me.NextButtonLogos.TabIndex = 15
        Me.NextButtonLogos.UseVisualStyleBackColor = True
        '
        'CustomBootLogos05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NextButtonLogos)
        Me.Controls.Add(Me.blackthund3rRecoveryLogoCheck)
        Me.Controls.Add(Me.blackthund3rBootLogoCheck)
        Me.Controls.Add(Me.BrowseRecovery)
        Me.Controls.Add(Me.BrowseBoot)
        Me.Controls.Add(Me.CustomRecoveryLogoCheck)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomBootCheck)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CustomBootLogos05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Boot / Recovery Logos"
        Me.TabControl1.ResumeLayout(False)
        Me.BootLogo.ResumeLayout(False)
        CType(Me.BootPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecoveryLogo.ResumeLayout(False)
        CType(Me.RecoveryPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BootLogo As System.Windows.Forms.TabPage
    Friend WithEvents BootPicture As System.Windows.Forms.PictureBox
    Friend WithEvents RecoveryLogo As System.Windows.Forms.TabPage
    Friend WithEvents RecoveryPicture As System.Windows.Forms.PictureBox
    Friend WithEvents CustomBootCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomRecoveryLogoCheck As System.Windows.Forms.CheckBox
    Friend WithEvents BrowseBoot As System.Windows.Forms.Button
    Friend WithEvents BrowseRecovery As System.Windows.Forms.Button
    Friend WithEvents blackthund3rBootLogoCheck As System.Windows.Forms.CheckBox
    Friend WithEvents blackthund3rRecoveryLogoCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NextButtonLogos As System.Windows.Forms.Button
    Friend WithEvents OpenBootLogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenRecoveryLogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
