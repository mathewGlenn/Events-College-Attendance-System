Imports MySql.Data.MySqlClient

Public Class frmEvents



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmAddEvents.Show()

    End Sub

    Private Sub frmEvents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lvEvents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvEvents.SelectedIndexChanged
        frmEventDetails.lbeventid.Text = lvEvents.FocusedItem.Text
        frmEventDetails.lbEvent.Text = lvEvents.FocusedItem.SubItems(1).Text
        frmEventDetails.lbDate.Text = lvEvents.FocusedItem.SubItems(2).Text
        frmEventDetails.lbVenue.Text = lvEvents.FocusedItem.SubItems(3).Text
        frmEventDetails.lbDesc.Text = lvEvents.FocusedItem.SubItems(4).Text


        frmEventDetails.ShowDialog()


    End Sub

    Private Sub frmEvents_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        lvEvents.Items.Clear()

        Dim con As New MySqlConnection("server= localhost;userid=root;password=;database= dbcollegeattendance")
        Dim cmd As New MySqlCommand("select * from tblevents", con)
        con.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader

        While reader.Read
            With lvEvents.Items.Add(reader.Item(0).ToString)
                .SubItems.Add(reader.Item(1).ToString)
                .SubItems.Add(reader.Item(2).ToString)
                .SubItems.Add(reader.Item(3).ToString)
                .SubItems.Add(reader.Item(4).ToString)
            End With

        End While

        con.Close()


    End Sub
End Class