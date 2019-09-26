Public Class rptChartOfAccountReport
    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Me.AccountChartTableAdapter.Fill(Me.Reports.AccountChart)
    End Sub
End Class