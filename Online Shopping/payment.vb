Imports System.Data.SqlClient
Imports System.Linq
Public Class payment
    Dim connection As New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")
    Dim randomstring As String
    Dim num As Integer

    Private Sub deliverBtn_Click(sender As Object, e As EventArgs) Handles deliverBtn.Click
        If txtaddress.Text = "" Then
            MsgBox("Enter valid address", MsgBoxStyle.Critical)
        Else
            pnlpayment.Visible = True
        End If

    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlpayment.Visible = False
        cmborders.Text = cmborders.Items.IndexOf(0)
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        randomstring_generator()
        If CODrd.Checked = False Then
            MsgBox("Select Payment mode", MsgBoxStyle.Critical)
        Else
            save_data()
            MsgBox("Order confirmed you'll notified when your package has been shipped :) " + randomstring + " is your tracking Id  Thanks for choosing E-kart", MsgBoxStyle.Information, "Order confirmed")
            cart.DataGridView1.Rows.Clear()
            cmborders.Items.Clear()
            lblttlitems.Text = ""
            txtaddress.Text = ""
            lblttl.Text = ""
            cart.lblttl.Text = ""
            mainform.Show()
        End If
    End Sub
    Private Sub randomstring_generator()
        Dim rand As New Random
        num = rand.Next(2000000, 20000000)
        randomstring = "Ekrt" + num.ToString
    End Sub

    Private Sub save_data()
        Dim tdate As String
        tdate = DateTime.Now().ToShortDateString

        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = "insert into order_details (name,number,address,total,transaction_id,mode,items,date) values ('" + lblusrname.Text + "','" + lblusrnum.Text + "','" + txtaddress.Text + "','" + lblttl.Text + "','" + randomstring + "','COD','" + lblttlitems.Text + "','" + tdate + "')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
        Me.Hide()
        cart.Show()
    End Sub
End Class