Imports System.Data.OleDb

Public Class frmLogin
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(ISPASDataSet.Users)
        Me.MenuSettingTableAdapter.Fill(ISPASDataSet.MenuSetting)
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If UserNameTextBox.Text = "" Then
            MsgBox("Enter User Name")
            UserNameTextBox.Focus()
            Exit Sub
        End If
        If txtPass.Text = "" Then
            MsgBox("Enter Password")
            txtPass.Focus()
            Exit Sub
        End If
        If UserNameTextBox.Text <> Nothing Or txtPass.Text <> Nothing Then
            Me.UsersBindingSource.Filter = "(UserName) = '" + UserNameTextBox.Text + "'"
            If Me.UsersBindingSource.Count >= 1 Then
                Dim row As ISPASDataSet.UsersRow

                row = CType(CType(Me.UsersBindingSource.Current, DataRowView).Row, ISPASDataSet.UsersRow)
                If row.UserName.ToLower = UserNameTextBox.Text.ToLower Then
                    If row.UserPassword = txtPass.Text Then
                        User_ID = row.UserID
                        User_Name = row.UserName.ToLower
                        ISPAMDIParent.Show()


                        Me.Close()
                    Else
                        MsgBox("Password Incorrect")
                        txtPass.SelectAll()
                        txtPass.Focus()

                    End If
                End If
            Else
                MsgBox("User Does Not Exist")
                txtPass.Clear()
                UserNameTextBox.SelectAll()
                UserNameTextBox.Focus()
            End If
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class