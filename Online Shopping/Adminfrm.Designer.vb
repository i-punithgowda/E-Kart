<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adminfrm))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtpieces = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlram = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlclr = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtColor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnllens = New Guna.UI2.WinForms.Guna2Panel()
        Me.rd14 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rd35 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rd85 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.pnlinches = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rd50 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rd32 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rd43 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rd65 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.pnlsize = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rd10 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rd9 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rd8 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rd7 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtmodel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBrand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.txtfeatures = New System.Windows.Forms.RichTextBox()
        Me.lblfeat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbItem = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.selectBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.pbItem = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlram.SuspendLayout()
        Me.pnlclr.SuspendLayout()
        Me.pnllens.SuspendLayout()
        Me.pnlinches.SuspendLayout()
        Me.pnlsize.SuspendLayout()
        CType(Me.pbItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.txtpieces)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.pnlram)
        Me.Guna2Panel1.Controls.Add(Me.pnlclr)
        Me.Guna2Panel1.Controls.Add(Me.pnllens)
        Me.Guna2Panel1.Controls.Add(Me.pnlinches)
        Me.Guna2Panel1.Controls.Add(Me.pnlsize)
        Me.Guna2Panel1.Controls.Add(Me.txtmodel)
        Me.Guna2Panel1.Controls.Add(Me.txtBrand)
        Me.Guna2Panel1.Controls.Add(Me.btnSave)
        Me.Guna2Panel1.Controls.Add(Me.txtprice)
        Me.Guna2Panel1.Controls.Add(Me.lblprice)
        Me.Guna2Panel1.Controls.Add(Me.txtfeatures)
        Me.Guna2Panel1.Controls.Add(Me.lblfeat)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.cmbItem)
        Me.Guna2Panel1.Controls.Add(Me.selectBtn)
        Me.Guna2Panel1.Controls.Add(Me.pbItem)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1482, 1051)
        Me.Guna2Panel1.TabIndex = 3
        '
        'txtpieces
        '
        Me.txtpieces.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpieces.DefaultText = ""
        Me.txtpieces.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpieces.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpieces.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpieces.DisabledState.Parent = Me.txtpieces
        Me.txtpieces.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpieces.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpieces.FocusedState.Parent = Me.txtpieces
        Me.txtpieces.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtpieces.ForeColor = System.Drawing.Color.Black
        Me.txtpieces.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpieces.HoverState.Parent = Me.txtpieces
        Me.txtpieces.Location = New System.Drawing.Point(643, 638)
        Me.txtpieces.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtpieces.Name = "txtpieces"
        Me.txtpieces.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpieces.PlaceholderText = ""
        Me.txtpieces.SelectedText = ""
        Me.txtpieces.ShadowDecoration.Parent = Me.txtpieces
        Me.txtpieces.Size = New System.Drawing.Size(200, 36)
        Me.txtpieces.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(475, 638)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 26)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "No. of pieces"
        '
        'pnlram
        '
        Me.pnlram.Controls.Add(Me.Label5)
        Me.pnlram.Controls.Add(Me.txtRam)
        Me.pnlram.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlram.Location = New System.Drawing.Point(501, 226)
        Me.pnlram.Name = "pnlram"
        Me.pnlram.ShadowDecoration.Parent = Me.pnlram
        Me.pnlram.Size = New System.Drawing.Size(394, 53)
        Me.pnlram.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ram"
        '
        'txtRam
        '
        Me.txtRam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRam.DefaultText = ""
        Me.txtRam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRam.DisabledState.Parent = Me.txtRam
        Me.txtRam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRam.FocusedState.Parent = Me.txtRam
        Me.txtRam.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtRam.ForeColor = System.Drawing.Color.Black
        Me.txtRam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRam.HoverState.Parent = Me.txtRam
        Me.txtRam.Location = New System.Drawing.Point(119, 10)
        Me.txtRam.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtRam.Name = "txtRam"
        Me.txtRam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRam.PlaceholderText = ""
        Me.txtRam.SelectedText = ""
        Me.txtRam.ShadowDecoration.Parent = Me.txtRam
        Me.txtRam.Size = New System.Drawing.Size(200, 36)
        Me.txtRam.TabIndex = 17
        '
        'pnlclr
        '
        Me.pnlclr.BackColor = System.Drawing.Color.Transparent
        Me.pnlclr.Controls.Add(Me.txtColor)
        Me.pnlclr.Controls.Add(Me.Label6)
        Me.pnlclr.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlclr.Location = New System.Drawing.Point(503, 303)
        Me.pnlclr.Name = "pnlclr"
        Me.pnlclr.ShadowDecoration.Parent = Me.pnlclr
        Me.pnlclr.Size = New System.Drawing.Size(394, 53)
        Me.pnlclr.TabIndex = 76
        '
        'txtColor
        '
        Me.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtColor.DefaultText = ""
        Me.txtColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtColor.DisabledState.Parent = Me.txtColor
        Me.txtColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtColor.FocusedState.Parent = Me.txtColor
        Me.txtColor.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtColor.ForeColor = System.Drawing.Color.Black
        Me.txtColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtColor.HoverState.Parent = Me.txtColor
        Me.txtColor.Location = New System.Drawing.Point(117, 8)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColor.PlaceholderText = ""
        Me.txtColor.SelectedText = ""
        Me.txtColor.ShadowDecoration.Parent = Me.txtColor
        Me.txtColor.Size = New System.Drawing.Size(200, 37)
        Me.txtColor.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 26)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Color"
        '
        'pnllens
        '
        Me.pnllens.Controls.Add(Me.rd14)
        Me.pnllens.Controls.Add(Me.Label9)
        Me.pnllens.Controls.Add(Me.rd35)
        Me.pnllens.Controls.Add(Me.rd85)
        Me.pnllens.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnllens.Location = New System.Drawing.Point(501, 503)
        Me.pnllens.Name = "pnllens"
        Me.pnllens.ShadowDecoration.Parent = Me.pnllens
        Me.pnllens.Size = New System.Drawing.Size(396, 49)
        Me.pnllens.TabIndex = 75
        '
        'rd14
        '
        Me.rd14.AutoSize = True
        Me.rd14.BackColor = System.Drawing.Color.White
        Me.rd14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd14.CheckedState.BorderThickness = 0
        Me.rd14.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd14.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd14.CheckedState.InnerOffset = -4
        Me.rd14.Location = New System.Drawing.Point(104, 15)
        Me.rd14.Name = "rd14"
        Me.rd14.Size = New System.Drawing.Size(67, 21)
        Me.rd14.TabIndex = 29
        Me.rd14.Text = "14mm"
        Me.rd14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd14.UncheckedState.BorderThickness = 2
        Me.rd14.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd14.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd14.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 26)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Lens"
        '
        'rd35
        '
        Me.rd35.AutoSize = True
        Me.rd35.BackColor = System.Drawing.Color.White
        Me.rd35.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd35.CheckedState.BorderThickness = 0
        Me.rd35.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd35.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd35.CheckedState.InnerOffset = -4
        Me.rd35.Location = New System.Drawing.Point(192, 15)
        Me.rd35.Name = "rd35"
        Me.rd35.Size = New System.Drawing.Size(67, 21)
        Me.rd35.TabIndex = 30
        Me.rd35.Text = "35mm"
        Me.rd35.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd35.UncheckedState.BorderThickness = 2
        Me.rd35.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd35.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd35.UseVisualStyleBackColor = False
        '
        'rd85
        '
        Me.rd85.AutoSize = True
        Me.rd85.BackColor = System.Drawing.Color.White
        Me.rd85.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd85.CheckedState.BorderThickness = 0
        Me.rd85.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd85.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd85.CheckedState.InnerOffset = -4
        Me.rd85.Location = New System.Drawing.Point(275, 15)
        Me.rd85.Name = "rd85"
        Me.rd85.Size = New System.Drawing.Size(67, 21)
        Me.rd85.TabIndex = 31
        Me.rd85.Text = "85mm"
        Me.rd85.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd85.UncheckedState.BorderThickness = 2
        Me.rd85.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd85.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd85.UseVisualStyleBackColor = False
        '
        'pnlinches
        '
        Me.pnlinches.Controls.Add(Me.Label8)
        Me.pnlinches.Controls.Add(Me.rd50)
        Me.pnlinches.Controls.Add(Me.rd32)
        Me.pnlinches.Controls.Add(Me.rd43)
        Me.pnlinches.Controls.Add(Me.rd65)
        Me.pnlinches.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlinches.Location = New System.Drawing.Point(501, 438)
        Me.pnlinches.Name = "pnlinches"
        Me.pnlinches.ShadowDecoration.Parent = Me.pnlinches
        Me.pnlinches.Size = New System.Drawing.Size(396, 44)
        Me.pnlinches.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 26)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Inches"
        '
        'rd50
        '
        Me.rd50.AutoSize = True
        Me.rd50.BackColor = System.Drawing.Color.White
        Me.rd50.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd50.CheckedState.BorderThickness = 0
        Me.rd50.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd50.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd50.CheckedState.InnerOffset = -4
        Me.rd50.Location = New System.Drawing.Point(233, 13)
        Me.rd50.Name = "rd50"
        Me.rd50.Size = New System.Drawing.Size(45, 21)
        Me.rd50.TabIndex = 26
        Me.rd50.Text = "50"
        Me.rd50.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd50.UncheckedState.BorderThickness = 2
        Me.rd50.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd50.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd50.UseVisualStyleBackColor = False
        '
        'rd32
        '
        Me.rd32.AutoSize = True
        Me.rd32.BackColor = System.Drawing.Color.White
        Me.rd32.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd32.CheckedState.BorderThickness = 0
        Me.rd32.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd32.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd32.CheckedState.InnerOffset = -4
        Me.rd32.Location = New System.Drawing.Point(104, 13)
        Me.rd32.Name = "rd32"
        Me.rd32.Size = New System.Drawing.Size(45, 21)
        Me.rd32.TabIndex = 24
        Me.rd32.Text = "32"
        Me.rd32.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd32.UncheckedState.BorderThickness = 2
        Me.rd32.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd32.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd32.UseVisualStyleBackColor = False
        '
        'rd43
        '
        Me.rd43.AutoSize = True
        Me.rd43.BackColor = System.Drawing.Color.White
        Me.rd43.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd43.CheckedState.BorderThickness = 0
        Me.rd43.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd43.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd43.CheckedState.InnerOffset = -4
        Me.rd43.Location = New System.Drawing.Point(169, 13)
        Me.rd43.Name = "rd43"
        Me.rd43.Size = New System.Drawing.Size(45, 21)
        Me.rd43.TabIndex = 25
        Me.rd43.Text = "43"
        Me.rd43.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd43.UncheckedState.BorderThickness = 2
        Me.rd43.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd43.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd43.UseVisualStyleBackColor = False
        '
        'rd65
        '
        Me.rd65.AutoSize = True
        Me.rd65.BackColor = System.Drawing.Color.White
        Me.rd65.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd65.CheckedState.BorderThickness = 0
        Me.rd65.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd65.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd65.CheckedState.InnerOffset = -4
        Me.rd65.Location = New System.Drawing.Point(297, 13)
        Me.rd65.Name = "rd65"
        Me.rd65.Size = New System.Drawing.Size(45, 21)
        Me.rd65.TabIndex = 27
        Me.rd65.Text = "65"
        Me.rd65.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd65.UncheckedState.BorderThickness = 2
        Me.rd65.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd65.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd65.UseVisualStyleBackColor = False
        '
        'pnlsize
        '
        Me.pnlsize.Controls.Add(Me.Label7)
        Me.pnlsize.Controls.Add(Me.rd10)
        Me.pnlsize.Controls.Add(Me.rd9)
        Me.pnlsize.Controls.Add(Me.rd8)
        Me.pnlsize.Controls.Add(Me.rd7)
        Me.pnlsize.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlsize.Location = New System.Drawing.Point(501, 377)
        Me.pnlsize.Name = "pnlsize"
        Me.pnlsize.ShadowDecoration.Parent = Me.pnlsize
        Me.pnlsize.Size = New System.Drawing.Size(396, 42)
        Me.pnlsize.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 26)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Size"
        '
        'rd10
        '
        Me.rd10.AutoSize = True
        Me.rd10.BackColor = System.Drawing.Color.White
        Me.rd10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd10.CheckedState.BorderThickness = 0
        Me.rd10.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd10.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd10.CheckedState.InnerOffset = -4
        Me.rd10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.rd10.Location = New System.Drawing.Point(297, 13)
        Me.rd10.Name = "rd10"
        Me.rd10.Size = New System.Drawing.Size(45, 21)
        Me.rd10.TabIndex = 26
        Me.rd10.Text = "10"
        Me.rd10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd10.UncheckedState.BorderThickness = 2
        Me.rd10.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd10.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd10.UseVisualStyleBackColor = False
        '
        'rd9
        '
        Me.rd9.AutoSize = True
        Me.rd9.BackColor = System.Drawing.Color.White
        Me.rd9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd9.CheckedState.BorderThickness = 0
        Me.rd9.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd9.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd9.CheckedState.InnerOffset = -4
        Me.rd9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.rd9.Location = New System.Drawing.Point(233, 13)
        Me.rd9.Name = "rd9"
        Me.rd9.Size = New System.Drawing.Size(37, 21)
        Me.rd9.TabIndex = 25
        Me.rd9.Text = "9"
        Me.rd9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd9.UncheckedState.BorderThickness = 2
        Me.rd9.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd9.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd9.UseVisualStyleBackColor = False
        '
        'rd8
        '
        Me.rd8.AutoSize = True
        Me.rd8.BackColor = System.Drawing.Color.White
        Me.rd8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd8.CheckedState.BorderThickness = 0
        Me.rd8.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd8.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd8.CheckedState.InnerOffset = -4
        Me.rd8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.rd8.Location = New System.Drawing.Point(169, 13)
        Me.rd8.Name = "rd8"
        Me.rd8.Size = New System.Drawing.Size(37, 21)
        Me.rd8.TabIndex = 24
        Me.rd8.Text = "8"
        Me.rd8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd8.UncheckedState.BorderThickness = 2
        Me.rd8.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd8.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd8.UseVisualStyleBackColor = False
        '
        'rd7
        '
        Me.rd7.AutoSize = True
        Me.rd7.BackColor = System.Drawing.Color.White
        Me.rd7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd7.CheckedState.BorderThickness = 0
        Me.rd7.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rd7.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rd7.CheckedState.InnerOffset = -4
        Me.rd7.Location = New System.Drawing.Point(104, 13)
        Me.rd7.Name = "rd7"
        Me.rd7.Size = New System.Drawing.Size(37, 21)
        Me.rd7.TabIndex = 23
        Me.rd7.Text = "7"
        Me.rd7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rd7.UncheckedState.BorderThickness = 2
        Me.rd7.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rd7.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rd7.UseVisualStyleBackColor = False
        '
        'txtmodel
        '
        Me.txtmodel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmodel.DefaultText = ""
        Me.txtmodel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmodel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmodel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmodel.DisabledState.Parent = Me.txtmodel
        Me.txtmodel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmodel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmodel.FocusedState.Parent = Me.txtmodel
        Me.txtmodel.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtmodel.ForeColor = System.Drawing.Color.Black
        Me.txtmodel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmodel.HoverState.Parent = Me.txtmodel
        Me.txtmodel.Location = New System.Drawing.Point(620, 165)
        Me.txtmodel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmodel.PlaceholderText = ""
        Me.txtmodel.SelectedText = ""
        Me.txtmodel.ShadowDecoration.Parent = Me.txtmodel
        Me.txtmodel.Size = New System.Drawing.Size(200, 36)
        Me.txtmodel.TabIndex = 72
        '
        'txtBrand
        '
        Me.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBrand.DefaultText = ""
        Me.txtBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBrand.DisabledState.Parent = Me.txtBrand
        Me.txtBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBrand.FocusedState.Parent = Me.txtBrand
        Me.txtBrand.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtBrand.ForeColor = System.Drawing.Color.Black
        Me.txtBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBrand.HoverState.Parent = Me.txtBrand
        Me.txtBrand.Location = New System.Drawing.Point(620, 95)
        Me.txtBrand.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrand.PlaceholderText = ""
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.ShadowDecoration.Parent = Me.txtBrand
        Me.txtBrand.Size = New System.Drawing.Size(200, 36)
        Me.txtBrand.TabIndex = 71
        '
        'btnSave
        '
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(591, 797)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 70
        Me.btnSave.Text = "Save"
        '
        'txtprice
        '
        Me.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprice.DefaultText = ""
        Me.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtprice.DisabledState.Parent = Me.txtprice
        Me.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtprice.FocusedState.Parent = Me.txtprice
        Me.txtprice.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtprice.ForeColor = System.Drawing.Color.Black
        Me.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtprice.HoverState.Parent = Me.txtprice
        Me.txtprice.Location = New System.Drawing.Point(643, 571)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprice.PlaceholderText = ""
        Me.txtprice.SelectedText = ""
        Me.txtprice.ShadowDecoration.Parent = Me.txtprice
        Me.txtprice.Size = New System.Drawing.Size(200, 36)
        Me.txtprice.TabIndex = 69
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(506, 571)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(62, 26)
        Me.lblprice.TabIndex = 68
        Me.lblprice.Text = "Price"
        '
        'txtfeatures
        '
        Me.txtfeatures.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeatures.Location = New System.Drawing.Point(643, 708)
        Me.txtfeatures.Name = "txtfeatures"
        Me.txtfeatures.Size = New System.Drawing.Size(206, 47)
        Me.txtfeatures.TabIndex = 67
        Me.txtfeatures.Text = ""
        '
        'lblfeat
        '
        Me.lblfeat.AutoSize = True
        Me.lblfeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfeat.Location = New System.Drawing.Point(496, 703)
        Me.lblfeat.Name = "lblfeat"
        Me.lblfeat.Size = New System.Drawing.Size(108, 52)
        Me.lblfeat.TabIndex = 66
        Me.lblfeat.Text = "Additional" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Features"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(509, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 26)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Brand"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 26)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Item type"
        '
        'cmbItem
        '
        Me.cmbItem.BackColor = System.Drawing.Color.Transparent
        Me.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItem.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbItem.FocusedState.Parent = Me.cmbItem
        Me.cmbItem.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.cmbItem.ForeColor = System.Drawing.Color.Black
        Me.cmbItem.HoverState.Parent = Me.cmbItem
        Me.cmbItem.ItemHeight = 30
        Me.cmbItem.Items.AddRange(New Object() {"Mobile", "Tv", "Shoe", "Dslr", "Watch", "Earphone"})
        Me.cmbItem.ItemsAppearance.Parent = Me.cmbItem
        Me.cmbItem.Location = New System.Drawing.Point(620, 24)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.ShadowDecoration.Parent = Me.cmbItem
        Me.cmbItem.Size = New System.Drawing.Size(200, 36)
        Me.cmbItem.TabIndex = 62
        '
        'selectBtn
        '
        Me.selectBtn.CheckedState.Parent = Me.selectBtn
        Me.selectBtn.CustomImages.Parent = Me.selectBtn
        Me.selectBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.selectBtn.ForeColor = System.Drawing.Color.Black
        Me.selectBtn.HoverState.Parent = Me.selectBtn
        Me.selectBtn.Location = New System.Drawing.Point(88, 466)
        Me.selectBtn.Name = "selectBtn"
        Me.selectBtn.ShadowDecoration.Parent = Me.selectBtn
        Me.selectBtn.Size = New System.Drawing.Size(180, 45)
        Me.selectBtn.TabIndex = 2
        Me.selectBtn.Text = "Select image"
        '
        'pbItem
        '
        Me.pbItem.Location = New System.Drawing.Point(33, 24)
        Me.pbItem.Name = "pbItem"
        Me.pbItem.ShadowDecoration.Parent = Me.pbItem
        Me.pbItem.Size = New System.Drawing.Size(310, 419)
        Me.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbItem.TabIndex = 1
        Me.pbItem.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(1483, 1054)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Adminfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1482, 1051)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Adminfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Adminfrm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnlram.ResumeLayout(False)
        Me.pnlram.PerformLayout()
        Me.pnlclr.ResumeLayout(False)
        Me.pnlclr.PerformLayout()
        Me.pnllens.ResumeLayout(False)
        Me.pnllens.PerformLayout()
        Me.pnlinches.ResumeLayout(False)
        Me.pnlinches.PerformLayout()
        Me.pnlsize.ResumeLayout(False)
        Me.pnlsize.PerformLayout()
        CType(Me.pbItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents selectBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbItem As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtpieces As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlram As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnlclr As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtColor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pnllens As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents rd14 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents rd35 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rd85 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents pnlinches As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents rd50 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rd32 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rd43 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rd65 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents pnlsize As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents rd10 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rd9 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rd8 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rd7 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtmodel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBrand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblprice As Label
    Friend WithEvents txtfeatures As RichTextBox
    Friend WithEvents lblfeat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbItem As Guna.UI2.WinForms.Guna2ComboBox
End Class
