<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim CustidLabel As System.Windows.Forms.Label
        Dim CustTitleLabel As System.Windows.Forms.Label
        Dim ConctactPersonLabel As System.Windows.Forms.Label
        Dim CustAddressLabel As System.Windows.Forms.Label
        Dim CustOffNoLabel As System.Windows.Forms.Label
        Dim CustEmailLabel As System.Windows.Forms.Label
        Dim CustFaxNoLabel As System.Windows.Forms.Label
        Dim CustSaleTaxNOLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Dim DebitLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SearchLabel = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AD_CustomersDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CustOffNoTextBox = New System.Windows.Forms.TextBox
        Me.CustidTextBox = New System.Windows.Forms.TextBox
        Me.CustEmailTextBox = New System.Windows.Forms.TextBox
        Me.CustAddressTextBox = New System.Windows.Forms.TextBox
        Me.CustTitleTextBox = New System.Windows.Forms.TextBox
        Me.CustSaleTaxNOTextBox = New System.Windows.Forms.TextBox
        Me.CustFaxNoTextBox = New System.Windows.Forms.TextBox
        Me.ConctactPersonTextBox = New System.Windows.Forms.TextBox
        Me.AD_CustomersTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AccountChartTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AD_CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DebitTextBox = New System.Windows.Forms.TextBox
        Me.CreditTextBox = New System.Windows.Forms.TextBox
        CustidLabel = New System.Windows.Forms.Label
        CustTitleLabel = New System.Windows.Forms.Label
        ConctactPersonLabel = New System.Windows.Forms.Label
        CustAddressLabel = New System.Windows.Forms.Label
        CustOffNoLabel = New System.Windows.Forms.Label
        CustEmailLabel = New System.Windows.Forms.Label
        CustFaxNoLabel = New System.Windows.Forms.Label
        CustSaleTaxNOLabel = New System.Windows.Forms.Label
        DebitLabel = New System.Windows.Forms.Label
        CreditLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AD_CustomerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(36, 10)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(80, 13)
        CustidLabel.TabIndex = 0
        CustidLabel.Text = "Customer ID:"
        '
        'CustTitleLabel
        '
        CustTitleLabel.AutoSize = True
        CustTitleLabel.Location = New System.Drawing.Point(421, 10)
        CustTitleLabel.Name = "CustTitleLabel"
        CustTitleLabel.Size = New System.Drawing.Size(43, 13)
        CustTitleLabel.TabIndex = 2
        CustTitleLabel.Text = "Name:"
        '
        'ConctactPersonLabel
        '
        ConctactPersonLabel.AutoSize = True
        ConctactPersonLabel.Location = New System.Drawing.Point(21, 36)
        ConctactPersonLabel.Name = "ConctactPersonLabel"
        ConctactPersonLabel.Size = New System.Drawing.Size(98, 13)
        ConctactPersonLabel.TabIndex = 4
        ConctactPersonLabel.Text = "Contact Person:"
        '
        'CustAddressLabel
        '
        CustAddressLabel.AutoSize = True
        CustAddressLabel.Location = New System.Drawing.Point(411, 39)
        CustAddressLabel.Name = "CustAddressLabel"
        CustAddressLabel.Size = New System.Drawing.Size(56, 13)
        CustAddressLabel.TabIndex = 10
        CustAddressLabel.Text = "Address:"
        '
        'CustOffNoLabel
        '
        CustOffNoLabel.AutoSize = True
        CustOffNoLabel.Location = New System.Drawing.Point(40, 62)
        CustOffNoLabel.Name = "CustOffNoLabel"
        CustOffNoLabel.Size = New System.Drawing.Size(75, 13)
        CustOffNoLabel.TabIndex = 12
        CustOffNoLabel.Text = "Contact No:"
        '
        'CustEmailLabel
        '
        CustEmailLabel.AutoSize = True
        CustEmailLabel.Location = New System.Drawing.Point(410, 108)
        CustEmailLabel.Name = "CustEmailLabel"
        CustEmailLabel.Size = New System.Drawing.Size(58, 13)
        CustEmailLabel.TabIndex = 14
        CustEmailLabel.Text = "Email ID:"
        '
        'CustFaxNoLabel
        '
        CustFaxNoLabel.AutoSize = True
        CustFaxNoLabel.Location = New System.Drawing.Point(60, 88)
        CustFaxNoLabel.Name = "CustFaxNoLabel"
        CustFaxNoLabel.Size = New System.Drawing.Size(51, 13)
        CustFaxNoLabel.TabIndex = 16
        CustFaxNoLabel.Text = "Fax No:"
        '
        'CustSaleTaxNOLabel
        '
        CustSaleTaxNOLabel.AutoSize = True
        CustSaleTaxNOLabel.Location = New System.Drawing.Point(404, 135)
        CustSaleTaxNOLabel.Name = "CustSaleTaxNOLabel"
        CustSaleTaxNOLabel.Size = New System.Drawing.Size(65, 13)
        CustSaleTaxNOLabel.TabIndex = 18
        CustSaleTaxNOLabel.Text = "Sale Tax :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Silver
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
        Me.SplitContainer1.SplitterDistance = 372
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
        Me.Panel1.Controls.Add(Me.AD_CustomersDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 333)
        Me.Panel1.TabIndex = 19
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(4, 39)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(41, 13)
        Me.SearchLabel.TabIndex = 19
        Me.SearchLabel.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(51, 36)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(280, 20)
        Me.SearchTextBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(780, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Customer Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.AD_CustomersDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AD_CustomersDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AD_CustomersDataGridView.ColumnHeadersHeight = 25
        Me.AD_CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AD_CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AD_CustomersDataGridView.DataSource = Me.AD_CustomersBindingSource
        Me.AD_CustomersDataGridView.Location = New System.Drawing.Point(6, 62)
        Me.AD_CustomersDataGridView.Name = "AD_CustomersDataGridView"
        Me.AD_CustomersDataGridView.ReadOnly = True
        Me.AD_CustomersDataGridView.RowHeadersWidth = 25
        Me.AD_CustomersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AD_CustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_CustomersDataGridView.Size = New System.Drawing.Size(766, 263)
        Me.AD_CustomersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustTitle"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Custid"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ConctactPerson"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CustAddress"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CustOffNo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.HeaderText = "ContactNo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CustFaxNo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn9.HeaderText = "FaxNo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CustEmail"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CustSaleTaxNO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SaleTaxNo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "AcctHead"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Account Head"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Debit"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Debit (Rs)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Credit"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Credit (Rs)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'AD_CustomersBindingSource
        '
        Me.AD_CustomersBindingSource.DataMember = "AD_Customers"
        Me.AD_CustomersBindingSource.DataSource = Me.ISPASDataSet
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(CreditLabel)
        Me.Panel2.Controls.Add(Me.CreditTextBox)
        Me.Panel2.Controls.Add(DebitLabel)
        Me.Panel2.Controls.Add(Me.DebitTextBox)
        Me.Panel2.Controls.Add(Me.CustOffNoTextBox)
        Me.Panel2.Controls.Add(CustEmailLabel)
        Me.Panel2.Controls.Add(CustidLabel)
        Me.Panel2.Controls.Add(Me.CustidTextBox)
        Me.Panel2.Controls.Add(CustOffNoLabel)
        Me.Panel2.Controls.Add(Me.CustEmailTextBox)
        Me.Panel2.Controls.Add(Me.CustAddressTextBox)
        Me.Panel2.Controls.Add(CustTitleLabel)
        Me.Panel2.Controls.Add(CustFaxNoLabel)
        Me.Panel2.Controls.Add(Me.CustTitleTextBox)
        Me.Panel2.Controls.Add(Me.CustSaleTaxNOTextBox)
        Me.Panel2.Controls.Add(CustAddressLabel)
        Me.Panel2.Controls.Add(Me.CustFaxNoTextBox)
        Me.Panel2.Controls.Add(ConctactPersonLabel)
        Me.Panel2.Controls.Add(Me.ConctactPersonTextBox)
        Me.Panel2.Controls.Add(CustSaleTaxNOLabel)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 179)
        Me.Panel2.TabIndex = 20
        '
        'CustOffNoTextBox
        '
        Me.CustOffNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "CustOffNo", True))
        Me.CustOffNoTextBox.Location = New System.Drawing.Point(122, 60)
        Me.CustOffNoTextBox.Name = "CustOffNoTextBox"
        Me.CustOffNoTextBox.Size = New System.Drawing.Size(179, 20)
        Me.CustOffNoTextBox.TabIndex = 4
        '
        'CustidTextBox
        '
        Me.CustidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "Custid", True))
        Me.CustidTextBox.Location = New System.Drawing.Point(122, 7)
        Me.CustidTextBox.Name = "CustidTextBox"
        Me.CustidTextBox.ReadOnly = True
        Me.CustidTextBox.Size = New System.Drawing.Size(65, 20)
        Me.CustidTextBox.TabIndex = 0
        '
        'CustEmailTextBox
        '
        Me.CustEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "CustEmail", True))
        Me.CustEmailTextBox.Location = New System.Drawing.Point(465, 105)
        Me.CustEmailTextBox.Name = "CustEmailTextBox"
        Me.CustEmailTextBox.Size = New System.Drawing.Size(205, 20)
        Me.CustEmailTextBox.TabIndex = 5
        '
        'CustAddressTextBox
        '
        Me.CustAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "CustAddress", True))
        Me.CustAddressTextBox.Location = New System.Drawing.Point(465, 33)
        Me.CustAddressTextBox.Multiline = True
        Me.CustAddressTextBox.Name = "CustAddressTextBox"
        Me.CustAddressTextBox.Size = New System.Drawing.Size(205, 66)
        Me.CustAddressTextBox.TabIndex = 3
        '
        'CustTitleTextBox
        '
        Me.CustTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "CustTitle", True))
        Me.CustTitleTextBox.Location = New System.Drawing.Point(465, 7)
        Me.CustTitleTextBox.Name = "CustTitleTextBox"
        Me.CustTitleTextBox.Size = New System.Drawing.Size(205, 20)
        Me.CustTitleTextBox.TabIndex = 1
        '
        'CustSaleTaxNOTextBox
        '
        Me.CustSaleTaxNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "CustSaleTaxNO", True))
        Me.CustSaleTaxNOTextBox.Location = New System.Drawing.Point(465, 132)
        Me.CustSaleTaxNOTextBox.Name = "CustSaleTaxNOTextBox"
        Me.CustSaleTaxNOTextBox.Size = New System.Drawing.Size(205, 20)
        Me.CustSaleTaxNOTextBox.TabIndex = 7
        '
        'CustFaxNoTextBox
        '
        Me.CustFaxNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "CustFaxNo", True))
        Me.CustFaxNoTextBox.Location = New System.Drawing.Point(122, 85)
        Me.CustFaxNoTextBox.Name = "CustFaxNoTextBox"
        Me.CustFaxNoTextBox.Size = New System.Drawing.Size(179, 20)
        Me.CustFaxNoTextBox.TabIndex = 6
        '
        'ConctactPersonTextBox
        '
        Me.ConctactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "ConctactPerson", True))
        Me.ConctactPersonTextBox.Location = New System.Drawing.Point(122, 33)
        Me.ConctactPersonTextBox.Name = "ConctactPersonTextBox"
        Me.ConctactPersonTextBox.Size = New System.Drawing.Size(179, 20)
        Me.ConctactPersonTextBox.TabIndex = 2
        '
        'AD_CustomersTableAdapter
        '
        Me.AD_CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Me.AccountChartTableAdapter
        Me.TableAdapterManager.AD_CustomersTableAdapter = Me.AD_CustomersTableAdapter
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
        'AD_CustomerBindingNavigator
        '
        Me.AD_CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AD_CustomerBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.AD_CustomerBindingNavigator.BindingSource = Me.AD_CustomersBindingSource
        Me.AD_CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AD_CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AD_CustomerBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AD_CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AD_CustomersBindingNavigatorSaveItem})
        Me.AD_CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AD_CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AD_CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AD_CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AD_CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AD_CustomerBindingNavigator.Name = "AD_CustomerBindingNavigator"
        Me.AD_CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AD_CustomerBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AD_CustomerBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.AD_CustomerBindingNavigator.TabIndex = 1
        Me.AD_CustomerBindingNavigator.Text = "AD_CustomerBindingNavigator"
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
        'AD_CustomersBindingNavigatorSaveItem
        '
        Me.AD_CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("AD_CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AD_CustomersBindingNavigatorSaveItem.Name = "AD_CustomersBindingNavigatorSaveItem"
        Me.AD_CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.AD_CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DebitLabel
        '
        DebitLabel.AutoSize = True
        DebitLabel.Location = New System.Drawing.Point(75, 114)
        DebitLabel.Name = "DebitLabel"
        DebitLabel.Size = New System.Drawing.Size(41, 13)
        DebitLabel.TabIndex = 18
        DebitLabel.Text = "Debit:"
        '
        'DebitTextBox
        '
        Me.DebitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "Debit", True))
        Me.DebitTextBox.Location = New System.Drawing.Point(122, 111)
        Me.DebitTextBox.Name = "DebitTextBox"
        Me.DebitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DebitTextBox.TabIndex = 19
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(72, 140)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(44, 13)
        CreditLabel.TabIndex = 19
        CreditLabel.Text = "Credit:"
        '
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AD_CustomersBindingSource, "Credit", True))
        Me.CreditTextBox.Location = New System.Drawing.Point(122, 137)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditTextBox.TabIndex = 20
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.AD_CustomerBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customers"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AD_CustomerBindingNavigator.ResumeLayout(False)
        Me.AD_CustomerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents AD_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConctactPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustFaxNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustSaleTaxNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AccountChartTableAdapter
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CustOffNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AD_CustomerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AD_CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchLabel As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DebitTextBox As System.Windows.Forms.TextBox
End Class
