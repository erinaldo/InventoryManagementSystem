<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrder
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
        Dim WrkOdrIDLabel As System.Windows.Forms.Label
        Dim CustTitleLabel As System.Windows.Forms.Label
        Dim SheduledToLabel As System.Windows.Forms.Label
        Dim WODateLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ProdTitleLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkOrder))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.WorkOrder_MBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkOrder_MTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.WorkOrder_MTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AD_CustomersTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
        Me.AD_EmpTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_EmpTableAdapter
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.WorkOrder_DTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.WorkOrder_DTableAdapter
        Me.WorkOrder_MBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WorkOrder_MBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FromQuatationToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FromQuatationToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.WrkOdrIDTextBox = New System.Windows.Forms.TextBox
        Me.CustTitleTextBox = New System.Windows.Forms.TextBox
        Me.SheduledToTextBox = New System.Windows.Forms.TextBox
        Me.WODateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.RemarkTextBox = New System.Windows.Forms.TextBox
        Me.AD_EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_EmpDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_CustomersDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.WorkOrder_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkOrder_DDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.AD_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ProdTitleTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.QtyTextBox = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Quatation_DTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Quatation_DTableAdapter
        Me.Quatation_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Quatation_MBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Quatation_MTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Quatation_MTableAdapter
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        WrkOdrIDLabel = New System.Windows.Forms.Label
        CustTitleLabel = New System.Windows.Forms.Label
        SheduledToLabel = New System.Windows.Forms.Label
        WODateLabel = New System.Windows.Forms.Label
        RemarkLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        ProdTitleLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        QtyLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrder_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrder_MBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkOrder_MBindingNavigator.SuspendLayout()
        CType(Me.AD_EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_EmpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrder_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrder_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Quatation_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quatation_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WrkOdrIDLabel
        '
        WrkOdrIDLabel.AutoSize = True
        WrkOdrIDLabel.Location = New System.Drawing.Point(7, 6)
        WrkOdrIDLabel.Name = "WrkOdrIDLabel"
        WrkOdrIDLabel.Size = New System.Drawing.Size(75, 13)
        WrkOdrIDLabel.TabIndex = 1
        WrkOdrIDLabel.Text = "Wrk Odr ID:"
        '
        'CustTitleLabel
        '
        CustTitleLabel.AutoSize = True
        CustTitleLabel.Location = New System.Drawing.Point(7, 32)
        CustTitleLabel.Name = "CustTitleLabel"
        CustTitleLabel.Size = New System.Drawing.Size(63, 13)
        CustTitleLabel.TabIndex = 3
        CustTitleLabel.Text = "Customer:"
        '
        'SheduledToLabel
        '
        SheduledToLabel.AutoSize = True
        SheduledToLabel.Location = New System.Drawing.Point(7, 58)
        SheduledToLabel.Name = "SheduledToLabel"
        SheduledToLabel.Size = New System.Drawing.Size(83, 13)
        SheduledToLabel.TabIndex = 5
        SheduledToLabel.Text = "Sheduled To:"
        '
        'WODateLabel
        '
        WODateLabel.AutoSize = True
        WODateLabel.Location = New System.Drawing.Point(600, 37)
        WODateLabel.Name = "WODateLabel"
        WODateLabel.Size = New System.Drawing.Size(59, 13)
        WODateLabel.TabIndex = 7
        WODateLabel.Text = "WODate:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Location = New System.Drawing.Point(7, 84)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(54, 13)
        RemarkLabel.TabIndex = 9
        RemarkLabel.Text = "Remark:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(612, 10)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(47, 13)
        StatusLabel.TabIndex = 14
        StatusLabel.Text = "Status:"
        '
        'ProdTitleLabel
        '
        ProdTitleLabel.AutoSize = True
        ProdTitleLabel.Location = New System.Drawing.Point(7, 5)
        ProdTitleLabel.Name = "ProdTitleLabel"
        ProdTitleLabel.Size = New System.Drawing.Size(55, 13)
        ProdTitleLabel.TabIndex = 4
        ProdTitleLabel.Text = "Product;"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(7, 44)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(75, 13)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Location = New System.Drawing.Point(7, 136)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(30, 13)
        QtyLabel.TabIndex = 8
        QtyLabel.Text = "Qty:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(7, 5)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(55, 13)
        Label2.TabIndex = 21
        Label2.Text = "Product:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(7, 44)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 13)
        Label3.TabIndex = 22
        Label3.Text = "Description:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(7, 136)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(30, 13)
        Label4.TabIndex = 23
        Label4.Text = "Qty:"
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkOrder_MBindingSource
        '
        Me.WorkOrder_MBindingSource.DataMember = "WorkOrder_M"
        Me.WorkOrder_MBindingSource.DataSource = Me.ISPASDataSet
        Me.WorkOrder_MBindingSource.Sort = "WrkOdrID"
        '
        'WorkOrder_MTableAdapter
        '
        Me.WorkOrder_MTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Nothing
        Me.TableAdapterManager.AD_CustomersTableAdapter = Me.AD_CustomersTableAdapter
        Me.TableAdapterManager.AD_EmpTableAdapter = Me.AD_EmpTableAdapter
        Me.TableAdapterManager.AD_ProdCatTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProductsTableAdapter = Me.AD_ProductsTableAdapter
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
        Me.TableAdapterManager.WorkOrder_DTableAdapter = Me.WorkOrder_DTableAdapter
        Me.TableAdapterManager.WorkOrder_MTableAdapter = Me.WorkOrder_MTableAdapter
        '
        'AD_CustomersTableAdapter
        '
        Me.AD_CustomersTableAdapter.ClearBeforeFill = True
        '
        'AD_EmpTableAdapter
        '
        Me.AD_EmpTableAdapter.ClearBeforeFill = True
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'WorkOrder_DTableAdapter
        '
        Me.WorkOrder_DTableAdapter.ClearBeforeFill = True
        '
        'WorkOrder_MBindingNavigator
        '
        Me.WorkOrder_MBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WorkOrder_MBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.WorkOrder_MBindingNavigator.BindingSource = Me.WorkOrder_MBindingSource
        Me.WorkOrder_MBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WorkOrder_MBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WorkOrder_MBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrder_MBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WorkOrder_MBindingNavigatorSaveItem, Me.PrintToolStripButton, Me.FromQuatationToolStripTextBox, Me.FromQuatationToolStripButton})
        Me.WorkOrder_MBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WorkOrder_MBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WorkOrder_MBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WorkOrder_MBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WorkOrder_MBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WorkOrder_MBindingNavigator.Name = "WorkOrder_MBindingNavigator"
        Me.WorkOrder_MBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WorkOrder_MBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.WorkOrder_MBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.WorkOrder_MBindingNavigator.TabIndex = 0
        Me.WorkOrder_MBindingNavigator.Text = "BindingNavigator1"
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
        'WorkOrder_MBindingNavigatorSaveItem
        '
        Me.WorkOrder_MBindingNavigatorSaveItem.Image = CType(resources.GetObject("WorkOrder_MBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WorkOrder_MBindingNavigatorSaveItem.Name = "WorkOrder_MBindingNavigatorSaveItem"
        Me.WorkOrder_MBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.WorkOrder_MBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(54, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'FromQuatationToolStripTextBox
        '
        Me.FromQuatationToolStripTextBox.Name = "FromQuatationToolStripTextBox"
        Me.FromQuatationToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FromQuatationToolStripButton
        '
        Me.FromQuatationToolStripButton.Image = CType(resources.GetObject("FromQuatationToolStripButton.Image"), System.Drawing.Image)
        Me.FromQuatationToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FromQuatationToolStripButton.Name = "FromQuatationToolStripButton"
        Me.FromQuatationToolStripButton.Size = New System.Drawing.Size(112, 22)
        Me.FromQuatationToolStripButton.Text = "FromQuatation"
        '
        'WrkOdrIDTextBox
        '
        Me.WrkOdrIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_MBindingSource, "WrkOdrID", True))
        Me.WrkOdrIDTextBox.Location = New System.Drawing.Point(97, 3)
        Me.WrkOdrIDTextBox.Name = "WrkOdrIDTextBox"
        Me.WrkOdrIDTextBox.ReadOnly = True
        Me.WrkOdrIDTextBox.Size = New System.Drawing.Size(77, 20)
        Me.WrkOdrIDTextBox.TabIndex = 0
        '
        'CustTitleTextBox
        '
        Me.CustTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_MBindingSource, "CustTitle", True))
        Me.CustTitleTextBox.Location = New System.Drawing.Point(97, 29)
        Me.CustTitleTextBox.Name = "CustTitleTextBox"
        Me.CustTitleTextBox.Size = New System.Drawing.Size(186, 20)
        Me.CustTitleTextBox.TabIndex = 1
        '
        'SheduledToTextBox
        '
        Me.SheduledToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_MBindingSource, "SheduledTo", True))
        Me.SheduledToTextBox.Location = New System.Drawing.Point(97, 55)
        Me.SheduledToTextBox.Name = "SheduledToTextBox"
        Me.SheduledToTextBox.Size = New System.Drawing.Size(186, 20)
        Me.SheduledToTextBox.TabIndex = 3
        '
        'WODateDateTimePicker
        '
        Me.WODateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkOrder_MBindingSource, "WODate", True))
        Me.WODateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_MBindingSource, "WODate", True))
        Me.WODateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.WODateDateTimePicker.Location = New System.Drawing.Point(665, 33)
        Me.WODateDateTimePicker.Name = "WODateDateTimePicker"
        Me.WODateDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.WODateDateTimePicker.TabIndex = 2
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.RemarkTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_MBindingSource, "Remark", True))
        Me.RemarkTextBox.Location = New System.Drawing.Point(97, 81)
        Me.RemarkTextBox.Multiline = True
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RemarkTextBox.Size = New System.Drawing.Size(663, 65)
        Me.RemarkTextBox.TabIndex = 3
        '
        'AD_EmpBindingSource
        '
        Me.AD_EmpBindingSource.DataMember = "AD_Emp"
        Me.AD_EmpBindingSource.DataSource = Me.ISPASDataSet
        '
        'AD_EmpDataGridView
        '
        Me.AD_EmpDataGridView.AllowUserToAddRows = False
        Me.AD_EmpDataGridView.AllowUserToDeleteRows = False
        Me.AD_EmpDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_EmpDataGridView.AutoGenerateColumns = False
        Me.AD_EmpDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_EmpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_EmpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AD_EmpDataGridView.DataSource = Me.AD_EmpBindingSource
        Me.AD_EmpDataGridView.Location = New System.Drawing.Point(289, 6)
        Me.AD_EmpDataGridView.Name = "AD_EmpDataGridView"
        Me.AD_EmpDataGridView.ReadOnly = True
        Me.AD_EmpDataGridView.RowHeadersVisible = False
        Me.AD_EmpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_EmpDataGridView.Size = New System.Drawing.Size(464, 136)
        Me.AD_EmpDataGridView.TabIndex = 13
        Me.AD_EmpDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmpName"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ContactNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
        Me.AD_CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.AD_CustomersDataGridView.DataSource = Me.AD_CustomersBindingSource
        Me.AD_CustomersDataGridView.Location = New System.Drawing.Point(289, 6)
        Me.AD_CustomersDataGridView.Name = "AD_CustomersDataGridView"
        Me.AD_CustomersDataGridView.ReadOnly = True
        Me.AD_CustomersDataGridView.RowHeadersVisible = False
        Me.AD_CustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_CustomersDataGridView.Size = New System.Drawing.Size(464, 136)
        Me.AD_CustomersDataGridView.TabIndex = 14
        Me.AD_CustomersDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CustTitle"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn10.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CustAddress"
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn14.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 250
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CustOffNo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Contact No"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_MBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"OPEN", "CLOSE"})
        Me.StatusComboBox.Location = New System.Drawing.Point(665, 6)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(99, 21)
        Me.StatusComboBox.TabIndex = 4
        '
        'WorkOrder_DBindingSource
        '
        Me.WorkOrder_DBindingSource.DataMember = "WorkOrder_MWorkOrder_D"
        Me.WorkOrder_DBindingSource.DataSource = Me.WorkOrder_MBindingSource
        '
        'WorkOrder_DDataGridView
        '
        Me.WorkOrder_DDataGridView.AllowUserToAddRows = False
        Me.WorkOrder_DDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WorkOrder_DDataGridView.AutoGenerateColumns = False
        Me.WorkOrder_DDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.WorkOrder_DDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.WorkOrder_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkOrder_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.WorkOrder_DDataGridView.DataSource = Me.WorkOrder_DBindingSource
        Me.WorkOrder_DDataGridView.Location = New System.Drawing.Point(219, 21)
        Me.WorkOrder_DDataGridView.Name = "WorkOrder_DDataGridView"
        Me.WorkOrder_DDataGridView.ReadOnly = True
        Me.WorkOrder_DDataGridView.Size = New System.Drawing.Size(529, 292)
        Me.WorkOrder_DDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WrkOrdDetID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WrkOrdDetID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "WrkOrdID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "WrkOrdID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn6.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Qty"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn8.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(10, 60)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(192, 73)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 152)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 20)
        Me.TextBox3.TabIndex = 7
        '
        'AD_ProductsBindingSource
        '
        Me.AD_ProductsBindingSource.DataMember = "AD_Products"
        Me.AD_ProductsBindingSource.DataSource = Me.ISPASDataSet
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
        Me.AD_ProductsDataGridView.BackgroundColor = System.Drawing.Color.Silver
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.AD_ProductsDataGridView.DataSource = Me.AD_ProductsBindingSource
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(43, 42)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(685, 206)
        Me.AD_ProductsDataGridView.TabIndex = 9
        Me.AD_ProductsDataGridView.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(ProdTitleLabel)
        Me.Panel1.Controls.Add(Me.ProdTitleTextBox)
        Me.Panel1.Controls.Add(DescriptionLabel)
        Me.Panel1.Controls.Add(Me.DescriptionTextBox)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 226)
        Me.Panel1.TabIndex = 20
        Me.Panel1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProdTitleTextBox
        '
        Me.ProdTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_DBindingSource, "ProdTitle", True))
        Me.ProdTitleTextBox.Location = New System.Drawing.Point(10, 21)
        Me.ProdTitleTextBox.Name = "ProdTitleTextBox"
        Me.ProdTitleTextBox.ReadOnly = True
        Me.ProdTitleTextBox.Size = New System.Drawing.Size(192, 20)
        Me.ProdTitleTextBox.TabIndex = 0
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_DBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(10, 60)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(192, 73)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkOrder_DBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(9, 152)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(125, 20)
        Me.QtyTextBox.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(6, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 492)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Panel4.Controls.Add(Label4)
        Me.Panel4.Controls.Add(Label3)
        Me.Panel4.Controls.Add(Label2)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.WorkOrder_DDataGridView)
        Me.Panel4.Location = New System.Drawing.Point(7, 162)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(751, 322)
        Me.Panel4.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.WrkOdrIDTextBox)
        Me.Panel3.Controls.Add(WrkOdrIDLabel)
        Me.Panel3.Controls.Add(Me.AD_CustomersDataGridView)
        Me.Panel3.Controls.Add(Me.AD_EmpDataGridView)
        Me.Panel3.Controls.Add(Me.CustTitleTextBox)
        Me.Panel3.Controls.Add(CustTitleLabel)
        Me.Panel3.Controls.Add(SheduledToLabel)
        Me.Panel3.Controls.Add(Me.RemarkTextBox)
        Me.Panel3.Controls.Add(Me.WODateDateTimePicker)
        Me.Panel3.Controls.Add(RemarkLabel)
        Me.Panel3.Controls.Add(Me.SheduledToTextBox)
        Me.Panel3.Controls.Add(WODateLabel)
        Me.Panel3.Controls.Add(StatusLabel)
        Me.Panel3.Controls.Add(Me.StatusComboBox)
        Me.Panel3.Location = New System.Drawing.Point(7, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(767, 153)
        Me.Panel3.TabIndex = 21
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
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Work Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Quatation_DTableAdapter
        '
        Me.Quatation_DTableAdapter.ClearBeforeFill = True
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
        'Quatation_MTableAdapter
        '
        Me.Quatation_MTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ProdTitle"
        Me.DataGridViewTextBoxColumn11.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Prododuct"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ProdCate"
        Me.DataGridViewTextBoxColumn12.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'frmWorkOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.WorkOrder_MBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmWorkOrder"
        Me.Text = "frmWorkOrder"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrder_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrder_MBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkOrder_MBindingNavigator.ResumeLayout(False)
        Me.WorkOrder_MBindingNavigator.PerformLayout()
        CType(Me.AD_EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_EmpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrder_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrder_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Quatation_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quatation_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents WorkOrder_MBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkOrder_MTableAdapter As ISPASystem.ISPASDataSetTableAdapters.WorkOrder_MTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkOrder_MBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents WorkOrder_MBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AD_EmpTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_EmpTableAdapter
    Friend WithEvents WrkOdrIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SheduledToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WODateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AD_EmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents AD_EmpDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AD_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkOrder_DTableAdapter As ISPASystem.ISPASDataSetTableAdapters.WorkOrder_DTableAdapter
    Friend WithEvents WorkOrder_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents WorkOrder_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents AD_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProdTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FromQuatationToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FromQuatationToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Quatation_DTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Quatation_DTableAdapter
    Friend WithEvents Quatation_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quatation_MBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quatation_MTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Quatation_MTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
