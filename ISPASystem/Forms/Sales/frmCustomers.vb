Public Class frmCustomers
    Dim Flag As Boolean = False
    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_CustomersTableAdapter.Fill(Me.ISPASDataSet.AD_Customers)
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Flag = True
    End Sub
    Private Sub AD_CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AD_CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AD_CustomersBindingSource.EndEdit()

        If Flag = True Then
            Me.AccountChartTableAdapter.Insert(CustidTextBox.Text, CustTitleTextBox.Text, "Assets", "Account Receivable", Convert.ToDecimal(DebitTextBox.Text) - Convert.ToDecimal(CreditTextBox.Text))
            Flag = False
        End If
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("Updated Sucessfully")
    End Sub
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        AD_CustomersBindingSource.Filter = "CustTitle LIKE '" + SearchTextBox.Text + "' + '%' "
    End Sub
End Class