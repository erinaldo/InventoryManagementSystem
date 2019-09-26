Public Class frmWorkOrder
    Dim newrecord As Boolean = False
    Dim newId As Integer
#Region "Loading Events Occur On Form Loading"
    Private Sub frmWorkOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
        Me.AD_CustomersTableAdapter.Fill(Me.ISPASDataSet.AD_Customers)
        Me.AD_EmpTableAdapter.Fill(Me.ISPASDataSet.AD_Emp)
        Me.WorkOrder_MTableAdapter.Fill(Me.ISPASDataSet.WorkOrder_M)
        Me.WorkOrder_DTableAdapter.Fill(Me.ISPASDataSet.WorkOrder_D)
    End Sub
#End Region
#Region "BindingNavigator Commands"
    Private Sub WorkOrder_MBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkOrder_MBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WorkOrder_MBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("Update Sucessfull")
        Print()
    End Sub
    Private Sub WorkOrder_MBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles WorkOrder_MBindingSource.AddingNew
        newrecord = True

        If WorkOrder_MBindingSource.Count > 0 Then
            WorkOrder_MBindingSource.MoveLast()
            Dim row As ISPASDataSet.WorkOrder_MRow
            row = CType(CType(Me.WorkOrder_MBindingSource.Current, DataRowView).Row, ISPASDataSet.WorkOrder_MRow)
            newId = row.WrkOdrID + 1
        Else
            newId = 1
        End If
    End Sub
    
    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Print()
    End Sub
#End Region
#Region "CustTitle Retriving Customer Information"
    Private Sub CustTitleTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.Enter
        AD_CustomersDataGridView.Visible = True
    End Sub
    Private Sub CustTitleTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustTitleTextBox.KeyDown
        If e.KeyCode = Keys.Down Then AD_CustomersBindingSource.MoveNext()
        If e.KeyCode = Keys.Up Then AD_CustomersBindingSource.MovePrevious()
        If AD_CustomersDataGridView.CurrentRow.Index <= 0 Or AD_CustomersDataGridView.CurrentRow.Index >= AD_CustomersDataGridView.Rows.Count - 1 Then e.Handled = True
        If e.KeyCode = Keys.Enter Then
            CustTitleTextBox.Text = AD_CustomersDataGridView.CurrentRow.Cells(0).Value
            AD_CustomersDataGridView.Visible = False
            SheduledToTextBox.Focus()
        End If
        If e.KeyCode = Keys.Escape Then AD_CustomersDataGridView.Visible = False
    End Sub
    Private Sub CustTitleTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.Leave
        AD_CustomersDataGridView.Visible = False
    End Sub
    Private Sub CustTitleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.TextChanged
        AD_CustomersBindingSource.Filter = "CustTitle LIKE '" + CustTitleTextBox.Text + "' + '%' "
    End Sub
#End Region
#Region "SheduledTo Retriving Employee Information"
    Private Sub SheduledToTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SheduledToTextBox.Enter
        AD_EmpDataGridView.Visible = True
    End Sub
    Private Sub SheduledToTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SheduledToTextBox.KeyDown
        If e.KeyCode = Keys.Down Then AD_EmpBindingSource.MoveNext()
        If e.KeyCode = Keys.Up Then AD_EmpBindingSource.MovePrevious()
        If AD_EmpDataGridView.CurrentRow.Index <= 0 Or AD_EmpDataGridView.CurrentRow.Index >= AD_EmpDataGridView.Rows.Count - 1 Then e.Handled = True
        If e.KeyCode = Keys.Enter Then
            SheduledToTextBox.Text = AD_EmpDataGridView.CurrentRow.Cells(0).Value
            AD_EmpDataGridView.Visible = False
            RemarkTextBox.Focus()
        End If
        If e.KeyCode = Keys.Escape Then AD_EmpDataGridView.Visible = False

    End Sub
    Private Sub SheduledToTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SheduledToTextBox.Leave
        AD_EmpDataGridView.Visible = False
    End Sub
    Private Sub SheduledToTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SheduledToTextBox.TextChanged
        AD_EmpBindingSource.Filter = "EmpName LIKE '" + SheduledToTextBox.Text + "' + '%' "
    End Sub
