<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptChartOfAccountReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptChartOfAccountReport))
        Me.AD_ProductsDataGridView = New System.Windows.Forms.DataGridView
        Me.AccountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountHeadTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountHeadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OpeningBalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reports = New ISPASystem.Reports
        Me.AccountChartTableAdapter = New ISPASystem.ReportsTableAdapters.AccountChartTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ShowToolStripButton = New System.Windows.Forms.ToolStripButton
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AD_ProductsDataGridView
        '
        Me.AD_ProductsDataGridView.AllowUserToAddRows = False
        Me.AD_ProductsDataGridView.AllowUserToDeleteRows = False
        Me.AD_ProductsDataGridView.AllowUserToOrderColumns = True
        Me.AD_ProductsDataGridView.AllowUserToResizeColumns = False
        Me.AD_ProductsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AD_ProductsDataGridView.AutoGenerateColumns = False
        Me.AD_ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AD_ProductsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.AD_ProductsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AD_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AD_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountIDDataGridViewTextBoxColumn, Me.AccountHeadTitleDataGridViewTextBoxColumn, Me.AccountHeadDataGridViewTextBoxColumn, Me.AccountTypeDataGridViewTextBoxColumn, Me.OpeningBalDataGridViewTextBoxColumn})
        Me.AD_ProductsDataGridView.DataSource = Me.AccountChartBindingSource
        Me.AD_ProductsDataGridView.GridColor = System.Drawing.SystemColors.Control
        Me.AD_ProductsDataGridView.Location = New System.Drawing.Point(6, 68)
        Me.AD_ProductsDataGridView.Name = "AD_ProductsDataGridView"
        Me.AD_ProductsDataGridView.ReadOnly = True
        Me.AD_ProductsDataGridView.RowHeadersVisible = False
        Me.AD_ProductsDataGridView.RowHeadersWidth = 20
        Me.AD_ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AD_ProductsDataGridView.ShowCellErrors = False
        Me.AD_ProductsDataGridView.ShowCellToolTips = False
        Me.AD_ProductsDataGridView.ShowEditingIcon = False
        Me.AD_ProductsDataGridView.ShowRowErrors = False
        Me.AD_ProductsDataGridView.Size = New System.Drawing.Size(778, 486)
        Me.AD_ProductsDataGridView.TabIndex = 5
        '
        'AccountIDDataGridViewTextBoxColumn
        '
        Me.AccountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID"
        Me.AccountIDDataGridViewTextBoxColumn.HeaderText = "Account ID"
        Me.AccountIDDataGridViewTextBoxColumn.Name = "AccountIDDataGridViewTextBoxColumn"
        Me.AccountIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountHeadTitleDataGridViewTextBoxColumn
        '
        Me.AccountHeadTitleDataGridViewTextBoxColumn.DataPropertyName = "AccountHeadTitle"
        Me.AccountHeadTitleDataGridViewTextBoxColumn.HeaderText = "Account Name"
        Me.AccountHeadTitleDataGridViewTextBoxColumn.Name = "AccountHeadTitleDataGridViewTextBoxColumn"
        Me.AccountHeadTitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountHeadTitleDataGridViewTextBoxColumn.Width = 150
        '
        'AccountHeadDataGridViewTextBoxColumn
        '
        Me.AccountHeadDataGridViewTextBoxColumn.DataPropertyName = "AccountHead"
        Me.AccountHeadDataGridViewTextBoxColumn.HeaderText = "Account Head"
        Me.AccountHeadDataGridViewTextBoxColumn.Name = "AccountHeadDataGridViewTextBoxColumn"
        Me.AccountHeadDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountHeadDataGridViewTextBoxColumn.Width = 150
        '
        'AccountTypeDataGridViewTextBoxColumn
        '
        Me.AccountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType"
        Me.AccountTypeDataGridViewTextBoxColumn.HeaderText = "Account Type"
        Me.AccountTypeDataGridViewTextBoxColumn.Name = "AccountTypeDataGridViewTextBoxColumn"
        Me.AccountTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountTypeDataGridViewTextBoxColumn.Width = 150
        '
        'OpeningBalDataGridViewTextBoxColumn
        '
        Me.OpeningBalDataGridViewTextBoxColumn.DataPropertyName = "OpeningBal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.OpeningBalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.OpeningBalDataGridViewTextBoxColumn.HeaderText = "Opening Balance"
        Me.OpeningBalDataGridViewTextBoxColumn.Name = "OpeningBalDataGridViewTextBoxColumn"
        Me.OpeningBalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountChartBindingSource
        '
        Me.AccountChartBindingSource.DataMember = "AccountChart"
        Me.AccountChartBindingSource.DataSource = Me.Reports
        '
        'Reports
        '
        Me.Reports.DataSetName = "Reports"
        Me.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountChartTableAdapter
        '
        Me.AccountChartTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(792, 33)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Accounts Chart"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ShowToolStripButton
        '
        Me.ShowToolStripButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToolStripButton.Image = CType(resources.GetObject("ShowToolStripButton.Image"), System.Drawing.Image)
        Me.ShowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowToolStripButton.Name = "ShowToolStripButton"
        Me.ShowToolStripButton.Size = New System.Drawing.Size(57, 22)
        Me.ShowToolStripButton.Text = "Show"
        '
        'rptChartOfAccountReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.AD_ProductsDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "rptChartOfAccountReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chart Of Accounts Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AD_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AD_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Reports As ISPASystem.Reports
    Friend WithEvents AccountChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountChartTableAdapter As ISPASystem.ReportsTableAdapters.AccountChartTableAdapter
    Friend WithEvents AccountIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountHeadTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountHeadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpeningBalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ShowToolStripButton As System.Windows.Forms.ToolStripButton
End Class
