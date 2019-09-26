<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewAccount
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
        Dim AccountIDLabel As System.Windows.Forms.Label
        Dim AccountHeadTitleLabel As System.Windows.Forms.Label
        Dim AccountHeadLabel As System.Windows.Forms.Label
        Dim AccountTypeLabel As System.Windows.Forms.Label
        Dim OpeningBalLabel As System.Windows.Forms.Label
        Dim AccountIDLabel1 As System.Windows.Forms.Label
        Dim AccountHeadTitleLabel1 As System.Windows.Forms.Label
        Dim AccountHeadLabel1 As System.Windows.Forms.Label
        Dim AccountTypeLabel1 As System.Windows.Forms.Label
        Dim OpeningBalLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewAccount))
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.NewAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewAccountsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.NewAccountsTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AccountChartTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
        Me.MasterTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
        Me.NewAccountsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NewAccountsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.AccountIDTextBox = New System.Windows.Forms.TextBox
        Me.AccountHeadTitleTextBox = New System.Windows.Forms.TextBox
        Me.AccountHeadComboBox = New System.Windows.Forms.ComboBox
        Me.AccountTypeComboBox = New System.Windows.Forms.ComboBox
        Me.MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpeningBalTextBox = New System.Windows.Forms.TextBox
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountChartDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CancelButton = New System.Windows.Forms.Button
        Me.UpdateButton = New System.Windows.Forms.Button
        Me.AccountIDTextBox1 = New System.Windows.Forms.TextBox
        Me.AccountHeadTitleTextBox1 = New System.Windows.Forms.TextBox
        Me.AccountHeadComboBox1 = New System.Windows.Forms.ComboBox
        Me.AccountTypeComboBox1 = New System.Windows.Forms.ComboBox
        Me.OpeningBalTextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        AccountIDLabel = New System.Windows.Forms.Label
        AccountHeadTitleLabel = New System.Windows.Forms.Label
        AccountHeadLabel = New System.Windows.Forms.Label
        AccountTypeLabel = New System.Windows.Forms.Label
        OpeningBalLabel = New System.Windows.Forms.Label
        AccountIDLabel1 = New System.Windows.Forms.Label
        AccountHeadTitleLabel1 = New System.Windows.Forms.Label
        AccountHeadLabel1 = New System.Windows.Forms.Label
        AccountTypeLabel1 = New System.Windows.Forms.Label
        OpeningBalLabel1 = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewAccountsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewAccountsBindingNavigator.SuspendLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountChartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountIDLabel
        '
        AccountIDLabel.AutoSize = True
        AccountIDLabel.Location = New System.Drawing.Point(6, 22)
        AccountIDLabel.Name = "AccountIDLabel"
        AccountIDLabel.Size = New System.Drawing.Size(75, 13)
        AccountIDLabel.TabIndex = 1
        AccountIDLabel.Text = "Account ID:"
        '
        'AccountHeadTitleLabel
        '
        AccountHeadTitleLabel.AutoSize = True
        AccountHeadTitleLabel.Location = New System.Drawing.Point(6, 48)
        AccountHeadTitleLabel.Name = "AccountHeadTitleLabel"
        AccountHeadTitleLabel.Size = New System.Drawing.Size(121, 13)
        AccountHeadTitleLabel.TabIndex = 3
        AccountHeadTitleLabel.Text = "Account Head Title:"
        '
        'AccountHeadLabel
        '
        AccountHeadLabel.AutoSize = True
        AccountHeadLabel.Location = New System.Drawing.Point(6, 74)
        AccountHeadLabel.Name = "AccountHeadLabel"
        AccountHeadLabel.Size = New System.Drawing.Size(92, 13)
        AccountHeadLabel.TabIndex = 5
        AccountHeadLabel.Text = "Account Head:"
        '
        'AccountTypeLabel
        '
        AccountTypeLabel.AutoSize = True
        AccountTypeLabel.Location = New System.Drawing.Point(6, 101)
        AccountTypeLabel.Name = "AccountTypeLabel"
        AccountTypeLabel.Size = New System.Drawing.Size(90, 13)
        AccountTypeLabel.TabIndex = 7
        AccountTypeLabel.Text = "Account Type:"
        '
        'OpeningBalLabel
        '
        OpeningBalLabel.AutoSize = True
        OpeningBalLabel.Location = New System.Drawing.Point(6, 128)
        OpeningBalLabel.Name = "OpeningBalLabel"
        OpeningBalLabel.Size = New System.Drawing.Size(80, 13)
        OpeningBalLabel.TabIndex = 9
        OpeningBalLabel.Text = "Opening Bal:"
        '
        'AccountIDLabel1
        '
        AccountIDLabel1.AutoSize = True
        AccountIDLabel1.Location = New System.Drawing.Point(16, 18)
        AccountIDLabel1.Name = "AccountIDLabel1"
        AccountIDLabel1.Size = New System.Drawing.Size(75, 13)
        AccountIDLabel1.TabIndex = 0
        AccountIDLabel1.Text = "Account ID:"
        '
        'AccountHeadTitleLabel1
        '
        AccountHeadTitleLabel1.AutoSize = True
        AccountHeadTitleLabel1.Location = New System.Drawing.Point(16, 44)
        AccountHeadTitleLabel1.Name = "AccountHeadTitleLabel1"
        AccountHeadTitleLabel1.Size = New System.Drawing.Size(121, 13)
        AccountHeadTitleLabel1.TabIndex = 2
        AccountHeadTitleLabel1.Text = "Account Head Title:"
        '
        'AccountHeadLabel1
        '
        AccountHeadLabel1.AutoSize = True
        AccountHeadLabel1.Location = New System.Drawing.Point(16, 70)
        AccountHeadLabel1.Name = "AccountHeadLabel1"
        AccountHeadLabel1.Size = New System.Drawing.Size(92, 13)
        AccountHeadLabel1.TabIndex = 4
        AccountHeadLabel1.Text = "Account Head:"
        '
        'AccountTypeLabel1
        '
        AccountTypeLabel1.AutoSize = True
        AccountTypeLabel1.Location = New System.Drawing.Point(16, 97)
        AccountTypeLabel1.Name = "AccountTypeLabel1"
        AccountTypeLabel1.Size = New System.Drawing.Size(90, 13)
        AccountTypeLabel1.TabIndex = 6
        AccountTypeLabel1.Text = "Account Type:"
        '
        'OpeningBalLabel1
        '
        OpeningBalLabel1.AutoSize = True
        OpeningBalLabel1.Location = New System.Drawing.Point(16, 124)
        OpeningBalLabel1.Name = "OpeningBalLabel1"
        OpeningBalLabel1.Size = New System.Drawing.Size(80, 13)
        OpeningBalLabel1.TabIndex = 8
        OpeningBalLabel1.Text = "Opening Bal:"
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NewAccountsBindingSource
        '
        Me.NewAccountsBindingSource.DataMember = "NewAccounts"
        Me.NewAccountsBindingSource.DataSource = Me.ISPASDataSet
        '
        'NewAccountsTableAdapter
        '
        Me.NewAccountsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.NewAccountsTableAdapter = Me.NewAccountsTableAdapter
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
        'MasterTableAdapter
        '
        Me.MasterTableAdapter.ClearBeforeFill = True
        '
        'NewAccountsBindingNavigator
        '
        Me.NewAccountsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NewAccountsBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.NewAccountsBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.NewAccountsBindingNavigator.BindingSource = Me.NewAccountsBindingSource
        Me.NewAccountsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NewAccountsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NewAccountsBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewAccountsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NewAccountsBindingNavigatorSaveItem})
        Me.NewAccountsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NewAccountsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NewAccountsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NewAccountsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NewAccountsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NewAccountsBindingNavigator.Name = "NewAccountsBindingNavigator"
        Me.NewAccountsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NewAccountsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.NewAccountsBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.NewAccountsBindingNavigator.TabIndex = 0
        Me.NewAccountsBindingNavigator.Text = "BindingNavigator1"
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
        'NewAccountsBindingNavigatorSaveItem
        '
        Me.NewAccountsBindingNavigatorSaveItem.Image = CType(resources.GetObject("NewAccountsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NewAccountsBindingNavigatorSaveItem.Name = "NewAccountsBindingNavigatorSaveItem"
        Me.NewAccountsBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.NewAccountsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccountIDTextBox
        '
        Me.AccountIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewAccountsBindingSource, "AccountID", True))
        Me.AccountIDTextBox.Location = New System.Drawing.Point(131, 19)
        Me.AccountIDTextBox.Name = "AccountIDTextBox"
        Me.AccountIDTextBox.Size = New System.Drawing.Size(136, 20)
        Me.AccountIDTextBox.TabIndex = 2
        '
        'AccountHeadTitleTextBox
        '
        Me.AccountHeadTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewAccountsBindingSource, "AccountHeadTitle", True))
        Me.AccountHeadTitleTextBox.Location = New System.Drawing.Point(131, 45)
        Me.AccountHeadTitleTextBox.Name = "AccountHeadTitleTextBox"
        Me.AccountHeadTitleTextBox.Size = New System.Drawing.Size(283, 20)
        Me.AccountHeadTitleTextBox.TabIndex = 4
        '
        'AccountHeadComboBox
        '
        Me.AccountHeadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewAccountsBindingSource, "AccountHead", True))
        Me.AccountHeadComboBox.FormattingEnabled = True
        Me.AccountHeadComboBox.Items.AddRange(New Object() {"Assets", "Liabilities", "Capital", "Revenue", "Expenses", "Purchases", "Sales"})
        Me.AccountHeadComboBox.Location = New System.Drawing.Point(131, 71)
        Me.AccountHeadComboBox.Name = "AccountHeadComboBox"
        Me.AccountHeadComboBox.Size = New System.Drawing.Size(283, 21)
        Me.AccountHeadComboBox.TabIndex = 6
        '
        'AccountTypeComboBox
        '
        Me.AccountTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NewAccountsBindingSource, "AccountType", True))
        Me.AccountTypeComboBox.DataSource = Me.MasterBindingSource
        Me.AccountTypeComboBox.DisplayMember = "subHead"
        Me.AccountTypeComboBox.FormattingEnabled = True
        Me.AccountTypeComboBox.Location = New System.Drawing.Point(131, 98)
        Me.AccountTypeComboBox.Name = "AccountTypeComboBox"
        Me.AccountTypeComboBox.Size = New System.Drawing.Size(283, 21)
        Me.AccountTypeComboBox.TabIndex = 8
        Me.AccountTypeComboBox.ValueMember = "subHead"
        '
        'MasterBindingSource
        '
        Me.MasterBindingSource.DataMember = "Master"
        Me.MasterBindingSource.DataSource = Me.ISPASDataSet
        '
        'OpeningBalTextBox
        '
        Me.OpeningBalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewAccountsBindingSource, "OpeningBal", True))
        Me.OpeningBalTextBox.Location = New System.Drawing.Point(131, 125)
        Me.OpeningBalTextBox.Name = "OpeningBalTextBox"
        Me.OpeningBalTextBox.Size = New System.Drawing.Size(283, 20)
        Me.OpeningBalTextBox.TabIndex = 10
        '
        'AccountChartBindingSource
        '
        Me.AccountChartBindingSource.DataMember = "AccountChart"
        Me.AccountChartBindingSource.DataSource = Me.ISPASDataSet
        '
        'AccountChartDataGridView
        '
        Me.AccountChartDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountChartDataGridView.AutoGenerateColumns = False
        Me.AccountChartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AccountChartDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.AccountChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountChartDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AccountChartDataGridView.DataSource = Me.AccountChartBindingSource
        Me.AccountChartDataGridView.Location = New System.Drawing.Point(9, 41)
        Me.AccountChartDataGridView.Name = "AccountChartDataGridView"
        Me.AccountChartDataGridView.Size = New System.Drawing.Size(761, 297)
        Me.AccountChartDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Sr"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AccountID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AccountID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AccountHeadTitle"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AccountHeadTitle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AccountHead"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AccountHead"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AccountType"
        Me.DataGridViewTextBoxColumn5.HeaderText = "AccountType"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OpeningBal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "OpeningBal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Controls.Add(AccountIDLabel1)
        Me.Panel1.Controls.Add(Me.AccountIDTextBox1)
        Me.Panel1.Controls.Add(AccountHeadTitleLabel1)
        Me.Panel1.Controls.Add(Me.AccountHeadTitleTextBox1)
        Me.Panel1.Controls.Add(AccountHeadLabel1)
        Me.Panel1.Controls.Add(Me.AccountHeadComboBox1)
        Me.Panel1.Controls.Add(AccountTypeLabel1)
        Me.Panel1.Controls.Add(Me.AccountTypeComboBox1)
        Me.Panel1.Controls.Add(OpeningBalLabel1)
        Me.Panel1.Controls.Add(Me.OpeningBalTextBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(249, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 178)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(167, 147)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(78, 23)
        Me.CancelButton.TabIndex = 11
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(78, 147)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(83, 23)
        Me.UpdateButton.TabIndex = 10
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AccountIDTextBox1
        '
        Me.AccountIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountChartBindingSource, "AccountID", True))
        Me.AccountIDTextBox1.Location = New System.Drawing.Point(139, 15)
        Me.AccountIDTextBox1.Name = "AccountIDTextBox1"
        Me.AccountIDTextBox1.Size = New System.Drawing.Size(186, 20)
        Me.AccountIDTextBox1.TabIndex = 1
        '
        'AccountHeadTitleTextBox1
        '
        Me.AccountHeadTitleTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountChartBindingSource, "AccountHeadTitle", True))
        Me.AccountHeadTitleTextBox1.Location = New System.Drawing.Point(139, 41)
        Me.AccountHeadTitleTextBox1.Name = "AccountHeadTitleTextBox1"
        Me.AccountHeadTitleTextBox1.Size = New System.Drawing.Size(186, 20)
        Me.AccountHeadTitleTextBox1.TabIndex = 3
        '
        'AccountHeadComboBox1
        '
        Me.AccountHeadComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AccountHeadComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AccountHeadComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountChartBindingSource, "AccountHead", True))
        Me.AccountHeadComboBox1.FormattingEnabled = True
        Me.AccountHeadComboBox1.Items.AddRange(New Object() {"Assets", "Liabilities", "Capital", "Revenue", "Expenses", "Purchases", "Sales"})
        Me.AccountHeadComboBox1.Location = New System.Drawing.Point(139, 67)
        Me.AccountHeadComboBox1.Name = "AccountHeadComboBox1"
        Me.AccountHeadComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.AccountHeadComboBox1.TabIndex = 5
        '
        'AccountTypeComboBox1
        '
        Me.AccountTypeComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AccountTypeComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AccountTypeComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AccountChartBindingSource, "AccountType", True))
        Me.AccountTypeComboBox1.DataSource = Me.MasterBindingSource
        Me.AccountTypeComboBox1.DisplayMember = "subHead"
        Me.AccountTypeComboBox1.FormattingEnabled = True
        Me.AccountTypeComboBox1.Location = New System.Drawing.Point(139, 94)
        Me.AccountTypeComboBox1.Name = "AccountTypeComboBox1"
        Me.AccountTypeComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.AccountTypeComboBox1.TabIndex = 7
        Me.AccountTypeComboBox1.ValueMember = "subHead"
        '
        'OpeningBalTextBox1
        '
        Me.OpeningBalTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountChartBindingSource, "OpeningBal", True))
        Me.OpeningBalTextBox1.Location = New System.Drawing.Point(139, 121)
        Me.OpeningBalTextBox1.Name = "OpeningBalTextBox1"
        Me.OpeningBalTextBox1.Size = New System.Drawing.Size(186, 20)
        Me.OpeningBalTextBox1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(AccountIDLabel)
        Me.GroupBox1.Controls.Add(Me.OpeningBalTextBox)
        Me.GroupBox1.Controls.Add(OpeningBalLabel)
        Me.GroupBox1.Controls.Add(Me.AccountTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.AccountIDTextBox)
        Me.GroupBox1.Controls.Add(AccountTypeLabel)
        Me.GroupBox1.Controls.Add(AccountHeadTitleLabel)
        Me.GroupBox1.Controls.Add(Me.AccountHeadComboBox)
        Me.GroupBox1.Controls.Add(Me.AccountHeadTitleTextBox)
        Me.GroupBox1.Controls.Add(AccountHeadLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 390)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(777, 164)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Account"
        Me.GroupBox1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.AccountChartDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(8, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 350)
        Me.Panel2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(777, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "New Account Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmNewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NewAccountsBindingNavigator)
        Me.Name = "FrmNewAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Account"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewAccountsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewAccountsBindingNavigator.ResumeLayout(False)
        Me.NewAccountsBindingNavigator.PerformLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountChartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents NewAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewAccountsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.NewAccountsTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NewAccountsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NewAccountsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
    Friend WithEvents AccountIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountHeadTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountHeadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OpeningBalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterTableAdapter As ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
    Friend WithEvents AccountChartDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents AccountIDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AccountHeadTitleTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AccountHeadComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AccountTypeComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents OpeningBalTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
