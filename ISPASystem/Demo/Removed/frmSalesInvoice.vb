Public Class frmSalesInvoice
    Dim CustID As Integer

    'Private Sub SaleInvoice_MBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoice_MBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.SaleInvoice_MBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)

    '    Me.LedgerTableAdapter.SInv_DisEntry(SIDateDateTimePicker.Value.ToOADate, DiscountAmountTextBox.Text)

    '    If Payment_TypeComboBox.SelectedItem = "Cash" Then

    '        Me.Cr_VoucherTableAdapter.SInv_Add_To_RecVoucher(Convert.ToDecimal(Me.Cr_VoucherTableAdapter.NewID()), SIDateDateTimePicker.Value.ToShortDateString, _
    '                                                         SInvNoTextBox.Text, CustNameComboBox.SelectedValue, _
    '                                                         CustNameComboBox.SelectedValue, TotalAmountTextBox.Text)

    '        Me.AD_CustomersTableAdapter.UpdateDebit(Convert.ToInt32(TotalAmountTextBox.Text), CustNameComboBox.SelectedValue)

    '        Me.LedgerTableAdapter.SInv_OnCashSaleEntry(SIDateDateTimePicker.Value.ToOADate, CustID, CustNameComboBox.SelectedValue, CustNameComboBox.SelectedValue, TotalAmountTextBox.Text)
    '        Me.LedgerTableAdapter.SInv_SaleOnCashEntry(SIDateDateTimePicker.Value.ToOADate, OriginalSaleTextBox.Text)

    '    ElseIf Payment_TypeComboBox.SelectedItem = "Credit" Then

    '        Me.AD_CustomersTableAdapter.UpdateCredit(TotalAmountTextBox.Text, CustNameComboBox.SelectedValue)
    '        Me.LedgerTableAdapter.SInv_OnCreditSaleEntry(SIDateDateTimePicker.Value.ToOADate, CustID, CustNameComboBox.SelectedValue, CustNameComboBox.SelectedValue, TotalAmountTextBox.Text)
    '        Me.LedgerTableAdapter.SInv_SaleOnCreditEntry(SIDateDateTimePicker.Value.ToOADate, OriginalSaleTextBox.Text)

    '    End If

    '    SaleDetails()
    '    ClearComponents()
    '    Me.Close()
    'End Sub

    'Private Sub frmSalesInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
    '    Me.AD_CustomersTableAdapter.Fill(Me.ISPASDataSet.AD_Customers)
    'End Sub

    'Private Sub ProdTitleComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProdTitleComboBox.SelectedIndexChanged
    '    QuantityTextBox.Text = ""
    '    UnitPriceTextBox.Text = ""
    '    TotalCostTextBox.Text = ""
    '    If ProdTitleComboBox.SelectedValue <> "" Then
    '        Dim row As ISPASDataSet.AD_ProductsRow
    '        row = CType(CType(Me.AD_ProductsBindingSource.Current, DataRowView).Row, ISPASDataSet.AD_ProductsRow)

    '        'UnitPriceTextBox.Text = Me.AD_ProductsTableAdapter.ReturnUnitPriceByProdTitle(ProdTitleComboBox.SelectedValue)
    '        UnitPriceTextBox.Text = row.UnitPrice
    '        QuantityTextBox.Focus()
    '    End If
    'End Sub

    'Private Sub QuantityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityTextBox.TextChanged, UnitPriceTextBox.TextChanged
    '    If TotalCostTextBox.Text = "" Then
    '        TotalCostTextBox.Text = 0
    '    End If
    '    If QuantityTextBox.Text = "" Then
    '        TotalCostTextBox.Text = ""
    '    Else
    '        TotalCostTextBox.Text = QuantityTextBox.Text * UnitPriceTextBox.Text
    '    End If
    'End Sub

    'Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
    '    If SInvNoTextBox.Text = "" Then
    '        'SInvNoTextBox.Text = Me.SaleInvoice_MTableAdapter.NewId
    '    End If

    '    With DataGridView1

    '        Dim Ri As Integer = .Rows.GetRowCount(DataGridViewElementStates.Displayed)
    '        .Rows.Add()
    '        .Rows(Ri).Cells(0).Value = ProdTitleComboBox.SelectedValue
    '        .Rows(Ri).Cells(1).Value = QuantityTextBox.Text
    '        .Rows(Ri).Cells(2).Value = UnitPriceTextBox.Text
    '        .Rows(Ri).Cells(3).Value = TotalCostTextBox.Text
    '        .CurrentCell = .Rows(Ri).Cells(0)
    '    End With
    '    If OriginalSaleTextBox.Text = "" Then
    '        OriginalSaleTextBox.Text = 0
    '    End If
    '    OriginalSaleTextBox.Text = Convert.ToDecimal(OriginalSaleTextBox.Text) + Convert.ToDecimal(TotalCostTextBox.Text)
    '    TotalAmountTextBox.Text = OriginalSaleTextBox.Text
    '    ProdTitleComboBox.Focus()
    'End Sub

    'Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
    '    OriginalSaleTextBox.Text = Convert.ToDecimal(OriginalSaleTextBox.Text) + Convert.ToDecimal(TotalCostTextBox.Text)
    '    TotalAmountTextBox.Text = OriginalSaleTextBox.Text
    '    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
    'End Sub

    Private Sub SaleDetails()
        With DataGridView1

            Dim Ri As Integer = .Rows.GetRowCount(DataGridViewElementStates.Displayed)
            For i As Integer = 0 To Ri - 1
                Me.SaleInvoice_DTableAdapter.Insert(SInvNoTextBox.Text, .Rows(i).Cells(0).Value, Convert.ToInt32(.Rows(i).Cells(1).Value), Convert.ToDouble(.Rows(i).Cells(2).Value), Convert.ToDouble(.Rows(i).Cells(3).Value))
                Dim unit As Integer = Me.AD_ProductsTableAdapter.ReturnUntisBeforeStockUpdate(.Rows(i).Cells(0).Value)
                unit = unit - Convert.ToInt32(.Rows(i).Cells(1).Value)
                'Me.AD_ProductsTableAdapter.UpdateUnit(unit, .Rows(i).Cells(0).Value)
            Next

        End With

    End Sub

    'Private Sub ClearComponents()
    '    DataGridView1.Rows.Clear()
    '    QuantityTextBox.Text = ""
    '    UnitPriceTextBox.Text = ""
    '    TotalCostTextBox.Text = ""
    'End Sub

    'Private Sub CustNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustNameComboBox.SelectedIndexChanged
    '    If CustNameComboBox.SelectedValue <> "" Then
    '        'CustID = Me.AD_CustomersTableAdapter.SelectIDbyCustTitle(CustNameComboBox.SelectedValue)
    '        Dim row As ISPASDataSet.AD_CustomersRow
    '        row = CType(CType(Me.AD_CustomersBindingSource.Current, DataRowView).Row, ISPASDataSet.AD_CustomersRow)
    '        CustID = row.Custid
    '    End If

    'End Sub

    'Private Sub DiscountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountTextBox.TextChanged
    '    If OriginalSaleTextBox.Text = "" Then
    '        OriginalSaleTextBox.Text = 0
    '        OriginalSaleTextBox.SelectAll()
    '    End If
    '    If DiscountTextBox.Text = "" Then
    '        DiscountTextBox.Text = 0
    '        DiscountTextBox.SelectAll()
    '    End If

    '    'If OriginalSaleTextBox.Text <> "" And DiscountTextBox.Text <> "" Then

    '    DiscountAmountTextBox.Text = Convert.ToDouble(OriginalSaleTextBox.Text) _
    '                                    * (Convert.ToDouble(DiscountTextBox.Text) / 100)

    '    TotalAmountTextBox.Text = Convert.ToDouble(OriginalSaleTextBox.Text) _
    '                                        - Convert.ToDouble(DiscountAmountTextBox.Text)
    '    'End If

    'End Sub

    'Private Sub DiscountAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountAmountTextBox.TextChanged
    '    'If OriginalSaleTextBox.Text = "" Then
    '    '    OriginalSaleTextBox.Text = 0
    '    '    OriginalSaleTextBox.SelectAll()
    '    'End If
    '    'If DiscountAmountTextBox.Text = "" Then
    '    '    DiscountAmountTextBox.Text = 0
    '    '    DiscountAmountTextBox.SelectAll()
    '    'End If
    '    ''If OriginalSaleTextBox.Text <> "" And DiscountAmountTextBox.Text <> "" Then
    '    'TotalAmountTextBox.Text = Convert.ToDouble(OriginalSaleTextBox.Text) _
    '    '                                - Convert.ToDouble(DiscountAmountTextBox.Text)
    '    ''End If
    'End Sub

End Class