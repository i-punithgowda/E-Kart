Imports System.Data.SqlClient
Public Class mobile
    Dim connection As New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")
    Dim picpath As String

    Private Sub mobile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainform.Show()
    End Sub

    Private Sub mobile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_loader()

    End Sub

    Private Sub cmb_loader()
        Try
            connection.Open()
            Dim query As String
            Dim command As New SqlCommand

            query = "select distinct brand from itemdb where type='mobile' "
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

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged
        model_loader()
    End Sub

    Private Sub model_loader()
        Try

            Dim query As String
            Dim command As New SqlCommand

            query = "select model from itemdb where brand='" + cmbBrand.Text + "' and type='mobile'"
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

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        details_loader()
        picbox.Image = Image.FromFile(picpath)
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
                lblram.Text = reader("ram")
                lblcolor.Text = reader("color")
                lblprice.Text = reader("price")
                txtFeatures.Text = reader("features")
                picpath = reader("imgpath")
            End While

            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCart_Click(sender As Object, e As EventArgs) Handles BtnCart.Click

        payment.lblttlitems.Text = payment.lblttlitems.Text + 1
        cart.DataGridView1.Rows.Add("Mobile", cmbBrand.Text, cmbModel.Text, lblprice.Text, 1)
        payment.cmborders.Items.Add(cmbModel.Text)
        MsgBox("Item has been added to cart")
    End Sub

    Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles BtnItem.Click
        Me.Hide()
        mainform.Show()
    End Sub


End Class