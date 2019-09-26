Public Class frmVendorReportvb
    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Me.AD_VendorsTableAdapter.Fill(Me.Reports.AD_Vendors)
    End Sub
End Class