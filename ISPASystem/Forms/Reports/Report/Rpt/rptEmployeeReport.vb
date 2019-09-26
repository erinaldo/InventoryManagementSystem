Public Class rptEmployeeReport
    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Me.AD_EmpTableAdapter.Fill(Me.Reports.AD_Emp)
    End Sub
End Class