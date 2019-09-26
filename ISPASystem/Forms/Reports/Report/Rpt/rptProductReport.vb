Public Class rptProductReport
    Private Sub frmProductReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_VendorsTableAdapter.Fill(Me.Reports.AD_Vendors)
        Me.AD_ProdCatTableAdapter.Fill(Me.Reports.AD_ProdCat)
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        Select Case ComboBox1.SelectedIndex
            Case 2
                ComboBox3.Enabled = True
                ComboBox3.Focus()
            Case 3
                ComboBox2.Enabled = True
                ComboBox2.Focus()
        End Select
    End Sub
    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                Me.AD_ProductsTableAdapter.Fill(Me.Reports.AD_Products)
            Case 1
                Me.AD_ProductsTableAdapter.FillByUnderValue(Me.Reports.AD_Products)
            Case 2
                Me.AD_ProductsTableAdapter.FillByVendor(Me.Reports.AD_Products, ComboBox3.SelectedValue)
            Case 3
                Me.AD_ProductsTableAdapter.FillByCategory(Me.Reports.AD_Products, ComboBox2.SelectedValue)
        End Select
    End Sub
End Class