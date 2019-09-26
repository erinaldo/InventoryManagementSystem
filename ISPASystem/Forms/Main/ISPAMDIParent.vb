Imports System.Drawing.Drawing2D
'Imports System.IO
'Imports System.Text
Public Class ISPAMDIParent
    'Dim PreviousClickedItem As Windows.Forms.ToolStripMenuItem
    Private Sub ISPAMDIParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mainfrm = Me
        'initAgent()
        'loadaction()
        'With DateAndTime.Today
        '    If (.Day >= 10 And .Month >= 6 And .Year >= 2011) Then
        '        MenuStrip1.Enabled = False
        '        MsgBox("Application Expired Contact The Vendor")
        '    End If
        'End With

        'If User_Name = "" Then User_Name = Strings.UCase("Alameen")
        'UserNameToolStripMenu.Text = User_Name

        'FrmBg.MdiParent = Me
        'FrmBg.WindowState = FormWindowState.Maximized
        'FrmBg.Show()

        'MenuStrip1.Tag = MenuStrip1.BackColor

    End Sub
    'Private Sub MenuStrip_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MenuStrip1.Paint, MenuStrip2.Paint
    '    Dim gp As Graphics = e.Graphics
    '    Dim lgb As New LinearGradientBrush(Me.MenuStrip1.ClientRectangle, Color.LightGray, Color.Gray, LinearGradientMode.Vertical)
    '    gp.FillRectangle(lgb, sender.ClientRectangle)
    'End Sub
