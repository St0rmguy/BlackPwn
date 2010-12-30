<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iPodOptionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iPodOptionsForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IPSWmods = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextRoot = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PartitionsizeBar = New System.Windows.Forms.TrackBar()
        Me.WutisNOR = New System.Windows.Forms.LinkLabel()
        Me.NOROnlyCheckBox = New System.Windows.Forms.CheckBox()
        Me.chkInstallSSH = New System.Windows.Forms.CheckBox()
        Me.SBMods = New System.Windows.Forms.GroupBox()
        Me.chkWallpaper = New System.Windows.Forms.CheckBox()
        Me.chkBatPercent = New System.Windows.Forms.CheckBox()
        Me.ChkNativeTask = New System.Windows.Forms.CheckBox()
        Me.IPSWmods.SuspendLayout()
        CType(Me.PartitionsizeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SBMods.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(175, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Options for your iPod"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.thund3rTool.My.Resources.Resources._Next
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(658, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IPSWmods
        '
        Me.IPSWmods.BackColor = System.Drawing.Color.Black
        Me.IPSWmods.Controls.Add(Me.Label7)
        Me.IPSWmods.Controls.Add(Me.TextRoot)
        Me.IPSWmods.Controls.Add(Me.Label8)
        Me.IPSWmods.Controls.Add(Me.PartitionsizeBar)
        Me.IPSWmods.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPSWmods.ForeColor = System.Drawing.Color.White
        Me.IPSWmods.Location = New System.Drawing.Point(52, 274)
        Me.IPSWmods.Name = "IPSWmods"
        Me.IPSWmods.Size = New System.Drawing.Size(622, 150)
        Me.IPSWmods.TabIndex = 119
        Me.IPSWmods.TabStop = False
        Me.IPSWmods.Text = "Root Partiton Options"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(239, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Root Partition Size"
        '
        'TextRoot
        '
        Me.TextRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRoot.Location = New System.Drawing.Point(291, 58)
        Me.TextRoot.MaxLength = 4
        Me.TextRoot.Name = "TextRoot"
        Me.TextRoot.Size = New System.Drawing.Size(31, 20)
        Me.TextRoot.TabIndex = 43
        Me.TextRoot.Text = "800"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(328, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 18)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "MB"
        '
        'PartitionsizeBar
        '
        Me.PartitionsizeBar.Location = New System.Drawing.Point(17, 84)
        Me.PartitionsizeBar.Maximum = 7000
        Me.PartitionsizeBar.Minimum = 800
        Me.PartitionsizeBar.Name = "PartitionsizeBar"
        Me.PartitionsizeBar.Size = New System.Drawing.Size(584, 45)
        Me.PartitionsizeBar.TabIndex = 1
        Me.PartitionsizeBar.TabStop = False
        Me.PartitionsizeBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.PartitionsizeBar.Value = 800
        '
        'WutisNOR
        '
        Me.WutisNOR.AutoSize = True
        Me.WutisNOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WutisNOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WutisNOR.LinkColor = System.Drawing.Color.Cyan
        Me.WutisNOR.Location = New System.Drawing.Point(380, 251)
        Me.WutisNOR.Name = "WutisNOR"
        Me.WutisNOR.Size = New System.Drawing.Size(140, 13)
        Me.WutisNOR.TabIndex = 0
        Me.WutisNOR.TabStop = True
        Me.WutisNOR.Text = "-- What is NOR-Only IPSW?"
        '
        'NOROnlyCheckBox
        '
        Me.NOROnlyCheckBox.AutoSize = True
        Me.NOROnlyCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOROnlyCheckBox.ForeColor = System.Drawing.Color.White
        Me.NOROnlyCheckBox.Location = New System.Drawing.Point(181, 248)
        Me.NOROnlyCheckBox.Name = "NOROnlyCheckBox"
        Me.NOROnlyCheckBox.Size = New System.Drawing.Size(193, 20)
        Me.NOROnlyCheckBox.TabIndex = 105
        Me.NOROnlyCheckBox.TabStop = False
        Me.NOROnlyCheckBox.Text = "Make a NOR-Only IPSW"
        Me.NOROnlyCheckBox.UseVisualStyleBackColor = True
        '
        'chkInstallSSH
        '
        Me.chkInstallSSH.AutoSize = True
        Me.chkInstallSSH.BackColor = System.Drawing.Color.Transparent
        Me.chkInstallSSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkInstallSSH.ForeColor = System.Drawing.Color.White
        Me.chkInstallSSH.Location = New System.Drawing.Point(6, 99)
        Me.chkInstallSSH.Name = "chkInstallSSH"
        Me.chkInstallSSH.Size = New System.Drawing.Size(103, 20)
        Me.chkInstallSSH.TabIndex = 112
        Me.chkInstallSSH.TabStop = False
        Me.chkInstallSSH.Text = "Install SSH"
        Me.chkInstallSSH.UseVisualStyleBackColor = False
        '
        'SBMods
        '
        Me.SBMods.BackColor = System.Drawing.Color.Black
        Me.SBMods.Controls.Add(Me.chkInstallSSH)
        Me.SBMods.Controls.Add(Me.chkWallpaper)
        Me.SBMods.Controls.Add(Me.chkBatPercent)
        Me.SBMods.Controls.Add(Me.ChkNativeTask)
        Me.SBMods.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBMods.ForeColor = System.Drawing.Color.White
        Me.SBMods.Location = New System.Drawing.Point(204, 105)
        Me.SBMods.Name = "SBMods"
        Me.SBMods.Size = New System.Drawing.Size(300, 125)
        Me.SBMods.TabIndex = 117
        Me.SBMods.TabStop = False
        Me.SBMods.Text = "SpringBoard or other Modifications"
        '
        'chkWallpaper
        '
        Me.chkWallpaper.AutoSize = True
        Me.chkWallpaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWallpaper.ForeColor = System.Drawing.Color.White
        Me.chkWallpaper.Location = New System.Drawing.Point(6, 23)
        Me.chkWallpaper.Name = "chkWallpaper"
        Me.chkWallpaper.Size = New System.Drawing.Size(239, 20)
        Me.chkWallpaper.TabIndex = 108
        Me.chkWallpaper.TabStop = False
        Me.chkWallpaper.Text = "Enable Background Wallpaper"
        Me.chkWallpaper.UseVisualStyleBackColor = True
        '
        'chkBatPercent
        '
        Me.chkBatPercent.AutoSize = True
        Me.chkBatPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBatPercent.ForeColor = System.Drawing.Color.White
        Me.chkBatPercent.Location = New System.Drawing.Point(6, 49)
        Me.chkBatPercent.Name = "chkBatPercent"
        Me.chkBatPercent.Size = New System.Drawing.Size(214, 20)
        Me.chkBatPercent.TabIndex = 107
        Me.chkBatPercent.TabStop = False
        Me.chkBatPercent.Text = "Enable Battery-Percentage"
        Me.chkBatPercent.UseVisualStyleBackColor = True
        '
        'ChkNativeTask
        '
        Me.ChkNativeTask.AutoSize = True
        Me.ChkNativeTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNativeTask.ForeColor = System.Drawing.Color.White
        Me.ChkNativeTask.Location = New System.Drawing.Point(6, 75)
        Me.ChkNativeTask.Name = "ChkNativeTask"
        Me.ChkNativeTask.Size = New System.Drawing.Size(211, 20)
        Me.ChkNativeTask.TabIndex = 106
        Me.ChkNativeTask.TabStop = False
        Me.ChkNativeTask.Text = "Enable Native Multitasking"
        Me.ChkNativeTask.UseVisualStyleBackColor = True
        '
        'iPodOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.IPSWmods)
        Me.Controls.Add(Me.WutisNOR)
        Me.Controls.Add(Me.NOROnlyCheckBox)
        Me.Controls.Add(Me.SBMods)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "iPodOptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.IPSWmods.ResumeLayout(False)
        Me.IPSWmods.PerformLayout()
        CType(Me.PartitionsizeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SBMods.ResumeLayout(False)
        Me.SBMods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IPSWmods As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WutisNOR As System.Windows.Forms.LinkLabel
    Friend WithEvents NOROnlyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextRoot As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PartitionsizeBar As System.Windows.Forms.TrackBar
    Friend WithEvents chkInstallSSH As System.Windows.Forms.CheckBox
    Friend WithEvents SBMods As System.Windows.Forms.GroupBox
    Friend WithEvents chkWallpaper As System.Windows.Forms.CheckBox
    Friend WithEvents chkBatPercent As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNativeTask As System.Windows.Forms.CheckBox
End Class
