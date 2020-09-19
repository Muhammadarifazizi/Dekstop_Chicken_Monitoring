Imports System.Runtime.InteropServices
Imports Domain
Imports Common

Public Class LoginForm

    Private Sub IconBtnClose_Click(sender As Object, e As EventArgs) Handles IconBtnClose.Click
        Application.Exit()
    End Sub

    Private Sub IconBtnMinimize_Click(sender As Object, e As EventArgs) Handles IconBtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'drag form
    <DllImport("User32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("User32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal WParam As Integer, ByVal IParam As Integer)
    End Sub

    Private Sub PanelLoginForm_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLoginForm.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelLoginForm_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelLoginForm.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub CustomizeComponents()
        TextBoxUsername.AutoSize = False
        TextBoxUsername.Size = New Size(265, 22)
        TextBoxPassword.AutoSize = False
        TextBoxPassword.Size = New Size(265, 22)
        TextBoxPassword.UseSystemPasswordChar = True
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CustomizeComponents()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim userModel As New UserModel()
        Dim validLogin = userModel.Login(TextBoxUsername.Text, TextBoxPassword.Text)
        If validLogin = True Then
            Dim home As New Home
            home.Show()
            AddHandler home.FormClosed, AddressOf Me.Logout
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Username or Password!" + vbNewLine + "Please Try Again")
            TextBoxPassword.Clear()
            TextBoxPassword.Focus()
        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If TextBoxPassword.UseSystemPasswordChar = True Then
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            TextBoxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        Me.Show()
        TextBoxUsername.Focus()
    End Sub

    Private Sub LinkLabelForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelForgotPassword.LinkClicked
        Dim formRecoveryPassword As New FormRecovPass()
        formRecoveryPassword.ShowDialog()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxUsername.Focus()
    End Sub


End Class
