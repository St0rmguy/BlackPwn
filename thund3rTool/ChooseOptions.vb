Public Class ChooseOptions

    Private Sub GeneralButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralButton.Click
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
                iPhoneOptionsForm.Show()
                Me.Close()
                Exit Select
            Case "N81AP"
                iPodOptionsForm.Show()
                Me.Close()
                Exit Select
            Case "K48AP"
                PackageManagersForm.Show()
                Me.Close()
                Exit Select
            Case "K66AP"
                PackageManagersForm.Show()
                Me.Close()
                Exit Select
            Case Else
                MsgBox("Please Select an IPSW", vbApplicationModal + vbExclamation, "IPSW")
                Exit Select
        End Select
    End Sub
End Class