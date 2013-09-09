Public Class SupervisorForm


    Private Sub ListRoles()
        cboRoles.Items.AddRange(DatabaseModule.GetRolesList().ToArray)
    End Sub

    Private Sub SupervisorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListRoles()
        EnableControls(False)
    End Sub

    

    

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearAll()
        EnableControls(True)
        cboRoles.Enabled = False
        btnNew.Enabled() = False
        btnSave.Enabled() = True


    End Sub

    Private Sub EnableControls(ByVal p1 As Boolean)
        txtRoleName.Enabled = p1
        txtRoleDesc.Enabled = p1
        btnSave.Enabled = False
        For index = 1 To gbPrivileges.Controls.Count
            gbPrivileges.Controls(index - 1).Enabled = p1
        Next


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        EnableControls(False)
        btnNew.Enabled = True
        cboRoles.Enabled = True
        Try
            DatabaseModule.SaveRoleSettings(Me)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub cboRoles_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoles.SelectionChangeCommitted
        Dim rolename As String = cboRoles.SelectedItem
        SetRoleValues(rolename)
        EnableControls(True)
        btnSave.Enabled = True


        


    End Sub

    Private Overloads Sub SetRoleValues(ByVal rolename As String)
        Dim role_access As List(Of Boolean) = DatabaseModule.GetAccess(rolename)
        chkStocks.Checked = role_access(0)
        chkProduction.Checked = role_access(1)
        chkPOS.Checked = role_access(2)
        chkLodging.Checked = role_access(3)
        chkReports.Checked = role_access(4)
        chkAdmin.Checked = role_access(5)
    End Sub

    Private Overloads Sub SetRoleValues()
        Dim rolename As String = cboRoles.SelectedItem
        SetRoleValues(rolename)

    End Sub

    Private Sub ClearAll()
        cboRoles.Text = String.Empty
        txtRoleName.Text = String.Empty
        txtRoleDesc.Text = String.Empty
        chkStocks.Checked = False
        chkProduction.Checked = False
        chkPOS.Checked = False
        chkLodging.Checked = False
        chkReports.Checked = False
        chkAdmin.Checked = False
    End Sub


    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        EnableSearchBoxes(False)
    End Sub

    Private Sub EnableSearchBoxes(ByVal p1 As Boolean)
        chkByName.Enabled = p1
        byEmpID.Enabled = p1
        cboSearchBox.Enabled = p1

        For index = 1 To gboBioData.Controls.Count

            gboBioData.Controls(index - 1).Text = ""
        Next

    End Sub

    
    Private Sub btnSaveEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEmp.Click
        EnableSearchBoxes(True)
    End Sub
End Class
