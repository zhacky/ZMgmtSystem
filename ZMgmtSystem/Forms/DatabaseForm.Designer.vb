<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.layoutPanelbtnArea = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnDbTest = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtDbUser = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtDbPassword = New System.Windows.Forms.TextBox()
        Me.cboServer = New System.Windows.Forms.ComboBox()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.cboDatabase = New System.Windows.Forms.ComboBox()
        Me.lblTestResult = New System.Windows.Forms.Label()
        Me.layoutPanelbtnArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutPanelbtnArea
        '
        Me.layoutPanelbtnArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layoutPanelbtnArea.ColumnCount = 2
        Me.layoutPanelbtnArea.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.layoutPanelbtnArea.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.layoutPanelbtnArea.Controls.Add(Me.OK_Button, 0, 0)
        Me.layoutPanelbtnArea.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.layoutPanelbtnArea.Location = New System.Drawing.Point(277, 274)
        Me.layoutPanelbtnArea.Name = "layoutPanelbtnArea"
        Me.layoutPanelbtnArea.RowCount = 1
        Me.layoutPanelbtnArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.layoutPanelbtnArea.Size = New System.Drawing.Size(146, 29)
        Me.layoutPanelbtnArea.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'btnDbTest
        '
        Me.btnDbTest.Location = New System.Drawing.Point(165, 168)
        Me.btnDbTest.Name = "btnDbTest"
        Me.btnDbTest.Size = New System.Drawing.Size(111, 23)
        Me.btnDbTest.TabIndex = 6
        Me.btnDbTest.Text = "Test Connection"
        Me.btnDbTest.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(74, 92)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(71, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "USERNAME:"
        '
        'txtDbUser
        '
        Me.txtDbUser.Location = New System.Drawing.Point(165, 89)
        Me.txtDbUser.Name = "txtDbUser"
        Me.txtDbUser.Size = New System.Drawing.Size(198, 20)
        Me.txtDbUser.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(72, 118)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(73, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "PASSWORD:"
        '
        'txtDbPassword
        '
        Me.txtDbPassword.Location = New System.Drawing.Point(165, 115)
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtDbPassword.TabIndex = 4
        '
        'cboServer
        '
        Me.cboServer.FormattingEnabled = True
        Me.cboServer.Location = New System.Drawing.Point(165, 62)
        Me.cboServer.Name = "cboServer"
        Me.cboServer.Size = New System.Drawing.Size(198, 21)
        Me.cboServer.TabIndex = 2
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(91, 65)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(54, 13)
        Me.lblServer.TabIndex = 2
        Me.lblServer.Text = "SERVER:"
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(78, 144)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(67, 13)
        Me.lblDatabase.TabIndex = 2
        Me.lblDatabase.Text = "DATABASE:"
        '
        'cboDatabase
        '
        Me.cboDatabase.FormattingEnabled = True
        Me.cboDatabase.Location = New System.Drawing.Point(165, 141)
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.Size = New System.Drawing.Size(198, 21)
        Me.cboDatabase.TabIndex = 5
        '
        'lblTestResult
        '
        Me.lblTestResult.AutoSize = True
        Me.lblTestResult.Location = New System.Drawing.Point(171, 204)
        Me.lblTestResult.Name = "lblTestResult"
        Me.lblTestResult.Size = New System.Drawing.Size(0, 13)
        Me.lblTestResult.TabIndex = 7
        '
        'DatabaseForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.lblTestResult)
        Me.Controls.Add(Me.cboDatabase)
        Me.Controls.Add(Me.cboServer)
        Me.Controls.Add(Me.txtDbPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.txtDbUser)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnDbTest)
        Me.Controls.Add(Me.layoutPanelbtnArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatabaseForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Database Configuration"
        Me.layoutPanelbtnArea.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents layoutPanelbtnArea As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btnDbTest As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtDbUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtDbPassword As System.Windows.Forms.TextBox
    Friend WithEvents cboServer As System.Windows.Forms.ComboBox
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblDatabase As System.Windows.Forms.Label
    Friend WithEvents cboDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents lblTestResult As System.Windows.Forms.Label

End Class
