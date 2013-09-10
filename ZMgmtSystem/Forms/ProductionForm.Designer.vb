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
        Me.btnUnitsDialog = New System.Windows.Forms.Button()
        Me.cboUnitOfMeasure = New System.Windows.Forms.ComboBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNewProduct = New System.Windows.Forms.Button()
        Me.cboSearchProducts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
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
        Me.TabPageProductDetails.Controls.Add(Me.btnUnitsDialog)
        Me.TabPageProductDetails.Controls.Add(Me.cboUnitOfMeasure)
        Me.TabPageProductDetails.Controls.Add(Me.txtUnitPrice)
        Me.TabPageProductDetails.Controls.Add(Me.Label1)
        Me.TabPageProductDetails.Controls.Add(Me.btnAddNewProduct)
        Me.TabPageProductDetails.Controls.Add(Me.cboSearchProducts)
        Me.TabPageProductDetails.Controls.Add(Me.Label2)
        Me.TabPageProductDetails.Controls.Add(Me.txtQuantity)
        Me.TabPageProductDetails.Controls.Add(Me.txtProductName)
        Me.TabPageProductDetails.Controls.Add(Me.Label3)
        Me.TabPageProductDetails.Controls.Add(Me.lblQuantity)
        Me.TabPageProductDetails.Controls.Add(Me.lblProductName)
        Me.TabPageProductDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProductDetails.Name = "TabPageProductDetails"
        Me.TabPageProductDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProductDetails.Size = New System.Drawing.Size(548, 305)
        Me.TabPageProductDetails.TabIndex = 1
        Me.TabPageProductDetails.Text = "Product Details"
        Me.TabPageProductDetails.UseVisualStyleBackColor = True
        '
        'btnUnitsDialog
        '
        Me.btnUnitsDialog.Location = New System.Drawing.Point(127, 125)
        Me.btnUnitsDialog.Name = "btnUnitsDialog"
        Me.btnUnitsDialog.Size = New System.Drawing.Size(32, 23)
        Me.btnUnitsDialog.TabIndex = 8
        Me.btnUnitsDialog.Text = "..."
        Me.btnUnitsDialog.UseVisualStyleBackColor = True
        '
        'cboUnitOfMeasure
        '
        Me.cboUnitOfMeasure.FormattingEnabled = True
        Me.cboUnitOfMeasure.Location = New System.Drawing.Point(58, 127)
        Me.cboUnitOfMeasure.Name = "cboUnitOfMeasure"
        Me.cboUnitOfMeasure.Size = New System.Drawing.Size(63, 21)
        Me.cboUnitOfMeasure.TabIndex = 7
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(165, 127)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitPrice.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unit Price"
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.Location = New System.Drawing.Point(285, 36)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNewProduct.TabIndex = 4
        Me.btnAddNewProduct.Text = "Add New"
        Me.btnAddNewProduct.UseVisualStyleBackColor = True
        '
        'cboSearchProducts
        '
        Me.cboSearchProducts.FormattingEnabled = True
        Me.cboSearchProducts.Location = New System.Drawing.Point(9, 38)
        Me.cboSearchProducts.Name = "cboSearchProducts"
        Me.cboSearchProducts.Size = New System.Drawing.Size(256, 21)
        Me.cboSearchProducts.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(9, 127)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(43, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(9, 88)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(257, 20)
        Me.txtProductName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unit"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(6, 111)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(6, 72)
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
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents btnAddNewProduct As System.Windows.Forms.Button
    Friend WithEvents cboSearchProducts As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboUnitOfMeasure As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUnitsDialog As System.Windows.Forms.Button

End Class
