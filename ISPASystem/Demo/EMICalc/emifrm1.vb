Public Class Emifrm1

    Private Sub EMISchemeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMISchemeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMISchemeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
    Private Sub Emifrm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EMISchemeTableAdapter.Fill(Me.ISPASDataSet.EMIScheme)
        Me.EMICalcTableAdapter.Fill(Me.ISPASDataSet.EMICalc)
    End Sub
End Class
