<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupervisorForm
    Inherits ZMgmtSystem.frmMain

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControlSupervisor = New System.Windows.Forms.TabControl()
        Me.TabPageUsers = New System.Windows.Forms.TabPage()
        Me.cboSearchBox2 = New System.Windows.Forms.ComboBox()
        Me.gboSearchMode = New System.Windows.Forms.GroupBox()
        Me.byEmpID = New System.Windows.Forms.RadioButton()
        Me.byNameSearch = New System.Windows.Forms.RadioButton()
        Me.gboUserAccess = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboUsersRole = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gboBioData = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.dateHire = New System.Windows.Forms.DateTimePicker()
        Me.dateBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCourtesyTitle = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtPostal = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtReportsTo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.empPhoto = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSaveEmp = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboSearchBox = New System.Windows.Forms.ComboBox()
        Me.txtEmpNotes = New System.Windows.Forms.TextBox()
        Me.TabPageRoles = New System.Windows.Forms.TabPage()
        Me.chkSettings = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.gbPrivileges = New System.Windows.Forms.GroupBox()
        Me.chkReports = New System.Windows.Forms.CheckBox()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        Me.chkPOS = New System.Windows.Forms.CheckBox()
        Me.chkLodging = New System.Windows.Forms.CheckBox()
        Me.chkProduction = New System.Windows.Forms.CheckBox()
        Me.chkStocks = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoleDesc = New System.Windows.Forms.TextBox()
        Me.txtRoleName = New System.Windows.Forms.TextBox()
        Me.lblRoles = New System.Windows.Forms.Label()
        Me.cboRoles = New System.Windows.Forms.ComboBox()
        Me.PictureDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TabControlSupervisor.SuspendLayout()
        Me.TabPageUsers.SuspendLayout()
        Me.gboSearchMode.SuspendLayout()
        Me.gboUserAccess.SuspendLayout()
        Me.gboBioData.SuspendLayout()
        CType(Me.empPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageRoles.SuspendLayout()
        Me.gbPrivileges.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlSupervisor
        '
        Me.TabControlSupervisor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlSupervisor.Controls.Add(Me.TabPageUsers)
        Me.TabControlSupervisor.Controls.Add(Me.TabPageRoles)
        Me.TabControlSupervisor.Location = New System.Drawing.Point(0, 27)
        Me.TabControlSupervisor.Name = "TabControlSupervisor"
        Me.TabControlSupervisor.SelectedIndex = 0
        Me.TabControlSupervisor.Size = New System.Drawing.Size(584, 472)
        Me.TabControlSupervisor.TabIndex = 2
        '
        'TabPageUsers
        '
        Me.TabPageUsers.Controls.Add(Me.cboSearchBox2)
        Me.TabPageUsers.Controls.Add(Me.gboSearchMode)
        Me.TabPageUsers.Controls.Add(Me.gboUserAccess)
        Me.TabPageUsers.Controls.Add(Me.gboBioData)
        Me.TabPageUsers.Controls.Add(Me.empPhoto)
        Me.TabPageUsers.Controls.Add(Me.Label18)
        Me.TabPageUsers.Controls.Add(Me.btnSaveEmp)
        Me.TabPageUsers.Controls.Add(Me.btnAddNew)
        Me.TabPageUsers.Controls.Add(Me.btnSearch)
        Me.TabPageUsers.Controls.Add(Me.cboSearchBox)
        Me.TabPageUsers.Controls.Add(Me.txtEmpNotes)
        Me.TabPageUsers.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUsers.Name = "TabPageUsers"
        Me.TabPageUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers.Size = New System.Drawing.Size(576, 446)
        Me.TabPageUsers.TabIndex = 0
        Me.TabPageUsers.Text = "Users"
        Me.TabPageUsers.UseVisualStyleBackColor = True
        '
        'cboSearchBox2
        '
        Me.cboSearchBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSearchBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearchBox2.Enabled = False
        Me.cboSearchBox2.FormattingEnabled = True
        Me.cboSearchBox2.Location = New System.Drawing.Point(11, 49)
        Me.cboSearchBox2.Name = "cboSearchBox2"
        Me.cboSearchBox2.Size = New System.Drawing.Size(231, 21)
        Me.cboSearchBox2.TabIndex = 17
        Me.cboSearchBox2.Visible = False
        '
        'gboSearchMode
        '
        Me.gboSearchMode.Controls.Add(Me.byEmpID)
        Me.gboSearchMode.Controls.Add(Me.byNameSearch)
        Me.gboSearchMode.Location = New System.Drawing.Point(11, 7)
        Me.gboSearchMode.Name = "gboSearchMode"
        Me.gboSearchMode.Size = New System.Drawing.Size(231, 36)
        Me.gboSearchMode.TabIndex = 16
        Me.gboSearchMode.TabStop = False
        '
        'byEmpID
        '
        Me.byEmpID.AutoSize = True
        Me.byEmpID.Location = New System.Drawing.Point(131, 13)
        Me.byEmpID.Name = "byEmpID"
        Me.byEmpID.Size = New System.Drawing.Size(87, 17)
        Me.byEmpID.TabIndex = 0
        Me.byEmpID.TabStop = True
        Me.byEmpID.Text = "Search by ID"
        Me.byEmpID.UseVisualStyleBackColor = True
        '
        'byNameSearch
        '
        Me.byNameSearch.AutoSize = True
        Me.byNameSearch.Location = New System.Drawing.Point(6, 13)
        Me.byNameSearch.Name = "byNameSearch"
        Me.byNameSearch.Size = New System.Drawing.Size(90, 17)
        Me.byNameSearch.TabIndex = 0
        Me.byNameSearch.TabStop = True
        Me.byNameSearch.Text = "Search Name"
        Me.byNameSearch.UseVisualStyleBackColor = True
        '
        'gboUserAccess
        '
        Me.gboUserAccess.Controls.Add(Me.Label22)
        Me.gboUserAccess.Controls.Add(Me.cboUsersRole)
        Me.gboUserAccess.Controls.Add(Me.Label21)
        Me.gboUserAccess.Controls.Add(Me.txtUserPassword)
        Me.gboUserAccess.Controls.Add(Me.txtUsername)
        Me.gboUserAccess.Controls.Add(Me.Label20)
        Me.gboUserAccess.Location = New System.Drawing.Point(11, 361)
        Me.gboUserAccess.Name = "gboUserAccess"
        Me.gboUserAccess.Size = New System.Drawing.Size(388, 79)
        Me.gboUserAccess.TabIndex = 15
        Me.gboUserAccess.TabStop = False
        Me.gboUserAccess.Text = "User Access"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(259, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Role:"
        '
        'cboUsersRole
        '
        Me.cboUsersRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsersRole.FormattingEnabled = True
        Me.cboUsersRole.Location = New System.Drawing.Point(262, 32)
        Me.cboUsersRole.Name = "cboUsersRole"
        Me.cboUsersRole.Size = New System.Drawing.Size(121, 21)
        Me.cboUsersRole.TabIndex = 38
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(132, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Password:"
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(131, 32)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtUserPassword.TabIndex = 37
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(6, 32)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 36
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Username:"
        '
        'gboBioData
        '
        Me.gboBioData.Controls.Add(Me.Label19)
        Me.gboBioData.Controls.Add(Me.txtEmpID)
        Me.gboBioData.Controls.Add(Me.dateHire)
        Me.gboBioData.Controls.Add(Me.dateBirth)
        Me.gboBioData.Controls.Add(Me.Label6)
        Me.gboBioData.Controls.Add(Me.Label5)
        Me.gboBioData.Controls.Add(Me.Label4)
        Me.gboBioData.Controls.Add(Me.Label9)
        Me.gboBioData.Controls.Add(Me.Label8)
        Me.gboBioData.Controls.Add(Me.Label12)
        Me.gboBioData.Controls.Add(Me.Label13)
        Me.gboBioData.Controls.Add(Me.Label15)
        Me.gboBioData.Controls.Add(Me.Label17)
        Me.gboBioData.Controls.Add(Me.Label16)
        Me.gboBioData.Controls.Add(Me.Label14)
        Me.gboBioData.Controls.Add(Me.Label11)
        Me.gboBioData.Controls.Add(Me.Label10)
        Me.gboBioData.Controls.Add(Me.Label7)
        Me.gboBioData.Controls.Add(Me.Label3)
        Me.gboBioData.Controls.Add(Me.cboCourtesyTitle)
        Me.gboBioData.Controls.Add(Me.txtLastName)
        Me.gboBioData.Controls.Add(Me.txtMiddleName)
        Me.gboBioData.Controls.Add(Me.txtFirstName)
        Me.gboBioData.Controls.Add(Me.txtPostal)
        Me.gboBioData.Controls.Add(Me.txtProvince)
        Me.gboBioData.Controls.Add(Me.txtMobile)
        Me.gboBioData.Controls.Add(Me.txtReportsTo)
        Me.gboBioData.Controls.Add(Me.txtEmail)
        Me.gboBioData.Controls.Add(Me.txtPhone)
        Me.gboBioData.Controls.Add(Me.txtCity)
        Me.gboBioData.Controls.Add(Me.txtEmpAddress)
        Me.gboBioData.Controls.Add(Me.txtPosition)
        Me.gboBioData.Location = New System.Drawing.Point(8, 88)
        Me.gboBioData.Name = "gboBioData"
        Me.gboBioData.Size = New System.Drawing.Size(391, 267)
        Me.gboBioData.TabIndex = 12
        Me.gboBioData.TabStop = False
        Me.gboBioData.Text = "Personal Data"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "EMPLOYEE ID"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(98, 19)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpID.TabIndex = 21
        '
        'dateHire
        '
        Me.dateHire.CustomFormat = Global.ZMgmtSystem.My.Resources.Resources.DbDatabaseName
        Me.dateHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateHire.Location = New System.Drawing.Point(237, 108)
        Me.dateHire.Name = "dateHire"
        Me.dateHire.Size = New System.Drawing.Size(97, 20)
        Me.dateHire.TabIndex = 27
        '
        'dateBirth
        '
        Me.dateBirth.CustomFormat = Global.ZMgmtSystem.My.Resources.Resources.DbDatabaseName
        Me.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateBirth.Location = New System.Drawing.Point(134, 108)
        Me.dateBirth.Name = "dateBirth"
        Me.dateBirth.Size = New System.Drawing.Size(97, 20)
        Me.dateBirth.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "M.I."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Hire Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Birthdate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Postal Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Province"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Email"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(262, 213)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Mobile"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(131, 213)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Reports To"
        Me.Label16.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(262, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Phone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(262, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "City"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Title:"
        '
        'cboCourtesyTitle
        '
        Me.cboCourtesyTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourtesyTitle.FormattingEnabled = True
        Me.cboCourtesyTitle.Items.AddRange(New Object() {"Mr.", "Ms.", "Mrs.", "Engr.", "Dr.", "Atty."})
        Me.cboCourtesyTitle.Location = New System.Drawing.Point(10, 68)
        Me.cboCourtesyTitle.Name = "cboCourtesyTitle"
        Me.cboCourtesyTitle.Size = New System.Drawing.Size(69, 21)
        Me.cboCourtesyTitle.TabIndex = 23
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(265, 68)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(118, 20)
        Me.txtLastName.TabIndex = 24
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(209, 68)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(50, 20)
        Me.txtMiddleName.TabIndex = 23
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(85, 68)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(118, 20)
        Me.txtFirstName.TabIndex = 22
        '
        'txtPostal
        '
        Me.txtPostal.Location = New System.Drawing.Point(134, 190)
        Me.txtPostal.Name = "txtPostal"
        Me.txtPostal.Size = New System.Drawing.Size(118, 20)
        Me.txtPostal.TabIndex = 31
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(10, 190)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(118, 20)
        Me.txtProvince.TabIndex = 30
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(265, 229)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(118, 20)
        Me.txtMobile.TabIndex = 35
        '
        'txtReportsTo
        '
        Me.txtReportsTo.Location = New System.Drawing.Point(134, 229)
        Me.txtReportsTo.Name = "txtReportsTo"
        Me.txtReportsTo.Size = New System.Drawing.Size(118, 20)
        Me.txtReportsTo.TabIndex = 34
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(10, 229)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(118, 20)
        Me.txtEmail.TabIndex = 33
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(265, 190)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(118, 20)
        Me.txtPhone.TabIndex = 32
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(265, 147)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(118, 20)
        Me.txtCity.TabIndex = 29
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.Location = New System.Drawing.Point(10, 147)
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.Size = New System.Drawing.Size(249, 20)
        Me.txtEmpAddress.TabIndex = 28
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(10, 108)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(118, 20)
        Me.txtPosition.TabIndex = 25
        '
        'empPhoto
        '
        Me.empPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.empPhoto.InitialImage = Global.ZMgmtSystem.My.Resources.Resources.emoticon
        Me.empPhoto.Location = New System.Drawing.Point(436, 88)
        Me.empPhoto.Name = "empPhoto"
        Me.empPhoto.Size = New System.Drawing.Size(100, 100)
        Me.empPhoto.TabIndex = 11
        Me.empPhoto.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(405, 198)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Notes"
        '
        'btnSaveEmp
        '
        Me.btnSaveEmp.Enabled = False
        Me.btnSaveEmp.Location = New System.Drawing.Point(489, 276)
        Me.btnSaveEmp.Name = "btnSaveEmp"
        Me.btnSaveEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveEmp.TabIndex = 40
        Me.btnSaveEmp.Text = "Save"
        Me.btnSaveEmp.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(489, 47)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(408, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboSearchBox
        '
        Me.cboSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearchBox.FormattingEnabled = True
        Me.cboSearchBox.Location = New System.Drawing.Point(11, 49)
        Me.cboSearchBox.Name = "cboSearchBox"
        Me.cboSearchBox.Size = New System.Drawing.Size(388, 21)
        Me.cboSearchBox.TabIndex = 4
        '
        'txtEmpNotes
        '
        Me.txtEmpNotes.Location = New System.Drawing.Point(408, 218)
        Me.txtEmpNotes.Multiline = True
        Me.txtEmpNotes.Name = "txtEmpNotes"
        Me.txtEmpNotes.Size = New System.Drawing.Size(156, 52)
        Me.txtEmpNotes.TabIndex = 39
        '
        'TabPageRoles
        '
        Me.TabPageRoles.Controls.Add(Me.chkSettings)
        Me.TabPageRoles.Controls.Add(Me.btnSave)
        Me.TabPageRoles.Controls.Add(Me.btnNew)
        Me.TabPageRoles.Controls.Add(Me.lblError)
        Me.TabPageRoles.Controls.Add(Me.gbPrivileges)
        Me.TabPageRoles.Controls.Add(Me.Label2)
        Me.TabPageRoles.Controls.Add(Me.Label1)
        Me.TabPageRoles.Controls.Add(Me.txtRoleDesc)
        Me.TabPageRoles.Controls.Add(Me.txtRoleName)
        Me.TabPageRoles.Controls.Add(Me.lblRoles)
        Me.TabPageRoles.Controls.Add(Me.cboRoles)
        Me.TabPageRoles.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRoles.Name = "TabPageRoles"
        Me.TabPageRoles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRoles.Size = New System.Drawing.Size(576, 446)
        Me.TabPageRoles.TabIndex = 1
        Me.TabPageRoles.Text = "Roles"
        Me.TabPageRoles.UseVisualStyleBackColor = True
        '
        'chkSettings
        '
        Me.chkSettings.AutoSize = True
        Me.chkSettings.Checked = True
        Me.chkSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSettings.Location = New System.Drawing.Point(84, 255)
        Me.chkSettings.Name = "chkSettings"
        Me.chkSettings.Size = New System.Drawing.Size(64, 17)
        Me.chkSettings.TabIndex = 13
        Me.chkSettings.Text = "Settings"
        Me.chkSettings.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(417, 251)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(417, 17)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(81, 248)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 10
        '
        'gbPrivileges
        '
        Me.gbPrivileges.Controls.Add(Me.chkReports)
        Me.gbPrivileges.Controls.Add(Me.chkAdmin)
        Me.gbPrivileges.Controls.Add(Me.chkPOS)
        Me.gbPrivileges.Controls.Add(Me.chkLodging)
        Me.gbPrivileges.Controls.Add(Me.chkProduction)
        Me.gbPrivileges.Controls.Add(Me.chkStocks)
        Me.gbPrivileges.Location = New System.Drawing.Point(81, 171)
        Me.gbPrivileges.Name = "gbPrivileges"
        Me.gbPrivileges.Size = New System.Drawing.Size(411, 74)
        Me.gbPrivileges.TabIndex = 9
        Me.gbPrivileges.TabStop = False
        Me.gbPrivileges.Text = "Privileges:"
        '
        'chkReports
        '
        Me.chkReports.AutoSize = True
        Me.chkReports.Location = New System.Drawing.Point(295, 19)
        Me.chkReports.Name = "chkReports"
        Me.chkReports.Size = New System.Drawing.Size(63, 17)
        Me.chkReports.TabIndex = 7
        Me.chkReports.Text = "Reports"
        Me.chkReports.UseVisualStyleBackColor = True
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Location = New System.Drawing.Point(295, 42)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(55, 17)
        Me.chkAdmin.TabIndex = 8
        Me.chkAdmin.Text = "Admin"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'chkPOS
        '
        Me.chkPOS.AutoSize = True
        Me.chkPOS.Location = New System.Drawing.Point(164, 19)
        Me.chkPOS.Name = "chkPOS"
        Me.chkPOS.Size = New System.Drawing.Size(88, 17)
        Me.chkPOS.TabIndex = 5
        Me.chkPOS.Text = "Point-Of-Sale"
        Me.chkPOS.UseVisualStyleBackColor = True
        '
        'chkLodging
        '
        Me.chkLodging.AutoSize = True
        Me.chkLodging.Location = New System.Drawing.Point(164, 42)
        Me.chkLodging.Name = "chkLodging"
        Me.chkLodging.Size = New System.Drawing.Size(64, 17)
        Me.chkLodging.TabIndex = 6
        Me.chkLodging.Text = "Lodging"
        Me.chkLodging.UseVisualStyleBackColor = True
        '
        'chkProduction
        '
        Me.chkProduction.AutoSize = True
        Me.chkProduction.Location = New System.Drawing.Point(52, 42)
        Me.chkProduction.Name = "chkProduction"
        Me.chkProduction.Size = New System.Drawing.Size(77, 17)
        Me.chkProduction.TabIndex = 4
        Me.chkProduction.Text = "Production"
        Me.chkProduction.UseVisualStyleBackColor = True
        '
        'chkStocks
        '
        Me.chkStocks.AutoSize = True
        Me.chkStocks.Location = New System.Drawing.Point(52, 19)
        Me.chkStocks.Name = "chkStocks"
        Me.chkStocks.Size = New System.Drawing.Size(59, 17)
        Me.chkStocks.TabIndex = 3
        Me.chkStocks.Text = "Stocks"
        Me.chkStocks.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Role Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Role Name:"
        '
        'txtRoleDesc
        '
        Me.txtRoleDesc.Location = New System.Drawing.Point(81, 98)
        Me.txtRoleDesc.Multiline = True
        Me.txtRoleDesc.Name = "txtRoleDesc"
        Me.txtRoleDesc.Size = New System.Drawing.Size(411, 67)
        Me.txtRoleDesc.TabIndex = 7
        '
        'txtRoleName
        '
        Me.txtRoleName.Location = New System.Drawing.Point(81, 59)
        Me.txtRoleName.Name = "txtRoleName"
        Me.txtRoleName.Size = New System.Drawing.Size(411, 20)
        Me.txtRoleName.TabIndex = 5
        '
        'lblRoles
        '
        Me.lblRoles.AutoSize = True
        Me.lblRoles.Location = New System.Drawing.Point(81, 3)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(34, 13)
        Me.lblRoles.TabIndex = 1
        Me.lblRoles.Text = "Roles"
        '
        'cboRoles
        '
        Me.cboRoles.FormattingEnabled = True
        Me.cboRoles.Location = New System.Drawing.Point(81, 19)
        Me.cboRoles.Name = "cboRoles"
        Me.cboRoles.Size = New System.Drawing.Size(330, 21)
        Me.cboRoles.TabIndex = 0
        '
        'PictureDialog
        '
        Me.PictureDialog.Filter = "JPEG Image (*.jpg)|*.jpg"
        '
        'SupervisorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 524)
        Me.Controls.Add(Me.TabControlSupervisor)
        Me.Name = "SupervisorForm"
        Me.Controls.SetChildIndex(Me.TabControlSupervisor, 0)
        Me.TabControlSupervisor.ResumeLayout(False)
        Me.TabPageUsers.ResumeLayout(False)
        Me.TabPageUsers.PerformLayout()
        Me.gboSearchMode.ResumeLayout(False)
        Me.gboSearchMode.PerformLayout()
        Me.gboUserAccess.ResumeLayout(False)
        Me.gboUserAccess.PerformLayout()
        Me.gboBioData.ResumeLayout(False)
        Me.gboBioData.PerformLayout()
        CType(Me.empPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageRoles.ResumeLayout(False)
        Me.TabPageRoles.PerformLayout()
        Me.gbPrivileges.ResumeLayout(False)
        Me.gbPrivileges.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControlSupervisor As System.Windows.Forms.TabControl
    Friend WithEvents TabPageUsers As System.Windows.Forms.TabPage
    Friend WithEvents TabPageRoles As System.Windows.Forms.TabPage
    Friend WithEvents lblRoles As System.Windows.Forms.Label
    Friend WithEvents cboRoles As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents gbPrivileges As System.Windows.Forms.GroupBox
    Friend WithEvents chkReports As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkPOS As System.Windows.Forms.CheckBox
    Friend WithEvents chkLodging As System.Windows.Forms.CheckBox
    Friend WithEvents chkProduction As System.Windows.Forms.CheckBox
    Friend WithEvents chkStocks As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoleDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtRoleName As System.Windows.Forms.TextBox
    Friend WithEvents chkSettings As System.Windows.Forms.CheckBox
    Friend WithEvents cboSearchBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveEmp As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents empPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEmpNotes As System.Windows.Forms.TextBox
    Friend WithEvents gboBioData As System.Windows.Forms.GroupBox
    Friend WithEvents dateHire As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCourtesyTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtReportsTo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents PictureDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gboUserAccess As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboUsersRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents gboSearchMode As System.Windows.Forms.GroupBox
    Friend WithEvents byEmpID As System.Windows.Forms.RadioButton
    Friend WithEvents byNameSearch As System.Windows.Forms.RadioButton
    Friend WithEvents cboSearchBox2 As System.Windows.Forms.ComboBox

End Class
