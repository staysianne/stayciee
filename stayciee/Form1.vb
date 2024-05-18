Public Class loginpage
    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        If TxtUsername.Text = "mamarose_lomi" And TxtPassword.Text = "lomihouse" Then
            MsgBox("You login successfully")
            MainPage.Show()
            Me.Hide() ' Hide the Loginpage
            '
        Else
            MsgBox("Invalid username or password")

        End If

    End Sub

    Private Sub loginpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.KeyPreview = True

    End Sub

    Private Sub loginpage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btnlogin.PerformClick()
        End If
    End Sub
End Class
