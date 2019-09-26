<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuatation
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
        Dim QuatationIDLabel As System.Windows.Forms.Label
        Dim CustTitleLabel As System.Windows.Forms.Label
        Dim QDateLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim TotalAmountLabel As System.Windows.Forms.Label
        Dim PaymentTypeLabel As System.Windows.Forms.Label
        Dim DiscountAmountLabel As System.Windows.Forms.Label
        Dim OriginalAmountLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuatation))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.AD_CustomersDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.QDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Quatation_MBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuatationIDTextBox = New System.Windows.Forms.TextBox
        Me.CustTitleTextBox = New System.Windows.Forms.TextBox
        Me.PaymentTypeComboBox = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.DiscountTextBox = New System.Windows.Forms.TextBox
        Me.OriginalAmountTextBox = New System.Windows.Forms.TextBox
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox
        Me.Quatation_MTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Quatation_MTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AD_CustomersTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.Quatation_DTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Quatation_DTableAdapter
        Me.Quatation_MBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Quatation_MBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToSalesInvoiceToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ProductTextBox = New System.Windows.Forms.TextBox
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Particular = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Quatation_DDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Quatation_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AD_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        QuatationIDLabel = New System.Windows.Forms.Label
        CustTitleLabel = New System.Windows.Forms.Label
        QDateLabel = New System.Windows.Forms.Label
        DiscountLabel = New System.Windows.Forms.Label
        TotalAmountLabel = New System.Windows.Forms.Label
        PaymentTypeLabel = New System.Windows.Forms.Label
        DiscountAmountLabel = New System.Windows.Forms.Label
        OriginalAmountLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quatation_MBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Quatation_MBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Quatation_MBindingNavigator.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quatation_DDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quatation_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuatationIDLabel
        '
        QuatationIDLabel.AutoSize = True
        QuatationIDLabel.Location = New System.Drawing.Point(11, 10)
        QuatationIDLabel.Name = "QuatationIDLabel"
        QuatationIDLabel.Size = New System.Drawing.Size(83, 13)
        QuatationIDLabel.TabIndex = 3
        QuatationIDLabel.Text = "Quotation ID:"
        '
        'CustTitleLabel
        '
        CustTitleLabel.AutoSize = True
        CustTitleLabel.Location = New System.Drawing.Point(11, 63)
        CustTitleLabel.Name = "CustTitleLabel"
        CustTitleLabel.Size = New System.Drawing.Size(99, 13)
        CustTitleLabel.TabIndex = 5
        CustTitleLabel.Text = "Customer Name:"
        '
        'QDateLabel
        '
        QDateLabel.AutoSize = True
        QDateLabel.Location = New System.Drawing.Point(11, 38)
        QDateLabel.Name = "QDateLabel"
        QDateLabel.Size = New System.Drawing.Size(47, 13)
        QDateLabel.TabIndex = 7
        QDateLabel.Text = "QDate:"
        '
        'DiscountLabel
        '
        DiscountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(564, 35)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(61, 13)
        DiscountLabel.TabIndex = 9
        DiscountLabel.Text = "Discount:"
        '
        'TotalAmountLabel
        '
        TotalAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalAmountLabel.AutoSize = True
        TotalAmountLabel.Location = New System.Drawing.Point(564, 9)
        TotalAmountLabel.Name = "TotalAmountLabel"
        TotalAmountLabel.Size = New System.Drawing.Size(86, 13)
        TotalAmountLabel.TabIndex = 11
        TotalAmountLabel.Text = "Total Amount:"
        '
        'PaymentTypeLabel
        '
        PaymentTypeLabel.AutoSize = True
        PaymentTypeLabel.Location = New System.Drawing.Point(11, 89)
        PaymentTypeLabel.Name = "PaymentTypeLabel"
        PaymentTypeLabel.Size = New System.Drawing.Size(91, 13)
        PaymentTypeLabel.TabIndex = 13
        PaymentTypeLabel.Text = "Payment Type:"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(564, 61)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(107, 13)
        DiscountAmountLabel.TabIndex = 15
        DiscountAmountLabel.Text = "Discount Amount:"
        '
        'OriginalAmountLabel
        '
        OriginalAmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        OriginalAmountLabel.AutoSize = True
        OriginalAmountLabel.Location = New System.Drawing.Point(564, 87)
        OriginalAmountLabel.Name = "OriginalAmountLabel"
        OriginalAmountLabel.Size = New System.Drawing.Size(100, 13)
        OriginalAmountLabel.TabIndex = 17
        OriginalAmountLabel.Text = "Original Amount:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(4, 7)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(91, 13)
        Label2.TabIndex = 38
        Label2.Text = "Select Product"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(372, 7)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(61, 13)
        Label5.TabIndex = 41
        Label5.Text = "TotalCost"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(241, 7)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(63, 13)
        Label4.TabIndex = 40
        Label4.Text = "Unit Price"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(307, 7)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(54, 13)
        Label3.TabIndex = 39
        Label3.Text = "Quantity"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.AD_CustomersDataGridView)
        Me.Panel1.Controls.Add(QDateLabel)
        Me.Panel1.Controls.Add(QuatationIDLabel)
        Me.Panel1.Controls.Add(Me.QDateDateTimePicker)
        Me.Panel1.Controls.Add(Me.QuatationIDTextBox)
        Me.Panel1.Controls.Add(PaymentTypeLabel)
        Me.Panel1.Controls.Add(Me.CustTitleTextBox)
        Me.Panel1.Controls.Add(Me.PaymentTypeComboBox)
        Me.Panel1.Controls.Add(CustTitleLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 160)
        Me.Panel1.TabIndex = 0
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
        Me.AD_CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.Column1})
        Me.AD_CustomersDataGridView.DataSource = Me.AD_CustomersBindingSource
        Me.AD_CustomersDataGridView.Location = New System.Drawing.Point(253, 3)
        Me.AD_CustomersDataGridView.Name = "AD_CustomersDataGridView"
        Me.AD_CustomersDataGridView.ReadOnly = True
        Me.AD_CustomersDataGridView.RowHeadersVisible = False
        Me.AD_CustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_CustomersDataGridView.Size = New System.Drawing.Size(529, 155)
        Me.AD_CustomersDataGridView.TabIndex = 24
        Me.AD_CustomersDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CustTitle"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn8.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ConctactPerson"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn9.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CustAddress"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn12.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 250
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CustOffNo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn13.HeaderText = "Contact No"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Custid"
        Me.Column1.HeaderText = "CustomerID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
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
        'QDateDateTimePicker
        '
        Me.QDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Quatation_MBindingSource, "QDate", True))
        Me.QDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "QDate", True))
        Me.QDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.QDateDateTimePicker.Location = New System.Drawing.Point(104, 34)
        Me.QDateDateTimePicker.Name = "QDateDateTimePicker"
        Me.QDateDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.QDateDateTimePicker.TabIndex = 8
        '
        'Quatation_MBindingSource
        '
        Me.Quatation_MBindingSource.DataMember = "Quatation_M"
        Me.Quatation_MBindingSource.DataSource = Me.ISPASDataSet
        '
        'QuatationIDTextBox
        '
        Me.QuatationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "QuatationID", True))
        Me.QuatationIDTextBox.Location = New System.Drawing.Point(104, 7)
        Me.QuatationIDTextBox.Name = "QuatationIDTextBox"
        Me.QuatationIDTextBox.ReadOnly = True
        Me.QuatationIDTextBox.Size = New System.Drawing.Size(71, 20)
        Me.QuatationIDTextBox.TabIndex = 4
        '
        'CustTitleTextBox
        '
        Me.CustTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "CustTitle", True))
        Me.CustTitleTextBox.Location = New System.Drawing.Point(104, 60)
        Me.CustTitleTextBox.Name = "CustTitleTextBox"
        Me.CustTitleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustTitleTextBox.TabIndex = 6
        '
        'PaymentTypeComboBox
        '
        Me.PaymentTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "PaymentType", True))
        Me.PaymentTypeComboBox.FormattingEnabled = True
        Me.PaymentTypeComboBox.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.PaymentTypeComboBox.Location = New System.Drawing.Point(104, 86)
        Me.PaymentTypeComboBox.Name = "PaymentTypeComboBox"
        Me.PaymentTypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PaymentTypeComboBox.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(DiscountLabel)
        Me.Panel2.Controls.Add(TotalAmountLabel)
        Me.Panel2.Controls.Add(Me.DiscountTextBox)
        Me.Panel2.Controls.Add(Me.OriginalAmountTextBox)
        Me.Panel2.Controls.Add(OriginalAmountLabel)
        Me.Panel2.Controls.Add(Me.TotalAmountTextBox)
        Me.Panel2.Controls.Add(Me.DiscountAmountTextBox)
        Me.Panel2.Controls.Add(DiscountAmountLabel)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(4, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 108)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 91)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Rs. 0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "Discount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.DiscountTextBox.Location = New System.Drawing.Point(677, 32)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(101, 20)
        Me.DiscountTextBox.TabIndex = 10
        '
        'OriginalAmountTextBox
        '
        Me.OriginalAmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OriginalAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "OriginalAmount", True))
        Me.OriginalAmountTextBox.Location = New System.Drawing.Point(677, 84)
        Me.OriginalAmountTextBox.Name = "OriginalAmountTextBox"
        Me.OriginalAmountTextBox.Size = New System.Drawing.Size(101, 20)
        Me.OriginalAmountTextBox.TabIndex = 18
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "TotalAmount", True))
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(677, 6)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(101, 20)
        Me.TotalAmountTextBox.TabIndex = 12
        '
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quatation_MBindingSource, "DiscountAmount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(677, 58)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(101, 20)
        Me.DiscountAmountTextBox.TabIndex = 16
        '
        'Quatation_MTableAdapter
        '
        Me.Quatation_MTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Quatation_DTableAdapter = Me.Quatation_DTableAdapter
        Me.TableAdapterManager.Quatation_MTableAdapter = Me.Quatation_MTableAdapter
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
        'Quatation_DTableAdapter
        '
        Me.Quatation_DTableAdapter.ClearBeforeFill = True
        '
        'Quatation_MBindingNavigator
        '
        Me.Quatation_MBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Quatation_MBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.Quatation_MBindingNavigator.BindingSource = Me.Quatation_MBindingSource
        Me.Quatation_MBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Quatation_MBindingNavigator.CountItemFormat = "{0}"
        Me.Quatation_MBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Quatation_MBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quatation_MBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Quatation_MBindingNavigatorSaveItem, Me.PrintToolStripButton, Me.ToSalesInvoiceToolStripButton})
        Me.Quatation_MBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Quatation_MBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Quatation_MBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Quatation_MBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Quatation_MBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Quatation_MBindingNavigator.Name = "Quatation_MBindingNavigator"
        Me.Quatation_MBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Quatation_MBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Quatation_MBindingNavigator.TabIndex = 2
        Me.Quatation_MBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorCountItem.Text = "{0}"
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
        'Quatation_MBindingNavigatorSaveItem
        '
        Me.Quatation_MBindingNavigatorSaveItem.Image = CType(resources.GetObject("Quatation_MBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Quatation_MBindingNavigatorSaveItem.Name = "Quatation_MBindingNavigatorSaveItem"
        Me.Quatation_MBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.Quatation_MBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(54, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'ToSalesInvoiceToolStripButton
        '
        Me.ToSalesInvoiceToolStripButton.Image = CType(resources.GetObject("ToSalesInvoiceToolStripButton.Image"), System.Drawing.Image)
        Me.ToSalesInvoiceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToSalesInvoiceToolStripButton.Name = "ToSalesInvoiceToolStripButton"
        Me.ToSalesInvoiceToolStripButton.Size = New System.Drawing.Size(113, 22)
        Me.ToSalesInvoiceToolStripButton.Text = "To Sale Invoice"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Label2)
        Me.Panel3.Controls.Add(Me.ProductTextBox)
        Me.Panel3.Controls.Add(Label5)
        Me.Panel3.Controls.Add(Me.UnitPriceTextBox)
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Controls.Add(Me.QuantityTextBox)
        Me.Panel3.Controls.Add(Label3)
        Me.Panel3.Controls.Add(Me.TotalCostTextBox)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Quatation_DDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(6, 261)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(794, 317)
        Me.Panel3.TabIndex = 3
        '
        'ProductTextBox
        '
        Me.ProductTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTextBox.Location = New System.Drawing.Point(7, 23)
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.Size = New System.Drawing.Size(228, 20)
        Me.ProductTextBox.TabIndex = 33
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(244, 23)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(57, 20)
        Me.UnitPriceTextBox.TabIndex = 34
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(307, 23)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(59, 20)
        Me.QuantityTextBox.TabIndex = 35
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(375, 23)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(58, 20)
        Me.TotalCostTextBox.TabIndex = 36
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Particular, Me.Qty, Me.Description, Me.Remark})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 46)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(775, 153)
        Me.DataGridView1.TabIndex = 43
        Me.DataGridView1.Visible = False
        '
        'Particular
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Particular.DefaultCellStyle = DataGridViewCellStyle5
        Me.Particular.HeaderText = "Product"
        Me.Particular.Name = "Particular"
        Me.Particular.ReadOnly = True
        '
        'Qty
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle6
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'Description
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.Description.DefaultCellStyle = DataGridViewCellStyle7
        Me.Description.HeaderText = "Unit Price"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Remark
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle8
        Me.Remark.HeaderText = "Total Cost"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        '
        'Quatation_DDataGridView
        '
        Me.Quatation_DDataGridView.AllowUserToAddRows = False
        Me.Quatation_DDataGridView.AllowUserToDeleteRows = False
        Me.Quatation_DDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Quatation_DDataGridView.AutoGenerateColumns = False
        Me.Quatation_DDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Quatation_DDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Quatation_DDataGridView.DataSource = Me.Quatation_DBindingSource
        Me.Quatation_DDataGridView.Location = New System.Drawing.Point(7, 46)
        Me.Quatation_DDataGridView.Name = "Quatation_DDataGridView"
        Me.Quatation_DDataGridView.ReadOnly = True
        Me.Quatation_DDataGridView.Size = New System.Drawing.Size(775, 153)
        Me.Quatation_DDataGridView.TabIndex = 42
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Quatation_DID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Quatation_DID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "QuatationID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "QuatationID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalCost"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Cost"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'Quatation_DBindingSource
        '
        Me.Quatation_DBindingSource.DataMember = "Quatation_MQuatation_D"
        Me.Quatation_DBindingSource.DataSource = Me.Quatation_MBindingSource
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
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn17})
        Me.AD_ProductsDataGridView.DataSource = Me.AD_ProductsBindingSource
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(6, 61)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(788, 198)
        Me.AD_ProductsDataGridView.TabIndex = 42
        Me.AD_ProductsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ProdTitle"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn10.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ProdCate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ProdUnits"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Vendor"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Vendor"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'AD_ProductsBindingSource
        '
        Me.AD_ProductsBindingSource.DataMember = "AD_Products"
        Me.AD_ProductsBindingSource.DataSource = Me.ISPASDataSet
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(800, 33)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Quotation"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuatation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 578)
        Me.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Quatation_MBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmQuatation"
        Me.Text = "Quotation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AD_CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quatation_MBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Quatation_MBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Quatation_MBindingNavigator.ResumeLayout(False)
        Me.Quatation_MBindingNavigator.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quatation_DDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quatation_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents Quatation_MBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quatation_MTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Quatation_MTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Quatation_MBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Quatation_MBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QuatationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OriginalAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AD_CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AD_CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_CustomersTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_CustomersTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ProductTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AD_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quatation_DTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Quatation_DTableAdapter
    Friend WithEvents Quatation_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quatation_DDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Particular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToSalesInvoiceToolStripButton As System.Windows.Forms.ToolStripButton
End Class
