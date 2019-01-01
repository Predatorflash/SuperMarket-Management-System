Public Class LoginForm1

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        af3.Show()
        Me.Hide()
    End Sub
End Class