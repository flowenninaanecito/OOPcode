Public Class ForgotPass
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If txtUname.Text.Trim() = "" Or txtPass.Text.Trim() = "" Or txtCPass.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Continue with save or other operations
        MessageBox.Show("Data submitted successfully!")


        Dim Login As New frmLogin()
        Hide()
        Login.ShowDialog()
    End Sub

    Public Sub clear()
        txtUname.Text = ""
        txtPass.Text = ""
        txtCPass.Text = ""
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim Register As New frmReg()
        Hide()
        Register.ShowDialog()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim Login As New frmLogin()
        Hide()
        Login.ShowDialog()
    End Sub
End Class