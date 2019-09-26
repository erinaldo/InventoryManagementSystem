Public Class frmBankPaymentVoucher
    Dim newflag As Boolean = False
    Dim _CurrentBalance As Decimal
    Private Sub frmBankPaymentVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LedgerTableAdapter.Fill(Me.ISPASDataSet.Ledger)
        Me.AccountChartTableAdapter.Fill(ISPASDataSet.AccountChart)
        Me.Bank_AccountsTableAdapter.Fill(Me.ISPASDataSet.Bank_Accounts)
        Me.MasterTableAdapter.Fill(Me.ISPASDataSet.Master)
        Me.Bp_VoucherTableAdapter.Fill(Me.ISPASDataSet.Bp_Voucher)
    End Sub
    Private Sub Bp_VoucherBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Bp_VoucherBindingSource.AddingNew
        newflag = True
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If Bank_AccountsBindingSource.Count >= 1 Then
            Dim row As ISPASDataSet.Bank_AccountsRow
            row = CType(CType(Me.Bank_AccountsBindingSource.Current, DataRowView).Row, ISPASDataSet.Bank_AccountsRow)
            If Not row.IsCurrentBalanceNull Then
                'CurrentBalanceLabel.Text = "You have Rs. " + row.CurrentBalance.ToString + " in your " + row.BankName.ToString + "'s " + row.AccountNo.ToString + " Account"
                _CurrentBalance = row.CurrentBalance
            Else
                'CurrentBalanceLabel.Text = "You Have No Balance In Your " + row.BankName.ToString + "'s " + row.AccountNo.ToString + " Account"
                _CurrentBalance = 0
            End If
            BankNameTextBox.Text = row.BankName
        End If

        If newflag Then

            Dim Debit = Convert.ToDouble(_CurrentBalance) + Convert.ToDouble(TAmountTextBox.Text)
            Me.LedgerTableAdapter.Insert(Date.Today, "Bp1", "Bank", "Bank", AccountTitleComboBox.SelectedValue, PVParticularsTextBox.Text, Debit, TAmountTextBox.Text)

            Dim row As ISPASDataSet.Bank_AccountsRow
            row = CType(CType(Me.Bank_AccountsBindingSource.Current, DataRowView).Row, ISPASDataSet.Bank_AccountsRow)

            row.CurrentBalance = row.CurrentBalance + Convert.ToDouble(TAmountTextBox.Text)
            Bank_AccountsBindingSource.EndEdit()
           
            newflag = False
        End If

        Me.Validate()
        Me.Bp_VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("Update Sucessfull")

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