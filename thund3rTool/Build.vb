Imports System.IO
Imports IWshRuntimeLibrary
Public Class Build
    Private Sub makeTheSt0rm(ByVal State As Object)
        'ProgressBar.Visible = True
        'Button1.Text = "Working... This may take a while. Please wait"
        Label2.Text = "Working.. Please wait till done!"
        ChDir(My.Application.Info.DirectoryPath)
        If My.Settings.CustomBootLogo = True Then
            FileCopy(My.Settings.CustomBootLogoPath, "bundles\bootLogo.png")
        End If
        If My.Settings.CustomRecoveryLogo = True Then
            FileCopy(My.Settings.CustomRecoveryLogoPath, "bundles\recoveryLogo.png")
        End If
        Dim type As String
        Dim DeviceName As String
        Dim device As String
        If My.Settings.device = "N82AP" Then
            type = "iPhone3G"
            DeviceName = "iPhone3G"
            'ElseIf My.Settings.device = "N88AP" Then
            '   type = "iPhone3GS"
            'ElseIf My.Settings.device = "N90AP" Then
            '    type = "iPhone4"
        ElseIf My.Settings.device = "N88AP" Then
            type = "NewiPhone"
            DeviceName = "iPhone3GS"
        ElseIf My.Settings.device = "N90AP" Then
            type = "NewiPhone"
            DeviceName = "iPhone4"
        ElseIf My.Settings.device = "N72AP" Then
            type = "NewiPod"
            DeviceName = "iPod2G"
            ' ElseIf My.Settings.device = "N45AP" Then
            'type = "iPod3G"
            'ElseIf My.Settings.device = "N45AP" Then
            '   type = "iPod4G"
        ElseIf My.Settings.device = "N45AP" Then
            type = "NewiPod"
            DeviceName = "iPod3G"
        ElseIf My.Settings.device = "N45AP" Then
            type = "NewiPod"
            DeviceName = "iPod4G"
        Else
            type = "Error!"
        End If
        If My.Settings.device = "N82AP" Or My.Settings.device = "N88AP" Or My.Settings.device = "N90AP" Or My.Settings.device = "N72AP" Or My.Settings.device = "N18AP" Or My.Settings.device = "N81AP" Or My.Settings.device = "K48AP" Then
            type = "MobileDevice"
        ElseIf My.Settings.device = "N82AP" Or My.Settings.device = "N88AP" Or My.Settings.device = "N90AP" Then
            device = "iPhone"
        ElseIf My.Settings.device = "K66AP" Then
            type = "ATV"
        End If
        If type = "Error!" Then
            MsgBox("Error! Please try again!", vbQuestion + vbApplicationModal, "Sorry!")
            Exit Sub
        End If
        If device = "iPhone" Then
            Dim Answer
            Answer = MsgBox("Do you want to activate your iPhone?", MsgBoxStyle.YesNo, "You wantz Hacktivation?")
            If Answer = vbYes Then My.Settings.Hacktivate = True
        End If
        If type = "MobileDevice" Then
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
        End If

    End Sub

    Private Sub clean()
        Dim WshShellClean As New WshShell
        Dim strShellCommandClean As String
        strShellCommandClean = "Cleanup.bat"
        WshShellClean.Run(strShellCommandClean, vbHide, vbTrue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim KillIPSW As New WshShell
        Dim KillIPSWCommand As String
        KillIPSWCommand = "kill.bat"
        KillIPSW.Run(KillIPSWCommand, vbHide, vbTrue)
        clean()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class