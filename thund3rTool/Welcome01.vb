Imports IWshRuntimeLibrary
Public Class Welcome01

    Private Sub ForwardWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardWelcome.Click
        SelectIPSW.Show()
        Me.Close()
    End Sub

    Private Sub Welcome01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.CustomRecoveryLogo = False
        My.Settings.CustomBootLogo = False
        My.Settings.CustomBootLogoPath = ""
        My.Settings.CustomRecoveryLogoPath = ""
        My.Settings.device = ""
        My.Settings.Hacktivate = False
        My.Settings.rootPartitionSize = 750
        My.Settings.IPSWFileName = ""
        My.Settings.IPSWPath = ""
        Dim WshShell As New WshShell
        WshShell.Run("ultraclean.bat", vbHide, vbTrue)
    End Sub

    Private Sub DFUHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=bITIiGswjFI")
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://www.twitter.com/blackthund3r")
    End Sub

    Private Sub BlogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://www.blackthund3r.co.cc")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Credits.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OneClickIPSW.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Credits.Show()
    End Sub
End Class
