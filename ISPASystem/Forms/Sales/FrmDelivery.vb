Public Class FrmDelivery
    Dim newrecord As Boolean = False
    Dim newMainID As Integer
#Region "Load"
    Private Sub FrmDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ISPASDataSet.AD_Products' table. You can move, or remove it, as needed.
        Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
        Me.AD_CustomersTableAdapter.Fill(Me.ISPASDataSet.AD_Customers)
        Me.DC_MainTableAdapter.Fill(Me.ISPASDataSet.DC_Main)
        Me.DC_DetailTableAdapter.Fill(Me.ISPASDataSet.DC_Detail)
    End Sub
#End Region
#Region "binding navigator"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        newrecord = True
        DataGridView1.Rows.Clear()
        DataGridView1.Visible = True
    End Sub
    Private Sub DC_MainBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DC_MainBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DC_MainBindingSource.EndEdit()
        If newrecord = True Then
            Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
            Me.DC_MainTableAdapter.Fill(Me.ISPASDataSet.DC_Main)
            DC_MainBindingSource.MoveLast()
            Dim MRow As ISPASDataSet.DC_MainRow
            MRow = CType(CType(Me.DC_MainBindingSource.Current, DataRowView).Row, ISPASDataSet.DC_MainRow)
            newMainID = MRow.DC_MainID
            Dim x As Integer
            For x = 0 To DataGridView1.Rows.Count - 1
                DC_DetailBindingSource.AddNew()
                DC_DetailBindingSource.MoveLast()
                Dim row As ISPASDataSet.DC_DetailRow
                row = CType(CType(Me.DC_DetailBindingSource.Current, DataRowView).Row, ISPASDataSet.DC_DetailRow)
                row.DC_MainID = newMainID
                row.ProdTitle = DataGridView1.Rows(x).Cells(0).Value
                row.Description = DataGridView1.Rows(x).Cells(1).Value
                row.Remark = DataGridView1.Rows(x).Cells(2).Value
                row.Qty = DataGridView1.Rows(x).Cells(3).Value
                DC_DetailBindingSource.EndEdit()
            Next
            DataGridView1.Visible = False
            newrecord = False
        Else
            DC_DetailBindingSource.EndEdit()
        End If

        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        Print()

    End Sub
    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Print()
    End Sub
#End Region
#Region "Details"
    Private Sub CustTitleTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.Enter
        AD_CustomersDataGridView.Visible = True
    End Sub
    Private Sub CustTitleTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustTitleTextBox.KeyDown
        If e.KeyCode = Keys.Down Then AD_CustomersBindingSource.MoveNext()
        If e.KeyCode = Keys.Up Then AD_CustomersBindingSource.MovePrevious()
        If AD_CustomersDataGridView.CurrentRow.Index <= 0 Or AD_CustomersDataGridView.CurrentRow.Index >= AD_CustomersDataGridView.Rows.Count - 1 Then e.Handled = True
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CustTitleTextBox.Text = AD_CustomersDataGridView.CurrentRow.Cells(0).Value
            AD_CustomersDataGridView.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then AD_CustomersDataGridView.Visible = False
    End Sub
    Private Sub CustTitleTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.Leave
        AD_CustomersDataGridView.Visible = False
    End Sub
    Private Sub CustTitleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.TextChanged
        AD_CustomersBindingSource.Filter = "CustTitle LIKE '" + CustTitleTextBox.Text + "' + '%' "
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        AD_ProductsDataGridView.Visible = True
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Down Then AD_ProductsBindingSource.MoveNext()
        If e.KeyCode = Keys.Up Then AD_ProductsBindingSource.MovePrevious()
        'If AD_ProductsDataGridView.CurrentRow.Index <= 0 Or AD_ProductsDataGridView.CurrentRow.Index >= AD_ProductsDataGridView.Rows.Count - 1 Then e.Handled = True
        If e.KeyCode = Keys.Enter Then
            TextBox1.Text = AD_ProductsDataGridView.CurrentRow.Cells(0).Value
            AD_ProductsDataGridView.Visible = False
            TextBox2.Focus()
        End If
        If e.KeyCode = Keys.Escape Then AD_ProductsDataGridView.Visible = False
    End Sub
    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        AD_ProductsDataGridView.Visible = False
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        AD_ProductsBindingSource.Filter = "ProdTitle LIKE '" + TextBox1.Text + "' + '%' "
    End Sub

    Private Sub DC_DetailDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DC_DetailDataGridView.CellDoubleClick
        DC_DetailDataGridView.Enabled = False
        Panel2.Visible = True
        DescriptionTextBox.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DC_DetailBindingSource.EndEdit()
        Panel2.Visible = False
        DC_DetailDataGridView.Enabled = True
        DC_DetailDataGridView.Focus()
    End Sub
    Private Sub TextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If newrecord = True Then
            '    DC_MainBindingSource.EndEdit()
            '    newrecord = False
            'End If
            Dim x As Integer = DataGridView1.RowCount()

            DataGridView1.Rows.Add()
            DataGridView1.Rows(x).Cells(0).Value = TextBox1.Text
            DataGridView1.Rows(x).Cells(1).Value = TextBox2.Text
            DataGridView1.Rows(x).Cells(2).Value = TextBox3.Text
            DataGridView1.Rows(x).Cells(3).Value = TextBox4.Text

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox1.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DC_DetailBindingSource.CancelEdit()
        Panel2.Visible = False
        DC_DetailDataGridView.Enabled = True
        DC_DetailDataGridView.Focus()
    End Sub
