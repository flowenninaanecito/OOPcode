Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUname.Text.Trim() = "" Or txtPass.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Continue with save or other operations
        MessageBox.Show("Data submitted successfully!")


        Dim About As New AboutBox1()
        Hide()
        About.ShowDialog()
    End Sub
    Public Sub clear()
        txtUname.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim Register As New frmReg()
        Hide()
        Register.ShowDialog()
    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        Dim Forgot As New ForgotPass()
        Hide()
        Forgot.ShowDialog()
    End Sub

    Private Sub txtUname_TextChanged(sender As Object, e As EventArgs) Handles txtUname.TextChanged

    End Sub
End Class