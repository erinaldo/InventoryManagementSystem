Public Class frmQuatation
    Dim NewRecord As Boolean = False
    Dim NewID As Integer = 1
#Region "Loading"
    Private Sub frmQuatation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
        Me.AD_CustomersTableAdapter.Fill(Me.ISPASDataSet.AD_Customers)
        Me.Quatation_MTableAdapter.Fill(Me.ISPASDataSet.Quatation_M)
        Me.Quatation_DTableAdapter.Fill(Me.ISPASDataSet.Quatation_D)
    End Sub
#End Region
#Region "Binding Navigator"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If Convert.ToInt32(BindingNavigatorCountItem.Text) <= 0 Then
            NewID = 1
        Else
            Quatation_MBindingSource.MoveLast()
            Dim MRow As ISPASDataSet.Quatation_MRow
            MRow = CType(CType(Me.Quatation_MBindingSource.Current, DataRowView).Row, ISPASDataSet.Quatation_MRow)
            NewID = MRow.QuatationID + 1
        End If


        DataGridView1.Visible = True
        DataGridView1.Rows.Clear()
        NewRecord = True

    End Sub
    Private Sub Quatation_MBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quatation_MBindingNavigatorSaveItem.Click
        Me.Validate()

        If NewRecord = True Then
            QuatationIDTextBox.Text = NewID
            If DiscountTextBox.Text = "" Then DiscountTextBox.Text = 0
            Dim x As Integer = 0
            For x = 0 To DataGridView1.Rows.Count - 1
                Me.Quatation_DBindingSource.AddNew()
                Dim row As ISPASDataSet.Quatation_DRow
                row = CType(CType(Me.Quatation_DBindingSource.Current, DataRowView).Row, ISPASDataSet.Quatation_DRow)

                row.QuatationID = NewID
                row.ProdTitle = DataGridView1.Rows(x).Cells(0).Value
                row.Quantity = DataGridView1.Rows(x).Cells(1).Value
                row.UnitPrice = DataGridView1.Rows(x).Cells(2).Value
                row.TotalCost = DataGridView1.Rows(x).Cells(3).Value
                Quatation_DBindingSource.EndEdit()
            Next

            NewRecord = False
            DataGridView1.Rows.Clear()
            DataGridView1.Visible = False

        End If

        Quatation_DBindingSource.EndEdit()
        Me.Quatation_MBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("Update Sucessfull")
        Print()
    End Sub
    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Print()
    End Sub
#End Region
#Region "DETAIL"
#Region "Retrive Customer Information"
    Private Sub CustTitleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.TextChanged
        AD_CustomersBindingSource.Filter = "(CustTitle) LIKE '" + CustTitleTextBox.Text + "' + '*'"
    End Sub
    Private Sub CustTitleTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.Leave
        AD_CustomersDataGridView.Visible = False
    End Sub
    Private Sub CustTitleTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustTitleTextBox.Enter
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
#End Region
#Region "Retrive Product Information"

    Private Sub ProductTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductTextBox.Enter
        AD_ProductsDataGridView.Visible = True
    End Sub
    Private Sub ProductTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProductTextBox.KeyDown
        If e.KeyCode = Keys.Down Then AD_ProductsBindingSource.MoveNext()
        If e.KeyCode = Keys.Up Then AD_ProductsBindingSource.MovePrevious()
        'If AD_ProductsDataGridView.CurrentRow.Index <= 0 Or AD_ProductsDataGridView.CurrentRow.Index >= AD_ProductsDataGridView.Rows.Count - 1 Then e.Handled = True
        If e.KeyCode = Keys.Enter Then
            ProductTextBox.Text = AD_ProductsDataGridView.CurrentRow.Cells(0).Value
            UnitPriceTextBox.Text = AD_ProductsDataGridView.CurrentRow.Cells(1).Value
            AD_ProductsDataGridView.Visible = False
            QuantityTextBox.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            AD_ProductsDataGridView.Visible = False
            DataGridView1.Focus()
        End If

    End Sub
    Private Sub ProductTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductTextBox.Leave
        AD_ProductsDataGridView.Visible = False
    End Sub
    Private Sub ProductTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductTextBox.TextChanged
        AD_ProductsBindingSource.Filter = "ProdTitle LIKE '" + ProductTextBox.Text + "' + '%' "
    End Sub

