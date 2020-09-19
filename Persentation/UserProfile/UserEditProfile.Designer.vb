<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEditProfile
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkEditPass = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxOldPass = New System.Windows.Forms.TextBox()
        Me.IconButtonCancel = New FontAwesome.Sharp.IconButton()
        Me.IconButtonConfirm = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRePass = New System.Windows.Forms.TextBox()
        Me.TextBoxNewPass = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.LabelEditProfile = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconBtnBack = New FontAwesome.Sharp.IconButton()
        Me.IconButtonEdit = New FontAwesome.Sharp.IconButton()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPosition = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.LinkEditPass)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBoxOldPass)
        Me.Panel1.Controls.Add(Me.IconButtonCancel)
        Me.Panel1.Controls.Add(Me.IconButtonConfirm)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxRePass)
        Me.Panel1.Controls.Add(Me.TextBoxNewPass)
        Me.Panel1.Controls.Add(Me.TextBoxUsername)
        Me.Panel1.Controls.Add(Me.TextBoxEmail)
        Me.Panel1.Controls.Add(Me.TextBoxLastName)
        Me.Panel1.Controls.Add(Me.TextBoxFirstName)
        Me.Panel1.Controls.Add(Me.LabelEditProfile)
        Me.Panel1.Location = New System.Drawing.Point(387, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(400, 527)
        Me.Panel1.MinimumSize = New System.Drawing.Size(0, 527)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 527)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.CheckBox1.Location = New System.Drawing.Point(166, 344)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 20)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkEditPass
        '
        Me.LinkEditPass.AutoSize = True
        Me.LinkEditPass.LinkColor = System.Drawing.Color.Gainsboro
        Me.LinkEditPass.Location = New System.Drawing.Point(121, 254)
        Me.LinkEditPass.Name = "LinkEditPass"
        Me.LinkEditPass.Size = New System.Drawing.Size(25, 13)
        Me.LinkEditPass.TabIndex = 17
        Me.LinkEditPass.TabStop = True
        Me.LinkEditPass.Text = "Edit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(24, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Old Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxOldPass
        '
        Me.TextBoxOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxOldPass.Location = New System.Drawing.Point(166, 254)
        Me.TextBoxOldPass.Name = "TextBoxOldPass"
        Me.TextBoxOldPass.Size = New System.Drawing.Size(197, 13)
        Me.TextBoxOldPass.TabIndex = 15
        Me.TextBoxOldPass.UseSystemPasswordChar = True
        '
        'IconButtonCancel
        '
        Me.IconButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.IconButtonCancel.FlatAppearance.BorderSize = 0
        Me.IconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonCancel.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonCancel.IconColor = System.Drawing.Color.Black
        Me.IconButtonCancel.IconSize = 16
        Me.IconButtonCancel.Location = New System.Drawing.Point(57, 400)
        Me.IconButtonCancel.Name = "IconButtonCancel"
        Me.IconButtonCancel.Rotation = 0R
        Me.IconButtonCancel.Size = New System.Drawing.Size(129, 44)
        Me.IconButtonCancel.TabIndex = 14
        Me.IconButtonCancel.Text = "Cancel"
        Me.IconButtonCancel.UseVisualStyleBackColor = False
        '
        'IconButtonConfirm
        '
        Me.IconButtonConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.IconButtonConfirm.FlatAppearance.BorderSize = 0
        Me.IconButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonConfirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonConfirm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonConfirm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonConfirm.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonConfirm.IconColor = System.Drawing.Color.Black
        Me.IconButtonConfirm.IconSize = 16
        Me.IconButtonConfirm.Location = New System.Drawing.Point(219, 400)
        Me.IconButtonConfirm.Name = "IconButtonConfirm"
        Me.IconButtonConfirm.Rotation = 0R
        Me.IconButtonConfirm.Size = New System.Drawing.Size(129, 44)
        Me.IconButtonConfirm.TabIndex = 13
        Me.IconButtonConfirm.Text = "Confirm"
        Me.IconButtonConfirm.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(24, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Re New Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(24, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "New Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(24, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Username"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(24, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Email"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(24, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(24, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxRePass
        '
        Me.TextBoxRePass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxRePass.Location = New System.Drawing.Point(166, 320)
        Me.TextBoxRePass.Name = "TextBoxRePass"
        Me.TextBoxRePass.Size = New System.Drawing.Size(197, 13)
        Me.TextBoxRePass.TabIndex = 6
        Me.TextBoxRePass.UseSystemPasswordChar = True
        '
        'TextBoxNewPass
        '
        Me.TextBoxNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNewPass.Location = New System.Drawing.Point(166, 289)
        Me.TextBoxNewPass.Name = "TextBoxNewPass"
        Me.TextBoxNewPass.Size = New System.Drawing.Size(197, 13)
        Me.TextBoxNewPass.TabIndex = 5
        Me.TextBoxNewPass.UseSystemPasswordChar = True
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsername.Location = New System.Drawing.Point(166, 221)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(197, 13)
        Me.TextBoxUsername.TabIndex = 4
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxEmail.Location = New System.Drawing.Point(166, 188)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(197, 13)
        Me.TextBoxEmail.TabIndex = 3
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxLastName.Location = New System.Drawing.Point(166, 154)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(197, 13)
        Me.TextBoxLastName.TabIndex = 2
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFirstName.Location = New System.Drawing.Point(166, 118)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(197, 13)
        Me.TextBoxFirstName.TabIndex = 1
        '
        'LabelEditProfile
        '
        Me.LabelEditProfile.AutoSize = True
        Me.LabelEditProfile.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEditProfile.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelEditProfile.Location = New System.Drawing.Point(140, 33)
        Me.LabelEditProfile.Name = "LabelEditProfile"
        Me.LabelEditProfile.Size = New System.Drawing.Size(114, 21)
        Me.LabelEditProfile.TabIndex = 0
        Me.LabelEditProfile.Text = "Edit Account"
        Me.LabelEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.IconBtnBack)
        Me.Panel2.Controls.Add(Me.IconButtonEdit)
        Me.Panel2.Controls.Add(Me.LabelUsername)
        Me.Panel2.Controls.Add(Me.LabelPosition)
        Me.Panel2.Controls.Add(Me.LabelEmail)
        Me.Panel2.Controls.Add(Me.LabelLastName)
        Me.Panel2.Controls.Add(Me.LabelFirstName)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(388, 527)
        Me.Panel2.MinimumSize = New System.Drawing.Size(388, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 527)
        Me.Panel2.TabIndex = 1
        '
        'IconBtnBack
        '
        Me.IconBtnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconBtnBack.FlatAppearance.BorderSize = 0
        Me.IconBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.IconBtnBack.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnBack.IconSize = 16
        Me.IconBtnBack.Location = New System.Drawing.Point(1, 2)
        Me.IconBtnBack.Name = "IconBtnBack"
        Me.IconBtnBack.Rotation = 0R
        Me.IconBtnBack.Size = New System.Drawing.Size(27, 24)
        Me.IconBtnBack.TabIndex = 2
        Me.IconBtnBack.UseVisualStyleBackColor = False
        '
        'IconButtonEdit
        '
        Me.IconButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.IconButtonEdit.FlatAppearance.BorderSize = 0
        Me.IconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonEdit.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButtonEdit.IconColor = System.Drawing.Color.Black
        Me.IconButtonEdit.IconSize = 16
        Me.IconButtonEdit.Location = New System.Drawing.Point(96, 429)
        Me.IconButtonEdit.Name = "IconButtonEdit"
        Me.IconButtonEdit.Rotation = 0R
        Me.IconButtonEdit.Size = New System.Drawing.Size(129, 44)
        Me.IconButtonEdit.TabIndex = 17
        Me.IconButtonEdit.Text = "Edit"
        Me.IconButtonEdit.UseVisualStyleBackColor = False
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelUsername.Location = New System.Drawing.Point(168, 398)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(71, 17)
        Me.LabelUsername.TabIndex = 26
        Me.LabelUsername.Text = "Username"
        Me.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPosition
        '
        Me.LabelPosition.AutoSize = True
        Me.LabelPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPosition.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelPosition.Location = New System.Drawing.Point(168, 361)
        Me.LabelPosition.Name = "LabelPosition"
        Me.LabelPosition.Size = New System.Drawing.Size(71, 17)
        Me.LabelPosition.TabIndex = 22
        Me.LabelPosition.Text = "Username"
        Me.LabelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelEmail.Location = New System.Drawing.Point(168, 329)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(43, 17)
        Me.LabelEmail.TabIndex = 25
        Me.LabelEmail.Text = "Email"
        Me.LabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelLastName.Location = New System.Drawing.Point(168, 295)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(77, 17)
        Me.LabelLastName.TabIndex = 24
        Me.LabelLastName.Text = "Last Name"
        Me.LabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelFirstName.Location = New System.Drawing.Point(168, 259)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(75, 17)
        Me.LabelFirstName.TabIndex = 23
        Me.LabelFirstName.Text = "First Name"
        Me.LabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(62, 398)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Username"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(62, 361)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Position"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(62, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Email"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(62, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Last Name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(62, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "First Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(143, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "My Profile"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Persentation.My.Resources.Resources.cewek
        Me.PictureBox1.Location = New System.Drawing.Point(88, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'UserEditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 527)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(778, 527)
        Me.MinimumSize = New System.Drawing.Size(388, 527)
        Me.Name = "UserEditProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserEditProfile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents LabelEditProfile As Label
    Friend WithEvents TextBoxRePass As TextBox
    Friend WithEvents TextBoxNewPass As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents IconButtonConfirm As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButtonCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxOldPass As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPosition As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelLastName As Label
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButtonEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents LinkEditPass As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents IconBtnBack As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
End Class
