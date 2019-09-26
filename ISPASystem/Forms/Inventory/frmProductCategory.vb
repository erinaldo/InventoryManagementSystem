Public Class ProductCategory
    Private Sub ProductCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_ProdCatTableAdapter.Fill(Me.ISPASDataSet.AD_ProdCat)
    End Sub
    Private Sub AD_ProdCatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AD_ProdCatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AD_ProdCatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        AD_ProdCatBindingSource.Filter = "ProdCatTitle LIKE '" + SearchTextBox.Text + "' + '%' "
    End Sub
End Class