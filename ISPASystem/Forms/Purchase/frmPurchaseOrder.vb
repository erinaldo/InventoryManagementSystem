Public Class frmPurchaseOrder
    Dim newID As Integer = 0
    Dim New_Flag As Boolean = False
    Dim UnitPrice As Double
#Region "Loading"
    Private Sub frmPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AD_VendorsTableAdapter.Fill(Me.ISPASDataSet.AD_Vendors)
        Me.AD_ProductsTableAdapter.Fill(Me.ISPASDataSet.AD_Products)
        Me.POrder_MainTableAdapter.Fill(Me.ISPASDataSet.POrder_Main)
        Me.POrder_DetailsTableAdapter.Fill(Me.ISPASDataSet.POrder_Details)
    End Sub
#End Region
#Region "Binding Navigation"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        New_Flag = True
        If Panel1.Enabled = False Then
            Panel1.Enabled = True
        End If
        Me.POrder_MainBindingSource.MoveLast()
        Dim row As ISPASDataSet.POrder_MainRow

        If Me.POrder_MainBindingSource.Current Is Nothing Then
            newID = 1
        Else
            row = CType(CType(Me.POrder_MainBindingSource.Current, DataRowView).Row, ISPASDataSet.POrder_MainRow)
            newID = row.POrderNo + 1
        End If

        DataGridView1.Visible = True
    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If Panel1.Enabled = True Then
            Panel1.Enabled = False
        End If
        For x = 0 To POrder_DetailsBindingSource.Count - 1
            POrder_DetailsBindingSource.MoveFirst()
            POrder_DetailsBindingSource.RemoveCurrent()
        Next
        Me.POrder_DetailsBindingSource.EndEdit()
    End Sub
    Private Sub POrder_MainBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POrder_MainBindingNavigatorSaveItem.Click
        If Panel1.Enabled = False Then
            Panel1.Enabled = True
        End If
        Me.Validate()
        If New_Flag = True Then
            New_Flag = False
            POrderNoTextBox.Text = newID
            POrder_DetailsBindingSource.MoveFirst()
            For x = 0 To DataGridView1.Rows.Count - 1
                Dim row As ISPASDataSet.POrder_DetailsRow
                row = CType(CType(Me.POrder_DetailsBindingSource.Current, DataRowView).Row, ISPASDataSet.POrder_DetailsRow)

                row.POrderNo = newID
                row.ProdTitle = DataGridView1.Rows(x).Cells(2).Value
                row.Quantity = DataGridView1.Rows(x).Cells(3).Value
                row.UnitPrice = DataGridView1.Rows(x).Cells(4).Value
                row.TotalCost = DataGridView1.Rows(x).Cells(5).Value
                POrder_DetailsBindingSource.MoveNext()
            Next
            Me.POrder_DetailsBindingSource.EndEdit()



            DataGridView1.Rows.Clear()
            DataGridView1.Visible = False
        End If
        Me.POrder_MainBindingSource.EndEdit()
        Me.POrder_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ISPASDataSet)
        MsgBox("Update Sucessful")
        Print()
    End Sub
    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Print()
    End Sub
#End Region
#Region "Details"
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If DataGridView1.Visible = True Then AD_ProductsDataGridView.Visible = True
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        AD_ProductsDataGridView.Visible = False
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Down Then
            If AD_ProductsDataGridView.CurrentCell.RowIndex = AD_ProductsDataGridView.Rows.Count - 1 Then
                e.Handled = True
            Else
                AD_ProductsDataGridView.CurrentCell = AD_ProductsDataGridView.Rows(AD_ProductsDataGridView.CurrentCell.RowIndex + 1).Cells(0)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If AD_ProductsDataGridView.CurrentCell.RowIndex > 0 Then
                AD_ProductsDataGridView.CurrentCell = AD_ProductsDataGridView.Rows(AD_ProductsDataGridView.CurrentCell.RowIndex - 1).Cells(0)
            Else
                e.Handled = True
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            Dim row As ISPASDataSet.AD_ProductsRow
            row = CType(CType(Me.AD_ProductsBindingSource.Current, DataRowView).Row, ISPASDataSet.AD_ProductsRow)
            TextBox1.Text = row.ProdTitle.ToString
            UnitPrice = row.UnitPrice
            TextBox2.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            AD_ProductsDataGridView.Visible = False
            DataGridView1.Focus()
        End If

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        AD_ProductsBindingSource.Filter = "ProdTitle LIKE '" + TextBox1.Text + "' + '%' "
    End Sub
    Private Sub AD_ProductsDataGridView_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AD_ProductsDataGridView.GotFocus
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Dim match As Boolean = False

        If e.KeyCode = Keys.Enter Then

            For i As Integer = 0 To Me.DataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible)
                If DataGridView1.Rows(i).Cells(2).Value.ToString = TextBox1.Text Then
                    match = True
                    If TotalAmountTextBox.Text = "" Then
                        TotalAmountTextBox.Text = 0
                    End If
                    If TextBox2.Text = "" Then
                        TextBox2.Text = 1
                    End If
                    DataGridView1.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value + Convert.ToInt32(TextBox2.Text)
                    DataGridView1.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(3).Value * DataGridView1.Rows(i).Cells(4).Value
                    TotalAmountTextBox.Text = Convert.ToDouble(TotalAmountTextBox.Text) + (Convert.ToInt32(TextBox2.Text) * DataGridView1.Rows(i).Cells(4).Value)

                    Exit For
                End If

            Next

            If match = False Then
                Me.POrder_DetailsBindingSource.AddNew()

                Me.DataGridView1.Rows.Add()

                Dim ri As Integer = Me.DataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible)

                DataGridView1.Rows(ri).Cells(1).Value = newID
                DataGridView1.Rows(ri).Cells(2).Value = TextBox1.Text
                If TextBox2.Text = "" Then
                    TextBox2.Text = 1
                End If
                DataGridView1.Rows(ri).Cells(3).Value = TextBox2.Text
                DataGridView1.Rows(ri).Cells(4).Value = UnitPrice
                DataGridView1.Rows(ri).Cells(5).Value = TextBox2.Text * UnitPrice

                If TotalAmountTextBox.Text = "" Then
                    TotalAmountTextBox.Text = 0
                End If
                TotalAmountTextBox.Text = Convert.ToDouble(TotalAmountTextBox.Text) + (TextBox2.Text * UnitPrice)
            End If

            match = False
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then TotalAmountTextBox.Text = Convert.ToDouble(TotalAmountTextBox.Text) - Convert.ToDouble(DataGridView1.CurrentRow.Cells(5).Value)
        If e.KeyCode = Keys.Escape Then TextBox1.Focus()
    End Sub

    Private Sub TotalAmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalAmountTextBox.TextChanged
        Label2.Text = "Rs." + TotalAmountTextBox.Text
    End Sub

    Private Sub POrder_DetailsDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles POrder_DetailsDataGridView.CellDoubleClick
        POrder_DetailsDataGridView.Enabled = False
        Panel1.Visible = True
    End Sub
    Private Sub QuantityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityTextBox.TextChanged
        If QuantityTextBox.Text = "" Then
            QuantityTextBox.Text = 1
            QuantityTextBox.SelectAll()
        End If
        TotalCostTextBox.Text = QuantityTextBox.Text * UnitPriceTextBox.Text
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total As Integer = 0
        For x = 0 To POrder_DetailsDataGridView.Rows.GetLastRow(DataGridViewElementStates.Visible)
            total = total + POrder_DetailsDataGridView.Rows(x).Cells(5).Value()
        Next
        TotalAmountTextBox.Text = total
        Me.POrder_DetailsBindingSource.EndEdit()
        POrder_DetailsDataGridView.Enabled = True
        Panel1.Visible = False
    End Sub
