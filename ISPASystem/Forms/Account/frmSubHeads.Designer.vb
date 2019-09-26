<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubHeads
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
        Dim SubHeadLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubHeads))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.MasterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MasterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MasterDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubHeadTextBox = New System.Windows.Forms.TextBox
        Me.TypeComboBox = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        SubHeadLabel = New System.Windows.Forms.Label
        TypeLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasterBindingNavigator.SuspendLayout()
        CType(Me.MasterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubHeadLabel
        '
        SubHeadLabel.AutoSize = True
        SubHeadLabel.Location = New System.Drawing.Point(14, 17)
        SubHeadLabel.Name = "SubHeadLabel"
        SubHeadLabel.Size = New System.Drawing.Size(65, 13)
        SubHeadLabel.TabIndex = 25
        SubHeadLabel.Text = "sub Head:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(14, 43)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(35, 13)
        TypeLabel.TabIndex = 27
        TypeLabel.Text = "type:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 33)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Account Sub Head Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterBindingSource
        '
        Me.MasterBindingSource.DataMember = "Master"
        Me.MasterBindingSource.DataSource = Me.ISPASDataSet
        '
        'MasterTableAdapter
        '
        Me.MasterTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EMICalcTableAdapter = Nothing
        Me.TableAdapterManager.EMISchemeTableAdapter = Nothing
        Me.TableAdapterManager.LedgerTableAdapter = Nothing
        Me.TableAdapterManager.MasterTableAdapter = Me.MasterTableAdapter
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
        'MasterBindingNavigator
        '
        Me.MasterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MasterBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.MasterBindingNavigator.BindingSource = Me.MasterBindingSource
        Me.MasterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MasterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MasterBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MasterBindingNavigatorSaveItem})
        Me.MasterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MasterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MasterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MasterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MasterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MasterBindingNavigator.Name = "MasterBindingNavigator"
        Me.MasterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MasterBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MasterBindingNavigator.Size = New System.Drawing.Size(446, 25)
        Me.MasterBindingNavigator.TabIndex = 25
        Me.MasterBindingNavigator.Text = "BindingNavigator1"
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
        'MasterBindingNavigatorSaveItem
        '
        Me.MasterBindingNavigatorSaveItem.Image = CType(resources.GetObject("MasterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MasterBindingNavigatorSaveItem.Name = "MasterBindingNavigatorSaveItem"
        Me.MasterBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 22)
        Me.MasterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MasterDataGridView
        '
        Me.MasterDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasterDataGridView.AutoGenerateColumns = False
        Me.MasterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MasterDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MasterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MasterDataGridView.DataSource = Me.MasterBindingSource
        Me.MasterDataGridView.Location = New System.Drawing.Point(11, 13)
        Me.MasterDataGridView.Name = "MasterDataGridView"
        Me.MasterDataGridView.Size = New System.Drawing.Size(402, 262)
        Me.MasterDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "accode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "accode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "subHead"
        Me.DataGridViewTextBoxColumn3.HeaderText = "subHead"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'SubHeadTextBox
        '
        Me.SubHeadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "subHead", True))
        Me.SubHeadTextBox.Location = New System.Drawing.Point(76, 14)
        Me.SubHeadTextBox.Name = "SubHeadTextBox"
        Me.SubHeadTextBox.Size = New System.Drawing.Size(220, 20)
        Me.SubHeadTextBox.TabIndex = 26
        '
        'TypeComboBox
        '
        Me.TypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "type", True))
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"Assets", "Capital", "Expenses", "Liabilities", "Purchases", "Revenue", "Sales"})
        Me.TypeComboBox.Location = New System.Drawing.Point(76, 40)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(220, 21)
        Me.TypeComboBox.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.MasterDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 287)
        Me.Panel1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.SubHeadTextBox)
        Me.Panel2.Controls.Add(Me.TypeComboBox)
        Me.Panel2.Controls.Add(SubHeadLabel)
        Me.Panel2.Controls.Add(TypeLabel)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(426, 76)
        Me.Panel2.TabIndex = 30
        '
        'FrmSubHeads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(446, 442)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MasterBindingNavigator)
        Me.Name = "FrmSubHeads"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sub Heads"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasterBindingNavigator.ResumeLayout(False)
        Me.MasterBindingNavigator.PerformLayout()
        CType(Me.MasterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterTableAdapter As ISPASystem.ISPASDataSetTableAdapters.MasterTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MasterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MasterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubHeadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
