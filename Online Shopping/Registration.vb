Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Registration
    Dim connection As SqlConnection

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        connection = New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")
        If txtemail.Text = "" Or txtmobile.Text = "" Or txtname.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Fields are empty Try again ", MsgBoxStyle.Critical)
        Else
            Dim regex As Regex = New Regex("([0-9]){10}$")
            If Not regex.IsMatch(txtmobile.Text.Trim()) Then
                MsgBox("Phone number should contain 10 letters", MsgBoxStyle.Information)
            Else


                Try
                    connection.Open()
                    Dim query As String
                    Dim reader As SqlDataReader
                    Dim command As SqlCommand
                    query = "insert into dbo.user_db (name,mobile_no,email,password,type) values ('" + txtname.Text + "','" + txtmobile.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "','User')"
                    command = New SqlCommand(query, connection)
                    reader = command.ExecuteReader
                    MsgBox("Sign-up successful, Continue to login!", MsgBoxStyle.Information, "Signup")
                Catch ex As SqlException
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()
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