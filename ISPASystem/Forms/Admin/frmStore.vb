Public Class FrmStore
    Private Sub FrmStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StoresTableAdapter.Fill(Me.ISPASDataSet.Stores)
    End Sub
    Private Sub StoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        StoresBindingSource.Filter = "StoreName LIKE '" + SearchTextBox.Text + "' + '%' "
    End Sub
End Class