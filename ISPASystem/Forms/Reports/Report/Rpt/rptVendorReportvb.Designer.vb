<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendorReportvb
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendorReportvb))
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.VendTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendOffNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADVendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reports = New ISPASystem.Reports
        Me.AD_VendorsTableAdapter = New ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ShowToolStripButton = New System.Windows.Forms.ToolStripButton
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AD_ProductsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendTitleDataGridViewTextBoxColumn, Me.ContactPersonDataGridViewTextBoxColumn, Me.VendAddressDataGridViewTextBoxColumn, Me.VendOffNoDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn})
        Me.AD_ProductsDataGridView.DataSource = Me.ADVendorsBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AD_ProductsDataGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.AD_ProductsDataGridView.GridColor = System.Drawing.Color.Red
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(6, 61)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.RowHeadersWidth = 20
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.ShowCellErrors = False
        Me.AD_ProductsDataGridView.ShowCellToolTips = False
        Me.AD_ProductsDataGridView.ShowEditingIcon = False
        Me.AD_ProductsDataGridView.ShowRowErrors = False
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(781, 493)
        Me.AD_ProductsDataGridView.TabIndex = 3
        '
        'VendTitleDataGridViewTextBoxColumn
        '
        Me.VendTitleDataGridViewTextBoxColumn.DataPropertyName = "VendTitle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendTitleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.VendTitleDataGridViewTextBoxColumn.Frozen = True
        Me.VendTitleDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendTitleDataGridViewTextBoxColumn.Name = "VendTitleDataGridViewTextBoxColumn"
        Me.VendTitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendTitleDataGridViewTextBoxColumn.Width = 300
        '
        'ContactPersonDataGridViewTextBoxColumn
        '
        Me.ContactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson"
        Me.ContactPersonDataGridViewTextBoxColumn.HeaderText = "Person"
        Me.ContactPersonDataGridViewTextBoxColumn.Name = "ContactPersonDataGridViewTextBoxColumn"
        Me.ContactPersonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendAddressDataGridViewTextBoxColumn
        '
        Me.VendAddressDataGridViewTextBoxColumn.DataPropertyName = "VendAddress"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VendAddressDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.VendAddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.VendAddressDataGridViewTextBoxColumn.Name = "VendAddressDataGridViewTextBoxColumn"
        Me.VendAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendOffNoDataGridViewTextBoxColumn
        '
        Me.VendOffNoDataGridViewTextBoxColumn.DataPropertyName = "VendOffNo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.VendOffNoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.VendOffNoDataGridViewTextBoxColumn.HeaderText = "Contact No"
        Me.VendOffNoDataGridViewTextBoxColumn.Name = "VendOffNoDataGridViewTextBoxColumn"
        Me.VendOffNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "Debit"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DebitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit(Rs)"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "Credit"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.CreditDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit(Rs)"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "N2"
        Me.BalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance(Rs)"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADVendorsBindingSource
        '
        Me.ADVendorsBindingSource.DataMember = "AD_Vendors"
        Me.ADVendorsBindingSource.DataSource = Me.Reports
        '
        'Reports
        '
        Me.Reports.DataSetName = "Reports"
        Me.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(792, 33)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Vendors Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'frmVendorReportvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmVendorReportvb"
        Me.Text = "Vendors Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Reports As ISPASystem.Reports
    Friend WithEvents ADVendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ReportsTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents VendTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactPersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendOffNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ShowToolStripButton As System.Windows.Forms.ToolStripButton
End Class
