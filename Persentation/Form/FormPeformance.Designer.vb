<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPeformance
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Download = New FontAwesome.Sharp.IconButton()
        Me.PanellListKandang = New System.Windows.Forms.Panel()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox09 = New System.Windows.Forms.CheckBox()
        Me.CheckBox08 = New System.Windows.Forms.CheckBox()
        Me.CheckBox07 = New System.Windows.Forms.CheckBox()
        Me.CheckBox06 = New System.Windows.Forms.CheckBox()
        Me.CheckBox05 = New System.Windows.Forms.CheckBox()
        Me.CheckBox04 = New System.Windows.Forms.CheckBox()
        Me.CheckBox03 = New System.Windows.Forms.CheckBox()
        Me.CheckBox02 = New System.Windows.Forms.CheckBox()
        Me.CheckBox01 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxall = New System.Windows.Forms.CheckBox()
        Me.IconButtonListKandang = New FontAwesome.Sharp.IconButton()
        Me.ListFarmOption = New System.Windows.Forms.Panel()
        Me.CheckBoxBr3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBr2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBr1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBrAll = New System.Windows.Forms.CheckBox()
        Me.IconButtonListFarm = New FontAwesome.Sharp.IconButton()
        Me.ListFarm = New System.Windows.Forms.Timer(Me.components)
        Me.ListKandang = New System.Windows.Forms.Timer(Me.components)
        Me.IconButtonSearch = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.PanellListKandang.SuspendLayout()
        Me.ListFarmOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(39, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 348)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(37, 25)
        Me.TextBox1.MinimumSize = New System.Drawing.Size(544, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(544, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.Panel2.Controls.Add(Me.Download)
        Me.Panel2.Controls.Add(Me.PanellListKandang)
        Me.Panel2.Controls.Add(Me.IconButtonListKandang)
        Me.Panel2.Controls.Add(Me.ListFarmOption)
        Me.Panel2.Controls.Add(Me.IconButtonListFarm)
        Me.Panel2.Location = New System.Drawing.Point(609, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 391)
        Me.Panel2.TabIndex = 3
        '
        'Download
        '
        Me.Download.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Download.Dock = System.Windows.Forms.DockStyle.Top
        Me.Download.FlatAppearance.BorderSize = 0
        Me.Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Download.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Download.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Download.ForeColor = System.Drawing.Color.Gainsboro
        Me.Download.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.Download.IconColor = System.Drawing.Color.Gainsboro
        Me.Download.IconSize = 16
        Me.Download.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Download.Location = New System.Drawing.Point(0, 433)
        Me.Download.Name = "Download"
        Me.Download.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Download.Rotation = 0R
        Me.Download.Size = New System.Drawing.Size(146, 34)
        Me.Download.TabIndex = 9
        Me.Download.Text = "Download"
        Me.Download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Download.UseVisualStyleBackColor = False
        '
        'PanellListKandang
        '
        Me.PanellListKandang.Controls.Add(Me.CheckBox12)
        Me.PanellListKandang.Controls.Add(Me.CheckBox11)
        Me.PanellListKandang.Controls.Add(Me.CheckBox10)
        Me.PanellListKandang.Controls.Add(Me.CheckBox09)
        Me.PanellListKandang.Controls.Add(Me.CheckBox08)
        Me.PanellListKandang.Controls.Add(Me.CheckBox07)
        Me.PanellListKandang.Controls.Add(Me.CheckBox06)
        Me.PanellListKandang.Controls.Add(Me.CheckBox05)
        Me.PanellListKandang.Controls.Add(Me.CheckBox04)
        Me.PanellListKandang.Controls.Add(Me.CheckBox03)
        Me.PanellListKandang.Controls.Add(Me.CheckBox02)
        Me.PanellListKandang.Controls.Add(Me.CheckBox01)
        Me.PanellListKandang.Controls.Add(Me.CheckBoxall)
        Me.PanellListKandang.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanellListKandang.Location = New System.Drawing.Point(0, 159)
        Me.PanellListKandang.MaximumSize = New System.Drawing.Size(146, 274)
        Me.PanellListKandang.MinimumSize = New System.Drawing.Size(146, 0)
        Me.PanellListKandang.Name = "PanellListKandang"
        Me.PanellListKandang.Size = New System.Drawing.Size(146, 274)
        Me.PanellListKandang.TabIndex = 8
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox12.FlatAppearance.BorderSize = 0
        Me.CheckBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox12.Location = New System.Drawing.Point(0, 252)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox12.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox12.TabIndex = 12
        Me.CheckBox12.Text = "12"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox11.FlatAppearance.BorderSize = 0
        Me.CheckBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox11.Location = New System.Drawing.Point(0, 231)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox11.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox11.TabIndex = 11
        Me.CheckBox11.Text = "11"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox10.FlatAppearance.BorderSize = 0
        Me.CheckBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox10.Location = New System.Drawing.Point(0, 210)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox10.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox10.TabIndex = 10
        Me.CheckBox10.Text = "10"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox09
        '
        Me.CheckBox09.AutoSize = True
        Me.CheckBox09.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox09.FlatAppearance.BorderSize = 0
        Me.CheckBox09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox09.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox09.Location = New System.Drawing.Point(0, 189)
        Me.CheckBox09.Name = "CheckBox09"
        Me.CheckBox09.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox09.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox09.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox09.TabIndex = 9
        Me.CheckBox09.Text = "09"
        Me.CheckBox09.UseVisualStyleBackColor = True
        '
        'CheckBox08
        '
        Me.CheckBox08.AutoSize = True
        Me.CheckBox08.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox08.FlatAppearance.BorderSize = 0
        Me.CheckBox08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox08.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox08.Location = New System.Drawing.Point(0, 168)
        Me.CheckBox08.Name = "CheckBox08"
        Me.CheckBox08.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox08.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox08.TabIndex = 8
        Me.CheckBox08.Text = "08"
        Me.CheckBox08.UseVisualStyleBackColor = True
        '
        'CheckBox07
        '
        Me.CheckBox07.AutoSize = True
        Me.CheckBox07.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox07.FlatAppearance.BorderSize = 0
        Me.CheckBox07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox07.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox07.Location = New System.Drawing.Point(0, 147)
        Me.CheckBox07.Name = "CheckBox07"
        Me.CheckBox07.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox07.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox07.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox07.TabIndex = 7
        Me.CheckBox07.Text = "07"
        Me.CheckBox07.UseVisualStyleBackColor = True
        '
        'CheckBox06
        '
        Me.CheckBox06.AutoSize = True
        Me.CheckBox06.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox06.FlatAppearance.BorderSize = 0
        Me.CheckBox06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox06.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox06.Location = New System.Drawing.Point(0, 126)
        Me.CheckBox06.Name = "CheckBox06"
        Me.CheckBox06.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox06.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox06.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox06.TabIndex = 6
        Me.CheckBox06.Text = "06"
        Me.CheckBox06.UseVisualStyleBackColor = True
        '
        'CheckBox05
        '
        Me.CheckBox05.AutoSize = True
        Me.CheckBox05.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox05.FlatAppearance.BorderSize = 0
        Me.CheckBox05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox05.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox05.Location = New System.Drawing.Point(0, 105)
        Me.CheckBox05.Name = "CheckBox05"
        Me.CheckBox05.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox05.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox05.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox05.TabIndex = 5
        Me.CheckBox05.Text = "05"
        Me.CheckBox05.UseVisualStyleBackColor = True
        '
        'CheckBox04
        '
        Me.CheckBox04.AutoSize = True
        Me.CheckBox04.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox04.FlatAppearance.BorderSize = 0
        Me.CheckBox04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox04.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox04.Location = New System.Drawing.Point(0, 84)
        Me.CheckBox04.Name = "CheckBox04"
        Me.CheckBox04.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox04.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox04.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox04.TabIndex = 4
        Me.CheckBox04.Text = "04"
        Me.CheckBox04.UseVisualStyleBackColor = True
        '
        'CheckBox03
        '
        Me.CheckBox03.AutoSize = True
        Me.CheckBox03.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox03.FlatAppearance.BorderSize = 0
        Me.CheckBox03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox03.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox03.Location = New System.Drawing.Point(0, 63)
        Me.CheckBox03.Name = "CheckBox03"
        Me.CheckBox03.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox03.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox03.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox03.TabIndex = 3
        Me.CheckBox03.Text = "03"
        Me.CheckBox03.UseVisualStyleBackColor = True
        '
        'CheckBox02
        '
        Me.CheckBox02.AutoSize = True
        Me.CheckBox02.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox02.FlatAppearance.BorderSize = 0
        Me.CheckBox02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox02.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox02.Location = New System.Drawing.Point(0, 42)
        Me.CheckBox02.Name = "CheckBox02"
        Me.CheckBox02.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox02.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox02.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox02.TabIndex = 2
        Me.CheckBox02.Text = "02"
        Me.CheckBox02.UseVisualStyleBackColor = True
        '
        'CheckBox01
        '
        Me.CheckBox01.AutoSize = True
        Me.CheckBox01.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox01.FlatAppearance.BorderSize = 0
        Me.CheckBox01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox01.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox01.Location = New System.Drawing.Point(0, 21)
        Me.CheckBox01.Name = "CheckBox01"
        Me.CheckBox01.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBox01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox01.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox01.TabIndex = 1
        Me.CheckBox01.Text = "01"
        Me.CheckBox01.UseVisualStyleBackColor = True
        '
        'CheckBoxall
        '
        Me.CheckBoxall.AutoSize = True
        Me.CheckBoxall.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBoxall.FlatAppearance.BorderSize = 0
        Me.CheckBoxall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxall.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxall.Location = New System.Drawing.Point(0, 0)
        Me.CheckBoxall.Name = "CheckBoxall"
        Me.CheckBoxall.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBoxall.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxall.Size = New System.Drawing.Size(146, 21)
        Me.CheckBoxall.TabIndex = 0
        Me.CheckBoxall.Text = "All"
        Me.CheckBoxall.UseVisualStyleBackColor = True
        '
        'IconButtonListKandang
        '
        Me.IconButtonListKandang.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonListKandang.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonListKandang.FlatAppearance.BorderSize = 0
        Me.IconButtonListKandang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonListKandang.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonListKandang.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonListKandang.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonListKandang.IconChar = FontAwesome.Sharp.IconChar.SortDown
        Me.IconButtonListKandang.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonListKandang.IconSize = 16
        Me.IconButtonListKandang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonListKandang.Location = New System.Drawing.Point(0, 125)
        Me.IconButtonListKandang.Name = "IconButtonListKandang"
        Me.IconButtonListKandang.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconButtonListKandang.Rotation = 0R
        Me.IconButtonListKandang.Size = New System.Drawing.Size(146, 34)
        Me.IconButtonListKandang.TabIndex = 7
        Me.IconButtonListKandang.Text = "List Kandang"
        Me.IconButtonListKandang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonListKandang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonListKandang.UseVisualStyleBackColor = False
        '
        'ListFarmOption
        '
        Me.ListFarmOption.Controls.Add(Me.CheckBoxBr3)
        Me.ListFarmOption.Controls.Add(Me.CheckBoxBr2)
        Me.ListFarmOption.Controls.Add(Me.CheckBoxBr1)
        Me.ListFarmOption.Controls.Add(Me.CheckBoxBrAll)
        Me.ListFarmOption.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListFarmOption.Location = New System.Drawing.Point(0, 34)
        Me.ListFarmOption.MaximumSize = New System.Drawing.Size(146, 91)
        Me.ListFarmOption.MinimumSize = New System.Drawing.Size(146, 0)
        Me.ListFarmOption.Name = "ListFarmOption"
        Me.ListFarmOption.Size = New System.Drawing.Size(146, 91)
        Me.ListFarmOption.TabIndex = 4
        '
        'CheckBoxBr3
        '
        Me.CheckBoxBr3.AutoSize = True
        Me.CheckBoxBr3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBoxBr3.FlatAppearance.BorderSize = 0
        Me.CheckBoxBr3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxBr3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxBr3.Location = New System.Drawing.Point(0, 63)
        Me.CheckBoxBr3.Name = "CheckBoxBr3"
        Me.CheckBoxBr3.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBoxBr3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxBr3.Size = New System.Drawing.Size(146, 21)
        Me.CheckBoxBr3.TabIndex = 3
        Me.CheckBoxBr3.Text = "BR-III Nasuba"
        Me.CheckBoxBr3.UseVisualStyleBackColor = True
        '
        'CheckBoxBr2
        '
        Me.CheckBoxBr2.AutoSize = True
        Me.CheckBoxBr2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBoxBr2.FlatAppearance.BorderSize = 0
        Me.CheckBoxBr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxBr2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxBr2.Location = New System.Drawing.Point(0, 42)
        Me.CheckBoxBr2.Name = "CheckBoxBr2"
        Me.CheckBoxBr2.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBoxBr2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxBr2.Size = New System.Drawing.Size(146, 21)
        Me.CheckBoxBr2.TabIndex = 2
        Me.CheckBoxBr2.Text = "BR-II Nasuba"
        Me.CheckBoxBr2.UseVisualStyleBackColor = True
        '
        'CheckBoxBr1
        '
        Me.CheckBoxBr1.AutoSize = True
        Me.CheckBoxBr1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBoxBr1.FlatAppearance.BorderSize = 0
        Me.CheckBoxBr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxBr1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxBr1.Location = New System.Drawing.Point(0, 21)
        Me.CheckBoxBr1.Name = "CheckBoxBr1"
        Me.CheckBoxBr1.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBoxBr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxBr1.Size = New System.Drawing.Size(146, 21)
        Me.CheckBoxBr1.TabIndex = 1
        Me.CheckBoxBr1.Text = "BR-I Nasuba"
        Me.CheckBoxBr1.UseVisualStyleBackColor = True
        '
        'CheckBoxBrAll
        '
        Me.CheckBoxBrAll.AutoSize = True
        Me.CheckBoxBrAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBoxBrAll.FlatAppearance.BorderSize = 0
        Me.CheckBoxBrAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxBrAll.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxBrAll.Location = New System.Drawing.Point(0, 0)
        Me.CheckBoxBrAll.Name = "CheckBoxBrAll"
        Me.CheckBoxBrAll.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.CheckBoxBrAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxBrAll.Size = New System.Drawing.Size(146, 21)
        Me.CheckBoxBrAll.TabIndex = 0
        Me.CheckBoxBrAll.Text = "All"
        Me.CheckBoxBrAll.UseVisualStyleBackColor = True
        '
        'IconButtonListFarm
        '
        Me.IconButtonListFarm.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonListFarm.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonListFarm.FlatAppearance.BorderSize = 0
        Me.IconButtonListFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonListFarm.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonListFarm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonListFarm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonListFarm.IconChar = FontAwesome.Sharp.IconChar.SortDown
        Me.IconButtonListFarm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonListFarm.IconSize = 16
        Me.IconButtonListFarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonListFarm.Location = New System.Drawing.Point(0, 0)
        Me.IconButtonListFarm.Name = "IconButtonListFarm"
        Me.IconButtonListFarm.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconButtonListFarm.Rotation = 0R
        Me.IconButtonListFarm.Size = New System.Drawing.Size(146, 34)
        Me.IconButtonListFarm.TabIndex = 3
        Me.IconButtonListFarm.Text = "List Farm"
        Me.IconButtonListFarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonListFarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonListFarm.UseVisualStyleBackColor = False
        '
        'ListFarm
        '
        Me.ListFarm.Interval = 15
        '
        'ListKandang
        '
        Me.ListKandang.Interval = 15
        '
        'IconButtonSearch
        '
        Me.IconButtonSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButtonSearch.FlatAppearance.BorderSize = 0
        Me.IconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonSearch.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButtonSearch.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSearch.IconSize = 16
        Me.IconButtonSearch.Location = New System.Drawing.Point(609, 25)
        Me.IconButtonSearch.Name = "IconButtonSearch"
        Me.IconButtonSearch.Rotation = 0R
        Me.IconButtonSearch.Size = New System.Drawing.Size(163, 34)
        Me.IconButtonSearch.TabIndex = 2
        Me.IconButtonSearch.Text = "Search"
        Me.IconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonSearch.UseVisualStyleBackColor = False
        '
        'FormPeformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 455)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconButtonSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPeformance"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "FormPeformance"
        Me.Panel2.ResumeLayout(False)
        Me.PanellListKandang.ResumeLayout(False)
        Me.PanellListKandang.PerformLayout()
        Me.ListFarmOption.ResumeLayout(False)
        Me.ListFarmOption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IconButtonSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListFarmOption As Panel
    Friend WithEvents CheckBoxBr2 As CheckBox
    Friend WithEvents CheckBoxBr1 As CheckBox
    Friend WithEvents CheckBoxBrAll As CheckBox
    Friend WithEvents IconButtonListFarm As FontAwesome.Sharp.IconButton
    Friend WithEvents CheckBoxBr3 As CheckBox
    Friend WithEvents PanellListKandang As Panel
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox09 As CheckBox
    Friend WithEvents CheckBox08 As CheckBox
    Friend WithEvents CheckBox07 As CheckBox
    Friend WithEvents CheckBox06 As CheckBox
    Friend WithEvents CheckBox05 As CheckBox
    Friend WithEvents CheckBox04 As CheckBox
    Friend WithEvents CheckBox03 As CheckBox
    Friend WithEvents CheckBox02 As CheckBox
    Friend WithEvents CheckBox01 As CheckBox
    Friend WithEvents CheckBoxall As CheckBox
    Friend WithEvents IconButtonListKandang As FontAwesome.Sharp.IconButton
    Friend WithEvents ListFarm As Timer
    Friend WithEvents ListKandang As Timer
    Friend WithEvents Download As FontAwesome.Sharp.IconButton
End Class
