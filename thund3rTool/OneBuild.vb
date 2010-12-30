Public Class OneBuild

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If My.Settings.device = "N82AP" Then
            Label5.Text = "BlackPwn_iPhone3G.ipsw"
        ElseIf My.Settings.device = "N88AP" Then
            Label5.Text = "BlackPwn_iPhone3GS.ipsw"
        ElseIf My.Settings.device = "N90AP" Then
            Label5.Text = "BlackPwn_iPhone4.ipsw"
        ElseIf My.Settings.device = "N72AP" Then
            Label5.Text = "BlackPwn_iPod2G.ipsw"
        ElseIf My.Settings.device = "N45AP" Then
            Label5.Text = "BlackPwn_iPod3G.ipsw"
        ElseIf My.Settings.device = "N45AP" Then
            Label5.Text = "BlackPwn_iPod4G.ipsw"
        Else
            Label5.Text = "Error!"
        End If
    End Sub
End Class