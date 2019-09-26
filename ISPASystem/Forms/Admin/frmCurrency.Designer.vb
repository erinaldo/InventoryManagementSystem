<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCurrency
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
        Dim CurrencyNameLabel As System.Windows.Forms.Label
        Dim RateLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCurrency))
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.CurrencyRateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyRateTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.CurrencyRateTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.RateTextBox = New System.Windows.Forms.TextBox
        Me.CurrencyRateDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrencyNameTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SearchLabel = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CurrencyRateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CurrencyRateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        CurrencyNameLabel = New System.Windows.Forms.Label
        RateLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyRateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyRateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CurrencyRateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CurrencyRateBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CurrencyNameLabel
        '
        CurrencyNameLabel.AutoSize = True
        CurrencyNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CurrencyNameLabel.Location = New System.Drawing.Point(12, 24)
        CurrencyNameLabel.Name = "CurrencyNameLabel"
        CurrencyNameLabel.Size = New System.Drawing.Size(97, 13)
        CurrencyNameLabel.TabIndex = 1
        CurrencyNameLabel.Text = "Currency Name:"
        '
        'RateLabel
        '
        RateLabel.AutoSize = True
        RateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RateLabel.Location = New System.Drawing.Point(12, 51)
        RateLabel.Name = "RateLabel"
        RateLabel.Size = New System.Drawing.Size(38, 13)
        RateLabel.TabIndex = 3
        RateLabel.Text = "Rate:"
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CurrencyRateBindingSource
        '
        Me.CurrencyRateBindingSource.DataMember = "CurrencyRate"
        Me.CurrencyRateBindingSource.DataSource = Me.ISPASDataSet
        '
        'CurrencyRateTableAdapter
        '
        Me.CurrencyRateTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CurrencyRateTableAdapter = Me.CurrencyRateTableAdapter
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
        'RateTextBox
        '
        Me.RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrencyRateBindingSource, "Rate", True))
        Me.RateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RateTextBox.Location = New System.Drawing.Point(115, 48)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.Size = New System.Drawing.Size(116, 20)
        Me.RateTextBox.TabIndex = 4
        '
        'CurrencyRateDataGridView
        '
        Me.CurrencyRateDataGridView.AllowUserToAddRows = False
        Me.CurrencyRateDataGridView.AllowUserToDeleteRows = False
        Me.CurrencyRateDataGridView.AllowUserToResizeRows = False
        Me.CurrencyRateDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrencyRateDataGridView.AutoGenerateColumns = False
        Me.CurrencyRateDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CurrencyRateDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CurrencyRateDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CurrencyRateDataGridView.ColumnHeadersHeight = 25
        Me.CurrencyRateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.CurrencyRateDataGridView.DataSource = Me.CurrencyRateBindingSource
        Me.CurrencyRateDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CurrencyRateDataGridView.Location = New System.Drawing.Point(7, 62)
        Me.CurrencyRateDataGridView.MultiSelect = False
        Me.CurrencyRateDataGridView.Name = "CurrencyRateDataGridView"
        Me.CurrencyRateDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CurrencyRateDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CurrencyRateDataGridView.RowHeadersWidth = 40
        Me.CurrencyRateDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.CurrencyRateDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.CurrencyRateDataGridView.RowTemplate.Height = 25
        Me.CurrencyRateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CurrencyRateDataGridView.Size = New System.Drawing.Size(423, 248)
        Me.CurrencyRateDataGridView.StandardTab = True
        Me.CurrencyRateDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CurrencyName"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Sr"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Rate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CurrencyNameTextBox
        '
        Me.CurrencyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrencyRateBindingSource, "CurrencyName", True))
        Me.CurrencyNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrencyNameTextBox.Location = New System.Drawing.Point(115, 21)
        Me.CurrencyNameTextBox.Name = "CurrencyNameTextBox"
        Me.CurrencyNameTextBox.Size = New System.Drawing.Size(301, 20)
        Me.CurrencyNameTextBox.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(CurrencyNameLabel)
        Me.Panel1.Controls.Add(Me.CurrencyNameTextBox)
        Me.Panel1.Controls.Add(RateLabel)
        Me.Panel1.Controls.Add(Me.RateTextBox)
        Me.Panel1.Location = New System.Drawing.Point(7, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 82)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.SearchLabel)
        Me.Panel2.Controls.Add(Me.SearchTextBox)
        Me.Panel2.Controls.Add(Me.CurrencyRateDataGridView)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(437, 408)
        Me.Panel2.TabIndex = 8
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(8, 39)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(41, 13)
        Me.SearchLabel.TabIndex = 17
        Me.SearchLabel.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(55, 36)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(375, 20)
        Me.SearchTextBox.TabIndex = 16
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
        Me.Label1.Size = New System.Drawing.Size(434, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Currency Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrencyRateBindingNavigator
        '
        Me.CurrencyRateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CurrencyRateBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.CurrencyRateBindingNavigator.BindingSource = Me.CurrencyRateBindingSource
        Me.CurrencyRateBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CurrencyRateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CurrencyRateBindingNavigator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrencyRateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CurrencyRateBindingNavigatorSaveItem})
        Me.CurrencyRateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CurrencyRateBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CurrencyRateBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CurrencyRateBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CurrencyRateBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CurrencyRateBindingNavigator.Name = "CurrencyRateBindingNavigator"
        Me.CurrencyRateBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CurrencyRateBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.CurrencyRateBindingNavigator.Size = New System.Drawing.Size(445, 25)
        Me.CurrencyRateBindingNavigator.TabIndex = 9
        Me.CurrencyRateBindingNavigator.Text = "CurrencyRateBindingNavigator"
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
        'CurrencyRateBindingNavigatorSaveItem
        '
        Me.CurrencyRateBindingNavigatorSaveItem.Image = CType(resources.GetObject("CurrencyRateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CurrencyRateBindingNavigatorSaveItem.Name = "CurrencyRateBindingNavigatorSaveItem"
        Me.CurrencyRateBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 20)
        Me.CurrencyRateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FrmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(445, 439)
        Me.Controls.Add(Me.CurrencyRateBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmCurrency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Currency"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyRateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyRateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CurrencyRateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CurrencyRateBindingNavigator.ResumeLayout(False)
        Me.CurrencyRateBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents CurrencyRateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrencyRateTableAdapter As ISPASystem.ISPASDataSetTableAdapters.CurrencyRateTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrencyRateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CurrencyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurrencyRateBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CurrencyRateBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchLabel As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
End Class
