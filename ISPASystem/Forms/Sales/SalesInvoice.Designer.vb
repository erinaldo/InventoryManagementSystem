<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesInvoice
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesInvoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.PrintToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.FromQuotationToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FromQuotationToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SInvNoTextBox = New System.Windows.Forms.TextBox
        Me.SVoucherNoTextBox = New System.Windows.Forms.TextBox
        Me.CustNameTextBox = New System.Windows.Forms.TextBox
        Me.SIDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DiscountTextBox = New System.Windows.Forms.TextBox
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox
        Me.Bill_NoTextBox = New System.Windows.Forms.TextBox
        Me.Payment_TypeComboBox = New System.Windows.Forms.ComboBox
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox
        Me.OriginalSaleTextBox = New System.Windows.Forms.TextBox
        Me.SaleInvoice_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleInvoice_DDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.AD_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_CustomersDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductTextBox = New System.Windows.Forms.TextBox
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox
        Me.AD_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Particular = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LedgerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cr_VoucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Quatation_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Quatation_MBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Quatation_DTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Quatation_DTableAdapter
        Me.Quatation_MTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Quatation_MTableAdapter
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
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoice_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoice_MBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaleInvoice_MBindingNavigator.SuspendLayout()
        CType(Me.SaleInvoice_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoice_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LedgerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cr_VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quatation_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quatation_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SInvNoLabel
        '
        SInvNoLabel.AutoSize = True
        SInvNoLabel.Location = New System.Drawing.Point(9, 16)
        SInvNoLabel.Name = "SInvNoLabel"
        SInvNoLabel.Size = New System.Drawing.Size(57, 13)
        SInvNoLabel.TabIndex = 1
        SInvNoLabel.Text = "SInv No:"
        '
        'SVoucherNoLabel
        '
        SVoucherNoLabel.AutoSize = True
        SVoucherNoLabel.Location = New System.Drawing.Point(555, 16)
        SVoucherNoLabel.Name = "SVoucherNoLabel"
        SVoucherNoLabel.Size = New System.Drawing.Size(86, 13)
        SVoucherNoLabel.TabIndex = 3
        SVoucherNoLabel.Text = "SVoucher No:"
        '
        'CustNameLabel
        '
        CustNameLabel.AutoSize = True
        CustNameLabel.Location = New System.Drawing.Point(9, 42)
        CustNameLabel.Name = "CustNameLabel"
        CustNameLabel.Size = New System.Drawing.Size(99, 13)
        CustNameLabel.TabIndex = 5
        CustNameLabel.Text = "Customer Name:"
        '
        'SIDateLabel
        '
        SIDateLabel.AutoSize = True
        SIDateLabel.Location = New System.Drawing.Point(555, 43)
        SIDateLabel.Name = "SIDateLabel"
        SIDateLabel.Size = New System.Drawing.Size(50, 13)
        SIDateLabel.TabIndex = 7
        SIDateLabel.Text = "SIDate:"
        '
        'DiscountLabel
        '
        DiscountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(556, 36)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(52, 13)
        DiscountLabel.TabIndex = 9
        DiscountLabel.Text = "Discount:"
        '
        'TotalAmountLabel
        '
        TotalAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalAmountLabel.AutoSize = True
        TotalAmountLabel.Location = New System.Drawing.Point(556, 88)
        TotalAmountLabel.Name = "TotalAmountLabel"
        TotalAmountLabel.Size = New System.Drawing.Size(73, 13)
        TotalAmountLabel.TabIndex = 11
        TotalAmountLabel.Text = "Total Amount:"
        '
        'Bill_NoLabel
        '
        Bill_NoLabel.AutoSize = True
        Bill_NoLabel.Location = New System.Drawing.Point(558, 68)
        Bill_NoLabel.Name = "Bill_NoLabel"
        Bill_NoLabel.Size = New System.Drawing.Size(48, 13)
        Bill_NoLabel.TabIndex = 13
        Bill_NoLabel.Text = "Bill No:"
        '
        'Payment_TypeLabel
        '
        Payment_TypeLabel.AutoSize = True
        Payment_TypeLabel.Location = New System.Drawing.Point(9, 66)
        Payment_TypeLabel.Name = "Payment_TypeLabel"
        Payment_TypeLabel.Size = New System.Drawing.Size(91, 13)
        Payment_TypeLabel.TabIndex = 15
        Payment_TypeLabel.Text = "Payment Type:"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(556, 62)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(91, 13)
        DiscountAmountLabel.TabIndex = 17
        DiscountAmountLabel.Text = "Discount Amount:"
        '
        'OriginalSaleLabel
        '
        OriginalSaleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        OriginalSaleLabel.AutoSize = True
        OriginalSaleLabel.Location = New System.Drawing.Point(556, 10)
        OriginalSaleLabel.Name = "OriginalSaleLabel"
        OriginalSaleLabel.Size = New System.Drawing.Size(69, 13)
        OriginalSaleLabel.TabIndex = 19
        OriginalSaleLabel.Text = "Original Sale:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(3, 6)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(91, 13)
        Label2.TabIndex = 29
        Label2.Text = "Select Product"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(306, 6)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(54, 13)
        Label3.TabIndex = 30
        Label3.Text = "Quantity"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(240, 6)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(63, 13)
        Label4.TabIndex = 31
        Label4.Text = "Unit Price"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(371, 6)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(61, 13)
        Label5.TabIndex = 32
        Label5.Text = "TotalCost"
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
        Me.TableAdapterManager.DC_DetailTableAdapter = Nothing
        Me.TableAdapterManager.DC_MainTableAdapter = Nothing
        Me.TableAdapterManager.EMICalcTableAdapter = Nothing
        Me.TableAdapterManager.EMISchemeTableAdapter = Nothing
        Me.TableAdapterManager.LedgerTableAdapter = Me.LedgerTableAdapter
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
        Me.TableAdapterManager.SaleInvoice_DTableAdapter = Me.SaleInvoice_DTableAdapter
        Me.TableAdapterManager.SaleInvoice_MTableAdapter = Me.SaleInvoice_MTableAdapter
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_DTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_MTableAdapter = Nothing
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
        Me.SaleInvoice_MBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.SaleInvoice_MBindingNavigator.BindingSource = Me.SaleInvoice_MBindingSource
        Me.SaleInvoice_MBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SaleInvoice_MBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SaleInvoice_MBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaleInvoice_MBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaleInvoice_MBindingNavigatorSaveItem, Me.PrintToolStripButton1, Me.FromQuotationToolStripTextBox, Me.FromQuotationToolStripButton})
        Me.SaleInvoice_MBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SaleInvoice_MBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SaleInvoice_MBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SaleInvoice_MBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SaleInvoice_MBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SaleInvoice_MBindingNavigator.Name = "SaleInvoice_MBindingNavigator"
        Me.SaleInvoice_MBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SaleInvoice_MBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.SaleInvoice_MBindingNavigator.Size = New System.Drawing.Size(804, 25)
        Me.SaleInvoice_MBindingNavigator.TabIndex = 0
        Me.SaleInvoice_MBindingNavigator.Text = "BindingNavigator1"
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
        'SaleInvoice_MBindingNavigatorSaveItem
        '
        Me.SaleInvoice_MBindingNavigatorSaveItem.Image = CType(resources.GetObject("SaleInvoice_MBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SaleInvoice_MBindingNavigatorSaveItem.Name = "SaleInvoice_MBindingNavigatorSaveItem"
        Me.SaleInvoice_MBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.SaleInvoice_MBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton1
        '
        Me.PrintToolStripButton1.Image = CType(resources.GetObject("PrintToolStripButton1.Image"), System.Drawing.Image)
        Me.PrintToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton1.Name = "PrintToolStripButton1"
        Me.PrintToolStripButton1.Size = New System.Drawing.Size(54, 22)
        Me.PrintToolStripButton1.Text = "Print"
        '
        'FromQuotationToolStripTextBox
        '
        Me.FromQuotationToolStripTextBox.Name = "FromQuotationToolStripTextBox"
        Me.FromQuotationToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FromQuotationToolStripButton
        '
        Me.FromQuotationToolStripButton.Image = CType(resources.GetObject("FromQuotationToolStripButton.Image"), System.Drawing.Image)
        Me.FromQuotationToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FromQuotationToolStripButton.Name = "FromQuotationToolStripButton"
        Me.FromQuotationToolStripButton.Size = New System.Drawing.Size(115, 22)
        Me.FromQuotationToolStripButton.Text = "From Quotation"
        '
        'SInvNoTextBox
        '
        Me.SInvNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "SInvNo", True))
        Me.SInvNoTextBox.Location = New System.Drawing.Point(106, 13)
        Me.SInvNoTextBox.Name = "SInvNoTextBox"
        Me.SInvNoTextBox.ReadOnly = True
        Me.SInvNoTextBox.Size = New System.Drawing.Size(83, 20)
        Me.SInvNoTextBox.TabIndex = 0
        '
        'SVoucherNoTextBox
        '
        Me.SVoucherNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "SVoucherNo", True))
        Me.SVoucherNoTextBox.Location = New System.Drawing.Point(652, 13)
        Me.SVoucherNoTextBox.Name = "SVoucherNoTextBox"
        Me.SVoucherNoTextBox.ReadOnly = True
        Me.SVoucherNoTextBox.Size = New System.Drawing.Size(98, 20)
        Me.SVoucherNoTextBox.TabIndex = 2
        '
        'CustNameTextBox
        '
        Me.CustNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "CustName", True))
        Me.CustNameTextBox.Location = New System.Drawing.Point(106, 39)
        Me.CustNameTextBox.Name = "CustNameTextBox"
        Me.CustNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustNameTextBox.TabIndex = 1
        '
        'SIDateDateTimePicker
        '
        Me.SIDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SaleInvoice_MBindingSource, "SIDate", True))
        Me.SIDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "SIDate", True))
        Me.SIDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SIDateDateTimePicker.Location = New System.Drawing.Point(652, 39)
        Me.SIDateDateTimePicker.Name = "SIDateDateTimePicker"
        Me.SIDateDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.SIDateDateTimePicker.TabIndex = 3
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "Discount", True))
        Me.DiscountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTextBox.Location = New System.Drawing.Point(653, 33)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(101, 22)
        Me.DiscountTextBox.TabIndex = 12
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "TotalAmount", True))
        Me.TotalAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(653, 85)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(101, 22)
        Me.TotalAmountTextBox.TabIndex = 14
        '
        'Bill_NoTextBox
        '
        Me.Bill_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "Bill No", True))
        Me.Bill_NoTextBox.Location = New System.Drawing.Point(652, 65)
        Me.Bill_NoTextBox.Name = "Bill_NoTextBox"
        Me.Bill_NoTextBox.ReadOnly = True
        Me.Bill_NoTextBox.Size = New System.Drawing.Size(98, 20)
        Me.Bill_NoTextBox.TabIndex = 4
        '
        'Payment_TypeComboBox
        '
        Me.Payment_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "Payment_Type", True))
        Me.Payment_TypeComboBox.FormattingEnabled = True
        Me.Payment_TypeComboBox.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.Payment_TypeComboBox.Location = New System.Drawing.Point(106, 63)
        Me.Payment_TypeComboBox.Name = "Payment_TypeComboBox"
        Me.Payment_TypeComboBox.Size = New System.Drawing.Size(112, 21)
        Me.Payment_TypeComboBox.TabIndex = 16
        '
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(653, 59)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(101, 22)
        Me.DiscountAmountTextBox.TabIndex = 13
        '
        'OriginalSaleTextBox
        '
        Me.OriginalSaleTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OriginalSaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_MBindingSource, "OriginalSale", True))
        Me.OriginalSaleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OriginalSaleTextBox.Location = New System.Drawing.Point(653, 7)
        Me.OriginalSaleTextBox.Name = "OriginalSaleTextBox"
        Me.OriginalSaleTextBox.ReadOnly = True
        Me.OriginalSaleTextBox.Size = New System.Drawing.Size(101, 22)
        Me.OriginalSaleTextBox.TabIndex = 11
        '
        'SaleInvoice_DBindingSource
        '
        Me.SaleInvoice_DBindingSource.DataMember = "SaleInvoice_MSaleInvoice_D"
        Me.SaleInvoice_DBindingSource.DataSource = Me.SaleInvoice_MBindingSource
        '
        'SaleInvoice_DDataGridView
        '
        Me.SaleInvoice_DDataGridView.AllowUserToAddRows = False
        Me.SaleInvoice_DDataGridView.AllowUserToDeleteRows = False
        Me.SaleInvoice_DDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaleInvoice_DDataGridView.AutoGenerateColumns = False
        Me.SaleInvoice_DDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SaleInvoice_DDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SaleInvoice_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaleInvoice_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SaleInvoice_DDataGridView.DataSource = Me.SaleInvoice_DBindingSource
        Me.SaleInvoice_DDataGridView.Location = New System.Drawing.Point(6, 48)
        Me.SaleInvoice_DDataGridView.Name = "SaleInvoice_DDataGridView"
        Me.SaleInvoice_DDataGridView.ReadOnly = True
        Me.SaleInvoice_DDataGridView.RowHeadersVisible = False
        Me.SaleInvoice_DDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SaleInvoice_DDataGridView.Size = New System.Drawing.Size(762, 175)
        Me.SaleInvoice_DDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SIDNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SIDNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SInvNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SInvNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalCost"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "TotalCost"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 91)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Rs. 0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AD_CustomersBindingSource
        '
        Me.AD_CustomersBindingSource.DataMember = "AD_Customers"
        Me.AD_CustomersBindingSource.DataSource = Me.ISPASDataSet
        '
        'AD_CustomersDataGridView
        '
        Me.AD_CustomersDataGridView.AllowUserToAddRows = False
        Me.AD_CustomersDataGridView.AllowUserToDeleteRows = False
        Me.AD_CustomersDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_CustomersDataGridView.AutoGenerateColumns = False
        Me.AD_CustomersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.Column1})
        Me.AD_CustomersDataGridView.DataSource = Me.AD_CustomersBindingSource
        Me.AD_CustomersDataGridView.Location = New System.Drawing.Point(257, 0)
        Me.AD_CustomersDataGridView.Name = "AD_CustomersDataGridView"
        Me.AD_CustomersDataGridView.ReadOnly = True
        Me.AD_CustomersDataGridView.RowHeadersVisible = False
        Me.AD_CustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_CustomersDataGridView.Size = New System.Drawing.Size(521, 174)
        Me.AD_CustomersDataGridView.TabIndex = 23
        Me.AD_CustomersDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CustTitle"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn8.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ConctactPerson"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn9.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CustAddress"
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn12.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 250
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CustOffNo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn13.HeaderText = "Contact No"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Custid"
        Me.Column1.HeaderText = "CustomerID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'ProductTextBox
        '
        Me.ProductTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTextBox.Location = New System.Drawing.Point(6, 22)
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.Size = New System.Drawing.Size(228, 20)
        Me.ProductTextBox.TabIndex = 5
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(243, 22)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(57, 20)
        Me.UnitPriceTextBox.TabIndex = 6
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(306, 22)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(59, 20)
        Me.QuantityTextBox.TabIndex = 7
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(374, 22)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(58, 20)
        Me.TotalCostTextBox.TabIndex = 8
        '
        'AD_ProductsBindingSource
        '
        Me.AD_ProductsBindingSource.DataMember = "AD_Products"
        Me.AD_ProductsBindingSource.DataSource = Me.ISPASDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Particular, Me.Qty, Me.Description, Me.Remark})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 48)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(762, 175)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.Visible = False
        '
        'Particular
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Particular.DefaultCellStyle = DataGridViewCellStyle9
        Me.Particular.HeaderText = "Product"
        Me.Particular.Name = "Particular"
        Me.Particular.ReadOnly = True
        '
        'Qty
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle10
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'Description
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.Description.DefaultCellStyle = DataGridViewCellStyle11
        Me.Description.HeaderText = "Unit Price"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Remark
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle12
        Me.Remark.HeaderText = "Total Cost"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.AD_CustomersDataGridView)
        Me.Panel1.Controls.Add(Me.Payment_TypeComboBox)
        Me.Panel1.Controls.Add(Payment_TypeLabel)
        Me.Panel1.Controls.Add(Me.Bill_NoTextBox)
        Me.Panel1.Controls.Add(Bill_NoLabel)
        Me.Panel1.Controls.Add(Me.SIDateDateTimePicker)
        Me.Panel1.Controls.Add(SIDateLabel)
        Me.Panel1.Controls.Add(Me.CustNameTextBox)
        Me.Panel1.Controls.Add(CustNameLabel)
        Me.Panel1.Controls.Add(Me.SVoucherNoTextBox)
        Me.Panel1.Controls.Add(SVoucherNoLabel)
        Me.Panel1.Controls.Add(Me.SInvNoTextBox)
        Me.Panel1.Controls.Add(SInvNoLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 177)
        Me.Panel1.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.OriginalSaleTextBox)
        Me.Panel2.Controls.Add(OriginalSaleLabel)
        Me.Panel2.Controls.Add(Me.DiscountAmountTextBox)
        Me.Panel2.Controls.Add(DiscountAmountLabel)
        Me.Panel2.Controls.Add(Me.TotalAmountTextBox)
        Me.Panel2.Controls.Add(TotalAmountLabel)
        Me.Panel2.Controls.Add(Me.DiscountTextBox)
        Me.Panel2.Controls.Add(DiscountLabel)
        Me.Panel2.Location = New System.Drawing.Point(6, 234)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 112)
        Me.Panel2.TabIndex = 34
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Label2)
        Me.Panel3.Controls.Add(Me.ProductTextBox)
        Me.Panel3.Controls.Add(Label5)
        Me.Panel3.Controls.Add(Me.UnitPriceTextBox)
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Controls.Add(Me.QuantityTextBox)
        Me.Panel3.Controls.Add(Label3)
        Me.Panel3.Controls.Add(Me.TotalCostTextBox)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.SaleInvoice_DDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(12, 211)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(786, 361)
        Me.Panel3.TabIndex = 34
        '
        'AD_ProductsDataGridView
        '
        Me.AD_ProductsDataGridView.AllowUserToAddRows = False
        Me.AD_ProductsDataGridView.AllowUserToDeleteRows = False
        Me.AD_ProductsDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AD_ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14})
        Me.AD_ProductsDataGridView.DataSource = Me.AD_ProductsBindingSource
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(778, 186)
        Me.AD_ProductsDataGridView.TabIndex = 9
        Me.AD_ProductsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn10.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ProdCate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ProdUnits"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'LedgerBindingSource
        '
        Me.LedgerBindingSource.DataMember = "Ledger"
        Me.LedgerBindingSource.DataSource = Me.ISPASDataSet
        '
        'Cr_VoucherBindingSource
        '
        Me.Cr_VoucherBindingSource.DataMember = "Cr_Voucher"
        Me.Cr_VoucherBindingSource.DataSource = Me.ISPASDataSet
        '
        'Quatation_DBindingSource
        '
        Me.Quatation_DBindingSource.DataMember = "Quatation_MQuatation_D"
        Me.Quatation_DBindingSource.DataSource = Me.Quatation_MBindingSource
        '
        'Quatation_MBindingSource
        '
        Me.Quatation_MBindingSource.DataMember = "Quatation_M"
        Me.Quatation_MBindingSource.DataSource = Me.ISPASDataSet
        '
        'Quatation_DTableAdapter
        '
        Me.Quatation_DTableAdapter.ClearBeforeFill = True
        '
        'Quatation_MTableAdapter
        '
        Me.Quatation_MTableAdapter.ClearBeforeFill = True
        '
        'SalesInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(804, 584)
        Me.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Controls.Add(Me.SaleInvoice_MBindingNavigator)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SalesInvoice"
        Me.Text = "Sales Invoice"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoice_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoice_MBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaleInvoice_MBindingNavigator.ResumeLayout(False)
        Me.SaleInvoice_MBindingNavigator.PerformLayout()
        CType(Me.SaleInvoice_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoice_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LedgerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cr_VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quatation_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quatation_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CustNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SIDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bill_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Payment_TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OriginalSaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaleInvoice_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleInvoice_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents AD_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents AD_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Particular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LedgerTableAdapter As ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
    Friend WithEvents LedgerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cr_VoucherTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Cr_VoucherTableAdapter
    Friend WithEvents Cr_VoucherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PrintToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FromQuotationToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FromQuotationToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Quatation_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quatation_MBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quatation_DTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Quatation_DTableAdapter
    Friend WithEvents Quatation_MTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Quatation_MTableAdapter
End Class
