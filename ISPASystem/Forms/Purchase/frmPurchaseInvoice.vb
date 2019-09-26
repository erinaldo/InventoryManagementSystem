Public Class frmPurchaseInvoice
    'Dim vendId As Integer
    Dim flag As Boolean = False

#Region "Loding"
    Private Sub PurchaseInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_VendorsTableAdapter.Fill(Me.ISPASDataSet.AD_Vendors)
        Me.CurrencyRateTableAdapter.Fill(Me.ISPASDataSet.CurrencyRate)
        Me.StoresTableAdapter.Fill(Me.ISPASDataSet.Stores)
        Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
        Me.PInvoice_MainTableAdapter.Fill(Me.ISPASDataSet.PInvoice_Main)
        Me.PInvoice_DetailsTableAdapter.Fill(Me.ISPASDataSet.PInvoice_Details)
        Me.LedgerTableAdapter.Fill(Me.ISPASDataSet.Ledger)
        Me.Cp_VoucherTableAdapter.Fill(Me.ISPASDataSet.Cp_Voucher)
    End Sub
#End Region
#Region "BindingNavigator"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        flag = True
        PInvoice_DetailsDataGridView.Visible = True
        PInvoice_DetailsDataGridView.Rows.Clear()
        'PInvoice_DetailsBindingSource.AddNew()
    End Sub
    Private Sub PInvoice_MainBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PInvoice_MainBindingNavigatorSaveItem.Click
        If flag = True Then
            If TotalAmount_RsTextBox.Text = "" Then
                TotalAmount_RsTextBox.Text = 0
            End If

            If DiscountTextBox.Text = "" Then
                DiscountTextBox.Text = 0
            End If

            If DutyExpTextBox.Text = "" Then
                DutyExpTextBox.Text = 0
            End If

            If NetInvoiceAmountTextBox.Text = "" Then
                NetInvoiceAmountTextBox.Text = TotalAmount_RsTextBox.Text
            End If

            Dim x As Integer
            Dim untp, pakp As Decimal

            PInvoice_DetailsBindingSource.MoveLast()

            With PInvoice_DetailsDataGridView
                For x = 0 To .Rows.Count - 1
                    Dim row As ISPASDataSet.PInvoice_DetailsRow
                    row = CType(CType(Me.PInvoice_DetailsBindingSource.Current, DataRowView).Row, ISPASDataSet.PInvoice_DetailsRow)
                    row.PInvNo = .Rows(x).Cells(1).Value
                    row.ProdTitle = .Rows(x).Cells(2).Value
                    row.Quantity = .Rows(x).Cells(3).Value
                    row.UnitPrice = .Rows(x).Cells(4).Value
                    row.Duty = .Rows(x).Cells(5).Value
                    row.TotalCost = .Rows(x).Cells(6).Value
                    row.OldPrice = .Rows(x).Cells(7).Value
                    Me.PInvoice_DetailsBindingSource.EndEdit()
                    PInvoice_DetailsBindingSource.MovePrevious()
                    untp = Convert.ToDecimal(.Rows(x).Cells(4).Value + .Rows(x).Cells(5).Value)
                    pakp = Convert.ToDecimal(.Rows(x).Cells(4).Value * CurrencyRateTextBox.Text)
                    AD_ProductsTableAdapter.UpdateStock(.Rows(x).Cells(3).Value, untp, pakp, .Rows(x).Cells(2).Value)
                Next
            End With


            Me.Validate()

            Dim row1 As ISPASDataSet.AD_VendorsRow
            row1 = CType(CType(Me.AD_VendorsBindingSource.Current, DataRowView).Row, ISPASDataSet.AD_VendorsRow)

            If Payment_TypeComboBox.SelectedItem = "Cash" Then

                Cp_VoucherTableAdapter.Insert(PInvDateDateTimePicker.Value, PInvNoTextBox.Text, "Liabilities", _
                                              VendTitleComboBox.SelectedValue, "Account Payable", "Items Purcahsed from " + VendTitleComboBox.SelectedValue, _
                                              "Cash", Convert.ToDouble(TotalAmount_RsTextBox.Text), "", "", "")
                row1.Debit = Convert.ToDecimal(TotalAmount_RsTextBox.Text)
                Me.LedgerTableAdapter.Insert(PInvDateDateTimePicker.Value.Date, row1.Vendid, "Liabilities", VendTitleComboBox.SelectedValue, "Account Payable", "Items Purchase from " + VendTitleComboBox.SelectedValue + " on Cash", Convert.ToInt32(TotalAmount_RsTextBox.Text), 0)
                Me.LedgerTableAdapter.Insert(PInvDateDateTimePicker.Value.Date, "666", "Expences", "Purchases", "Purchases", "Items Purchased on Cash", Convert.ToInt32(TotalAmount_RsTextBox.Text), 0)
            ElseIf Payment_TypeComboBox.SelectedItem = "Credit" Then

                row1.Credit = Convert.ToDecimal(TotalAmount_RsTextBox.Text)
                Me.LedgerTableAdapter.Insert(PInvDateDateTimePicker.Value.Date, row1.Vendid, "Liabilities", VendTitleComboBox.SelectedValue, "Account Payable", "Items Purchase from " + VendTitleComboBox.SelectedValue + " on Credit", 0, Convert.ToInt32(TotalAmount_RsTextBox.Text))
                Me.LedgerTableAdapter.Insert(PInvDateDateTimePicker.Value.Date, "666", "Expences", "Purchases", "Purchases", "Items Purchased on Credit", 0, Convert.ToInt32(TotalAmount_RsTextBox.Text))

            End If
            Me.AD_VendorsBindingSource.EndEdit()

        End If
        Me.PInvoice_DetailsBindingSource.EndEdit()
        Me.PInvoice_MainBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        flag = False
        MsgBox("Update sucessful")
        Print()
        PInvoice_DetailsDataGridView.Visible = False
    End Sub
    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Print()
    End Sub
