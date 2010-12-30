Imports System.IO
Imports IWshRuntimeLibrary
Public Class ReadyToBuild06

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar.Visible = True
        If My.Settings.NOROnlyIPSW = False Then

            Button2.Hide()
            Button2.Enabled = False
            Button1.Enabled = False
            Button1.Text = "Working... This may take a while. Please wait"
            ChDir(My.Application.Info.DirectoryPath)
            If My.Settings.CustomBootLogo = True Then
                FileCopy(My.Settings.CustomBootLogoPath, "bundles\bootLogo.png")
            End If
            If My.Settings.CustomRecoveryLogo = True Then
                FileCopy(My.Settings.CustomRecoveryLogoPath, "bundles\recoveryLogo.png")
            End If
            Dim type As String
            Dim DeviceName As String
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
            If type = "Error!" Then
                MsgBox("Error! Please try again!", vbQuestion + vbApplicationModal, "Sorry!")
                Exit Sub
            End If
            If type = "iPod2G" Then
                Dim WshShell As New WshShell
                Dim strShellCommand As String
                clean()
                MkDir("makeIPSWDir")
                FileCopy(My.Settings.IPSWPath, "makeIPSWDir\" + My.Settings.IPSWFileName)
                strShellCommand = "ipsw.exe makeIPSWDir\" + My.Settings.IPSWFileName + " " + "makeIPSWDir\" + My.Settings.device + "_Custom_Pwned_Restore.ipsw"
                If My.Settings.CustomBootLogo = True Then
                    strShellCommand = strShellCommand + " -b bundles\bootLogo.png"
                End If
                If My.Settings.CustomRecoveryLogo = True Then
                    strShellCommand = strShellCommand + " -r bundles\recoveryLogo.png"
                End If
                If Not My.Settings.rootPartitionSize = 750 Then
                    strShellCommand = strShellCommand + " -s " + My.Settings.rootPartitionSize.ToString()
                End If
                strShellCommand = strShellCommand + " CustomPackages\Cydia.tar"
                WshShell.Run(strShellCommand, vbHide, vbTrue)
                ChDir(My.Application.Info.DirectoryPath)
            End If
            If type = "NewiPod" Then
                Dim WshShell As New WshShell
                Dim strShellCommand As String
                clean()
                MkDir("makeIPSWDir")
                FileCopy(My.Settings.IPSWPath, "makeIPSWDir\" + My.Settings.IPSWFileName)
                strShellCommand = "ipsw.exe makeIPSWDir\" + My.Settings.IPSWFileName + " " + "makeIPSWDir\" + My.Settings.device + "_Custom_Pwned_Restore.ipsw"
                If Not My.Settings.rootPartitionSize = 750 Then
                    strShellCommand = strShellCommand + " -s " + My.Settings.rootPartitionSize.ToString()
                End If
                strShellCommand = strShellCommand + " CustomPackages\Cydia.tar"
                WshShell.Run(strShellCommand, vbHide, vbTrue)
                ChDir(My.Application.Info.DirectoryPath)
            End If
            If type = "iPhone3G" Then
                Dim WshShell As New WshShell
                Dim strShellCommand As String
                clean()
                MkDir("makeIPSWDir")
                FileCopy(My.Settings.IPSWPath, "makeIPSWDir\" + My.Settings.IPSWFileName)
                strShellCommand = "ipsw.exe makeIPSWDir\" + My.Settings.IPSWFileName + " " + "makeIPSWDir\" + My.Settings.device + "_Custom_Pwned_Restore.ipsw"
                If My.Settings.CustomBootLogo = True Then
                    strShellCommand = strShellCommand + " -b bundles\bootLogo.png"
                End If
                If My.Settings.CustomRecoveryLogo = True Then
                    strShellCommand = strShellCommand + " -r bundles\recoveryLogo.png"
                End If
                If Not My.Settings.rootPartitionSize = 750 Then
                    strShellCommand = strShellCommand + " -s " + My.Settings.rootPartitionSize.ToString()
                End If
                If My.Settings.Hacktivate = False Then
                    strShellCommand = strShellCommand + " -e " + Chr(34) + "Phone Activation" + Chr(34)
                Else
                    strShellCommand = strShellCommand + " CustomPackages\Youtube.tar CustomPackages\Hacktivate.tar"
                End If
                strShellCommand = strShellCommand + " CustomPackages\Cydia.tar"
                WshShell.Run(strShellCommand, vbHide, vbTrue)
                ChDir(My.Application.Info.DirectoryPath)
            End If
            If type = "NewiPhone" Then
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
                WshShell.Run(strShellCommand, vbHide, vbTrue)
                ChDir(My.Application.Info.DirectoryPath)
            End If
            Button1.Text = "Moving IPSW..."
            FileCopy("makeIPSWDir\" + My.Settings.device + "_Custom_Pwned_Restore.ipsw", My.Computer.FileSystem.SpecialDirectories.Desktop + "\" + "thund3rTool_" + My.Settings.device + "_Custom_Restore.ipsw")
            Button1.Text = "Cleaning Up..."
            ultraclean()
            Button1.Text = "Done!"
            frmComplete.Show()
            Me.Close()
        Else
            Dim WshShell As New WshShell
            Dim strShellCommand As String
            strShellCommand = "ipsw.exe IPSW\" + My.Settings.IPSWFileName + " " + "BlackPwn" + My.Settings.device + "_NOR_Only.ipsw"
            If My.Settings.CustomBootLogo = True Then
                FileCopy(My.Settings.CustomBootLogoPath.ToString(), "bundles\bootLogo.png")
                strShellCommand = strShellCommand + " -b bundles\bootLogo.png"
            End If
            If My.Settings.CustomRecoveryLogo = True Then
                FileCopy(My.Settings.CustomRecoveryLogoPath.ToString(), "bundles\recoveryLogo.png")
                strShellCommand = strShellCommand + " -r bundles\recoveryLogo.png"
            End If
            strShellCommand = strShellCommand + " -nowipe"
            WshShell.Run(strShellCommand, vbHide, vbTrue)

        End If
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
        CustomBootLogos05.Show()
        Me.Close()
    End Sub

    Private Sub ReadyToBuild06_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Show()
        Button2.Enabled = True
        Button1.Enabled = True
        Button1.Text = "Start"
    End Sub

End Class