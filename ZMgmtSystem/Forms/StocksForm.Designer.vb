<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocksForm
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
        Me.TabControlStocks = New System.Windows.Forms.TabControl()
        Me.TabPageStocks = New System.Windows.Forms.TabPage()
        Me.cboStockSearch = New System.Windows.Forms.ComboBox()
        Me.btnStockUpdate = New System.Windows.Forms.Button()
        Me.dgvStocks = New System.Windows.Forms.DataGridView()
        Me.cat_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_measure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpCategories = New System.Windows.Forms.TabPage()
        Me.pictureCat = New System.Windows.Forms.PictureBox()
        Me.txtCatDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCatName = New System.Windows.Forms.TextBox()
        Me.lblCatName = New System.Windows.Forms.Label()
        Me.btnSaveCat = New System.Windows.Forms.Button()
        Me.btnAddNewCat = New System.Windows.Forms.Button()
        Me.btnSearchCat = New System.Windows.Forms.Button()
        Me.cboCatSearch = New System.Windows.Forms.ComboBox()
        Me.lblSearchCat = New System.Windows.Forms.Label()
        Me.TabPageAdd = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUnitsInProduction = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnitsInStock = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboUnitMeasure = New System.Windows.Forms.ComboBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNewStock = New System.Windows.Forms.Button()
        Me.lblSearchStock = New System.Windows.Forms.Label()
        Me.cboStockItem = New System.Windows.Forms.ComboBox()
        Me.TabPageTransfer = New System.Windows.Forms.TabPage()
        Me.btnTransferToProduction = New System.Windows.Forms.Button()
        Me.dgvAddedToProduction = New System.Windows.Forms.DataGridView()
        Me.stock_cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tstock_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tstock_units = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tstock_unitmeasure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.cboSearchAddItem = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveStock = New System.Windows.Forms.Button()
        Me.TabControlStocks.SuspendLayout()
        Me.TabPageStocks.SuspendLayout()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCategories.SuspendLayout()
        CType(Me.pictureCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAdd.SuspendLayout()
        Me.TabPageTransfer.SuspendLayout()
        CType(Me.dgvAddedToProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlStocks
        '
        Me.TabControlStocks.Controls.Add(Me.TabPageStocks)
        Me.TabControlStocks.Controls.Add(Me.tpCategories)
        Me.TabControlStocks.Controls.Add(Me.TabPageAdd)
        Me.TabControlStocks.Controls.Add(Me.TabPageTransfer)
        Me.TabControlStocks.Location = New System.Drawing.Point(12, 27)
        Me.TabControlStocks.Name = "TabControlStocks"
        Me.TabControlStocks.SelectedIndex = 0
        Me.TabControlStocks.Size = New System.Drawing.Size(620, 331)
        Me.TabControlStocks.TabIndex = 2
        '
        'TabPageStocks
        '
        Me.TabPageStocks.Controls.Add(Me.cboStockSearch)
        Me.TabPageStocks.Controls.Add(Me.btnStockUpdate)
        Me.TabPageStocks.Controls.Add(Me.dgvStocks)
        Me.TabPageStocks.Location = New System.Drawing.Point(4, 22)
        Me.TabPageStocks.Name = "TabPageStocks"
        Me.TabPageStocks.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStocks.Size = New System.Drawing.Size(612, 305)
        Me.TabPageStocks.TabIndex = 0
        Me.TabPageStocks.Text = "Stocks"
        Me.TabPageStocks.UseVisualStyleBackColor = True
        '
        'cboStockSearch
        '
        Me.cboStockSearch.FormattingEnabled = True
        Me.cboStockSearch.Location = New System.Drawing.Point(6, 8)
        Me.cboStockSearch.Name = "cboStockSearch"
        Me.cboStockSearch.Size = New System.Drawing.Size(519, 21)
        Me.cboStockSearch.TabIndex = 5
        '
        'btnStockUpdate
        '
        Me.btnStockUpdate.Location = New System.Drawing.Point(531, 6)
        Me.btnStockUpdate.Name = "btnStockUpdate"
        Me.btnStockUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnStockUpdate.TabIndex = 4
        Me.btnStockUpdate.Text = "Update"
        Me.btnStockUpdate.UseVisualStyleBackColor = True
        '
        'dgvStocks
        '
        Me.dgvStocks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStocks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cat_name, Me.stock_name, Me.unit_measure, Me.unit_price, Me.stock_qty, Me.total_price})
        Me.dgvStocks.Location = New System.Drawing.Point(6, 35)
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.RowHeadersVisible = False
        Me.dgvStocks.Size = New System.Drawing.Size(600, 264)
        Me.dgvStocks.TabIndex = 0
        '
        'cat_name
        '
        Me.cat_name.HeaderText = "Category"
        Me.cat_name.Name = "cat_name"
        '
        'stock_name
        '
        Me.stock_name.HeaderText = "Stock"
        Me.stock_name.Name = "stock_name"
        '
        'unit_measure
        '
        Me.unit_measure.HeaderText = "Unit"
        Me.unit_measure.Name = "unit_measure"
        '
        'unit_price
        '
        Me.unit_price.HeaderText = "Unit Price"
        Me.unit_price.Name = "unit_price"
        '
        'stock_qty
        '
        Me.stock_qty.HeaderText = "Units Available"
        Me.stock_qty.Name = "stock_qty"
        '
        'total_price
        '
        Me.total_price.HeaderText = "Total Price"
        Me.total_price.Name = "total_price"
        '
        'tpCategories
        '
        Me.tpCategories.Controls.Add(Me.pictureCat)
        Me.tpCategories.Controls.Add(Me.txtCatDesc)
        Me.tpCategories.Controls.Add(Me.Label3)
        Me.tpCategories.Controls.Add(Me.txtCatName)
        Me.tpCategories.Controls.Add(Me.lblCatName)
        Me.tpCategories.Controls.Add(Me.btnSaveCat)
        Me.tpCategories.Controls.Add(Me.btnAddNewCat)
        Me.tpCategories.Controls.Add(Me.btnSearchCat)
        Me.tpCategories.Controls.Add(Me.cboCatSearch)
        Me.tpCategories.Controls.Add(Me.lblSearchCat)
        Me.tpCategories.Location = New System.Drawing.Point(4, 22)
        Me.tpCategories.Name = "tpCategories"
        Me.tpCategories.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCategories.Size = New System.Drawing.Size(612, 305)
        Me.tpCategories.TabIndex = 1
        Me.tpCategories.Text = "Categories"
        Me.tpCategories.UseVisualStyleBackColor = True
        '
        'pictureCat
        '
        Me.pictureCat.Location = New System.Drawing.Point(377, 80)
        Me.pictureCat.Name = "pictureCat"
        Me.pictureCat.Size = New System.Drawing.Size(100, 100)
        Me.pictureCat.TabIndex = 6
        Me.pictureCat.TabStop = False
        '
        'txtCatDesc
        '
        Me.txtCatDesc.Location = New System.Drawing.Point(9, 149)
        Me.txtCatDesc.Multiline = True
        Me.txtCatDesc.Name = "txtCatDesc"
        Me.txtCatDesc.Size = New System.Drawing.Size(334, 65)
        Me.txtCatDesc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category Description:"
        '
        'txtCatName
        '
        Me.txtCatName.Location = New System.Drawing.Point(9, 110)
        Me.txtCatName.Name = "txtCatName"
        Me.txtCatName.Size = New System.Drawing.Size(334, 20)
        Me.txtCatName.TabIndex = 5
        '
        'lblCatName
        '
        Me.lblCatName.AutoSize = True
        Me.lblCatName.Location = New System.Drawing.Point(6, 94)
        Me.lblCatName.Name = "lblCatName"
        Me.lblCatName.Size = New System.Drawing.Size(83, 13)
        Me.lblCatName.TabIndex = 4
        Me.lblCatName.Text = "Category Name:"
        '
        'btnSaveCat
        '
        Me.btnSaveCat.Location = New System.Drawing.Point(430, 255)
        Me.btnSaveCat.Name = "btnSaveCat"
        Me.btnSaveCat.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCat.TabIndex = 3
        Me.btnSaveCat.Text = "Save"
        Me.btnSaveCat.UseVisualStyleBackColor = True
        '
        'btnAddNewCat
        '
        Me.btnAddNewCat.Location = New System.Drawing.Point(430, 49)
        Me.btnAddNewCat.Name = "btnAddNewCat"
        Me.btnAddNewCat.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNewCat.TabIndex = 3
        Me.btnAddNewCat.Text = "Add New"
        Me.btnAddNewCat.UseVisualStyleBackColor = True
        '
        'btnSearchCat
        '
        Me.btnSearchCat.Location = New System.Drawing.Point(349, 49)
        Me.btnSearchCat.Name = "btnSearchCat"
        Me.btnSearchCat.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchCat.TabIndex = 2
        Me.btnSearchCat.Text = "Search"
        Me.btnSearchCat.UseVisualStyleBackColor = True
        '
        'cboCatSearch
        '
        Me.cboCatSearch.FormattingEnabled = True
        Me.cboCatSearch.Location = New System.Drawing.Point(9, 51)
        Me.cboCatSearch.Name = "cboCatSearch"
        Me.cboCatSearch.Size = New System.Drawing.Size(334, 21)
        Me.cboCatSearch.TabIndex = 1
        '
        'lblSearchCat
        '
        Me.lblSearchCat.AutoSize = True
        Me.lblSearchCat.Location = New System.Drawing.Point(6, 35)
        Me.lblSearchCat.Name = "lblSearchCat"
        Me.lblSearchCat.Size = New System.Drawing.Size(86, 13)
        Me.lblSearchCat.TabIndex = 0
        Me.lblSearchCat.Text = "Category Search"
        '
        'TabPageAdd
        '
        Me.TabPageAdd.Controls.Add(Me.btnSaveStock)
        Me.TabPageAdd.Controls.Add(Me.TextBox2)
        Me.TabPageAdd.Controls.Add(Me.Label4)
        Me.TabPageAdd.Controls.Add(Me.txtUnitsInProduction)
        Me.TabPageAdd.Controls.Add(Me.Label5)
        Me.TabPageAdd.Controls.Add(Me.txtUnitsInStock)
        Me.TabPageAdd.Controls.Add(Me.lblUnits)
        Me.TabPageAdd.Controls.Add(Me.Label2)
        Me.TabPageAdd.Controls.Add(Me.cboUnitMeasure)
        Me.TabPageAdd.Controls.Add(Me.lblItemName)
        Me.TabPageAdd.Controls.Add(Me.TextBox1)
        Me.TabPageAdd.Controls.Add(Me.cboCategory)
        Me.TabPageAdd.Controls.Add(Me.Label1)
        Me.TabPageAdd.Controls.Add(Me.btnAddNewStock)
        Me.TabPageAdd.Controls.Add(Me.lblSearchStock)
        Me.TabPageAdd.Controls.Add(Me.cboStockItem)
        Me.TabPageAdd.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAdd.Name = "TabPageAdd"
        Me.TabPageAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAdd.Size = New System.Drawing.Size(612, 305)
        Me.TabPageAdd.TabIndex = 2
        Me.TabPageAdd.Text = "Stock In"
        Me.TabPageAdd.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 221)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Unit Price"
        '
        'txtUnitsInProduction
        '
        Me.txtUnitsInProduction.Location = New System.Drawing.Point(425, 205)
        Me.txtUnitsInProduction.Name = "txtUnitsInProduction"
        Me.txtUnitsInProduction.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitsInProduction.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Units In Production"
        '
        'txtUnitsInStock
        '
        Me.txtUnitsInStock.Location = New System.Drawing.Point(425, 160)
        Me.txtUnitsInStock.Name = "txtUnitsInStock"
        Me.txtUnitsInStock.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitsInStock.TabIndex = 11
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(422, 144)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(74, 13)
        Me.lblUnits.TabIndex = 10
        Me.lblUnits.Text = "Units In Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Unit Of Measurement"
        '
        'cboUnitMeasure
        '
        Me.cboUnitMeasure.FormattingEnabled = True
        Me.cboUnitMeasure.Location = New System.Drawing.Point(280, 160)
        Me.cboUnitMeasure.Name = "cboUnitMeasure"
        Me.cboUnitMeasure.Size = New System.Drawing.Size(121, 21)
        Me.cboUnitMeasure.TabIndex = 8
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(6, 144)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(66, 13)
        Me.lblItemName.TabIndex = 7
        Me.lblItemName.Text = "Stock Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 20)
        Me.TextBox1.TabIndex = 6
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(6, 105)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(226, 21)
        Me.cboCategory.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Category"
        '
        'btnAddNewStock
        '
        Me.btnAddNewStock.Location = New System.Drawing.Point(450, 43)
        Me.btnAddNewStock.Name = "btnAddNewStock"
        Me.btnAddNewStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNewStock.TabIndex = 3
        Me.btnAddNewStock.Text = "Add New"
        Me.btnAddNewStock.UseVisualStyleBackColor = True
        '
        'lblSearchStock
        '
        Me.lblSearchStock.AutoSize = True
        Me.lblSearchStock.Location = New System.Drawing.Point(6, 29)
        Me.lblSearchStock.Name = "lblSearchStock"
        Me.lblSearchStock.Size = New System.Drawing.Size(41, 13)
        Me.lblSearchStock.TabIndex = 1
        Me.lblSearchStock.Text = "Search"
        '
        'cboStockItem
        '
        Me.cboStockItem.FormattingEnabled = True
        Me.cboStockItem.Location = New System.Drawing.Point(6, 45)
        Me.cboStockItem.Name = "cboStockItem"
        Me.cboStockItem.Size = New System.Drawing.Size(438, 21)
        Me.cboStockItem.TabIndex = 0
        '
        'TabPageTransfer
        '
        Me.TabPageTransfer.Controls.Add(Me.btnTransferToProduction)
        Me.TabPageTransfer.Controls.Add(Me.dgvAddedToProduction)
        Me.TabPageTransfer.Controls.Add(Me.btnAddStock)
        Me.TabPageTransfer.Controls.Add(Me.cboSearchAddItem)
        Me.TabPageTransfer.Controls.Add(Me.Label6)
        Me.TabPageTransfer.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTransfer.Name = "TabPageTransfer"
        Me.TabPageTransfer.Size = New System.Drawing.Size(612, 305)
        Me.TabPageTransfer.TabIndex = 3
        Me.TabPageTransfer.Text = "Transfer"
        Me.TabPageTransfer.UseVisualStyleBackColor = True
        '
        'btnTransferToProduction
        '
        Me.btnTransferToProduction.Location = New System.Drawing.Point(510, 48)
        Me.btnTransferToProduction.Name = "btnTransferToProduction"
        Me.btnTransferToProduction.Size = New System.Drawing.Size(99, 23)
        Me.btnTransferToProduction.TabIndex = 5
        Me.btnTransferToProduction.Text = "To Production"
        Me.btnTransferToProduction.UseVisualStyleBackColor = True
        '
        'dgvAddedToProduction
        '
        Me.dgvAddedToProduction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvAddedToProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddedToProduction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stock_cat, Me.tstock_name, Me.tstock_units, Me.tstock_unitmeasure})
        Me.dgvAddedToProduction.Location = New System.Drawing.Point(18, 77)
        Me.dgvAddedToProduction.Name = "dgvAddedToProduction"
        Me.dgvAddedToProduction.RowHeadersVisible = False
        Me.dgvAddedToProduction.Size = New System.Drawing.Size(591, 225)
        Me.dgvAddedToProduction.TabIndex = 4
        '
        'stock_cat
        '
        Me.stock_cat.HeaderText = "Category"
        Me.stock_cat.Name = "stock_cat"
        '
        'tstock_name
        '
        Me.tstock_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tstock_name.FillWeight = 300.0!
        Me.tstock_name.HeaderText = "Stock"
        Me.tstock_name.Name = "tstock_name"
        '
        'tstock_units
        '
        Me.tstock_units.HeaderText = "Quantity / Units"
        Me.tstock_units.Name = "tstock_units"
        '
        'tstock_unitmeasure
        '
        Me.tstock_unitmeasure.HeaderText = "Unit Of Measurement"
        Me.tstock_unitmeasure.Name = "tstock_unitmeasure"
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(429, 48)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStock.TabIndex = 3
        Me.btnAddStock.Text = "Add"
        Me.btnAddStock.UseVisualStyleBackColor = True
        '
        'cboSearchAddItem
        '
        Me.cboSearchAddItem.FormattingEnabled = True
        Me.cboSearchAddItem.Location = New System.Drawing.Point(18, 50)
        Me.cboSearchAddItem.Name = "cboSearchAddItem"
        Me.cboSearchAddItem.Size = New System.Drawing.Size(405, 21)
        Me.cboSearchAddItem.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Search"
        '
        'btnSaveStock
        '
        Me.btnSaveStock.Location = New System.Drawing.Point(450, 231)
        Me.btnSaveStock.Name = "btnSaveStock"
        Me.btnSaveStock.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveStock.TabIndex = 14
        Me.btnSaveStock.Text = "Save"
        Me.btnSaveStock.UseVisualStyleBackColor = True
        '
        'StocksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(644, 383)
        Me.Controls.Add(Me.TabControlStocks)
        Me.Name = "StocksForm"
        Me.Controls.SetChildIndex(Me.TabControlStocks, 0)
        Me.TabControlStocks.ResumeLayout(False)
        Me.TabPageStocks.ResumeLayout(False)
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCategories.ResumeLayout(False)
        Me.tpCategories.PerformLayout()
        CType(Me.pictureCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAdd.ResumeLayout(False)
        Me.TabPageAdd.PerformLayout()
        Me.TabPageTransfer.ResumeLayout(False)
        Me.TabPageTransfer.PerformLayout()
        CType(Me.dgvAddedToProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControlStocks As System.Windows.Forms.TabControl
    Friend WithEvents TabPageStocks As System.Windows.Forms.TabPage
    Friend WithEvents tpCategories As System.Windows.Forms.TabPage
    Friend WithEvents pictureCat As System.Windows.Forms.PictureBox
    Friend WithEvents txtCatDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCatName As System.Windows.Forms.TextBox
    Friend WithEvents lblCatName As System.Windows.Forms.Label
    Friend WithEvents btnSaveCat As System.Windows.Forms.Button
    Friend WithEvents btnAddNewCat As System.Windows.Forms.Button
    Friend WithEvents btnSearchCat As System.Windows.Forms.Button
    Friend WithEvents cboCatSearch As System.Windows.Forms.ComboBox
    Friend WithEvents lblSearchCat As System.Windows.Forms.Label
    Friend WithEvents cboStockSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnStockUpdate As System.Windows.Forms.Button
    Friend WithEvents dgvStocks As System.Windows.Forms.DataGridView
    Friend WithEvents cat_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_measure As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPageAdd As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUnitsInStock As System.Windows.Forms.TextBox
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboUnitMeasure As System.Windows.Forms.ComboBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddNewStock As System.Windows.Forms.Button
    Friend WithEvents lblSearchStock As System.Windows.Forms.Label
    Friend WithEvents cboStockItem As System.Windows.Forms.ComboBox
    Friend WithEvents TabPageTransfer As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitsInProduction As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnTransferToProduction As System.Windows.Forms.Button
    Friend WithEvents dgvAddedToProduction As System.Windows.Forms.DataGridView
    Friend WithEvents stock_cat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tstock_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tstock_units As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tstock_unitmeasure As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddStock As System.Windows.Forms.Button
    Friend WithEvents cboSearchAddItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSaveStock As System.Windows.Forms.Button
   
End Class
