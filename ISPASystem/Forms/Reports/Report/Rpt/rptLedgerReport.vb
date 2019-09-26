Public Class rptLedgerReport

    Private Sub frmLedgerReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_CustomersTableAdapter.Fill(Me.Reports.AD_Customers)
        Me.AD_VendorsTableAdapter.Fill(Me.Reports.AD_Vendors)
        SelectComboBox.SelectedIndex = 2
    End Sub
    Private Sub SelectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectComboBox.SelectedIndexChanged
        CustomerComboBox.Enabled = False
        VendorComboBox.Enabled = False
        If DateTimePicker2.Value >= DateTimePicker1.Value Then
            Select Case SelectComboBox.SelectedIndex
                Case 0
                    CustomerComboBox.Enabled = True
                    CustomerComboBox.Focus()
                Case 1
                    VendorComboBox.Enabled = True
                    VendorComboBox.Focus()
            End Select
        End If

    End Sub
    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Select Case SelectComboBox.SelectedIndex
            Case 0
                Me.LedgerTableAdapter.FillByAcName(Me.Reports.Ledger, CustomerComboBox.SelectedValue, DateTimePicker1.Value, DateTimePicker2.Value)
            Case 1
                Me.LedgerTableAdapter.FillByAcName(Me.Reports.Ledger, VendorComboBox.SelectedValue, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)
            Case 2
                Me.LedgerTableAdapter.FillByDates(Me.Reports.Ledger, DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)
        End Select
    End Sub

End Class