<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Dim POrderNoLabel As System.Windows.Forms.Label
        Dim POrderDateLabel As System.Windows.Forms.Label
        Dim VendorLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim FromCompanyLabel As System.Windows.Forms.Label
        Dim TNoteLabel As System.Windows.Forms.Label
        Dim TotalAmountLabel As System.Windows.Forms.Label
        Dim ProdTitleLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrder))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.POrder_MainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.POrder_MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.POrder_MainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.POrderNoTextBox = New System.Windows.Forms.TextBox
        Me.POrderDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.VendorComboBox = New System.Windows.Forms.ComboBox
        Me.ADVendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttentionTextBox = New System.Windows.Forms.TextBox
        Me.FromCompanyTextBox = New System.Windows.Forms.TextBox
        Me.TNoteTextBox = New System.Windows.Forms.TextBox
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.ProdTitleTextBox = New System.Windows.Forms.TextBox
        Me.POrder_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox
        Me.POrder_MainTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.POrder_MainTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.AD_VendorsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
        Me.POrder_DetailsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.POrder_DetailsTableAdapter
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ODN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdTit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.POrder_DetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        POrderNoLabel = New System.Windows.Forms.Label
        POrderDateLabel = New System.Windows.Forms.Label
        VendorLabel = New System.Windows.Forms.Label
        AttentionLabel = New System.Windows.Forms.Label
        FromCompanyLabel = New System.Windows.Forms.Label
        TNoteLabel = New System.Windows.Forms.Label
        TotalAmountLabel = New System.Windows.Forms.Label
        ProdTitleLabel = New System.Windows.Forms.Label
        QuantityLabel = New System.Windows.Forms.Label
        UnitPriceLabel = New System.Windows.Forms.Label
        TotalCostLabel = New System.Windows.Forms.Label
        CType(Me.POrder_MainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POrder_MainBindingNavigator.SuspendLayout()
        CType(Me.POrder_MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.POrder_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POrder_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'POrderNoLabel
        '
        POrderNoLabel.AutoSize = True
        POrderNoLabel.Location = New System.Drawing.Point(11, 8)
        POrderNoLabel.Name = "POrderNoLabel"
        POrderNoLabel.Size = New System.Drawing.Size(62, 13)
        POrderNoLabel.TabIndex = 1
        POrderNoLabel.Text = "Order No:"
        '
        'POrderDateLabel
        '
        POrderDateLabel.AutoSize = True
        POrderDateLabel.Location = New System.Drawing.Point(11, 32)
        POrderDateLabel.Name = "POrderDateLabel"
        POrderDateLabel.Size = New System.Drawing.Size(38, 13)
        POrderDateLabel.TabIndex = 3
        POrderDateLabel.Text = "Date:"
        '
        'VendorLabel
        '
        VendorLabel.AutoSize = True
        VendorLabel.Location = New System.Drawing.Point(11, 66)
        VendorLabel.Name = "VendorLabel"
        VendorLabel.Size = New System.Drawing.Size(51, 13)
        VendorLabel.TabIndex = 5
        VendorLabel.Text = "Vendor:"
        '
        'AttentionLabel
        '
        AttentionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(479, 9)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(62, 13)
        AttentionLabel.TabIndex = 7
        AttentionLabel.Text = "Attention:"
        '
        'FromCompanyLabel
        '
        FromCompanyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FromCompanyLabel.AutoSize = True
        FromCompanyLabel.Location = New System.Drawing.Point(477, 32)
        FromCompanyLabel.Name = "FromCompanyLabel"
        FromCompanyLabel.Size = New System.Drawing.Size(62, 13)
        FromCompanyLabel.TabIndex = 9
        FromCompanyLabel.Text = "Company:"
        '
        'TNoteLabel
        '
        TNoteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TNoteLabel.AutoSize = True
        TNoteLabel.Location = New System.Drawing.Point(498, 55)
        TNoteLabel.Name = "TNoteLabel"
        TNoteLabel.Size = New System.Drawing.Size(38, 13)
        TNoteLabel.TabIndex = 11
        TNoteLabel.Text = "Note:"
        '
        'TotalAmountLabel
        '
        TotalAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalAmountLabel.AutoSize = True
        TotalAmountLabel.Location = New System.Drawing.Point(485, 79)
        TotalAmountLabel.Name = "TotalAmountLabel"
        TotalAmountLabel.Size = New System.Drawing.Size(53, 13)
        TotalAmountLabel.TabIndex = 13
        TotalAmountLabel.Text = "Amount:"
        '
        'ProdTitleLabel
        '
        ProdTitleLabel.AutoSize = True
        ProdTitleLabel.Location = New System.Drawing.Point(16, 19)
        ProdTitleLabel.Name = "ProdTitleLabel"
        ProdTitleLabel.Size = New System.Drawing.Size(66, 13)
        ProdTitleLabel.TabIndex = 4
        ProdTitleLabel.Text = "Prod Title:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(16, 45)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(58, 13)
        QuantityLabel.TabIndex = 6
        QuantityLabel.Text = "Quantity:"
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(16, 71)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(67, 13)
        UnitPriceLabel.TabIndex = 8
        UnitPriceLabel.Text = "Unit Price:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Location = New System.Drawing.Point(16, 97)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(69, 13)
        TotalCostLabel.TabIndex = 10
        TotalCostLabel.Text = "Total Cost:"
        '
        'POrder_MainBindingNavigator
        '
        Me.POrder_MainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.POrder_MainBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.POrder_MainBindingNavigator.BindingSource = Me.POrder_MainBindingSource
        Me.POrder_MainBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.POrder_MainBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.POrder_MainBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POrder_MainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.POrder_MainBindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.POrder_MainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.POrder_MainBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.POrder_MainBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.POrder_MainBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.POrder_MainBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.POrder_MainBindingNavigator.Name = "POrder_MainBindingNavigator"
        Me.POrder_MainBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.POrder_MainBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.POrder_MainBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.POrder_MainBindingNavigator.TabIndex = 0
        Me.POrder_MainBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(75, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'POrder_MainBindingSource
        '
        Me.POrder_MainBindingSource.DataMember = "POrder_Main"
        Me.POrder_MainBindingSource.DataSource = Me.ISPASDataSet
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
        'POrder_MainBindingNavigatorSaveItem
        '
        Me.POrder_MainBindingNavigatorSaveItem.Image = CType(resources.GetObject("POrder_MainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.POrder_MainBindingNavigatorSaveItem.Name = "POrder_MainBindingNavigatorSaveItem"
        Me.POrder_MainBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.POrder_MainBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(54, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'POrderNoTextBox
        '
        Me.POrderNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_MainBindingSource, "POrderNo", True))
        Me.POrderNoTextBox.Location = New System.Drawing.Point(79, 6)
        Me.POrderNoTextBox.Name = "POrderNoTextBox"
        Me.POrderNoTextBox.ReadOnly = True
        Me.POrderNoTextBox.Size = New System.Drawing.Size(98, 20)
        Me.POrderNoTextBox.TabIndex = 0
        Me.POrderNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'POrderDateDateTimePicker
        '
        Me.POrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.POrder_MainBindingSource, "POrderDate", True))
        Me.POrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_MainBindingSource, "POrderDate", True))
        Me.POrderDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.POrderDateDateTimePicker.Location = New System.Drawing.Point(79, 32)
        Me.POrderDateDateTimePicker.Name = "POrderDateDateTimePicker"
        Me.POrderDateDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.POrderDateDateTimePicker.TabIndex = 2
        '
        'VendorComboBox
        '
        Me.VendorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.VendorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.VendorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_MainBindingSource, "Vendor", True))
        Me.VendorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.POrder_MainBindingSource, "Vendor", True))
        Me.VendorComboBox.DataSource = Me.ADVendorsBindingSource
        Me.VendorComboBox.DisplayMember = "VendTitle"
        Me.VendorComboBox.FormattingEnabled = True
        Me.VendorComboBox.Location = New System.Drawing.Point(79, 63)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(240, 21)
        Me.VendorComboBox.TabIndex = 1
        Me.VendorComboBox.ValueMember = "VendTitle"
        '
        'ADVendorsBindingSource
        '
        Me.ADVendorsBindingSource.DataMember = "AD_Vendors"
        Me.ADVendorsBindingSource.DataSource = Me.ISPASDataSet
        '
        'AttentionTextBox
        '
        Me.AttentionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttentionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_MainBindingSource, "Attention", True))
        Me.AttentionTextBox.Location = New System.Drawing.Point(537, 6)
        Me.AttentionTextBox.Multiline = True
        Me.AttentionTextBox.Name = "AttentionTextBox"
        Me.AttentionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AttentionTextBox.TabIndex = 3
        '
        'FromCompanyTextBox
        '
        Me.FromCompanyTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FromCompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_MainBindingSource, "FromCompany", True))
        Me.FromCompanyTextBox.Location = New System.Drawing.Point(537, 29)
        Me.FromCompanyTextBox.Multiline = True
        Me.FromCompanyTextBox.Name = "FromCompanyTextBox"
        Me.FromCompanyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FromCompanyTextBox.TabIndex = 4
        '
        'TNoteTextBox
        '
        Me.TNoteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_MainBindingSource, "tNote", True))
        Me.TNoteTextBox.Location = New System.Drawing.Point(537, 52)
        Me.TNoteTextBox.Multiline = True
        Me.TNoteTextBox.Name = "TNoteTextBox"
        Me.TNoteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TNoteTextBox.TabIndex = 5
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_MainBindingSource, "TotalAmount", True))
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(537, 76)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalAmountTextBox.TabIndex = 0
        Me.TotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.Location = New System.Drawing.Point(8, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(371, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(108, 20)
        Me.TextBox2.TabIndex = 1
        '
        'AD_ProductsDataGridView
        '
        Me.AD_ProductsDataGridView.AllowUserToAddRows = False
        Me.AD_ProductsDataGridView.AllowUserToDeleteRows = False
        Me.AD_ProductsDataGridView.AllowUserToResizeColumns = False
        Me.AD_ProductsDataGridView.AllowUserToResizeRows = False
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AD_ProductsDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12})
        Me.AD_ProductsDataGridView.DataSource = Me.AD_ProductsBindingSource
        Me.AD_ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(774, 135)
        Me.AD_ProductsDataGridView.StandardTab = True
        Me.AD_ProductsDataGridView.TabIndex = 18
        Me.AD_ProductsDataGridView.TabStop = False
        Me.AD_ProductsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ProdTitle"
        Me.DataGridViewTextBoxColumn8.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn12.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'AD_ProductsBindingSource
        '
        Me.AD_ProductsBindingSource.DataMember = "AD_Products"
        Me.AD_ProductsBindingSource.DataSource = Me.ISPASDataSet
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(ProdTitleLabel)
        Me.Panel1.Controls.Add(Me.ProdTitleTextBox)
        Me.Panel1.Controls.Add(QuantityLabel)
        Me.Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Panel1.Controls.Add(UnitPriceLabel)
        Me.Panel1.Controls.Add(Me.UnitPriceTextBox)
        Me.Panel1.Controls.Add(TotalCostLabel)
        Me.Panel1.Controls.Add(Me.TotalCostTextBox)
        Me.Panel1.Location = New System.Drawing.Point(259, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 163)
        Me.Panel1.TabIndex = 21
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProdTitleTextBox
        '
        Me.ProdTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_DetailsBindingSource, "ProdTitle", True))
        Me.ProdTitleTextBox.Location = New System.Drawing.Point(90, 16)
        Me.ProdTitleTextBox.Name = "ProdTitleTextBox"
        Me.ProdTitleTextBox.ReadOnly = True
        Me.ProdTitleTextBox.Size = New System.Drawing.Size(183, 20)
        Me.ProdTitleTextBox.TabIndex = 0
        '
        'POrder_DetailsBindingSource
        '
        Me.POrder_DetailsBindingSource.DataMember = "POrder_MainPOrder_Details"
        Me.POrder_DetailsBindingSource.DataSource = Me.POrder_MainBindingSource
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_DetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(90, 42)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(82, 20)
        Me.QuantityTextBox.TabIndex = 1
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_DetailsBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(90, 68)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.ReadOnly = True
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(183, 20)
        Me.UnitPriceTextBox.TabIndex = 2
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POrder_DetailsBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(90, 94)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.ReadOnly = True
        Me.TotalCostTextBox.Size = New System.Drawing.Size(183, 20)
        Me.TotalCostTextBox.TabIndex = 3
        '
        'POrder_MainTableAdapter
        '
        Me.POrder_MainTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Cp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Cr_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyRateTableAdapter = Nothing
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
        Me.TableAdapterManager.POrder_DetailsTableAdapter = Me.POrder_DetailsTableAdapter
        Me.TableAdapterManager.POrder_MainTableAdapter = Me.POrder_MainTableAdapter
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
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'POrder_DetailsTableAdapter
        '
        Me.POrder_DetailsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ODN, Me.OrN, Me.ProdTit, Me.Qty, Me.UnitP, Me.TC})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 33)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(742, 201)
        Me.DataGridView1.TabIndex = 20
        Me.DataGridView1.Visible = False
        '
        'ODN
        '
        Me.ODN.HeaderText = "PorderDNO"
        Me.ODN.Name = "ODN"
        Me.ODN.ReadOnly = True
        Me.ODN.Visible = False
        '
        'OrN
        '
        Me.OrN.HeaderText = "PorderNo"
        Me.OrN.Name = "OrN"
        Me.OrN.ReadOnly = True
        Me.OrN.Visible = False
        '
        'ProdTit
        '
        Me.ProdTit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProdTit.DefaultCellStyle = DataGridViewCellStyle6
        Me.ProdTit.FillWeight = 250.0!
        Me.ProdTit.HeaderText = "Product"
        Me.ProdTit.Name = "ProdTit"
        Me.ProdTit.ReadOnly = True
        '
        'Qty
        '
        Me.Qty.FillWeight = 75.0!
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'UnitP
        '
        Me.UnitP.FillWeight = 75.0!
        Me.UnitP.HeaderText = "Unit Price"
        Me.UnitP.Name = "UnitP"
        Me.UnitP.ReadOnly = True
        '
        'TC
        '
        Me.TC.FillWeight = 75.0!
        Me.TC.HeaderText = "Total Cost"
        Me.TC.Name = "TC"
        Me.TC.ReadOnly = True
        '
        'POrder_DetailsDataGridView
        '
        Me.POrder_DetailsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.POrder_DetailsDataGridView.AutoGenerateColumns = False
        Me.POrder_DetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.POrder_DetailsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.POrder_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.POrder_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.POrder_DetailsDataGridView.DataSource = Me.POrder_DetailsBindingSource
        Me.POrder_DetailsDataGridView.Location = New System.Drawing.Point(9, 33)
        Me.POrder_DetailsDataGridView.MultiSelect = False
        Me.POrder_DetailsDataGridView.Name = "POrder_DetailsDataGridView"
        Me.POrder_DetailsDataGridView.ReadOnly = True
        Me.POrder_DetailsDataGridView.RowHeadersVisible = False
        Me.POrder_DetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.POrder_DetailsDataGridView.Size = New System.Drawing.Size(742, 201)
        Me.POrder_DetailsDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "POrderDNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "POrderDNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "POrderNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "POrderNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalCost"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn6.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Cost"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.POrder_DetailsDataGridView)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(6, 205)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(772, 349)
        Me.Panel3.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TNoteTextBox)
        Me.Panel4.Controls.Add(Me.TotalAmountTextBox)
        Me.Panel4.Controls.Add(TNoteLabel)
        Me.Panel4.Controls.Add(TotalAmountLabel)
        Me.Panel4.Controls.Add(Me.AttentionTextBox)
        Me.Panel4.Controls.Add(Me.FromCompanyTextBox)
        Me.Panel4.Controls.Add(FromCompanyLabel)
        Me.Panel4.Controls.Add(AttentionLabel)
        Me.Panel4.Location = New System.Drawing.Point(9, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(742, 100)
        Me.Panel4.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(465, 83)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Rs."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Panel2.Controls.Add(POrderNoLabel)
        Me.Panel2.Controls.Add(Me.VendorComboBox)
        Me.Panel2.Controls.Add(VendorLabel)
        Me.Panel2.Controls.Add(Me.POrderNoTextBox)
        Me.Panel2.Controls.Add(Me.POrderDateDateTimePicker)
        Me.Panel2.Controls.Add(POrderDateLabel)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(6, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 135)
        Me.Panel2.TabIndex = 22
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
        Me.Label1.Size = New System.Drawing.Size(793, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Purchase Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.POrder_MainBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmPurchaseOrder"
        Me.Text = "Purchase Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.POrder_MainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POrder_MainBindingNavigator.ResumeLayout(False)
        Me.POrder_MainBindingNavigator.PerformLayout()
        CType(Me.POrder_MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADVendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.POrder_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POrder_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents POrder_MainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents POrder_MainTableAdapter As ISPASystem.ISPASDataSetTableAdapters.POrder_MainTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents POrder_MainBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents POrder_MainBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents POrderNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POrderDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VendorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AttentionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FromCompanyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TNoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADVendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents AD_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProdTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POrder_DetailsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.POrder_DetailsTableAdapter
    Friend WithEvents POrder_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents POrder_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ODN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdTit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
