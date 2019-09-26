<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankReciptVoucher
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
        Dim RVNoLabel As System.Windows.Forms.Label
        Dim RVDateLabel As System.Windows.Forms.Label
        Dim AccountNumLabel As System.Windows.Forms.Label
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim AccountTitleLabel As System.Windows.Forms.Label
        Dim AccountTypeLabel As System.Windows.Forms.Label
        Dim RVParticularsLabel As System.Windows.Forms.Label
        Dim PaymentModeLabel As System.Windows.Forms.Label
        Dim TAmountLabel As System.Windows.Forms.Label
        Dim PayingPersonLabel As System.Windows.Forms.Label
        Dim RecPersonLabel As System.Windows.Forms.Label
        Dim ChequeNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankReciptVoucher))
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.Br_VoucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Br_VoucherTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Br_VoucherTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AccountChartTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
        Me.Bank_AccountsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Bank_AccountsTableAdapter
        Me.MasterTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
        Me.Br_VoucherBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Br_VoucherBindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.Br_VoucherBindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Br_VoucherBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.RVNoTextBox = New System.Windows.Forms.TextBox
        Me.RVDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AccountNumComboBox = New System.Windows.Forms.ComboBox
        Me.Bank_AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankNameTextBox = New System.Windows.Forms.TextBox
        Me.AccountTitleComboBox = New System.Windows.Forms.ComboBox
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountTypeComboBox = New System.Windows.Forms.ComboBox
        Me.MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RVParticularsTextBox = New System.Windows.Forms.TextBox
        Me.PaymentModeComboBox = New System.Windows.Forms.ComboBox
        Me.TAmountTextBox = New System.Windows.Forms.TextBox
        Me.PayingPersonTextBox = New System.Windows.Forms.TextBox
        Me.RecPersonTextBox = New System.Windows.Forms.TextBox
        Me.ChequeNoTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ReciptVoucherGroupBox = New System.Windows.Forms.GroupBox
        Me.WithdrawGroupBox = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LedgerTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
        RVNoLabel = New System.Windows.Forms.Label
        RVDateLabel = New System.Windows.Forms.Label
        AccountNumLabel = New System.Windows.Forms.Label
        BankNameLabel = New System.Windows.Forms.Label
        AccountTitleLabel = New System.Windows.Forms.Label
        AccountTypeLabel = New System.Windows.Forms.Label
        RVParticularsLabel = New System.Windows.Forms.Label
        PaymentModeLabel = New System.Windows.Forms.Label
        TAmountLabel = New System.Windows.Forms.Label
        PayingPersonLabel = New System.Windows.Forms.Label
        RecPersonLabel = New System.Windows.Forms.Label
        ChequeNoLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Br_VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Br_VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Br_VoucherBindingNavigator.SuspendLayout()
        CType(Me.Bank_AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ReciptVoucherGroupBox.SuspendLayout()
        Me.WithdrawGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RVNoLabel
        '
        RVNoLabel.AutoSize = True
        RVNoLabel.Location = New System.Drawing.Point(6, 26)
        RVNoLabel.Name = "RVNoLabel"
        RVNoLabel.Size = New System.Drawing.Size(68, 13)
        RVNoLabel.TabIndex = 1
        RVNoLabel.Text = "Recipt No:"
        '
        'RVDateLabel
        '
        RVDateLabel.AutoSize = True
        RVDateLabel.Location = New System.Drawing.Point(427, 23)
        RVDateLabel.Name = "RVDateLabel"
        RVDateLabel.Size = New System.Drawing.Size(38, 13)
        RVDateLabel.TabIndex = 3
        RVDateLabel.Text = "Date:"
        '
        'AccountNumLabel
        '
        AccountNumLabel.AutoSize = True
        AccountNumLabel.Location = New System.Drawing.Point(6, 52)
        AccountNumLabel.Name = "AccountNumLabel"
        AccountNumLabel.Size = New System.Drawing.Size(78, 13)
        AccountNumLabel.TabIndex = 5
        AccountNumLabel.Text = "Account No:"
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(427, 45)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(76, 13)
        BankNameLabel.TabIndex = 7
        BankNameLabel.Text = "Bank Name:"
        '
        'AccountTitleLabel
        '
        AccountTitleLabel.AutoSize = True
        AccountTitleLabel.Location = New System.Drawing.Point(410, 19)
        AccountTitleLabel.Name = "AccountTitleLabel"
        AccountTitleLabel.Size = New System.Drawing.Size(87, 13)
        AccountTitleLabel.TabIndex = 9
        AccountTitleLabel.Text = "Account Title:"
        '
        'AccountTypeLabel
        '
        AccountTypeLabel.AutoSize = True
        AccountTypeLabel.Location = New System.Drawing.Point(6, 16)
        AccountTypeLabel.Name = "AccountTypeLabel"
        AccountTypeLabel.Size = New System.Drawing.Size(90, 13)
        AccountTypeLabel.TabIndex = 11
        AccountTypeLabel.Text = "Account Type:"
        '
        'RVParticularsLabel
        '
        RVParticularsLabel.AutoSize = True
        RVParticularsLabel.Location = New System.Drawing.Point(6, 123)
        RVParticularsLabel.Name = "RVParticularsLabel"
        RVParticularsLabel.Size = New System.Drawing.Size(71, 13)
        RVParticularsLabel.TabIndex = 13
        RVParticularsLabel.Text = "Particulars:"
        '
        'PaymentModeLabel
        '
        PaymentModeLabel.AutoSize = True
        PaymentModeLabel.Location = New System.Drawing.Point(6, 70)
        PaymentModeLabel.Name = "PaymentModeLabel"
        PaymentModeLabel.Size = New System.Drawing.Size(94, 13)
        PaymentModeLabel.TabIndex = 15
        PaymentModeLabel.Text = "Payment Mode:"
        '
        'TAmountLabel
        '
        TAmountLabel.AutoSize = True
        TAmountLabel.Location = New System.Drawing.Point(6, 97)
        TAmountLabel.Name = "TAmountLabel"
        TAmountLabel.Size = New System.Drawing.Size(53, 13)
        TAmountLabel.TabIndex = 17
        TAmountLabel.Text = "Amount:"
        '
        'PayingPersonLabel
        '
        PayingPersonLabel.AutoSize = True
        PayingPersonLabel.Location = New System.Drawing.Point(6, 43)
        PayingPersonLabel.Name = "PayingPersonLabel"
        PayingPersonLabel.Size = New System.Drawing.Size(92, 13)
        PayingPersonLabel.TabIndex = 19
        PayingPersonLabel.Text = "Paying Person:"
        '
        'RecPersonLabel
        '
        RecPersonLabel.AutoSize = True
        RecPersonLabel.Location = New System.Drawing.Point(410, 46)
        RecPersonLabel.Name = "RecPersonLabel"
        RecPersonLabel.Size = New System.Drawing.Size(108, 13)
        RecPersonLabel.TabIndex = 21
        RecPersonLabel.Text = "Receving Person:"
        '
        'ChequeNoLabel
        '
        ChequeNoLabel.AutoSize = True
        ChequeNoLabel.Location = New System.Drawing.Point(410, 72)
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
        'Br_VoucherBindingSource
        '
        Me.Br_VoucherBindingSource.DataMember = "Br_Voucher"
        Me.Br_VoucherBindingSource.DataSource = Me.ISPASDataSet
        '
        'Br_VoucherTableAdapter
        '
        Me.Br_VoucherTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Bp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Br_VoucherTableAdapter = Me.Br_VoucherTableAdapter
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
        'AccountChartTableAdapter
        '
        Me.AccountChartTableAdapter.ClearBeforeFill = True
        '
        'Bank_AccountsTableAdapter
        '
        Me.Bank_AccountsTableAdapter.ClearBeforeFill = True
        '
        'MasterTableAdapter
        '
        Me.MasterTableAdapter.ClearBeforeFill = True
        '
        'Br_VoucherBindingNavigator
        '
        Me.Br_VoucherBindingNavigator.AddNewItem = Me.Br_VoucherBindingNavigatorAddNewItem
        Me.Br_VoucherBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.Br_VoucherBindingNavigator.BindingSource = Me.Br_VoucherBindingSource
        Me.Br_VoucherBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Br_VoucherBindingNavigator.DeleteItem = Me.Br_VoucherBindingNavigatorDeleteItem
        Me.Br_VoucherBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Br_VoucherBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Br_VoucherBindingNavigatorAddNewItem, Me.Br_VoucherBindingNavigatorDeleteItem, Me.Br_VoucherBindingNavigatorSaveItem})
        Me.Br_VoucherBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Br_VoucherBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Br_VoucherBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Br_VoucherBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Br_VoucherBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Br_VoucherBindingNavigator.Name = "Br_VoucherBindingNavigator"
        Me.Br_VoucherBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Br_VoucherBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Br_VoucherBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.Br_VoucherBindingNavigator.TabIndex = 0
        Me.Br_VoucherBindingNavigator.Text = "BindingNavigator1"
        '
        'Br_VoucherBindingNavigatorAddNewItem
        '
        Me.Br_VoucherBindingNavigatorAddNewItem.Image = CType(resources.GetObject("Br_VoucherBindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.Br_VoucherBindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.White
        Me.Br_VoucherBindingNavigatorAddNewItem.Name = "Br_VoucherBindingNavigatorAddNewItem"
        Me.Br_VoucherBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.Br_VoucherBindingNavigatorAddNewItem.Size = New System.Drawing.Size(75, 22)
        Me.Br_VoucherBindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(42, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'Br_VoucherBindingNavigatorDeleteItem
        '
        Me.Br_VoucherBindingNavigatorDeleteItem.Image = CType(resources.GetObject("Br_VoucherBindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.Br_VoucherBindingNavigatorDeleteItem.Name = "Br_VoucherBindingNavigatorDeleteItem"
        Me.Br_VoucherBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.Br_VoucherBindingNavigatorDeleteItem.Size = New System.Drawing.Size(64, 22)
        Me.Br_VoucherBindingNavigatorDeleteItem.Text = "Delete"
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
        'Br_VoucherBindingNavigatorSaveItem
        '
        Me.Br_VoucherBindingNavigatorSaveItem.Image = CType(resources.GetObject("Br_VoucherBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Br_VoucherBindingNavigatorSaveItem.Name = "Br_VoucherBindingNavigatorSaveItem"
        Me.Br_VoucherBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.Br_VoucherBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RVNoTextBox
        '
        Me.RVNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "RVNo", True))
        Me.RVNoTextBox.Location = New System.Drawing.Point(93, 23)
        Me.RVNoTextBox.Name = "RVNoTextBox"
        Me.RVNoTextBox.ReadOnly = True
        Me.RVNoTextBox.Size = New System.Drawing.Size(81, 20)
        Me.RVNoTextBox.TabIndex = 2
        '
        'RVDateDateTimePicker
        '
        Me.RVDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Br_VoucherBindingSource, "RVDate", True))
        Me.RVDateDateTimePicker.Location = New System.Drawing.Point(514, 19)
        Me.RVDateDateTimePicker.Name = "RVDateDateTimePicker"
        Me.RVDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.RVDateDateTimePicker.TabIndex = 4
        '
        'AccountNumComboBox
        '
        Me.AccountNumComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "AccountNum", True))
        Me.AccountNumComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Br_VoucherBindingSource, "AccountNum", True))
        Me.AccountNumComboBox.DataSource = Me.Bank_AccountsBindingSource
        Me.AccountNumComboBox.DisplayMember = "AccountNo"
        Me.AccountNumComboBox.FormattingEnabled = True
        Me.AccountNumComboBox.Location = New System.Drawing.Point(93, 49)
        Me.AccountNumComboBox.Name = "AccountNumComboBox"
        Me.AccountNumComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AccountNumComboBox.TabIndex = 6
        Me.AccountNumComboBox.ValueMember = "AccountNo"
        '
        'Bank_AccountsBindingSource
        '
        Me.Bank_AccountsBindingSource.DataMember = "Bank_Accounts"
        Me.Bank_AccountsBindingSource.DataSource = Me.ISPASDataSet
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "BankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(514, 42)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.ReadOnly = True
        Me.BankNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankNameTextBox.TabIndex = 8
        '
        'AccountTitleComboBox
        '
        Me.AccountTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "AccountTitle", True))
        Me.AccountTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Br_VoucherBindingSource, "AccountTitle", True))
        Me.AccountTitleComboBox.DataSource = Me.AccountChartBindingSource
        Me.AccountTitleComboBox.DisplayMember = "AccountHeadTitle"
        Me.AccountTitleComboBox.FormattingEnabled = True
        Me.AccountTitleComboBox.Location = New System.Drawing.Point(497, 16)
        Me.AccountTitleComboBox.Name = "AccountTitleComboBox"
        Me.AccountTitleComboBox.Size = New System.Drawing.Size(158, 21)
        Me.AccountTitleComboBox.TabIndex = 10
        Me.AccountTitleComboBox.ValueMember = "AccountHeadTitle"
        '
        'AccountChartBindingSource
        '
        Me.AccountChartBindingSource.DataMember = "AccountChart"
        Me.AccountChartBindingSource.DataSource = Me.ISPASDataSet
        '
        'AccountTypeComboBox
        '
        Me.AccountTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "AccountType", True))
        Me.AccountTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Br_VoucherBindingSource, "AccountType", True))
        Me.AccountTypeComboBox.DataSource = Me.MasterBindingSource
        Me.AccountTypeComboBox.DisplayMember = "subHead"
        Me.AccountTypeComboBox.FormattingEnabled = True
        Me.AccountTypeComboBox.Location = New System.Drawing.Point(102, 16)
        Me.AccountTypeComboBox.Name = "AccountTypeComboBox"
        Me.AccountTypeComboBox.Size = New System.Drawing.Size(169, 21)
        Me.AccountTypeComboBox.TabIndex = 12
        Me.AccountTypeComboBox.ValueMember = "subHead"
        '
        'MasterBindingSource
        '
        Me.MasterBindingSource.DataMember = "Master"
        Me.MasterBindingSource.DataSource = Me.ISPASDataSet
        '
        'RVParticularsTextBox
        '
        Me.RVParticularsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "RVParticulars", True))
        Me.RVParticularsTextBox.Location = New System.Drawing.Point(102, 120)
        Me.RVParticularsTextBox.Name = "RVParticularsTextBox"
        Me.RVParticularsTextBox.Size = New System.Drawing.Size(553, 20)
        Me.RVParticularsTextBox.TabIndex = 14
        '
        'PaymentModeComboBox
        '
        Me.PaymentModeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "PaymentMode", True))
        Me.PaymentModeComboBox.FormattingEnabled = True
        Me.PaymentModeComboBox.Items.AddRange(New Object() {"Cash", "Cheque", "Online Deposit", "Pay Order", "Draft"})
        Me.PaymentModeComboBox.Location = New System.Drawing.Point(102, 70)
        Me.PaymentModeComboBox.Name = "PaymentModeComboBox"
        Me.PaymentModeComboBox.Size = New System.Drawing.Size(169, 21)
        Me.PaymentModeComboBox.TabIndex = 16
        '
        'TAmountTextBox
        '
        Me.TAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "TAmount", True))
        Me.TAmountTextBox.Location = New System.Drawing.Point(102, 97)
        Me.TAmountTextBox.Name = "TAmountTextBox"
        Me.TAmountTextBox.Size = New System.Drawing.Size(169, 20)
        Me.TAmountTextBox.TabIndex = 18
        '
        'PayingPersonTextBox
        '
        Me.PayingPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "PayingPerson", True))
        Me.PayingPersonTextBox.Location = New System.Drawing.Point(102, 43)
        Me.PayingPersonTextBox.Name = "PayingPersonTextBox"
        Me.PayingPersonTextBox.Size = New System.Drawing.Size(169, 20)
        Me.PayingPersonTextBox.TabIndex = 20
        '
        'RecPersonTextBox
        '
        Me.RecPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "RecPerson", True))
        Me.RecPersonTextBox.Location = New System.Drawing.Point(497, 43)
        Me.RecPersonTextBox.Name = "RecPersonTextBox"
        Me.RecPersonTextBox.Size = New System.Drawing.Size(158, 20)
        Me.RecPersonTextBox.TabIndex = 22
        '
        'ChequeNoTextBox
        '
        Me.ChequeNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Br_VoucherBindingSource, "ChequeNo", True))
        Me.ChequeNoTextBox.Enabled = False
        Me.ChequeNoTextBox.Location = New System.Drawing.Point(497, 69)
        Me.ChequeNoTextBox.Name = "ChequeNoTextBox"
        Me.ChequeNoTextBox.Size = New System.Drawing.Size(158, 20)
        Me.ChequeNoTextBox.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.ReciptVoucherGroupBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 516)
        Me.Panel1.TabIndex = 25
        '
        'ReciptVoucherGroupBox
        '
        Me.ReciptVoucherGroupBox.Controls.Add(Me.WithdrawGroupBox)
        Me.ReciptVoucherGroupBox.Controls.Add(RVNoLabel)
        Me.ReciptVoucherGroupBox.Controls.Add(Me.BankNameTextBox)
        Me.ReciptVoucherGroupBox.Controls.Add(RVDateLabel)
        Me.ReciptVoucherGroupBox.Controls.Add(BankNameLabel)
        Me.ReciptVoucherGroupBox.Controls.Add(Me.AccountNumComboBox)
        Me.ReciptVoucherGroupBox.Controls.Add(AccountNumLabel)
        Me.ReciptVoucherGroupBox.Controls.Add(Me.RVNoTextBox)
        Me.ReciptVoucherGroupBox.Controls.Add(Me.RVDateDateTimePicker)
        Me.ReciptVoucherGroupBox.Location = New System.Drawing.Point(6, 36)
        Me.ReciptVoucherGroupBox.Name = "ReciptVoucherGroupBox"
        Me.ReciptVoucherGroupBox.Size = New System.Drawing.Size(746, 250)
        Me.ReciptVoucherGroupBox.TabIndex = 26
        Me.ReciptVoucherGroupBox.TabStop = False
        Me.ReciptVoucherGroupBox.Text = "Recipt Voucher Detail"
        '
        'WithdrawGroupBox
        '
        Me.WithdrawGroupBox.Controls.Add(AccountTypeLabel)
        Me.WithdrawGroupBox.Controls.Add(RVParticularsLabel)
        Me.WithdrawGroupBox.Controls.Add(Me.ChequeNoTextBox)
        Me.WithdrawGroupBox.Controls.Add(Me.AccountTypeComboBox)
        Me.WithdrawGroupBox.Controls.Add(ChequeNoLabel)
        Me.WithdrawGroupBox.Controls.Add(Me.RVParticularsTextBox)
        Me.WithdrawGroupBox.Controls.Add(Me.RecPersonTextBox)
        Me.WithdrawGroupBox.Controls.Add(PaymentModeLabel)
        Me.WithdrawGroupBox.Controls.Add(RecPersonLabel)
        Me.WithdrawGroupBox.Controls.Add(Me.AccountTitleComboBox)
        Me.WithdrawGroupBox.Controls.Add(Me.PayingPersonTextBox)
        Me.WithdrawGroupBox.Controls.Add(Me.PaymentModeComboBox)
        Me.WithdrawGroupBox.Controls.Add(PayingPersonLabel)
        Me.WithdrawGroupBox.Controls.Add(AccountTitleLabel)
        Me.WithdrawGroupBox.Controls.Add(Me.TAmountTextBox)
        Me.WithdrawGroupBox.Controls.Add(TAmountLabel)
        Me.WithdrawGroupBox.Location = New System.Drawing.Point(9, 84)
        Me.WithdrawGroupBox.Name = "WithdrawGroupBox"
        Me.WithdrawGroupBox.Size = New System.Drawing.Size(705, 149)
        Me.WithdrawGroupBox.TabIndex = 9
        Me.WithdrawGroupBox.TabStop = False
        Me.WithdrawGroupBox.Text = "Cash Withdrawn For"
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
        Me.Label1.Text = "Bank Recipt Voucher"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LedgerTableAdapter
        '
        Me.LedgerTableAdapter.ClearBeforeFill = True
        '
        'frmBankReciptVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Br_VoucherBindingNavigator)
        Me.Name = "frmBankReciptVoucher"
        Me.Text = "Bank Recipt Voucher"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Br_VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Br_VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Br_VoucherBindingNavigator.ResumeLayout(False)
        Me.Br_VoucherBindingNavigator.PerformLayout()
        CType(Me.Bank_AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ReciptVoucherGroupBox.ResumeLayout(False)
        Me.ReciptVoucherGroupBox.PerformLayout()
        Me.WithdrawGroupBox.ResumeLayout(False)
        Me.WithdrawGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents Br_VoucherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Br_VoucherTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Br_VoucherTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Br_VoucherBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Br_VoucherBindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Br_VoucherBindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Br_VoucherBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RVNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RVDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AccountNumComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BankNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountTitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RVParticularsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayingPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChequeNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bank_AccountsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Bank_AccountsTableAdapter
    Friend WithEvents Bank_AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterTableAdapter As ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
    Friend WithEvents MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReciptVoucherGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents WithdrawGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LedgerTableAdapter As ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
End Class
