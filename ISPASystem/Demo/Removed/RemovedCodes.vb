Module RemovedCodes

#Region "To Print the content of datagrid to a text file"
    'Imports System.IO
    'Imports System.Text
    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Dim fw As StreamWriter
    '    Dim str As New StringBuilder

    '    Try
    '        fw = New StreamWriter("C:\print.txt", False)
    '        For i As Integer = 0 To AD_ProductsDataGridView.Rows.Count - 1 Step 1
    '            For j As Integer = 0 To AD_ProductsDataGridView.Columns.Count - 1 Step 1
    '                str.Append(AD_ProductsDataGridView.Rows(i).Cells(j).Value)
    '                str.Append(Strings.Chr(9))

    '            Next
    '            str.AppendLine()

    '        Next
    '        fw.Write(str)
    '    Finally
    '        fw.Close()
    '        Dim ProcID As Integer
    '        ProcID = Shell("C:\Windows\system32\notepad.exe C:\print.txt", AppWinStyle.NormalFocus)

    '    End Try
    'End Sub
#Region "Some Modification"
    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Dim fw As StreamWriter
    '    Dim str As New StringBuilder

    '    Try
    '        fw = New StreamWriter("C:\print.txt", False)
    '        str.Append("-------------------------------------------------------------------------")
    '        str.AppendLine()
    '        For i As Integer = 0 To AD_ProductsDataGridView.Rows.Count - 1 Step 1
    '            For j As Integer = 0 To AD_ProductsDataGridView.Columns.Count - 1 Step 1
    '                'str.Append(AD_ProductsDataGridView.Rows(i).Cells(j).Value)
    '                'str.Append(Strings.Chr(9))
    '                Select Case j
    '                    Case 0
    '                        str.Append(Strings.FormatDateTime(AD_ProductsDataGridView.Rows(i).Cells(j).Value, DateFormat.ShortDate))
    '                    Case 1
    '                        Dim x As Integer = (AD_ProductsDataGridView.Rows(i).Cells(j).Value).ToString.Length
    '                        If x > 30 Then
    '                            str.Append(Strings.Left(AD_ProductsDataGridView.Rows(i).Cells(j).Value, 25))
    '                        ElseIf x < 30 Then
    '                            str.Append(AD_ProductsDataGridView.Rows(i).Cells(j).Value)
    '                            str.Append(Strings.Space(30 - x))

    '                        End If
    '                    Case 2
    '                        str.Append(Strings.FormatNumber(AD_ProductsDataGridView.Rows(i).Cells(j).Value, 2))
    '                    Case 3
    '                        str.Append(Strings.FormatNumber(AD_ProductsDataGridView.Rows(i).Cells(j).Value, 2))
    '                End Select
    '                str.Append(Strings.Chr(9))
    '            Next
    '            str.AppendLine()
    '        Next
    '        str.Append("-------------------------------------------------------------------------")
    '        fw.Write(str)
    '    Finally
    '        fw.Close()
    '        Dim ProcID As Integer
    '        ProcID = Shell("C:\Windows\system32\notepad.exe C:\print.txt", AppWinStyle.NormalFocus)

    '    End Try
    'End Sub
#End Region
#End Region


#Region "Painting a control with gradient color"
    'Imports System.Drawing.Drawing2D
    'Private Sub AD_CustomersBindingNavigator_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles AD_CustomersBindingNavigator.Paint
    '    Dim gp As Graphics = e.Graphics

    '    Dim lgb As New LinearGradientBrush(Me.AD_CustomersBindingNavigator.ClientRectangle, Color.LightSkyBlue, Color.LightBlue, LinearGradientMode.Vertical)

    '    gp.FillRectangle(lgb, Me.AD_CustomersBindingNavigator.ClientRectangle)
    'End Sub
#End Region


