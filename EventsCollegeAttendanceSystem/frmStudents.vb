Imports MySql.Data.MySqlClient
Public Class frmStudents
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        frmAddStudent.ShowDialog()

    End Sub

    Private Sub frmStudents_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub


    Private Sub frmStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvStudents.Items.Clear()


        con = New MySqlConnection("server = localhost; userid=root;password=;database=dbcollegeattendance")

        con.Open()

        cmd = New MySqlCommand("select stud_id, f_name, m_name, l_name, dep, yr_level, course, section from tblstudents", con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read
            With lvStudents.Items.Add(reader.Item(0).ToString)
                .SubItems.Add(reader.Item(1).ToString)
                .SubItems.Add(reader.Item(2).ToString)
                .SubItems.Add(reader.Item(3).ToString)
                .SubItems.Add(reader.Item(4).ToString)
                .SubItems.Add(reader.Item(5).ToString)
                .SubItems.Add(reader.Item(6).ToString)
                .SubItems.Add(reader.Item(7).ToString)
            End With
        End While

        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class