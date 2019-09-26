<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Dim ProdCodeLabel As System.Windows.Forms.Label
        Dim ProdTitleLabel As System.Windows.Forms.Label
        Dim ProdCateLabel As System.Windows.Forms.Label
        Dim ProdUnitsLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim VendorLabel As System.Windows.Forms.Label
        Dim CurrencyTypeLabel As System.Windows.Forms.Label
        Dim PakPriceLabel As System.Windows.Forms.Label
        Dim CurrencyRateLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.AD_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AD_ProdCatTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProdCatTableAdapter
        Me.AD_VendorsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
        Me.CurrencyRateTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.CurrencyRateTableAdapter
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdCodeTextBox = New System.Windows.Forms.TextBox
        Me.ProdTitleTextBox = New System.Windows.Forms.TextBox
        Me.ProdUnitsTextBox = New System.Windows.Forms.TextBox
        Me.WeightTextBox = New System.Windows.Forms.TextBox
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox
        Me.CurrencyRateTextBox = New System.Windows.Forms.TextBox
        Me.CurrencyTypeComboBox = New System.Windows.Forms.ComboBox
        Me.CurrencyRateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorComboBox = New System.Windows.Forms.ComboBox
        Me.AD_VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdCateComboBox = New System.Windows.Forms.ComboBox
        Me.AD_ProdCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PakPriceTextBox = New System.Windows.Forms.TextBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.AD_ProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AD_ProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SearchLabel = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        ProdCodeLabel = New System.Windows.Forms.Label
        ProdTitleLabel = New System.Windows.Forms.Label
        ProdCateLabel = New System.Windows.Forms.Label
        ProdUnitsLabel = New System.Windows.Forms.Label
        WeightLabel = New System.Windows.Forms.Label
        UnitPriceLabel = New System.Windows.Forms.Label
        VendorLabel = New System.Windows.Forms.Label
        CurrencyTypeLabel = New System.Windows.Forms.Label
        PakPriceLabel = New System.Windows.Forms.Label
        CurrencyRateLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyRateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProdCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AD_ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AD_ProductsBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProdCodeLabel
        '
        ProdCodeLabel.AutoSize = True
        ProdCodeLabel.Location = New System.Drawing.Point(3, 10)
        ProdCodeLabel.Name = "ProdCodeLabel"
        ProdCodeLabel.Size = New System.Drawing.Size(68, 13)
        ProdCodeLabel.TabIndex = 2
        ProdCodeLabel.Text = "Product ID"
        '
        'ProdTitleLabel
        '
        ProdTitleLabel.AutoSize = True
        ProdTitleLabel.Location = New System.Drawing.Point(389, 13)
        ProdTitleLabel.Name = "ProdTitleLabel"
        ProdTitleLabel.Size = New System.Drawing.Size(75, 13)
        ProdTitleLabel.TabIndex = 4
        ProdTitleLabel.Text = "Description:"
        '
        'ProdCateLabel
        '
        ProdCateLabel.AutoSize = True
        ProdCateLabel.Location = New System.Drawing.Point(3, 36)
        ProdCateLabel.Name = "ProdCateLabel"
        ProdCateLabel.Size = New System.Drawing.Size(61, 13)
        ProdCateLabel.TabIndex = 6
        ProdCateLabel.Text = "Category:"
        '
        'ProdUnitsLabel
        '
        ProdUnitsLabel.AutoSize = True
        ProdUnitsLabel.Location = New System.Drawing.Point(3, 114)
        ProdUnitsLabel.Name = "ProdUnitsLabel"
        ProdUnitsLabel.Size = New System.Drawing.Size(92, 13)
        ProdUnitsLabel.TabIndex = 8
        ProdUnitsLabel.Text = "Units In Stock:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(389, 39)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(51, 13)
        WeightLabel.TabIndex = 10
        WeightLabel.Text = "Weight:"
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(389, 65)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(67, 13)
        UnitPriceLabel.TabIndex = 12
        UnitPriceLabel.Text = "Unit Price:"
        '
        'VendorLabel
        '
        VendorLabel.AutoSize = True
        VendorLabel.Location = New System.Drawing.Point(389, 116)
        VendorLabel.Name = "VendorLabel"
        VendorLabel.Size = New System.Drawing.Size(51, 13)
        VendorLabel.TabIndex = 14
        VendorLabel.Text = "Vendor:"
        '
        'CurrencyTypeLabel
        '
        CurrencyTypeLabel.AutoSize = True
        CurrencyTypeLabel.Location = New System.Drawing.Point(3, 62)
        CurrencyTypeLabel.Name = "CurrencyTypeLabel"
        CurrencyTypeLabel.Size = New System.Drawing.Size(57, 13)
        CurrencyTypeLabel.TabIndex = 16
        CurrencyTypeLabel.Text = "Currency"
        '
        'PakPriceLabel
        '
        PakPriceLabel.AutoSize = True
        PakPriceLabel.Location = New System.Drawing.Point(389, 91)
        PakPriceLabel.Name = "PakPriceLabel"
        PakPriceLabel.Size = New System.Drawing.Size(66, 13)
        PakPriceLabel.TabIndex = 18
        PakPriceLabel.Text = "Pak Price:"
        '
        'CurrencyRateLabel
        '
        CurrencyRateLabel.AutoSize = True
        CurrencyRateLabel.Location = New System.Drawing.Point(3, 88)
        CurrencyRateLabel.Name = "CurrencyRateLabel"
        CurrencyRateLabel.Size = New System.Drawing.Size(92, 13)
        CurrencyRateLabel.TabIndex = 20
        CurrencyRateLabel.Text = "Currency Rate:"
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AD_ProductsBindingSource
        '
        Me.AD_ProductsBindingSource.DataMember = "AD_Products"
        Me.AD_ProductsBindingSource.DataSource = Me.ISPASDataSet
        Me.AD_ProductsBindingSource.Filter = ""
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Nothing
        Me.TableAdapterManager.AD_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.AD_EmpTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProdCatTableAdapter = Me.AD_ProdCatTableAdapter
        Me.TableAdapterManager.AD_ProductsTableAdapter = Me.AD_ProductsTableAdapter
        Me.TableAdapterManager.AD_VendorsTableAdapter = Me.AD_VendorsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.Bp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Br_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Cp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Cr_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyRateTableAdapter = Me.CurrencyRateTableAdapter
        Me.TableAdapterManager.DC_DetailTableAdapter = Nothing
        Me.TableAdapterManager.DC_MainTableAdapter = Nothing
        Me.TableAdapterManager.EMICalcTableAdapter = Nothing
        Me.TableAdapterManager.EMISchemeTableAdapter = Nothing
        Me.TableAdapterManager.LedgerTableAdapter = Nothing
        Me.TableAdapterManager.MasterTableAdapter = Nothing
        Me.TableAdapterManager.MenuSettingTableAdapter = Nothing
        Me.TableAdapterManager.NewAccountsTableAdapter = Nothing
        Me.TableAdapterManager.PickListTableAdapter = Nothing
        Me.TableAdapterManager.PInvoice_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.PInvoice_MainTableAdapter = Nothing
        Me.TableAdapterManager.POrder_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.POrder_MainTableAdapter = Nothing
        Me.TableAdapterManager.Quatation_DTableAdapter = Nothing
        Me.TableAdapterManager.Quatation_MTableAdapter = Nothing
        Me.TableAdapterManager.Sale_ReturnTableAdapter = Nothing
        Me.TableAdapterManager.SaleInvoice_DTableAdapter = Nothing
        Me.TableAdapterManager.SaleInvoice_MTableAdapter = Nothing
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_DTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_MTableAdapter = Nothing
        '
        'AD_ProdCatTableAdapter
        '
        Me.AD_ProdCatTableAdapter.ClearBeforeFill = True
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'CurrencyRateTableAdapter
        '
        Me.CurrencyRateTableAdapter.ClearBeforeFill = True
        '
        'AD_ProductsDataGridView
        '
        Me.AD_ProductsDataGridView.AllowUserToAddRows = False
        Me.AD_ProductsDataGridView.AllowUserToDeleteRows = False
        Me.AD_ProductsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_ProductsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AD_ProductsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AD_ProductsDataGridView.ColumnHeadersHeight = 25
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.AD_ProductsDataGridView.DataSource = Me.AD_ProductsBindingSource
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(10, 62)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersWidth = 25
        Me.AD_ProductsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(754, 235)
        Me.AD_ProductsDataGridView.StandardTab = True
        Me.AD_ProductsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdCate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit Price (Rs)"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProdUnits"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Stock(No)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Vendor"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Vendor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProdCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "weight"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CurrencyType"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PakPrice"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Pak Price"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'ProdCodeTextBox
        '
        Me.ProdCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_ProductsBindingSource, "ProdCode", True))
        Me.ProdCodeTextBox.Location = New System.Drawing.Point(94, 7)
        Me.ProdCodeTextBox.Name = "ProdCodeTextBox"
        Me.ProdCodeTextBox.Size = New System.Drawing.Size(114, 20)
        Me.ProdCodeTextBox.TabIndex = 3
        '
        'ProdTitleTextBox
        '
        Me.ProdTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_ProductsBindingSource, "ProdTitle", True))
        Me.ProdTitleTextBox.Location = New System.Drawing.Point(474, 10)
        Me.ProdTitleTextBox.Name = "ProdTitleTextBox"
        Me.ProdTitleTextBox.Size = New System.Drawing.Size(279, 20)
        Me.ProdTitleTextBox.TabIndex = 5
        '
        'ProdUnitsTextBox
        '
        Me.ProdUnitsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_ProductsBindingSource, "ProdUnits", True))
        Me.ProdUnitsTextBox.Location = New System.Drawing.Point(94, 111)
        Me.ProdUnitsTextBox.Name = "ProdUnitsTextBox"
        Me.ProdUnitsTextBox.Size = New System.Drawing.Size(185, 20)
        Me.ProdUnitsTextBox.TabIndex = 9
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_ProductsBindingSource, "weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(474, 36)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(164, 20)
        Me.WeightTextBox.TabIndex = 11
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_ProductsBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(474, 62)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(96, 20)
        Me.UnitPriceTextBox.TabIndex = 13
        '
        'CurrencyRateTextBox
        '
        Me.CurrencyRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_ProductsBindingSource, "CurrencyRate", True))
        Me.CurrencyRateTextBox.Location = New System.Drawing.Point(94, 84)
        Me.CurrencyRateTextBox.Name = "CurrencyRateTextBox"
        Me.CurrencyRateTextBox.ReadOnly = True
        Me.CurrencyRateTextBox.Size = New System.Drawing.Size(114, 20)
        Me.CurrencyRateTextBox.TabIndex = 21
        '
        'CurrencyTypeComboBox
        '
        Me.CurrencyTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CurrencyTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CurrencyTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AD_ProductsBindingSource, "CurrencyType", True))
        Me.CurrencyTypeComboBox.DataSource = Me.CurrencyRateBindingSource
        Me.CurrencyTypeComboBox.DisplayMember = "CurrencyName"
        Me.CurrencyTypeComboBox.FormattingEnabled = True
        Me.CurrencyTypeComboBox.Location = New System.Drawing.Point(94, 58)
        Me.CurrencyTypeComboBox.Name = "CurrencyTypeComboBox"
        Me.CurrencyTypeComboBox.Size = New System.Drawing.Size(185, 21)
        Me.CurrencyTypeComboBox.TabIndex = 24
        Me.CurrencyTypeComboBox.ValueMember = "CurrencyName"
        '
        'CurrencyRateBindingSource
        '
        Me.CurrencyRateBindingSource.DataMember = "CurrencyRate"
        Me.CurrencyRateBindingSource.DataSource = Me.ISPASDataSet
        '
        'VendorComboBox
        '
        Me.VendorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.VendorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.VendorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AD_ProductsBindingSource, "Vendor", True))
        Me.VendorComboBox.DataSource = Me.AD_VendorsBindingSource
        Me.VendorComboBox.DisplayMember = "VendTitle"
        Me.VendorComboBox.FormattingEnabled = True
        Me.VendorComboBox.Location = New System.Drawing.Point(474, 113)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(257, 21)
        Me.VendorComboBox.TabIndex = 23
        Me.VendorComboBox.ValueMember = "VendTitle"
        '
        'AD_VendorsBindingSource
        '
        Me.AD_VendorsBindingSource.DataMember = "AD_Vendors"
        Me.AD_VendorsBindingSource.DataSource = Me.ISPASDataSet
        '
        'ProdCateComboBox
        '
        Me.ProdCateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProdCateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProdCateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AD_ProductsBindingSource, "ProdCate", True))
        Me.ProdCateComboBox.DataSource = Me.AD_ProdCatBindingSource
        Me.ProdCateComboBox.DisplayMember = "ProdCatTitle"
        Me.ProdCateComboBox.FormattingEnabled = True
        Me.ProdCateComboBox.Location = New System.Drawing.Point(94, 33)
        Me.ProdCateComboBox.Name = "ProdCateComboBox"
        Me.ProdCateComboBox.Size = New System.Drawing.Size(185, 21)
        Me.ProdCateComboBox.TabIndex = 22
        Me.ProdCateComboBox.ValueMember = "ProdCatTitle"
        '
        'AD_ProdCatBindingSource
        '
        Me.AD_ProdCatBindingSource.DataMember = "AD_ProdCat"
        Me.AD_ProdCatBindingSource.DataSource = Me.ISPASDataSet
        '
        'PakPriceTextBox
        '
        Me.PakPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_ProductsBindingSource, "PakPrice", True))
        Me.PakPriceTextBox.Location = New System.Drawing.Point(474, 88)
        Me.PakPriceTextBox.Name = "PakPriceTextBox"
        Me.PakPriceTextBox.ReadOnly = True
        Me.PakPriceTextBox.Size = New System.Drawing.Size(96, 20)
        Me.PakPriceTextBox.TabIndex = 19
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer1.Panel1.Controls.Add(Me.AD_ProductsBindingNavigator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(792, 566)
        Me.SplitContainer1.SplitterDistance = 355
        Me.SplitContainer1.TabIndex = 23
        '
        'AD_ProductsBindingNavigator
        '
        Me.AD_ProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AD_ProductsBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.AD_ProductsBindingNavigator.BindingSource = Me.AD_ProductsBindingSource
        Me.AD_ProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AD_ProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AD_ProductsBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AD_ProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AD_ProductsBindingNavigatorSaveItem})
        Me.AD_ProductsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AD_ProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AD_ProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AD_ProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AD_ProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AD_ProductsBindingNavigator.Name = "AD_ProductsBindingNavigator"
        Me.AD_ProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AD_ProductsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AD_ProductsBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.AD_ProductsBindingNavigator.TabIndex = 11
        Me.AD_ProductsBindingNavigator.Text = "AD_ProductsBindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(75, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(42, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(64, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AD_ProductsBindingNavigatorSaveItem
        '
        Me.AD_ProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AD_ProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AD_ProductsBindingNavigatorSaveItem.Name = "AD_ProductsBindingNavigatorSaveItem"
        Me.AD_ProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.AD_ProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.SearchLabel)
        Me.Panel1.Controls.Add(Me.SearchTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(7, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 308)
        Me.Panel1.TabIndex = 1
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(7, 39)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(41, 13)
        Me.SearchLabel.TabIndex = 13
        Me.SearchLabel.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(54, 36)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(280, 20)
        Me.SearchTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(770, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Product Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.CurrencyRateTextBox)
        Me.Panel2.Controls.Add(ProdCodeLabel)
        Me.Panel2.Controls.Add(Me.VendorComboBox)
        Me.Panel2.Controls.Add(Me.CurrencyTypeComboBox)
        Me.Panel2.Controls.Add(ProdTitleLabel)
        Me.Panel2.Controls.Add(Me.ProdTitleTextBox)
        Me.Panel2.Controls.Add(ProdUnitsLabel)
        Me.Panel2.Controls.Add(WeightLabel)
        Me.Panel2.Controls.Add(Me.ProdUnitsTextBox)
        Me.Panel2.Controls.Add(Me.WeightTextBox)
        Me.Panel2.Controls.Add(Me.ProdCateComboBox)
        Me.Panel2.Controls.Add(UnitPriceLabel)
        Me.Panel2.Controls.Add(ProdCateLabel)
        Me.Panel2.Controls.Add(Me.UnitPriceTextBox)
        Me.Panel2.Controls.Add(CurrencyTypeLabel)
        Me.Panel2.Controls.Add(VendorLabel)
        Me.Panel2.Controls.Add(CurrencyRateLabel)
        Me.Panel2.Controls.Add(PakPriceLabel)
        Me.Panel2.Controls.Add(Me.ProdCodeTextBox)
        Me.Panel2.Controls.Add(Me.PakPriceTextBox)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(7, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(773, 184)
        Me.Panel2.TabIndex = 25
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyRateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProdCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AD_ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AD_ProductsBindingNavigator.ResumeLayout(False)
        Me.AD_ProductsBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents AD_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProdCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProdTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProdUnitsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrencyRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ProdCateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AD_ProdCatTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProdCatTableAdapter
    Friend WithEvents AD_ProdCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents VendorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AD_VendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PakPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrencyRateTableAdapter As ISPASystem.ISPASDataSetTableAdapters.CurrencyRateTableAdapter
    Friend WithEvents CurrencyTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CurrencyRateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AD_ProductsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AD_ProductsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchLabel As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
End Class
