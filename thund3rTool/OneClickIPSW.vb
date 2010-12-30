Option Explicit On
Imports IWshRuntimeLibrary
Imports System.IO
Public Class OneClickIPSW

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Clean As New WshShell
        Clean.Run("Cleanup.bat", vbHide, vbTrue)
        My.Settings.device = "N88AP"
        'Dim useram As Boolean
        ProgressBar.Visible = True
        'If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
        'useram = True
        'Else
        'useram = False
        'End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7938.20100908.F3rCk/iPhone2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "/makeIPSWDir/IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        wshThisShellIPSWExtract = New WshShell
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        strShellCommand = "ipsw.exe \makeIPSWDir\IPSW.ipsw \makeIPSWDir\Pwn_iPhone3GS.ipsw CustomPackages\Cydia.tar CustomPackages\Hacktivate.tar CustomPackages\Youtube.tar"
        'strShellCommand = "ipsw.exe /makeIPSWDir/IPSW.ipsw Pwn_iPhone3GS.ipsw CustomPackages/Cydia.tar CustomPackages/Hacktivate.tar CustomPackages/Youtube.tar"
        'If useram = True Then
        'strShellCommand = strShellCommand + " -memory"
        'End If
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        'ChDir(My.Application.Info.DirectoryPath)
        'Dim CleanShell As New WshShell
        'Dim CleanCommand As String
        'CleanCommand = "Cleanup.bat"
        'CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.device = "N82AP"
        Dim useram As Boolean
        ProgressBar.Visible = True
        If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
            useram = True
        Else
            useram = False
        End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7937.20100908.ghj4f/iPod2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\makeIPSWDir\IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        wshThisShellIPSWExtract = New WshShell
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        strShellCommand = "ipsw.exe \IPSW\IPSW.ipsw BlackPwn_iPhone3G.ipsw"
        If useram = True Then
            strShellCommand = strShellCommand + " -memory"
        End If
        strShellCommand = strShellCommand + " CustomPackages\Cydia.tar CustomPackages\Hacktivate.tar CustomPackages\Youtube.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
        Dim CleanShell As New WshShell
        Dim CleanCommand As String
        CleanCommand = "Cleanup.bat"
        CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.device = "N90AP"
        Dim useram As Boolean
        ProgressBar.Visible = True
        If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
            useram = True
        Else
            useram = False
        End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7937.20100908.ghj4f/iPod2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\makeIPSWDir\IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        wshThisShellIPSWExtract = New WshShell
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        strShellCommand = "ipsw.exe \IPSW\IPSW.ipsw BlackPwn_iPhone4.ipsw"
        If useram = True Then
            strShellCommand = strShellCommand + " -memory"
        End If
        strShellCommand = strShellCommand + " CustomPackages\Cydia.tar CustomPackages\Hacktivate.tar CustomPackages\Youtube.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
        Dim CleanShell As New WshShell
        Dim CleanCommand As String
        CleanCommand = "Cleanup.bat"
        CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Settings.device = "N72AP"
        Dim useram As Boolean
        ProgressBar.Visible = True
        If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
            useram = True
        Else
            useram = False
        End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7937.20100908.ghj4f/iPod2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\makeIPSWDir\IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        'Dim strBatchPathIPSWExtract As String
        wshThisShellIPSWExtract = New WshShell
        'strBatchPathIPSWExtract = "FindOutIPSW.bat"
        'the path for the batch file you're using
        'wshThisShellIPSWExtract.Run(strBatchPathIPSWExtract, vbHide, vbTrue)
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        'FileCopy(My.Settings.IPSWPath, "IPSW\" + My.Settings.IPSWFileName)
        strShellCommand = "ipsw.exe \IPSW\IPSW.ipsw BlackPwn_iPod2G.ipsw"
        'If My.Settings.CustomBootLogo = True Then
        'strShellCommand = strShellCommand + " -b bundles\bootLogo.png"
        'End If
        'If My.Settings.CustomRecoveryLogo = True Then
        'strShellCommand = strShellCommand + " -r bundles\recoveryLogo.png"
        'End If
        'If Not My.Settings.rootPartitionSize = 750 Then
        'strShellCommand = strShellCommand + " -s " + My.Settings.rootPartitionSize.ToString()
        'End If
        If useram = True Then
            strShellCommand = strShellCommand + " -memory"
        End If
        strShellCommand = strShellCommand + " CustomPackages\Cydia.tar CustomPackages\Hacktivate.tar CustomPackages\Youtube.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
        Dim CleanShell As New WshShell
        Dim CleanCommand As String
        CleanCommand = "Cleanup.bat"
        CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Welcome01.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Settings.device = "N18AP"
        Dim useram As Boolean
        ProgressBar.Visible = True
        If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
            useram = True
        Else
            useram = False
        End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7937.20100908.ghj4f/iPod2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\makeIPSWDir\IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        wshThisShellIPSWExtract = New WshShell
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        strShellCommand = "ipsw.exe \IPSW\IPSW.ipsw BlackPwn_iPod3G.ipsw"
        If useram = True Then
            strShellCommand = strShellCommand + " -memory"
        End If
        strShellCommand = strShellCommand + " CustomPackages\Cydia.tar CustomPackages\Hacktivate.tar CustomPackages\Youtube.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
        Dim CleanShell As New WshShell
        Dim CleanCommand As String
        CleanCommand = "Cleanup.bat"
        CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Settings.device = "N81AP"
        Dim useram As Boolean
        ProgressBar.Visible = True
        If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
            useram = True
        Else
            useram = False
        End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7937.20100908.ghj4f/iPod2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\makeIPSWDir\IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        wshThisShellIPSWExtract = New WshShell
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        strShellCommand = "ipsw.exe \IPSW\IPSW.ipsw BlackPwn_iPod4G.ipsw"
        If useram = True Then
            strShellCommand = strShellCommand + " -memory"
        End If
        strShellCommand = strShellCommand + " CustomPackages\Cydia.tar CustomPackages\Hacktivate.tar CustomPackages\Youtube.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
        Dim CleanShell As New WshShell
        Dim CleanCommand As String
        CleanCommand = "Cleanup.bat"
        CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        My.Settings.device = "K66AP"
        Dim useram As Boolean
        ProgressBar.Visible = True
        If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
            useram = True
        Else
            useram = False
        End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7937.20100908.ghj4f/iPod2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\makeIPSWDir\IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        wshThisShellIPSWExtract = New WshShell
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        strShellCommand = "ipsw.exe \IPSW\IPSW.ipsw BlackPwn_ATV2G.ipsw"
        If useram = True Then
            strShellCommand = strShellCommand + " -memory"
        End If
        strShellCommand = strShellCommand + " CustomPackages\CydiaATV.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
        Dim CleanShell As New WshShell
        Dim CleanCommand As String
        CleanCommand = "Cleanup.bat"
        CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        My.Settings.device = "K48AP"
        Dim useram As Boolean
        ProgressBar.Visible = True
        If My.Computer.Info.AvailablePhysicalMemory / 1000000 > 1100 Then
            useram = True
        Else
            useram = False
        End If
        ChDir(My.Application.Info.DirectoryPath)
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        My.Computer.Network.DownloadFile("http://appldnld.apple.com/iPhone4/061-7937.20100908.ghj4f/iPod2,1_4.1_8B117_Restore.ipsw", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\makeIPSWDir\IPSW.ipsw")
        Dim wshThisShellIPSWExtract As WshShell
        wshThisShellIPSWExtract = New WshShell
        Dim WshShell As New WshShell
        Dim strShellCommand As String
        strShellCommand = "ipsw.exe \IPSW\IPSW.ipsw BlackPwn_iPad.ipsw"
        If useram = True Then
            strShellCommand = strShellCommand + " -memory"
        End If
        strShellCommand = strShellCommand + " CustomPackages\Cydia.tar CustomPackages\Hacktivate.tar CustomPackages\Youtube.tar"
        WshShell.Run(strShellCommand, vbHide, vbTrue)
        ChDir(My.Application.Info.DirectoryPath)
        Dim CleanShell As New WshShell
        Dim CleanCommand As String
        CleanCommand = "Cleanup.bat"
        CleanShell.Run(CleanCommand, vbHide, vbTrue)
        OneBuild.Show()
        Me.Close()
    End Sub
End Class