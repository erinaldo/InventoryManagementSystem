Public Class frmCashPaymentVoucher
    Private Sub frmCashPaymentVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cp_VoucherTableAdapter.Fill(Me.ISPASDataSet.Cp_Voucher)
        Me.AccountChartTableAdapter.Fill(Me.ISPASDataSet.AccountChart)
    End Sub
    Private Sub Cp_VoucherBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cp_VoucherBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Cp_VoucherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub AccountHeadComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountHeadComboBox.SelectedIndexChanged
        If Me.AccountChartBindingSource.Filter = "{AccountHead} ='" + AccountHeadComboBox.SelectedItem + "'" Then
            Dim row As ISPASDataSet.AccountChartRow
            row = CType(CType(Me.AccountChartBindingSource.Current, DataRowView).Row, ISPASDataSet.AccountChartRow)
            AccountTypeTextBox.Text = row.AccountType
        End If
    End Sub
    Private Sub PaymentModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentModeComboBox.SelectedIndexChanged
        If PaymentModeComboBox.SelectedItem = "Cheque" Then
            ChequeNoTextBox.Enabled = True
        Else
            ChequeNoTextBox.Enabled = False
        End If
    End Sub
End Class