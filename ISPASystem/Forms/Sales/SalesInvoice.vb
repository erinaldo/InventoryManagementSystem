Public Class SalesInvoice
    Dim NewRecord As Boolean = False
    Dim NewID As Integer = 1
    Dim CustID As Integer
#Region "Print"
    Private Sub Print()
        Try
            Dim rpt As rptSaleInvoice = New rptSaleInvoice
            Dim frm As frmReport = New frmReport
            frm.MdiParent = Me.MdiParent
            frm.Show()
            frm.CrystalReportViewer1.SelectionFormula = "{SaleInvoice_M.SInvNo} = " + SInvNoTextBox.Text.Trim
            frm.CrystalReportViewer1.Refresh()
            frm.CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Loading"
    Private Sub SalesInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.Cr_VoucherTableAdapter.Fill(Me.ISPASDataSet.Cr_Voucher)
        Me.LedgerTableAdapter.Fill(Me.ISPASDataSet.Ledger)
        Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
        Me.AD_CustomersTableAdapter.Fill(Me.ISPASDataSet.AD_Customers)
        Me.SaleInvoice_MTableAdapter.Fill(Me.ISPASDataSet.SaleInvoice_M)
        Me.SaleInvoice_DTableAdapter.Fill(Me.ISPASDataSet.SaleInvoice_D)
    End Sub
#End Region
#Region "Binding Navigator"
    Private Sub SaleInvoice_MBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoice_MBindingNavigatorSaveItem.Click
        Me.Validate()
        If NewRecord = True Then
            SInvNoTextBox.Text = NewID

            Dim x As Integer = 0
            For x = 0 To DataGridView1.Rows.Count - 1
                Me.SaleInvoice_DBindingSource.AddNew()
                Dim row As ISPASDataSet.SaleInvoice_DRow
                row = CType(CType(Me.SaleInvoice_DBindingSource.Current, DataRowView).Row, ISPASDataSet.SaleInvoice_DRow)
                row.SInvNo = SInvNoTextBox.Text
                row.ProdTitle = DataGridView1.Rows(x).Cells(0).Value
                row.Quantity = DataGridView1.Rows(x).Cells(1).Value
                row.UnitPrice = DataGridView1.Rows(x).Cells(2).Value
                row.TotalCost = DataGridView1.Rows(x).Cells(3).Value
                SaleInvoice_DBindingSource.EndEdit()
            Next

            NewRecord = False
            DataGridView1.Rows.Clear()
            DataGridView1.Visible = False

            If DiscountAmountTextBox.Text = "" Then DiscountAmountTextBox.Text = 0

            Me.LedgerTableAdapter.Insert(SIDateDateTimePicker.Value.Date, "212", "Revenue", "Sales", "Sales Discounts", "Discount on Items Sold", Convert.ToInt32(DiscountAmountTextBox.Text), 0)

            Dim row1 As ISPASDataSet.AD_CustomersRow
            row1 = CType(CType(Me.AD_CustomersBindingSource.Current, DataRowView).Row, ISPASDataSet.AD_CustomersRow)

            If Payment_TypeComboBox.SelectedItem = "Cash" Then
                Me.Cr_VoucherTableAdapter.Insert(SIDateDateTimePicker.Value.Date, SInvNoTextBox.Text, "Assets", _
                                            CustNameTextBox.Text, "Account Receivable", "Items Sold To " + CustNameTextBox.Text, _
                                            "Cash", Convert.ToDouble(TotalAmountTextBox.Text), "", "", "")

                row1.Debit = row1.Debit + Convert.ToInt32(TotalAmountTextBox.Text)
                Me.AD_CustomersBindingSource.EndEdit()

                Me.LedgerTableAdapter.Insert(SIDateDateTimePicker.Value.Date, CustID, "Assets", CustNameTextBox.Text, "Account Receivable", "Items Sold to " + CustNameTextBox.Text + " on Cash", Convert.ToInt32(TotalAmountTextBox.Text), 0)
                Me.LedgerTableAdapter.Insert(SIDateDateTimePicker.Value.Date, "555", "Revenue", "Sales", "Sales", "Items Sold on Cash", Convert.ToInt32(TotalAmountTextBox.Text), 0)

            ElseIf Payment_TypeComboBox.SelectedItem = "Credit" Then
                row1.Credit = row1.Credit + Convert.ToInt32(TotalAmountTextBox.Text)
                Me.AD_CustomersBindingSource.EndEdit()

                Me.LedgerTableAdapter.Insert(SIDateDateTimePicker.Value.Date, CustID, "Assets", CustNameTextBox.Text, "Account Receivable", "Items Sold to " + CustNameTextBox.Text + " on Credit", 0, Convert.ToInt32(TotalAmountTextBox.Text))
                Me.LedgerTableAdapter.Insert(SIDateDateTimePicker.Value.Date, "555", "Revenue", "Sales", "Sales", "Items Sold on Credit", 0, Convert.ToInt32(TotalAmountTextBox.Text))
            End If
        End If
        SaleInvoice_DBindingSource.EndEdit()
        Me.SaleInvoice_MBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("Update Sucessfull")
        Print()
    End Sub

    Private Sub SaleInvoice_MBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles SaleInvoice_MBindingSource.AddingNew
        If SaleInvoice_MBindingSource.Count > 0 Then
            SaleInvoice_MBindingSource.MoveLast()
            Dim MRow As ISPASDataSet.SaleInvoice_MRow
            MRow = CType(CType(Me.SaleInvoice_MBindingSource.Current, DataRowView).Row, ISPASDataSet.SaleInvoice_MRow)
            NewID = MRow.SInvNo + 1
        Else
            NewID = 1
        End If


        DataGridView1.Visible = True
        DataGridView1.Rows.Clear()
        NewRecord = True

    End Sub
    'Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
    '    If SaleInvoice_MBindingSource.Count > 0 Then
    '        SaleInvoice_MBindingSource.MoveLast()
    '        Dim MRow As ISPASDataSet.SaleInvoice_MRow
    '        MRow = CType(CType(Me.SaleInvoice_MBindingSource.Current, DataRowView).Row, ISPASDataSet.SaleInvoice_MRow)
    '        NewID = MRow.SInvNo + 1
    '    Else
    '        NewID = 1
    '    End If


    '    DataGridView1.Visible = True
    '    DataGridView1.Rows.Clear()
    '    NewRecord = True

    'End Sub
    Private Sub PrintToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton1.Click
        Print()
    End Sub
