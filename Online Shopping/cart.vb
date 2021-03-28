Public Class cart
    Private Sub cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub deliverBtn_Click(sender As Object, e As EventArgs) Handles deliverBtn.Click
        Me.Hide()
        payment.Show()
        payment.lblttl.Text = lblttl.Text

    End Sub

    Private Sub cart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        mainform.Show()
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Hide()
        mainform.Show()
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(3).Value
        Next
        lblttl.Text = sum.ToString
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs)

    End Sub
End Class