Public Class MainPage
    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to logout?", "Confim logout",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim LoginForm As New loginpage()

        If result = DialogResult.Yes Then

            loginpage.Show()
            Me.Close() 'Close the mainpage
        End If

    End Sub

    Private Sub Mainpanel_Paint(sender As Object, e As PaintEventArgs) Handles Mainpanel.Paint

    End Sub

    Private Sub Btnorder_Click(sender As Object, e As EventArgs) Handles Btnorder.Click
        ' this is to close open forms
        While Me.Mainpanel.Controls.Count > 0
            Me.Mainpanel.Controls(0).Dispose()
        End While

        Dim Order_List As New ORDERlist With {.TopMost = False, .AutoSize = False}
        Order_List.TopLevel = False
        Order_List.WindowState = FormWindowState.Maximized
        Order_List.FormBorderStyle = FormBorderStyle.None
        Order_List.Dock = DockStyle.Fill
        Me.Mainpanel.Controls.Add(Order_List)
        Order_List.Show()
    End Sub

    Private Sub BtnStats_Click(sender As Object, e As EventArgs) Handles BtnStats.Click
        ' this is to close open forms
        While Me.Mainpanel.Controls.Count > 0
            Me.Mainpanel.Controls(0).Dispose()
        End While

        Dim Delivery_Status As New DeliveryStatus With {.TopMost = False, .AutoSize = False}
        Delivery_Status.TopLevel = False
        Delivery_Status.WindowState = FormWindowState.Maximized
        Delivery_Status.FormBorderStyle = FormBorderStyle.None
        Delivery_Status.Dock = DockStyle.Fill
        Me.Mainpanel.Controls.Add(Delivery_Status)
        Delivery_Status.Show()
    End Sub

    Private Sub Btnlog_Click(sender As Object, e As EventArgs) Handles Btnlog.Click
        ' this is to close open forms
        While Me.Mainpanel.Controls.Count > 0
            Me.Mainpanel.Controls(0).Dispose()
        End While

        Dim Sales_Log As New SalesLog With {.TopMost = False, .AutoSize = False}
        Sales_Log.TopLevel = False
        Sales_Log.WindowState = FormWindowState.Maximized
        Sales_Log.FormBorderStyle = FormBorderStyle.None
        Sales_Log.Dock = DockStyle.Fill
        Me.Mainpanel.Controls.Add(Sales_Log)
        Sales_Log.Show()

    End Sub

    Private Sub Panelthrd_Paint(sender As Object, e As PaintEventArgs)


    End Sub

    Private Sub Panelsecnd_Paint(sender As Object, e As PaintEventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class