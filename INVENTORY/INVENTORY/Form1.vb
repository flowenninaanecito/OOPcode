Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim conn As New MySqlConnection("server=127.0.0.1;port=3307;user=root;password=;database=crud")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM tbl_user WHERE UNAME=@UNAME AND PASSWORD=@PASSWORD"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UNAME", txtUname.Text)
                cmd.Parameters.AddWithValue("@PASSWORD", txtPass.Text) ' For production, use hashed passwords

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then

                        Dim modalForm1 As New frmInventory()
                        Hide()
                        modalForm1.ShowDialog()
                        ' Proceed to the next form or action
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim Register As New frmReg()
        Hide()
        Register.ShowDialog()
    End Sub
End Class
