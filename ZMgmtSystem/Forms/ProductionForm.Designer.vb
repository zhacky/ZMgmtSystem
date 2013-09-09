<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionForm
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
        Me.TabControlProduction = New System.Windows.Forms.TabControl()
        Me.TabPageProducts = New System.Windows.Forms.TabPage()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.TabPageProductDetails = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.TabControlProduction.SuspendLayout()
        Me.TabPageProducts.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageProductDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlProduction
        '
        Me.TabControlProduction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlProduction.Controls.Add(Me.TabPageProducts)
        Me.TabControlProduction.Controls.Add(Me.TabPageProductDetails)
        Me.TabControlProduction.Location = New System.Drawing.Point(12, 27)
        Me.TabControlProduction.Name = "TabControlProduction"
        Me.TabControlProduction.SelectedIndex = 0
        Me.TabControlProduction.Size = New System.Drawing.Size(556, 331)
        Me.TabControlProduction.TabIndex = 2
        '
        'TabPageProducts
        '
        Me.TabPageProducts.Controls.Add(Me.dgvProducts)
        Me.TabPageProducts.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProducts.Name = "TabPageProducts"
        Me.TabPageProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProducts.Size = New System.Drawing.Size(548, 305)
        Me.TabPageProducts.TabIndex = 0
        Me.TabPageProducts.Text = "Products"
        Me.TabPageProducts.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(6, 91)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(536, 208)
        Me.dgvProducts.TabIndex = 0
        '
        'TabPageProductDetails
        '
        Me.TabPageProductDetails.Controls.Add(Me.TextBox2)
        Me.TabPageProductDetails.Controls.Add(Me.TextBox1)
        Me.TabPageProductDetails.Controls.Add(Me.Label1)
        Me.TabPageProductDetails.Controls.Add(Me.lblProductName)
        Me.TabPageProductDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProductDetails.Name = "TabPageProductDetails"
        Me.TabPageProductDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProductDetails.Size = New System.Drawing.Size(548, 305)
        Me.TabPageProductDetails.TabIndex = 1
        Me.TabPageProductDetails.Text = "Add Product"
        Me.TabPageProductDetails.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(257, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(6, 31)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(75, 13)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "Product Name"
        '
        'ProductionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(580, 383)
        Me.Controls.Add(Me.TabControlProduction)
        Me.Name = "ProductionForm"
        Me.Controls.SetChildIndex(Me.TabControlProduction, 0)
        Me.TabControlProduction.ResumeLayout(False)
        Me.TabPageProducts.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageProductDetails.ResumeLayout(False)
        Me.TabPageProductDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControlProduction As System.Windows.Forms.TabControl
    Friend WithEvents TabPageProducts As System.Windows.Forms.TabPage
    Friend WithEvents TabPageProductDetails As System.Windows.Forms.TabPage
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label

End Class
