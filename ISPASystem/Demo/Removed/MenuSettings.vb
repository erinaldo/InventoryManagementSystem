Public Class MenuSettings

    Private Sub MenuSettingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSettingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MenuSettingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
    End Sub

    Private Sub MenuSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Me.ISPASDataSet.Users)
        'Me.MenuSettingTableAdapter.Fill(Me.ISPASDataSet.MenuSetting)
    End Sub

    Private Sub UserNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserNameComboBox.SelectedIndexChanged
        'Me.MenuSettingTableAdapter.FillByUserName(Me.ISPASDataSet.MenuSetting, UserNameComboBox.SelectedValue)
    End Sub

End Class