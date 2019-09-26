<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesInvoice
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
        Dim SInvNoLabel As System.Windows.Forms.Label
        Dim SVoucherNoLabel As System.Windows.Forms.Label
        Dim CustNameLabel As System.Windows.Forms.Label
        Dim SIDateLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim TotalAmountLabel As System.Windows.Forms.Label
        Dim Bill_NoLabel As System.Windows.Forms.Label
        Dim Payment_TypeLabel As System.Windows.Forms.Label
        Dim DiscountAmountLabel As System.Windows.Forms.Label
        Dim OriginalSaleLabel As System.Windows.Forms.Label
        Dim ProdTitleLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesInvoice))
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.SaleInvoice_MBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleInvoice_MTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_MTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AD_CustomersTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.Cr_VoucherTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Cr_VoucherTableAdapter
        Me.LedgerTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
        Me.SaleInvoice_DTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_DTableAdapter
        Me.SaleInvoice_MBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SaleInvoice_MBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SInvNoTextBox = New System.Windows.Forms.TextBox
        Me.SVoucherNoTextBox = New System.Windows.Forms.TextBox
        Me.CustNameComboBox = New System.Windows.Forms.ComboBox
        Me.AD_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DiscountTextBox = New System.Windows.Forms.TextBox
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox
        Me.Bill_NoTextBox = New System.Windows.Forms.TextBox
        Me.Payment_TypeComboBox = New System.Windows.Forms.ComboBox
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox
        Me.OriginalSaleTextBox = New System.Windows.Forms.TextBox
        Me.ProdTitleComboBox = New System.Windows.Forms.ComboBox
        Me.AD_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        SInvNoLabel = New System.Windows.Forms.Label
        SVoucherNoLabel = New System.Windows.Forms.Label
        CustNameLabel = New System.Windows.Forms.Label
        SIDateLabel = New System.Windows.Forms.Label
        DiscountLabel = New System.Windows.Forms.Label
        TotalAmountLabel = New System.Windows.Forms.Label
        Bill_NoLabel = New System.Windows.Forms.Label
        Payment_TypeLabel = New System.Windows.Forms.Label
        DiscountAmountLabel = New System.Windows.Forms.Label
        OriginalSaleLabel = New System.Windows.Forms.Label
        ProdTitleLabel = New System.Windows.Forms.Label
        QuantityLabel = New System.Windows.Forms.Label
        UnitPriceLabel = New System.Windows.Forms.Label
        TotalCostLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoice_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoice_MBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaleInvoice_MBindingNavigator.SuspendLayout()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SInvNoLabel
        '
        SInvNoLabel.AutoSize = True
        SInvNoLabel.Location = New System.Drawing.Point(6, 16)
        SInvNoLabel.Name = "SInvNoLabel"
        SInvNoLabel.Size = New System.Drawing.Size(42, 13)
        SInvNoLabel.TabIndex = 1
        SInvNoLabel.Text = "Inv No:"
        '
        'SVoucherNoLabel
        '
        SVoucherNoLabel.AutoSize = True
        SVoucherNoLabel.Location = New System.Drawing.Point(8, 23)
        SVoucherNoLabel.Name = "SVoucherNoLabel"
        SVoucherNoLabel.Size = New System.Drawing.Size(74, 13)
        SVoucherNoLabel.TabIndex = 3
        SVoucherNoLabel.Text = "SVoucher No:"
        '
        'CustNameLabel
        '
        CustNameLabel.AutoSize = True
        CustNameLabel.Location = New System.Drawing.Point(6, 45)
        CustNameLabel.Name = "CustNameLabel"
        CustNameLabel.Size = New System.Drawing.Size(54, 13)
        CustNameLabel.TabIndex = 5
        CustNameLabel.Text = "Customer:"
        '
        'SIDateLabel
        '
        SIDateLabel.AutoSize = True
        SIDateLabel.Location = New System.Drawing.Point(530, 16)
        SIDateLabel.Name = "SIDateLabel"
        SIDateLabel.Size = New System.Drawing.Size(33, 13)
        SIDateLabel.TabIndex = 7
        SIDateLabel.Text = "Date:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(6, 14)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(69, 13)
        DiscountLabel.TabIndex = 9
        DiscountLabel.Text = "Discount (%):"
        '
        'TotalAmountLabel
        '
        TotalAmountLabel.AutoSize = True
        TotalAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalAmountLabel.Location = New System.Drawing.Point(473, 24)
        TotalAmountLabel.Name = "TotalAmountLabel"
        TotalAmountLabel.Size = New System.Drawing.Size(83, 24)
        TotalAmountLabel.TabIndex = 2
        TotalAmountLabel.Text = "TOTAL:"
        '
        'Bill_NoLabel
        '
        Bill_NoLabel.AutoSize = True
        Bill_NoLabel.Location = New System.Drawing.Point(8, 49)
        Bill_NoLabel.Name = "Bill_NoLabel"
        Bill_NoLabel.Size = New System.Drawing.Size(40, 13)
        Bill_NoLabel.TabIndex = 13
        Bill_NoLabel.Text = "Bill No:"
        '
        'Payment_TypeLabel
        '
        Payment_TypeLabel.AutoSize = True
        Payment_TypeLabel.Location = New System.Drawing.Point(495, 41)
        Payment_TypeLabel.Name = "Payment_TypeLabel"
        Payment_TypeLabel.Size = New System.Drawing.Size(78, 13)
        Payment_TypeLabel.TabIndex = 15
        Payment_TypeLabel.Text = "Payment Type:"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(6, 33)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(91, 13)
        DiscountAmountLabel.TabIndex = 17
        DiscountAmountLabel.Text = "Discount Amount:"
        '
        'OriginalSaleLabel
        '
        OriginalSaleLabel.AutoSize = True
        OriginalSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OriginalSaleLabel.Location = New System.Drawing.Point(202, 25)
        OriginalSaleLabel.Name = "OriginalSaleLabel"
        OriginalSaleLabel.Size = New System.Drawing.Size(116, 24)
        OriginalSaleLabel.TabIndex = 19
        OriginalSaleLabel.Text = "NET SALE:"
        '
        'ProdTitleLabel
        '
        ProdTitleLabel.AutoSize = True
        ProdTitleLabel.Location = New System.Drawing.Point(6, 16)
        ProdTitleLabel.Name = "ProdTitleLabel"
        ProdTitleLabel.Size = New System.Drawing.Size(80, 13)
        ProdTitleLabel.TabIndex = 25
        ProdTitleLabel.Text = "Select Product:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(276, 16)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 27
        QuantityLabel.Text = "Quantity:"
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(342, 16)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 29
        UnitPriceLabel.Text = "Unit Price:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Location = New System.Drawing.Point(424, 16)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(58, 13)
        TotalCostLabel.TabIndex = 31
        TotalCostLabel.Text = "Total Cost:"
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleInvoice_MBindingSource
        '
        Me.SaleInvoice_MBindingSource.DataMember = "SaleInvoice_M"
        Me.SaleInvoice_MBindingSource.DataSource = Me.ISPASDataSet
        '
        'SaleInvoice_MTableAdapter
        '
        Me.SaleInvoice_MTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Nothing
        Me.TableAdapterManager.AD_CustomersTableAdapter = Me.AD_CustomersTableAdapter
        Me.TableAdapterManager.AD_EmpTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProdCatTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProductsTableAdapter = Me.AD_ProductsTableAdapter
        Me.TableAdapterManager.AD_VendorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.Bp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Br_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Cp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Cr_VoucherTableAdapter = Me.Cr_VoucherTableAdapter
        Me.TableAdapterManager.CurrencyRateTableAdapter = Nothing
        Me.TableAdapterManager.LedgerTableAdapter = Me.LedgerTableAdapter
        Me.TableAdapterManager.MasterTableAdapter = Nothing
        Me.TableAdapterManager.NewAccountsTableAdapter = Nothing
        Me.TableAdapterManager.PInvoice_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.PInvoice_MainTableAdapter = Nothing
        Me.TableAdapterManager.POrder_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.POrder_MainTableAdapter = Nothing
        Me.TableAdapterManager.Sale_ReturnTableAdapter = Nothing
        Me.TableAdapterManager.SaleInvoice_DTableAdapter = Me.SaleInvoice_DTableAdapter
        Me.TableAdapterManager.SaleInvoice_MTableAdapter = Me.SaleInvoice_MTableAdapter
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'AD_CustomersTableAdapter
        '
        Me.AD_CustomersTableAdapter.ClearBeforeFill = True
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'Cr_VoucherTableAdapter
        '
        Me.Cr_VoucherTableAdapter.ClearBeforeFill = True
        '
        'LedgerTableAdapter
        '
        Me.LedgerTableAdapter.ClearBeforeFill = True
        '
        'SaleInvoice_DTableAdapter
        '
        Me.SaleInvoice_DTableAdapter.ClearBeforeFill = True
        '
        'SaleInvoice_MBindingNavigator
        '
        Me.SaleInvoice_MBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SaleInvoice_MBindingNavigator.BackColor = System.Drawing.Color.White
        Me.SaleInvoice_MBindingNavigator.BindingSource = Me.SaleInvoice_MBindingSource
        Me.SaleInvoice_MBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SaleInvoice_MBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SaleInvoice_MBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaleInvoice_MBindingNavigatorSaveItem})
        Me.SaleInvoice_MBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SaleInvoice_MBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SaleInvoice_MBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SaleInvoice_MBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SaleInvoice_MBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SaleInvoice_MBindingNavigator.Name = "SaleInvoice_MBindingNavigator"
        Me.SaleInvoice_MBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SaleInvoice_MBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SaleInvoice_MBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.SaleInvoice_MBindingNavigator.TabIndex = 0
        Me.SaleInvoice_MBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'SaleInvoice_MBindingNavigatorSaveItem
        '
        Me.SaleInvoice_MBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaleInvoice_MBindingNavigatorSaveItem.Image = CType(resources.GetObject("SaleInvoice_MBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SaleInvoice_MBindingNavigatorSaveItem.Name = "SaleInvoice_MBindingNavigatorSaveItem"
        Me.SaleInvoice_MBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SaleInvoice_MBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SInvNoTextBox
        '
        Me.SInvNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "SInvNo", True))
        Me.SInvNoTextBox.Location = New System.Drawing.Point(69, 13)
        Me.SInvNoTextBox.Name = "SInvNoTextBox"
        Me.SInvNoTextBox.Size = New System.Drawing.Size(70, 20)
        Me.SInvNoTextBox.TabIndex = 0
        '
        'SVoucherNoTextBox
        '
        Me.SVoucherNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "SVoucherNo", True))
        Me.SVoucherNoTextBox.Location = New System.Drawing.Point(105, 20)
        Me.SVoucherNoTextBox.Name = "SVoucherNoTextBox"
        Me.SVoucherNoTextBox.Size = New System.Drawing.Size(70, 20)
        Me.SVoucherNoTextBox.TabIndex = 4
        '
        'CustNameComboBox
        '
        Me.CustNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CustNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SaleInvoice_MBindingSource, "CustName", True))
        Me.CustNameComboBox.DataSource = Me.AD_CustomersBindingSource
        Me.CustNameComboBox.DisplayMember = "CustTitle"
        Me.CustNameComboBox.FormattingEnabled = True
        Me.CustNameComboBox.Location = New System.Drawing.Point(69, 42)
        Me.CustNameComboBox.Name = "CustNameComboBox"
        Me.CustNameComboBox.Size = New System.Drawing.Size(231, 21)
        Me.CustNameComboBox.TabIndex = 1
        Me.CustNameComboBox.ValueMember = "CustTitle"
        '
        'AD_CustomersBindingSource
        '
        Me.AD_CustomersBindingSource.DataMember = "AD_Customers"
        Me.AD_CustomersBindingSource.DataSource = Me.ISPASDataSet
        '
        'SIDateDateTimePicker
        '
        Me.SIDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SaleInvoice_MBindingSource, "SIDate", True))
        Me.SIDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "SIDate", True))
        Me.SIDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SIDateDateTimePicker.Location = New System.Drawing.Point(579, 12)
        Me.SIDateDateTimePicker.Name = "SIDateDateTimePicker"
        Me.SIDateDateTimePicker.Size = New System.Drawing.Size(113, 20)
        Me.SIDateDateTimePicker.TabIndex = 2
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "Discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(95, 10)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(69, 20)
        Me.DiscountTextBox.TabIndex = 0
        Me.DiscountTextBox.Text = "0"
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.BackColor = System.Drawing.Color.Yellow
        Me.TotalAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "TotalAmount", True))
        Me.TotalAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(559, 18)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(137, 31)
        Me.TotalAmountTextBox.TabIndex = 2
        Me.TotalAmountTextBox.Text = "0"
        '
        'Bill_NoTextBox
        '
        Me.Bill_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "Bill No", True))
        Me.Bill_NoTextBox.Location = New System.Drawing.Point(105, 46)
        Me.Bill_NoTextBox.Name = "Bill_NoTextBox"
        Me.Bill_NoTextBox.Size = New System.Drawing.Size(70, 20)
        Me.Bill_NoTextBox.TabIndex = 14
        '
        'Payment_TypeComboBox
        '
        Me.Payment_TypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Payment_TypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Payment_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "Payment_Type", True))
        Me.Payment_TypeComboBox.FormattingEnabled = True
        Me.Payment_TypeComboBox.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.Payment_TypeComboBox.Location = New System.Drawing.Point(579, 38)
        Me.Payment_TypeComboBox.Name = "Payment_TypeComboBox"
        Me.Payment_TypeComboBox.Size = New System.Drawing.Size(113, 21)
        Me.Payment_TypeComboBox.TabIndex = 3
        Me.Payment_TypeComboBox.Text = "Cash"
        '
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(95, 33)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(69, 20)
        Me.DiscountAmountTextBox.TabIndex = 1
        Me.DiscountAmountTextBox.Text = "0"
        '
        'OriginalSaleTextBox
        '
        Me.OriginalSaleTextBox.BackColor = System.Drawing.Color.Lime
        Me.OriginalSaleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OriginalSaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "OriginalSale", True))
        Me.OriginalSaleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OriginalSaleTextBox.Location = New System.Drawing.Point(313, 19)
        Me.OriginalSaleTextBox.Name = "OriginalSaleTextBox"
        Me.OriginalSaleTextBox.ReadOnly = True
        Me.OriginalSaleTextBox.Size = New System.Drawing.Size(137, 31)
        Me.OriginalSaleTextBox.TabIndex = 3
        Me.OriginalSaleTextBox.Text = "0"
        '
        'ProdTitleComboBox
        '
        Me.ProdTitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProdTitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProdTitleComboBox.DataSource = Me.AD_ProductsBindingSource
        Me.ProdTitleComboBox.DisplayMember = "ProdTitle"
        Me.ProdTitleComboBox.FormattingEnabled = True
        Me.ProdTitleComboBox.Location = New System.Drawing.Point(9, 32)
        Me.ProdTitleComboBox.Name = "ProdTitleComboBox"
        Me.ProdTitleComboBox.Size = New System.Drawing.Size(264, 21)
        Me.ProdTitleComboBox.TabIndex = 0
        Me.ProdTitleComboBox.ValueMember = "ProdTitle"
        '
        'AD_ProductsBindingSource
        '
        Me.AD_ProductsBindingSource.DataMember = "AD_Products"
        Me.AD_ProductsBindingSource.DataSource = Me.ISPASDataSet
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(279, 32)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(62, 20)
        Me.QuantityTextBox.TabIndex = 1
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(349, 32)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(72, 20)
        Me.UnitPriceTextBox.TabIndex = 2
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.Location = New System.Drawing.Point(427, 32)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(104, 20)
        Me.TotalCostTextBox.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.CustNameComboBox)
        Me.GroupBox1.Controls.Add(Me.Payment_TypeComboBox)
        Me.GroupBox1.Controls.Add(Payment_TypeLabel)
        Me.GroupBox1.Controls.Add(Me.SIDateDateTimePicker)
        Me.GroupBox1.Controls.Add(SIDateLabel)
        Me.GroupBox1.Controls.Add(CustNameLabel)
        Me.GroupBox1.Controls.Add(Me.SInvNoTextBox)
        Me.GroupBox1.Controls.Add(SInvNoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(SVoucherNoLabel)
        Me.GroupBox3.Controls.Add(Me.Bill_NoTextBox)
        Me.GroupBox3.Controls.Add(Bill_NoLabel)
        Me.GroupBox3.Controls.Add(Me.SVoucherNoTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(688, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(71, 34)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox2.Controls.Add(Me.OriginalSaleTextBox)
        Me.GroupBox2.Controls.Add(DiscountLabel)
        Me.GroupBox2.Controls.Add(OriginalSaleLabel)
        Me.GroupBox2.Controls.Add(Me.TotalAmountTextBox)
        Me.GroupBox2.Controls.Add(TotalAmountLabel)
        Me.GroupBox2.Controls.Add(Me.DiscountAmountTextBox)
        Me.GroupBox2.Controls.Add(DiscountAmountLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 502)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 60)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox4.Controls.Add(Me.DeleteButton)
        Me.GroupBox4.Controls.Add(Me.AddButton)
        Me.GroupBox4.Controls.Add(Me.ProdTitleComboBox)
        Me.GroupBox4.Controls.Add(ProdTitleLabel)
        Me.GroupBox4.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox4.Controls.Add(TotalCostLabel)
        Me.GroupBox4.Controls.Add(Me.UnitPriceTextBox)
        Me.GroupBox4.Controls.Add(Me.TotalCostTextBox)
        Me.GroupBox4.Controls.Add(QuantityLabel)
        Me.GroupBox4.Controls.Add(UnitPriceLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 94)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(775, 61)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeleteButton.Location = New System.Drawing.Point(632, 28)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(60, 23)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(566, 28)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(60, 23)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName, Me.Quantity, Me.UnitPrice, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(666, 315)
        Me.DataGridView1.TabIndex = 4
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        Me.ProductName.Width = 300
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'frmSalesInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 574)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaleInvoice_MBindingNavigator)
        Me.Name = "frmSalesInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoice_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoice_MBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaleInvoice_MBindingNavigator.ResumeLayout(False)
        Me.SaleInvoice_MBindingNavigator.PerformLayout()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents SaleInvoice_MBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleInvoice_MTableAdapter As ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_MTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SaleInvoice_MBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SaleInvoice_MBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaleInvoice_DTableAdapter As ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_DTableAdapter
    Friend WithEvents SInvNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SVoucherNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SIDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bill_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Payment_TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OriginalSaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProdTitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Shadows WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents AD_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents AD_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cr_VoucherTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Cr_VoucherTableAdapter
    Friend WithEvents LedgerTableAdapter As ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
End Class