#Region "Menu Item"
    Private Sub ProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem.Click
        frmShow(New Products)
    End Sub
    Private Sub ProductsCategoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsCategoriesToolStripMenuItem.Click
        frmShowDialog(New ProductCategory)
    End Sub
    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        frmShow(New frmEmployees)
    End Sub
    Private Sub VendorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorToolStripMenuItem.Click
        frmShow(New frmVendors)
    End Sub
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        frmShow(New frmCustomers)
    End Sub
    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        If User_Name = "Admin".ToLower Then
            frmShow(New FrmUser)
        Else
            MsgBox("Contact The Adminstrator")
        End If
    End Sub
    Private Sub CompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyToolStripMenuItem.Click
        frmShowDialog(New FrmCompany)
    End Sub
    Private Sub StoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StoreToolStripMenuItem.Click
        frmShowDialog(New FrmStore)
    End Sub
    Private Sub CurrencyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrencyToolStripMenuItem.Click
        frmShowDialog(New FrmCurrency)
    End Sub
    Private Sub NewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAccountToolStripMenuItem.Click
        frmShow(New FrmNewAccount)
    End Sub
    Private Sub NewSubHeadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSubHeadToolStripMenuItem.Click
        frmShowDialog(New FrmSubHeads)
    End Sub
    Private Sub NewBackAccouuntToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBackAccouuntToolStripMenuItem.Click
        frmShowDialog(New FrmBankAccount)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub PurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        frmShow(New frmPurchaseOrder)
    End Sub
    Private Sub PurchaseInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseInvoiceToolStripMenuItem.Click
        frmShow(New frmPurchaseInvoice)
    End Sub
    Private Sub SalesInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesInvoiceToolStripMenuItem.Click
        'frmShow(New frmSalesInvoice)
        frmShow(New SalesInvoice)
    End Sub
    Private Sub SalesReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReturnToolStripMenuItem.Click
        frmShowDialog(New frmSalesReturn)
    End Sub
    Private Sub ProductsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem1.Click
        frmShow(New rptProductReport)
    End Sub
    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        frmShow(New rptCustomerReport)
    End Sub
    Private Sub VendorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorsToolStripMenuItem.Click
        frmShow(New frmVendorReportvb)
    End Sub
    Private Sub EmployeeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem1.Click
        frmShow(New rptEmployeeReport)
    End Sub
    Private Sub ChartOfAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartOfAccountToolStripMenuItem.Click
        frmShow(New rptChartOfAccountReport)
    End Sub
    Private Sub LedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgerToolStripMenuItem.Click
        frmShow(New rptLedgerReport)
    End Sub
    Private Sub PurchaseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        frmShow(New rptPurchaseReport)
    End Sub
    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        frmShow(New frmSalesReport)
    End Sub
    Private Sub CashPaymentVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashPaymentVoucherToolStripMenuItem.Click
        frmShow(New frmCashPaymentVoucher)
    End Sub
    Private Sub CashReciptVocherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashReciptVocherToolStripMenuItem.Click
        frmShow(New frmCashRecivedVoucher)
    End Sub
    Private Sub BankPaymentVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankPaymentVoucherToolStripMenuItem.Click
        frmShow(New frmBankPaymentVoucher)
    End Sub
    Private Sub BankReciptVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankReciptVoucherToolStripMenuItem.Click
        frmShow(New frmBankReciptVoucher)
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub MinimizeAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeAllToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.WindowState = FormWindowState.Minimized
        Next
    End Sub
    Private Sub MaximzeAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximzeAllToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.WindowState = FormWindowState.Maximized
        Next
    End Sub
    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Dim ProcID As Integer
        ProcID = Shell("C:\Windows\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Dim ProcID As Integer
        ProcID = Shell("C:\Windows\system32\NotePad.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub WorkOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkOrderToolStripMenuItem.Click
        frmShow(New frmWorkOrder)
    End Sub
    Private Sub DeliveryChallanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryChallanToolStripMenuItem.Click
        frmShow(New FrmDelivery)
    End Sub
    Private Sub QutationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QutationToolStripMenuItem.Click
        frmShow(New frmQuatation)
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.ShowDialog()
    End Sub
#End Region
    'Private Sub ISPAMDIParent_MdiChildActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
    '    If Me.ActiveMdiChild Is Nothing Then
    '        Label1.Text = ""
    '    Else
    '        Label1.Text = Me.ActiveMdiChild.Text

    '    End If
    'End Sub

    'Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    '    If PreviousClickedItem IsNot Nothing Then
    '        PreviousClickedItem.BackColor = MenuStrip1.Tag
    '    End If

    '    e.ClickedItem.BackColor = Color.Gray
    '    'MenuStrip2.BackColor = Color.Gray
    '    MenuStrip2.Items.Clear()
    '    Dim abc As Windows.Forms.ToolStripMenuItem = e.ClickedItem

    '    'For Each x As ToolStripDropDownItem In abc.DropDownItems
    '    '    If x.GetType Is GetType(ToolStripMenuItem) Then
    '    '        Dim y As New ToolStripMenuItem
    '    '        y.Name = x.Name
    '    '        y.Text = x.Text
    '    '        MenuStrip2.Items.Add(y)

    '    '    End If
    '    'Next

    '    For x As Integer = 0 To abc.DropDownItems.Count - 1
    '        Dim y As New ToolStripMenuItem
    '        y.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    '        y.Name = abc.DropDownItems(x).Name
    '        y.Text = abc.DropDownItems(x).Text
    '        'y.DropDown = abc.DropDown

    '        y.Image = abc.DropDownItems(x).Image
    '        MenuStrip2.Items.Add(y)
    '    Next

    '    PreviousClickedItem = e.ClickedItem
    'End Sub
    'Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked
    '    Select Case e.ClickedItem.Name
    '        Case "ProductsToolStripMenuItem"
    '            frmShow(New Products)
    '        Case "ProductsCategoriesToolStripMenuItem"
    '            frmShow(New ProductCategory)
    '        Case "EmployeeToolStripMenuItem"
    '            frmShow(New frmEmployees)
    '        Case "VendorToolStripMenuItem"
    '            frmShow(New frmVendors)
    '        Case "CustomerToolStripMenuItem"
    '            frmShow(New frmCustomers)
    '        Case "CompanyToolStripMenuItem"
    '            frmShow(New FrmCompany)
    '        Case "StoreToolStripMenuItem"
    '            frmShow(New FrmStore)
    '        Case "CurrencyToolStripMenuItem"
    '            frmShow(New FrmCurrency)
    '        Case "NewAccountToolStripMenuItem"
    '            frmShow(New FrmNewAccount)
    '        Case "NewSubHeadToolStripMenuItem"
    '            frmShow(New FrmSubHeads)
    '        Case "NewBackAccouuntToolStripMenuItem"
    '            frmShow(New FrmBankAccount)
    '        Case "ExitToolStripMenuItem"
    '            Me.Close()
    '        Case "PurchaseOrderToolStripMenuItem"
    '            frmShow(New frmPurchaseOrder)
    '        Case "PurchaseInvoiceToolStripMenuItem"
    '            frmShow(New frmPurchaseInvoice)
    '        Case "SalesInvoiceToolStripMenuItem"
    '            frmShow(New SalesInvoice)
    '        Case "SalesReturnToolStripMenuItem"
    '            frmShow(New frmSalesReport)
    '        Case "ProductsToolStripMenuItem1"
    '            frmShow(New rptProductReport)
    '        Case "CustomerToolStripMenuItem1"
    '            frmShow(New rptCustomerReport)
    '        Case "VendorsToolStripMenuItem"
    '            frmShow(New frmVendorReportvb)
    '        Case "EmployeeToolStripMenuItem1"
    '            frmShow(New rptEmployeeReport)
    '        Case "ChartOfAccountToolStripMenuItem"
    '            frmShow(New rptChartOfAccountReport)
    '        Case "LedgerToolStripMenuItem"
    '            frmShow(New rptLedgerReport)
    '        Case "PurchaseReportToolStripMenuItem"
    '            frmShow(New rptPurchaseReport)
    '        Case "SalesReportToolStripMenuItem"
    '            frmShow(New frmSalesReport)
    '        Case "CashPaymentVoucherToolStripMenuItem"
    '            frmShow(New frmCashPaymentVoucher)
    '        Case "CashReciptVocherToolStripMenuItem"
    '            frmShow(New frmCashRecivedVoucher)
    '        Case "BankPaymentVoucherToolStripMenuItem"
    '            frmShow(New frmBankPaymentVoucher)
    '        Case "BankReciptVoucherToolStripMenuItem"
    '            frmShow(New frmBankReciptVoucher)
    '        Case "WorkOrderToolStripMenuItem"
    '            frmShow(New frmWorkOrder)
    '        Case "DeliveryChallanToolStripMenuItem"
    '            frmShow(New FrmDelivery)
    '        Case "QutationToolStripMenuItem"
    '            frmShow(New frmQuatation)
    '        Case Else
    '            'MsgBox("Under Developement")
    '    End Select
    'End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    If (Panel2.Width = 30) Then
    '        Panel2.Width = 200
    '    ElseIf (Panel2.Width = 200) Then
    '        Panel2.Width = 30
    '    End If
    'End Sub
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        If Me.ActiveMdiChild Is Nothing Then

        Else
            Me.ActiveMdiChild.Close()
        End If
    End Sub
End Class