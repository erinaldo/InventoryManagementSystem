<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDelivery
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
        Dim DC_MainIDLabel As System.Windows.Forms.Label
        Dim CustTitleLabel As System.Windows.Forms.Label
        Dim DCDateLabel As System.Windows.Forms.Label
        Dim ReffrenceNoLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim ProdTitleLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim RemarkLabel1 As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDelivery))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ProdTitleTextBox = New System.Windows.Forms.TextBox
        Me.DC_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DC_MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.RemarkTextBox1 = New System.Windows.Forms.TextBox
        Me.QtyTextBox = New System.Windows.Forms.TextBox
        Me.DC_MainIDTextBox = New System.Windows.Forms.TextBox
        Me.CustTitleTextBox = New System.Windows.Forms.TextBox
        Me.AD_CustomersDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DCDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ReffrenceNoTextBox = New System.Windows.Forms.TextBox
        Me.RemarkTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Particular = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DC_DetailDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DC_MainTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.DC_MainTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AD_CustomersTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.DC_DetailTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.DC_DetailTableAdapter
        Me.DC_MainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DC_MainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FromWorkOrderToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FromWorkOrderToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.WorkOrder_MBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkOrder_MTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.WorkOrder_MTableAdapter
        Me.WorkOrder_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkOrder_DTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.WorkOrder_DTableAdapter
        DC_MainIDLabel = New System.Windows.Forms.Label
        CustTitleLabel = New System.Windows.Forms.Label
        DCDateLabel = New System.Windows.Forms.Label
        ReffrenceNoLabel = New System.Windows.Forms.Label
        RemarkLabel = New System.Windows.Forms.Label
        ProdTitleLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        RemarkLabel1 = New System.Windows.Forms.Label
        QtyLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DC_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DC_MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DC_DetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DC_MainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DC_MainBindingNavigator.SuspendLayout()
        CType(Me.WorkOrder_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrder_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DC_MainIDLabel
        '
        DC_MainIDLabel.AutoSize = True
        DC_MainIDLabel.Location = New System.Drawing.Point(14, 64)
        DC_MainIDLabel.Name = "DC_MainIDLabel"
        DC_MainIDLabel.Size = New System.Drawing.Size(76, 13)
        DC_MainIDLabel.TabIndex = 0
        DC_MainIDLabel.Text = "DC Main ID:"
        '
        'CustTitleLabel
        '
        CustTitleLabel.AutoSize = True
        CustTitleLabel.Location = New System.Drawing.Point(14, 86)
        CustTitleLabel.Name = "CustTitleLabel"
        CustTitleLabel.Size = New System.Drawing.Size(65, 13)
        CustTitleLabel.TabIndex = 2
        CustTitleLabel.Text = "Cust Title:"
        '
        'DCDateLabel
        '
        DCDateLabel.AutoSize = True
        DCDateLabel.Location = New System.Drawing.Point(14, 113)
        DCDateLabel.Name = "DCDateLabel"
        DCDateLabel.Size = New System.Drawing.Size(55, 13)
        DCDateLabel.TabIndex = 4
        DCDateLabel.Text = "DCDate:"
        '
        'ReffrenceNoLabel
        '
        ReffrenceNoLabel.AutoSize = True
        ReffrenceNoLabel.Location = New System.Drawing.Point(14, 138)
        ReffrenceNoLabel.Name = "ReffrenceNoLabel"
        ReffrenceNoLabel.Size = New System.Drawing.Size(87, 13)
        ReffrenceNoLabel.TabIndex = 6
        ReffrenceNoLabel.Text = "Reffrence No:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Location = New System.Drawing.Point(14, 164)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(54, 13)
        RemarkLabel.TabIndex = 8
        RemarkLabel.Text = "Remark:"
        '
        'ProdTitleLabel
        '
        ProdTitleLabel.AutoSize = True
        ProdTitleLabel.Location = New System.Drawing.Point(8, 6)
        ProdTitleLabel.Name = "ProdTitleLabel"
        ProdTitleLabel.Size = New System.Drawing.Size(65, 13)
        ProdTitleLabel.TabIndex = 4
        ProdTitleLabel.Text = "Particular:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(8, 45)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(75, 13)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'RemarkLabel1
        '
        RemarkLabel1.AutoSize = True
        RemarkLabel1.Location = New System.Drawing.Point(8, 137)
        RemarkLabel1.Name = "RemarkLabel1"
        RemarkLabel1.Size = New System.Drawing.Size(54, 13)
        RemarkLabel1.TabIndex = 8
        RemarkLabel1.Text = "Remark:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Location = New System.Drawing.Point(8, 229)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(30, 13)
        QtyLabel.TabIndex = 10
        QtyLabel.Text = "Qty:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(8, 210)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(91, 13)
        Label2.TabIndex = 19
        Label2.Text = "Select Product"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(8, 249)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 13)
        Label3.TabIndex = 20
        Label3.Text = "Description:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(10, 341)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 13)
        Label4.TabIndex = 21
        Label4.Text = "Remark:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(14, 433)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(30, 13)
        Label5.TabIndex = 22
        Label5.Text = "Qty:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Delvery Challan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Panel1.Controls.Add(DC_MainIDLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DC_MainIDTextBox)
        Me.Panel1.Controls.Add(CustTitleLabel)
        Me.Panel1.Controls.Add(Me.CustTitleTextBox)
        Me.Panel1.Controls.Add(Me.AD_CustomersDataGridView)
        Me.Panel1.Controls.Add(DCDateLabel)
        Me.Panel1.Controls.Add(Me.DCDateDateTimePicker)
        Me.Panel1.Controls.Add(ReffrenceNoLabel)
        Me.Panel1.Controls.Add(Me.ReffrenceNoTextBox)
        Me.Panel1.Controls.Add(RemarkLabel)
        Me.Panel1.Controls.Add(Me.RemarkTextBox)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.DC_DetailDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(4, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 534)
        Me.Panel1.TabIndex = 0
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
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16})
        Me.AD_ProductsDataGridView.DataSource = Me.AD_ProductsBindingSource
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(107, 246)
        Me.AD_ProductsDataGridView.MultiSelect = False
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(649, 200)
        Me.AD_ProductsDataGridView.TabIndex = 11
        Me.AD_ProductsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle41
        Me.DataGridViewTextBoxColumn12.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ProdCate"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ProdUnits"
        DataGridViewCellStyle42.Format = "N2"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle42
        Me.DataGridViewTextBoxColumn14.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle43.Format = "C2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle43
        Me.DataGridViewTextBoxColumn16.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'AD_ProductsBindingSource
        '
        Me.AD_ProductsBindingSource.DataMember = "AD_Products"
        Me.AD_ProductsBindingSource.DataSource = Me.ISPASDataSet
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(ProdTitleLabel)
        Me.Panel2.Controls.Add(Me.ProdTitleTextBox)
        Me.Panel2.Controls.Add(DescriptionLabel)
        Me.Panel2.Controls.Add(Me.DescriptionTextBox)
        Me.Panel2.Controls.Add(RemarkLabel1)
        Me.Panel2.Controls.Add(Me.RemarkTextBox1)
        Me.Panel2.Controls.Add(QtyLabel)
        Me.Panel2.Controls.Add(Me.QtyTextBox)
        Me.Panel2.Location = New System.Drawing.Point(0, 204)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(231, 300)
        Me.Panel2.TabIndex = 18
        Me.Panel2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProdTitleTextBox
        '
        Me.ProdTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_DetailBindingSource, "ProdTitle", True))
        Me.ProdTitleTextBox.Enabled = False
        Me.ProdTitleTextBox.Location = New System.Drawing.Point(8, 22)
        Me.ProdTitleTextBox.Name = "ProdTitleTextBox"
        Me.ProdTitleTextBox.Size = New System.Drawing.Size(213, 20)
        Me.ProdTitleTextBox.TabIndex = 5
        '
        'DC_DetailBindingSource
        '
        Me.DC_DetailBindingSource.DataMember = "DC_MainDC_Detail"
        Me.DC_DetailBindingSource.DataSource = Me.DC_MainBindingSource
        '
        'DC_MainBindingSource
        '
        Me.DC_MainBindingSource.DataMember = "DC_Main"
        Me.DC_MainBindingSource.DataSource = Me.ISPASDataSet
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_DetailBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(11, 61)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(210, 73)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'RemarkTextBox1
        '
        Me.RemarkTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_DetailBindingSource, "Remark", True))
        Me.RemarkTextBox1.Location = New System.Drawing.Point(11, 153)
        Me.RemarkTextBox1.Multiline = True
        Me.RemarkTextBox1.Name = "RemarkTextBox1"
        Me.RemarkTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RemarkTextBox1.Size = New System.Drawing.Size(210, 73)
        Me.RemarkTextBox1.TabIndex = 9
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_DetailBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(11, 245)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(210, 20)
        Me.QtyTextBox.TabIndex = 11
        '
        'DC_MainIDTextBox
        '
        Me.DC_MainIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_MainBindingSource, "DC_MainID", True))
        Me.DC_MainIDTextBox.Location = New System.Drawing.Point(107, 61)
        Me.DC_MainIDTextBox.Name = "DC_MainIDTextBox"
        Me.DC_MainIDTextBox.ReadOnly = True
        Me.DC_MainIDTextBox.Size = New System.Drawing.Size(83, 20)
        Me.DC_MainIDTextBox.TabIndex = 2
        '
        'CustTitleTextBox
        '
        Me.CustTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_MainBindingSource, "CustTitle", True))
        Me.CustTitleTextBox.Location = New System.Drawing.Point(107, 83)
        Me.CustTitleTextBox.Name = "CustTitleTextBox"
        Me.CustTitleTextBox.Size = New System.Drawing.Size(180, 20)
        Me.CustTitleTextBox.TabIndex = 3
        '
        'AD_CustomersDataGridView
        '
        Me.AD_CustomersDataGridView.AllowUserToAddRows = False
        Me.AD_CustomersDataGridView.AllowUserToDeleteRows = False
        Me.AD_CustomersDataGridView.AutoGenerateColumns = False
        Me.AD_CustomersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AD_CustomersDataGridView.DataSource = Me.AD_CustomersBindingSource
        Me.AD_CustomersDataGridView.Location = New System.Drawing.Point(313, 40)
        Me.AD_CustomersDataGridView.MultiSelect = False
        Me.AD_CustomersDataGridView.Name = "AD_CustomersDataGridView"
        Me.AD_CustomersDataGridView.ReadOnly = True
        Me.AD_CustomersDataGridView.RowHeadersVisible = False
        Me.AD_CustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_CustomersDataGridView.Size = New System.Drawing.Size(458, 141)
        Me.AD_CustomersDataGridView.TabIndex = 10
        Me.AD_CustomersDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ConctactPerson"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Conctact Person"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CustAddress"
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle44
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CustOffNo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'AD_CustomersBindingSource
        '
        Me.AD_CustomersBindingSource.DataMember = "AD_Customers"
        Me.AD_CustomersBindingSource.DataSource = Me.ISPASDataSet
        '
        'DCDateDateTimePicker
        '
        Me.DCDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DC_MainBindingSource, "DCDate", True))
        Me.DCDateDateTimePicker.Location = New System.Drawing.Point(107, 109)
        Me.DCDateDateTimePicker.Name = "DCDateDateTimePicker"
        Me.DCDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DCDateDateTimePicker.TabIndex = 4
        '
        'ReffrenceNoTextBox
        '
        Me.ReffrenceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_MainBindingSource, "ReffrenceNo", True))
        Me.ReffrenceNoTextBox.Location = New System.Drawing.Point(107, 135)
        Me.ReffrenceNoTextBox.Name = "ReffrenceNoTextBox"
        Me.ReffrenceNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReffrenceNoTextBox.TabIndex = 5
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DC_MainBindingSource, "Remark", True))
        Me.RemarkTextBox.Location = New System.Drawing.Point(107, 161)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RemarkTextBox.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 226)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 265)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(210, 73)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 357)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(210, 73)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(11, 449)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(210, 20)
        Me.TextBox4.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Particular, Me.Description, Me.Remark, Me.Qty})
        Me.DataGridView1.Location = New System.Drawing.Point(232, 226)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(549, 195)
        Me.DataGridView1.TabIndex = 12
        Me.DataGridView1.Visible = False
        '
        'Particular
        '
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Particular.DefaultCellStyle = DataGridViewCellStyle37
        Me.Particular.HeaderText = "Particular"
        Me.Particular.Name = "Particular"
        Me.Particular.ReadOnly = True
        '
        'Description
        '
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Description.DefaultCellStyle = DataGridViewCellStyle38
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Remark
        '
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle39
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        '
        'Qty
        '
        DataGridViewCellStyle40.Format = "N2"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle40
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'DC_DetailDataGridView
        '
        Me.DC_DetailDataGridView.AllowUserToAddRows = False
        Me.DC_DetailDataGridView.AllowUserToDeleteRows = False
        Me.DC_DetailDataGridView.AllowUserToResizeColumns = False
        Me.DC_DetailDataGridView.AllowUserToResizeRows = False
        Me.DC_DetailDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DC_DetailDataGridView.AutoGenerateColumns = False
        Me.DC_DetailDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DC_DetailDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DC_DetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DC_DetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DC_DetailDataGridView.DataSource = Me.DC_DetailBindingSource
        Me.DC_DetailDataGridView.Location = New System.Drawing.Point(232, 226)
        Me.DC_DetailDataGridView.MultiSelect = False
        Me.DC_DetailDataGridView.Name = "DC_DetailDataGridView"
        Me.DC_DetailDataGridView.ReadOnly = True
        Me.DC_DetailDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DC_DetailDataGridView.Size = New System.Drawing.Size(549, 195)
        Me.DC_DetailDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DC_DetailID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DC_DetailID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DC_MainID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DC_MainID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle45
        Me.DataGridViewTextBoxColumn5.HeaderText = "Particulars"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Description"
        DataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle46
        Me.DataGridViewTextBoxColumn8.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Remark"
        DataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle47
        Me.DataGridViewTextBoxColumn9.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Qty"
        DataGridViewCellStyle48.Format = "N2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle48
        Me.DataGridViewTextBoxColumn10.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DC_MainTableAdapter
        '
        Me.DC_MainTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Nothing
        Me.TableAdapterManager.AD_CustomersTableAdapter = Me.AD_CustomersTableAdapter
        Me.TableAdapterManager.AD_EmpTableAdapter = Nothing
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
        Me.TableAdapterManager.DC_DetailTableAdapter = Me.DC_DetailTableAdapter
        Me.TableAdapterManager.DC_MainTableAdapter = Me.DC_MainTableAdapter
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
        'AD_CustomersTableAdapter
        '
        Me.AD_CustomersTableAdapter.ClearBeforeFill = True
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'DC_DetailTableAdapter
        '
        Me.DC_DetailTableAdapter.ClearBeforeFill = True
        '
        'DC_MainBindingNavigator
        '
        Me.DC_MainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DC_MainBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.DC_MainBindingNavigator.BindingSource = Me.DC_MainBindingSource
        Me.DC_MainBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DC_MainBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DC_MainBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DC_MainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DC_MainBindingNavigatorSaveItem, Me.PrintToolStripButton, Me.FromWorkOrderToolStripTextBox, Me.FromWorkOrderToolStripButton})
        Me.DC_MainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DC_MainBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DC_MainBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DC_MainBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DC_MainBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DC_MainBindingNavigator.Name = "DC_MainBindingNavigator"
        Me.DC_MainBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DC_MainBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.DC_MainBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.DC_MainBindingNavigator.TabIndex = 0
        Me.DC_MainBindingNavigator.Text = "BindingNavigator1"
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
        'DC_MainBindingNavigatorSaveItem
        '
        Me.DC_MainBindingNavigatorSaveItem.Image = CType(resources.GetObject("DC_MainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DC_MainBindingNavigatorSaveItem.Name = "DC_MainBindingNavigatorSaveItem"
        Me.DC_MainBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.DC_MainBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(54, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'FromWorkOrderToolStripTextBox
        '
        Me.FromWorkOrderToolStripTextBox.Name = "FromWorkOrderToolStripTextBox"
        Me.FromWorkOrderToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FromWorkOrderToolStripButton
        '
        Me.FromWorkOrderToolStripButton.Image = CType(resources.GetObject("FromWorkOrderToolStripButton.Image"), System.Drawing.Image)
        Me.FromWorkOrderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FromWorkOrderToolStripButton.Name = "FromWorkOrderToolStripButton"
        Me.FromWorkOrderToolStripButton.Size = New System.Drawing.Size(121, 22)
        Me.FromWorkOrderToolStripButton.Text = "From WorkOrder"
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
        'WorkOrder_DBindingSource
        '
        Me.WorkOrder_DBindingSource.DataMember = "WorkOrder_MWorkOrder_D"
        Me.WorkOrder_DBindingSource.DataSource = Me.WorkOrder_MBindingSource
        '
        'WorkOrder_DTableAdapter
        '
        Me.WorkOrder_DTableAdapter.ClearBeforeFill = True
        '
        'FrmDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.DC_MainBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmDelivery"
        Me.Text = "FrmDelivery"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DC_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DC_MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DC_DetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DC_MainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DC_MainBindingNavigator.ResumeLayout(False)
        Me.DC_MainBindingNavigator.PerformLayout()
        CType(Me.WorkOrder_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrder_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents DC_MainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DC_MainTableAdapter As ISPASystem.ISPASDataSetTableAdapters.DC_MainTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DC_MainBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DC_MainBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DC_MainIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DCDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReffrenceNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents AD_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DC_DetailTableAdapter As ISPASystem.ISPASDataSetTableAdapters.DC_DetailTableAdapter
    Friend WithEvents DC_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents AD_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProdTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarkTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DC_DetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Particular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FromWorkOrderToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FromWorkOrderToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WorkOrder_MBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkOrder_MTableAdapter As ISPASystem.ISPASDataSetTableAdapters.WorkOrder_MTableAdapter
    Friend WithEvents WorkOrder_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkOrder_DTableAdapter As ISPASystem.ISPASDataSetTableAdapters.WorkOrder_DTableAdapter
End Class
