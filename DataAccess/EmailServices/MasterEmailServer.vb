Imports System.Net
Imports System.Net.Mail

Public MustInherit Class MasterEmailServer

    Private smtpClient As SmtpClient
    Protected senderMail As String
    Protected password As String
    Protected host As String
    Protected port As Integer
    Protected ssl As Boolean

    Protected Sub InitializeSmtpClient()
        smtpClient = New SmtpClient()
        smtpClient.Credentials = New NetworkCredential(senderMail, password)
        smtpClient.Host = host
        smtpClient.Port = port
        smtpClient.EnableSsl = ssl
    End Sub

    Public Sub SendMail(subject As String, body As String, receiverMail As List(Of String))
        Dim mailMessage As New MailMessage()
        Try
            mailMessage.From = New MailAddress(senderMail)
            For Each recipientMail As String In receiverMail
                mailMessage.To.Add(recipientMail)
            Next
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.Priority = MailPriority.Normal

            smtpClient.Send(mailMessage)

        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try
    End Sub
End Class
