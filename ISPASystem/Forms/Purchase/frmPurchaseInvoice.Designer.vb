<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseInvoice
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
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim NetInvoiceAmountLabel As System.Windows.Forms.Label
        Dim DutyExpLabel As System.Windows.Forms.Label
        Dim POrderNoLabel As System.Windows.Forms.Label
        Dim TotalAmount_RsLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim DutyLabel As System.Windows.Forms.Label
        Dim ProdTitleLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim OldPriceLabel As System.Windows.Forms.Label
        Dim PInvNoLabel As System.Windows.Forms.Label
        Dim SaleTaxAmountLabel As System.Windows.Forms.Label
        Dim FileNoLabel As System.Windows.Forms.Label
        Dim StoreLabel As System.Windows.Forms.Label
        Dim PInvDateLabel As System.Windows.Forms.Label
        Dim CurrencyRateLabel As System.Windows.Forms.Label
        Dim CurrencyNameLabel As System.Windows.Forms.Label
        Dim Payment_TypeLabel As System.Windows.Forms.Label
        Dim OtherExpLabel As System.Windows.Forms.Label
        Dim VendTitleLabel As System.Windows.Forms.Label
        Dim BENoLabel As System.Windows.Forms.Label
        Dim BEDateLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseInvoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PInvoice_MainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PInvoice_MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
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
        Me.PInvoice_MainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ADVendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyRateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiscountTextBox = New System.Windows.Forms.TextBox
        Me.NetInvoiceAmountTextBox = New System.Windows.Forms.TextBox
        Me.DutyExpTextBox = New System.Windows.Forms.TextBox
        Me.POrderNoTextBox = New System.Windows.Forms.TextBox
        Me.TotalAmount_RsTextBox = New System.Windows.Forms.TextBox
        Me.StoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PInvoice_DetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.PInvDNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PInvMainNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Duty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OldPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.DutyTextBox = New System.Windows.Forms.TextBox
        Me.OldPriceTextBox = New System.Windows.Forms.TextBox
        Me.PInvoice_DetailsDataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PInvoice_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.ProdTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PInvoice_MainTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.PInvoice_MainTableAdapter
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.AD_VendorsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
        Me.Cp_VoucherTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Cp_VoucherTableAdapter
        Me.CurrencyRateTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.CurrencyRateTableAdapter
        Me.LedgerTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
        Me.StoresTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.StoresTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.PInvoice_DetailsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.PInvoice_DetailsTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FileNoTextBox = New System.Windows.Forms.TextBox
        Me.StoreComboBox = New System.Windows.Forms.ComboBox
        Me.SaleTaxAmountTextBox = New System.Windows.Forms.TextBox
        Me.PInvNoTextBox = New System.Windows.Forms.TextBox
        Me.CurrencyRateTextBox = New System.Windows.Forms.TextBox
        Me.Payment_TypeComboBox = New System.Windows.Forms.ComboBox
        Me.CurrencyNameComboBox = New System.Windows.Forms.ComboBox
        Me.PInvDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.BEDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.VendTitleComboBox = New System.Windows.Forms.ComboBox
        Me.OtherExpTextBox = New System.Windows.Forms.TextBox
        Me.BENoTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.AD_VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        DiscountLabel = New System.Windows.Forms.Label
        NetInvoiceAmountLabel = New System.Windows.Forms.Label
        DutyExpLabel = New System.Windows.Forms.Label
        POrderNoLabel = New System.Windows.Forms.Label
        TotalAmount_RsLabel = New System.Windows.Forms.Label
        QuantityLabel = New System.Windows.Forms.Label
        DutyLabel = New System.Windows.Forms.Label
        ProdTitleLabel = New System.Windows.Forms.Label
        UnitPriceLabel = New System.Windows.Forms.Label
        OldPriceLabel = New System.Windows.Forms.Label
        PInvNoLabel = New System.Windows.Forms.Label
        SaleTaxAmountLabel = New System.Windows.Forms.Label
        FileNoLabel = New System.Windows.Forms.Label
        StoreLabel = New System.Windows.Forms.Label
        PInvDateLabel = New System.Windows.Forms.Label
        CurrencyRateLabel = New System.Windows.Forms.Label
        CurrencyNameLabel = New System.Windows.Forms.Label
        Payment_TypeLabel = New System.Windows.Forms.Label
        OtherExpLabel = New System.Windows.Forms.Label
        VendTitleLabel = New System.Windows.Forms.Label
        BENoLabel = New System.Windows.Forms.Label
        BEDateLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.PInvoice_MainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PInvoice_MainBindingNavigator.SuspendLayout()
        CType(Me.PInvoice_MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyRateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PInvoice_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PInvoice_DetailsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PInvoice_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AD_VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiscountLabel
        '
        DiscountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(582, 8)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(52, 13)
        DiscountLabel.TabIndex = 4
        DiscountLabel.Text = "Discount:"
        '
        'NetInvoiceAmountLabel
        '
        NetInvoiceAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NetInvoiceAmountLabel.AutoSize = True
        NetInvoiceAmountLabel.Location = New System.Drawing.Point(531, 81)
        NetInvoiceAmountLabel.Name = "NetInvoiceAmountLabel"
        NetInvoiceAmountLabel.Size = New System.Drawing.Size(104, 13)
        NetInvoiceAmountLabel.TabIndex = 7
        NetInvoiceAmountLabel.Text = "Net Invoice Amount:"
        '
        'DutyExpLabel
        '
        DutyExpLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DutyExpLabel.AutoSize = True
        DutyExpLabel.Location = New System.Drawing.Point(581, 31)
        DutyExpLabel.Name = "DutyExpLabel"
        DutyExpLabel.Size = New System.Drawing.Size(53, 13)
        DutyExpLabel.TabIndex = 5
        DutyExpLabel.Text = "Duty Exp:"
        '
        'POrderNoLabel
        '
        POrderNoLabel.AutoSize = True
        POrderNoLabel.Location = New System.Drawing.Point(0, 123)
        POrderNoLabel.Name = "POrderNoLabel"
        POrderNoLabel.Size = New System.Drawing.Size(60, 13)
        POrderNoLabel.TabIndex = 6
        POrderNoLabel.Text = "POrder No:"
        '
        'TotalAmount_RsLabel
        '
        TotalAmount_RsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalAmount_RsLabel.AutoSize = True
        TotalAmount_RsLabel.Location = New System.Drawing.Point(546, 57)
        TotalAmount_RsLabel.Name = "TotalAmount_RsLabel"
        TotalAmount_RsLabel.Size = New System.Drawing.Size(89, 13)
        TotalAmount_RsLabel.TabIndex = 6
        TotalAmount_RsLabel.Text = "Total Amount Rs:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(552, 3)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 11
        QuantityLabel.Text = "Quantity:"
        '
        'DutyLabel
        '
        DutyLabel.AutoSize = True
        DutyLabel.Location = New System.Drawing.Point(493, 3)
        DutyLabel.Name = "DutyLabel"
        DutyLabel.Size = New System.Drawing.Size(32, 13)
        DutyLabel.TabIndex = 10
        DutyLabel.Text = "Duty:"
        '
        'ProdTitleLabel
        '
        ProdTitleLabel.AutoSize = True
        ProdTitleLabel.Location = New System.Drawing.Point(6, 3)
        ProdTitleLabel.Name = "ProdTitleLabel"
        ProdTitleLabel.Size = New System.Drawing.Size(55, 13)
        ProdTitleLabel.TabIndex = 2
        ProdTitleLabel.Text = "Prod Title:"
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(420, 3)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 44
        UnitPriceLabel.Text = "Unit Price:"
        '
        'OldPriceLabel
        '
        OldPriceLabel.AutoSize = True
        OldPriceLabel.Location = New System.Drawing.Point(354, 3)
        OldPriceLabel.Name = "OldPriceLabel"
        OldPriceLabel.Size = New System.Drawing.Size(53, 13)
        OldPriceLabel.TabIndex = 6
        OldPriceLabel.Text = "Old Price:"
        '
        'PInvNoLabel
        '
        PInvNoLabel.AutoSize = True
        PInvNoLabel.Location = New System.Drawing.Point(32, 16)
        PInvNoLabel.Name = "PInvNoLabel"
        PInvNoLabel.Size = New System.Drawing.Size(49, 13)
        PInvNoLabel.TabIndex = 36
        PInvNoLabel.Text = "PInv No:"
        '
        'SaleTaxAmountLabel
        '
        SaleTaxAmountLabel.AutoSize = True
        SaleTaxAmountLabel.Location = New System.Drawing.Point(574, 38)
        SaleTaxAmountLabel.Name = "SaleTaxAmountLabel"
        SaleTaxAmountLabel.Size = New System.Drawing.Size(91, 13)
        SaleTaxAmountLabel.TabIndex = 45
        SaleTaxAmountLabel.Text = "Sale Tax Amount:"
        '
        'FileNoLabel
        '
        FileNoLabel.AutoSize = True
        FileNoLabel.Location = New System.Drawing.Point(574, 13)
        FileNoLabel.Name = "FileNoLabel"
        FileNoLabel.Size = New System.Drawing.Size(43, 13)
        FileNoLabel.TabIndex = 44
        FileNoLabel.Text = "File No:"
        '
        'StoreLabel
        '
        StoreLabel.AutoSize = True
        StoreLabel.Location = New System.Drawing.Point(32, 69)
        StoreLabel.Name = "StoreLabel"
        StoreLabel.Size = New System.Drawing.Size(35, 13)
        StoreLabel.TabIndex = 38
        StoreLabel.Text = "Store:"
        '
        'PInvDateLabel
        '
        PInvDateLabel.AutoSize = True
        PInvDateLabel.Location = New System.Drawing.Point(282, 13)
        PInvDateLabel.Name = "PInvDateLabel"
        PInvDateLabel.Size = New System.Drawing.Size(58, 13)
        PInvDateLabel.TabIndex = 40
        PInvDateLabel.Text = "PInv Date:"
        '
        'CurrencyRateLabel
        '
        CurrencyRateLabel.AutoSize = True
        CurrencyRateLabel.Location = New System.Drawing.Point(574, 95)
        CurrencyRateLabel.Name = "CurrencyRateLabel"
        CurrencyRateLabel.Size = New System.Drawing.Size(78, 13)
        CurrencyRateLabel.TabIndex = 47
        CurrencyRateLabel.Text = "Currency Rate:"
        '
        'CurrencyNameLabel
        '
        CurrencyNameLabel.AutoSize = True
        CurrencyNameLabel.Location = New System.Drawing.Point(282, 91)
        CurrencyNameLabel.Name = "CurrencyNameLabel"
        CurrencyNameLabel.Size = New System.Drawing.Size(83, 13)
        CurrencyNameLabel.TabIndex = 43
        CurrencyNameLabel.Text = "Currency Name:"
        '
        'Payment_TypeLabel
        '
        Payment_TypeLabel.AutoSize = True
        Payment_TypeLabel.Location = New System.Drawing.Point(32, 91)
        Payment_TypeLabel.Name = "Payment_TypeLabel"
        Payment_TypeLabel.Size = New System.Drawing.Size(78, 13)
        Payment_TypeLabel.TabIndex = 39
        Payment_TypeLabel.Text = "Payment Type:"
        '
        'OtherExpLabel
        '
        OtherExpLabel.AutoSize = True
        OtherExpLabel.Location = New System.Drawing.Point(574, 66)
        OtherExpLabel.Name = "OtherExpLabel"
        OtherExpLabel.Size = New System.Drawing.Size(57, 13)
        OtherExpLabel.TabIndex = 46
        OtherExpLabel.Text = "Other Exp:"
        '
        'VendTitleLabel
        '
        VendTitleLabel.AutoSize = True
        VendTitleLabel.Location = New System.Drawing.Point(282, 67)
        VendTitleLabel.Name = "VendTitleLabel"
        VendTitleLabel.Size = New System.Drawing.Size(58, 13)
        VendTitleLabel.TabIndex = 42
        VendTitleLabel.Text = "Vend Title:"
        '
        'BENoLabel
        '
        BENoLabel.AutoSize = True
        BENoLabel.Location = New System.Drawing.Point(32, 42)
        BENoLabel.Name = "BENoLabel"
        BENoLabel.Size = New System.Drawing.Size(38, 13)
        BENoLabel.TabIndex = 37
        BENoLabel.Text = "BENo:"
        '
        'BEDateLabel
        '
        BEDateLabel.AutoSize = True
        BEDateLabel.Location = New System.Drawing.Point(282, 39)
        BEDateLabel.Name = "BEDateLabel"
        BEDateLabel.Size = New System.Drawing.Size(47, 13)
        BEDateLabel.TabIndex = 41
        BEDateLabel.Text = "BEDate:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(616, 3)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 13)
        Label2.TabIndex = 11
        Label2.Text = "Total Cost:"
        '
        'PInvoice_MainBindingNavigator
        '
        Me.PInvoice_MainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PInvoice_MainBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.PInvoice_MainBindingNavigator.BindingSource = Me.PInvoice_MainBindingSource
        Me.PInvoice_MainBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PInvoice_MainBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PInvoice_MainBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PInvoice_MainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PInvoice_MainBindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.PInvoice_MainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PInvoice_MainBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PInvoice_MainBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PInvoice_MainBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PInvoice_MainBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PInvoice_MainBindingNavigator.Name = "PInvoice_MainBindingNavigator"
        Me.PInvoice_MainBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PInvoice_MainBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.PInvoice_MainBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.PInvoice_MainBindingNavigator.TabIndex = 0
        Me.PInvoice_MainBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(75, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PInvoice_MainBindingSource
        '
        Me.PInvoice_MainBindingSource.DataMember = "PInvoice_Main"
        Me.PInvoice_MainBindingSource.DataSource = Me.ISPASDataSet
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PInvoice_MainBindingNavigatorSaveItem
        '
        Me.PInvoice_MainBindingNavigatorSaveItem.Image = CType(resources.GetObject("PInvoice_MainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PInvoice_MainBindingNavigatorSaveItem.Name = "PInvoice_MainBindingNavigatorSaveItem"
        Me.PInvoice_MainBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.PInvoice_MainBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(54, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'ADVendorsBindingSource
        '
        Me.ADVendorsBindingSource.DataMember = "AD_Vendors"
        Me.ADVendorsBindingSource.DataSource = Me.ISPASDataSet
        '
        'CurrencyRateBindingSource
        '
        Me.CurrencyRateBindingSource.DataMember = "CurrencyRate"
        Me.CurrencyRateBindingSource.DataSource = Me.ISPASDataSet
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "Discount", True))
        Me.DiscountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTextBox.Location = New System.Drawing.Point(636, 4)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(110, 20)
        Me.DiscountTextBox.TabIndex = 0
        Me.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetInvoiceAmountTextBox
        '
        Me.NetInvoiceAmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NetInvoiceAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "NetInvoiceAmount", True))
        Me.NetInvoiceAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetInvoiceAmountTextBox.Location = New System.Drawing.Point(636, 77)
        Me.NetInvoiceAmountTextBox.Name = "NetInvoiceAmountTextBox"
        Me.NetInvoiceAmountTextBox.ReadOnly = True
        Me.NetInvoiceAmountTextBox.Size = New System.Drawing.Size(110, 20)
        Me.NetInvoiceAmountTextBox.TabIndex = 3
        Me.NetInvoiceAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DutyExpTextBox
        '
        Me.DutyExpTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DutyExpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "DutyExp", True))
        Me.DutyExpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DutyExpTextBox.Location = New System.Drawing.Point(636, 27)
        Me.DutyExpTextBox.Name = "DutyExpTextBox"
        Me.DutyExpTextBox.ReadOnly = True
        Me.DutyExpTextBox.Size = New System.Drawing.Size(110, 20)
        Me.DutyExpTextBox.TabIndex = 1
        Me.DutyExpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'POrderNoTextBox
        '
        Me.POrderNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "POrderNo", True))
        Me.POrderNoTextBox.Location = New System.Drawing.Point(0, 120)
        Me.POrderNoTextBox.Name = "POrderNoTextBox"
        Me.POrderNoTextBox.Size = New System.Drawing.Size(59, 20)
        Me.POrderNoTextBox.TabIndex = 12
        '
        'TotalAmount_RsTextBox
        '
        Me.TotalAmount_RsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalAmount_RsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "TotalAmount_Rs", True))
        Me.TotalAmount_RsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount_RsTextBox.Location = New System.Drawing.Point(636, 53)
        Me.TotalAmount_RsTextBox.Name = "TotalAmount_RsTextBox"
        Me.TotalAmount_RsTextBox.ReadOnly = True
        Me.TotalAmount_RsTextBox.Size = New System.Drawing.Size(110, 20)
        Me.TotalAmount_RsTextBox.TabIndex = 2
        Me.TotalAmount_RsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StoresBindingSource
        '
        Me.StoresBindingSource.DataMember = "Stores"
        Me.StoresBindingSource.DataSource = Me.ISPASDataSet
        '
        'PInvoice_DetailsDataGridView
        '
        Me.PInvoice_DetailsDataGridView.AllowUserToAddRows = False
        Me.PInvoice_DetailsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.PInvoice_DetailsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PInvoice_DetailsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PInvoice_DetailsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PInvoice_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PInvoice_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PInvDNo, Me.PInvMainNo, Me.Product, Me.Quantity, Me.UnitPrice, Me.Duty, Me.TotalCost, Me.OldPrice})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PInvoice_DetailsDataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.PInvoice_DetailsDataGridView.Location = New System.Drawing.Point(9, 47)
        Me.PInvoice_DetailsDataGridView.Name = "PInvoice_DetailsDataGridView"
        Me.PInvoice_DetailsDataGridView.ReadOnly = True
        Me.PInvoice_DetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PInvoice_DetailsDataGridView.Size = New System.Drawing.Size(749, 204)
        Me.PInvoice_DetailsDataGridView.TabIndex = 7
        Me.PInvoice_DetailsDataGridView.Visible = False
        '
        'PInvDNo
        '
        Me.PInvDNo.DataPropertyName = "PinvDNo"
        Me.PInvDNo.HeaderText = "PInvDID"
        Me.PInvDNo.Name = "PInvDNo"
        Me.PInvDNo.ReadOnly = True
        Me.PInvDNo.Visible = False
        '
        'PInvMainNo
        '
        Me.PInvMainNo.DataPropertyName = "PInvNo"
        Me.PInvMainNo.HeaderText = "PInvMainNo"
        Me.PInvMainNo.Name = "PInvMainNo"
        Me.PInvMainNo.ReadOnly = True
        Me.PInvMainNo.Visible = False
        '
        'Product
        '
        Me.Product.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Product.DefaultCellStyle = DataGridViewCellStyle2
        Me.Product.FillWeight = 210.084!
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        Me.Product.ReadOnly = True
        Me.Product.Width = 300
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity.FillWeight = 58.83902!
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 84
        '
        'UnitPrice
        '
        Me.UnitPrice.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.UnitPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.UnitPrice.FillWeight = 68.83278!
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        Me.UnitPrice.Width = 98
        '
        'Duty
        '
        Me.Duty.DataPropertyName = "Duty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.Duty.DefaultCellStyle = DataGridViewCellStyle5
        Me.Duty.FillWeight = 77.42687!
        Me.Duty.HeaderText = "Duty"
        Me.Duty.Name = "Duty"
        Me.Duty.ReadOnly = True
        Me.Duty.Width = 111
        '
        'TotalCost
        '
        Me.TotalCost.DataPropertyName = "TotalCost"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.TotalCost.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalCost.FillWeight = 84.81731!
        Me.TotalCost.HeaderText = "Total Cost"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.ReadOnly = True
        Me.TotalCost.Width = 121
        '
        'OldPrice
        '
        Me.OldPrice.DataPropertyName = "OldPrice"
        Me.OldPrice.HeaderText = "Old Price"
        Me.OldPrice.Name = "OldPrice"
        Me.OldPrice.ReadOnly = True
        Me.OldPrice.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TotalCostTextBox)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(QuantityLabel)
        Me.Panel2.Controls.Add(DutyLabel)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.UnitPriceTextBox)
        Me.Panel2.Controls.Add(Me.QuantityTextBox)
        Me.Panel2.Controls.Add(ProdTitleLabel)
        Me.Panel2.Controls.Add(Me.DutyTextBox)
        Me.Panel2.Controls.Add(Me.OldPriceTextBox)
        Me.Panel2.Controls.Add(UnitPriceLabel)
        Me.Panel2.Controls.Add(OldPriceLabel)
        Me.Panel2.Controls.Add(Me.PInvoice_DetailsDataGridView)
        Me.Panel2.Controls.Add(Me.PInvoice_DetailsDataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(6, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 369)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(NetInvoiceAmountLabel)
        Me.Panel3.Controls.Add(Me.NetInvoiceAmountTextBox)
        Me.Panel3.Controls.Add(DiscountLabel)
        Me.Panel3.Controls.Add(Me.DutyExpTextBox)
        Me.Panel3.Controls.Add(Me.DiscountTextBox)
        Me.Panel3.Controls.Add(Me.TotalAmount_RsTextBox)
        Me.Panel3.Controls.Add(TotalAmount_RsLabel)
        Me.Panel3.Controls.Add(DutyExpLabel)
        Me.Panel3.Location = New System.Drawing.Point(9, 257)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(749, 100)
        Me.Panel3.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(522, 88)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Rs. 0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(614, 19)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(51, 22)
        Me.TotalCostTextBox.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(330, 22)
        Me.TextBox1.TabIndex = 0
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(423, 19)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(51, 22)
        Me.UnitPriceTextBox.TabIndex = 2
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(555, 19)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(51, 22)
        Me.QuantityTextBox.TabIndex = 4
        '
        'DutyTextBox
        '
        Me.DutyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DutyTextBox.Location = New System.Drawing.Point(492, 19)
        Me.DutyTextBox.Name = "DutyTextBox"
        Me.DutyTextBox.Size = New System.Drawing.Size(57, 22)
        Me.DutyTextBox.TabIndex = 3
        '
        'OldPriceTextBox
        '
        Me.OldPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldPriceTextBox.Location = New System.Drawing.Point(357, 19)
        Me.OldPriceTextBox.Name = "OldPriceTextBox"
        Me.OldPriceTextBox.ReadOnly = True
        Me.OldPriceTextBox.Size = New System.Drawing.Size(51, 22)
        Me.OldPriceTextBox.TabIndex = 1
        '
        'PInvoice_DetailsDataGridView1
        '
        Me.PInvoice_DetailsDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PInvoice_DetailsDataGridView1.AutoGenerateColumns = False
        Me.PInvoice_DetailsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PInvoice_DetailsDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.PInvoice_DetailsDataGridView1.DataSource = Me.PInvoice_DetailsBindingSource
        Me.PInvoice_DetailsDataGridView1.Location = New System.Drawing.Point(9, 47)
        Me.PInvoice_DetailsDataGridView1.Name = "PInvoice_DetailsDataGridView1"
        Me.PInvoice_DetailsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PInvoice_DetailsDataGridView1.Size = New System.Drawing.Size(749, 204)
        Me.PInvoice_DetailsDataGridView1.TabIndex = 46
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PinvDNo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PinvDNo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PInvNo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PInvNo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ProdTitle"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 300
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Duty"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Duty"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TotalCost"
        Me.DataGridViewTextBoxColumn21.HeaderText = "TotalCost"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "OldPrice"
        Me.DataGridViewTextBoxColumn22.HeaderText = "OldPrice"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'PInvoice_DetailsBindingSource
        '
        Me.PInvoice_DetailsBindingSource.DataMember = "PInvoice_MainPInvoice_Details"
        Me.PInvoice_DetailsBindingSource.DataSource = Me.PInvoice_MainBindingSource
        '
        'AD_ProductsDataGridView
        '
        Me.AD_ProductsDataGridView.AllowUserToAddRows = False
        Me.AD_ProductsDataGridView.AllowUserToDeleteRows = False
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdTitleDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn})
        Me.AD_ProductsDataGridView.DataSource = Me.ADProductsBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AD_ProductsDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.AD_ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(770, 118)
        Me.AD_ProductsDataGridView.TabIndex = 6
        Me.AD_ProductsDataGridView.Visible = False
        '
        'ProdTitleDataGridViewTextBoxColumn
        '
        Me.ProdTitleDataGridViewTextBoxColumn.DataPropertyName = "ProdTitle"
        Me.ProdTitleDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProdTitleDataGridViewTextBoxColumn.Name = "ProdTitleDataGridViewTextBoxColumn"
        Me.ProdTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADProductsBindingSource
        '
        Me.ADProductsBindingSource.DataMember = "AD_Products"
        Me.ADProductsBindingSource.DataSource = Me.ISPASDataSet
        '
        'PInvoice_MainTableAdapter
        '
        Me.PInvoice_MainTableAdapter.ClearBeforeFill = True
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'Cp_VoucherTableAdapter
        '
        Me.Cp_VoucherTableAdapter.ClearBeforeFill = True
        '
        'CurrencyRateTableAdapter
        '
        Me.CurrencyRateTableAdapter.ClearBeforeFill = True
        '
        'LedgerTableAdapter
        '
        Me.LedgerTableAdapter.ClearBeforeFill = True
        '
        'StoresTableAdapter
        '
        Me.StoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Nothing
        Me.TableAdapterManager.AD_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.AD_EmpTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProdCatTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProductsTableAdapter = Me.AD_ProductsTableAdapter
        Me.TableAdapterManager.AD_VendorsTableAdapter = Me.AD_VendorsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.Bp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Br_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Cp_VoucherTableAdapter = Me.Cp_VoucherTableAdapter
        Me.TableAdapterManager.Cr_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyRateTableAdapter = Me.CurrencyRateTableAdapter
        Me.TableAdapterManager.DC_DetailTableAdapter = Nothing
        Me.TableAdapterManager.DC_MainTableAdapter = Nothing
        Me.TableAdapterManager.EMICalcTableAdapter = Nothing
        Me.TableAdapterManager.EMISchemeTableAdapter = Nothing
        Me.TableAdapterManager.LedgerTableAdapter = Me.LedgerTableAdapter
        Me.TableAdapterManager.MasterTableAdapter = Nothing
        Me.TableAdapterManager.MenuSettingTableAdapter = Nothing
        Me.TableAdapterManager.NewAccountsTableAdapter = Nothing
        Me.TableAdapterManager.PickListTableAdapter = Nothing
        Me.TableAdapterManager.PInvoice_DetailsTableAdapter = Me.PInvoice_DetailsTableAdapter
        Me.TableAdapterManager.PInvoice_MainTableAdapter = Me.PInvoice_MainTableAdapter
        Me.TableAdapterManager.POrder_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.POrder_MainTableAdapter = Nothing
        Me.TableAdapterManager.Quatation_DTableAdapter = Nothing
        Me.TableAdapterManager.Quatation_MTableAdapter = Nothing
        Me.TableAdapterManager.Sale_ReturnTableAdapter = Nothing
        Me.TableAdapterManager.SaleInvoice_DTableAdapter = Nothing
        Me.TableAdapterManager.SaleInvoice_MTableAdapter = Nothing
        Me.TableAdapterManager.StoresTableAdapter = Me.StoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_DTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_MTableAdapter = Nothing
        '
        'PInvoice_DetailsTableAdapter
        '
        Me.PInvoice_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Panel1.Controls.Add(PInvNoLabel)
        Me.Panel1.Controls.Add(SaleTaxAmountLabel)
        Me.Panel1.Controls.Add(Me.FileNoTextBox)
        Me.Panel1.Controls.Add(Me.StoreComboBox)
        Me.Panel1.Controls.Add(Me.SaleTaxAmountTextBox)
        Me.Panel1.Controls.Add(Me.PInvNoTextBox)
        Me.Panel1.Controls.Add(FileNoLabel)
        Me.Panel1.Controls.Add(StoreLabel)
        Me.Panel1.Controls.Add(Me.CurrencyRateTextBox)
        Me.Panel1.Controls.Add(PInvDateLabel)
        Me.Panel1.Controls.Add(CurrencyRateLabel)
        Me.Panel1.Controls.Add(Me.Payment_TypeComboBox)
        Me.Panel1.Controls.Add(Me.CurrencyNameComboBox)
        Me.Panel1.Controls.Add(Me.PInvDateDateTimePicker)
        Me.Panel1.Controls.Add(CurrencyNameLabel)
        Me.Panel1.Controls.Add(Payment_TypeLabel)
        Me.Panel1.Controls.Add(OtherExpLabel)
        Me.Panel1.Controls.Add(VendTitleLabel)
        Me.Panel1.Controls.Add(Me.BEDateDateTimePicker)
        Me.Panel1.Controls.Add(Me.VendTitleComboBox)
        Me.Panel1.Controls.Add(Me.OtherExpTextBox)
        Me.Panel1.Controls.Add(BENoLabel)
        Me.Panel1.Controls.Add(BEDateLabel)
        Me.Panel1.Controls.Add(Me.BENoTextBox)
        Me.Panel1.Controls.Add(Me.POrderNoTextBox)
        Me.Panel1.Controls.Add(POrderNoLabel)
        Me.Panel1.Location = New System.Drawing.Point(6, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 118)
        Me.Panel1.TabIndex = 0
        '
        'FileNoTextBox
        '
        Me.FileNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "FileNo", True))
        Me.FileNoTextBox.Location = New System.Drawing.Point(672, 9)
        Me.FileNoTextBox.Name = "FileNoTextBox"
        Me.FileNoTextBox.Size = New System.Drawing.Size(73, 20)
        Me.FileNoTextBox.TabIndex = 8
        '
        'StoreComboBox
        '
        Me.StoreComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StoreComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "Store", True))
        Me.StoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PInvoice_MainBindingSource, "Store", True))
        Me.StoreComboBox.DataSource = Me.StoresBindingSource
        Me.StoreComboBox.DisplayMember = "StoreName"
        Me.StoreComboBox.FormattingEnabled = True
        Me.StoreComboBox.Location = New System.Drawing.Point(119, 62)
        Me.StoreComboBox.Name = "StoreComboBox"
        Me.StoreComboBox.Size = New System.Drawing.Size(147, 21)
        Me.StoreComboBox.TabIndex = 2
        Me.StoreComboBox.ValueMember = "StoreName"
        '
        'SaleTaxAmountTextBox
        '
        Me.SaleTaxAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "SaleTaxAmount", True))
        Me.SaleTaxAmountTextBox.Location = New System.Drawing.Point(672, 35)
        Me.SaleTaxAmountTextBox.Name = "SaleTaxAmountTextBox"
        Me.SaleTaxAmountTextBox.Size = New System.Drawing.Size(73, 20)
        Me.SaleTaxAmountTextBox.TabIndex = 9
        '
        'PInvNoTextBox
        '
        Me.PInvNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "PInvNo", True))
        Me.PInvNoTextBox.Location = New System.Drawing.Point(119, 13)
        Me.PInvNoTextBox.Name = "PInvNoTextBox"
        Me.PInvNoTextBox.ReadOnly = True
        Me.PInvNoTextBox.Size = New System.Drawing.Size(72, 20)
        Me.PInvNoTextBox.TabIndex = 0
        '
        'CurrencyRateTextBox
        '
        Me.CurrencyRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "CurrencyRate", True))
        Me.CurrencyRateTextBox.Location = New System.Drawing.Point(672, 90)
        Me.CurrencyRateTextBox.Name = "CurrencyRateTextBox"
        Me.CurrencyRateTextBox.ReadOnly = True
        Me.CurrencyRateTextBox.Size = New System.Drawing.Size(73, 20)
        Me.CurrencyRateTextBox.TabIndex = 11
        '
        'Payment_TypeComboBox
        '
        Me.Payment_TypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Payment_TypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Payment_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "Payment_Type", True))
        Me.Payment_TypeComboBox.FormattingEnabled = True
        Me.Payment_TypeComboBox.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.Payment_TypeComboBox.Location = New System.Drawing.Point(119, 87)
        Me.Payment_TypeComboBox.Name = "Payment_TypeComboBox"
        Me.Payment_TypeComboBox.Size = New System.Drawing.Size(147, 21)
        Me.Payment_TypeComboBox.TabIndex = 3
        '
        'CurrencyNameComboBox
        '
        Me.CurrencyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CurrencyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CurrencyNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "CurrencyName", True))
        Me.CurrencyNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PInvoice_MainBindingSource, "CurrencyName", True))
        Me.CurrencyNameComboBox.DataSource = Me.CurrencyRateBindingSource
        Me.CurrencyNameComboBox.DisplayMember = "CurrencyName"
        Me.CurrencyNameComboBox.FormattingEnabled = True
        Me.CurrencyNameComboBox.Location = New System.Drawing.Point(368, 87)
        Me.CurrencyNameComboBox.Name = "CurrencyNameComboBox"
        Me.CurrencyNameComboBox.Size = New System.Drawing.Size(96, 21)
        Me.CurrencyNameComboBox.TabIndex = 7
        Me.CurrencyNameComboBox.ValueMember = "CurrencyName"
        '
        'PInvDateDateTimePicker
        '
        Me.PInvDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "PInvDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.PInvDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PInvoice_MainBindingSource, "PInvDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.PInvDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PInvDateDateTimePicker.Location = New System.Drawing.Point(368, 9)
        Me.PInvDateDateTimePicker.Name = "PInvDateDateTimePicker"
        Me.PInvDateDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.PInvDateDateTimePicker.TabIndex = 4
        '
        'BEDateDateTimePicker
        '
        Me.BEDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "BEDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.BEDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PInvoice_MainBindingSource, "BEDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.BEDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BEDateDateTimePicker.Location = New System.Drawing.Point(368, 34)
        Me.BEDateDateTimePicker.Name = "BEDateDateTimePicker"
        Me.BEDateDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.BEDateDateTimePicker.TabIndex = 5
        '
        'VendTitleComboBox
        '
        Me.VendTitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.VendTitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.VendTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "VendTitle", True))
        Me.VendTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PInvoice_MainBindingSource, "VendTitle", True))
        Me.VendTitleComboBox.DataSource = Me.ADVendorsBindingSource
        Me.VendTitleComboBox.DisplayMember = "VendTitle"
        Me.VendTitleComboBox.FormattingEnabled = True
        Me.VendTitleComboBox.Location = New System.Drawing.Point(368, 61)
        Me.VendTitleComboBox.Name = "VendTitleComboBox"
        Me.VendTitleComboBox.Size = New System.Drawing.Size(153, 21)
        Me.VendTitleComboBox.TabIndex = 6
        Me.VendTitleComboBox.ValueMember = "VendTitle"
        '
        'OtherExpTextBox
        '
        Me.OtherExpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "OtherExp", True))
        Me.OtherExpTextBox.Location = New System.Drawing.Point(672, 63)
        Me.OtherExpTextBox.Name = "OtherExpTextBox"
        Me.OtherExpTextBox.Size = New System.Drawing.Size(73, 20)
        Me.OtherExpTextBox.TabIndex = 10
        '
        'BENoTextBox
        '
        Me.BENoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PInvoice_MainBindingSource, "BENo", True))
        Me.BENoTextBox.Location = New System.Drawing.Point(119, 39)
        Me.BENoTextBox.Name = "BENoTextBox"
        Me.BENoTextBox.Size = New System.Drawing.Size(72, 20)
        Me.BENoTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(792, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Purchase Invoice"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(787, 503)
        Me.SplitContainer1.SplitterDistance = 432
        Me.SplitContainer1.TabIndex = 2
        '
        'AD_VendorsBindingSource
        '
        Me.AD_VendorsBindingSource.DataMember = "AD_Vendors"
        Me.AD_VendorsBindingSource.DataSource = Me.ISPASDataSet
        '
        'frmPurchaseInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PInvoice_MainBindingNavigator)
        Me.Name = "frmPurchaseInvoice"
        Me.Text = "Purchase Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PInvoice_MainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PInvoice_MainBindingNavigator.ResumeLayout(False)
        Me.PInvoice_MainBindingNavigator.PerformLayout()
        CType(Me.PInvoice_MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyRateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PInvoice_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PInvoice_DetailsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PInvoice_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AD_VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents PInvoice_MainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PInvoice_MainTableAdapter As ISPASystem.ISPASDataSetTableAdapters.PInvoice_MainTableAdapter
    Friend WithEvents PInvoice_MainBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PInvoice_MainBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetInvoiceAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DutyExpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POrderNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmount_RsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PInvoice_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StoresTableAdapter As ISPASystem.ISPASDataSetTableAdapters.StoresTableAdapter
    Friend WithEvents StoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents ADVendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrencyRateTableAdapter As ISPASystem.ISPASDataSetTableAdapters.CurrencyRateTableAdapter
    Friend WithEvents CurrencyRateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents ADProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LedgerTableAdapter As ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
    Friend WithEvents Cp_VoucherTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Cp_VoucherTableAdapter
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DutyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OldPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProdTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PInvDNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PInvMainNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OldPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PInvoice_DetailsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.PInvoice_DetailsTableAdapter
    Friend WithEvents PInvoice_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PInvoice_DetailsDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaleTaxAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PInvNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrencyRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Payment_TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CurrencyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PInvDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BEDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VendTitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OtherExpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BENoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AD_VendorsBindingSource As System.Windows.Forms.BindingSource

End Class
