Imports Domain

Public Class FormRecovPass
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim userModel As New UserModel()
        Dim result = userModel.recoveryPassword(TextBox1.Text)
        lblresult.Text = result
    End Sub

    Private Sub IconBtnClose_Click(sender As Object, e As EventArgs) Handles IconBtnClose.Click
        Me.Close()
    End Sub

    Private Sub FormRecovPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AutoSize = False
        TextBox1.Size = New Size(276, 22)
    End Sub
End Class