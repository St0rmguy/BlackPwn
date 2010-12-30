Imports FreeImageAPI
Imports System.Runtime.InteropServices
Imports System.Text
Imports IWshRuntimeLibrary
Public Class CustomBootLogos05

    Private Sub CustomBootLogos05_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CustomBootLogo = True Then
            CustomBootCheck.Checked = True
            BootPicture.ImageLocation = My.Settings.CustomBootLogoPath
            If My.Settings.CustomBootLogoPath = "thund3rBoot.png" Then
                blackthund3rBootLogoCheck.Checked = True
            Else
                blackthund3rBootLogoCheck.Checked = False
            End If
        Else
            CustomBootCheck.Checked = False
            BootPicture.ImageLocation = "Blank.png"
        End If
        If My.Settings.CustomRecoveryLogo = True Then
            CustomRecoveryLogoCheck.Checked = True
            RecoveryPicture.ImageLocation = My.Settings.CustomRecoveryLogoPath
            If My.Settings.CustomRecoveryLogoPath = "thund3rRecovery.png" Then
                blackthund3rRecoveryLogoCheck.Checked = True
            Else
                blackthund3rRecoveryLogoCheck.Checked = False
            End If
        Else
            CustomRecoveryLogoCheck.Checked = False
            RecoveryPicture.ImageLocation = "Blank.png"
        End If
    End Sub
    Public BootLogoPath As String
    Public RecoveryLogoPath As String
    Private Sub NextButtonLogos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButtonLogos.Click
        If CustomBootCheck.Checked = True Or CustomRecoveryLogoCheck.Checked = True Then
            If CustomBootCheck.Checked = True Then
                My.Settings.CustomBootLogo = True
                'My.Settings.CustomBootLogoPath = BootLogoPath.ToString()
            Else
                My.Settings.CustomBootLogo = False
                'My.Settings.CustomBootLogoPath = ""
            End If
            If CustomRecoveryLogoCheck.Checked = True Then
                My.Settings.CustomRecoveryLogo = True
                'My.Settings.CustomRecoveryLogoPath = RecoveryLogoPath.ToString()
            Else
                My.Settings.CustomRecoveryLogo = False
                My.Settings.CustomRecoveryLogoPath = ""
            End If
        End If
        ReadyToBuild06.Show()
        Me.Close()
    End Sub

    Private Sub BrowseBoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseBoot.Click
        OpenBootLogo.ShowDialog()
        BootLogoPath = OpenBootLogo.FileName
        Dim InfoReader As System.IO.FileInfo
        If BootLogoPath Is "" Then
            Exit Sub
        Else
            InfoReader = My.Computer.FileSystem.GetFileInfo(BootLogoPath.ToString())
            If InfoReader.Length / 1024 <= 100 Then
                Dim bootlogoimage As System.Drawing.Image = System.Drawing.Image.FromFile(BootLogoPath.ToString())
                If bootlogoimage.Width <= 320 And bootlogoimage.Height <= 480 Then
                    'MsgBox("Right Size")
                    Dim FreeLogo = FreeImageAPI.FreeImage.Load(FREE_IMAGE_FORMAT.FIF_PNG, BootLogoPath, FREE_IMAGE_LOAD_FLAGS.DEFAULT)
                    Dim FreeTrans = FreeImageAPI.FreeImage.IsTransparent(FreeLogo)
                    If FreeTrans.ToString() = False Then
                        MsgBox("This image has no transparency. Please choose one that has at least one transparent pixel", vbCritical + vbOKOnly, "Transparency Needed!")
                    Else
                        BootPicture.Load(BootLogoPath)
                        'MsgBox(" imagetool code here ")
                    End If

                Else
                    MsgBox("The dimensions are too large. The PNG must be smaller than or equal to 320px by 480px", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Wrong Dimensions")
                End If
            Else
                MsgBox("The selected file is too large. The image must be below 100kb in size", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Too Large")
            End If
        End If
    End Sub

    Private Sub BrowseRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseRecovery.Click
        OpenRecoveryLogo.ShowDialog()
        RecoveryLogoPath = OpenRecoveryLogo.FileName
        ' MsgBox(RecoveryLogoPath.ToString())
        If RecoveryLogoPath Is "" Then
            Exit Sub
        Else
            Dim InfoReaderR As System.IO.FileInfo
            InfoReaderR = My.Computer.FileSystem.GetFileInfo(RecoveryLogoPath.ToString())
            If InfoReaderR.Length / 1024 <= 100 Then
                Dim recoverylogoimage As System.Drawing.Image = System.Drawing.Image.FromFile(RecoveryLogoPath.ToString())
                If recoverylogoimage.Width <= 320 And recoverylogoimage.Height <= 480 Then
                    Dim FreeLogoR = FreeImageAPI.FreeImage.Load(FREE_IMAGE_FORMAT.FIF_PNG, RecoveryLogoPath, FREE_IMAGE_LOAD_FLAGS.DEFAULT)
                    Dim FreeTransR = FreeImageAPI.FreeImage.IsTransparent(FreeLogoR)
                    If FreeTransR.ToString() = False Then
                        MsgBox("This image has no transparency. Please choose one that has at least one transparent pixel", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Transparency Needed!")
                    Else
                        RecoveryPicture.Load(RecoveryLogoPath)
                        'MsgBox(" imagetool code here ")
                    End If

                Else
                    MsgBox("The dimensions are too large. The PNG must be smaller than or equal to 320px by 480px", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Wrong Dimensions")
                End If
            Else
                MsgBox("The selected file is too large. The image must be below 100kb in size", vbExclamation + vbOKOnly, "Too Large")
            End If
        End If
    End Sub

    Private Sub CustomBootCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomBootCheck.CheckedChanged
        If CustomBootCheck.Checked = True Then
            BrowseBoot.Enabled = True
            blackthund3rBootLogoCheck.Enabled = True
        Else
            BrowseBoot.Enabled = False
            blackthund3rBootLogoCheck.Enabled = False
            BootPicture.ImageLocation = "Blank.png"
        End If
    End Sub

    Private Sub CustomRecoveryLogoCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomRecoveryLogoCheck.CheckedChanged
        If CustomRecoveryLogoCheck.Checked = True Then
            BrowseRecovery.Enabled = True
            blackthund3rRecoveryLogoCheck.Enabled = True
        Else
            BrowseRecovery.Enabled = False
            blackthund3rRecoveryLogoCheck.Enabled = False
            RecoveryPicture.ImageLocation = "Blank.png"
        End If
    End Sub

    Private Sub blackthund3rBootLogoCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blackthund3rBootLogoCheck.CheckedChanged
        If blackthund3rBootLogoCheck.Checked = True Then
            BootPicture.Load("thund3rBoot.png")
            My.Settings.CustomBootLogoPath = "thund3rBoot.png"
        End If
    End Sub

    Private Sub blackthund3rRecoveryLogoCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blackthund3rRecoveryLogoCheck.CheckedChanged
        If blackthund3rRecoveryLogoCheck.Checked = True Then
            RecoveryPicture.Load("thund3rRecovery.png")
            My.Settings.CustomRecoveryLogoPath = "thund3rRecovery.png"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Settings.NOROnlyIPSW = True Then
            Select Case My.Settings.device
                Case "N88AP"
                    iPhoneOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "N82AP"
                    iPhoneOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "N72AP"
                    iPodOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "N18AP"
                    iPodOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "N45AP"
                    iPodOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "N90AP"
                    iPodOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "N81AP"
                    iPodOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "K48AP"
                    iPodOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case "N66AP"
                    iPodOptionsForm.Show()
                    Me.Close()
                    Exit Select
                Case Else
                    MsgBox("Please Select an IPSW", vbApplicationModal + vbExclamation, "IPSW")
                    Exit Select
            End Select
        Else
            PackageManagersForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class