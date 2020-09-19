Imports Common
Imports Domain

Public Class UserEditProfile

    Private isCollapse As Boolean = True

    Private Sub UserEditProfile_Load(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Me.Size = Me.MinimumSize
        loadUserData()
        initializeControlEditPass()
    End Sub

    Private Sub loadUserData()
        'view
        LabelUsername.Text = ActiveUser.username
        LabelFirstName.Text = ActiveUser.firstName
        LabelLastName.Text = ActiveUser.lastName
        LabelEmail.Text = ActiveUser.email
        LabelPosition.Text = ActiveUser.level
        'edit
        TextBoxFirstName.Text = ActiveUser.firstName
        TextBoxLastName.Text = ActiveUser.lastName
        TextBoxEmail.Text = ActiveUser.email
        TextBoxUsername.Text = ActiveUser.username
        TextBoxNewPass.Text = ActiveUser.password
        TextBoxRePass.Text = ActiveUser.password
    End Sub

    Private Sub reset()
        loadUserData()
        initializeControlEditPass()
    End Sub

    Private Sub initializeControlEditPass()
        LinkEditPass.Text = "Edit"
        TextBoxOldPass.Text = ""
        TextBoxNewPass.Text = ""
        TextBoxRePass.Text = ""
        Label5.Visible = False
        Label6.Visible = False
        TextBoxRePass.Visible = False
        TextBoxNewPass.Visible = False
    End Sub

    Private Sub IconButtonConfirm_Click(sender As Object, e As EventArgs) Handles IconButtonConfirm.Click
        If TextBoxNewPass.Text = TextBoxRePass.Text Then
            If TextBoxOldPass.Text = ActiveUser.password Then

                Dim userModel As New UserModel(id_account:=ActiveUser.userId, username:=TextBoxUsername.Text,
                                               password:=TextBoxNewPass.Text, firstname:=TextBoxFirstName.Text,
                                               lastname:=TextBoxLastName.Text, level:=Nothing,
                                               email:=TextBoxEmail.Text)

                Dim result = userModel.editUserProfile()
                MessageBox.Show(result)
                reset()
                Panel1.Visible = False
            Else
                MessageBox.Show("incorrect Old Password!")
            End If
        Else
            MessageBox.Show("The Password do not match, please try again")
        End If
    End Sub

    Private Sub IconButtonCancel_Click(sender As Object, e As EventArgs) Handles IconButtonCancel.Click
        Timer1.Start()
        Panel1.Visible = False
        reset()
    End Sub

    Private Sub IconBtnBack_Click(sender As Object, e As EventArgs) Handles IconBtnBack.Click
        Me.Close()
    End Sub

    Private Sub LinkEditPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEditPass.LinkClicked
        If LinkEditPass.Text = "Edit" Then
            LinkEditPass.Text = "Cancel"
            TextBoxNewPass.Visible = True
            TextBoxRePass.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            TextBoxNewPass.Text = ""
            TextBoxRePass.Text = ""
        ElseIf LinkEditPass.Text = "Cancel" Then
            reset()
        End If
    End Sub

    Private Sub IconButtonEdit_Click(sender As Object, e As EventArgs) Handles IconButtonEdit.Click
        Timer1.Start()
        Panel1.Visible = True
        loadUserData()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBoxNewPass.UseSystemPasswordChar = True Or
        TextBoxRePass.UseSystemPasswordChar = True Or
        TextBoxOldPass.UseSystemPasswordChar = True Then
            TextBoxOldPass.UseSystemPasswordChar = False
            TextBoxNewPass.UseSystemPasswordChar = False
            TextBoxRePass.UseSystemPasswordChar = False
        Else
            TextBoxOldPass.UseSystemPasswordChar = True
            TextBoxNewPass.UseSystemPasswordChar = True
            TextBoxRePass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapse Then
            Me.Width += 300
            Panel1.Visible = True
            If Me.Size = Me.MaximumSize Then
                isCollapse = False
                Timer1.Stop()
            End If
        Else
            Me.Width -= 300
            Panel1.Visible = False
            If Me.Size = Me.MinimumSize Then
                isCollapse = True
                Timer1.Stop()
            End If
        End If
    End Sub
End Class