Public Class SelectionForm

    Private Sub SelectionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DisableAllButtons()
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
        Dim RoleSettings() As Boolean
        RoleSettings = CurrentConfig.GetRoleSettings(CurrentConfig.usernameToFind)
        Console.WriteLine("RoleSettings: (6)" & RoleSettings(6).ToString)
        If RoleSettings(0) Then
            btnStocks.Enabled = True
        End If
        If RoleSettings(1) Then
            btnProduction.Enabled = True
        End If

        If RoleSettings(2) Then
            btnPOS.Enabled = True
        End If

        If RoleSettings(3) Then
            btnLodging.Enabled = True
        End If
        If RoleSettings(4) Then
            btnReports.Enabled = True
        End If
        If RoleSettings(5) Then
            btnSupervisor.Enabled = True
        End If

        If RoleSettings(6) Then
            btnSettings.Enabled = True
        End If



    End Sub

    Private Sub btnSupervisor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupervisor.Click
        SupervisorForm.Show()
    End Sub

    Private Sub btnProduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduction.Click
        ProductionForm.Show()
    End Sub
End Class