Imports System.Data.SqlClient

Public Class myorders
    Dim connection As New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")
    Dim dbdataset As New DataTable
    Private Sub myorders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridview_load()
    End Sub

    Private Sub datagridview_load()
        dbdataset.Clear()
        Dim SDA As New SqlDataAdapter
        Dim bSource As New BindingSource


        Try
            connection.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select id,name,address,total,transaction_id,mode,items,date from order_details where name='" + lblname.Text + "'"
            Dim command As New SqlCommand
            command = New SqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbdataset)


            connection.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub myorders_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        mainform.Show()
    End Sub
End Class