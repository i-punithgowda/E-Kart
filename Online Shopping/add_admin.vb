Imports System.Data.SqlClient
Public Class add_admin
    Dim connection As New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Try
            connection.Open()
            Dim query As String
            Dim command As New SqlCommand
            Dim reader As SqlDataReader
            query = "insert into user_db (name,mobile_no,email,password,type) values ('" + txtname.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "','Admin')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("New admin added", MsgBoxStyle.Information, "Admin")
            connection.Close()
            txtname.Text = ""
            txtpassword.Text = ""
            txtemail.Text = ""
            txtphone.Text = ""
        Catch ex As SqlException
            MsgBox(ex.Message)
            MsgBox(ex.Message)
        End Try
    End Sub
End Class