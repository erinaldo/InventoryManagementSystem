Public Class FrmSubHeads
    Private Sub FrmSubHeads_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MasterTableAdapter.Fill(Me.ISPASDataSet.Master)
    End Sub
    Private Sub MasterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MasterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
End Class