#End Region
#Region "DETAIL"
#Region "Retrive Customer Information"
    Private Sub CustNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameTextBox.TextChanged
        AD_CustomersBindingSource.Filter = "(CustTitle) LIKE '" + CustNameTextBox.Text + "' + '*'"
    End Sub
    Private Sub CustNameTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameTextBox.Leave
        AD_CustomersDataGridView.Visible = False
    End Sub
    Private Sub CustNameTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameTextBox.Enter
        AD_CustomersDataGridView.Visible = True
    End Sub
    Private Sub CustNameTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustNameTextBox.KeyDown
        If e.KeyCode = Keys.Down Then AD_CustomersBindingSource.MoveNext()
        If e.KeyCode = Keys.Up Then AD_CustomersBindingSource.MovePrevious()
        If AD_CustomersDataGridView.CurrentRow.Index <= 0 Or AD_CustomersDataGridView.CurrentRow.Index >= AD_CustomersDataGridView.Rows.Count - 1 Then e.Handled = True
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            CustNameTextBox.Text = AD_CustomersDataGridView.CurrentRow.Cells(0).Value
            CustID = AD_CustomersDataGridView.CurrentRow.Cells(4).Value
            AD_CustomersDataGridView.Visible = False
            Payment_TypeComboBox.Focus()
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

                    If OriginalSaleTextBox.Text = "" Then OriginalSaleTextBox.Text = 0

                    OriginalSaleTextBox.Text = Convert.ToDecimal(OriginalSaleTextBox.Text) + Convert.ToDecimal(TotalCostTextBox.Text)
                    TotalAmountTextBox.Text = OriginalSaleTextBox.Text

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
            OriginalSaleTextBox.Text = Convert.ToDecimal(OriginalSaleTextBox.Text) - Convert.ToDecimal(DataGridView1.CurrentRow.Cells(3).Value)
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        End If
        If e.KeyCode = Keys.Escape Then ProductTextBox.Focus()
    End Sub
    ' Changes totalAMOUNT
    Private Sub OriginalSaleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginalSaleTextBox.TextChanged
        TotalAmountTextBox.Text = OriginalSaleTextBox.Text
    End Sub
    ' Changes totalAMOUNT     ' Calculate Discount in Percentage
    Private Sub DiscountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountTextBox.TextChanged
        If OriginalSaleTextBox.Text = "" Then
            OriginalSaleTextBox.Text = 0
            OriginalSaleTextBox.SelectAll()
        End If
        If DiscountTextBox.Text = "" Then
            DiscountTextBox.Text = 0
            DiscountTextBox.SelectAll()
        End If

        DiscountAmountTextBox.Text = Convert.ToDouble(OriginalSaleTextBox.Text) _
                                        * (Convert.ToDouble(DiscountTextBox.Text) / 100)

        TotalAmountTextBox.Text = Convert.ToDouble(OriginalSaleTextBox.Text) _
                                            - Convert.ToDouble(DiscountAmountTextBox.Text)
    End Sub
    ' Calculate Discount In Amount
    Private Sub DiscountAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountAmountTextBox.TextChanged
        If OriginalSaleTextBox.Text = "" Then
            OriginalSaleTextBox.Text = 0
            OriginalSaleTextBox.SelectAll()
        End If
        If DiscountAmountTextBox.Text = "" Then
            DiscountAmountTextBox.Text = 0
            DiscountAmountTextBox.SelectAll()
        End If
        TotalAmountTextBox.Text = Convert.ToDouble(OriginalSaleTextBox.Text) _
                                        - Convert.ToDouble(DiscountAmountTextBox.Text)
    End Sub
    'Format the Currency
    Private Sub TotalAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalAmountTextBox.TextChanged
        Label1.Text = "Rs." + TotalAmountTextBox.Text
    End Sub
