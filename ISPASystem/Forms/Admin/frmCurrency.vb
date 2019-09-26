Public Class FrmCurrency
    Private Sub FrmCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CurrencyRateTableAdapter.Fill(Me.ISPASDataSet.CurrencyRate)
    End Sub
    Private Sub CurrencyRateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrencyRateBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CurrencyRateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        CurrencyRateBindingSource.Filter = "CurrencyName LIKE '" + SearchTextBox.Text + "' + '%' "
    End Sub
End Class