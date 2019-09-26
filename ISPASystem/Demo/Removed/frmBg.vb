Public Class FrmBg

    Private Sub PurchaseOrderLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PurchaseOrderLinkLabel.LinkClicked
        frmPurchaseOrder.MdiParent = ISPAMDIParent
        frmPurchaseOrder.Show()
        frmPurchaseOrder.Activate()
    End Sub

End Class