#End Region

    'Calculate Total Cost
    Private Sub QuantityTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QuantityTextBox.KeyDown
        If QuantityTextBox.Text <> "" Then
            If IsNumeric(QuantityTextBox.Text) Then
                TotalCostTextBox.Text = QuantityTextBox.Text * UnitPriceTextBox.Text
                If e.KeyCode = Keys.Enter Then
                    TotalCostTextBox.Focus()
                End If
            Else
                e.Handled = True
                TotalCostTextBox.Clear()
                QuantityTextBox.Clear()
            End If
        Else
            TotalCostTextBox.Clear()
        End If

    End Sub

    ' ADD Into the DatagridView1
    Private Sub TotalCostTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TotalCostTextBox.KeyDown

        If TotalCostTextBox.Text <> "" Then
            If IsNumeric(TotalCostTextBox.Text) Then
                If e.KeyCode = Keys.Enter Then
                    Dim x As Integer = DataGridView1.RowCount()

                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(x).Cells(0).Value = ProductTextBox.Text
                    DataGridView1.Rows(x).Cells(1).Value = QuantityTextBox.Text
                    DataGridView1.Rows(x).Cells(2).Value = UnitPriceTextBox.Text
                    DataGridView1.Rows(x).Cells(3).Value = TotalCostTextBox.Text

                    If OriginalAmountTextBox.Text = "" Then OriginalAmountTextBox.Text = 0

                    OriginalAmountTextBox.Text = Convert.ToDecimal(OriginalAmountTextBox.Text) + Convert.ToDecimal(TotalCostTextBox.Text)
                    TotalAmountTextBox.Text = OriginalAmountTextBox.Text

                    ProductTextBox.Clear()
                    QuantityTextBox.Clear()
                    UnitPriceTextBox.Clear()
                    TotalCostTextBox.Clear()

                    ProductTextBox.Focus()
                End If
            Else
                e.Handled = True
                TotalCostTextBox.Text = QuantityTextBox.Text * UnitPriceTextBox.Text
            End If
        Else
            TotalCostTextBox.Text = QuantityTextBox.Text * UnitPriceTextBox.Text
        End If





    End Sub
    ' DELETE from DatagridView1
    Private Sub DataGridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
            If DataGridView1.RowCount > 0 Then
                OriginalAmountTextBox.Text = Convert.ToDecimal(OriginalAmountTextBox.Text) - Convert.ToDecimal(DataGridView1.CurrentRow.Cells(3).Value)
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If
        End If
        If e.KeyCode = Keys.Escape Then ProductTextBox.Focus()
    End Sub
    ' Changes totalAMOUNT
    Private Sub OriginalAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginalAmountTextBox.TextChanged
        TotalAmountTextBox.Text = OriginalAmountTextBox.Text
    End Sub
    ' Changes totalAMOUNT     ' Calculate Discount in Percentage
    Private Sub DiscountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountTextBox.TextChanged
        If OriginalAmountTextBox.Text = "" Then
            OriginalAmountTextBox.Text = 0
            OriginalAmountTextBox.SelectAll()
        End If
        If DiscountTextBox.Text = "" Then
            DiscountTextBox.Text = 0
            DiscountTextBox.SelectAll()
        End If

        DiscountAmountTextBox.Text = Convert.ToDouble(OriginalAmountTextBox.Text) _
                                        * (Convert.ToDouble(DiscountTextBox.Text) / 100)

        TotalAmountTextBox.Text = Convert.ToDouble(OriginalAmountTextBox.Text) _
                                            - Convert.ToDouble(DiscountAmountTextBox.Text)
    End Sub
    ' Calculate Discount In Amount
    Private Sub DiscountAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountAmountTextBox.TextChanged
        If OriginalAmountTextBox.Text = "" Then
            OriginalAmountTextBox.Text = 0
            OriginalAmountTextBox.SelectAll()
        End If
        If DiscountAmountTextBox.Text = "" Then
            DiscountAmountTextBox.Text = 0
            DiscountAmountTextBox.SelectAll()
        End If
        TotalAmountTextBox.Text = Convert.ToDouble(OriginalAmountTextBox.Text) _
                                        - Convert.ToDouble(DiscountAmountTextBox.Text)
    End Sub
    'Format the Currency
    Private Sub TotalAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalAmountTextBox.TextChanged
        Label1.Text = "Rs." + TotalAmountTextBox.Text
    End Sub

#End Region
#Region "Print"
    Private Sub Print()
        Try
            Dim rpt As rptQuatation = New rptQuatation
            Dim frm As frmReport = New frmReport
            frm.MdiParent = Me.MdiParent
            frm.Show()
            frm.CrystalReportViewer1.SelectionFormula = "{Quatation_M.QuatationID} = " + QuatationIDTextBox.Text.Trim
            frm.CrystalReportViewer1.Refresh()
            frm.CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ToSalesInvoiceToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToSalesInvoiceToolStripButton.Click
        SalesInvoice.FromQuotationToolStripTextBox.Text = QuatationIDTextBox.Text
        frmShow(SalesInvoice)
        Call SalesInvoice.FromQuotationToolStripButton_Click(sender, e)
        MsgBox("Please save data editing Data")
    End Sub
End Class