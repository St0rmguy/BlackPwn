Public Class PackageManagersForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case My.Settings.device
            Case "N88AP"
                iPhoneOptionsForm.Show()
                Me.Close()
                Exit Select
            Case "M68AP"
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
            Case Else
                MsgBox("Please Select an IPSW", vbApplicationModal + vbExclamation, "IPSW")
                Exit Select
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Settings.device = "N82AP" Then
            CustomBootLogos05.Show()
            Me.Close()
        Else : ReadyToBuild06.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class