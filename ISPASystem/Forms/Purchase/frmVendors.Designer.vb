<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendors
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
        Dim VendidLabel As System.Windows.Forms.Label
        Dim VendTitleLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim DebitLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim VendAddressLabel As System.Windows.Forms.Label
        Dim VendOffNoLabel As System.Windows.Forms.Label
        Dim VendEmailLabel As System.Windows.Forms.Label
        Dim VendFaxNoLabel As System.Windows.Forms.Label
        Dim VendSaleTaxNoLabel As System.Windows.Forms.Label
        Dim AcctHeadLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendors))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.AD_VendorsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.VendAddressTextBox = New System.Windows.Forms.TextBox
        Me.BalanceTextBox = New System.Windows.Forms.TextBox
        Me.VendidTextBox = New System.Windows.Forms.TextBox
        Me.VendOffNoTextBox = New System.Windows.Forms.TextBox
        Me.VendEmailTextBox = New System.Windows.Forms.TextBox
        Me.CreditTextBox = New System.Windows.Forms.TextBox
        Me.VendTitleTextBox = New System.Windows.Forms.TextBox
        Me.VendFaxNoTextBox = New System.Windows.Forms.TextBox
        Me.VendSaleTaxNoTextBox = New System.Windows.Forms.TextBox
        Me.DebitTextBox = New System.Windows.Forms.TextBox
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox
        Me.AcctHeadTextBox = New System.Windows.Forms.TextBox
        Me.AD_VendorsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AccountChartTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_VendorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AD_VendorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SearchLabel = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        VendidLabel = New System.Windows.Forms.Label
        VendTitleLabel = New System.Windows.Forms.Label
        ContactPersonLabel = New System.Windows.Forms.Label
        DebitLabel = New System.Windows.Forms.Label
        CreditLabel = New System.Windows.Forms.Label
        BalanceLabel = New System.Windows.Forms.Label
        VendAddressLabel = New System.Windows.Forms.Label
        VendOffNoLabel = New System.Windows.Forms.Label
        VendEmailLabel = New System.Windows.Forms.Label
        VendFaxNoLabel = New System.Windows.Forms.Label
        VendSaleTaxNoLabel = New System.Windows.Forms.Label
        AcctHeadLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AD_VendorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AD_VendorsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'VendidLabel
        '
        VendidLabel.AutoSize = True
        VendidLabel.Location = New System.Drawing.Point(13, 12)
        VendidLabel.Name = "VendidLabel"
        VendidLabel.Size = New System.Drawing.Size(24, 13)
        VendidLabel.TabIndex = 0
        VendidLabel.Text = "ID:"
        '
        'VendTitleLabel
        '
        VendTitleLabel.AutoSize = True
        VendTitleLabel.Location = New System.Drawing.Point(13, 38)
        VendTitleLabel.Name = "VendTitleLabel"
        VendTitleLabel.Size = New System.Drawing.Size(51, 13)
        VendTitleLabel.TabIndex = 2
        VendTitleLabel.Text = "Vendor:"
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.AutoSize = True
        ContactPersonLabel.Location = New System.Drawing.Point(13, 64)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(98, 13)
        ContactPersonLabel.TabIndex = 4
        ContactPersonLabel.Text = "Contact Person:"
        '
        'DebitLabel
        '
        DebitLabel.AutoSize = True
        DebitLabel.Location = New System.Drawing.Point(13, 90)
        DebitLabel.Name = "DebitLabel"
        DebitLabel.Size = New System.Drawing.Size(41, 13)
        DebitLabel.TabIndex = 6
        DebitLabel.Text = "Debit:"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(13, 116)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(44, 13)
        CreditLabel.TabIndex = 8
        CreditLabel.Text = "Credit:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(13, 142)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(57, 13)
        BalanceLabel.TabIndex = 10
        BalanceLabel.Text = "Balance:"
        '
        'VendAddressLabel
        '
        VendAddressLabel.AutoSize = True
        VendAddressLabel.Location = New System.Drawing.Point(405, 9)
        VendAddressLabel.Name = "VendAddressLabel"
        VendAddressLabel.Size = New System.Drawing.Size(56, 13)
        VendAddressLabel.TabIndex = 12
        VendAddressLabel.Text = "Address:"
        '
        'VendOffNoLabel
        '
        VendOffNoLabel.AutoSize = True
        VendOffNoLabel.Location = New System.Drawing.Point(405, 86)
        VendOffNoLabel.Name = "VendOffNoLabel"
        VendOffNoLabel.Size = New System.Drawing.Size(65, 13)
        VendOffNoLabel.TabIndex = 14
        VendOffNoLabel.Text = "Office No:"
        '
        'VendEmailLabel
        '
        VendEmailLabel.AutoSize = True
        VendEmailLabel.Location = New System.Drawing.Point(405, 112)
        VendEmailLabel.Name = "VendEmailLabel"
        VendEmailLabel.Size = New System.Drawing.Size(41, 13)
        VendEmailLabel.TabIndex = 16
        VendEmailLabel.Text = "Email:"
        '
        'VendFaxNoLabel
        '
        VendFaxNoLabel.AutoSize = True
        VendFaxNoLabel.Location = New System.Drawing.Point(405, 138)
        VendFaxNoLabel.Name = "VendFaxNoLabel"
        VendFaxNoLabel.Size = New System.Drawing.Size(51, 13)
        VendFaxNoLabel.TabIndex = 18
        VendFaxNoLabel.Text = "Fax No:"
        '
        'VendSaleTaxNoLabel
        '
        VendSaleTaxNoLabel.AutoSize = True
        VendSaleTaxNoLabel.Location = New System.Drawing.Point(405, 164)
        VendSaleTaxNoLabel.Name = "VendSaleTaxNoLabel"
        VendSaleTaxNoLabel.Size = New System.Drawing.Size(77, 13)
        VendSaleTaxNoLabel.TabIndex = 20
        VendSaleTaxNoLabel.Text = "SaleTax No:"
        '
        'AcctHeadLabel
        '
        AcctHeadLabel.AutoSize = True
        AcctHeadLabel.Location = New System.Drawing.Point(13, 167)
        AcctHeadLabel.Name = "AcctHeadLabel"
        AcctHeadLabel.Size = New System.Drawing.Size(96, 13)
        AcctHeadLabel.TabIndex = 22
        AcctHeadLabel.Text = "Acctount Head:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(792, 566)
        Me.SplitContainer1.SplitterDistance = 354
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.SearchLabel)
        Me.Panel1.Controls.Add(Me.SearchTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AD_VendorsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(8, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 319)
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Size = New System.Drawing.Size(769, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Vendor Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AD_VendorsDataGridView
        '
        Me.AD_VendorsDataGridView.AllowUserToAddRows = False
        Me.AD_VendorsDataGridView.AllowUserToDeleteRows = False
        Me.AD_VendorsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_VendorsDataGridView.AutoGenerateColumns = False
        Me.AD_VendorsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_VendorsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AD_VendorsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.AD_VendorsDataGridView.ColumnHeadersHeight = 25
        Me.AD_VendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AD_VendorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AD_VendorsDataGridView.DataSource = Me.AD_VendorsBindingSource
        Me.AD_VendorsDataGridView.Location = New System.Drawing.Point(10, 62)
        Me.AD_VendorsDataGridView.Name = "AD_VendorsDataGridView"
        Me.AD_VendorsDataGridView.ReadOnly = True
        Me.AD_VendorsDataGridView.RowHeadersWidth = 25
        Me.AD_VendorsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AD_VendorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_VendorsDataGridView.Size = New System.Drawing.Size(756, 251)
        Me.AD_VendorsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "VendTitle"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Vendor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Vendid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Vendid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ContactPerson"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "VendAddress"
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 250
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VendOffNo"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn8.HeaderText = "Office No"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "VendEmail"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "VendFaxNo"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fax No"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "VendSaleTaxNo"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn11.HeaderText = "SaleTax No"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "AcctHead"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Account Head"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Debit"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn4.HeaderText = "Debit (Rs)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Credit"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn5.HeaderText = "Credit (Rs)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Balance"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn6.HeaderText = "Balance (Rs)"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'AD_VendorsBindingSource
        '
        Me.AD_VendorsBindingSource.DataMember = "AD_Vendors"
        Me.AD_VendorsBindingSource.DataSource = Me.ISPASDataSet
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(VendidLabel)
        Me.Panel2.Controls.Add(VendAddressLabel)
        Me.Panel2.Controls.Add(Me.VendAddressTextBox)
        Me.Panel2.Controls.Add(Me.BalanceTextBox)
        Me.Panel2.Controls.Add(VendOffNoLabel)
        Me.Panel2.Controls.Add(Me.VendidTextBox)
        Me.Panel2.Controls.Add(Me.VendOffNoTextBox)
        Me.Panel2.Controls.Add(BalanceLabel)
        Me.Panel2.Controls.Add(VendEmailLabel)
        Me.Panel2.Controls.Add(VendTitleLabel)
        Me.Panel2.Controls.Add(Me.VendEmailTextBox)
        Me.Panel2.Controls.Add(Me.CreditTextBox)
        Me.Panel2.Controls.Add(VendFaxNoLabel)
        Me.Panel2.Controls.Add(Me.VendTitleTextBox)
        Me.Panel2.Controls.Add(Me.VendFaxNoTextBox)
        Me.Panel2.Controls.Add(CreditLabel)
        Me.Panel2.Controls.Add(VendSaleTaxNoLabel)
        Me.Panel2.Controls.Add(ContactPersonLabel)
        Me.Panel2.Controls.Add(Me.VendSaleTaxNoTextBox)
        Me.Panel2.Controls.Add(Me.DebitTextBox)
        Me.Panel2.Controls.Add(AcctHeadLabel)
        Me.Panel2.Controls.Add(Me.ContactPersonTextBox)
        Me.Panel2.Controls.Add(Me.AcctHeadTextBox)
        Me.Panel2.Controls.Add(DebitLabel)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(8, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(771, 186)
        Me.Panel2.TabIndex = 24
        '
        'VendAddressTextBox
        '
        Me.VendAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "VendAddress", True))
        Me.VendAddressTextBox.Location = New System.Drawing.Point(508, 6)
        Me.VendAddressTextBox.Multiline = True
        Me.VendAddressTextBox.Name = "VendAddressTextBox"
        Me.VendAddressTextBox.Size = New System.Drawing.Size(249, 69)
        Me.VendAddressTextBox.TabIndex = 13
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "Balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(116, 139)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(103, 20)
        Me.BalanceTextBox.TabIndex = 11
        '
        'VendidTextBox
        '
        Me.VendidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "Vendid", True))
        Me.VendidTextBox.Location = New System.Drawing.Point(116, 9)
        Me.VendidTextBox.Name = "VendidTextBox"
        Me.VendidTextBox.ReadOnly = True
        Me.VendidTextBox.Size = New System.Drawing.Size(78, 20)
        Me.VendidTextBox.TabIndex = 1
        '
        'VendOffNoTextBox
        '
        Me.VendOffNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "VendOffNo", True))
        Me.VendOffNoTextBox.Location = New System.Drawing.Point(508, 83)
        Me.VendOffNoTextBox.Name = "VendOffNoTextBox"
        Me.VendOffNoTextBox.Size = New System.Drawing.Size(153, 20)
        Me.VendOffNoTextBox.TabIndex = 15
        '
        'VendEmailTextBox
        '
        Me.VendEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "VendEmail", True))
        Me.VendEmailTextBox.Location = New System.Drawing.Point(508, 109)
        Me.VendEmailTextBox.Name = "VendEmailTextBox"
        Me.VendEmailTextBox.Size = New System.Drawing.Size(249, 20)
        Me.VendEmailTextBox.TabIndex = 17
        '
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "Credit", True))
        Me.CreditTextBox.Location = New System.Drawing.Point(116, 113)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(103, 20)
        Me.CreditTextBox.TabIndex = 9
        '
        'VendTitleTextBox
        '
        Me.VendTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "VendTitle", True))
        Me.VendTitleTextBox.Location = New System.Drawing.Point(116, 35)
        Me.VendTitleTextBox.Name = "VendTitleTextBox"
        Me.VendTitleTextBox.Size = New System.Drawing.Size(249, 20)
        Me.VendTitleTextBox.TabIndex = 3
        '
        'VendFaxNoTextBox
        '
        Me.VendFaxNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "VendFaxNo", True))
        Me.VendFaxNoTextBox.Location = New System.Drawing.Point(508, 135)
        Me.VendFaxNoTextBox.Name = "VendFaxNoTextBox"
        Me.VendFaxNoTextBox.Size = New System.Drawing.Size(153, 20)
        Me.VendFaxNoTextBox.TabIndex = 19
        '
        'VendSaleTaxNoTextBox
        '
        Me.VendSaleTaxNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "VendSaleTaxNo", True))
        Me.VendSaleTaxNoTextBox.Location = New System.Drawing.Point(508, 161)
        Me.VendSaleTaxNoTextBox.Name = "VendSaleTaxNoTextBox"
        Me.VendSaleTaxNoTextBox.Size = New System.Drawing.Size(110, 20)
        Me.VendSaleTaxNoTextBox.TabIndex = 21
        '
        'DebitTextBox
        '
        Me.DebitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "Debit", True))
        Me.DebitTextBox.Location = New System.Drawing.Point(116, 87)
        Me.DebitTextBox.Name = "DebitTextBox"
        Me.DebitTextBox.Size = New System.Drawing.Size(103, 20)
        Me.DebitTextBox.TabIndex = 7
        '
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "ContactPerson", True))
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(116, 61)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(249, 20)
        Me.ContactPersonTextBox.TabIndex = 5
        '
        'AcctHeadTextBox
        '
        Me.AcctHeadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_VendorsBindingSource, "AcctHead", True))
        Me.AcctHeadTextBox.Location = New System.Drawing.Point(116, 164)
        Me.AcctHeadTextBox.Name = "AcctHeadTextBox"
        Me.AcctHeadTextBox.Size = New System.Drawing.Size(103, 20)
        Me.AcctHeadTextBox.TabIndex = 23
        '
        'AD_VendorsTableAdapter
        '
        Me.AD_VendorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Me.AccountChartTableAdapter
        Me.TableAdapterManager.AD_CustomersTableAdapter = Nothing
        Me.TableAdapterManager.AD_EmpTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProdCatTableAdapter = Nothing
        Me.TableAdapterManager.AD_ProductsTableAdapter = Nothing
        Me.TableAdapterManager.AD_VendorsTableAdapter = Me.AD_VendorsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.Bp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Br_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Cp_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.Cr_VoucherTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyRateTableAdapter = Nothing
        Me.TableAdapterManager.LedgerTableAdapter = Nothing
        Me.TableAdapterManager.MasterTableAdapter = Nothing
        Me.TableAdapterManager.MenuSettingTableAdapter = Nothing
        Me.TableAdapterManager.NewAccountsTableAdapter = Nothing
        Me.TableAdapterManager.PInvoice_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.PInvoice_MainTableAdapter = Nothing
        Me.TableAdapterManager.POrder_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.POrder_MainTableAdapter = Nothing
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
        'AD_VendorsBindingNavigator
        '
        Me.AD_VendorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AD_VendorsBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.AD_VendorsBindingNavigator.BindingSource = Me.AD_VendorsBindingSource
        Me.AD_VendorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AD_VendorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AD_VendorsBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AD_VendorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AD_VendorsBindingNavigatorSaveItem})
        Me.AD_VendorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AD_VendorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AD_VendorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AD_VendorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AD_VendorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AD_VendorsBindingNavigator.Name = "AD_VendorsBindingNavigator"
        Me.AD_VendorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AD_VendorsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AD_VendorsBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.AD_VendorsBindingNavigator.TabIndex = 3
        Me.AD_VendorsBindingNavigator.Text = "AD_VendorsBindingNavigator"
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
        'AD_VendorsBindingNavigatorSaveItem
        '
        Me.AD_VendorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AD_VendorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AD_VendorsBindingNavigatorSaveItem.Name = "AD_VendorsBindingNavigatorSaveItem"
        Me.AD_VendorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.AD_VendorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(11, 39)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(41, 13)
        Me.SearchLabel.TabIndex = 23
        Me.SearchLabel.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(58, 36)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(280, 20)
        Me.SearchTextBox.TabIndex = 22
        '
        'frmVendors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.AD_VendorsBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmVendors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendors"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AD_VendorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AD_VendorsBindingNavigator.ResumeLayout(False)
        Me.AD_VendorsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents AD_VendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_VendorsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_VendorsTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AD_VendorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VendidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DebitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendOffNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendFaxNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendSaleTaxNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcctHeadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AD_VendorsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AD_VendorsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchLabel As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
End Class
