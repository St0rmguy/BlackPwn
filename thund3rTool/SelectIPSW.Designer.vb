<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectIPSW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectIPSW))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenIPSWDialogue = New System.Windows.Forms.OpenFileDialog()
        Me.NextArrowIPSW = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BrowseForIPSWButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(153, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select a not jailbroken IPSW!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BlackPwn supports at the moment iOS 4.2!!!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(158, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 72)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select IPSW"
        '
        'OpenIPSWDialogue
        '
        Me.OpenIPSWDialogue.FileName = ".ipsw"
        Me.OpenIPSWDialogue.Filter = "Apple IPSWs (*.ipsw)|*.ipsw"
        '
        'NextArrowIPSW
        '
        Me.NextArrowIPSW.BackgroundImage = Global.thund3rTool.My.Resources.Resources._Next
        Me.NextArrowIPSW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NextArrowIPSW.Enabled = False
        Me.NextArrowIPSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextArrowIPSW.Location = New System.Drawing.Point(658, 436)
        Me.NextArrowIPSW.Name = "NextArrowIPSW"
        Me.NextArrowIPSW.Size = New System.Drawing.Size(64, 64)
        Me.NextArrowIPSW.TabIndex = 5
        Me.NextArrowIPSW.UseVisualStyleBackColor = True
        Me.NextArrowIPSW.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.thund3rTool.My.Resources.Resources.Cancel
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BrowseForIPSWButton
        '
        Me.BrowseForIPSWButton.BackgroundImage = Global.thund3rTool.My.Resources.Resources.BrowseButton
        Me.BrowseForIPSWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrowseForIPSWButton.Location = New System.Drawing.Point(276, 251)
        Me.BrowseForIPSWButton.Name = "BrowseForIPSWButton"
        Me.BrowseForIPSWButton.Size = New System.Drawing.Size(128, 64)
        Me.BrowseForIPSWButton.TabIndex = 2
        Me.BrowseForIPSWButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BrowseForIPSWButton.UseVisualStyleBackColor = True
        '
        'SelectIPSW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.NextArrowIPSW)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BrowseForIPSWButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SelectIPSW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select an IPSW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BrowseForIPSWButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenIPSWDialogue As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NextArrowIPSW As System.Windows.Forms.Button
End Class
