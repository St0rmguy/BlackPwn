Option Explicit On
Imports IWshRuntimeLibrary
Imports System.IO
Imports System.Security.Cryptography
Public Class SelectIPSW
    Public FilePath As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Welcome01.Show()
        Me.Close()
    End Sub

    Private Sub BrowseForIPSWButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseForIPSWButton.Click
        ChDir(My.Application.Info.DirectoryPath)
        Dim WshShell As New WshShell
        WshShell.Run("Cleanup.bat", vbHide, vbTrue)
        FilePath = OpenIPSWDialogue.ShowDialog().ToString()
        FilePath = OpenIPSWDialogue.FileName
        If Not Directory.Exists("makeIPSWDir") Then
            MkDir("makeIPSWDir")
        End If
        If FilePath.ToString() = "" Or FilePath.ToString() = ".ipsw" Then
            Exit Sub
        Else
            FileCopy(FilePath.ToString(), "makeIPSWDir\IPSW.ipsw")
            Dim wshThisShellIPSWExtract As WshShell
            Dim strBatchPathIPSWExtract As String
            wshThisShellIPSWExtract = New WshShell
            strBatchPathIPSWExtract = "FindOutIPSW.bat"
            'the path for the batch file you're using
            wshThisShellIPSWExtract.Run(strBatchPathIPSWExtract, vbHide, vbTrue)
            'Dim device As String
            ChDir(My.Application.Info.DirectoryPath)
            If Directory.Exists("IPSW\Firmware\all_flash.n82ap.production") Then
                My.Settings.device = "N82AP" 'iPhone 3G
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.n88ap.production") Then
                My.Settings.device = "N88AP" 'iPhone 3GS
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.n90ap.production") Then
                My.Settings.device = "N90AP" 'iPhone 3GS
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.n45ap.production") Then
                My.Settings.device = "N45AP" 'iPod Touch 1G
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.n72ap.production") Then
                My.Settings.device = "N72AP" 'iPod Touch 2G
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.n18ap.production") Then
                My.Settings.device = "N18AP" 'iPod Touch 3G
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.n81ap.production") Then
                My.Settings.device = "N81AP" 'iPod Touch 4G
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.k48ap.production") Then
                My.Settings.device = "K48AP" 'iPad
            End If
            If Directory.Exists("IPSW\Firmware\all_flash.n66ap.production") Then
                My.Settings.device = "K66AP" 'Apple TV 2G
            End If

            If My.Settings.device = Nothing Then
                MsgBox("Invalid IPSW, please try again or download the correct IPSW from www.felixbruns.de", vbExclamation + vbApplicationModal, "Error, please try again!")
                Exit Sub
            End If
            Select Case My.Settings.device
                Case "N72AP"
                    'Logic Here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "N88AP"
                    'logic here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "N18AP"
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "N45AP"
                    'Logic Here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "N82AP"
                    'logic here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "N90AP"
                    'logic here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "N81AP"
                    'logic here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "K48AP"
                    'logic here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case "K66AP"
                    'logic here
                    NextArrowIPSW.Enabled = True
                    NextArrowIPSW.Visible = True
                    Exit Select
                Case Else
                    MsgBox("You have supplied an invalid IPSW. Please select a new one or (re)download one from www.felixbruns.de/iPod/Firmware", vbExclamation + vbApplicationModal, "Invalid IPSW")
                    Exit Select
                    Exit Sub
            End Select
        End If
        My.Settings.IPSWPath = FilePath.ToString()
        My.Settings.IPSWFileName = OpenIPSWDialogue.SafeFileName
    End Sub
    Private Sub nextStep()
        Select Case My.Settings.device
            Case "N72AP"
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "N88AP"
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "N18AP"
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "N45AP"
                'Logic Here
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "N82AP"
                'logic here
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "N90AP"
                'logic here
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "N81AP"
                'logic here
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "K48AP"
                'logic here
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case "K66AP"
                'logic here
                NextArrowIPSW.Enabled = True
                NextArrowIPSW.Visible = True
                Exit Select
            Case Else
                MsgBox("You have supplied an invalid IPSW. Please select a new one or (re)download one from www.felixbruns.de/iPod/Firmware", vbExclamation + vbApplicationModal, "Invalid IPSW")
                Exit Select
                Exit Sub
        End Select
        My.Settings.IPSWPath = FilePath.ToString()
        My.Settings.IPSWFileName = OpenIPSWDialogue.SafeFileName
    End Sub

    Private Sub NextArrowIPSW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextArrowIPSW.Click
        SelectMode.Show()
        Me.Close()
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

    Private Sub SelectIPSW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class