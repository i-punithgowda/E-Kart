Imports System.Data.SqlClient
Public Class shoes
    Dim connection As New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")
    Dim picpath As String
    Private Sub shoes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainform.Show()
    End Sub

    Private Sub shoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbloader()
    End Sub

    Private Sub cmbloader()
        Try
            connection.Open()
            Dim query As String
            Dim command As New SqlCommand

            query = "select distinct brand from itemdb where type='shoe' "
            command = New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            cmbBrand.DataSource = table
            cmbBrand.DisplayMember = "brand"
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub model_loader()
        Try

            Dim query As String
            Dim command As New SqlCommand

            query = "select model from itemdb where brand='" + cmbBrand.Text + "' and type='shoe'"
            command = New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            cmbModel.DataSource = table
            cmbModel.DisplayMember = "model"
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged
        model_loader()
    End Sub

    Private Sub details_loader()
        Try
            connection.Open()
            Dim query As String
            Dim command As New SqlCommand
            Dim reader As SqlDataReader
            query = "select * from itemdb where brand='" + cmbBrand.Text + "' and model='" + cmbModel.Text + "'"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read

                lblsize.Text = reader("size")
                lblprice.Text = reader("price")
                txtfeatures.Text = reader("features")
                picpath = reader("imgpath")
            End While

            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        details_loader()
        picbox.Image = Image.FromFile(picpath)
    End Sub

    Private Sub Btncart_Click(sender As Object, e As EventArgs) Handles Btncart.Click

        payment.lblttlitems.Text = payment.lblttlitems.Text + 1
        cart.DataGridView1.Rows.Add("Shoes", cmbBrand.Text, cmbModel.Text, lblprice.Text, 1)
        payment.cmborders.Items.Add(cmbModel.Text)
        MsgBox("Item has been added to card")

    End Sub

    Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles BtnItem.Click
        Me.Hide()
        mainform.Show()
    End Sub
End Class