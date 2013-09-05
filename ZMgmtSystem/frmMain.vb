Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeSettings()
    End Sub

    Private Sub InitializeSettings()
        tsCurrentUser.Text += CurrentConfig.DisplayName
    End Sub

    Private Sub FullScreenToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FullScreenToolStripMenuItem.CheckStateChanged

        Select Case FullScreenToolStripMenuItem.CheckState
            Case CheckState.Checked
                Me.WindowState = FormWindowState.Maximized
                Me.FormBorderStyle = FormBorderStyle.None

            Case CheckState.Unchecked
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = FormBorderStyle.Sizable
            Case Else
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = FormBorderStyle.Sizable
        End Select

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If InteractivityModule.confirmClosing Then
            Me.Close()
        End If

    End Sub
End Class
