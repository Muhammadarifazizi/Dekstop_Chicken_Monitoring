﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenangkapan
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
        Me.IconButtonDelete = New FontAwesome.Sharp.IconButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IconButtonUpdate = New FontAwesome.Sharp.IconButton()
        Me.IconButtonAdd = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxJlhBesar = New System.Windows.Forms.TextBox()
        Me.TextBoxTtlBerat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxFarmId = New System.Windows.Forms.ComboBox()
        Me.TextBoxJlhKecil = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxJlhSedang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButtonCancel = New FontAwesome.Sharp.IconButton()
        Me.IconButtonSave = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconButtonDelete
        '
        Me.IconButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonDelete.FlatAppearance.BorderSize = 0
        Me.IconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButtonDelete.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonDelete.IconSize = 16
        Me.IconButtonDelete.Location = New System.Drawing.Point(511, 401)
        Me.IconButtonDelete.Name = "IconButtonDelete"
        Me.IconButtonDelete.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.IconButtonDelete.Rotation = 0R
        Me.IconButtonDelete.Size = New System.Drawing.Size(86, 42)
        Me.IconButtonDelete.TabIndex = 22
        Me.IconButtonDelete.Text = "Delete"
        Me.IconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonDelete.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(23, 9)
        Me.TextBox1.MinimumSize = New System.Drawing.Size(544, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(748, 20)
        Me.TextBox1.TabIndex = 23
        '
        'IconButtonUpdate
        '
        Me.IconButtonUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButtonUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonUpdate.FlatAppearance.BorderSize = 0
        Me.IconButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonUpdate.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButtonUpdate.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonUpdate.IconSize = 16
        Me.IconButtonUpdate.Location = New System.Drawing.Point(416, 401)
        Me.IconButtonUpdate.Name = "IconButtonUpdate"
        Me.IconButtonUpdate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.IconButtonUpdate.Rotation = 0R
        Me.IconButtonUpdate.Size = New System.Drawing.Size(86, 42)
        Me.IconButtonUpdate.TabIndex = 20
        Me.IconButtonUpdate.Text = "Update"
        Me.IconButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonUpdate.UseVisualStyleBackColor = False
        '
        'IconButtonAdd
        '
        Me.IconButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonAdd.FlatAppearance.BorderSize = 0
        Me.IconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonAdd.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconButtonAdd.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonAdd.IconSize = 16
        Me.IconButtonAdd.Location = New System.Drawing.Point(321, 401)
        Me.IconButtonAdd.Name = "IconButtonAdd"
        Me.IconButtonAdd.Rotation = 0R
        Me.IconButtonAdd.Size = New System.Drawing.Size(86, 42)
        Me.IconButtonAdd.TabIndex = 19
        Me.IconButtonAdd.Text = "Add"
        Me.IconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonAdd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(320, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 331)
        Me.Panel1.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(451, 331)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxJlhBesar)
        Me.Panel2.Controls.Add(Me.TextBoxTtlBerat)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ComboBoxFarmId)
        Me.Panel2.Controls.Add(Me.TextBoxJlhKecil)
        Me.Panel2.Controls.Add(Me.DateTimePicker)
        Me.Panel2.Controls.Add(Me.TextBoxJlhSedang)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.IconButtonCancel)
        Me.Panel2.Controls.Add(Me.IconButtonSave)
        Me.Panel2.Location = New System.Drawing.Point(23, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 379)
        Me.Panel2.TabIndex = 45
        '
        'TextBoxJlhBesar
        '
        Me.TextBoxJlhBesar.Location = New System.Drawing.Point(123, 130)
        Me.TextBoxJlhBesar.Name = "TextBoxJlhBesar"
        Me.TextBoxJlhBesar.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxJlhBesar.TabIndex = 49
        '
        'TextBoxTtlBerat
        '
        Me.TextBoxTtlBerat.Location = New System.Drawing.Point(123, 158)
        Me.TextBoxTtlBerat.Name = "TextBoxTtlBerat"
        Me.TextBoxTtlBerat.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxTtlBerat.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Ttl Berat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Jlh Besar"
        '
        'ComboBoxFarmId
        '
        Me.ComboBoxFarmId.FormattingEnabled = True
        Me.ComboBoxFarmId.Items.AddRange(New Object() {"--", "BR1-K01", "BR1-K02", "BR1-K03", "BR1-K04", "BR1-K05", "BR1-K06", "BR1-K07", "BR1-K08", "BR1-K09", "BR1-K10", "BR1-K11", "BR1-K12", "BR2-K01", "BR2-K02", "BR2-K03", "BR2-K04", "BR2-K05", "BR2-K06", "BR2-K07", "BR2-K08", "BR2-K09", "BR2-K10", "BR2-K11", "BR2-K12", "BR3-K01", "BR3-K02", "BR3-K03", "BR3-K04", "BR3-K05", "BR3-K06"})
        Me.ComboBoxFarmId.Location = New System.Drawing.Point(123, 17)
        Me.ComboBoxFarmId.Name = "ComboBoxFarmId"
        Me.ComboBoxFarmId.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxFarmId.TabIndex = 45
        '
        'TextBoxJlhKecil
        '
        Me.TextBoxJlhKecil.Location = New System.Drawing.Point(123, 73)
        Me.TextBoxJlhKecil.Name = "TextBoxJlhKecil"
        Me.TextBoxJlhKecil.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxJlhKecil.TabIndex = 44
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(123, 44)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePicker.TabIndex = 43
        '
        'TextBoxJlhSedang
        '
        Me.TextBoxJlhSedang.Location = New System.Drawing.Point(123, 101)
        Me.TextBoxJlhSedang.Name = "TextBoxJlhSedang"
        Me.TextBoxJlhSedang.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxJlhSedang.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Jlh Sedang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Jlh Kecil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ID Farm"
        '
        'IconButtonCancel
        '
        Me.IconButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonCancel.FlatAppearance.BorderSize = 0
        Me.IconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonCancel.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus
        Me.IconButtonCancel.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonCancel.IconSize = 16
        Me.IconButtonCancel.Location = New System.Drawing.Point(141, 239)
        Me.IconButtonCancel.Name = "IconButtonCancel"
        Me.IconButtonCancel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.IconButtonCancel.Rotation = 0R
        Me.IconButtonCancel.Size = New System.Drawing.Size(86, 42)
        Me.IconButtonCancel.TabIndex = 32
        Me.IconButtonCancel.Text = "Cancel"
        Me.IconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonCancel.UseVisualStyleBackColor = False
        '
        'IconButtonSave
        '
        Me.IconButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonSave.FlatAppearance.BorderSize = 0
        Me.IconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonSave.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.IconButtonSave.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSave.IconSize = 16
        Me.IconButtonSave.Location = New System.Drawing.Point(46, 239)
        Me.IconButtonSave.Name = "IconButtonSave"
        Me.IconButtonSave.Rotation = 0R
        Me.IconButtonSave.Size = New System.Drawing.Size(86, 42)
        Me.IconButtonSave.TabIndex = 31
        Me.IconButtonSave.Text = "Save"
        Me.IconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonSave.UseVisualStyleBackColor = False
        '
        'FormPenangkapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconButtonDelete)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.IconButtonUpdate)
        Me.Controls.Add(Me.IconButtonAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPenangkapan"
        Me.Text = "FormPenangkapan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButtonDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IconButtonUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxJlhBesar As TextBox
    Friend WithEvents TextBoxTtlBerat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxFarmId As ComboBox
    Friend WithEvents TextBoxJlhKecil As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents TextBoxJlhSedang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButtonCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonSave As FontAwesome.Sharp.IconButton
End Class