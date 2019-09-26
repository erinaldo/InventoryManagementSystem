<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo
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
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemo))
        Me.ISPASDataSet = New ISPASystem.ISPASDataSet
        Me.PickListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PickListTableAdapter = New ISPASystem.ISPASDataSetTableAdapters.PickListTableAdapter
        Me.TableAdapterManager = New ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
        Me.PickListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PickListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PickListDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategoryTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        CategoryLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PickListBindingNavigator.SuspendLayout()
        CType(Me.PickListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(11, 278)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 4
        CategoryLabel.Text = "Category:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(11, 304)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'ISPASDataSet
        '
        Me.ISPASDataSet.DataSetName = "ISPASDataSet"
        Me.ISPASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PickListBindingSource
        '
        Me.PickListBindingSource.DataMember = "PickList"
        Me.PickListBindingSource.DataSource = Me.ISPASDataSet
        '
        'PickListTableAdapter
        '
        Me.PickListTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MasterTableAdapter = Nothing
        Me.TableAdapterManager.MenuSettingTableAdapter = Nothing
        Me.TableAdapterManager.NewAccountsTableAdapter = Nothing
        Me.TableAdapterManager.PickListTableAdapter = Me.PickListTableAdapter
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
        'PickListBindingNavigator
        '
        Me.PickListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PickListBindingNavigator.BindingSource = Me.PickListBindingSource
        Me.PickListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PickListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PickListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PickListBindingNavigatorSaveItem})
        Me.PickListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PickListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PickListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PickListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PickListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PickListBindingNavigator.Name = "PickListBindingNavigator"
        Me.PickListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PickListBindingNavigator.Size = New System.Drawing.Size(461, 25)
        Me.PickListBindingNavigator.TabIndex = 0
        Me.PickListBindingNavigator.Text = "BindingNavigator1"
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
        'PickListBindingNavigatorSaveItem
        '
        Me.PickListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PickListBindingNavigatorSaveItem.Image = CType(resources.GetObject("PickListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PickListBindingNavigatorSaveItem.Name = "PickListBindingNavigatorSaveItem"
        Me.PickListBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PickListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PickListDataGridView
        '
        Me.PickListDataGridView.AllowUserToAddRows = False
        Me.PickListDataGridView.AllowUserToDeleteRows = False
        Me.PickListDataGridView.AutoGenerateColumns = False
        Me.PickListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PickListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PickListDataGridView.DataSource = Me.PickListBindingSource
        Me.PickListDataGridView.Location = New System.Drawing.Point(12, 39)
        Me.PickListDataGridView.Name = "PickListDataGridView"
        Me.PickListDataGridView.ReadOnly = True
        Me.PickListDataGridView.Size = New System.Drawing.Size(437, 220)
        Me.PickListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickListBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(80, 275)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(232, 20)
        Me.CategoryTextBox.TabIndex = 5
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickListBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(80, 301)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(232, 20)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'frmDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 376)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PickListDataGridView)
        Me.Controls.Add(Me.PickListBindingNavigator)
        Me.Name = "frmDemo"
        Me.Text = "frmDemo"
        CType(Me.ISPASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PickListBindingNavigator.ResumeLayout(False)
        Me.PickListBindingNavigator.PerformLayout()
        CType(Me.PickListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISPASDataSet As ISPASystem.ISPASDataSet
    Friend WithEvents PickListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PickListTableAdapter As ISPASystem.ISPASDataSetTableAdapters.PickListTableAdapter
    Friend WithEvents TableAdapterManager As ISPASystem.ISPASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PickListBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PickListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PickListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
End Class
