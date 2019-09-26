<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesReport))
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.SInvNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SIDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdCateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaleInvoiceDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reports = New ISPASystem.Reports
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.SelectComboBox = New System.Windows.Forms.ComboBox
        Me.VendorComboBox = New System.Windows.Forms.ComboBox
        Me.ADVendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox
        Me.ADCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.ProductComboBox = New System.Windows.Forms.ComboBox
        Me.ADProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_CustomersTableAdapter = New ISPASystem.ReportsTableAdapters.AD_CustomersTableAdapter
        Me.AD_ProductsTableAdapter = New ISPASystem.ReportsTableAdapters.AD_ProductsTableAdapter
        Me.AD_VendorsTableAdapter = New ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
        Me.SaleInvoice_DTableAdapter = New ISPASystem.ReportsTableAdapters.SaleInvoice_DTableAdapter
        Me.Label7 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ShowToolStripButton = New System.Windows.Forms.ToolStripButton
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoiceDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AD_ProductsDataGridView
        '
        Me.AD_ProductsDataGridView.AllowUserToAddRows = False
        Me.AD_ProductsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.AD_ProductsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.AD_ProductsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_ProductsDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AD_ProductsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SInvNoDataGridViewTextBoxColumn, Me.SIDateDataGridViewTextBoxColumn, Me.CustNameDataGridViewTextBoxColumn, Me.ProdTitleDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.VendorDataGridViewTextBoxColumn, Me.ProdCateDataGridViewTextBoxColumn})
        Me.AD_ProductsDataGridView.DataSource = Me.SaleInvoiceDBindingSource
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AD_ProductsDataGridView.DefaultCellStyle = DataGridViewCellStyle20
        Me.AD_ProductsDataGridView.GridColor = System.Drawing.Color.Red
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(6, 165)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.RowHeadersWidth = 20
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.ShowCellErrors = False
        Me.AD_ProductsDataGridView.ShowCellToolTips = False
        Me.AD_ProductsDataGridView.ShowEditingIcon = False
        Me.AD_ProductsDataGridView.ShowRowErrors = False
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(775, 389)
        Me.AD_ProductsDataGridView.TabIndex = 2
        '
        'SInvNoDataGridViewTextBoxColumn
        '
        Me.SInvNoDataGridViewTextBoxColumn.DataPropertyName = "SInvNo"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SInvNoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.SInvNoDataGridViewTextBoxColumn.Frozen = True
        Me.SInvNoDataGridViewTextBoxColumn.HeaderText = "InVoice No"
        Me.SInvNoDataGridViewTextBoxColumn.Name = "SInvNoDataGridViewTextBoxColumn"
        Me.SInvNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SIDateDataGridViewTextBoxColumn
        '
        Me.SIDateDataGridViewTextBoxColumn.DataPropertyName = "SIDate"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.SIDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.SIDateDataGridViewTextBoxColumn.Frozen = True
        Me.SIDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.SIDateDataGridViewTextBoxColumn.Name = "SIDateDataGridViewTextBoxColumn"
        Me.SIDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustNameDataGridViewTextBoxColumn
        '
        Me.CustNameDataGridViewTextBoxColumn.DataPropertyName = "CustName"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.CustNameDataGridViewTextBoxColumn.Frozen = True
        Me.CustNameDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustNameDataGridViewTextBoxColumn.Name = "CustNameDataGridViewTextBoxColumn"
        Me.CustNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdTitleDataGridViewTextBoxColumn
        '
        Me.ProdTitleDataGridViewTextBoxColumn.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProdTitleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.ProdTitleDataGridViewTextBoxColumn.Frozen = True
        Me.ProdTitleDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProdTitleDataGridViewTextBoxColumn.Name = "ProdTitleDataGridViewTextBoxColumn"
        Me.ProdTitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdTitleDataGridViewTextBoxColumn.Width = 250
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.UnitPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price(Rs)"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.TotalCostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost(Rs)"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        Me.TotalCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendorDataGridViewTextBoxColumn
        '
        Me.VendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.Name = "VendorDataGridViewTextBoxColumn"
        Me.VendorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdCateDataGridViewTextBoxColumn
        '
        Me.ProdCateDataGridViewTextBoxColumn.DataPropertyName = "ProdCate"
        Me.ProdCateDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.ProdCateDataGridViewTextBoxColumn.Name = "ProdCateDataGridViewTextBoxColumn"
        Me.ProdCateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleInvoiceDBindingSource
        '
        Me.SaleInvoiceDBindingSource.DataMember = "SaleInvoice_D"
        Me.SaleInvoiceDBindingSource.DataSource = Me.Reports
        '
        'Reports
        '
        Me.Reports.DataSetName = "Reports"
        Me.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Select Vendor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Select Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Select Search Type"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(489, 86)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker2.TabIndex = 20
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(489, 60)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'SelectComboBox
        '
        Me.SelectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SelectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SelectComboBox.FormattingEnabled = True
        Me.SelectComboBox.Items.AddRange(New Object() {"Dale Search", "Customer Search", "Product Search", "Vendor Search"})
        Me.SelectComboBox.Location = New System.Drawing.Point(142, 62)
        Me.SelectComboBox.Name = "SelectComboBox"
        Me.SelectComboBox.Size = New System.Drawing.Size(250, 21)
        Me.SelectComboBox.TabIndex = 18
        '
        'VendorComboBox
        '
        Me.VendorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.VendorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.VendorComboBox.DataSource = Me.ADVendorsBindingSource
        Me.VendorComboBox.DisplayMember = "VendTitle"
        Me.VendorComboBox.Enabled = False
        Me.VendorComboBox.FormattingEnabled = True
        Me.VendorComboBox.Location = New System.Drawing.Point(142, 138)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(250, 21)
        Me.VendorComboBox.TabIndex = 17
        Me.VendorComboBox.ValueMember = "VendTitle"
        '
        'ADVendorsBindingSource
        '
        Me.ADVendorsBindingSource.DataMember = "AD_Vendors"
        Me.ADVendorsBindingSource.DataSource = Me.Reports
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CustomerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerComboBox.DataSource = Me.ADCustomersBindingSource
        Me.CustomerComboBox.DisplayMember = "CustTitle"
        Me.CustomerComboBox.Enabled = False
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(142, 87)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(250, 21)
        Me.CustomerComboBox.TabIndex = 16
        Me.CustomerComboBox.ValueMember = "CustTitle"
        '
        'ADCustomersBindingSource
        '
        Me.ADCustomersBindingSource.DataMember = "AD_Customers"
        Me.ADCustomersBindingSource.DataSource = Me.Reports
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Select Product"
        '
        'ProductComboBox
        '
        Me.ProductComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProductComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProductComboBox.DataSource = Me.ADProductsBindingSource
        Me.ProductComboBox.DisplayMember = "ProdTitle"
        Me.ProductComboBox.Enabled = False
        Me.ProductComboBox.FormattingEnabled = True
        Me.ProductComboBox.Location = New System.Drawing.Point(142, 113)
        Me.ProductComboBox.Name = "ProductComboBox"
        Me.ProductComboBox.Size = New System.Drawing.Size(250, 21)
        Me.ProductComboBox.TabIndex = 26
        Me.ProductComboBox.ValueMember = "ProdTitle"
        '
        'ADProductsBindingSource
        '
        Me.ADProductsBindingSource.DataMember = "AD_Products"
        Me.ADProductsBindingSource.DataSource = Me.Reports
        '
        'AD_CustomersTableAdapter
        '
        Me.AD_CustomersTableAdapter.ClearBeforeFill = True
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'SaleInvoice_DTableAdapter
        '
        Me.SaleInvoice_DTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(792, 33)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Sales Report"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ShowToolStripButton
        '
        Me.ShowToolStripButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToolStripButton.Image = CType(resources.GetObject("ShowToolStripButton.Image"), System.Drawing.Image)
        Me.ShowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowToolStripButton.Name = "ShowToolStripButton"
        Me.ShowToolStripButton.Size = New System.Drawing.Size(57, 22)
        Me.ShowToolStripButton.Text = "Show"
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProductComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.SelectComboBox)
        Me.Controls.Add(Me.VendorComboBox)
        Me.Controls.Add(Me.CustomerComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSalesReport"
        Me.Text = "Sales Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoiceDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SelectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VendorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProductComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Reports As ISPASystem.Reports
    Friend WithEvents ADCustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ReportsTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents ADProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ReportsTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents ADVendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents SaleInvoiceDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleInvoice_DTableAdapter As ISPASystem.ReportsTableAdapters.SaleInvoice_DTableAdapter
    Friend WithEvents SInvNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdCateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ShowToolStripButton As System.Windows.Forms.ToolStripButton
End Class
