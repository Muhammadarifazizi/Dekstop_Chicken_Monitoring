Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports Common
Imports Domain
Imports MySql.Data.MySqlClient

Public Class Home
    'field
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private isCollapseAva As Boolean = True

    Dim logActivityModel As New LogActivityModel()
    'Constructor
    Public Sub New()
        'thid call required by design
        InitializeComponent()
        'add any initialize after calling initializeComponen()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 38)
        PanelMenu.Controls.Add(leftBorderBtn)
        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methode
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DissableButton()
            'customazing Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(51, 51, 76)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'Left border at BUtton
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'change icon on current bar like what on Button after clicked
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = Color.Gainsboro

            'title bar
            TitleBar.BackColor = customColor

            'close, resize and minimize
            IconBtnClose.BackColor = customColor
            IconBtnResize.BackColor = customColor
            IconBtnMinimize.BackColor = customColor
            'iconbtn avatar and setting
            IconBtnUser.BackColor = customColor
            'labelformtitle
            lblFormTitle.BackColor = customColor
        End If
    End Sub

    Private Sub DissableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(51, 51, 76)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'when open form we close previous form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        'set DekstopPanel that we have
        DekstopPanel.Controls.Add(childForm)
        DekstopPanel.Tag = childForm 'assosiated form to panel
        childForm.BringToFront()
        childForm.Show()

        'add label header
        lblFormTitle.Text = currentBtn.Text

    End Sub

    Private Sub IconButtonDashboard_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color1)
        'invoke each form for each button
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub IconButtonPeformance_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color2)
        'invoke each form for each button
        OpenChildForm(New FormPeformance)
    End Sub

    Private Sub IconButtonPenangkapan_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color3)
        'invoke each form for each button
        OpenChildForm(New FormPenangkapan)
    End Sub

    Private Sub IconButtonDeplesidanMutasi_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color4)
        TimerOptionDM.Start()
    End Sub

    Private Sub IconButtonLog_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color5)
        'invoke each form for each button
        OpenChildForm(New FormLog)
    End Sub

    Private Sub IconButtonSetting_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color6)
        'invoke each form for each button
        OpenChildForm(New FormSetting)
    End Sub
    'reset to home menu
    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    'reset menubar 
    Private Sub Reset()
        DissableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Gainsboro
        lblFormTitle.Text = "Home"
        lblFormTitle.BackColor = Color.FromArgb(232, 125, 53)
        TitleBar.BackColor = Color.FromArgb(232, 125, 53)
        IconBtnClose.BackColor = Color.FromArgb(232, 125, 53)
        IconBtnResize.BackColor = Color.FromArgb(232, 125, 53)
        IconBtnMinimize.BackColor = Color.FromArgb(232, 125, 53)
        'iconbtn avatar and setting
        IconBtnUser.BackColor = Color.FromArgb(232, 125, 53)

    End Sub
    'drag form
    <DllImport("User32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("User32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal WParam As Integer, ByVal IParam As Integer)
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Home_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub IconBtnClose_Click(sender As Object, e As EventArgs) Handles IconBtnClose.Click

        If MessageBox.Show("Are you sure to close the application?",
                        "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub IconBtnResize_Click(sender As Object, e As EventArgs) Handles IconBtnResize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = WindowState.Maximized
        Else
            WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub IconBtnMinimize_Click(sender As Object, e As EventArgs) Handles IconBtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButtonSignOut_Click(sender As Object, e As EventArgs) Handles IconButtonSignOut.Click
        If MessageBox.Show("Are you sure to Sign Out Now?", "Warning",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub IconBtnUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelAva.Size = PanelAva.MinimumSize
        LoadUser()
        managePermission()
        SecurityUser()
    End Sub

    Private Sub LoadUser()
        IconBtnUser.Text = ActiveUser.firstName + " " + ActiveUser.lastName
        LabelUser.Text = ActiveUser.firstName + " " + ActiveUser.lastName
        labelEmailUser.Text = ActiveUser.email

    End Sub


    Private Sub SecurityUser()
        Dim user As New UserModel()
        If user.AnyMethode(ActiveUser.userId) = False Then
            MessageBox.Show("Error, unknow subject!")
            Me.Close()
        End If
    End Sub

    Private Sub managePermission()
        If ActiveUser.level = levelUser.review Then
            IconButtonLog.Enabled = False
            IconButtonLog.Visible = False
            IconButtonSetting.Enabled = False
            IconButtonSetting.Visible = False
            IconButtonDeplesi.Enabled = False
            IconButtonPenangkapan.Enabled = False
            IconButtonDeplesi.Visible = False
            IconButtonPenangkapan.Visible = False
            IconButtonMutasi.Visible = False
            IconButtonMutasi.Enabled = False
            IconButtonPeriode.Visible = False
            IconButtonPeriode.Enabled = False
            IconButtonPakan.Visible = False
            IconButtonPakan.Enabled = False

        End If
        If ActiveUser.level = levelUser.admin Then
            IconButtonLog.Enabled = False
            IconButtonSetting.Enabled = False
            IconButtonLog.Visible = False
            IconButtonSetting.Visible = False
        End If
        If ActiveUser.level = levelUser.input Then
            IconButtonLog.Enabled = False
            IconButtonSetting.Enabled = False
            IconButtonLog.Visible = False
            IconButtonSetting.Visible = False
        End If
    End Sub

    Private Sub DekstopPanel_Paint(sender As Object, e As PaintEventArgs) Handles DekstopPanel.Paint

    End Sub

    Private Sub TimerAva_Tick(sender As Object, e As EventArgs) Handles TimerAva.Tick
        If isCollapseAva Then
            PanelAva.Height += 20
            If PanelAva.Size = PanelAva.MaximumSize Then
                isCollapseAva = False
                PanelAva.BringToFront()
                TimerAva.Stop()
            End If
        Else
            PanelAva.Height -= 20
            If PanelAva.Size = PanelAva.MinimumSize Then
                isCollapseAva = True
                TimerAva.Stop()
            End If
        End If
    End Sub

    Private Sub IconBtnUser_Click(sender As Object, e As EventArgs) Handles IconBtnUser.Click
        TimerAva.Start()
    End Sub

    Private Sub AccountSetting_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim userEditProfile As New UserEditProfile()
        userEditProfile.ShowDialog()
    End Sub

    Private Sub AccountSetting_Click(sender As Object, e As EventArgs) Handles AccountSetting.Click
        Dim userEditProfile As New UserEditProfile()
        userEditProfile.ShowDialog()
    End Sub

    Private Sub IconButtonLog_Click_1(sender As Object, e As EventArgs) Handles IconButtonLog.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormLog)
    End Sub

    Private Sub IconButtonSetting_Click_1(sender As Object, e As EventArgs) Handles IconButtonSetting.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormSetting)
    End Sub

    Private Sub IconButtonDeplesi_Click_1(sender As Object, e As EventArgs) Handles IconButtonDeplesi.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormDeplesi)
    End Sub

    Private Sub IconButtonMutasi_Click_1(sender As Object, e As EventArgs) Handles IconButtonMutasi.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormMutasi)
    End Sub

    Private Sub IconButtonPeformance_Click_1(sender As Object, e As EventArgs) Handles IconButtonPeformance.Click

        ActivateButton(sender, RGBColors.color1)
    End Sub

    Private Sub IconButtonPeriode_Click(sender As Object, e As EventArgs) Handles IconButtonPeriode.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormPeriode)
    End Sub

    Private Sub IconButtonPakan_Click(sender As Object, e As EventArgs) Handles IconButtonPakan.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormPakan)
    End Sub

    Private Sub IconButtonDashboard_Click_1(sender As Object, e As EventArgs) Handles IconButtonDashboard.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormHomepage)

    End Sub

    Private Sub IconButtonPenangkapan_Click_1(sender As Object, e As EventArgs) Handles IconButtonPenangkapan.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormPenangkapan)
    End Sub

    Private Sub LoginLog()
        Dim vActivityLog = "Login Aplikasi"
        Dim vUserLog = IconBtnUser.Text
        Dim DateTimeSystem = Now
        Dim vInsertLog = "INSERT INTO log_activity (DateTimeLog, ActivityLog, UserLog, PCLog) values (DateTimeSystem, vActivityLog, vUserLog,'PC1')"


    End Sub
End Class
