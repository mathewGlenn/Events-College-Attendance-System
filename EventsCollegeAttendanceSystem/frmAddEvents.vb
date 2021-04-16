Imports MySql.Data.MySqlClient

Public Class frmAddEvents

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=dbcollegeattendance")
        Dim cmd As New MySqlCommand("insert into tblevents (event,date,venue,Description) values(?event,?date,?venue,?desc)", con)
        con.Open()

        cmd.Parameters.Add("?event", txtEventName.Text)
        cmd.Parameters.Add("?date", dateEvent.Text)
        cmd.Parameters.Add("?venue", txtVenue.Text)
        cmd.Parameters.Add("?desc", txtEventDepartment.Text)

        Dim reader As MySqlDataReader

        reader = cmd.ExecuteReader

        con.Close()

        MessageBox.Show("Event Saved")

    End Sub

    'Hello, World
End Class