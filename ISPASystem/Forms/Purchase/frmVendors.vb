Public Class frmVendors
    Dim flag As Boolean = False
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AccountChartTableAdapter.Fill(Me.ISPASDataSet.AccountChart)
        Me.AD_VendorsTableAdapter.Fill(Me.ISPASDataSet.AD_Vendors)
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        flag = True
    End Sub
    Private Sub AD_VendorsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AD_VendorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AD_VendorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        If flag = True Then
            Me.AccountChartTableAdapter.Insert(VendidTextBox.Text, VendTitleTextBox.Text, "Liabilities", "Account Payable", Convert.ToDecimal(DebitTextBox.Text) - Convert.ToDecimal(CreditTextBox.Text))
            flag = False
        End If
    End Sub
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        AD_VendorsBindingSource.Filter = "VendTitle LIKE '" + SearchTextBox.Text + "' + '%' "
    End Sub
End Class