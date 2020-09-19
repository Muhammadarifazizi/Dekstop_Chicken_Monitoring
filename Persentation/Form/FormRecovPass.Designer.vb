<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecovPass
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.IconBtnClose = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(80, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 16)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Email"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(362, 50)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(72, 30)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "Recovery"
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.Black
        Me.lblresult.Location = New System.Drawing.Point(7, 87)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 16)
        Me.lblresult.TabIndex = 3
        Me.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconBtnClose
        '
        Me.IconBtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.IconBtnClose.FlatAppearance.BorderSize = 0
        Me.IconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconBtnClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnClose.IconSize = 16
        Me.IconBtnClose.Location = New System.Drawing.Point(429, 0)
        Me.IconBtnClose.Name = "IconBtnClose"
        Me.IconBtnClose.Rotation = 0R
        Me.IconBtnClose.Size = New System.Drawing.Size(27, 24)
        Me.IconBtnClose.TabIndex = 4
        Me.IconBtnClose.UseVisualStyleBackColor = False
        '
        'FormRecovPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(456, 157)
        Me.Controls.Add(Me.IconBtnClose)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRecovPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRecovPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblresult As Label
    Friend WithEvents IconBtnClose As FontAwesome.Sharp.IconButton
End Class
