Module ModMenuSetting
    

    'Public Sub user_rightss(ByVal comp_name As String, ByVal usernm As String)
    '    Dim i As Integer

    '    If (ConnectionState.Open = ConnectionState.Open) Then
    '        MainDB.Close()
    '    End If
    '    MainDB.Open()
    '    Dim tl As New ToolStripMenuItem
    '    cmd = New SqlCommand()
    '    cmd.CommandText = "select MenuName from Menu_Master where menuID in (select Menu_ID from UserAccessRights_Details where User_ID in (select UserID from User_Master where UserName='" & usernm.Trim() & "') and Company_Id in (select Company_Code from Company_Details where Company_Name='" & comp_name.Trim() & "') and Rights=1) "
    '    cmd.Connection = MainDB
    '    sqlda = New SqlDataAdapter(cmd)
    '    menu_ds = New DataSet
    '    sqlda.Fill(menu_ds)

    '    Dim MenuStp As MenuStrip
    '    Dim i1 As Integer
    '    MenuStp = frmMain.MenuStrip
    '    Dim c As ToolStripItem
    '    Dim flag As Integer = 0
    '    Dim l_flag As Integer = 0

    '    For Each c In MenuStp.Items
    '        If c.GetType Is GetType(ToolStripMenuItem) Then
    '            tl = c

    '            For i = 0 To tl.DropDownItems.Count - 1
    '                For i1 = 0 To menu_ds.Tables(0).Rows.Count - 1
    '                    If (menu_ds.Tables(0).Rows(i1).Item(0).ToString().ToUpper() = tl.DropDownItems.Item(i).Name.ToUpper()) Then
    '                        tl.DropDownItems.Item(i).Visible = True
    '                        flag = 1
    '                        l_flag = 1
    '                    End If
    '                Next
    '                If (flag = 1) Then
    '                    tl.DropDownItems.Item(i).Visible = True
    '                    flag = 0
    '                Else
    '                    tl.DropDownItems.Item(i).Visible = False
    '                End If
    '            Next
    '        End If
    '        If (l_flag = 0) Then
    '            tl.Visible = False
    '        Else
    '            tl.Visible = True
    '        End If
    '        l_flag = 0
    '        flag = 0
    '    Next
    'End Sub




End Module