#End Region

    Protected Friend Sub FromQuotationToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromQuotationToolStripButton.Click

        If FromQuotationToolStripTextBox.Text <> "" Then
            Me.SaleInvoice_MBindingSource.AddNew()

            Me.Quatation_MTableAdapter.Fill(ISPASDataSet.Quatation_M)
            Quatation_MBindingSource.Filter = "QuatationID = '" + FromQuotationToolStripTextBox.Text.Trim + "'"

            Dim row As ISPASDataSet.Quatation_MRow
            row = CType(CType(Me.Quatation_MBindingSource.Current, DataRowView).Row, ISPASDataSet.Quatation_MRow)

            If row.IsCustTitleNull = False Then CustNameTextBox.Text = row.CustTitle
            If row.IsPaymentTypeNull = False Then Payment_TypeComboBox.SelectedItem = row.PaymentType
            If row.IsOriginalAmountNull = False Then OriginalSaleTextBox.Text = row.OriginalAmount
            If row.IsDiscountNull = False Then DiscountTextBox.Text = row.Discount
            If row.IsDiscountAmountNull = False Then DiscountAmountTextBox.Text = row.DiscountAmount
            If row.IsTotalAmountNull = False Then TotalAmountTextBox.Text = row.TotalAmount

            Me.Quatation_DTableAdapter.Fill(ISPASDataSet.Quatation_D)
            Quatation_DBindingSource.MoveFirst()

            For x = 0 To Quatation_DBindingSource.Count - 1
                Dim row1 As ISPASDataSet.Quatation_DRow
                row1 = CType(CType(Me.Quatation_DBindingSource.Current, DataRowView).Row, ISPASDataSet.Quatation_DRow)

                DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = row1.ProdTitle
                DataGridView1.Rows(x).Cells(1).Value = row1.Quantity
                DataGridView1.Rows(x).Cells(2).Value = row1.UnitPrice
                DataGridView1.Rows(x).Cells(3).Value = row1.TotalCost
                Quatation_DBindingSource.MoveNext()

            Next











        End If
    End Sub

   
    Private Sub FromQuotationToolStripTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromQuotationToolStripTextBox.Enter
        SaleInvoice_MBindingSource.CancelEdit()
    End Sub
End Class