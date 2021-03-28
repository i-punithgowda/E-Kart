<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblttl = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deliverBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCalc = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.BtnCalc)
        Me.Guna2Panel1.Controls.Add(Me.lblttl)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.DataGridView1)
        Me.Guna2Panel1.Controls.Add(Me.deliverBtn)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(917, 917)
        Me.Guna2Panel1.TabIndex = 3
        '
        'lblttl
        '
        Me.lblttl.AutoSize = True
        Me.lblttl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblttl.Location = New System.Drawing.Point(175, 601)
        Me.lblttl.Name = "lblttl"
        Me.lblttl.Size = New System.Drawing.Size(0, 29)
        Me.lblttl.TabIndex = 11
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(911, 138)
        Me.Guna2Panel2.TabIndex = 8
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Black
        Me.Guna2Panel3.Controls.Add(Me.IconPictureBox1)
        Me.Guna2Panel3.Controls.Add(Me.IconPictureBox2)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(908, 31)
        Me.Guna2Panel3.TabIndex = 10
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(873, 0)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 11
        Me.IconPictureBox1.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.Location = New System.Drawing.Point(835, -5)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.TabIndex = 12
        Me.IconPictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Algerian", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 46)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cart"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 601)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(820, 338)
        Me.DataGridView1.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Brand"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Model"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'deliverBtn
        '
        Me.deliverBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.deliverBtn.CheckedState.Parent = Me.deliverBtn
        Me.deliverBtn.CustomImages.Parent = Me.deliverBtn
        Me.deliverBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.deliverBtn.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Bold)
        Me.deliverBtn.ForeColor = System.Drawing.Color.White
        Me.deliverBtn.HoverState.Parent = Me.deliverBtn
        Me.deliverBtn.Location = New System.Drawing.Point(429, 701)
        Me.deliverBtn.Name = "deliverBtn"
        Me.deliverBtn.ShadowDecoration.Parent = Me.deliverBtn
        Me.deliverBtn.Size = New System.Drawing.Size(215, 45)
        Me.deliverBtn.TabIndex = 9
        Me.deliverBtn.Text = "Place Order"
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnCalc.CheckedState.Parent = Me.BtnCalc
        Me.BtnCalc.CustomImages.Parent = Me.BtnCalc
        Me.BtnCalc.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnCalc.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCalc.ForeColor = System.Drawing.Color.White
        Me.BtnCalc.HoverState.Parent = Me.BtnCalc
        Me.BtnCalc.Location = New System.Drawing.Point(39, 523)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.ShadowDecoration.Parent = Me.BtnCalc
        Me.BtnCalc.Size = New System.Drawing.Size(215, 45)
        Me.BtnCalc.TabIndex = 12
        Me.BtnCalc.Text = "Calculate total"
        '
        'cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(904, 917)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cart"
        Me.Text = "cart"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents deliverBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents lblttl As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents BtnCalc As Guna.UI2.WinForms.Guna2Button
End Class
