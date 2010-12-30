Imports System.IO
Imports IWshRuntimeLibrary
Public Class SelectMode
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        Label1.Visible = True
        ProgressBar2.Visible = True
        My.Settings.CustomBootLogo = False
        My.Settings.CustomRecoveryLogo = False
        ChDir(My.Application.Info.DirectoryPath)
        If My.Settings.CustomBootLogo = True Then
            FileCopy(My.Settings.CustomBootLogoPath, "bundles\bootLogo.png")
        End If
        If My.Settings.CustomRecoveryLogo = True Then
            FileCopy(My.Settings.CustomRecoveryLogoPath, "bundles\recoveryLogo.png")
        End If
        If My.Settings.device = "N82AP" Then
            Hacktivate()
            MobileJailbreak()
            'type = "iPhone"
            'DeviceName = "iPhone3G"
        ElseIf My.Settings.device = "N88AP" Then
            Hacktivate()
            MobileJailbreak()
            'type = "iPhone"
            'DeviceName = "iPhone3GS"
        ElseIf My.Settings.device = "N90AP" Then
            Hacktivate()
            MobileJailbreak()
            'type = "iPhone"
            'DeviceName = "iPhone4"
        ElseIf My.Settings.device = "N72AP" Then
            MobileJailbreak()
            'type = "iPod"
            'DeviceName = "iPod2G"
        ElseIf My.Settings.device = "N45AP" Then
            MobileJailbreak()
            'type = "iPod"
            'DeviceName = "iPod3G"
        ElseIf My.Settings.device = "N45AP" Then
            MobileJailbreak()
            'type = "iPod"
            'DeviceName = "iPod4G"
        ElseIf My.Settings.device = "K48AP" Then
            MobileJailbreak()
            'type = "iPad"
            'DeviceName = "iPad"
        ElseIf My.Settings.device = "K66AP" Then
            ElseJailbreak()
            'type = "ATV"
            'DeviceName = "ATV2G"
        Else
            MsgBox("Error! Please try again!", vbQuestion + vbApplicationModal, "Sorry!")
            Exit Sub
        End If
        Label1.Text = "Moving IPSW..."
        FileCopy("makeIPSWDir\" + My.Settings.device + "_Custom_Pwned_Restore.ipsw", My.Computer.FileSystem.SpecialDirectories.Desktop + "\" + "BlackPwn_" + My.Settings.device + "_Custom_Restore.ipsw")
        Label1.Text = "Cleaning Up..."
        ultraclean()
        Label1.Text = "Done!"
        frmComplete.Show()
        Me.Close()
    End Sub

    Private Sub Hacktivate()
        Dim Answer
        Answer = MsgBox("Do you want to activate your iPhone?", MsgBoxStyle.YesNo, "Hacktivate?")
        If Answer = vbYes Then My.Settings.Hacktivate = True
    End Sub

    Private Sub MobileJailbreak()
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        clean()
        MkDir("makeIPSWDir")
        FileCopy(My.Settings.IPSWPath, "makeIPSWDir\" + My.Settings.IPSWFileName)
        strShellCommand = "ipsw.exe makeIPSWDir\" + My.Settings.IPSWFileName + " " + "makeIPSWDir\" + My.Settings.device + "_Custom_Pwned_Restore.ipsw"
        If Not My.Settings.rootPartitionSize = 750 Then
            strShellCommand = strShellCommand + " -s " + My.Settings.rootPartitionSize.ToString()
        End If
        If My.Settings.Hacktivate = False Then
            strShellCommand = strShellCommand + " -e " + Chr(34) + "Phone Activation" + Chr(34)
        Else
            strShellCommand = strShellCommand + " CustomPackages\Youtube.tar CustomPackages\Hacktivate.tar"
        End If
        strShellCommand = strShellCommand + " CustomPackages\Cydia.tar"
        'strShellCommand = "ipse.exe makeIPSWDir\" + My.Settings.IPSWFileName + " makeIPSWDir\BlackPwn_" + My.Settings.device + "_Custom_Restore.ipsw CustomPackages\Youtube.tar CustomPackages\Hacktivate.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
    End Sub

    Private Sub ElseJailbreak()
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        clean()
        MkDir("makeIPSWDir")
        FileCopy(My.Settings.IPSWPath, "makeIPSWDir\" + My.Settings.IPSWFileName)
        strShellCommand = "ipsw.exe makeIPSWDir\" + My.Settings.IPSWFileName + " " + "makeIPSWDir\" + My.Settings.device + "_Custom_Pwned_Restore.ipsw"
        If Not My.Settings.rootPartitionSize = 750 Then
            strShellCommand = strShellCommand + " -s " + My.Settings.rootPartitionSize.ToString()
        End If
        strShellCommand = strShellCommand + " CustomPackages\CydiaATV.tar"
        'strShellCommand = "ipse.exe makeIPSWDir\" + My.Settings.IPSWFileName + " makeIPSWDir\BlackPwn_" + My.Settings.device + "_Custom_Restore.ipsw CustomPackages\Youtube.tar CustomPackages\Hacktivate.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
    End Sub

    Private Sub clean()
        Dim WshShellClean As New WshShell
        Dim strShellCommandClean As String
        strShellCommandClean = "Cleanup.bat"
        WshShellClean.Run(strShellCommandClean, vbHide, vbTrue)
    End Sub
    Private Sub ultraclean()
        Dim WshShellUltraClean As New WshShell
        Dim strShellCommandUltraClean As String
        strShellCommandUltraClean = "ultraclean.bat"
        WshShellUltraClean.Run(strShellCommandUltraClean, vbHide, vbTrue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ChooseOptions.Show()
        Me.Close()
    End Sub

    Private Sub ProgressBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim KillIPSW As New WshShell
        Dim KillIPSWCommand As String
        KillIPSWCommand = "kill.bat"
        KillIPSW.Run(KillIPSWCommand, vbHide, vbTrue)
        clean()
    End Sub
End Class