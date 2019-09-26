<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBankAccount
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
        Dim AccountNoLabel As System.Windows.Forms.Label
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim BranchAddressLabel As System.Windows.Forms.Label
        Dim OpeningDateLabel As System.Windows.Forms.Label
        Dim OpeningBalanceLabel As System.Windows.Forms.Label
        Dim AccountTypeLabel As System.Windows.Forms.Label
        Dim CurrentBalanceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBankAccount))
        Me.Bank_AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.AccountNoTextBox = New System.Windows.Forms.TextBox
        Me.BankNameTextBox = New System.Windows.Forms.TextBox
        Me.BranchAddressTextBox = New System.Windows.Forms.TextBox
        Me.OpeningDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.OpeningBalanceTextBox = New System.Windows.Forms.TextBox
        Me.AccountTypeComboBox = New System.Windows.Forms.ComboBox
        Me.Bank_AccountsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Bank_AccountsTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AccountChartTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CurrentBalanceTextBox = New System.Windows.Forms.TextBox
        Me.AccountHeadTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Bank_AccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        AccountNoLabel = New System.Windows.Forms.Label
        BankNameLabel = New System.Windows.Forms.Label
        BranchAddressLabel = New System.Windows.Forms.Label
        OpeningDateLabel = New System.Windows.Forms.Label
        OpeningBalanceLabel = New System.Windows.Forms.Label
        AccountTypeLabel = New System.Windows.Forms.Label
        CurrentBalanceLabel = New System.Windows.Forms.Label
        CType(Me.Bank_AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Bank_AccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bank_AccountBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountNoLabel
        '
        AccountNoLabel.AutoSize = True
        AccountNoLabel.Location = New System.Drawing.Point(50, 22)
        AccountNoLabel.Name = "AccountNoLabel"
        AccountNoLabel.Size = New System.Drawing.Size(78, 13)
        AccountNoLabel.TabIndex = 3
        AccountNoLabel.Text = "Account No:"
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(51, 48)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(76, 13)
        BankNameLabel.TabIndex = 5
        BankNameLabel.Text = "Bank Name:"
        '
        'BranchAddressLabel
        '
        BranchAddressLabel.AutoSize = True
        BranchAddressLabel.Location = New System.Drawing.Point(32, 74)
        BranchAddressLabel.Name = "BranchAddressLabel"
        BranchAddressLabel.Size = New System.Drawing.Size(100, 13)
        BranchAddressLabel.TabIndex = 7
        BranchAddressLabel.Text = "Branch Address:"
        '
        'OpeningDateLabel
        '
        OpeningDateLabel.AutoSize = True
        OpeningDateLabel.Location = New System.Drawing.Point(41, 148)
        OpeningDateLabel.Name = "OpeningDateLabel"
        OpeningDateLabel.Size = New System.Drawing.Size(89, 13)
        OpeningDateLabel.TabIndex = 9
        OpeningDateLabel.Text = "Opening Date:"
        '
        'OpeningBalanceLabel
        '
        OpeningBalanceLabel.AutoSize = True
        OpeningBalanceLabel.Location = New System.Drawing.Point(25, 173)
        OpeningBalanceLabel.Name = "OpeningBalanceLabel"
        OpeningBalanceLabel.Size = New System.Drawing.Size(108, 13)
        OpeningBalanceLabel.TabIndex = 11
        OpeningBalanceLabel.Text = "Opening Balance:"
        '
        'AccountTypeLabel
        '
        AccountTypeLabel.AutoSize = True
        AccountTypeLabel.Location = New System.Drawing.Point(40, 199)
        AccountTypeLabel.Name = "AccountTypeLabel"
        AccountTypeLabel.Size = New System.Drawing.Size(90, 13)
        AccountTypeLabel.TabIndex = 15
        AccountTypeLabel.Text = "Account Type:"
        '
        'CurrentBalanceLabel
        '
        CurrentBalanceLabel.AutoSize = True
        CurrentBalanceLabel.Location = New System.Drawing.Point(28, 226)
        CurrentBalanceLabel.Name = "CurrentBalanceLabel"
        CurrentBalanceLabel.Size = New System.Drawing.Size(102, 13)
        CurrentBalanceLabel.TabIndex = 15
        CurrentBalanceLabel.Text = "Current Balance:"
        '
        'Bank_AccountsBindingSource
        '
        Me.Bank_AccountsBindingSource.DataMember = "Bank_Accounts"
        Me.Bank_AccountsBindingSource.DataSource = Me.ISPASDataSet
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountNoTextBox
        '
        Me.AccountNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "AccountNo", True))
        Me.AccountNoTextBox.Location = New System.Drawing.Point(136, 19)
        Me.AccountNoTextBox.Name = "AccountNoTextBox"
        Me.AccountNoTextBox.Size = New System.Drawing.Size(179, 20)
        Me.AccountNoTextBox.TabIndex = 1
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "BankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(136, 45)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(248, 20)
        Me.BankNameTextBox.TabIndex = 2
        '
        'BranchAddressTextBox
        '
        Me.BranchAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "BranchAddress", True))
        Me.BranchAddressTextBox.Location = New System.Drawing.Point(136, 71)
        Me.BranchAddressTextBox.Multiline = True
        Me.BranchAddressTextBox.Name = "BranchAddressTextBox"
        Me.BranchAddressTextBox.Size = New System.Drawing.Size(290, 67)
        Me.BranchAddressTextBox.TabIndex = 3
        '
        'OpeningDateDateTimePicker
        '
        Me.OpeningDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Bank_AccountsBindingSource, "OpeningDate", True))
        Me.OpeningDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "OpeningDate", True))
        Me.OpeningDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.OpeningDateDateTimePicker.Location = New System.Drawing.Point(136, 144)
        Me.OpeningDateDateTimePicker.Name = "OpeningDateDateTimePicker"
        Me.OpeningDateDateTimePicker.Size = New System.Drawing.Size(143, 20)
        Me.OpeningDateDateTimePicker.TabIndex = 4
        '
        'OpeningBalanceTextBox
        '
        Me.OpeningBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "OpeningBalance", True))
        Me.OpeningBalanceTextBox.Location = New System.Drawing.Point(136, 170)
        Me.OpeningBalanceTextBox.Name = "OpeningBalanceTextBox"
        Me.OpeningBalanceTextBox.Size = New System.Drawing.Size(80, 20)
        Me.OpeningBalanceTextBox.TabIndex = 5
        '
        'AccountTypeComboBox
        '
        Me.AccountTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "AccountType", True))
        Me.AccountTypeComboBox.FormattingEnabled = True
        Me.AccountTypeComboBox.Items.AddRange(New Object() {"Current", "Savings"})
        Me.AccountTypeComboBox.Location = New System.Drawing.Point(136, 196)
        Me.AccountTypeComboBox.Name = "AccountTypeComboBox"
        Me.AccountTypeComboBox.Size = New System.Drawing.Size(143, 21)
        Me.AccountTypeComboBox.TabIndex = 7
        Me.AccountTypeComboBox.Text = "Current"
        '
        'Bank_AccountsTableAdapter
        '
        Me.Bank_AccountsTableAdapter.ClearBeforeFill = True
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
        'AccountChartBindingSource
        '
        Me.AccountChartBindingSource.DataMember = "AccountChart"
        Me.AccountChartBindingSource.DataSource = Me.ISPASDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(CurrentBalanceLabel)
        Me.GroupBox1.Controls.Add(Me.CurrentBalanceTextBox)
        Me.GroupBox1.Controls.Add(Me.AccountTypeComboBox)
        Me.GroupBox1.Controls.Add(AccountTypeLabel)
        Me.GroupBox1.Controls.Add(AccountNoLabel)
        Me.GroupBox1.Controls.Add(Me.AccountHeadTextBox)
        Me.GroupBox1.Controls.Add(Me.AccountNoTextBox)
        Me.GroupBox1.Controls.Add(BankNameLabel)
        Me.GroupBox1.Controls.Add(Me.OpeningBalanceTextBox)
        Me.GroupBox1.Controls.Add(Me.BankNameTextBox)
        Me.GroupBox1.Controls.Add(OpeningBalanceLabel)
        Me.GroupBox1.Controls.Add(BranchAddressLabel)
        Me.GroupBox1.Controls.Add(Me.OpeningDateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.BranchAddressTextBox)
        Me.GroupBox1.Controls.Add(OpeningDateLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CurrentBalanceTextBox
        '
        Me.CurrentBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "CurrentBalance", True))
        Me.CurrentBalanceTextBox.Enabled = False
        Me.CurrentBalanceTextBox.Location = New System.Drawing.Point(136, 223)
        Me.CurrentBalanceTextBox.Name = "CurrentBalanceTextBox"
        Me.CurrentBalanceTextBox.Size = New System.Drawing.Size(80, 20)
        Me.CurrentBalanceTextBox.TabIndex = 16
        '
        'AccountHeadTextBox
        '
        Me.AccountHeadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_AccountsBindingSource, "AccountHead", True))
        Me.AccountHeadTextBox.Location = New System.Drawing.Point(222, 170)
        Me.AccountHeadTextBox.Name = "AccountHeadTextBox"
        Me.AccountHeadTextBox.ReadOnly = True
        Me.AccountHeadTextBox.Size = New System.Drawing.Size(35, 20)
        Me.AccountHeadTextBox.TabIndex = 6
        Me.AccountHeadTextBox.Visible = False
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
        Me.Label1.Size = New System.Drawing.Size(464, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bank Account Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bank_AccountBindingNavigator
        '
        Me.Bank_AccountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Bank_AccountBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.Bank_AccountBindingNavigator.BindingSource = Me.Bank_AccountsBindingSource
        Me.Bank_AccountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Bank_AccountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Bank_AccountBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bank_AccountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.Bank_AccountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Bank_AccountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Bank_AccountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Bank_AccountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Bank_AccountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Bank_AccountBindingNavigator.Name = "Bank_AccountBindingNavigator"
        Me.Bank_AccountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Bank_AccountBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Bank_AccountBindingNavigator.Size = New System.Drawing.Size(464, 25)
        Me.Bank_AccountBindingNavigator.TabIndex = 27
        Me.Bank_AccountBindingNavigator.Text = "BindingNavigator1"
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
        'FrmBankAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(464, 364)
        Me.Controls.Add(Me.Bank_AccountBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmBankAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bank Account"
        CType(Me.Bank_AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Bank_AccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bank_AccountBindingNavigator.ResumeLayout(False)
        Me.Bank_AccountBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents Bank_AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bank_AccountsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Bank_AccountsTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccountNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BankNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpeningDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpeningBalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bank_AccountBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AccountHeadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrentBalanceTextBox As System.Windows.Forms.TextBox
End Class
