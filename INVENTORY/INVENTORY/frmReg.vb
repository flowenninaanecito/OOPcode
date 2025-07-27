Imports MySql.Data.MySqlClient
Public Class frmReg
    Dim conn As New MySqlConnection("server=127.0.0.1;port=3307;user=root;password=;database=crud")
    Dim i As Integer
    Dim dr As MySqlDataReader

    'SAVE
    Public Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_user`(LNAME, FNAME, MNAME, SEX, CONTACTNUM, ADDRESS, BDATE, AGE, CIVILSTAT, DESIGNATION, EMAILADD, UNAME, PASSWORD, CONPASS) VALUES (@LNAME, @FNAME, @MNAME, @SEX, @CONTACTNUM, @ADDRESS, @BDATE, @AGE, @CIVILSTAT, @DESIGNATION, @EMAILADD, @UNAME, @PASSWORD, @CONPASS)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@LNAME", txtLname.Text)
            cmd.Parameters.AddWithValue("@FNAME", txtFname.Text)
            cmd.Parameters.AddWithValue("@MNAME", txtMname.Text)

            cmd.Parameters.AddWithValue("@SEX", chkSex.Text)
            cmd.Parameters.AddWithValue("@CONTACTNUM", txtContactNum.Text)
            cmd.Parameters.AddWithValue("@ADDRESS", txtAddress.Text)
            cmd.Parameters.AddWithValue("@BDATE", CDate(CDdate.Value))

            cmd.Parameters.AddWithValue("@AGE", txtAge.Text)
            cmd.Parameters.AddWithValue("@CIVILSTAT", txtCStat.Text)
            cmd.Parameters.AddWithValue("@DESIGNATION", txtDesig.Text)

            cmd.Parameters.AddWithValue("@EMAILADD", txtEAdd.Text)
            cmd.Parameters.AddWithValue("@UNAME", txtUname.Text)
            cmd.Parameters.AddWithValue("@PASSWORD", txtPass.Text)
            cmd.Parameters.AddWithValue("@CONPASS", txtConPass.Text)

            ' Validate input
            If String.IsNullOrWhiteSpace(txtLname.Text) Or String.IsNullOrWhiteSpace(txtFname.Text) Or String.IsNullOrWhiteSpace(txtMname.Text) Or String.IsNullOrWhiteSpace(txtAddress.Text) Or String.IsNullOrWhiteSpace(txtContactNum.Text) Or String.IsNullOrWhiteSpace(txtCStat.Text) Or String.IsNullOrWhiteSpace(txtDesig.Text) Or String.IsNullOrWhiteSpace(txtEAdd.Text) Or String.IsNullOrWhiteSpace(txtPass.Text) Or String.IsNullOrWhiteSpace(txtConPass.Text) Or String.IsNullOrWhiteSpace(chkSex.Text) Or String.IsNullOrWhiteSpace(CDate(CDdate.Value)) Then
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            Else
                MessageBox.Show("Record Save Failed!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Shared Sub NewMethod(count As Integer)
        If count > 0 Then
            MessageBox.Show("Username already exists. Please choose another.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub
    'REGISTER
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        save()
    End Sub


    'CLEAR
    Public Sub clear()
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        txtAddress.Clear()
        txtAge.Clear()
        txtContactNum.Clear()
        txtCStat.Clear()
        txtDesig.Clear()
        txtEAdd.Clear()
        txtUname.Clear()
        txtPass.Clear()
        txtConPass.Clear()
        chkSex.Text = ""
        CDdate.Value = Now
    End Sub

    'CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    'LOGIN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim modalForm1 As New frmLogin()
        Hide()
        modalForm1.ShowDialog()
    End Sub

End Class