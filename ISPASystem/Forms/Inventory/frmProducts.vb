Public Class Products
    Private Sub Products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CurrencyRateTableAdapter.Fill(Me.ISPASDataSet.CurrencyRate)
        Me.AD_VendorsTableAdapter.Fill(Me.ISPASDataSet.AD_Vendors)
        Me.AD_ProdCatTableAdapter.Fill(Me.ISPASDataSet.AD_ProdCat)
        Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
    End Sub
    Private Sub AD_ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AD_ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AD_ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub CurrencyTypeComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CurrencyTypeComboBox.SelectionChangeCommitted
        Dim row As ISPASDataSet.CurrencyRateRow
        row = CType(CType(Me.CurrencyRateBindingSource.Current, DataRowView).Row, ISPASDataSet.CurrencyRateRow)
        CurrencyRateTextBox.Text = row.Rate.ToString
    End Sub
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        AD_ProductsBindingSource.Filter = "ProdTitle LIKE '" + SearchTextBox.Text.Trim + "' + '%' "
    End Sub
End Class