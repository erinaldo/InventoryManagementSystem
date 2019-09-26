Public Class EmiCalcfrom

    Private Sub PTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTextBox.TextChanged
        Dim x As Decimal
        If PTextBox.Text = "" Then
            PTextBox.Text = "0"
            PTextBox.Focus()
            PTextBox.SelectAll()
        End If

        If PTextBox.Text > 30000 Then
            x = (PTextBox.Text * (3 / 100))
            If x > 1060 Then
                DCTextBox.Text = x
            End If
        Else
            DCTextBox.Text = 1100
        End If

        TTextBox.Text = PTextBox.Text * (RTextBox.Text / 100)
        EMITextBox.Text = ((TTextBox.Text * CRTextBox.Text) + PTextBox.Text) / MTextBox.Text
        IPTextBox.Text = (EMITextBox.Text * IMTextBox.Text) + DCTextBox.Text

    End Sub

    Private Sub EMITextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMITextBox.TextChanged
        EMITextBox.Text = Math.Round(Convert.ToDecimal(EMITextBox.Text))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Emifrm1.ShowDialog()
    End Sub

    Private Sub IPTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPTextBox.TextChanged
        IPTextBox.Text = Math.Round(Convert.ToDecimal(IPTextBox.Text))
    End Sub

    Private Sub DCTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DCTextBox.TextChanged
        DCTextBox.Text = Math.Round(Convert.ToDecimal(DCTextBox.Text))
    End Sub

    Private Sub EMICalcBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMICalcBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMICalcBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EMICalcDataSet)

    End Sub

    Private Sub EmiCalcfrom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMICalcDataSet.EMIScheme' table. You can move, or remove it, as needed.
        Me.EMISchemeTableAdapter.Fill(Me.EMICalcDataSet.EMIScheme)
        'TODO: This line of code loads data into the 'EMICalcDataSet.EMICalc' table. You can move, or remove it, as needed.
        Me.EMICalcTableAdapter.Fill(Me.EMICalcDataSet.EMICalc)

    End Sub



End Class