Public Class iPhoneOptionsForm

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BackArrowiPhoneOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SelectIPSW.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HacktivateNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PartitionsizeBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartitionsizeBar.Scroll
        TextRoot.Text = PartitionsizeBar.Value
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextRoot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextRoot.TextChanged
        My.Settings.rootPartitionSize = TextRoot.Text
        'My.Settings.rootPartitionSize = PartitionsizeBar.Value
        PartitionsizeBar.Value = TextRoot.Text
    End Sub

    Private Sub NOROnlyCheckBox_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOROnlyCheckBox.CheckedChanged
        If NOROnlyCheckBox.Checked = True Then
            SBMods.Visible = False
            HacktivationMods.Visible = False
        Else
            SBMods.Visible = True
            HacktivationMods.Visible = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'My.Settings.BBUpdate = True
        'My.Settings.name()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class