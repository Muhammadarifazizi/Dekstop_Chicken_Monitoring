<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButtonSetting = New FontAwesome.Sharp.IconButton()
        Me.IconButtonLog = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPenangkapan = New FontAwesome.Sharp.IconButton()
        Me.IconButtonMutasi = New FontAwesome.Sharp.IconButton()
        Me.IconButtonDeplesi = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPakan = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPeriode = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPeformance = New FontAwesome.Sharp.IconButton()
        Me.IconButtonDashboard = New FontAwesome.Sharp.IconButton()
        Me.IconButtonSignOut = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.IconBtnUser = New FontAwesome.Sharp.IconButton()
        Me.IconBtnMinimize = New FontAwesome.Sharp.IconButton()
        Me.IconBtnResize = New FontAwesome.Sharp.IconButton()
        Me.IconBtnClose = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.DekstopPanel = New System.Windows.Forms.Panel()
        Me.PanelAva = New System.Windows.Forms.Panel()
        Me.AccountSetting = New FontAwesome.Sharp.IconButton()
        Me.IconButtonAVA = New FontAwesome.Sharp.IconButton()
        Me.labelEmailUser = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerAva = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOptionDM = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPeformance = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DekstopPanel.SuspendLayout()
        Me.PanelAva.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButtonSetting)
        Me.PanelMenu.Controls.Add(Me.IconButtonLog)
        Me.PanelMenu.Controls.Add(Me.IconButtonPenangkapan)
        Me.PanelMenu.Controls.Add(Me.IconButtonMutasi)
        Me.PanelMenu.Controls.Add(Me.IconButtonDeplesi)
        Me.PanelMenu.Controls.Add(Me.IconButtonPakan)
        Me.PanelMenu.Controls.Add(Me.IconButtonPeriode)
        Me.PanelMenu.Controls.Add(Me.IconButtonPeformance)
        Me.PanelMenu.Controls.Add(Me.IconButtonDashboard)
        Me.PanelMenu.Controls.Add(Me.IconButtonSignOut)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 570)
        Me.PanelMenu.TabIndex = 0
        '
        'IconButtonSetting
        '
        Me.IconButtonSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconButtonSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonSetting.FlatAppearance.BorderSize = 0
        Me.IconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonSetting.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonSetting.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.Cogs
        Me.IconButtonSetting.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSetting.IconSize = 20
        Me.IconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonSetting.Location = New System.Drawing.Point(0, 424)
        Me.IconButtonSetting.Name = "IconButtonSetting"
        Me.IconButtonSetting.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonSetting.Rotation = 0R
        Me.IconButtonSetting.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonSetting.TabIndex = 25
        Me.IconButtonSetting.Text = "Setting"
        Me.IconButtonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonSetting.UseVisualStyleBackColor = False
        '
        'IconButtonLog
        '
        Me.IconButtonLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonLog.FlatAppearance.BorderSize = 0
        Me.IconButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonLog.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonLog.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonLog.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonLog.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck
        Me.IconButtonLog.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonLog.IconSize = 20
        Me.IconButtonLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLog.Location = New System.Drawing.Point(0, 386)
        Me.IconButtonLog.Name = "IconButtonLog"
        Me.IconButtonLog.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonLog.Rotation = 0R
        Me.IconButtonLog.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonLog.TabIndex = 24
        Me.IconButtonLog.Text = "Log"
        Me.IconButtonLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonLog.UseVisualStyleBackColor = True
        '
        'IconButtonPenangkapan
        '
        Me.IconButtonPenangkapan.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonPenangkapan.FlatAppearance.BorderSize = 0
        Me.IconButtonPenangkapan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPenangkapan.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonPenangkapan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonPenangkapan.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPenangkapan.IconChar = FontAwesome.Sharp.IconChar.TruckLoading
        Me.IconButtonPenangkapan.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPenangkapan.IconSize = 20
        Me.IconButtonPenangkapan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPenangkapan.Location = New System.Drawing.Point(0, 348)
        Me.IconButtonPenangkapan.Name = "IconButtonPenangkapan"
        Me.IconButtonPenangkapan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonPenangkapan.Rotation = 0R
        Me.IconButtonPenangkapan.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonPenangkapan.TabIndex = 22
        Me.IconButtonPenangkapan.Text = "Penangkapan"
        Me.IconButtonPenangkapan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPenangkapan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPenangkapan.UseVisualStyleBackColor = True
        '
        'IconButtonMutasi
        '
        Me.IconButtonMutasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconButtonMutasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonMutasi.FlatAppearance.BorderSize = 0
        Me.IconButtonMutasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMutasi.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonMutasi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonMutasi.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonMutasi.IconChar = FontAwesome.Sharp.IconChar.BalanceScaleRight
        Me.IconButtonMutasi.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonMutasi.IconSize = 16
        Me.IconButtonMutasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonMutasi.Location = New System.Drawing.Point(0, 310)
        Me.IconButtonMutasi.Name = "IconButtonMutasi"
        Me.IconButtonMutasi.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonMutasi.Rotation = 0R
        Me.IconButtonMutasi.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonMutasi.TabIndex = 27
        Me.IconButtonMutasi.Text = "Mutasi"
        Me.IconButtonMutasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonMutasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonMutasi.UseVisualStyleBackColor = False
        '
        'IconButtonDeplesi
        '
        Me.IconButtonDeplesi.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconButtonDeplesi.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonDeplesi.FlatAppearance.BorderSize = 0
        Me.IconButtonDeplesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonDeplesi.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonDeplesi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDeplesi.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonDeplesi.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus
        Me.IconButtonDeplesi.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonDeplesi.IconSize = 16
        Me.IconButtonDeplesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonDeplesi.Location = New System.Drawing.Point(0, 272)
        Me.IconButtonDeplesi.Name = "IconButtonDeplesi"
        Me.IconButtonDeplesi.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonDeplesi.Rotation = 0R
        Me.IconButtonDeplesi.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonDeplesi.TabIndex = 26
        Me.IconButtonDeplesi.Text = "Deplesi"
        Me.IconButtonDeplesi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonDeplesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonDeplesi.UseVisualStyleBackColor = False
        '
        'IconButtonPakan
        '
        Me.IconButtonPakan.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconButtonPakan.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonPakan.FlatAppearance.BorderSize = 0
        Me.IconButtonPakan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPakan.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonPakan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonPakan.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPakan.IconChar = FontAwesome.Sharp.IconChar.BalanceScaleRight
        Me.IconButtonPakan.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPakan.IconSize = 16
        Me.IconButtonPakan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPakan.Location = New System.Drawing.Point(0, 234)
        Me.IconButtonPakan.Name = "IconButtonPakan"
        Me.IconButtonPakan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonPakan.Rotation = 0R
        Me.IconButtonPakan.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonPakan.TabIndex = 29
        Me.IconButtonPakan.Text = "Pakan"
        Me.IconButtonPakan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPakan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPakan.UseVisualStyleBackColor = False
        '
        'IconButtonPeriode
        '
        Me.IconButtonPeriode.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconButtonPeriode.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonPeriode.FlatAppearance.BorderSize = 0
        Me.IconButtonPeriode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPeriode.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonPeriode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonPeriode.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPeriode.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus
        Me.IconButtonPeriode.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPeriode.IconSize = 16
        Me.IconButtonPeriode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPeriode.Location = New System.Drawing.Point(0, 196)
        Me.IconButtonPeriode.Name = "IconButtonPeriode"
        Me.IconButtonPeriode.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonPeriode.Rotation = 0R
        Me.IconButtonPeriode.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonPeriode.TabIndex = 28
        Me.IconButtonPeriode.Text = "Periode"
        Me.IconButtonPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPeriode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPeriode.UseVisualStyleBackColor = False
        '
        'IconButtonPeformance
        '
        Me.IconButtonPeformance.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonPeformance.FlatAppearance.BorderSize = 0
        Me.IconButtonPeformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPeformance.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonPeformance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonPeformance.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPeformance.IconChar = FontAwesome.Sharp.IconChar.Wpforms
        Me.IconButtonPeformance.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPeformance.IconSize = 20
        Me.IconButtonPeformance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPeformance.Location = New System.Drawing.Point(0, 158)
        Me.IconButtonPeformance.Name = "IconButtonPeformance"
        Me.IconButtonPeformance.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonPeformance.Rotation = 0R
        Me.IconButtonPeformance.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonPeformance.TabIndex = 23
        Me.IconButtonPeformance.Text = "Peformance"
        Me.IconButtonPeformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPeformance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPeformance.UseVisualStyleBackColor = True
        '
        'IconButtonDashboard
        '
        Me.IconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonDashboard.FlatAppearance.BorderSize = 0
        Me.IconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonDashboard.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.IconButtonDashboard.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonDashboard.IconSize = 20
        Me.IconButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonDashboard.Location = New System.Drawing.Point(0, 120)
        Me.IconButtonDashboard.Name = "IconButtonDashboard"
        Me.IconButtonDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonDashboard.Rotation = 0R
        Me.IconButtonDashboard.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonDashboard.TabIndex = 21
        Me.IconButtonDashboard.Text = "Dashboard"
        Me.IconButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonDashboard.UseVisualStyleBackColor = True
        '
        'IconButtonSignOut
        '
        Me.IconButtonSignOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButtonSignOut.FlatAppearance.BorderSize = 0
        Me.IconButtonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonSignOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonSignOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonSignOut.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButtonSignOut.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonSignOut.IconSize = 20
        Me.IconButtonSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonSignOut.Location = New System.Drawing.Point(0, 532)
        Me.IconButtonSignOut.Name = "IconButtonSignOut"
        Me.IconButtonSignOut.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonSignOut.Rotation = 0R
        Me.IconButtonSignOut.Size = New System.Drawing.Size(200, 38)
        Me.IconButtonSignOut.TabIndex = 7
        Me.IconButtonSignOut.Text = "Sign Out"
        Me.IconButtonSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonSignOut.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.Logo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 120)
        Me.PanelLogo.TabIndex = 0
        '
        'Logo
        '
        Me.Logo.Image = Global.Persentation.My.Resources.Resources.tes_ayam
        Me.Logo.Location = New System.Drawing.Point(49, 16)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(101, 86)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.IconBtnUser)
        Me.TitleBar.Controls.Add(Me.IconBtnMinimize)
        Me.TitleBar.Controls.Add(Me.IconBtnResize)
        Me.TitleBar.Controls.Add(Me.IconBtnClose)
        Me.TitleBar.Controls.Add(Me.lblFormTitle)
        Me.TitleBar.Controls.Add(Me.IconCurrentForm)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(200, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(790, 38)
        Me.TitleBar.TabIndex = 1
        '
        'IconBtnUser
        '
        Me.IconBtnUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.IconBtnUser.FlatAppearance.BorderSize = 0
        Me.IconBtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconBtnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        Me.IconBtnUser.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnUser.IconSize = 25
        Me.IconBtnUser.Location = New System.Drawing.Point(542, 5)
        Me.IconBtnUser.Name = "IconBtnUser"
        Me.IconBtnUser.Rotation = 0R
        Me.IconBtnUser.Size = New System.Drawing.Size(144, 29)
        Me.IconBtnUser.TabIndex = 5
        Me.IconBtnUser.Text = "Curious George"
        Me.IconBtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnUser.UseVisualStyleBackColor = False
        '
        'IconBtnMinimize
        '
        Me.IconBtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.IconBtnMinimize.FlatAppearance.BorderSize = 0
        Me.IconBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.IconBtnMinimize.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnMinimize.IconSize = 16
        Me.IconBtnMinimize.Location = New System.Drawing.Point(692, 0)
        Me.IconBtnMinimize.Name = "IconBtnMinimize"
        Me.IconBtnMinimize.Rotation = 0R
        Me.IconBtnMinimize.Size = New System.Drawing.Size(32, 28)
        Me.IconBtnMinimize.TabIndex = 4
        Me.IconBtnMinimize.UseVisualStyleBackColor = False
        '
        'IconBtnResize
        '
        Me.IconBtnResize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnResize.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.IconBtnResize.FlatAppearance.BorderSize = 0
        Me.IconBtnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnResize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnResize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.IconBtnResize.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnResize.IconSize = 16
        Me.IconBtnResize.Location = New System.Drawing.Point(725, 0)
        Me.IconBtnResize.Name = "IconBtnResize"
        Me.IconBtnResize.Rotation = 0R
        Me.IconBtnResize.Size = New System.Drawing.Size(32, 28)
        Me.IconBtnResize.TabIndex = 3
        Me.IconBtnResize.UseVisualStyleBackColor = False
        '
        'IconBtnClose
        '
        Me.IconBtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.IconBtnClose.FlatAppearance.BorderSize = 0
        Me.IconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconBtnClose.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconBtnClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBtnClose.IconSize = 16
        Me.IconBtnClose.Location = New System.Drawing.Point(758, 0)
        Me.IconBtnClose.Name = "IconBtnClose"
        Me.IconBtnClose.Rotation = 0R
        Me.IconBtnClose.Size = New System.Drawing.Size(32, 28)
        Me.IconBtnClose.TabIndex = 2
        Me.IconBtnClose.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(36, 10)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(47, 17)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconSize = 23
        Me.IconCurrentForm.Location = New System.Drawing.Point(7, 8)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(23, 24)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'DekstopPanel
        '
        Me.DekstopPanel.BackColor = System.Drawing.Color.White
        Me.DekstopPanel.Controls.Add(Me.PanelAva)
        Me.DekstopPanel.Controls.Add(Me.PictureBox1)
        Me.DekstopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DekstopPanel.Location = New System.Drawing.Point(200, 38)
        Me.DekstopPanel.Name = "DekstopPanel"
        Me.DekstopPanel.Size = New System.Drawing.Size(790, 532)
        Me.DekstopPanel.TabIndex = 2
        '
        'PanelAva
        '
        Me.PanelAva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAva.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelAva.Controls.Add(Me.AccountSetting)
        Me.PanelAva.Controls.Add(Me.IconButtonAVA)
        Me.PanelAva.Controls.Add(Me.labelEmailUser)
        Me.PanelAva.Controls.Add(Me.LabelUser)
        Me.PanelAva.Location = New System.Drawing.Point(495, 0)
        Me.PanelAva.MaximumSize = New System.Drawing.Size(191, 66)
        Me.PanelAva.MinimumSize = New System.Drawing.Size(191, 0)
        Me.PanelAva.Name = "PanelAva"
        Me.PanelAva.Size = New System.Drawing.Size(191, 66)
        Me.PanelAva.TabIndex = 8
        '
        'AccountSetting
        '
        Me.AccountSetting.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AccountSetting.FlatAppearance.BorderSize = 0
        Me.AccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.AccountSetting.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountSetting.ForeColor = System.Drawing.Color.Gainsboro
        Me.AccountSetting.IconChar = FontAwesome.Sharp.IconChar.None
        Me.AccountSetting.IconColor = System.Drawing.Color.Black
        Me.AccountSetting.IconSize = 16
        Me.AccountSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountSetting.Location = New System.Drawing.Point(0, 43)
        Me.AccountSetting.Name = "AccountSetting"
        Me.AccountSetting.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.AccountSetting.Rotation = 0R
        Me.AccountSetting.Size = New System.Drawing.Size(191, 23)
        Me.AccountSetting.TabIndex = 11
        Me.AccountSetting.Text = "Account Setting ..."
        Me.AccountSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountSetting.UseVisualStyleBackColor = True
        '
        'IconButtonAVA
        '
        Me.IconButtonAVA.FlatAppearance.BorderSize = 0
        Me.IconButtonAVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonAVA.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonAVA.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.IconButtonAVA.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonAVA.IconSize = 40
        Me.IconButtonAVA.Location = New System.Drawing.Point(4, 3)
        Me.IconButtonAVA.Name = "IconButtonAVA"
        Me.IconButtonAVA.Rotation = 0R
        Me.IconButtonAVA.Size = New System.Drawing.Size(41, 43)
        Me.IconButtonAVA.TabIndex = 10
        Me.IconButtonAVA.UseVisualStyleBackColor = True
        '
        'labelEmailUser
        '
        Me.labelEmailUser.AutoSize = True
        Me.labelEmailUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEmailUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.labelEmailUser.Location = New System.Drawing.Point(45, 22)
        Me.labelEmailUser.Name = "labelEmailUser"
        Me.labelEmailUser.Size = New System.Drawing.Size(36, 16)
        Me.labelEmailUser.TabIndex = 8
        Me.labelEmailUser.Text = "Email"
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelUser.Location = New System.Drawing.Point(45, 3)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(49, 17)
        Me.LabelUser.TabIndex = 7
        Me.LabelUser.Text = "Nama"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Persentation.My.Resources.Resources.tes_ayam1
        Me.PictureBox1.Location = New System.Drawing.Point(308, 183)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TimerAva
        '
        Me.TimerAva.Interval = 15
        '
        'TimerOptionDM
        '
        Me.TimerOptionDM.Interval = 15
        '
        'TimerPeformance
        '
        Me.TimerPeformance.Interval = 15
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(990, 570)
        Me.Controls.Add(Me.DekstopPanel)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(990, 570)
        Me.Name = "Home"
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DekstopPanel.ResumeLayout(False)
        Me.PanelAva.ResumeLayout(False)
        Me.PanelAva.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents TitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents DekstopPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconBtnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnResize As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnUser As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonSignOut As FontAwesome.Sharp.IconButton
    Friend WithEvents TimerAva As Timer
    Friend WithEvents PanelAva As Panel
    Friend WithEvents IconButtonAVA As FontAwesome.Sharp.IconButton
    Friend WithEvents labelEmailUser As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents AccountSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents TimerOptionDM As Timer
    Friend WithEvents TimerPeformance As Timer
    Friend WithEvents IconButtonSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonLog As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPenangkapan As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMutasi As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonDeplesi As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPakan As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPeriode As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPeformance As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonDashboard As FontAwesome.Sharp.IconButton
End Class
