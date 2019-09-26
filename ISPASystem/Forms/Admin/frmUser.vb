Public Class FrmUser
    Private Sub FrmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Me.ISPASDataSet.Users)
        Me.MenuSettingTableAdapter.Fill(Me.ISPASDataSet.MenuSetting)
    End Sub
    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub
End Class