#End Region
#Region "Print"
    Private Sub Print()
        Try

            Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo
            Dim paramFields As CrystalDecisions.Shared.ParameterFields = New CrystalDecisions.Shared.ParameterFields()
            Dim paramField As CrystalDecisions.Shared.ParameterField = New CrystalDecisions.Shared.ParameterField()
            Dim paramValue1 As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()
            Dim paramValue2 As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()

            Dim rpt As PurchaseOrderPrint = New PurchaseOrderPrint
            Dim frm As frmReport = New frmReport

            For Each myTabel As CrystalDecisions.CrystalReports.Engine.Table In rpt.Database.Tables
                myLogin = myTabel.LogOnInfo
                myLogin.ConnectionInfo.UserID = ""
                myLogin.ConnectionInfo.Password = ""
                myLogin.ConnectionInfo.ServerName = Application.StartupPath + "\\ISPASystem.mdb"
                myTabel.ApplyLogOnInfo(myLogin)

            Next

            frm.MdiParent = Me.MdiParent
            frm.Show()

            ''The first parameter date
            'paramField.ParameterFieldName = "@FromDate"
            ''Setting the first discrete value and passing it to the parameter
            'paramValue1.Value = POrderDateDateTimePicker.Value.ToShortDateString()
            'paramField.CurrentValues.Add(paramValue1)
            ''Add the parameter fields to the parameter fields collection
            'paramFields.Add(paramField)

            ''The second parameter date
            'paramField = New CrystalDecisions.Shared.ParameterField()
            'paramField.ParameterFieldName = "@ToDate"
            ''Setting the first discrete value and passing it to the parameter
            'paramValue2.Value = POrderDateDateTimePicker.Value.ToShortDateString()
            'paramField.CurrentValues.Add(paramValue2)
            ''Add the parameter fields to the parameter fields collection
            'paramFields.Add(paramField)

            ''Set the parameter fields collection into the crystal report viewer
            'frm.CrystalReportViewer1.ParameterFieldInfo = paramFields

            'frm.CrystalReportViewer1.SelectionFormula = "{POrder_Main.POrderNo} ='" + POrderNoTextBox.Text + "' and {POrder_Details.POrderNo} ='" + POrderNoTextBox.Text + "'"
            frm.CrystalReportViewer1.SelectionFormula = "{POrder_Main.POrderNo} = " + POrderNoTextBox.Text.Trim
            frm.CrystalReportViewer1.Refresh()
            frm.CrystalReportViewer1.ReportSource = rpt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If ToolStripButton1.Text = "Print" Then
        '    ToolStripButton1.Text = "Close"
        '    SplitContainer1.Panel1Collapsed = True
        '    Me.POrder_MainTableAdapter.FillByPorder(Me.ISPASDataSet.POrder_Main, POrderNoTextBox.Text)
        '    Me.POrder_DetailsTableAdapter.Fill(Me.ISPASDataSet.POrder_Details)
        '    PurchaseOrderPrint1.SetDataSource(ISPASDataSet)
        '    CrystalReportViewer1.RefreshReport()
        'ElseIf ToolStripButton1.Text = "Close" Then
        '    ToolStripButton1.Text = "Print"
        '    SplitContainer1.Panel2Collapsed = True
        '    Me.POrder_MainTableAdapter.Fill(Me.ISPASDataSet.POrder_Main)
        '    Me.POrder_DetailsTableAdapter.Fill(Me.ISPASDataSet.POrder_Details)
        'End If

    End Sub
#End Region
End Class