Imports ZMgmtSystem.Param
Public Class SupervisorForm




    Private Sub ListRoles()
        cboRoles.Items.AddRange(DatabaseModule.GetRolesList().ToArray)
        cboUsersRole.Items.AddRange(DatabaseModule.GetRolesList().ToArray)

    End Sub

    Private Sub SupervisorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListRoles()
        EnableControls(False)
        ListEmployees()
        gboBioData.Enabled = False
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
        If btnAddNew.Text = "Add New" Then
            gboBioData.Enabled = True
            btnSaveEmp.Enabled = True
            btnSave.Text = "Save"
            btnAddNew.Text = "Cancel"
            EnableSearchBoxes(False)
            For index = 1 To gboBioData.Controls.Count
                If TypeOf (gboBioData.Controls(index - 1)) Is TextBox Or TypeOf (gboBioData.Controls(index - 1)) Is ComboBox Then
                    gboBioData.Controls(index - 1).Text = ""
                End If

            Next
        Else
            gboBioData.Enabled = False
            btnSaveEmp.Enabled = False
            btnAddNew.Text = "Add New"
            EnableSearchBoxes(True)
        End If

    End Sub

    Private Sub EnableSearchBoxes(ByVal p1 As Boolean)
        byNameSearch.Enabled = p1
        byEmpID.Enabled = p1
        cboSearchBox.Enabled = p1
        cboSearchBox2.Enabled = p1


    End Sub


    Private Sub btnSaveEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEmp.Click
        If ValidateBoxes() Then
            EnableSearchBoxes(True)
            btnSave.Enabled = False
            Dim this_emp As New Employee(Me)
            this_emp.Save()
            this_emp.Dispose()
        End If
    End Sub

    Private Sub empPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empPhoto.Click

        PictureDialog.ShowDialog()

    End Sub

    Private Sub PictureDialog_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PictureDialog.FileOk
        Dim imgsrc As Image = Image.FromFile(PictureDialog.FileName)
        Dim bmp_src As New Bitmap(imgsrc)
        Dim bmp_dest As New Bitmap(100, 100)
        Dim NewGraphics As Graphics = Graphics.FromImage(bmp_dest)
        NewGraphics.DrawImage(bmp_src, 0, 0, 100, 100)
        empPhoto.Image = bmp_dest
    End Sub

    Private Sub ListEmployees()
        Dim employees As String()
        Dim Emp_ids As String()
        Emp_ids = Employee.GetAllEmployees(EMPLOYEEID)
        employees = Employee.GetAllEmployees(FULLNAME)
        cboSearchBox2.Items.AddRange(Emp_ids)
        cboSearchBox.Items.AddRange(employees)


    End Sub

    Private Sub cboSearchBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBox.SelectedIndexChanged
        gboBioData.Enabled = True
        btnSave.Text = "Update"
        btnSave.Enabled = True
    End Sub

 
    Private Sub byEmpID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles byEmpID.CheckedChanged
        If byEmpID.Checked Then
            byNameSearch.Checked = False
            cboSearchBox.Visible = False
            cboSearchBox.Enabled = False
            cboSearchBox2.Visible = True
            cboSearchBox2.Enabled = True
        Else
            byNameSearch.Checked = True
            cboSearchBox.Visible = True
            cboSearchBox.Enabled = True
            cboSearchBox2.Visible = False
            cboSearchBox2.Enabled = False

        End If
    End Sub

    Private Sub byNameSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles byNameSearch.CheckedChanged
        If byNameSearch.Checked Then
            byEmpID.Checked = False
            cboSearchBox.Visible = True
            cboSearchBox.Enabled = True
            cboSearchBox2.Visible = False
            cboSearchBox2.Enabled = False
        Else
            byEmpID.Checked = True
            cboSearchBox.Visible = False
            cboSearchBox.Enabled = False
            cboSearchBox2.Visible = True
            cboSearchBox2.Enabled = True

        End If
    End Sub

    Private Function ValidateBoxes() As Boolean
        Dim result As Boolean = False
        If Not IsNumeric(txtEmpID.Text) Then
            MessageBox.Show("Employee ID must be a number...")
        ElseIf txtFirstName.Text = "" Or txtLastName.Text = "" Then
            MessageBox.Show("Please provide a complete name")

        ElseIf txtUsername.Text = "" Or txtUserPassword.Text = "" Then
            MessageBox.Show("Username and password cannot be empty")
        ElseIf cboUsersRole.SelectedIndex = -1 Then
            MessageBox.Show("Please select role")
        Else
            result = True
        End If
        



            Return result
    End Function

 

  
    Private Sub cboSearchBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBox2.SelectedIndexChanged
        gboBioData.Enabled = True
        btnSave.Text = "Update"
        btnSave.Enabled = True
    End Sub
End Class
