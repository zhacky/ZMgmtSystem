<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitsDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtUnitName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUnitSelect = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddUnit = New System.Windows.Forms.Button()
        Me.btnSaveUnit = New System.Windows.Forms.Button()
        Me.cboUnitGroup = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQtyInGroup = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(25, 74)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(184, 20)
        Me.txtUnitName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Unit Name"
        '
        'cboUnitSelect
        '
        Me.cboUnitSelect.FormattingEnabled = True
        Me.cboUnitSelect.Location = New System.Drawing.Point(25, 34)
        Me.cboUnitSelect.Name = "cboUnitSelect"
        Me.cboUnitSelect.Size = New System.Drawing.Size(121, 21)
        Me.cboUnitSelect.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Unit"
        '
        'btnAddUnit
        '
        Me.btnAddUnit.Location = New System.Drawing.Point(345, 32)
        Me.btnAddUnit.Name = "btnAddUnit"
        Me.btnAddUnit.Size = New System.Drawing.Size(75, 23)
        Me.btnAddUnit.TabIndex = 5
        Me.btnAddUnit.Text = "Add New"
        Me.btnAddUnit.UseVisualStyleBackColor = True
        '
        'btnSaveUnit
        '
        Me.btnSaveUnit.Enabled = False
        Me.btnSaveUnit.Location = New System.Drawing.Point(345, 72)
        Me.btnSaveUnit.Name = "btnSaveUnit"
        Me.btnSaveUnit.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveUnit.TabIndex = 6
        Me.btnSaveUnit.Text = "Save Unit"
        Me.btnSaveUnit.UseVisualStyleBackColor = True
        '
        'cboUnitGroup
        '
        Me.cboUnitGroup.FormattingEnabled = True
        Me.cboUnitGroup.Location = New System.Drawing.Point(25, 122)
        Me.cboUnitGroup.Name = "cboUnitGroup"
        Me.cboUnitGroup.Size = New System.Drawing.Size(121, 21)
        Me.cboUnitGroup.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Unit Group"
        '
        'lblQtyInGroup
        '
        Me.lblQtyInGroup.AutoSize = True
        Me.lblQtyInGroup.Location = New System.Drawing.Point(154, 106)
        Me.lblQtyInGroup.Name = "lblQtyInGroup"
        Me.lblQtyInGroup.Size = New System.Drawing.Size(90, 13)
        Me.lblQtyInGroup.TabIndex = 9
        Me.lblQtyInGroup.Text = "Quantity In Group"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(152, 122)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(57, 20)
        Me.txtQuantity.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(345, 106)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'UnitsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQtyInGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboUnitGroup)
        Me.Controls.Add(Me.btnSaveUnit)
        Me.Controls.Add(Me.btnAddUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboUnitSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUnitName)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnitsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UnitsDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtUnitName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUnitSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddUnit As System.Windows.Forms.Button
    Friend WithEvents btnSaveUnit As System.Windows.Forms.Button
    Friend WithEvents cboUnitGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblQtyInGroup As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class
