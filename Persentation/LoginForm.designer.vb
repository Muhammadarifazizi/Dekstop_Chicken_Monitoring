<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.PanelLoginForm = New System.Windows.Forms.Panel()
        Me.LinkLabelForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonLogin = New FontAwesome.Sharp.IconButton()
        Me.IconBtnMinimize = New FontAwesome.Sharp.IconButton()
        Me.IconBtnClose = New FontAwesome.Sharp.IconButton()
        Me.PanelLoginForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLoginForm
        '
        Me.PanelLoginForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelLoginForm.Controls.Add(Me.LinkLabelForgotPassword)
        Me.PanelLoginForm.Controls.Add(Me.PictureBox1)
        Me.PanelLoginForm.Controls.Add(Me.CheckBox)
        Me.PanelLoginForm.Controls.Add(Me.TextBoxPassword)
        Me.PanelLoginForm.Controls.Add(Me.LabelPassword)
        Me.PanelLoginForm.Controls.Add(Me.TextBoxUsername)
        Me.PanelLoginForm.Controls.Add(Me.LabelUsername)
        Me.PanelLoginForm.Controls.Add(Me.ButtonLogin)
        Me.PanelLoginForm.Controls.Add(Me.IconBtnMinimize)
        Me.PanelLoginForm.Controls.Add(Me.IconBtnClose)
        Me.PanelLoginForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLoginForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelLoginForm.Name = "PanelLoginForm"
        Me.PanelLoginForm.Size = New System.Drawing.Size(333, 479)
        Me.PanelLoginForm.TabIndex = 0
        '
        'LinkLabelForgotPassword
        '
        Me.LinkLabelForgotPassword.AutoSize = True
        Me.LinkLabelForgotPassword.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelForgotPassword.LinkColor = System.Drawing.Color.Gainsboro
        Me.LinkLabelForgotPassword.Location = New System.Drawing.Point(111, 431)
        Me.LinkLabelForgotPassword.Name = "LinkLabelForgotPassword"
        Me.LinkLabelForgotPassword.Size = New System.Drawing.Size(103, 16)
        Me.LinkLabelForgotPassword.TabIndex = 9
        Me.LinkLabelForgotPassword.TabStop = True
        Me.LinkLabelForgotPassword.Text = "Forgot password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Persentation.My.Resources.Resources.tes_ayam1
        Me.PictureBox1.Location = New System.Drawing.Point(91, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox.ForeColor = System.Drawing.Color.Gainsboro
        Me.CheckBox.Location = New System.Drawing.Point(36, 323)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(112, 20)
        Me.CheckBox.TabIndex = 7
        Me.CheckBox.Text = "Show password"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.Black
        Me.TextBoxPassword.Location = New System.Drawing.Point(36, 291)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(265, 16)
        Me.TextBoxPassword.TabIndex = 6
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelPassword.Location = New System.Drawing.Point(34, 272)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(69, 17)
        Me.LabelPassword.TabIndex = 5
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.ForeColor = System.Drawing.Color.Black
        Me.TextBoxUsername.Location = New System.Drawing.Point(37, 232)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(265, 16)
        Me.TextBoxUsername.TabIndex = 4
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelUsername.Location = New System.Drawing.Point(35, 213)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(71, 17)
        Me.LabelUsername.TabIndex = 3
        Me.LabelUsername.Text = "Username"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ButtonLogin.FlatAppearance.BorderSize = 0
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ButtonLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.Color.Gainsboro
        Me.ButtonLogin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonLogin.IconColor = System.Drawing.Color.Black
        Me.ButtonLogin.IconSize = 16
        Me.ButtonLogin.Location = New System.Drawing.Point(68, 369)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Rotation = 0R
        Me.ButtonLogin.Size = New System.Drawing.Size(191, 59)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'IconBtnMinimize
        '
        Me.IconBtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconBtnMinimize.FlatAppearance.BorderSize = 0
        Me.IconBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconBtnMinimize.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnMinimize.IconSize = 16
        Me.IconBtnMinimize.Location = New System.Drawing.Point(274, 3)
        Me.IconBtnMinimize.Name = "IconBtnMinimize"
        Me.IconBtnMinimize.Rotation = 0R
        Me.IconBtnMinimize.Size = New System.Drawing.Size(27, 24)
        Me.IconBtnMinimize.TabIndex = 1
        Me.IconBtnMinimize.UseVisualStyleBackColor = False
        '
        'IconBtnClose
        '
        Me.IconBtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconBtnClose.FlatAppearance.BorderSize = 0
        Me.IconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconBtnClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnClose.IconSize = 16
        Me.IconBtnClose.Location = New System.Drawing.Point(303, 3)
        Me.IconBtnClose.Name = "IconBtnClose"
        Me.IconBtnClose.Rotation = 0R
        Me.IconBtnClose.Size = New System.Drawing.Size(27, 24)
        Me.IconBtnClose.TabIndex = 0
        Me.IconBtnClose.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 479)
        Me.Controls.Add(Me.PanelLoginForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelLoginForm.ResumeLayout(False)
        Me.PanelLoginForm.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLoginForm As Panel
    Friend WithEvents IconBtnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LinkLabelForgotPassword As LinkLabel
End Class