#End Region
#Region "Retriving the Product Detail from Product Binding Source"
    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        AD_ProductsDataGridView.Visible = True
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Down Then AD_ProductsBindingSource.MoveNext()
        If e.KeyCode = Keys.Up Then AD_ProductsBindingSource.MovePrevious()
        If AD_ProductsDataGridView.CurrentRow.Index <= 0 Or AD_ProductsDataGridView.CurrentRow.Index >= AD_ProductsDataGridView.Rows.Count - 1 Then e.Handled = True
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
#End Region
#Region "Adding Input from Textbox to DetailsGRID on EnterKey"
    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            If newrecord = True Then
                WrkOdrIDTextBox.Text = newId
                WorkOrder_MBindingSource.EndEdit()

                newrecord = False
            End If
            WorkOrder_DBindingSource.EndEdit()
            WorkOrder_DBindingSource.AddNew()
            WorkOrder_DBindingSource.MoveLast()
            Dim row As ISPASDataSet.WorkOrder_DRow
            row = CType(CType(Me.WorkOrder_DBindingSource.Current, DataRowView).Row, ISPASDataSet.WorkOrder_DRow)
            row.WrkOrdID = newId 'WrkOdrIDTextBox.Text
            row.ProdTitle = TextBox1.Text
            row.Description = TextBox2.Text.Trim
            row.Qty = TextBox3.Text
            WorkOrder_DBindingSource.EndEdit()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox1.Focus()
        End If
    End Sub
#End Region
#Region "For Panel Dispaly"
    Private Sub WorkOrder_DDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles WorkOrder_DDataGridView.CellDoubleClick
        WorkOrder_DDataGridView.Enabled = False
        Panel1.Visible = True
        DescriptionTextBox.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WorkOrder_DDataGridView.Enabled = True
        WorkOrder_DBindingSource.EndEdit()
        Panel1.Visible = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WorkOrder_DDataGridView.Enabled = True
        WorkOrder_DBindingSource.CancelEdit()
        Panel1.Visible = False
    End Sub

#End Region
#Region "Printing"
    Private Sub Print()
        Try
            Dim rpt As rptWorkOrder = New rptWorkOrder
            Dim frm As frmReport = New frmReport
            frm.MdiParent = Me.MdiParent
            frm.Show()
            frm.CrystalReportViewer1.SelectionFormula = "{WorkOrder_M.WrkOdrID} = " + WrkOdrIDTextBox.Text.Trim
            frm.CrystalReportViewer1.Refresh()
            frm.CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub FromQuatationToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromQuatationToolStripButton.Click
        If FromQuatationToolStripTextBox.Text <> "" Then

            Me.WorkOrder_MBindingSource.AddNew()

            Me.Quatation_MTableAdapter.Fill(ISPASDataSet.Quatation_M)
            Quatation_MBindingSource.Filter = "QuatationID = '" + FromQuatationToolStripTextBox.Text.Trim + "'"

            Dim row2 As ISPASDataSet.Quatation_MRow
            row2 = CType(CType(Me.Quatation_MBindingSource.Current, DataRowView).Row, ISPASDataSet.Quatation_MRow)

            CustTitleTextBox.Text = row2.CustTitle

            Me.Quatation_DTableAdapter.Fill(ISPASDataSet.Quatation_D)
            Quatation_DBindingSource.MoveFirst()

            For x = 0 To Quatation_DBindingSource.Count - 1
                Dim row1 As ISPASDataSet.Quatation_DRow
                row1 = CType(CType(Me.Quatation_DBindingSource.Current, DataRowView).Row, ISPASDataSet.Quatation_DRow)

                If newrecord = True Then
                    WrkOdrIDTextBox.Text = newId
                    WorkOrder_MBindingSource.EndEdit()
                    newrecord = False
                End If
                WorkOrder_DBindingSource.AddNew()
                WorkOrder_DBindingSource.MoveLast()
                Dim row As ISPASDataSet.WorkOrder_DRow
                row = CType(CType(Me.WorkOrder_DBindingSource.Current, DataRowView).Row, ISPASDataSet.WorkOrder_DRow)
                row.WrkOrdID = newId 'WrkOdrIDTextBox.Text
                row.ProdTitle = row1.ProdTitle
                row.Description = ""
                row.Qty = row1.Quantity
                WorkOrder_DBindingSource.EndEdit()
                Quatation_DBindingSource.MoveNext()
            Next
        End If
    End Sub

   
    Private Sub FromQuatationToolStripTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromQuatationToolStripTextBox.Enter
        Me.WorkOrder_MBindingSource.CancelEdit()
    End Sub
End Class