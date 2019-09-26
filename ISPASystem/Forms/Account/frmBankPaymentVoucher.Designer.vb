<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankPaymentVoucher
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
        Dim ChequeNoLabel As System.Windows.Forms.Label
        Dim AccountNumLabel As System.Windows.Forms.Label
        Dim PayingPersonLabel As System.Windows.Forms.Label
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim TAmountLabel As System.Windows.Forms.Label
        Dim AccountTitleLabel As System.Windows.Forms.Label
        Dim PaymentModeLabel As System.Windows.Forms.Label
        Dim AccountTypeLabel As System.Windows.Forms.Label
        Dim PVParticularsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankPaymentVoucher))
        Me.PVNoTextBox = New System.Windows.Forms.TextBox
        Me.Bp_VoucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.PVDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.VoucherGroupBox = New System.Windows.Forms.GroupBox
        Me.CashRecievedGroupBox = New System.Windows.Forms.GroupBox
        Me.AccountTypeComboBox = New System.Windows.Forms.ComboBox
        Me.MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChequeNoTextBox = New System.Windows.Forms.TextBox
        Me.PVParticularsTextBox = New System.Windows.Forms.TextBox
        Me.PayingPersonTextBox = New System.Windows.Forms.TextBox
        Me.AccountTitleComboBox = New System.Windows.Forms.ComboBox
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAmountTextBox = New System.Windows.Forms.TextBox
        Me.PaymentModeComboBox = New System.Windows.Forms.ComboBox
        Me.BankNameTextBox = New System.Windows.Forms.TextBox
        Me.AccountNumComboBox = New System.Windows.Forms.ComboBox
        Me.Bank_AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.MasterTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
        Me.Bank_AccountsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Bank_AccountsTableAdapter
        Me.AccountChartTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
        Me.Bp_VoucherTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Bp_VoucherTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.LedgerTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
        Me.LedgerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        PVNoLabel = New System.Windows.Forms.Label
        PVDateLabel = New System.Windows.Forms.Label
        ChequeNoLabel = New System.Windows.Forms.Label
        AccountNumLabel = New System.Windows.Forms.Label
        PayingPersonLabel = New System.Windows.Forms.Label
        BankNameLabel = New System.Windows.Forms.Label
        TAmountLabel = New System.Windows.Forms.Label
        AccountTitleLabel = New System.Windows.Forms.Label
        PaymentModeLabel = New System.Windows.Forms.Label
        AccountTypeLabel = New System.Windows.Forms.Label
        PVParticularsLabel = New System.Windows.Forms.Label
        CType(Me.Bp_VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.VoucherGroupBox.SuspendLayout()
        Me.CashRecievedGroupBox.SuspendLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bank_AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.LedgerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PVNoLabel
        '
        PVNoLabel.AutoSize = True
        PVNoLabel.Location = New System.Drawing.Point(6, 27)
        PVNoLabel.Name = "PVNoLabel"
        PVNoLabel.Size = New System.Drawing.Size(130, 13)
        PVNoLabel.TabIndex = 1
        PVNoLabel.Text = "Payment Voucher No:"
        '
        'PVDateLabel
        '
        PVDateLabel.AutoSize = True
        PVDateLabel.Location = New System.Drawing.Point(445, 28)
        PVDateLabel.Name = "PVDateLabel"
        PVDateLabel.Size = New System.Drawing.Size(54, 13)
        PVDateLabel.TabIndex = 3
        PVDateLabel.Text = "PVDate:"
        '
        'ChequeNoLabel
        '
        ChequeNoLabel.AutoSize = True
        ChequeNoLabel.Location = New System.Drawing.Point(339, 86)
        ChequeNoLabel.Name = "ChequeNoLabel"
        ChequeNoLabel.Size = New System.Drawing.Size(74, 13)
        ChequeNoLabel.TabIndex = 21
        ChequeNoLabel.Text = "Cheque No:"
        '
        'AccountNumLabel
        '
        AccountNumLabel.AutoSize = True
        AccountNumLabel.Location = New System.Drawing.Point(6, 53)
        AccountNumLabel.Name = "AccountNumLabel"
        AccountNumLabel.Size = New System.Drawing.Size(105, 13)
        AccountNumLabel.TabIndex = 5
        AccountNumLabel.Text = "Account Number:"
        '
        'PayingPersonLabel
        '
        PayingPersonLabel.AutoSize = True
        PayingPersonLabel.Location = New System.Drawing.Point(12, 59)
        PayingPersonLabel.Name = "PayingPersonLabel"
        PayingPersonLabel.Size = New System.Drawing.Size(92, 13)
        PayingPersonLabel.TabIndex = 19
        PayingPersonLabel.Text = "Paying Person:"
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(445, 53)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(76, 13)
        BankNameLabel.TabIndex = 7
        BankNameLabel.Text = "Bank Name:"
        '
        'TAmountLabel
        '
        TAmountLabel.AutoSize = True
        TAmountLabel.Location = New System.Drawing.Point(339, 60)
        TAmountLabel.Name = "TAmountLabel"
        TAmountLabel.Size = New System.Drawing.Size(53, 13)
        TAmountLabel.TabIndex = 17
        TAmountLabel.Text = "Amount:"
        '
        'AccountTitleLabel
        '
        AccountTitleLabel.AutoSize = True
        AccountTitleLabel.Location = New System.Drawing.Point(339, 33)
        AccountTitleLabel.Name = "AccountTitleLabel"
        AccountTitleLabel.Size = New System.Drawing.Size(87, 13)
        AccountTitleLabel.TabIndex = 9
        AccountTitleLabel.Text = "Account Title:"
        '
        'PaymentModeLabel
        '
        PaymentModeLabel.AutoSize = True
        PaymentModeLabel.Location = New System.Drawing.Point(12, 85)
        PaymentModeLabel.Name = "PaymentModeLabel"
        PaymentModeLabel.Size = New System.Drawing.Size(94, 13)
        PaymentModeLabel.TabIndex = 15
        PaymentModeLabel.Text = "Payment Mode:"
        '
        'AccountTypeLabel
        '
        AccountTypeLabel.AutoSize = True
        AccountTypeLabel.Location = New System.Drawing.Point(12, 30)
        AccountTypeLabel.Name = "AccountTypeLabel"
        AccountTypeLabel.Size = New System.Drawing.Size(90, 13)
        AccountTypeLabel.TabIndex = 11
        AccountTypeLabel.Text = "Account Type:"
        '
        'PVParticularsLabel
        '
        PVParticularsLabel.AutoSize = True
        PVParticularsLabel.Location = New System.Drawing.Point(12, 112)
        PVParticularsLabel.Name = "PVParticularsLabel"
        PVParticularsLabel.Size = New System.Drawing.Size(71, 13)
        PVParticularsLabel.TabIndex = 13
        PVParticularsLabel.Text = "Particulars:"
        '
        'PVNoTextBox
        '
        Me.PVNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "PVNo", True))
        Me.PVNoTextBox.Location = New System.Drawing.Point(142, 24)
        Me.PVNoTextBox.Name = "PVNoTextBox"
        Me.PVNoTextBox.Size = New System.Drawing.Size(151, 20)
        Me.PVNoTextBox.TabIndex = 2
        '
        'Bp_VoucherBindingSource
        '
        Me.Bp_VoucherBindingSource.DataMember = "Bp_Voucher"
        Me.Bp_VoucherBindingSource.DataSource = Me.ISPASDataSet
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PVDateDateTimePicker
        '
        Me.PVDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Bp_VoucherBindingSource, "PVDate", True))
        Me.PVDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PVDateDateTimePicker.Location = New System.Drawing.Point(532, 24)
        Me.PVDateDateTimePicker.Name = "PVDateDateTimePicker"
        Me.PVDateDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.PVDateDateTimePicker.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.VoucherGroupBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 594)
        Me.Panel1.TabIndex = 25
        '
        'VoucherGroupBox
        '
        Me.VoucherGroupBox.Controls.Add(Me.CashRecievedGroupBox)
        Me.VoucherGroupBox.Controls.Add(PVNoLabel)
        Me.VoucherGroupBox.Controls.Add(Me.BankNameTextBox)
        Me.VoucherGroupBox.Controls.Add(BankNameLabel)
        Me.VoucherGroupBox.Controls.Add(Me.PVNoTextBox)
        Me.VoucherGroupBox.Controls.Add(Me.AccountNumComboBox)
        Me.VoucherGroupBox.Controls.Add(AccountNumLabel)
        Me.VoucherGroupBox.Controls.Add(PVDateLabel)
        Me.VoucherGroupBox.Controls.Add(Me.PVDateDateTimePicker)
        Me.VoucherGroupBox.Location = New System.Drawing.Point(6, 46)
        Me.VoucherGroupBox.Name = "VoucherGroupBox"
        Me.VoucherGroupBox.Size = New System.Drawing.Size(764, 247)
        Me.VoucherGroupBox.TabIndex = 24
        Me.VoucherGroupBox.TabStop = False
        Me.VoucherGroupBox.Text = "Voucher Detail"
        '
        'CashRecievedGroupBox
        '
        Me.CashRecievedGroupBox.Controls.Add(AccountTypeLabel)
        Me.CashRecievedGroupBox.Controls.Add(Me.AccountTypeComboBox)
        Me.CashRecievedGroupBox.Controls.Add(Me.ChequeNoTextBox)
        Me.CashRecievedGroupBox.Controls.Add(PVParticularsLabel)
        Me.CashRecievedGroupBox.Controls.Add(ChequeNoLabel)
        Me.CashRecievedGroupBox.Controls.Add(Me.PVParticularsTextBox)
        Me.CashRecievedGroupBox.Controls.Add(Me.PayingPersonTextBox)
        Me.CashRecievedGroupBox.Controls.Add(Me.AccountTitleComboBox)
        Me.CashRecievedGroupBox.Controls.Add(PayingPersonLabel)
        Me.CashRecievedGroupBox.Controls.Add(PaymentModeLabel)
        Me.CashRecievedGroupBox.Controls.Add(Me.TAmountTextBox)
        Me.CashRecievedGroupBox.Controls.Add(AccountTitleLabel)
        Me.CashRecievedGroupBox.Controls.Add(TAmountLabel)
        Me.CashRecievedGroupBox.Controls.Add(Me.PaymentModeComboBox)
        Me.CashRecievedGroupBox.Location = New System.Drawing.Point(9, 93)
        Me.CashRecievedGroupBox.Name = "CashRecievedGroupBox"
        Me.CashRecievedGroupBox.Size = New System.Drawing.Size(735, 138)
        Me.CashRecievedGroupBox.TabIndex = 25
        Me.CashRecievedGroupBox.TabStop = False
        Me.CashRecievedGroupBox.Text = "Cash Recieved From"
        '
        'AccountTypeComboBox
        '
        Me.AccountTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "AccountType", True))
        Me.AccountTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bp_VoucherBindingSource, "AccountType", True))
        Me.AccountTypeComboBox.DataSource = Me.MasterBindingSource
        Me.AccountTypeComboBox.DisplayMember = "subHead"
        Me.AccountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccountTypeComboBox.FormattingEnabled = True
        Me.AccountTypeComboBox.Location = New System.Drawing.Point(108, 27)
        Me.AccountTypeComboBox.Name = "AccountTypeComboBox"
        Me.AccountTypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AccountTypeComboBox.TabIndex = 12
        Me.AccountTypeComboBox.ValueMember = "subHead"
        '
        'MasterBindingSource
        '
        Me.MasterBindingSource.AllowNew = False
        Me.MasterBindingSource.DataMember = "Master"
        Me.MasterBindingSource.DataSource = Me.ISPASDataSet
        '
        'ChequeNoTextBox
        '
        Me.ChequeNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "ChequeNo", True))
        Me.ChequeNoTextBox.Enabled = False
        Me.ChequeNoTextBox.Location = New System.Drawing.Point(426, 83)
        Me.ChequeNoTextBox.Name = "ChequeNoTextBox"
        Me.ChequeNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ChequeNoTextBox.TabIndex = 22
        '
        'PVParticularsTextBox
        '
        Me.PVParticularsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "PVParticulars", True))
        Me.PVParticularsTextBox.Location = New System.Drawing.Point(99, 109)
        Me.PVParticularsTextBox.Name = "PVParticularsTextBox"
        Me.PVParticularsTextBox.Size = New System.Drawing.Size(527, 20)
        Me.PVParticularsTextBox.TabIndex = 14
        '
        'PayingPersonTextBox
        '
        Me.PayingPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "PayingPerson", True))
        Me.PayingPersonTextBox.Location = New System.Drawing.Point(108, 56)
        Me.PayingPersonTextBox.Name = "PayingPersonTextBox"
        Me.PayingPersonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PayingPersonTextBox.TabIndex = 20
        '
        'AccountTitleComboBox
        '
        Me.AccountTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "AccountTitle", True))
        Me.AccountTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bp_VoucherBindingSource, "AccountTitle", True))
        Me.AccountTitleComboBox.DataSource = Me.AccountChartBindingSource
        Me.AccountTitleComboBox.DisplayMember = "AccountHeadTitle"
        Me.AccountTitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccountTitleComboBox.FormattingEnabled = True
        Me.AccountTitleComboBox.Location = New System.Drawing.Point(426, 30)
        Me.AccountTitleComboBox.Name = "AccountTitleComboBox"
        Me.AccountTitleComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AccountTitleComboBox.TabIndex = 10
        Me.AccountTitleComboBox.ValueMember = "AccountID"
        '
        'AccountChartBindingSource
        '
        Me.AccountChartBindingSource.DataMember = "AccountChart"
        Me.AccountChartBindingSource.DataSource = Me.ISPASDataSet
        '
        'TAmountTextBox
        '
        Me.TAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "TAmount", True))
        Me.TAmountTextBox.Location = New System.Drawing.Point(426, 57)
        Me.TAmountTextBox.Name = "TAmountTextBox"
        Me.TAmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TAmountTextBox.TabIndex = 18
        '
        'PaymentModeComboBox
        '
        Me.PaymentModeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "PaymentMode", True))
        Me.PaymentModeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bp_VoucherBindingSource, "PaymentMode", True))
        Me.PaymentModeComboBox.DisplayMember = "Description"
        Me.PaymentModeComboBox.FormattingEnabled = True
        Me.PaymentModeComboBox.Items.AddRange(New Object() {"Cash", "Cheque", "DD"})
        Me.PaymentModeComboBox.Location = New System.Drawing.Point(108, 82)
        Me.PaymentModeComboBox.Name = "PaymentModeComboBox"
        Me.PaymentModeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PaymentModeComboBox.TabIndex = 16
        Me.PaymentModeComboBox.ValueMember = "Description"
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bp_VoucherBindingSource, "BankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(532, 50)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankNameTextBox.TabIndex = 8
        '
        'AccountNumComboBox
        '
        Me.AccountNumComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bp_VoucherBindingSource, "AccountNum", True))
        Me.AccountNumComboBox.DataSource = Me.Bank_AccountsBindingSource
        Me.AccountNumComboBox.DisplayMember = "AccountNo"
        Me.AccountNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccountNumComboBox.FormattingEnabled = True
        Me.AccountNumComboBox.Location = New System.Drawing.Point(142, 50)
        Me.AccountNumComboBox.Name = "AccountNumComboBox"
        Me.AccountNumComboBox.Size = New System.Drawing.Size(151, 21)
        Me.AccountNumComboBox.TabIndex = 6
        Me.AccountNumComboBox.ValueMember = "AccountNo"
        '
        'Bank_AccountsBindingSource
        '
        Me.Bank_AccountsBindingSource.AllowNew = False
        Me.Bank_AccountsBindingSource.DataMember = "Bank_Accounts"
        Me.Bank_AccountsBindingSource.DataSource = Me.ISPASDataSet
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
        Me.Label1.Size = New System.Drawing.Size(788, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Bank Payment Voucher"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MasterTableAdapter
        '
        Me.MasterTableAdapter.ClearBeforeFill = True
        '
        'Bank_AccountsTableAdapter
        '
        Me.Bank_AccountsTableAdapter.ClearBeforeFill = True
        '
        'AccountChartTableAdapter
        '
        Me.AccountChartTableAdapter.ClearBeforeFill = True
        '
        'Bp_VoucherTableAdapter
        '
        Me.Bp_VoucherTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Bank_AccountsTableAdapter = Me.Bank_AccountsTableAdapter
        Me.TableAdapterManager.Bp_VoucherTableAdapter = Me.Bp_VoucherTableAdapter
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
        Me.TableAdapterManager.MasterTableAdapter = Me.MasterTableAdapter
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
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.Bp_VoucherBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(812, 25)
        Me.BindingNavigator1.TabIndex = 26
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(55, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'LedgerTableAdapter
        '
        Me.LedgerTableAdapter.ClearBeforeFill = True
        '
        'LedgerBindingSource
        '
        Me.LedgerBindingSource.DataMember = "Ledger"
        Me.LedgerBindingSource.DataSource = Me.ISPASDataSet
        '
        'frmBankPaymentVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(812, 640)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBankPaymentVoucher"
        Me.Text = "Bank Payment Voucher"
        CType(Me.Bp_VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.VoucherGroupBox.ResumeLayout(False)
        Me.VoucherGroupBox.PerformLayout()
        Me.CashRecievedGroupBox.ResumeLayout(False)
        Me.CashRecievedGroupBox.PerformLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bank_AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.LedgerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PVNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bp_VoucherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents PVDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChequeNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayingPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountNumComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bank_AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BankNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountTitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PVParticularsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterTableAdapter As ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
    Friend WithEvents Bank_AccountsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Bank_AccountsTableAdapter
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
    Friend WithEvents Bp_VoucherTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Bp_VoucherTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LedgerTableAdapter As ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
    Friend WithEvents LedgerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VoucherGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CashRecievedGroupBox As System.Windows.Forms.GroupBox

End Class