#End Region
#Region "Selection"

    Private Sub CurrencyNameComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CurrencyNameComboBox.SelectionChangeCommitted
        Dim row As ISPASDataSet.CurrencyRateRow
        row = CType(CType(Me.CurrencyRateBindingSource.Current, DataRowView).Row, ISPASDataSet.CurrencyRateRow)
        CurrencyRateTextBox.Text = row.Rate.ToString
    End Sub

#End Region
#Region "Details"

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        AD_ProductsDataGridView.Visible = True
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Down Then
            If AD_ProductsDataGridView.CurrentCell.RowIndex = AD_ProductsDataGridView.Rows.Count - 1 Then
                e.Handled = True
            Else
                AD_ProductsDataGridView.CurrentCell = AD_ProductsDataGridView.Rows(AD_ProductsDataGridView.CurrentCell.RowIndex + 1).Cells(0)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If AD_ProductsDataGridView.CurrentCell.RowIndex > 0 Then
                AD_ProductsDataGridView.CurrentCell = AD_ProductsDataGridView.Rows(AD_ProductsDataGridView.CurrentCell.RowIndex - 1).Cells(0)
            Else
                e.Handled = True
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            Dim row As ISPASDataSet.AD_ProductsRow
            row = CType(CType(Me.ADProductsBindingSource.Current, DataRowView).Row, ISPASDataSet.AD_ProductsRow)
            TextBox1.Text = row.ProdTitle.ToString
            OldPriceTextBox.Text = row.UnitPrice
            UnitPriceTextBox.Text = ""
            DutyTextBox.Text = ""
            QuantityTextBox.Text = ""
            TotalCostTextBox.Text = ""

            UnitPriceTextBox.Focus()

        ElseIf e.KeyCode = Keys.Escape Then
            AD_ProductsDataGridView.Visible = False
            PInvoice_DetailsDataGridView.Focus()
        End If

    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        AD_ProductsDataGridView.Visible = False
        TextBox1.BackColor = TextBox1.Tag
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ADProductsBindingSource.Filter = "(ProdTitle) LIKE '" + TextBox1.Text.Trim + "' + '%' "
    End Sub

    Private Sub UnitPriceTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UnitPriceTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DutyTextBox.Focus()
        End If
    End Sub
    Private Sub UnitPriceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitPriceTextBox.TextChanged
        If UnitPriceTextBox.Text <> "" Then
            DutyTextBox.Text = Math.Round(Convert.ToDouble(UnitPriceTextBox.Text) * 0.04, 2)
        End If
    End Sub

    Private Sub DutyTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DutyTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            QuantityTextBox.Focus()
        End If
    End Sub

    Private Sub QuantityTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QuantityTextBox.KeyDown
        Dim match As Boolean = False


        If UnitPriceTextBox.Text = "" Then
            UnitPriceTextBox.Text = OldPriceTextBox.Text - (OldPriceTextBox.Text * 0.04)
            DutyTextBox.Text = Math.Round(Convert.ToDouble(OldPriceTextBox.Text) * 0.04, 2)

        End If

        If DutyTextBox.Text = "" Then
            DutyTextBox.Text = 0
        End If

        If DutyExpTextBox.Text = "" Then
            DutyExpTextBox.Text = 0
        End If

        If QuantityTextBox.Text = "" Then
            QuantityTextBox.Text = 1
            QuantityTextBox.SelectAll()
        End If

        TotalCostTextBox.Text = (Math.Round(Convert.ToDouble(UnitPriceTextBox.Text)) + Math.Round(Convert.ToDouble(DutyTextBox.Text))) * Convert.ToDouble(QuantityTextBox.Text)

        If e.KeyCode = Keys.Enter Then
            With PInvoice_DetailsDataGridView
                Dim y As Integer
                y = .Rows.GetRowCount(DataGridViewElementStates.Visible) - 1

                For i As Integer = 0 To y
                    If .Rows(i).Cells(2).Value = TextBox1.Text Then
                        match = True
                        If match = True Then
                            .Rows(i).Cells(3).Value += Convert.ToInt32(QuantityTextBox.Text)
                            .Rows(i).Cells(6).Value = Convert.ToInt32(.Rows(i).Cells(3).Value) * (Convert.ToInt32(.Rows(i).Cells(4).Value) + Convert.ToInt32(.Rows(i).Cells(5).Value))
                        End If
                        Exit For
                    End If


                Next
            End With



            If match = False Then
                With PInvoice_DetailsDataGridView
                    Dim x As Integer
                    If PInvNoTextBox.Text = "" Then
                        PInvNoTextBox.Text = 1
                    End If
                    PInvoice_DetailsBindingSource.AddNew()
                    .Rows.Add()
                    x = .Rows.GetRowCount(DataGridViewElementStates.Visible) - 1
                    .Rows(x).Cells(1).Value = Convert.ToInt32(PInvNoTextBox.Text)
                    .Rows(x).Cells(2).Value = TextBox1.Text
                    .Rows(x).Cells(3).Value = Convert.ToInt32(QuantityTextBox.Text)
                    .Rows(x).Cells(4).Value = Convert.ToDouble(UnitPriceTextBox.Text)
                    .Rows(x).Cells(5).Value = Convert.ToDouble(DutyTextBox.Text)
                    .Rows(x).Cells(6).Value = Convert.ToDouble(TotalCostTextBox.Text)
                    .Rows(x).Cells(7).Value = Convert.ToDouble(OldPriceTextBox.Text)



                End With
            End If


            DutyExpTextBox.Text = Convert.ToDouble(DutyExpTextBox.Text) + (Convert.ToDouble(DutyTextBox.Text) * QuantityTextBox.Text)
            If TotalAmount_RsTextBox.Text = "" Then
                TotalAmount_RsTextBox.Text = 0
            End If
            TotalAmount_RsTextBox.Text = Convert.ToDouble(TotalAmount_RsTextBox.Text) + Convert.ToDouble(TotalCostTextBox.Text)

            TextBox1.Text = ""
            OldPriceTextBox.Text = ""
            UnitPriceTextBox.Text = ""
            DutyTextBox.Text = ""
            QuantityTextBox.Text = ""
            TotalCostTextBox.Text = ""

            TextBox1.Focus()

        End If
    End Sub

    Private Sub PInvoice_DetailsDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PInvoice_DetailsDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            With PInvoice_DetailsDataGridView
                DutyExpTextBox.Text = Convert.ToDouble(DutyExpTextBox.Text) - (.CurrentRow.Cells(3).Value * .CurrentRow.Cells(5).Value)
                TotalAmount_RsTextBox.Text = Convert.ToDouble(TotalAmount_RsTextBox.Text) - .CurrentRow.Cells(6).Value
                .Rows.Remove(.CurrentRow)
            End With
        End If

        If e.KeyCode = Keys.Escape Then
            TextBox1.Focus()
        End If

    End Sub

    Private Sub TotalAmount_RsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalAmount_RsTextBox.TextChanged
        Label3.Text = "Rs." + TotalAmount_RsTextBox.Text
    End Sub

#End Region
#Region "Print"
    Private Sub Print()
        Try
            Dim rpt As rptPurchaseInvoice = New rptPurchaseInvoice
            Dim frm As frmReport = New frmReport
            frm.MdiParent = Me.MdiParent
            frm.Show()
            frm.CrystalReportViewer1.SelectionFormula = "{PInvoice_Main.PInvNo} = " + PInvNoTextBox.Text.Trim
            frm.CrystalReportViewer1.Refresh()
            frm.CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class