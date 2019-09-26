Public Class FrmNewAccount
    Dim flag As Boolean = False
    Private Sub FrmNewAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MasterTableAdapter.Fill(Me.ISPASDataSet.Master)
        Me.AccountChartTableAdapter.Fill(Me.ISPASDataSet.AccountChart)
        Me.NewAccountsTableAdapter.Fill(Me.ISPASDataSet.NewAccounts)
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        flag = True
        GroupBox1.Visible = True
    End Sub
    Private Sub NewAccountsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAccountsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NewAccountsBindingSource.EndEdit()
        If flag = True Then
            AccountChartBindingSource.AddNew()
            Dim row As ISPASDataSet.AccountChartRow
            row = CType(CType(Me.AccountChartBindingSource.Current, DataRowView).Row, ISPASDataSet.AccountChartRow)
            row.AccountID = AccountIDTextBox.Text
            row.AccountHeadTitle = AccountHeadTitleTextBox.Text
            row.AccountHead = AccountHeadComboBox.SelectedItem
            row.AccountType = AccountTypeComboBox.SelectedValue
            row.OpeningBal = OpeningBalTextBox.Text
            AccountChartBindingSource.EndEdit()
            flag = False
        End If

        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        GroupBox1.Visible = False
        Me.NewAccountsTableAdapter.Fill(Me.ISPASDataSet.NewAccounts)
    End Sub
    Private Sub AccountChartDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AccountChartDataGridView.CellDoubleClick
        Panel1.Visible = True
    End Sub
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        AccountChartBindingSource.EndEdit()
        Panel1.Visible = False
    End Sub
    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        AccountChartBindingSource.CancelEdit()
        Panel1.Visible = False
    End Sub
End Class