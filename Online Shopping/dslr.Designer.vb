<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dslr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dslr))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.BtnItem = New Guna.UI2.WinForms.Guna2Button()
        Me.picbox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.cartBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtfeatures = New System.Windows.Forms.RichTextBox()
        Me.features = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLens = New System.Windows.Forms.Label()
        Me.Color = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbModel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbBrand = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(371, 859)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, -33)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(371, 904)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.BtnItem)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.picbox)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cartBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtfeatures)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.features)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblprice)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblLens)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Color)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbModel)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbBrand)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1317, 859)
        Me.Guna2CustomGradientPanel1.TabIndex = 3
        '
        'BtnItem
        '
        Me.BtnItem.CheckedState.Parent = Me.BtnItem
        Me.BtnItem.CustomImages.Parent = Me.BtnItem
        Me.BtnItem.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnItem.ForeColor = System.Drawing.Color.Black
        Me.BtnItem.HoverState.Parent = Me.BtnItem
        Me.BtnItem.Location = New System.Drawing.Point(987, 716)
        Me.BtnItem.Name = "BtnItem"
        Me.BtnItem.ShadowDecoration.Parent = Me.BtnItem
        Me.BtnItem.Size = New System.Drawing.Size(253, 45)
        Me.BtnItem.TabIndex = 22
        Me.BtnItem.Text = "Add More Items"
        '
        'picbox
        '
        Me.picbox.Location = New System.Drawing.Point(377, 163)
        Me.picbox.Name = "picbox"
        Me.picbox.ShadowDecoration.Parent = Me.picbox
        Me.picbox.Size = New System.Drawing.Size(330, 445)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox.TabIndex = 20
        Me.picbox.TabStop = False
        '
        'cartBtn
        '
        Me.cartBtn.CheckedState.Parent = Me.cartBtn
        Me.cartBtn.CustomImages.Parent = Me.cartBtn
        Me.cartBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cartBtn.ForeColor = System.Drawing.Color.Black
        Me.cartBtn.HoverState.Parent = Me.cartBtn
        Me.cartBtn.Location = New System.Drawing.Point(764, 716)
        Me.cartBtn.Name = "cartBtn"
        Me.cartBtn.ShadowDecoration.Parent = Me.cartBtn
        Me.cartBtn.Size = New System.Drawing.Size(207, 45)
        Me.cartBtn.TabIndex = 19
        Me.cartBtn.Text = "Add to cart"
        '
        'txtfeatures
        '
        Me.txtfeatures.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeatures.Location = New System.Drawing.Point(1008, 485)
        Me.txtfeatures.Name = "txtfeatures"
        Me.txtfeatures.Size = New System.Drawing.Size(199, 95)
        Me.txtfeatures.TabIndex = 18
        Me.txtfeatures.Text = ""
        '
        'features
        '
        Me.features.AutoSize = True
        Me.features.BackColor = System.Drawing.Color.Transparent
        Me.features.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.features.ForeColor = System.Drawing.Color.White
        Me.features.Location = New System.Drawing.Point(874, 485)
        Me.features.Name = "features"
        Me.features.Size = New System.Drawing.Size(97, 26)
        Me.features.TabIndex = 17
        Me.features.Text = "Features"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.White
        Me.lblprice.Location = New System.Drawing.Point(1064, 634)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(0, 26)
        Me.lblprice.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(882, 635)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Price"
        '
        'lblLens
        '
        Me.lblLens.AutoSize = True
        Me.lblLens.BackColor = System.Drawing.Color.Transparent
        Me.lblLens.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLens.ForeColor = System.Drawing.Color.White
        Me.lblLens.Location = New System.Drawing.Point(1056, 398)
        Me.lblLens.Name = "lblLens"
        Me.lblLens.Size = New System.Drawing.Size(0, 26)
        Me.lblLens.TabIndex = 14
        '
        'Color
        '
        Me.Color.AutoSize = True
        Me.Color.BackColor = System.Drawing.Color.Transparent
        Me.Color.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color.ForeColor = System.Drawing.Color.White
        Me.Color.Location = New System.Drawing.Point(874, 398)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(59, 26)
        Me.Color.TabIndex = 13
        Me.Color.Text = "Lens"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(874, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(874, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Brand"
        '
        'cmbModel
        '
        Me.cmbModel.BackColor = System.Drawing.Color.Transparent
        Me.cmbModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbModel.FocusedState.Parent = Me.cmbModel
        Me.cmbModel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbModel.HoverState.Parent = Me.cmbModel
        Me.cmbModel.ItemHeight = 30
        Me.cmbModel.ItemsAppearance.Parent = Me.cmbModel
        Me.cmbModel.Location = New System.Drawing.Point(1008, 251)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.ShadowDecoration.Parent = Me.cmbModel
        Me.cmbModel.Size = New System.Drawing.Size(189, 36)
        Me.cmbModel.TabIndex = 4
        '
        'cmbBrand
        '
        Me.cmbBrand.BackColor = System.Drawing.Color.Transparent
        Me.cmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrand.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBrand.FocusedState.Parent = Me.cmbBrand
        Me.cmbBrand.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBrand.HoverState.Parent = Me.cmbBrand
        Me.cmbBrand.ItemHeight = 30
        Me.cmbBrand.ItemsAppearance.Parent = Me.cmbBrand
        Me.cmbBrand.Location = New System.Drawing.Point(1008, 174)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.ShadowDecoration.Parent = Me.cmbBrand
        Me.cmbBrand.Size = New System.Drawing.Size(189, 36)
        Me.cmbBrand.TabIndex = 3
        '
        'dslr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 859)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Name = "dslr"
        Me.Text = "dslr"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents cartBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtfeatures As RichTextBox
    Friend WithEvents features As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLens As Label
    Friend WithEvents Color As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbModel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbBrand As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents picbox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnItem As Guna.UI2.WinForms.Guna2Button
End Class
