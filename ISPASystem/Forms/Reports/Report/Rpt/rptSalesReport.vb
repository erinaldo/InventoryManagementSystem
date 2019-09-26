Public Class frmSalesReport
    Private Sub frmPurchaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_CustomersTableAdapter.Fill(Me.Reports.AD_Customers)
        Me.AD_VendorsTableAdapter.Fill(Me.Reports.AD_Vendors)
        Me.AD_ProductsTableAdapter.Fill(Me.Reports.AD_Products)
        SelectComboBox.SelectedIndex = 0
    End Sub
    Private Sub SelectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectComboBox.SelectedIndexChanged
        CustomerComboBox.Enabled = False
        ProductComboBox.Enabled = False
        VendorComboBox.Enabled = False

        Select Case SelectComboBox.SelectedIndex
            Case 1
                CustomerComboBox.Enabled = True
                CustomerComboBox.Focus()
            Case 2
                ProductComboBox.Enabled = True
                ProductComboBox.Focus()
            Case 3
                VendorComboBox.Enabled = True
                VendorComboBox.Focus()
        End Select
    End Sub
    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Select Case SelectComboBox.SelectedIndex
            Case 0
                Me.SaleInvoice_DTableAdapter.FillByDate(Me.Reports.SaleInvoice_D, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)
            Case 1
                Me.SaleInvoice_DTableAdapter.FillByCustomer(Me.Reports.SaleInvoice_D, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString, CustomerComboBox.SelectedValue)
            Case 2
                Me.SaleInvoice_DTableAdapter.FillByProduct(Me.Reports.SaleInvoice_D, ProductComboBox.SelectedValue, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)
            Case 3
                Me.SaleInvoice_DTableAdapter.FillByVendor(Me.Reports.SaleInvoice_D, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString, VendorComboBox.SelectedValue)
        End Select
    End Sub
End Class