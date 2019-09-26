Module GlobalFunction
    Friend Mainfrm As Windows.Forms.Form
    Public User_ID As Integer
    Public User_Name As String

    Public Sub frmShow(ByVal frm As System.Windows.Forms.Form)
        frm.MdiParent = Mainfrm
        frm.Height = Mainfrm.Height - 10
        frm.Width = Mainfrm.Width - 10
        frm.KeyPreview = True
        'AddHandler frm.KeyDown, AddressOf Form1_KeyDown
        frm.ControlBox = False
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
        frm.Activate()
    End Sub

    Public Sub frmShowDialog(ByVal frm As System.Windows.Forms.Form)
        frm.ShowInTaskbar = False
        frm.WindowState = FormWindowState.Normal
        frm.FormBorderStyle = FormBorderStyle.FixedDialog
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.ShowDialog()
    End Sub

    Friend Function AmountInWord(ByVal str As String) As String
        Dim mystr As String
        If IsNumeric(str) = False Then
            mystr = "Error In Input"
        Else
            mystr = "Rupees. "
            For tx = 0 To str.Length - 1
                'TextBox1.Text.Chars(tx)

                Select Case str.Chars(tx)
                    Case "1"
                        mystr += "One "
                    Case "2"
                        mystr += "Two "
                    Case "3"
                        mystr += "Three "
                    Case "4"
                        mystr += "Four "
                    Case "5"
                        mystr += "Five "
                    Case "6"
                        mystr += "Six "
                    Case "7"
                        mystr += "Seven "
                    Case "8"
                        str += "Eight "
                    Case "9"
                        mystr += "Nine "
                    Case "0"
                        mystr += "Zero "
                    Case "."
                        mystr += "and Paise. "

                End Select
            Next
        End If
        Return mystr.Trim
    End Function

    Public Sub Print(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportClass, ByVal str As String)
        Try
            Dim frm As frmReport = New frmReport
            frm.MdiParent = Mainfrm
            frm.Show()
            frm.CrystalReportViewer1.SelectionFormula = str
            frm.CrystalReportViewer1.Refresh()
            frm.CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        e.Handled = True
    '    End If
    'End Sub


End Module
