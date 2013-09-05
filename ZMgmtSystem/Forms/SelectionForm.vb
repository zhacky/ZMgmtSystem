Public Class SelectionForm

    Private Sub SelectionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case CurrentConfig.UserLevel
            Case 1

            Case 2

            Case Else

        End Select


    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        SettingsDialog.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If InteractivityModule.confirmClosing() Then
            Me.Close()
        End If
    End Sub

    Private Sub btnStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStocks.Click
        StocksForm.Show()
    End Sub
End Class