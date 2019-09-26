Public Class frmBankReciptVoucher
    Dim NewFlag As Boolean = False
    Dim _CurrentBalance As Decimal
    Private Sub frmBankReciptVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MasterTableAdapter.Fill(Me.ISPASDataSet.Master)
        Me.AccountChartTableAdapter.Fill(ISPASDataSet.AccountChart)
        Me.Bank_AccountsTableAdapter.Fill(Me.ISPASDataSet.Bank_Accounts)
        Me.Br_VoucherTableAdapter.Fill(Me.ISPASDataSet.Br_Voucher)
    End Sub
    Private Sub Br_VoucherBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Br_VoucherBindingSource.AddingNew
        NewFlag = True
    End Sub
    Private Sub Br_VoucherBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Br_VoucherBindingNavigatorSaveItem.Click
        If Bank_AccountsBindingSource.Count >= 1 Then
            Dim row As ISPASDataSet.Bank_AccountsRow
            row = CType(CType(Me.Bank_AccountsBindingSource.Current, DataRowView).Row, ISPASDataSet.Bank_AccountsRow)
            If Not row.IsCurrentBalanceNull Then
                _CurrentBalance = row.CurrentBalance
            Else
                _CurrentBalance = 0
            End If
            BankNameTextBox.Text = row.BankName
        End If

        If NewFlag = True Then

            Dim credit = Convert.ToDecimal(_CurrentBalance) - Convert.ToDecimal(TAmountTextBox.Text)
            Me.LedgerTableAdapter.Insert(Date.Today, "Br", "Bank", "Bank", AccountTitleComboBox.SelectedValue, RVParticularsTextBox.Text, credit, TAmountTextBox.Text)
            Dim row As ISPASDataSet.Bank_AccountsRow
            row = CType(CType(Me.Bank_AccountsBindingSource.Current, DataRowView).Row, ISPASDataSet.Bank_AccountsRow)

            row.CurrentBalance = row.CurrentBalance - Convert.ToDouble(TAmountTextBox.Text)
            Bank_AccountsBindingSource.EndEdit()

            NewFlag = False
        End If

        Me.Validate()
        Me.Br_VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub PaymentModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentModeComboBox.SelectedIndexChanged
        If PaymentModeComboBox.SelectedItem = "Cheque" Then
            ChequeNoTextBox.Enabled = True
        Else
            ChequeNoTextBox.Enabled = False
        End If
    End Sub
    Private Sub AccountTypeComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountTypeComboBox.SelectionChangeCommitted
        Me.AccountChartBindingSource.Filter = "AccountType ='" + AccountTypeComboBox.SelectedValue + "'"
    End Sub
End Class