#End Region
#Region "Print"
    Private Sub Print()
        Try
            Dim rpt As rptDeliveryChallan = New rptDeliveryChallan
            Dim frm As frmReport = New frmReport
            frm.MdiParent = Me.MdiParent
            frm.Show()
            frm.CrystalReportViewer1.SelectionFormula = "{DC_Main.DC_MainID} = " + DC_MainIDTextBox.Text.Trim
            frm.CrystalReportViewer1.Refresh()
            frm.CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub FromWorkOrderToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromWorkOrderToolStripButton.Click
        If FromWorkOrderToolStripTextBox.Text <> "" Then

            Me.DC_MainBindingSource.AddNew()
            newrecord = True
            DataGridView1.Rows.Clear()
            DataGridView1.Visible = True

            Me.WorkOrder_MTableAdapter.Fill(ISPASDataSet.WorkOrder_M)
            WorkOrder_MBindingSource.Filter = "WrkOdrID = '" + FromWorkOrderToolStripTextBox.Text.Trim + "'"

            Dim row As ISPASDataSet.WorkOrder_MRow
            row = CType(CType(Me.WorkOrder_MBindingSource.Current, DataRowView).Row, ISPASDataSet.WorkOrder_MRow)

            CustTitleTextBox.Text = row.CustTitle
            RemarkTextBox.Text = row.Remark

            Me.WorkOrder_DTableAdapter.Fill(ISPASDataSet.WorkOrder_D)
            WorkOrder_DBindingSource.MoveFirst()

            For x = 0 To WorkOrder_DBindingSource.Count - 1
                Dim row1 As ISPASDataSet.WorkOrder_DRow
                row1 = CType(CType(Me.WorkOrder_DBindingSource.Current, DataRowView).Row, ISPASDataSet.WorkOrder_DRow)

                DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = row1.ProdTitle
                DataGridView1.Rows(x).Cells(1).Value = row1.Description
                DataGridView1.Rows(x).Cells(2).Value = ""
                DataGridView1.Rows(x).Cells(3).Value = row1.Qty
                WorkOrder_DBindingSource.MoveNext()

            Next

        End If
    End Sub

    Private Sub FromWorkOrderToolStripTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromWorkOrderToolStripTextBox.Enter
        Me.DC_MainBindingSource.CancelEdit()
    End Sub
End Class