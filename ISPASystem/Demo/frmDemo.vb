Public Class frmDemo
    Private Sub PickListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PickListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PickListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub frmDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PickListTableAdapter.Fill(Me.ISPASDataSet.PickList)
    End Sub

End Class