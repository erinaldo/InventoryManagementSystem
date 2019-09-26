Public Class frmEmployees
    Dim flag As Boolean = False
    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AccountChartTableAdapter.Fill(Me.ISPASDataSet.AccountChart)
        Me.AD_EmpTableAdapter.Fill(Me.ISPASDataSet.AD_Emp)
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        flag = True
    End Sub
    Private Sub AD_EmpBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AD_EmpBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AD_EmpBindingSource.EndEdit()
        If flag = True Then
            Me.AccountChartTableAdapter.Insert(EmpIdTextBox.Text, EmpNameTextBox.Text, "Libilities", "Account Payable", 0)
            flag = False
        End If
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        AD_EmpBindingSource.Filter = "EmpName LIKE '" + SearchTextBox.Text + "' + '%' "
    End Sub
End Class