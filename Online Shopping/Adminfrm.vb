Imports System.Data.SqlClient
Public Class Adminfrm
    Dim strpath As String
    Dim connection As New SqlConnection("server=ABBISHEK;Database=E-kart; Integrated Security=True")
    Dim TV_size As String
    Dim inches As String
    Dim lens As String
    Private Sub selectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image file (*.jpg;*.bmp;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbItem.Image = Image.FromFile(OpenFileDialog1.FileName)
            strpath = OpenFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub item_mobile()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = "insert into dbo.itemdb (type,brand,model,Ram,color,price,pieces,features,imgpath) values ('" + cmbItem.Text + "','" + txtBrand.Text + "','" + txtmodel.Text + "','" + txtRam.Text + "','" + txtColor.Text + "','" + txtprice.Text + "','" + txtpieces.Text + "','" + txtfeatures.Text + "','" + strpath + "')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("Item saved :)", MsgBoxStyle.Information, "Saved")
            clear_txtfields()
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub item_earphones()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = "insert into dbo.itemdb (type,brand,model,price,pieces,features,imgpath) values ('" + cmbItem.Text + "','" + txtBrand.Text + "','" + txtmodel.Text + "','" + txtprice.Text + "','" + txtpieces.Text + "','" + txtfeatures.Text + "','" + strpath + "')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("Item saved :)", MsgBoxStyle.Information, "Saved")
            clear_txtfields()
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub item_shoes()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = "insert into dbo.itemdb (type,brand,model,size,price,pieces,features,imgpath) values ('" + cmbItem.Text + "','" + txtBrand.Text + "','" + txtmodel.Text + "','" + TV_size + "','" + txtprice.Text + "','" + txtpieces.Text + "','" + txtfeatures.Text + "','" + strpath + "')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("Item saved :)", MsgBoxStyle.Information, "Saved")
            clear_txtfields()
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub item_tv()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = "insert into dbo.itemdb (type,brand,model,inches,price,pieces,features,imgpath) values ('" + cmbItem.Text + "','" + txtBrand.Text + "','" + txtmodel.Text + "','" + inches + "','" + txtprice.Text + "','" + txtpieces.Text + "','" + txtfeatures.Text + "','" + strpath + "')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("Item saved :)", MsgBoxStyle.Information, "Saved")
            clear_txtfields()
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub item_dslr()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = "insert into dbo.itemdb (type,brand,model,lens,price,pieces,features,imgpath) values ('" + cmbItem.Text + "','" + txtBrand.Text + "','" + txtmodel.Text + "','" + lens + "','" + txtprice.Text + "','" + txtpieces.Text + "','" + txtfeatures.Text + "','" + strpath + "')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("Item saved :)", MsgBoxStyle.Information, "Saved")
            clear_txtfields()
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub item_watch()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = "insert into dbo.itemdb (type,brand,model,price,pieces,features,imgpath) values ('" + cmbItem.Text + "','" + txtBrand.Text + "','" + txtmodel.Text + "','" + txtprice.Text + "','" + txtpieces.Text + "','" + txtfeatures.Text + "','" + strpath + "')"
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("Item saved :)", MsgBoxStyle.Information, "Saved")
            clear_txtfields()
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmbItem_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbItem.Text = "Mobile" Then
            pnlram.Visible = True
            pnlclr.Visible = True
            pnlsize.Visible = False
            pnllens.Visible = False
            pnlinches.Visible = False

        ElseIf cmbItem.Text = "Tv" Then
            pnlram.Visible = False
            pnlclr.Visible = False
            pnlsize.Visible = False
            pnllens.Visible = False
            pnlinches.Visible = True
        ElseIf cmbItem.Text = "Shoe" Then
            pnlram.Visible = False
            pnlclr.Visible = False
            pnlsize.Visible = True
            pnllens.Visible = False
            pnlinches.Visible = False
        ElseIf cmbItem.Text = "Dslr" Then
            pnlram.Visible = False
            pnlclr.Visible = False
            pnlsize.Visible = False
            pnllens.Visible = True
            pnlinches.Visible = False
        ElseIf cmbItem.Text = "Watch" Then
            pnlram.Visible = False
            pnlclr.Visible = False
            pnlsize.Visible = False
            pnllens.Visible = False
            pnlinches.Visible = False
        ElseIf cmbItem.Text = "Earphone" Then
            pnlram.Visible = False
            pnlclr.Visible = False
            pnlsize.Visible = False
            pnllens.Visible = False
            pnlinches.Visible = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

        If cmbItem.Text = "Mobile" Then
            item_mobile()

        ElseIf cmbItem.Text = "Tv" Then
            item_tv()
        ElseIf cmbItem.Text = "Earphone" Then
            item_earphones()
        ElseIf cmbItem.Text = "Dslr" Then
            item_dslr()
        ElseIf cmbItem.Text = "Shoe" Then
            item_shoes()
        ElseIf cmbItem.Text = "Watch" Then
            item_watch()

        End If
    End Sub

    Private Sub rd7_CheckedChanged(sender As Object, e As EventArgs)
        TV_size = 7
    End Sub

    Private Sub rd8_CheckedChanged(sender As Object, e As EventArgs)
        TV_size = 8
    End Sub

    Private Sub rd9_CheckedChanged(sender As Object, e As EventArgs)
        TV_size = 9
    End Sub

    Private Sub rd10_CheckedChanged(sender As Object, e As EventArgs)
        TV_size = 10
    End Sub

    Private Sub rd32_CheckedChanged(sender As Object, e As EventArgs)
        inches = 32
    End Sub

    Private Sub rd43_CheckedChanged(sender As Object, e As EventArgs)
        inches = 43
    End Sub

    Private Sub rd50_CheckedChanged(sender As Object, e As EventArgs)
        inches = 50
    End Sub

    Private Sub rd65_CheckedChanged(sender As Object, e As EventArgs)
        inches = 65
    End Sub

    Private Sub rd14_CheckedChanged(sender As Object, e As EventArgs)
        lens = 14
    End Sub

    Private Sub rd35_CheckedChanged(sender As Object, e As EventArgs)
        lens = 35
    End Sub

    Private Sub rd85_CheckedChanged(sender As Object, e As EventArgs)
        lens = 85
    End Sub

    Private Sub clear_txtfields()
        cmbItem.Text = ""
        txtBrand.Text = ""
        txtColor.Text = ""
        txtfeatures.Text = ""
        txtmodel.Text = ""
        txtpieces.Text = ""
        txtprice.Text = ""
        txtRam.Text = ""
        pbItem.Image = Nothing
    End Sub

    Private Sub Adminfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Login.Show()
    End Sub


End Class