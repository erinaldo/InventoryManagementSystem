Public Class rptPurchaseReport
    Private Sub frmPurchaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_ProdCatTableAdapter.Fill(Me.Reports.AD_ProdCat)
        Me.AD_VendorsTableAdapter.Fill(Me.Reports.AD_Vendors)
        Me.AD_ProductsTableAdapter.Fill(Me.Reports.AD_Products)
        SelectComboBox.SelectedIndex = 0
    End Sub
    Private Sub SelectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectComboBox.SelectedIndexChanged
        CategoryComboBox.Enabled = False
        ProductComboBox.Enabled = False
        VendorComboBox.Enabled = False
        Select Case SelectComboBox.SelectedIndex
            Case 1
                CategoryComboBox.Enabled = True
                CategoryComboBox.Focus()
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
                Me.PInvoice_DetailsTableAdapter.FillByDate(Me.Reports.PInvoice_Details, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)
            Case 1
                Me.PInvoice_DetailsTableAdapter.FillByProdCat(Me.Reports.PInvoice_Details, CategoryComboBox.SelectedValue, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)

            Case 2
                Me.PInvoice_DetailsTableAdapter.FillByProduct(Me.Reports.PInvoice_Details, ProductComboBox.SelectedValue, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)

            Case 3
                Me.PInvoice_DetailsTableAdapter.FillByVend(Me.Reports.PInvoice_Details, VendorComboBox.SelectedValue, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)
        End Select
    End Sub
End Class