Public Class FormHomepage
    Dim DateTimeSystem = Now
    Private Sub FormHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = DateTimeSystem.Now
    End Sub
End Class