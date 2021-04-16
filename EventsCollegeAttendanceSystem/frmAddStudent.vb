Imports MySql.Data.MySqlClient
Public Class frmAddStudent

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim reader As MySqlDataReader
        Dim con As New MySqlConnection("server = localhost; user id= root;pwd=;database=dbcollegeattendance")

        con.Open()

        Dim likecmd As New MySqlCommand("select * from tblstudents where f_name = ?f_name and m_name=?m_name and l_name=?l_name", con)
        likecmd.Parameters.Add("?f_name", txtfname.Text)
        likecmd.Parameters.Add("?m_name", txtmname.Text)
        likecmd.Parameters.Add("?l_name", txtlname.Text)
        Dim adapt As New MySqlDataAdapter(likecmd)
        Dim ds As New DataSet()
        adapt.Fill(ds)

        Dim count = ds.Tables(0).Rows.Count
        con.Close()

        If count = 1 Then
            MessageBox.Show("Student already exist in the database")
        Else

            con.Open()

            Dim cmd As New MySqlCommand("insert into tblstudents (f_name,m_name, l_name,dep,yr_level, course, section) values(?fname,?mname,?lname,?dep,?yrlev,?course,?section)", con)
            cmd.Parameters.Add("?fname", txtfname.Text)
            cmd.Parameters.Add("?mname", txtmname.Text)
            cmd.Parameters.Add("?lname", txtlname.Text)
            cmd.Parameters.Add("?dep", cmbdep.Text)
            cmd.Parameters.Add("?yrlev", cmbyrlev.Text)
            cmd.Parameters.Add("?course", cmbcourse.Text)
            cmd.Parameters.Add("?section", cmbsection.Text)



            reader = cmd.ExecuteReader

            MessageBox.Show("Data saved!")
        End If



        con.Close()

    End Sub

    Private Sub cmbcourse_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcourse.DropDown


        If cmbdep.Text = "CCSICT" Then
            cmbcourse.Items.Clear()
            cmbcourse.Items.Add("BSCS")
            cmbcourse.Items.Add("BSIT")
        ElseIf cmbdep.Text = "CBM" Then
            cmbcourse.Items.Clear()
            cmbcourse.Items.Add("BSBA")
            cmbcourse.Items.Add("BSA")
            cmbcourse.Items.Add("BS Entrep")

        End If
    End Sub


    Private Sub cmbsection_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsection.DropDown
        If cmbcourse.Text = "BSCS" And cmbyrlev.Text = "1st Year" Then
            cmbsection.Items.Clear()
            cmbsection.Items.Add("1-1")
            cmbsection.Items.Add("1-2")
            cmbsection.Items.Add("1-3")
        ElseIf cmbcourse.Text = "BSCS" And cmbyrlev.Text = "2nd Year" Then
            cmbsection.Items.Clear()
            cmbsection.Items.Add("2-1")
            cmbsection.Items.Add("2-2")
        ElseIf cmbcourse.Text = "BSIT" And cmbyrlev.Text = "2nd Year" Then
            cmbsection.Items.Clear()
            cmbsection.Items.Add("2-1")
            cmbsection.Items.Add("2-2")
            cmbsection.Items.Add("2-3")
            cmbsection.Items.Add("2-4")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class