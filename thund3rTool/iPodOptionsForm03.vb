Public Class iPodOptionsForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If NOROnlyCheckBox.Checked = True Then
            My.Settings.NOROnlyIPSW = True
            My.Settings.rootPartitionSize = 750
            CustomBootLogos05.Show()
            Me.Close()
        Else
            My.Settings.NOROnlyIPSW = False
            'My.Settings.rootPartitionSize = NumericUpDown1.Value
            PackageManagersForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SelectIPSW.Show()
        Me.Close()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Settings.rootPartitionSize = NumericUpDown1.Value
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MsgBox("A NOR Only IPSW is one that does not actually restore the firmware, but it allows you to change your boot and recovery logos without iTunes Wiping any user data. Only logos can be changed in this mode and your device must already be jailbroken.", vbInformation + vbApplicationModal, "NOR only IPSW")
    End Sub

    Private Sub iPodOptionsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub chkNOR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOROnlyCheckBox.CheckedChanged
        If NOROnlyCheckBox.Checked = True Then
            SBMods.Visible = False
        Else
            SBMods.Visible = True
        End If
    End Sub

    Private Sub GroupRootPartitionSize_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextRoot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextRoot.TextChanged
        My.Settings.rootPartitionSize = TextRoot.Text
        'My.Settings.rootPartitionSize = PartitionsizeBar.Value
        PartitionsizeBar.Value = TextRoot.Text
    End Sub

    Private Sub PartitionsizeBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartitionsizeBar.Scroll
        TextRoot.Text = PartitionsizeBar.Value
    End Sub

    Private Sub WutisNOR_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles WutisNOR.LinkClicked

    End Sub
End Class