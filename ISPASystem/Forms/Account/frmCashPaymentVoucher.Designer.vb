<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashPaymentVoucher
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
        Dim PVNoLabel As System.Windows.Forms.Label
        Dim PVDateLabel As System.Windows.Forms.Label
        Dim PinvNoLabel As System.Windows.Forms.Label
        Dim AccountHeadLabel As System.Windows.Forms.Label
        Dim AccountTitleLabel As System.Windows.Forms.Label
        Dim AccountTypeLabel As System.Windows.Forms.Label
        Dim PVParticularsLabel As System.Windows.Forms.Label
        Dim PaymentModeLabel As System.Windows.Forms.Label
        Dim TAmountLabel As System.Windows.Forms.Label
        Dim PayingPersonLabel As System.Windows.Forms.Label
        Dim RecPersonLabel As System.Windows.Forms.Label
        Dim ChequeNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashPaymentVoucher))
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.Cp_VoucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cp_VoucherTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Cp_VoucherTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AccountChartTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
        Me.Cp_VoucherBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Cp_VoucherBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PVNoTextBox = New System.Windows.Forms.TextBox
        Me.PVDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.PinvNoTextBox = New System.Windows.Forms.TextBox
        Me.AccountHeadComboBox = New System.Windows.Forms.ComboBox
        Me.AccountTitleComboBox = New System.Windows.Forms.ComboBox
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountTypeTextBox = New System.Windows.Forms.TextBox
        Me.PVParticularsTextBox = New System.Windows.Forms.TextBox
        Me.PaymentModeComboBox = New System.Windows.Forms.ComboBox
        Me.TAmountTextBox = New System.Windows.Forms.TextBox
        Me.PayingPersonTextBox = New System.Windows.Forms.TextBox
        Me.RecPersonTextBox = New System.Windows.Forms.TextBox
        Me.ChequeNoTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        PVNoLabel = New System.Windows.Forms.Label
        PVDateLabel = New System.Windows.Forms.Label
        PinvNoLabel = New System.Windows.Forms.Label
        AccountHeadLabel = New System.Windows.Forms.Label
        AccountTitleLabel = New System.Windows.Forms.Label
        AccountTypeLabel = New System.Windows.Forms.Label
        PVParticularsLabel = New System.Windows.Forms.Label
        PaymentModeLabel = New System.Windows.Forms.Label
        TAmountLabel = New System.Windows.Forms.Label
        PayingPersonLabel = New System.Windows.Forms.Label
        RecPersonLabel = New System.Windows.Forms.Label
        ChequeNoLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cp_VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cp_VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cp_VoucherBindingNavigator.SuspendLayout()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PVNoLabel
        '
        PVNoLabel.AutoSize = True
        PVNoLabel.Location = New System.Drawing.Point(11, 43)
        PVNoLabel.Name = "PVNoLabel"
        PVNoLabel.Size = New System.Drawing.Size(43, 13)
        PVNoLabel.TabIndex = 1
        PVNoLabel.Text = "PVNo:"
        '
        'PVDateLabel
        '
        PVDateLabel.AutoSize = True
        PVDateLabel.Location = New System.Drawing.Point(446, 44)
        PVDateLabel.Name = "PVDateLabel"
        PVDateLabel.Size = New System.Drawing.Size(54, 13)
        PVDateLabel.TabIndex = 3
        PVDateLabel.Text = "PVDate:"
        '
        'PinvNoLabel
        '
        PinvNoLabel.AutoSize = True
        PinvNoLabel.Location = New System.Drawing.Point(11, 201)
        PinvNoLabel.Name = "PinvNoLabel"
        PinvNoLabel.Size = New System.Drawing.Size(56, 13)
        PinvNoLabel.TabIndex = 5
        PinvNoLabel.Text = "Pinv No:"
        '
        'AccountHeadLabel
        '
        AccountHeadLabel.AutoSize = True
        AccountHeadLabel.Location = New System.Drawing.Point(11, 69)
        AccountHeadLabel.Name = "AccountHeadLabel"
        AccountHeadLabel.Size = New System.Drawing.Size(92, 13)
        AccountHeadLabel.TabIndex = 7
        AccountHeadLabel.Text = "Account Head:"
        '
        'AccountTitleLabel
        '
        AccountTitleLabel.AutoSize = True
        AccountTitleLabel.Location = New System.Drawing.Point(446, 69)
        AccountTitleLabel.Name = "AccountTitleLabel"
        AccountTitleLabel.Size = New System.Drawing.Size(87, 13)
        AccountTitleLabel.TabIndex = 9
        AccountTitleLabel.Text = "Account Title:"
        '
        'AccountTypeLabel
        '
        AccountTypeLabel.AutoSize = True
        AccountTypeLabel.Location = New System.Drawing.Point(446, 96)
        AccountTypeLabel.Name = "AccountTypeLabel"
        AccountTypeLabel.Size = New System.Drawing.Size(90, 13)
        AccountTypeLabel.TabIndex = 11
        AccountTypeLabel.Text = "Account Type:"
        '
        'PVParticularsLabel
        '
        PVParticularsLabel.AutoSize = True
        PVParticularsLabel.Location = New System.Drawing.Point(11, 149)
        PVParticularsLabel.Name = "PVParticularsLabel"
        PVParticularsLabel.Size = New System.Drawing.Size(87, 13)
        PVParticularsLabel.TabIndex = 13
        PVParticularsLabel.Text = "PVParticulars:"
        '
        'PaymentModeLabel
        '
        PaymentModeLabel.AutoSize = True
        PaymentModeLabel.Location = New System.Drawing.Point(11, 122)
        PaymentModeLabel.Name = "PaymentModeLabel"
        PaymentModeLabel.Size = New System.Drawing.Size(94, 13)
        PaymentModeLabel.TabIndex = 15
        PaymentModeLabel.Text = "Payment Mode:"
        '
        'TAmountLabel
        '
        TAmountLabel.AutoSize = True
        TAmountLabel.Location = New System.Drawing.Point(11, 96)
        TAmountLabel.Name = "TAmountLabel"
        TAmountLabel.Size = New System.Drawing.Size(61, 13)
        TAmountLabel.TabIndex = 17
        TAmountLabel.Text = "TAmount:"
        '
        'PayingPersonLabel
        '
        PayingPersonLabel.AutoSize = True
        PayingPersonLabel.Location = New System.Drawing.Point(11, 175)
        PayingPersonLabel.Name = "PayingPersonLabel"
        PayingPersonLabel.Size = New System.Drawing.Size(92, 13)
        PayingPersonLabel.TabIndex = 19
        PayingPersonLabel.Text = "Paying Person:"
        '
        'RecPersonLabel
        '
        RecPersonLabel.AutoSize = True
        RecPersonLabel.Location = New System.Drawing.Point(446, 175)
        RecPersonLabel.Name = "RecPersonLabel"
        RecPersonLabel.Size = New System.Drawing.Size(77, 13)
        RecPersonLabel.TabIndex = 21
        RecPersonLabel.Text = "Rec Person:"
        '
        'ChequeNoLabel
        '
        ChequeNoLabel.AutoSize = True
        ChequeNoLabel.Location = New System.Drawing.Point(446, 122)
        ChequeNoLabel.Name = "ChequeNoLabel"
        ChequeNoLabel.Size = New System.Drawing.Size(74, 13)
        ChequeNoLabel.TabIndex = 23
        ChequeNoLabel.Text = "Cheque No:"
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cp_VoucherBindingSource
        '
        Me.Cp_VoucherBindingSource.DataMember = "Cp_Voucher"
        Me.Cp_VoucherBindingSource.DataSource = Me.ISPASDataSet
        '
        'Cp_VoucherTableAdapter
        '
        Me.Cp_VoucherTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Me.AccountChartTableAdapter
        Me.TableAdapterManager.AD_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.AD_EmpTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProdCatTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProductsTableAdapter = Nothing
        Me.TableAdapterManager.AD_VendorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.Bp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Br_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Cp_VoucherTableAdapter = Me.Cp_VoucherTableAdapter
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
        'AccountChartTableAdapter
        '
        Me.AccountChartTableAdapter.ClearBeforeFill = True
        '
        'Cp_VoucherBindingNavigator
        '
        Me.Cp_VoucherBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Cp_VoucherBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.Cp_VoucherBindingNavigator.BindingSource = Me.Cp_VoucherBindingSource
        Me.Cp_VoucherBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cp_VoucherBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Cp_VoucherBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cp_VoucherBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Cp_VoucherBindingNavigatorSaveItem})
        Me.Cp_VoucherBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cp_VoucherBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cp_VoucherBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cp_VoucherBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cp_VoucherBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cp_VoucherBindingNavigator.Name = "Cp_VoucherBindingNavigator"
        Me.Cp_VoucherBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cp_VoucherBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Cp_VoucherBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.Cp_VoucherBindingNavigator.TabIndex = 0
        Me.Cp_VoucherBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.White
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
        'Cp_VoucherBindingNavigatorSaveItem
        '
        Me.Cp_VoucherBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cp_VoucherBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cp_VoucherBindingNavigatorSaveItem.Name = "Cp_VoucherBindingNavigatorSaveItem"
        Me.Cp_VoucherBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.Cp_VoucherBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PVNoTextBox
        '
        Me.PVNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "PVNo", True))
        Me.PVNoTextBox.Location = New System.Drawing.Point(102, 40)
        Me.PVNoTextBox.Name = "PVNoTextBox"
        Me.PVNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PVNoTextBox.TabIndex = 2
        '
        'PVDateDateTimePicker
        '
        Me.PVDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Cp_VoucherBindingSource, "PVDate", True))
        Me.PVDateDateTimePicker.Location = New System.Drawing.Point(533, 40)
        Me.PVDateDateTimePicker.Name = "PVDateDateTimePicker"
        Me.PVDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PVDateDateTimePicker.TabIndex = 4
        '
        'PinvNoTextBox
        '
        Me.PinvNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "PinvNo", True))
        Me.PinvNoTextBox.Location = New System.Drawing.Point(102, 198)
        Me.PinvNoTextBox.Name = "PinvNoTextBox"
        Me.PinvNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PinvNoTextBox.TabIndex = 6
        '
        'AccountHeadComboBox
        '
        Me.AccountHeadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "AccountHead", True))
        Me.AccountHeadComboBox.FormattingEnabled = True
        Me.AccountHeadComboBox.Items.AddRange(New Object() {"Assets", "Liabilities", "Capital", "Revenue", "Expenses", "Purchases", "Sales"})
        Me.AccountHeadComboBox.Location = New System.Drawing.Point(102, 66)
        Me.AccountHeadComboBox.Name = "AccountHeadComboBox"
        Me.AccountHeadComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AccountHeadComboBox.TabIndex = 8
        '
        'AccountTitleComboBox
        '
        Me.AccountTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cp_VoucherBindingSource, "AccountTitle", True))
        Me.AccountTitleComboBox.DataSource = Me.AccountChartBindingSource
        Me.AccountTitleComboBox.DisplayMember = "AccountHeadTitle"
        Me.AccountTitleComboBox.FormattingEnabled = True
        Me.AccountTitleComboBox.Location = New System.Drawing.Point(533, 66)
        Me.AccountTitleComboBox.Name = "AccountTitleComboBox"
        Me.AccountTitleComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AccountTitleComboBox.TabIndex = 10
        Me.AccountTitleComboBox.ValueMember = "AccountHeadTitle"
        '
        'AccountChartBindingSource
        '
        Me.AccountChartBindingSource.DataMember = "AccountChart"
        Me.AccountChartBindingSource.DataSource = Me.ISPASDataSet
        '
        'AccountTypeTextBox
        '
        Me.AccountTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "AccountType", True))
        Me.AccountTypeTextBox.Location = New System.Drawing.Point(533, 93)
        Me.AccountTypeTextBox.Name = "AccountTypeTextBox"
        Me.AccountTypeTextBox.ReadOnly = True
        Me.AccountTypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccountTypeTextBox.TabIndex = 12
        '
        'PVParticularsTextBox
        '
        Me.PVParticularsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "PVParticulars", True))
        Me.PVParticularsTextBox.Location = New System.Drawing.Point(102, 146)
        Me.PVParticularsTextBox.Name = "PVParticularsTextBox"
        Me.PVParticularsTextBox.Size = New System.Drawing.Size(631, 20)
        Me.PVParticularsTextBox.TabIndex = 14
        '
        'PaymentModeComboBox
        '
        Me.PaymentModeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "PaymentMode", True))
        Me.PaymentModeComboBox.FormattingEnabled = True
        Me.PaymentModeComboBox.Items.AddRange(New Object() {"Cash", "Cheque"})
        Me.PaymentModeComboBox.Location = New System.Drawing.Point(102, 119)
        Me.PaymentModeComboBox.Name = "PaymentModeComboBox"
        Me.PaymentModeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PaymentModeComboBox.TabIndex = 16
        '
        'TAmountTextBox
        '
        Me.TAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "TAmount", True))
        Me.TAmountTextBox.Location = New System.Drawing.Point(102, 93)
        Me.TAmountTextBox.Name = "TAmountTextBox"
        Me.TAmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TAmountTextBox.TabIndex = 18
        '
        'PayingPersonTextBox
        '
        Me.PayingPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "PayingPerson", True))
        Me.PayingPersonTextBox.Location = New System.Drawing.Point(102, 172)
        Me.PayingPersonTextBox.Name = "PayingPersonTextBox"
        Me.PayingPersonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PayingPersonTextBox.TabIndex = 20
        '
        'RecPersonTextBox
        '
        Me.RecPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "RecPerson", True))
        Me.RecPersonTextBox.Location = New System.Drawing.Point(533, 172)
        Me.RecPersonTextBox.Name = "RecPersonTextBox"
        Me.RecPersonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RecPersonTextBox.TabIndex = 22
        '
        'ChequeNoTextBox
        '
        Me.ChequeNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cp_VoucherBindingSource, "ChequeNo", True))
        Me.ChequeNoTextBox.Enabled = False
        Me.ChequeNoTextBox.Location = New System.Drawing.Point(533, 119)
        Me.ChequeNoTextBox.Name = "ChequeNoTextBox"
        Me.ChequeNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ChequeNoTextBox.TabIndex = 24
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
        Me.Label1.Size = New System.Drawing.Size(768, 33)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cash Payment Voucher"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(PVNoLabel)
        Me.Panel1.Controls.Add(Me.PayingPersonTextBox)
        Me.Panel1.Controls.Add(Me.PVNoTextBox)
        Me.Panel1.Controls.Add(Me.ChequeNoTextBox)
        Me.Panel1.Controls.Add(PVDateLabel)
        Me.Panel1.Controls.Add(ChequeNoLabel)
        Me.Panel1.Controls.Add(Me.PVDateDateTimePicker)
        Me.Panel1.Controls.Add(Me.RecPersonTextBox)
        Me.Panel1.Controls.Add(PinvNoLabel)
        Me.Panel1.Controls.Add(RecPersonLabel)
        Me.Panel1.Controls.Add(Me.PinvNoTextBox)
        Me.Panel1.Controls.Add(PayingPersonLabel)
        Me.Panel1.Controls.Add(AccountHeadLabel)
        Me.Panel1.Controls.Add(Me.TAmountTextBox)
        Me.Panel1.Controls.Add(Me.AccountHeadComboBox)
        Me.Panel1.Controls.Add(TAmountLabel)
        Me.Panel1.Controls.Add(AccountTitleLabel)
        Me.Panel1.Controls.Add(Me.PaymentModeComboBox)
        Me.Panel1.Controls.Add(Me.AccountTitleComboBox)
        Me.Panel1.Controls.Add(PaymentModeLabel)
        Me.Panel1.Controls.Add(AccountTypeLabel)
        Me.Panel1.Controls.Add(Me.PVParticularsTextBox)
        Me.Panel1.Controls.Add(Me.AccountTypeTextBox)
        Me.Panel1.Controls.Add(PVParticularsLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(14, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 514)
        Me.Panel1.TabIndex = 26
        '
        'frmCashPaymentVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Cp_VoucherBindingNavigator)
        Me.Name = "frmCashPaymentVoucher"
        Me.Text = "Cash Payment Voucher"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cp_VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cp_VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cp_VoucherBindingNavigator.ResumeLayout(False)
        Me.Cp_VoucherBindingNavigator.PerformLayout()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents Cp_VoucherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cp_VoucherTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Cp_VoucherTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cp_VoucherBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Cp_VoucherBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
    Friend WithEvents PVNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PVDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PinvNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountHeadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountTitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PVParticularsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayingPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChequeNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
