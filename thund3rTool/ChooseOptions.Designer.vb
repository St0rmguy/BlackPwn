<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseOptions
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
        Me.GeneralButton = New System.Windows.Forms.Button()
        Me.UnlockButton = New System.Windows.Forms.Button()
        Me.BuildIPSWButton = New System.Windows.Forms.Button()
        Me.PackagesButton = New System.Windows.Forms.Button()
        Me.LogoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GeneralButton
        '
        Me.GeneralButton.Location = New System.Drawing.Point(107, 238)
        Me.GeneralButton.Name = "GeneralButton"
        Me.GeneralButton.Size = New System.Drawing.Size(215, 45)
        Me.GeneralButton.TabIndex = 0
        Me.GeneralButton.Text = "General"
        Me.GeneralButton.UseVisualStyleBackColor = True
        '
        'UnlockButton
        '
        Me.UnlockButton.Location = New System.Drawing.Point(107, 336)
        Me.UnlockButton.Name = "UnlockButton"
        Me.UnlockButton.Size = New System.Drawing.Size(215, 45)
        Me.UnlockButton.TabIndex = 1
        Me.UnlockButton.Text = "Unlock"
        Me.UnlockButton.UseVisualStyleBackColor = True
        '
        'BuildIPSWButton
        '
        Me.BuildIPSWButton.Location = New System.Drawing.Point(239, 425)
        Me.BuildIPSWButton.Name = "BuildIPSWButton"
        Me.BuildIPSWButton.Size = New System.Drawing.Size(215, 45)
        Me.BuildIPSWButton.TabIndex = 2
        Me.BuildIPSWButton.Text = "Build IPSW"
        Me.BuildIPSWButton.UseVisualStyleBackColor = True
        '
        'PackagesButton
        '
        Me.PackagesButton.Location = New System.Drawing.Point(368, 336)
        Me.PackagesButton.Name = "PackagesButton"
        Me.PackagesButton.Size = New System.Drawing.Size(215, 45)
        Me.PackagesButton.TabIndex = 3
        Me.PackagesButton.Text = "Packages Manager"
        Me.PackagesButton.UseVisualStyleBackColor = True
        '
        'LogoButton
        '
        Me.LogoButton.Location = New System.Drawing.Point(368, 238)
        Me.LogoButton.Name = "LogoButton"
        Me.LogoButton.Size = New System.Drawing.Size(215, 45)
        Me.LogoButton.TabIndex = 4
        Me.LogoButton.Text = "Custom Boot Logos"
        Me.LogoButton.UseVisualStyleBackColor = True
        '
        'ChooseOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.LogoButton)
        Me.Controls.Add(Me.PackagesButton)
        Me.Controls.Add(Me.BuildIPSWButton)
        Me.Controls.Add(Me.UnlockButton)
        Me.Controls.Add(Me.GeneralButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ChooseOptions"
        Me.Text = "Choose your options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GeneralButton As System.Windows.Forms.Button
    Friend WithEvents UnlockButton As System.Windows.Forms.Button
    Friend WithEvents BuildIPSWButton As System.Windows.Forms.Button
    Friend WithEvents PackagesButton As System.Windows.Forms.Button
    Friend WithEvents LogoButton As System.Windows.Forms.Button
End Class
