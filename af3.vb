Public Class af3

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        af1.Show()
    End Sub

    Private Sub af3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        BtnUser.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        sell.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        af2.Show()
    End Sub

    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUser.Click
        user.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub
End Class