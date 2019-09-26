Public Class FrmCompany
    Private Sub FrmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CompanyTableAdapter.Fill(Me.ISPASDataSet.Company)
        If CompanyBindingSource.Count = 0 Then
            CompanyBindingSource.AddNew()
            CompanyNameTextBox.ReadOnly = False
            AddressTextBox.ReadOnly = False
            TelTextBox.ReadOnly = False
        End If
    End Sub
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Me.Validate()
        Me.CompanyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("Company Details Updated Sucessfully")
        Me.Close()
    End Sub
    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.CompanyBindingSource.CancelEdit()
        Me.Close()
    End Sub
    Private Sub FrmCompany_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CompanyNameTextBox.Text = "" Then
            e.Cancel = True
            MsgBox("Enter Company Name")
            CompanyNameTextBox.Focus()
        End If
    End Sub
End Class