#Region "Crystal Report Printing"
    'Private Sub Print()
    '    Try

    '        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo
    '        Dim paramFields As CrystalDecisions.Shared.ParameterFields = New CrystalDecisions.Shared.ParameterFields()
    '        Dim paramField As CrystalDecisions.Shared.ParameterField = New CrystalDecisions.Shared.ParameterField()
    '        Dim paramValue1 As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()
    '        Dim paramValue2 As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()

    '        Dim rpt As rptPurchaseInvoice = New rptPurchaseInvoice
    '        Dim frm As frmReport = New frmReport

    '        For Each myTabel As CrystalDecisions.CrystalReports.Engine.Table In rpt.Database.Tables
    '            myLogin = myTabel.LogOnInfo
    '            myLogin.ConnectionInfo.UserID = ""
    '            myLogin.ConnectionInfo.Password = ""
    '            myLogin.ConnectionInfo.ServerName = Application.StartupPath + "\\ISPASystem.mdb"
    '            myTabel.ApplyLogOnInfo(myLogin)

    '        Next

    '        frm.MdiParent = Me.MdiParent
    '        frm.Show()

    '        ''The first parameter date
    '        'paramField.ParameterFieldName = "@FromDate"
    '        ''Setting the first discrete value and passing it to the parameter
    '        'paramValue1.Value = POrderDateDateTimePicker.Value.ToShortDateString()
    '        'paramField.CurrentValues.Add(paramValue1)
    '        ''Add the parameter fields to the parameter fields collection
    '        'paramFields.Add(paramField)

    '        ''The second parameter date
    '        'paramField = New CrystalDecisions.Shared.ParameterField()
    '        'paramField.ParameterFieldName = "@ToDate"
    '        ''Setting the first discrete value and passing it to the parameter
    '        'paramValue2.Value = POrderDateDateTimePicker.Value.ToShortDateString()
    '        'paramField.CurrentValues.Add(paramValue2)
    '        ''Add the parameter fields to the parameter fields collection
    '        'paramFields.Add(paramField)

    '        ''Set the parameter fields collection into the crystal report viewer
    '        'frm.CrystalReportViewer1.ParameterFieldInfo = paramFields

    '        'frm.CrystalReportViewer1.SelectionFormula = "{POrder_Main.POrderNo} ='" + POrderNoTextBox.Text + "' and {POrder_Details.POrderNo} ='" + POrderNoTextBox.Text + "'"
    '        frm.CrystalReportViewer1.SelectionFormula = "{PInvoice_Main.PInvNo} = " + PInvNoTextBox.Text.Trim
    '        frm.CrystalReportViewer1.Refresh()
    '        frm.CrystalReportViewer1.ReportSource = rpt

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    'If ToolStripButton1.Text = "Print" Then
    '    '    ToolStripButton1.Text = "Close"
    '    '    SplitContainer1.Panel1Collapsed = True
    '    '    Me.POrder_MainTableAdapter.FillByPorder(Me.ISPASDataSet.POrder_Main, POrderNoTextBox.Text)
    '    '    Me.POrder_DetailsTableAdapter.Fill(Me.ISPASDataSet.POrder_Details)
    '    '    PurchaseOrderPrint1.SetDataSource(ISPASDataSet)
    '    '    CrystalReportViewer1.RefreshReport()
    '    'ElseIf ToolStripButton1.Text = "Close" Then
    '    '    ToolStripButton1.Text = "Print"
    '    '    SplitContainer1.Panel2Collapsed = True
    '    '    Me.POrder_MainTableAdapter.Fill(Me.ISPASDataSet.POrder_Main)
    '    '    Me.POrder_DetailsTableAdapter.Fill(Me.ISPASDataSet.POrder_Details)
    '    'End If

    'End Sub
#End Region

#Region "Desktop Wallpaper"
    'Public Sub backgroud()
    '    Dim readValue As String = My.Computer.Registry.GetValue _
    '       ("HKEY_CURRENT_USER\Control Panel\Desktop", "Wallpaper", Nothing)
    '    Dim image1 As Bitmap = New Bitmap(readValue, True)
    '    Mainfrm.BackgroundImage = image1
    'End Sub
#End Region
End Module
