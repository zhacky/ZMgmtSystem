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
        Me.TabPageRoles = New System.Windows.Forms.TabPage()
        Me.ListBoxRoles = New System.Windows.Forms.ListBox()
        Me.TabControlSupervisor.SuspendLayout()
        Me.TabPageRoles.SuspendLayout()
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
        Me.TabPageUsers.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUsers.Name = "TabPageUsers"
        Me.TabPageUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers.Size = New System.Drawing.Size(572, 305)
        Me.TabPageUsers.TabIndex = 0
        Me.TabPageUsers.Text = "Users"
        Me.TabPageUsers.UseVisualStyleBackColor = True
        '
        'TabPageRoles
        '
        Me.TabPageRoles.Controls.Add(Me.ListBoxRoles)
        Me.TabPageRoles.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRoles.Name = "TabPageRoles"
        Me.TabPageRoles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRoles.Size = New System.Drawing.Size(572, 305)
        Me.TabPageRoles.TabIndex = 1
        Me.TabPageRoles.Text = "Roles"
        Me.TabPageRoles.UseVisualStyleBackColor = True
        '
        'ListBoxRoles
        '
        Me.ListBoxRoles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBoxRoles.FormattingEnabled = True
        Me.ListBoxRoles.Location = New System.Drawing.Point(8, 6)
        Me.ListBoxRoles.Name = "ListBoxRoles"
        Me.ListBoxRoles.Size = New System.Drawing.Size(120, 290)
        Me.ListBoxRoles.TabIndex = 0
        '
        'SupervisorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(580, 383)
        Me.Controls.Add(Me.TabControlSupervisor)
        Me.Name = "SupervisorForm"
        Me.Controls.SetChildIndex(Me.TabControlSupervisor, 0)
        Me.TabControlSupervisor.ResumeLayout(False)
        Me.TabPageRoles.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControlSupervisor As System.Windows.Forms.TabControl
    Friend WithEvents TabPageUsers As System.Windows.Forms.TabPage
    Friend WithEvents TabPageRoles As System.Windows.Forms.TabPage
    Friend WithEvents ListBoxRoles As System.Windows.Forms.ListBox

End Class
