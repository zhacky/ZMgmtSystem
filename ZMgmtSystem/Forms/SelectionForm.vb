Public Class SelectionForm

    Private Sub SelectionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableAllButtons()
        EnableButtonsByRole()

        


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

    Private Sub DisableAllButtons()
        btnStocks.Enabled = False
        btnProduction.Enabled = False
        btnPOS.Enabled = False
        btnLodging.Enabled = False
        btnReports.Enabled = False
        btnSupervisor.Enabled = False
        btnSettings.Enabled = False

    End Sub

    Private Sub EnableButtonsByRole()
        Dim RoleSettings() As Integer
        RoleSettings = CurrentConfig.GetRoleSettings(CurrentConfig.usernameToFind)
        Console.WriteLine("RoleSettings: (6)" & RoleSettings(6).ToString)
        If RoleSettings(0) = 1 Then
            btnStocks.Enabled = True
        End If
        If RoleSettings(1) = 1 Then
            btnProduction.Enabled = True
        End If

        If RoleSettings(2) = 1 Then
            btnPOS.Enabled = True
        End If

        If RoleSettings(3) = 1 Then
            btnLodging.Enabled = True
        End If
        If RoleSettings(4) = 1 Then
            btnReports.Enabled = True
        End If
        If RoleSettings(5) = 1 Then
            btnSupervisor.Enabled = True
        End If

        If RoleSettings(6) = 1 Then
            btnSettings.Enabled = True
        End If



    End Sub

    Private Sub btnSupervisor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupervisor.Click
        SupervisorForm.Show()
    End Sub
End Class