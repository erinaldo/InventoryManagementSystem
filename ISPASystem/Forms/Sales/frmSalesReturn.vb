Public Class frmSalesReturn
    Private Sub ProcessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessButton.Click
        If SInvNoTextBox.Text = "" Then
            MsgBox("Please Enter Sale Invoice Number")
            SInvNoTextBox.Focus()
        ElseIf QuantityReturnTextBox.Text = "" Then
            MsgBox("Please Enter Quantity to Return")
            QuantityReturnTextBox.Focus()
        Else
            Me.Sale_ReturnTableAdapter.Insert( _
            SRetDateDateTimePicker.Value.ToShortDateString, SInvNoTextBox.Text, CustomerTextBox.Text, _
             ProdTitleComboBox.SelectedValue, InvDateDateTimePicker.Value.ToShortDateString, _
              ItemPriceTextBox.Text, QuantitySaleTextBox.Text, QuantityReturnTextBox.Text, ReasonTextBox.Text, _
               DefectedCheckBox.CheckState)
            If (DefectedCheckBox.CheckState = CheckState.Unchecked) Then
                Me.AD_ProductsTableAdapter.UpdateStock(Convert.ToInt32(QuantityReturnTextBox.Text), 0, 0, ProdTitleComboBox.SelectedItem)
            End If
            ' ''Me.SaleInvoice_DTableAdapter.UpdateSaleInvWhenSaleReturn(QuantityReturnTextBox.Text, SInvNoTextBox.Text, ProdTitleComboBox.SelectedValue)
            Me.LedgerTableAdapter.Insert(SRetDateDateTimePicker.Value.Date, "121", "Revenue", "Sales Returns", "Revenue", "Sales Return By " + CustomerTextBox.Text, Convert.ToInt32(ItemPriceTextBox.Text) * Convert.ToInt32(QuantityReturnTextBox.Text), 0)
            MsgBox("Item Posted Sucessfully")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SaleInvoice_MTableAdapter.Fill(Me.ISPASDataSet.SaleInvoice_M)
        Me.SaleInvoice_DTableAdapter.Fill(Me.ISPASDataSet.SaleInvoice_D)
        SaleInvoiceMBindingSource.Filter = "(SInvNo) ='" + SInvNoTextBox.Text + "'"
        SaleInvoice_DBindingSource.Filter = "(SInvNo) ='" + SInvNoTextBox.Text + "'"
    End Sub
End Class