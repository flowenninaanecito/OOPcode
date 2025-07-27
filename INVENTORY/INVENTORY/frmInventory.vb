Imports MySql.Data.MySqlClient
Public Class frmInventory
    Dim conn As New MySqlConnection("server=127.0.0.1;port=3307;user=root;password=;database=crud")
    Dim i As Integer
    Dim dr As MySqlDataReader
    'Data Grid
    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_crud_inventory", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("CATEGORY"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    'Save
    Public Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_crud_inventory`(PRODUCTNO, PRODUCTNAME, PRICE, CATEGORY, EXPDATE,STATUS) VALUES (@PRODUCTNO,@PRODUCTNAME,@PRICE,@CATEGORY,@EXPDATE,@STATUS)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txtProdNo.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txtProdName.Text)
            cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text)
            cmd.Parameters.AddWithValue("@CATEGORY", txtProdCategory.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(Expiredate.Value))
            cmd.Parameters.AddWithValue("@STATUS", CBool(chkAvail.Checked.ToString))

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub

    'Clear
    Public Sub clear()
        txtProdNo.Clear()
        txtProdName.Clear()
        txtPrice.Clear()
        txtProdCategory.Text = ""
        Expiredate.Value = Now
        chkAvail.CheckState = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        DGV_load()
    End Sub

    'Edit
    Public Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_crud_inventory` SET `PRODUCTNAME`=@PRODUCTNAME, `PRICE`=@PRICE, `CATEGORY`=@CATEGORY, `EXPDATE`=@EXPDATE, `STATUS`=@STATUS WHERE `PRODUCTNO`=@PRODUCTNO", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txtProdNo.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txtProdName.Text)
            cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text)
            cmd.Parameters.AddWithValue("@CATEGORY", txtProdCategory.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(Expiredate.Value))
            cmd.Parameters.AddWithValue("@STATUS", CBool(chkAvail.Checked.ToString))

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record UPDATE Success !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record UPDATE Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        DGV_load()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtProdNo.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtProdName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtPrice.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtProdCategory.Text = DataGridView1.CurrentRow.Cells(3).Value
        Expiredate.Text = DataGridView1.CurrentRow.Cells(4).Value
        chkAvail.Checked = DataGridView1.CurrentRow.Cells(5).Value
        btnSave.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Edit()
    End Sub
    Public Sub delete()
        If MsgBox("Are You Sure You Want to DELETE this Record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `tbl_crud_inventory` WHERE `PRODUCTNO`=@PRODUCTNO", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PRODUCTNO", txtProdNo.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record DELETE Success !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record DELETE Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            clear()
            DGV_load()

        Else
            Return
        End If

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        clear()
    End Sub

    'Text Search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_crud_inventory WHERE PRODUCTNO like '%" & txtSearch.Text & "%' OR PRODUCTNAME like '%" & txtSearch.Text & "%' OR PRICE like '%" & txtSearch.Text & "%' OR CATEGORY like '%" & txtSearch.Text & "%' OR EXPDATE like '%" & txtSearch.Text & "%' OR STATUS like '%" & txtSearch.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("CATEGORY"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        delete()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Close()
        Else
            ' Cancel logout
            Exit Sub
        End If

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim HOME As New frmHome()
        Hide()
        HOME.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim ABOUT As New frmAbout()
        Hide()
        ABOUT.ShowDialog()
    End Sub
End Class