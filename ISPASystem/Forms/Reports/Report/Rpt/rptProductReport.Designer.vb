<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptProductReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProductReport))
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.ProdTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdCateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reports = New ISPASystem.Reports
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ADProdCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ADVendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_ProductsTableAdapter = New ISPASystem.ReportsTableAdapters.AD_ProductsTableAdapter
        Me.AD_ProdCatTableAdapter = New ISPASystem.ReportsTableAdapters.AD_ProdCatTableAdapter
        Me.AD_VendorsTableAdapter = New ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ShowToolStripButton = New System.Windows.Forms.ToolStripButton
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADProdCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AD_ProductsDataGridView
        '
        Me.AD_ProductsDataGridView.AllowUserToAddRows = False
        Me.AD_ProductsDataGridView.AllowUserToDeleteRows = False
        Me.AD_ProductsDataGridView.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.AD_ProductsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AD_ProductsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_ProductsDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AD_ProductsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdTitleDataGridViewTextBoxColumn, Me.ProdUnitsDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.VendorDataGridViewTextBoxColumn, Me.ProdCateDataGridViewTextBoxColumn})
        Me.AD_ProductsDataGridView.DataSource = Me.ADProductsBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AD_ProductsDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.AD_ProductsDataGridView.GridColor = System.Drawing.Color.Red
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(6, 110)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.RowHeadersWidth = 20
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.ShowCellErrors = False
        Me.AD_ProductsDataGridView.ShowCellToolTips = False
        Me.AD_ProductsDataGridView.ShowEditingIcon = False
        Me.AD_ProductsDataGridView.ShowRowErrors = False
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(778, 444)
        Me.AD_ProductsDataGridView.TabIndex = 1
        '
        'ProdTitleDataGridViewTextBoxColumn
        '
        Me.ProdTitleDataGridViewTextBoxColumn.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTitleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProdTitleDataGridViewTextBoxColumn.Frozen = True
        Me.ProdTitleDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProdTitleDataGridViewTextBoxColumn.Name = "ProdTitleDataGridViewTextBoxColumn"
        Me.ProdTitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdTitleDataGridViewTextBoxColumn.Width = 300
        '
        'ProdUnitsDataGridViewTextBoxColumn
        '
        Me.ProdUnitsDataGridViewTextBoxColumn.DataPropertyName = "ProdUnits"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ProdUnitsDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ProdUnitsDataGridViewTextBoxColumn.HeaderText = "Unit In Stock"
        Me.ProdUnitsDataGridViewTextBoxColumn.Name = "ProdUnitsDataGridViewTextBoxColumn"
        Me.ProdUnitsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.UnitPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendorDataGridViewTextBoxColumn
        '
        Me.VendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.Name = "VendorDataGridViewTextBoxColumn"
        Me.VendorDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendorDataGridViewTextBoxColumn.Width = 300
        '
        'ProdCateDataGridViewTextBoxColumn
        '
        Me.ProdCateDataGridViewTextBoxColumn.DataPropertyName = "ProdCate"
        Me.ProdCateDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.ProdCateDataGridViewTextBoxColumn.Name = "ProdCateDataGridViewTextBoxColumn"
        Me.ProdCateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADProductsBindingSource
        '
        Me.ADProductsBindingSource.DataMember = "AD_Products"
        Me.ADProductsBindingSource.DataSource = Me.Reports
        '
        'Reports
        '
        Me.Reports.DataSetName = "Reports"
        Me.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All", "Under Value", "Vendor", "Category"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ADProdCatBindingSource
        Me.ComboBox2.DisplayMember = "ProdCatTitle"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(195, 83)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "ProdCatTitle"
        '
        'ADProdCatBindingSource
        '
        Me.ADProdCatBindingSource.DataMember = "AD_ProdCat"
        Me.ADProdCatBindingSource.DataSource = Me.ReportsBindingSource
        '
        'ReportsBindingSource
        '
        Me.ReportsBindingSource.DataSource = Me.Reports
        Me.ReportsBindingSource.Position = 0
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ADVendorsBindingSource
        Me.ComboBox3.DisplayMember = "VendTitle"
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(399, 83)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(209, 21)
        Me.ComboBox3.TabIndex = 4
        Me.ComboBox3.ValueMember = "VendTitle"
        '
        'ADVendorsBindingSource
        '
        Me.ADVendorsBindingSource.DataMember = "AD_Vendors"
        Me.ADVendorsBindingSource.DataSource = Me.ReportsBindingSource
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'AD_ProdCatTableAdapter
        '
        Me.AD_ProdCatTableAdapter.ClearBeforeFill = True
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Show By:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Select Vendor:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(792, 33)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Product Report"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 25
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
        'rptProductReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "rptProductReport"
        Me.Text = "Products Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADProdCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Reports As ISPASystem.Reports
    Friend WithEvents ADProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ReportsTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ADProdCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProdCatTableAdapter As ISPASystem.ReportsTableAdapters.AD_ProdCatTableAdapter
    Friend WithEvents ADVendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProdTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdCateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ShowToolStripButton As System.Windows.Forms.ToolStripButton
End Class
