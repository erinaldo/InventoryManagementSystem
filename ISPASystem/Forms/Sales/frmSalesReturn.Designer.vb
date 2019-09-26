<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReturn
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
        Dim SRetNoLabel As System.Windows.Forms.Label
        Dim SRetDateLabel As System.Windows.Forms.Label
        Dim SInvNoLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim InvDateLabel As System.Windows.Forms.Label
        Dim ItemPriceLabel As System.Windows.Forms.Label
        Dim QuantitySaleLabel As System.Windows.Forms.Label
        Dim QuantityReturnLabel As System.Windows.Forms.Label
        Dim ReasonLabel As System.Windows.Forms.Label
        Dim ProdTitleLabel As System.Windows.Forms.Label
        Me.Sale_ReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.SRetNoTextBox = New System.Windows.Forms.TextBox
        Me.SRetDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SInvNoTextBox = New System.Windows.Forms.TextBox
        Me.CustomerTextBox = New System.Windows.Forms.TextBox
        Me.SaleInvoiceMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ItemPriceTextBox = New System.Windows.Forms.TextBox
        Me.SaleInvoice_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantitySaleTextBox = New System.Windows.Forms.TextBox
        Me.QuantityReturnTextBox = New System.Windows.Forms.TextBox
        Me.ReasonTextBox = New System.Windows.Forms.TextBox
        Me.DefectedCheckBox = New System.Windows.Forms.CheckBox
        Me.ProdTitleComboBox = New System.Windows.Forms.ComboBox
        Me.Sale_ReturnTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.Sale_ReturnTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.AD_ProductsTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
        Me.LedgerTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
        Me.SaleInvoice_DTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_DTableAdapter
        Me.SaleInvoice_MTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_MTableAdapter
        Me.ProcessButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        SRetNoLabel = New System.Windows.Forms.Label
        SRetDateLabel = New System.Windows.Forms.Label
        SInvNoLabel = New System.Windows.Forms.Label
        CustomerLabel = New System.Windows.Forms.Label
        InvDateLabel = New System.Windows.Forms.Label
        ItemPriceLabel = New System.Windows.Forms.Label
        QuantitySaleLabel = New System.Windows.Forms.Label
        QuantityReturnLabel = New System.Windows.Forms.Label
        ReasonLabel = New System.Windows.Forms.Label
        ProdTitleLabel = New System.Windows.Forms.Label
        CType(Me.Sale_ReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoiceMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleInvoice_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SRetNoLabel
        '
        SRetNoLabel.AutoSize = True
        SRetNoLabel.Location = New System.Drawing.Point(12, 19)
        SRetNoLabel.Name = "SRetNoLabel"
        SRetNoLabel.Size = New System.Drawing.Size(59, 13)
        SRetNoLabel.TabIndex = 1
        SRetNoLabel.Text = "SRet No:"
        '
        'SRetDateLabel
        '
        SRetDateLabel.AutoSize = True
        SRetDateLabel.Location = New System.Drawing.Point(12, 124)
        SRetDateLabel.Name = "SRetDateLabel"
        SRetDateLabel.Size = New System.Drawing.Size(70, 13)
        SRetDateLabel.TabIndex = 3
        SRetDateLabel.Text = "SRet Date:"
        '
        'SInvNoLabel
        '
        SInvNoLabel.AutoSize = True
        SInvNoLabel.Location = New System.Drawing.Point(12, 45)
        SInvNoLabel.Name = "SInvNoLabel"
        SInvNoLabel.Size = New System.Drawing.Size(57, 13)
        SInvNoLabel.TabIndex = 5
        SInvNoLabel.Text = "SInv No:"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(12, 97)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(63, 13)
        CustomerLabel.TabIndex = 7
        CustomerLabel.Text = "Customer:"
        '
        'InvDateLabel
        '
        InvDateLabel.AutoSize = True
        InvDateLabel.Location = New System.Drawing.Point(12, 72)
        InvDateLabel.Name = "InvDateLabel"
        InvDateLabel.Size = New System.Drawing.Size(60, 13)
        InvDateLabel.TabIndex = 11
        InvDateLabel.Text = "Inv Date:"
        '
        'ItemPriceLabel
        '
        ItemPriceLabel.AutoSize = True
        ItemPriceLabel.Location = New System.Drawing.Point(12, 175)
        ItemPriceLabel.Name = "ItemPriceLabel"
        ItemPriceLabel.Size = New System.Drawing.Size(68, 13)
        ItemPriceLabel.TabIndex = 13
        ItemPriceLabel.Text = "Item Price:"
        '
        'QuantitySaleLabel
        '
        QuantitySaleLabel.AutoSize = True
        QuantitySaleLabel.Location = New System.Drawing.Point(12, 201)
        QuantitySaleLabel.Name = "QuantitySaleLabel"
        QuantitySaleLabel.Size = New System.Drawing.Size(87, 13)
        QuantitySaleLabel.TabIndex = 15
        QuantitySaleLabel.Text = "Quantity Sale:"
        '
        'QuantityReturnLabel
        '
        QuantityReturnLabel.AutoSize = True
        QuantityReturnLabel.Location = New System.Drawing.Point(12, 227)
        QuantityReturnLabel.Name = "QuantityReturnLabel"
        QuantityReturnLabel.Size = New System.Drawing.Size(100, 13)
        QuantityReturnLabel.TabIndex = 17
        QuantityReturnLabel.Text = "Quantity Return:"
        '
        'ReasonLabel
        '
        ReasonLabel.AutoSize = True
        ReasonLabel.Location = New System.Drawing.Point(12, 253)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(54, 13)
        ReasonLabel.TabIndex = 19
        ReasonLabel.Text = "Reason:"
        '
        'ProdTitleLabel
        '
        ProdTitleLabel.AutoSize = True
        ProdTitleLabel.Location = New System.Drawing.Point(13, 149)
        ProdTitleLabel.Name = "ProdTitleLabel"
        ProdTitleLabel.Size = New System.Drawing.Size(66, 13)
        ProdTitleLabel.TabIndex = 22
        ProdTitleLabel.Text = "Prod Title:"
        '
        'Sale_ReturnBindingSource
        '
        Me.Sale_ReturnBindingSource.DataMember = "Sale_Return"
        Me.Sale_ReturnBindingSource.DataSource = Me.ISPASDataSet
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SRetNoTextBox
        '
        Me.SRetNoTextBox.Location = New System.Drawing.Point(117, 16)
        Me.SRetNoTextBox.Name = "SRetNoTextBox"
        Me.SRetNoTextBox.ReadOnly = True
        Me.SRetNoTextBox.Size = New System.Drawing.Size(72, 20)
        Me.SRetNoTextBox.TabIndex = 0
        '
        'SRetDateDateTimePicker
        '
        Me.SRetDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sale_ReturnBindingSource, "SRetDate", True))
        Me.SRetDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SRetDateDateTimePicker.Location = New System.Drawing.Point(117, 120)
        Me.SRetDateDateTimePicker.Name = "SRetDateDateTimePicker"
        Me.SRetDateDateTimePicker.Size = New System.Drawing.Size(117, 20)
        Me.SRetDateDateTimePicker.TabIndex = 5
        '
        'SInvNoTextBox
        '
        Me.SInvNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sale_ReturnBindingSource, "SInvNo", True))
        Me.SInvNoTextBox.Location = New System.Drawing.Point(117, 42)
        Me.SInvNoTextBox.Name = "SInvNoTextBox"
        Me.SInvNoTextBox.Size = New System.Drawing.Size(117, 20)
        Me.SInvNoTextBox.TabIndex = 1
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoiceMBindingSource, "CustName", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(117, 94)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.ReadOnly = True
        Me.CustomerTextBox.Size = New System.Drawing.Size(210, 20)
        Me.CustomerTextBox.TabIndex = 4
        '
        'SaleInvoiceMBindingSource
        '
        Me.SaleInvoiceMBindingSource.DataMember = "SaleInvoice_M"
        Me.SaleInvoiceMBindingSource.DataSource = Me.ISPASDataSet
        '
        'InvDateDateTimePicker
        '
        Me.InvDateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.InvDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SaleInvoiceMBindingSource, "SIDate", True))
        Me.InvDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InvDateDateTimePicker.Location = New System.Drawing.Point(117, 68)
        Me.InvDateDateTimePicker.Name = "InvDateDateTimePicker"
        Me.InvDateDateTimePicker.Size = New System.Drawing.Size(117, 20)
        Me.InvDateDateTimePicker.TabIndex = 3
        '
        'ItemPriceTextBox
        '
        Me.ItemPriceTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_DBindingSource, "UnitPrice", True))
        Me.ItemPriceTextBox.Location = New System.Drawing.Point(117, 172)
        Me.ItemPriceTextBox.Name = "ItemPriceTextBox"
        Me.ItemPriceTextBox.ReadOnly = True
        Me.ItemPriceTextBox.Size = New System.Drawing.Size(117, 20)
        Me.ItemPriceTextBox.TabIndex = 7
        '
        'SaleInvoice_DBindingSource
        '
        Me.SaleInvoice_DBindingSource.DataMember = "SaleInvoice_D"
        Me.SaleInvoice_DBindingSource.DataSource = Me.ISPASDataSet
        '
        'QuantitySaleTextBox
        '
        Me.QuantitySaleTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QuantitySaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleInvoice_DBindingSource, "Quantity", True))
        Me.QuantitySaleTextBox.Location = New System.Drawing.Point(117, 198)
        Me.QuantitySaleTextBox.Name = "QuantitySaleTextBox"
        Me.QuantitySaleTextBox.ReadOnly = True
        Me.QuantitySaleTextBox.Size = New System.Drawing.Size(117, 20)
        Me.QuantitySaleTextBox.TabIndex = 8
        '
        'QuantityReturnTextBox
        '
        Me.QuantityReturnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sale_ReturnBindingSource, "QuantityReturn", True))
        Me.QuantityReturnTextBox.Location = New System.Drawing.Point(117, 224)
        Me.QuantityReturnTextBox.Name = "QuantityReturnTextBox"
        Me.QuantityReturnTextBox.Size = New System.Drawing.Size(72, 20)
        Me.QuantityReturnTextBox.TabIndex = 9
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sale_ReturnBindingSource, "Reason", True))
        Me.ReasonTextBox.Location = New System.Drawing.Point(117, 250)
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(210, 20)
        Me.ReasonTextBox.TabIndex = 10
        '
        'DefectedCheckBox
        '
        Me.DefectedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Sale_ReturnBindingSource, "Defected", True))
        Me.DefectedCheckBox.Location = New System.Drawing.Point(117, 276)
        Me.DefectedCheckBox.Name = "DefectedCheckBox"
        Me.DefectedCheckBox.Size = New System.Drawing.Size(233, 24)
        Me.DefectedCheckBox.TabIndex = 11
        Me.DefectedCheckBox.Text = "Defected"
        Me.DefectedCheckBox.UseVisualStyleBackColor = True
        '
        'ProdTitleComboBox
        '
        Me.ProdTitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProdTitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProdTitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Sale_ReturnBindingSource, "ProdTitle", True))
        Me.ProdTitleComboBox.DataSource = Me.SaleInvoice_DBindingSource
        Me.ProdTitleComboBox.DisplayMember = "ProdTitle"
        Me.ProdTitleComboBox.FormattingEnabled = True
        Me.ProdTitleComboBox.Location = New System.Drawing.Point(117, 146)
        Me.ProdTitleComboBox.Name = "ProdTitleComboBox"
        Me.ProdTitleComboBox.Size = New System.Drawing.Size(210, 21)
        Me.ProdTitleComboBox.TabIndex = 6
        Me.ProdTitleComboBox.ValueMember = "ProdTitle"
        '
        'Sale_ReturnTableAdapter
        '
        Me.Sale_ReturnTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountChartTableAdapter = Nothing
        Me.TableAdapterManager.AD_CustomersTableAdapter = Nothing
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

        Me.TableAdapterManager.LedgerTableAdapter = Me.LedgerTableAdapter
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
        Me.TableAdapterManager.Sale_ReturnTableAdapter = Me.Sale_ReturnTableAdapter
        Me.TableAdapterManager.SaleInvoice_DTableAdapter = Me.SaleInvoice_DTableAdapter
        Me.TableAdapterManager.SaleInvoice_MTableAdapter = Me.SaleInvoice_MTableAdapter
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_DTableAdapter = Nothing
        Me.TableAdapterManager.WorkOrder_MTableAdapter = Nothing
        '
        'AD_ProductsTableAdapter
        '
        Me.AD_ProductsTableAdapter.ClearBeforeFill = True
        '
        'LedgerTableAdapter
        '
        Me.LedgerTableAdapter.ClearBeforeFill = True
        '
        'SaleInvoice_DTableAdapter
        '
        Me.SaleInvoice_DTableAdapter.ClearBeforeFill = True
        '
        'SaleInvoice_MTableAdapter
        '
        Me.SaleInvoice_MTableAdapter.ClearBeforeFill = True
        '
        'ProcessButton
        '
        Me.ProcessButton.Location = New System.Drawing.Point(110, 315)
        Me.ProcessButton.Name = "ProcessButton"
        Me.ProcessButton.Size = New System.Drawing.Size(157, 35)
        Me.ProcessButton.TabIndex = 12
        Me.ProcessButton.Text = "Process"
        Me.ProcessButton.UseVisualStyleBackColor = True
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
        Me.Label1.Size = New System.Drawing.Size(430, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale Return"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(SRetNoLabel)
        Me.Panel1.Controls.Add(Me.DefectedCheckBox)
        Me.Panel1.Controls.Add(Me.ProcessButton)
        Me.Panel1.Controls.Add(Me.ReasonTextBox)
        Me.Panel1.Controls.Add(ProdTitleLabel)
        Me.Panel1.Controls.Add(ReasonLabel)
        Me.Panel1.Controls.Add(Me.ProdTitleComboBox)
        Me.Panel1.Controls.Add(Me.QuantityReturnTextBox)
        Me.Panel1.Controls.Add(QuantityReturnLabel)
        Me.Panel1.Controls.Add(Me.SRetNoTextBox)
        Me.Panel1.Controls.Add(Me.QuantitySaleTextBox)
        Me.Panel1.Controls.Add(SRetDateLabel)
        Me.Panel1.Controls.Add(QuantitySaleLabel)
        Me.Panel1.Controls.Add(Me.SRetDateDateTimePicker)
        Me.Panel1.Controls.Add(Me.ItemPriceTextBox)
        Me.Panel1.Controls.Add(SInvNoLabel)
        Me.Panel1.Controls.Add(ItemPriceLabel)
        Me.Panel1.Controls.Add(Me.SInvNoTextBox)
        Me.Panel1.Controls.Add(Me.InvDateDateTimePicker)
        Me.Panel1.Controls.Add(CustomerLabel)
        Me.Panel1.Controls.Add(InvDateLabel)
        Me.Panel1.Controls.Add(Me.CustomerTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 360)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Load..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSalesReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(428, 402)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmSalesReturn"
        Me.Text = "Sales Return"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Sale_ReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoiceMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleInvoice_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents Sale_ReturnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sale_ReturnTableAdapter As ISPASystem.ISPASDataSetTableAdapters.Sale_ReturnTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SRetNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SRetDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SInvNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ItemPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantitySaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityReturnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReasonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefectedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaleInvoice_MTableAdapter As ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_MTableAdapter
    Friend WithEvents SaleInvoiceMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdTitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaleInvoice_DTableAdapter As ISPASystem.ISPASDataSetTableAdapters.SaleInvoice_DTableAdapter
    Friend WithEvents SaleInvoice_DBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProcessButton As System.Windows.Forms.Button
    Friend WithEvents AD_ProductsTableAdapter As ISPASystem.ISPASDataSetTableAdapters.AD_ProductsTableAdapter
    Friend WithEvents LedgerTableAdapter As ISPASystem.ISPASDataSetTableAdapters.LedgerTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
