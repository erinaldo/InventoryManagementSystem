<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmiCalcfrom
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
        Dim PLabel As System.Windows.Forms.Label
        Dim EMILabel As System.Windows.Forms.Label
        Dim IPLabel As System.Windows.Forms.Label
        Dim DCLabel As System.Windows.Forms.Label
        Dim CNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim RLabel As System.Windows.Forms.Label
        Dim MLabel As System.Windows.Forms.Label
        Dim IMLabel As System.Windows.Forms.Label
        Dim SchemeNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmiCalcfrom))
        Me.EMICalcDataSet = New ISPASystem.EMICalcDataSet
        Me.EMICalcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMICalcTableAdapter = New ISPASystem.EMICalcDataSetTableAdapters.EMICalcTableAdapter
        Me.TableAdapterManager = New ISPASystem.EMICalcDataSetTableAdapters.TableAdapterManager
        Me.EMISchemeTableAdapter = New ISPASystem.EMICalcDataSetTableAdapters.EMISchemeTableAdapter
        Me.EMICalcBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EMICalcBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PTextBox = New System.Windows.Forms.TextBox
        Me.TTextBox = New System.Windows.Forms.TextBox
        Me.EMITextBox = New System.Windows.Forms.TextBox
        Me.IPTextBox = New System.Windows.Forms.TextBox
        Me.DCTextBox = New System.Windows.Forms.TextBox
        Me.CNameTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.PhoneTextBox = New System.Windows.Forms.TextBox
        Me.QDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.SchemeIdComboBox = New System.Windows.Forms.ComboBox
        Me.EMISchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RTextBox = New System.Windows.Forms.TextBox
        Me.MTextBox = New System.Windows.Forms.TextBox
        Me.IMTextBox = New System.Windows.Forms.TextBox
        Me.CRTextBox = New System.Windows.Forms.TextBox
        PLabel = New System.Windows.Forms.Label
        EMILabel = New System.Windows.Forms.Label
        IPLabel = New System.Windows.Forms.Label
        DCLabel = New System.Windows.Forms.Label
        CNameLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        PhoneLabel = New System.Windows.Forms.Label
        RLabel = New System.Windows.Forms.Label
        MLabel = New System.Windows.Forms.Label
        IMLabel = New System.Windows.Forms.Label
        SchemeNameLabel = New System.Windows.Forms.Label
        CType(Me.EMICalcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMICalcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMICalcBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMICalcBindingNavigator.SuspendLayout()
        CType(Me.EMISchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PLabel
        '
        PLabel.AutoSize = True
        PLabel.Location = New System.Drawing.Point(57, 144)
        PLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PLabel.Name = "PLabel"
        PLabel.Size = New System.Drawing.Size(47, 13)
        PLabel.TabIndex = 5
        PLabel.Text = "Principle"
        '
        'EMILabel
        '
        EMILabel.AutoSize = True
        EMILabel.Location = New System.Drawing.Point(41, 201)
        EMILabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EMILabel.Name = "EMILabel"
        EMILabel.Size = New System.Drawing.Size(65, 13)
        EMILabel.TabIndex = 9
        EMILabel.Text = "EMI Amount"
        '
        'IPLabel
        '
        IPLabel.AutoSize = True
        IPLabel.Location = New System.Drawing.Point(31, 217)
        IPLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IPLabel.Name = "IPLabel"
        IPLabel.Size = New System.Drawing.Size(75, 13)
        IPLabel.TabIndex = 11
        IPLabel.Text = "Initial Payment"
        '
        'DCLabel
        '
        DCLabel.AutoSize = True
        DCLabel.Location = New System.Drawing.Point(159, 182)
        DCLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DCLabel.Name = "DCLabel"
        DCLabel.Size = New System.Drawing.Size(93, 13)
        DCLabel.TabIndex = 13
        DCLabel.Text = "Document Charge"
        '
        'CNameLabel
        '
        CNameLabel.AutoSize = True
        CNameLabel.Location = New System.Drawing.Point(23, 42)
        CNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CNameLabel.Name = "CNameLabel"
        CNameLabel.Size = New System.Drawing.Size(82, 13)
        CNameLabel.TabIndex = 15
        CNameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(56, 70)
        AddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 17
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(64, 102)
        PhoneLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 19
        PhoneLabel.Text = "Phone:"
        '
        'RLabel
        '
        RLabel.AutoSize = True
        RLabel.Location = New System.Drawing.Point(77, 163)
        RLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        RLabel.Name = "RLabel"
        RLabel.Size = New System.Drawing.Size(30, 13)
        RLabel.TabIndex = 28
        RLabel.Text = "Rate"
        '
        'MLabel
        '
        MLabel.AutoSize = True
        MLabel.Location = New System.Drawing.Point(34, 182)
        MLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MLabel.Name = "MLabel"
        MLabel.Size = New System.Drawing.Size(73, 13)
        MLabel.TabIndex = 30
        MLabel.Text = "No Of Months"
        '
        'IMLabel
        '
        IMLabel.AutoSize = True
        IMLabel.Location = New System.Drawing.Point(159, 163)
        IMLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IMLabel.Name = "IMLabel"
        IMLabel.Size = New System.Drawing.Size(98, 13)
        IMLabel.TabIndex = 32
        IMLabel.Text = "No of Initial Months"
        '
        'SchemeNameLabel
        '
        SchemeNameLabel.AutoSize = True
        SchemeNameLabel.Location = New System.Drawing.Point(26, 125)
        SchemeNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SchemeNameLabel.Name = "SchemeNameLabel"
        SchemeNameLabel.Size = New System.Drawing.Size(80, 13)
        SchemeNameLabel.TabIndex = 36
        SchemeNameLabel.Text = "Scheme Name:"
        '
        'EMICalcDataSet
        '
        Me.EMICalcDataSet.DataSetName = "EMICalcDataSet"
        Me.EMICalcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMICalcBindingSource
        '
        Me.EMICalcBindingSource.DataMember = "EMICalc"
        Me.EMICalcBindingSource.DataSource = Me.EMICalcDataSet
        '
        'EMICalcTableAdapter
        '
        Me.EMICalcTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EMICalcTableAdapter = Me.EMICalcTableAdapter
        Me.TableAdapterManager.EMISchemeTableAdapter = Me.EMISchemeTableAdapter
        Me.TableAdapterManager.UpdateOrder = ISPASystem.EMICalcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMISchemeTableAdapter
        '
        Me.EMISchemeTableAdapter.ClearBeforeFill = True
        '
        'EMICalcBindingNavigator
        '
        Me.EMICalcBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMICalcBindingNavigator.BindingSource = Me.EMICalcBindingSource
        Me.EMICalcBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMICalcBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMICalcBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMICalcBindingNavigatorSaveItem})
        Me.EMICalcBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMICalcBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMICalcBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMICalcBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMICalcBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMICalcBindingNavigator.Name = "EMICalcBindingNavigator"
        Me.EMICalcBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.EMICalcBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMICalcBindingNavigator.Size = New System.Drawing.Size(482, 25)
        Me.EMICalcBindingNavigator.TabIndex = 0
        Me.EMICalcBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(27, 21)
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
        'EMICalcBindingNavigatorSaveItem
        '
        Me.EMICalcBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMICalcBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMICalcBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMICalcBindingNavigatorSaveItem.Name = "EMICalcBindingNavigatorSaveItem"
        Me.EMICalcBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EMICalcBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PTextBox
        '
        Me.PTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "P", True))
        Me.PTextBox.Location = New System.Drawing.Point(106, 141)
        Me.PTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PTextBox.Name = "PTextBox"
        Me.PTextBox.Size = New System.Drawing.Size(202, 20)
        Me.PTextBox.TabIndex = 6
        '
        'TTextBox
        '
        Me.TTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "T", True))
        Me.TTextBox.Location = New System.Drawing.Point(346, 318)
        Me.TTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TTextBox.Name = "TTextBox"
        Me.TTextBox.Size = New System.Drawing.Size(28, 20)
        Me.TTextBox.TabIndex = 8
        '
        'EMITextBox
        '
        Me.EMITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "EMI", True))
        Me.EMITextBox.Enabled = False
        Me.EMITextBox.Location = New System.Drawing.Point(106, 198)
        Me.EMITextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EMITextBox.Name = "EMITextBox"
        Me.EMITextBox.Size = New System.Drawing.Size(102, 20)
        Me.EMITextBox.TabIndex = 10
        '
        'IPTextBox
        '
        Me.IPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "IP", True))
        Me.IPTextBox.Enabled = False
        Me.IPTextBox.Location = New System.Drawing.Point(106, 217)
        Me.IPTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(102, 20)
        Me.IPTextBox.TabIndex = 12
        '
        'DCTextBox
        '
        Me.DCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "DC", True))
        Me.DCTextBox.Enabled = False
        Me.DCTextBox.Location = New System.Drawing.Point(256, 179)
        Me.DCTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DCTextBox.Name = "DCTextBox"
        Me.DCTextBox.Size = New System.Drawing.Size(52, 20)
        Me.DCTextBox.TabIndex = 14
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "CName", True))
        Me.CNameTextBox.Location = New System.Drawing.Point(106, 42)
        Me.CNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(176, 20)
        Me.CNameTextBox.TabIndex = 16
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(106, 62)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(140, 39)
        Me.AddressTextBox.TabIndex = 18
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMICalcBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(106, 102)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(112, 20)
        Me.PhoneTextBox.TabIndex = 20
        '
        'QDateDateTimePicker
        '
        Me.QDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMICalcBindingSource, "QDate", True))
        Me.QDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.QDateDateTimePicker.Location = New System.Drawing.Point(285, 43)
        Me.QDateDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QDateDateTimePicker.Name = "QDateDateTimePicker"
        Me.QDateDateTimePicker.Size = New System.Drawing.Size(64, 20)
        Me.QDateDateTimePicker.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 120)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 19)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SchemeIdComboBox
        '
        Me.SchemeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EMICalcBindingSource, "SchemeId", True))
        Me.SchemeIdComboBox.DataSource = Me.EMISchemeBindingSource
        Me.SchemeIdComboBox.DisplayMember = "SchemeName"
        Me.SchemeIdComboBox.FormattingEnabled = True
        Me.SchemeIdComboBox.Location = New System.Drawing.Point(106, 121)
        Me.SchemeIdComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SchemeIdComboBox.Name = "SchemeIdComboBox"
        Me.SchemeIdComboBox.Size = New System.Drawing.Size(168, 21)
        Me.SchemeIdComboBox.TabIndex = 37
        Me.SchemeIdComboBox.ValueMember = "ID"
        '
        'EMISchemeBindingSource
        '
        Me.EMISchemeBindingSource.DataMember = "EMIScheme"
        Me.EMISchemeBindingSource.DataSource = Me.EMICalcDataSet
        '
        'RTextBox
        '
        Me.RTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "R", True))
        Me.RTextBox.Enabled = False
        Me.RTextBox.Location = New System.Drawing.Point(106, 160)
        Me.RTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RTextBox.Name = "RTextBox"
        Me.RTextBox.Size = New System.Drawing.Size(52, 20)
        Me.RTextBox.TabIndex = 38
        '
        'MTextBox
        '
        Me.MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "M", True))
        Me.MTextBox.Enabled = False
        Me.MTextBox.Location = New System.Drawing.Point(106, 179)
        Me.MTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MTextBox.Name = "MTextBox"
        Me.MTextBox.Size = New System.Drawing.Size(52, 20)
        Me.MTextBox.TabIndex = 39
        '
        'IMTextBox
        '
        Me.IMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "IM", True))
        Me.IMTextBox.Enabled = False
        Me.IMTextBox.Location = New System.Drawing.Point(256, 160)
        Me.IMTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IMTextBox.Name = "IMTextBox"
        Me.IMTextBox.Size = New System.Drawing.Size(52, 20)
        Me.IMTextBox.TabIndex = 40
        '
        'CRTextBox
        '
        Me.CRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMISchemeBindingSource, "CR", True))
        Me.CRTextBox.Location = New System.Drawing.Point(297, 318)
        Me.CRTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CRTextBox.Name = "CRTextBox"
        Me.CRTextBox.Size = New System.Drawing.Size(21, 20)
        Me.CRTextBox.TabIndex = 41
        '
        'EmiCalcfrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 378)
        Me.Controls.Add(Me.IMTextBox)
        Me.Controls.Add(Me.MTextBox)
        Me.Controls.Add(Me.RTextBox)
        Me.Controls.Add(Me.SchemeIdComboBox)
        Me.Controls.Add(SchemeNameLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RLabel)
        Me.Controls.Add(MLabel)
        Me.Controls.Add(IMLabel)
        Me.Controls.Add(PLabel)
        Me.Controls.Add(Me.PTextBox)
        Me.Controls.Add(EMILabel)
        Me.Controls.Add(Me.EMITextBox)
        Me.Controls.Add(IPLabel)
        Me.Controls.Add(Me.IPTextBox)
        Me.Controls.Add(DCLabel)
        Me.Controls.Add(Me.DCTextBox)
        Me.Controls.Add(CNameLabel)
        Me.Controls.Add(Me.CNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.QDateDateTimePicker)
        Me.Controls.Add(Me.EMICalcBindingNavigator)
        Me.Controls.Add(Me.CRTextBox)
        Me.Controls.Add(Me.TTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EmiCalcfrom"
        Me.Text = "EmiCalcfrom"
        CType(Me.EMICalcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMICalcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMICalcBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMICalcBindingNavigator.ResumeLayout(False)
        Me.EMICalcBindingNavigator.PerformLayout()
        CType(Me.EMISchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EMICalcDataSet As ISPASystem.EMICalcDataSet
    Friend WithEvents EMICalcBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMICalcTableAdapter As ISPASystem.EMICalcDataSetTableAdapters.EMICalcTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.EMICalcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMICalcBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EMICalcBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMITextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EMISchemeTableAdapter As ISPASystem.EMICalcDataSetTableAdapters.EMISchemeTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SchemeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EMISchemeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CRTextBox As System.Windows.Forms.TextBox
End Class
