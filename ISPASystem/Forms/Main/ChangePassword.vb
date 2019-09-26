Public Class ChangePassword
    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Me.ISPASDataSet.Users)
        UserNameTextBox.Text = User_Name
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.UsersBindingSource.Filter = "(UserName) = '" + UserNameTextBox.Text + "'"
        If UserPasswordTextBox.Text = "" Then
            MsgBox("Enter Old Password")
            UserPasswordTextBox.Focus()
            Exit Sub
        End If
        If NewPasswordTextBox.Text = "" Then
            MsgBox("Enter New Password")
            NewPasswordTextBox.Focus()
            Exit Sub
        End If
        If ConfirmPasswordTextBox.Text = "" Then
            MsgBox("Confirm Password Again")
            ConfirmPasswordTextBox.Focus()
            Exit Sub
        End If
        If NewPasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MsgBox("Confirm Password Not Correct")
            ConfirmPasswordTextBox.Clear()
            ConfirmPasswordTextBox.Focus()
            Exit Sub
        End If
        If NewPasswordTextBox.Text <> Nothing Or ConfirmPasswordTextBox.Text <> Nothing Or NewPasswordTextBox.Text <> Nothing Then
            If Me.UsersBindingSource.Count >= 1 Then
                Dim row As ISPASDataSet.UsersRow
                row = CType(CType(Me.UsersBindingSource.Current, DataRowView).Row, ISPASDataSet.UsersRow)
                If row.UserName.ToLower = UserNameTextBox.Text.ToLower Then
                    If row.UserPassword = UserPasswordTextBox.Text Then
                        row.UserPassword = NewPasswordTextBox.Text.Trim
                        UsersBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
                        MsgBox("Password Changed")
                        ClearTextBox()
                        Me.Close()
                    Else
                        MsgBox("Password Incorrect")
                        ClearTextBox()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub ClearTextBox()
        UserPasswordTextBox.Clear()
        NewPasswordTextBox.Clear()
        ConfirmPasswordTextBox.Clear()
        UserPasswordTextBox.Focus()
    End Sub
End Class