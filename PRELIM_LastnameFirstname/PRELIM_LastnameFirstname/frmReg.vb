Public Class frmReg
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Public Sub clear()
        txtName.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtUname.Text = ""
        txtPass.Text = ""
        txtCPass.Text = ""
    End Sub


    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If txtUname.Text.Trim() = "" Or txtPass.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Continue with save or other operations
        MessageBox.Show("Data submitted successfully!")

        MessageBox.Show(txtName.Text & " " & txtAddress.Text & " " & txtContact.Text & " " & txtUname.Text & " " & txtPass.Text & " " & txtCPass.Text, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim Login As New frmLogin()
        Hide()
        Login.ShowDialog()


    End Sub

End Class
