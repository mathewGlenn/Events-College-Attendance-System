Imports MySql.Data.MySqlClient

Public Class frmLogin

    Dim cmd As MySqlCommand

    Private Sub btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Submit.Click
        Dim query = "select * from tbladmin where username = ?user and password=?password"

        Dim con As New MySqlConnection("server = localhost; user id= root;pwd=;database=dbcollegeattendance")



        cmd = New MySqlCommand(query, con)
        cmd.Parameters.Add("?password", txt_Password.Text)
        cmd.Parameters.Add("?user", txt_Username.Text)
        con.Open()
        Dim adapt As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet()
        adapt.Fill(ds)

        Dim count = ds.Tables(0).Rows.Count

        If count = 0 Then
            MessageBox.Show("login failed")
        Else

            MessageBox.Show("Login successful")
            frmMain.Show()
            Me.Hide()

        End If
        con.Close()


    End Sub


    Private Sub chkpasswordVisibility_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpasswordVisibility.CheckedChanged
        If txt_Password.UseSystemPasswordChar = True Then
            txt_Password.UseSystemPasswordChar = False

        Else

            txt_Password.UseSystemPasswordChar = True

        End If
    End Sub
End Class