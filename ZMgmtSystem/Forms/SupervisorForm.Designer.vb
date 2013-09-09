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
        Me.gboBioData = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.empPhoto = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSaveEmp = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.byEmpID = New System.Windows.Forms.CheckBox()
        Me.chkByName = New System.Windows.Forms.CheckBox()
        Me.cboSearchBox = New System.Windows.Forms.ComboBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
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
        Me.TabControlSupervisor.SuspendLayout()
        Me.TabPageUsers.SuspendLayout()
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
        Me.TabControlSupervisor.Size = New System.Drawing.Size(580, 331)
        Me.TabControlSupervisor.TabIndex = 2
        '
        'TabPageUsers
        '
        Me.TabPageUsers.Controls.Add(Me.gboBioData)
        Me.TabPageUsers.Controls.Add(Me.empPhoto)
        Me.TabPageUsers.Controls.Add(Me.Label18)
        Me.TabPageUsers.Controls.Add(Me.btnSaveEmp)
        Me.TabPageUsers.Controls.Add(Me.btnAddNew)
        Me.TabPageUsers.Controls.Add(Me.btnSearch)
        Me.TabPageUsers.Controls.Add(Me.byEmpID)
        Me.TabPageUsers.Controls.Add(Me.chkByName)
        Me.TabPageUsers.Controls.Add(Me.cboSearchBox)
        Me.TabPageUsers.Controls.Add(Me.TextBox13)
        Me.TabPageUsers.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUsers.Name = "TabPageUsers"
        Me.TabPageUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers.Size = New System.Drawing.Size(572, 305)
        Me.TabPageUsers.TabIndex = 0
        Me.TabPageUsers.Text = "Users"
        Me.TabPageUsers.UseVisualStyleBackColor = True
        '
        'gboBioData
        '
        Me.gboBioData.Controls.Add(Me.DateTimePicker2)
        Me.gboBioData.Controls.Add(Me.DateTimePicker1)
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
        Me.gboBioData.Controls.Add(Me.ComboBox1)
        Me.gboBioData.Controls.Add(Me.TextBox4)
        Me.gboBioData.Controls.Add(Me.TextBox3)
        Me.gboBioData.Controls.Add(Me.TextBox2)
        Me.gboBioData.Controls.Add(Me.TextBox7)
        Me.gboBioData.Controls.Add(Me.TextBox8)
        Me.gboBioData.Controls.Add(Me.TextBox12)
        Me.gboBioData.Controls.Add(Me.TextBox11)
        Me.gboBioData.Controls.Add(Me.TextBox10)
        Me.gboBioData.Controls.Add(Me.TextBox9)
        Me.gboBioData.Controls.Add(Me.TextBox6)
        Me.gboBioData.Controls.Add(Me.TextBox5)
        Me.gboBioData.Controls.Add(Me.TextBox1)
        Me.gboBioData.Location = New System.Drawing.Point(8, 76)
        Me.gboBioData.Name = "gboBioData"
        Me.gboBioData.Size = New System.Drawing.Size(391, 223)
        Me.gboBioData.TabIndex = 12
        Me.gboBioData.TabStop = False
        Me.gboBioData.Text = "Personal Data"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(237, 69)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker2.TabIndex = 39
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 69)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "M.I."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Hire Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Birthdate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Postal Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Province"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Email"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(262, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Mobile"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(131, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Reports To"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(262, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Phone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(262, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "City"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Title:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(265, 29)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(118, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(209, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(50, 20)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(134, 151)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(118, 20)
        Me.TextBox7.TabIndex = 11
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(10, 151)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(118, 20)
        Me.TextBox8.TabIndex = 12
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(265, 190)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(118, 20)
        Me.TextBox12.TabIndex = 13
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(134, 190)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(118, 20)
        Me.TextBox11.TabIndex = 20
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(10, 190)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(118, 20)
        Me.TextBox10.TabIndex = 21
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(265, 151)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(118, 20)
        Me.TextBox9.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(265, 108)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(118, 20)
        Me.TextBox6.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(10, 108)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(249, 20)
        Me.TextBox5.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(118, 20)
        Me.TextBox1.TabIndex = 19
        '
        'empPhoto
        '
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
        Me.btnSaveEmp.Location = New System.Drawing.Point(489, 276)
        Me.btnSaveEmp.Name = "btnSaveEmp"
        Me.btnSaveEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveEmp.TabIndex = 8
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
        'byEmpID
        '
        Me.byEmpID.AutoSize = True
        Me.byEmpID.Location = New System.Drawing.Point(98, 26)
        Me.byEmpID.Name = "byEmpID"
        Me.byEmpID.Size = New System.Drawing.Size(101, 17)
        Me.byEmpID.TabIndex = 5
        Me.byEmpID.Text = "By Employee ID"
        Me.byEmpID.UseVisualStyleBackColor = True
        '
        'chkByName
        '
        Me.chkByName.AutoSize = True
        Me.chkByName.Location = New System.Drawing.Point(11, 26)
        Me.chkByName.Name = "chkByName"
        Me.chkByName.Size = New System.Drawing.Size(69, 17)
        Me.chkByName.TabIndex = 5
        Me.chkByName.Text = "By Name"
        Me.chkByName.UseVisualStyleBackColor = True
        '
        'cboSearchBox
        '
        Me.cboSearchBox.FormattingEnabled = True
        Me.cboSearchBox.Location = New System.Drawing.Point(11, 49)
        Me.cboSearchBox.Name = "cboSearchBox"
        Me.cboSearchBox.Size = New System.Drawing.Size(388, 21)
        Me.cboSearchBox.TabIndex = 4
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(408, 218)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(156, 52)
        Me.TextBox13.TabIndex = 0
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
        Me.TabPageRoles.Size = New System.Drawing.Size(572, 305)
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
        'SupervisorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(580, 383)
        Me.Controls.Add(Me.TabControlSupervisor)
        Me.Name = "SupervisorForm"
        Me.Controls.SetChildIndex(Me.TabControlSupervisor, 0)
        Me.TabControlSupervisor.ResumeLayout(False)
        Me.TabPageUsers.ResumeLayout(False)
        Me.TabPageUsers.PerformLayout()
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
    Friend WithEvents chkByName As System.Windows.Forms.CheckBox
    Friend WithEvents cboSearchBox As System.Windows.Forms.ComboBox
    Friend WithEvents byEmpID As System.Windows.Forms.CheckBox
    Friend WithEvents btnSaveEmp As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents empPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents gboBioData As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
