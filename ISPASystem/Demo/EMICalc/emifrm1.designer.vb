<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emifrm1
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim SchemeNameLabel As System.Windows.Forms.Label
        Dim SchemeDescLabel As System.Windows.Forms.Label
        Dim RLabel As System.Windows.Forms.Label
        Dim MLabel As System.Windows.Forms.Label
        Dim IMLabel As System.Windows.Forms.Label
        Dim CRLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim SchemeIdLabel As System.Windows.Forms.Label
        Dim PLabel As System.Windows.Forms.Label
        Dim TLabel As System.Windows.Forms.Label
        Dim EMILabel As System.Windows.Forms.Label
        Dim IPLabel As System.Windows.Forms.Label
        Dim DCLabel As System.Windows.Forms.Label
        Dim CNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim QDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emifrm1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.EMISchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMISchemeTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.EMISchemeTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.EMICalcTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.EMICalcTableAdapter
        Me.EMISchemeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EMISchemeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.SchemeNameTextBox = New System.Windows.Forms.TextBox
        Me.SchemeDescTextBox = New System.Windows.Forms.TextBox
        Me.RTextBox = New System.Windows.Forms.TextBox
        Me.MTextBox = New System.Windows.Forms.TextBox
        Me.IMTextBox = New System.Windows.Forms.TextBox
        Me.CRTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.EMICalcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox1 = New System.Windows.Forms.TextBox
        Me.SchemeIdTextBox = New System.Windows.Forms.TextBox
        Me.PTextBox = New System.Windows.Forms.TextBox
        Me.TTextBox = New System.Windows.Forms.TextBox
        Me.EMITextBox = New System.Windows.Forms.TextBox
        Me.IPTextBox = New System.Windows.Forms.TextBox
        Me.DCTextBox = New System.Windows.Forms.TextBox
        Me.CNameTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.PhoneTextBox = New System.Windows.Forms.TextBox
        Me.QDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        IDLabel = New System.Windows.Forms.Label
        SchemeNameLabel = New System.Windows.Forms.Label
        SchemeDescLabel = New System.Windows.Forms.Label
        RLabel = New System.Windows.Forms.Label
        MLabel = New System.Windows.Forms.Label
        IMLabel = New System.Windows.Forms.Label
        CRLabel = New System.Windows.Forms.Label
        IDLabel1 = New System.Windows.Forms.Label
        SchemeIdLabel = New System.Windows.Forms.Label
        PLabel = New System.Windows.Forms.Label
        TLabel = New System.Windows.Forms.Label
        EMILabel = New System.Windows.Forms.Label
        IPLabel = New System.Windows.Forms.Label
        DCLabel = New System.Windows.Forms.Label
        CNameLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        PhoneLabel = New System.Windows.Forms.Label
        QDateLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMISchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMISchemeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMISchemeBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.EMICalcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(102, 14)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 13)
        IDLabel.TabIndex = 13
        IDLabel.Text = "ID:"
        '
        'SchemeNameLabel
        '
        SchemeNameLabel.AutoSize = True
        SchemeNameLabel.Location = New System.Drawing.Point(34, 40)
        SchemeNameLabel.Name = "SchemeNameLabel"
        SchemeNameLabel.Size = New System.Drawing.Size(92, 13)
        SchemeNameLabel.TabIndex = 15
        SchemeNameLabel.Text = "Scheme Name:"
        '
        'SchemeDescLabel
        '
        SchemeDescLabel.AutoSize = True
        SchemeDescLabel.Location = New System.Drawing.Point(51, 66)
        SchemeDescLabel.Name = "SchemeDescLabel"
        SchemeDescLabel.Size = New System.Drawing.Size(75, 13)
        SchemeDescLabel.TabIndex = 17
        SchemeDescLabel.Text = "Description:"
        '
        'RLabel
        '
        RLabel.AutoSize = True
        RLabel.Location = New System.Drawing.Point(24, 93)
        RLabel.Name = "RLabel"
        RLabel.Size = New System.Drawing.Size(102, 13)
        RLabel.TabIndex = 19
        RLabel.Text = "Rate Of Interest:"
        '
        'MLabel
        '
        MLabel.AutoSize = True
        MLabel.Location = New System.Drawing.Point(4, 119)
        MLabel.Name = "MLabel"
        MLabel.Size = New System.Drawing.Size(122, 13)
        MLabel.TabIndex = 21
        MLabel.Text = "Total No Of Months:"
        '
        'IMLabel
        '
        IMLabel.AutoSize = True
        IMLabel.Location = New System.Drawing.Point(260, 93)
        IMLabel.Name = "IMLabel"
        IMLabel.Size = New System.Drawing.Size(120, 13)
        IMLabel.TabIndex = 23
        IMLabel.Text = "No Of Initial Months"
        '
        'CRLabel
        '
        CRLabel.AutoSize = True
        CRLabel.Location = New System.Drawing.Point(260, 118)
        CRLabel.Name = "CRLabel"
        CRLabel.Size = New System.Drawing.Size(111, 13)
        CRLabel.TabIndex = 25
        CRLabel.Text = "Compounded Rate"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(4, 10)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(24, 13)
        IDLabel1.TabIndex = 27
        IDLabel1.Text = "ID:"
        '
        'SchemeIdLabel
        '
        SchemeIdLabel.AutoSize = True
        SchemeIdLabel.Location = New System.Drawing.Point(4, 36)
        SchemeIdLabel.Name = "SchemeIdLabel"
        SchemeIdLabel.Size = New System.Drawing.Size(71, 13)
        SchemeIdLabel.TabIndex = 29
        SchemeIdLabel.Text = "Scheme Id:"
        '
        'PLabel
        '
        PLabel.AutoSize = True
        PLabel.Location = New System.Drawing.Point(4, 62)
        PLabel.Name = "PLabel"
        PLabel.Size = New System.Drawing.Size(19, 13)
        PLabel.TabIndex = 31
        PLabel.Text = "P:"
        '
        'TLabel
        '
        TLabel.AutoSize = True
        TLabel.Location = New System.Drawing.Point(4, 88)
        TLabel.Name = "TLabel"
        TLabel.Size = New System.Drawing.Size(19, 13)
        TLabel.TabIndex = 33
        TLabel.Text = "T:"
        '
        'EMILabel
        '
        EMILabel.AutoSize = True
        EMILabel.Location = New System.Drawing.Point(4, 114)
        EMILabel.Name = "EMILabel"
        EMILabel.Size = New System.Drawing.Size(33, 13)
        EMILabel.TabIndex = 35
        EMILabel.Text = "EMI:"
        '
        'IPLabel
        '
        IPLabel.AutoSize = True
        IPLabel.Location = New System.Drawing.Point(4, 140)
        IPLabel.Name = "IPLabel"
        IPLabel.Size = New System.Drawing.Size(23, 13)
        IPLabel.TabIndex = 37
        IPLabel.Text = "IP:"
        '
        'DCLabel
        '
        DCLabel.AutoSize = True
        DCLabel.Location = New System.Drawing.Point(4, 166)
        DCLabel.Name = "DCLabel"
        DCLabel.Size = New System.Drawing.Size(28, 13)
        DCLabel.TabIndex = 39
        DCLabel.Text = "DC:"
        '
        'CNameLabel
        '
        CNameLabel.AutoSize = True
        CNameLabel.Location = New System.Drawing.Point(4, 192)
        CNameLabel.Name = "CNameLabel"
        CNameLabel.Size = New System.Drawing.Size(51, 13)
        CNameLabel.TabIndex = 41
        CNameLabel.Text = "CName:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(4, 218)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(56, 13)
        AddressLabel.TabIndex = 43
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(4, 244)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(47, 13)
        PhoneLabel.TabIndex = 45
        PhoneLabel.Text = "Phone:"
        '
        'QDateLabel
        '
        QDateLabel.AutoSize = True
        QDateLabel.Location = New System.Drawing.Point(4, 271)
        QDateLabel.Name = "QDateLabel"
        QDateLabel.Size = New System.Drawing.Size(47, 13)
        QDateLabel.TabIndex = 47
        QDateLabel.Text = "QDate:"
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
        Me.Label1.Size = New System.Drawing.Size(772, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "EMI Scheme"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMISchemeBindingSource
        '
        Me.EMISchemeBindingSource.DataMember = "EMIScheme"
        Me.EMISchemeBindingSource.DataSource = Me.ISPASDataSet
        '
        'EMISchemeTableAdapter
        '
        Me.EMISchemeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Nothing
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
        Me.TableAdapterManager.EMICalcTableAdapter = Me.EMICalcTableAdapter
        Me.TableAdapterManager.EMISchemeTableAdapter = Me.EMISchemeTableAdapter
        Me.TableAdapterManager.LedgerTableAdapter = Nothing
        Me.TableAdapterManager.MasterTableAdapter = Nothing
        Me.TableAdapterManager.MenuSettingTableAdapter = Nothing
        Me.TableAdapterManager.NewAccountsTableAdapter = Nothing
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
        'EMICalcTableAdapter
        '
        Me.EMICalcTableAdapter.ClearBeforeFill = True
        '
        'EMISchemeBindingNavigator
        '
        Me.EMISchemeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMISchemeBindingNavigator.BindingSource = Me.EMISchemeBindingSource
        Me.EMISchemeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMISchemeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMISchemeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMISchemeBindingNavigatorSaveItem})
        Me.EMISchemeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMISchemeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMISchemeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMISchemeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMISchemeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMISchemeBindingNavigator.Name = "EMISchemeBindingNavigator"
        Me.EMISchemeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMISchemeBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.EMISchemeBindingNavigator.TabIndex = 13
        Me.EMISchemeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'EMISchemeBindingNavigatorSaveItem
        '
        Me.EMISchemeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMISchemeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMISchemeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMISchemeBindingNavigatorSaveItem.Name = "EMISchemeBindingNavigatorSaveItem"
        Me.EMISchemeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EMISchemeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(132, 11)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IDTextBox.TabIndex = 14
        '
        'SchemeNameTextBox
        '
        Me.SchemeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "SchemeName", True))
        Me.SchemeNameTextBox.Location = New System.Drawing.Point(132, 37)
        Me.SchemeNameTextBox.Name = "SchemeNameTextBox"
        Me.SchemeNameTextBox.Size = New System.Drawing.Size(364, 20)
        Me.SchemeNameTextBox.TabIndex = 16
        '
        'SchemeDescTextBox
        '
        Me.SchemeDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "SchemeDesc", True))
        Me.SchemeDescTextBox.Location = New System.Drawing.Point(132, 63)
        Me.SchemeDescTextBox.Name = "SchemeDescTextBox"
        Me.SchemeDescTextBox.Size = New System.Drawing.Size(364, 20)
        Me.SchemeDescTextBox.TabIndex = 18
        '
        'RTextBox
        '
        Me.RTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "R", True))
        Me.RTextBox.Location = New System.Drawing.Point(132, 89)
        Me.RTextBox.Name = "RTextBox"
        Me.RTextBox.Size = New System.Drawing.Size(110, 20)
        Me.RTextBox.TabIndex = 20
        '
        'MTextBox
        '
        Me.MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "M", True))
        Me.MTextBox.Location = New System.Drawing.Point(132, 115)
        Me.MTextBox.Name = "MTextBox"
        Me.MTextBox.Size = New System.Drawing.Size(110, 20)
        Me.MTextBox.TabIndex = 22
        '
        'IMTextBox
        '
        Me.IMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "IM", True))
        Me.IMTextBox.Location = New System.Drawing.Point(386, 115)
        Me.IMTextBox.Name = "IMTextBox"
        Me.IMTextBox.Size = New System.Drawing.Size(110, 20)
        Me.IMTextBox.TabIndex = 24
        '
        'CRTextBox
        '
        Me.CRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "CR", True))
        Me.CRTextBox.Location = New System.Drawing.Point(386, 90)
        Me.CRTextBox.Name = "CRTextBox"
        Me.CRTextBox.Size = New System.Drawing.Size(110, 20)
        Me.CRTextBox.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.CRTextBox)
        Me.Panel1.Controls.Add(CRLabel)
        Me.Panel1.Controls.Add(SchemeNameLabel)
        Me.Panel1.Controls.Add(Me.IMTextBox)
        Me.Panel1.Controls.Add(Me.SchemeNameTextBox)
        Me.Panel1.Controls.Add(IMLabel)
        Me.Panel1.Controls.Add(SchemeDescLabel)
        Me.Panel1.Controls.Add(Me.MTextBox)
        Me.Panel1.Controls.Add(Me.SchemeDescTextBox)
        Me.Panel1.Controls.Add(MLabel)
        Me.Panel1.Controls.Add(RLabel)
        Me.Panel1.Controls.Add(Me.RTextBox)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(34, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 155)
        Me.Panel1.TabIndex = 27
        '
        'EMICalcBindingSource
        '
        Me.EMICalcBindingSource.DataMember = "EMICalc"
        Me.EMICalcBindingSource.DataSource = Me.ISPASDataSet
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(71, 7)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox1.TabIndex = 28
        '
        'SchemeIdTextBox
        '
        Me.SchemeIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "SchemeId", True))
        Me.SchemeIdTextBox.Location = New System.Drawing.Point(71, 33)
        Me.SchemeIdTextBox.Name = "SchemeIdTextBox"
        Me.SchemeIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SchemeIdTextBox.TabIndex = 30
        '
        'PTextBox
        '
        Me.PTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "P", True))
        Me.PTextBox.Location = New System.Drawing.Point(71, 59)
        Me.PTextBox.Name = "PTextBox"
        Me.PTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PTextBox.TabIndex = 32
        '
        'TTextBox
        '
        Me.TTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "T", True))
        Me.TTextBox.Location = New System.Drawing.Point(71, 85)
        Me.TTextBox.Name = "TTextBox"
        Me.TTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TTextBox.TabIndex = 34
        '
        'EMITextBox
        '
        Me.EMITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "EMI", True))
        Me.EMITextBox.Location = New System.Drawing.Point(71, 111)
        Me.EMITextBox.Name = "EMITextBox"
        Me.EMITextBox.Size = New System.Drawing.Size(100, 20)
        Me.EMITextBox.TabIndex = 36
        '
        'IPTextBox
        '
        Me.IPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "IP", True))
        Me.IPTextBox.Location = New System.Drawing.Point(71, 137)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IPTextBox.TabIndex = 38
        '
        'DCTextBox
        '
        Me.DCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "DC", True))
        Me.DCTextBox.Location = New System.Drawing.Point(71, 163)
        Me.DCTextBox.Name = "DCTextBox"
        Me.DCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DCTextBox.TabIndex = 40
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "CName", True))
        Me.CNameTextBox.Location = New System.Drawing.Point(71, 189)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNameTextBox.TabIndex = 42
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(71, 215)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 44
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(71, 241)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 46
        '
        'QDateDateTimePicker
        '
        Me.QDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMICalcBindingSource, "QDate", True))
        Me.QDateDateTimePicker.Location = New System.Drawing.Point(71, 267)
        Me.QDateDateTimePicker.Name = "QDateDateTimePicker"
        Me.QDateDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.QDateDateTimePicker.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(IDLabel1)
        Me.Panel2.Controls.Add(Me.QDateDateTimePicker)
        Me.Panel2.Controls.Add(Me.IDTextBox1)
        Me.Panel2.Controls.Add(QDateLabel)
        Me.Panel2.Controls.Add(SchemeIdLabel)
        Me.Panel2.Controls.Add(Me.PhoneTextBox)
        Me.Panel2.Controls.Add(Me.SchemeIdTextBox)
        Me.Panel2.Controls.Add(PhoneLabel)
        Me.Panel2.Controls.Add(PLabel)
        Me.Panel2.Controls.Add(Me.AddressTextBox)
        Me.Panel2.Controls.Add(Me.PTextBox)
        Me.Panel2.Controls.Add(AddressLabel)
        Me.Panel2.Controls.Add(TLabel)
        Me.Panel2.Controls.Add(Me.CNameTextBox)
        Me.Panel2.Controls.Add(Me.TTextBox)
        Me.Panel2.Controls.Add(CNameLabel)
        Me.Panel2.Controls.Add(EMILabel)
        Me.Panel2.Controls.Add(Me.DCTextBox)
        Me.Panel2.Controls.Add(Me.EMITextBox)
        Me.Panel2.Controls.Add(DCLabel)
        Me.Panel2.Controls.Add(IPLabel)
        Me.Panel2.Controls.Add(Me.IPTextBox)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(34, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 299)
        Me.Panel2.TabIndex = 49
        '
        'Emifrm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 577)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EMISchemeBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Emifrm1"
        Me.Text = "EMI Scheme"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMISchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMISchemeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMISchemeBindingNavigator.ResumeLayout(False)
        Me.EMISchemeBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EMICalcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents EMISchemeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMISchemeTableAdapter As ISPASystem.ISPASDataSetTableAdapters.EMISchemeTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMISchemeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EMISchemeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchemeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchemeDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EMICalcTableAdapter As ISPASystem.ISPASDataSetTableAdapters.EMICalcTableAdapter
    Friend WithEvents EMICalcBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SchemeIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMITextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
