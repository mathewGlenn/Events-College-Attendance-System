Imports MySql.Data.MySqlClient

Public Class frmEventDetails

    Private Sub frmEventDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub chkEventDone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEventDone.CheckedChanged
        Dim dir As DialogResult = MessageBox.Show("Mark this event as Done?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dir = DialogResult.Yes Then

            Dim con As New MySqlConnection("server = localhost; userid=root; password=; database = dbcollegeattendance")
            Dim cmd As New MySqlCommand("update tblevents set Done ='true' where eventid = ?eid", con)
            cmd.Parameters.Add("?eid", lbeventid.Text)
            con.Open()


            Dim reader As MySqlDataReader = cmd.ExecuteReader

            MessageBox.Show("Event was marked Done")

            con.Close()
        Else
            chkEventDone.Checked = False


        End If



    End Sub
End Class