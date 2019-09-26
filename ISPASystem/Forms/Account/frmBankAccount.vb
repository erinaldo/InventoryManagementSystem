Public Class FrmBankAccount
    Dim flag As Boolean = False
    Private Sub FrmBankAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Me.Bank_AccountsTableAdapter.Fill(Me.ISPASDataSet.Bank_Accounts)
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        flag = True
        If flag Then CurrentBalanceTextBox.Enabled = True
    End Sub
    Private Sub Bank_AccountsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.Bank_AccountsBindingSource.EndEdit()
        If flag = True Then
            Me.AccountChartTableAdapter.Insert(AccountNoTextBox.Text, BankNameTextBox.Text, "", "Bank", CurrentBalanceTextBox.Text)
            CurrentBalanceTextBox.Enabled = False
            flag = False
        End If
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("updated Sucessfully")
    End Sub
    Private Sub AccountNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountNoTextBox.TextChanged
        If AccountHeadTextBox.Text = "" Then
            AccountHeadTextBox.Text = "B"
        End If
    End Sub
End Class