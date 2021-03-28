Imports System.Windows.Forms
Public Class mainform
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        search_func()
    End Sub

    Private Sub search_func()
        If txtsearch.Text = "" Then
            picmobile.Visible = True
            lblmobile.Visible = True
            picearphone.Visible = True
            lblearphone.Visible = True
            picshoes.Visible = True
            lblshoes.Visible = True
            pictv.Visible = True
            lbltv.Visible = True
            picwatch.Visible = True
            lblwatch.Visible = True
            picdslr.Visible = True
            lbldslr.Visible = True

        ElseIf txtsearch.Text.Substring(0, 1) = "M" Or txtsearch.Text.Substring(0, 1) = "m" Then
            picmobile.Visible = True
            lblmobile.Visible = True
            picearphone.Visible = False
            lblearphone.Visible = False
            picshoes.Visible = False
            lblshoes.Visible = False
            pictv.Visible = False
            lbltv.Visible = False
            picwatch.Visible = False
            lblwatch.Visible = False
            picdslr.Visible = False
            lbldslr.Visible = False

        ElseIf txtsearch.Text.Substring(0, 1) = "E" Or txtsearch.Text.Substring(0, 1) = "e" Then
            picmobile.Visible = False
            lblmobile.Visible = False
            picearphone.Visible = True
            lblearphone.Visible = True
            picshoes.Visible = False
            lblshoes.Visible = False
            pictv.Visible = False
            lbltv.Visible = False
            picwatch.Visible = False
            lblwatch.Visible = False
            picdslr.Visible = False
            lbldslr.Visible = False

        ElseIf txtsearch.Text.Substring(0, 1) = "S" Or txtsearch.Text.Substring(0, 1) = "s" Then
            picmobile.Visible = False
            lblmobile.Visible = False
            picearphone.Visible = False
            lblearphone.Visible = False
            picshoes.Visible = True
            lblshoes.Visible = True
            pictv.Visible = False
            lbltv.Visible = False
            picwatch.Visible = False
            lblwatch.Visible = False
            picdslr.Visible = False
            lbldslr.Visible = False

        ElseIf txtsearch.Text.Substring(0, 1) = "T" Or txtsearch.Text.Substring(0, 1) = "t" Then
            picmobile.Visible = False
            lblmobile.Visible = False
            picearphone.Visible = False
            lblearphone.Visible = False
            picshoes.Visible = False
            lblshoes.Visible = False
            pictv.Visible = True
            lbltv.Visible = True
            picwatch.Visible = False
            lblwatch.Visible = False
            picdslr.Visible = False
            lbldslr.Visible = False

        ElseIf txtsearch.Text.Substring(0, 1) = "W" Or txtsearch.Text.Substring(0, 1) = "w" Then
            picmobile.Visible = False
            lblmobile.Visible = False
            picearphone.Visible = False
            lblearphone.Visible = False
            picshoes.Visible = False
            lblshoes.Visible = False
            pictv.Visible = False
            lbltv.Visible = False
            picwatch.Visible = True
            lblwatch.Visible = True
            picdslr.Visible = False
            lbldslr.Visible = False

        ElseIf txtsearch.Text.Substring(0, 1) = "D" Or txtsearch.Text.Substring(0, 1) = "d" Then
            picmobile.Visible = False
            lblmobile.Visible = False
            picearphone.Visible = False
            lblearphone.Visible = False
            picshoes.Visible = False
            lblshoes.Visible = False
            pictv.Visible = False
            lbltv.Visible = False
            picwatch.Visible = False
            lblwatch.Visible = False
            picdslr.Visible = True
            lbldslr.Visible = True

        End If
    End Sub



    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            search_func()
        End If
    End Sub

    Private Sub picmobile_Click(sender As Object, e As EventArgs) Handles picmobile.Click
        Me.Hide()
        mobile.Show()
    End Sub

    Private Sub picearphone_Click(sender As Object, e As EventArgs) Handles picearphone.Click
        Me.Hide()
        earphone.Show()
    End Sub

    Private Sub picshoes_Click(sender As Object, e As EventArgs) Handles picshoes.Click
        Me.Hide()
        shoes.Show()
    End Sub

    Private Sub picwatch_Click(sender As Object, e As EventArgs) Handles picwatch.Click
        Me.Hide()
        watch.Show()
    End Sub

    Private Sub pictv_Click(sender As Object, e As EventArgs) Handles pictv.Click
        Me.Hide()
        Tv.Show()
    End Sub

    Private Sub picdslr_Click(sender As Object, e As EventArgs) Handles picdslr.Click
        Me.Hide()
        dslr.Show()
    End Sub

    Private Sub lblcart_Click(sender As Object, e As EventArgs) Handles lblcart.Click
        Me.Hide()
        cart.Show()
    End Sub

    Private Sub lblorderss_Click(sender As Object, e As EventArgs) Handles lblorderss.Click
        myorders.lblname.Text = lblname.Text
        Me.Hide()
        myorders.Show()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Me.Hide()
        Login.txtmobile.Text = ""
        Login.txtpassword.Text = ""
        Login.Show()

    End Sub
End Class