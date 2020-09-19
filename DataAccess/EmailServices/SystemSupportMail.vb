Public Class SystemSupportMail
    Inherits MasterEmailServer

    Public Sub New()
        senderMail = "hartono.mabar88@gmail.com"
        password = "ayammabar"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        InitializeSmtpClient()
    End Sub

    Public Sub Notivication()

    End Sub

    Public Sub Errors()

    End Sub
End Class
