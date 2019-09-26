Public Class rptCustomerReport
    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Me.AD_CustomersTableAdapter.Fill(Me.Reports.AD_Customers)
    End Sub
End Class