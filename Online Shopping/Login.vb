Imports System.Data.SqlClient
Public Class Login
    Dim connection As New SqlConnection
    Dim username As String
    Dim number As String
    Dim type As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        Registration.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        connection = New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            Dim count As Integer = 0
            query = "select * from dbo.user_db where mobile_no='" + txtmobile.Text + "' and password='" + txtpassword.Text + "'   "
            command = New SqlCommand(query, connection)

            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
                username = reader("name")
                number = reader("mobile_no")
                type = reader("type")
            End While
            If count = 1 Then

                If type = "User" Then
                    MsgBox("Succesfully logged in", MsgBoxStyle.Information, "Login")
                    Me.Hide()
                    mainform.lblname.Text = username
                    payment.lblusrname.Text = username
                    payment.lblusrnum.Text = number
                    mainform.Show()
                ElseIf type = "Admin" Then
                    MsgBox("Succesfully logged in", MsgBoxStyle.Information, "Login")
                    Me.Hide()
                    Adminfrm.Show()

                End If
            Else
                MsgBox("Wrong username or password", MsgBoxStyle.Critical, "Password")
            End If
            txtmobile.Text = ""
            txtpassword.Text = ""

            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtmobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobile.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


End Class