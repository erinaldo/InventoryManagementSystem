<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptLedgerReport
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptLedgerReport))
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.TDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LedgerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reports = New ISPASystem.Reports
        Me.LedgerTableAdapter = New ISPASystem.ReportsTableAdapters.LedgerTableAdapter
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox
        Me.ADCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_CustomersTableAdapter = New ISPASystem.ReportsTableAdapters.AD_CustomersTableAdapter
        Me.VendorComboBox = New System.Windows.Forms.ComboBox
        Me.ADVendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_VendorsTableAdapter = New ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
        Me.SelectComboBox = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ShowToolStripButton = New System.Windows.Forms.ToolStripButton
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LedgerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.AD_ProductsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AD_ProductsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_ProductsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TDateDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn})
        Me.AD_ProductsDataGridView.DataSource = Me.LedgerBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AD_ProductsDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.AD_ProductsDataGridView.GridColor = System.Drawing.Color.Red
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(14, 142)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.RowHeadersWidth = 20
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.ShowCellErrors = False
        Me.AD_ProductsDataGridView.ShowCellToolTips = False
        Me.AD_ProductsDataGridView.ShowEditingIcon = False
        Me.AD_ProductsDataGridView.ShowRowErrors = False
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(766, 412)
        Me.AD_ProductsDataGridView.StandardTab = True
        Me.AD_ProductsDataGridView.TabIndex = 4
        '
        'TDateDataGridViewTextBoxColumn
        '
        Me.TDateDataGridViewTextBoxColumn.DataPropertyName = "TDate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.TDateDataGridViewTextBoxColumn.Name = "TDateDataGridViewTextBoxColumn"
        Me.TDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetailsDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "Detail"
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetailsDataGridViewTextBoxColumn.Width = 300
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "Debit"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DebitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit(Rs)"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "Credit"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        Me.CreditDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit(Rs)"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LedgerBindingSource
        '
        Me.LedgerBindingSource.DataMember = "Ledger"
        Me.LedgerBindingSource.DataSource = Me.Reports
        '
        'Reports
        '
        Me.Reports.DataSetName = "Reports"
        Me.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LedgerTableAdapter
        '
        Me.LedgerTableAdapter.ClearBeforeFill = True
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.DataSource = Me.ADCustomersBindingSource
        Me.CustomerComboBox.DisplayMember = "CustTitle"
        Me.CustomerComboBox.Enabled = False
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(141, 88)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(278, 21)
        Me.CustomerComboBox.TabIndex = 5
        Me.CustomerComboBox.ValueMember = "CustTitle"
        '
        'ADCustomersBindingSource
        '
        Me.ADCustomersBindingSource.DataMember = "AD_Customers"
        Me.ADCustomersBindingSource.DataSource = Me.Reports
        '
        'AD_CustomersTableAdapter
        '
        Me.AD_CustomersTableAdapter.ClearBeforeFill = True
        '
        'VendorComboBox
        '
        Me.VendorComboBox.DataSource = Me.ADVendorsBindingSource
        Me.VendorComboBox.DisplayMember = "VendTitle"
        Me.VendorComboBox.Enabled = False
        Me.VendorComboBox.FormattingEnabled = True
        Me.VendorComboBox.Location = New System.Drawing.Point(141, 115)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(278, 21)
        Me.VendorComboBox.TabIndex = 6
        Me.VendorComboBox.ValueMember = "VendTitle"
        '
        'ADVendorsBindingSource
        '
        Me.ADVendorsBindingSource.DataMember = "AD_Vendors"
        Me.ADVendorsBindingSource.DataSource = Me.Reports
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'SelectComboBox
        '
        Me.SelectComboBox.FormattingEnabled = True
        Me.SelectComboBox.Items.AddRange(New Object() {"Customer Ledger", "Vendor Ledger", "General Ledger"})
        Me.SelectComboBox.Location = New System.Drawing.Point(141, 61)
        Me.SelectComboBox.Name = "SelectComboBox"
        Me.SelectComboBox.Size = New System.Drawing.Size(278, 21)
        Me.SelectComboBox.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(488, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(488, 87)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select Ledger Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Select Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Select Vendor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "From:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(792, 33)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Ledger Report"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'rptLedgerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.AD_ProductsDataGridView)
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
        Me.Name = "rptLedgerReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ledgers Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LedgerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Reports As ISPASystem.Reports
    Friend WithEvents LedgerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LedgerTableAdapter As ISPASystem.ReportsTableAdapters.LedgerTableAdapter
    Friend WithEvents CustomerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ADCustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ReportsTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents VendorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ADVendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents SelectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ShowToolStripButton As System.Windows.Forms.ToolStripButton
End Class
