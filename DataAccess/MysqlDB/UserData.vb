Imports System.Data
Imports MySql.Data.MySqlClient
Imports Common

Public Class UserData
    Inherits ConnectionToSQL

    Public Sub editProvile(id, username, password, firstname, lastname, email)
        Using connection = GetConnection()
            connection.Open()
            Using Command = New MySqlCommand()
                Command.Connection = connection
                Command.CommandText = "UPDATE account set Username=@username, password=@password, firstname=@firstname, lastname=@lastname, email=@email where id_account=@id"
                Command.Parameters.AddWithValue("@username", username)
                Command.Parameters.AddWithValue("@password", password)
                Command.Parameters.AddWithValue("@firstname", firstname)
                Command.Parameters.AddWithValue("@lastname", lastname)
                Command.Parameters.AddWithValue("@email", email)
                Command.Parameters.AddWithValue("@id", id)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Public Function requestUserPassword(requestingUser As String) As String
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM account WHERE username=@username or email=@email"
                command.Parameters.AddWithValue("@username", requestingUser)
                command.Parameters.AddWithValue("@email", requestingUser)
                command.CommandType = CommandType.Text

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read = True Then
                    Dim fullname = reader.GetString(3) & " " & reader.GetString(4)
                    Dim useremail = reader.GetString(6)
                    Dim userpassword = reader.GetString(3)

                    Dim mailSupport As New SystemSupportMail()

                    mailSupport.SendMail(subject:="SYSTEM : Password Recovery Request",
                                         body:="Hi " & fullname & vbNewLine & "We find that you request for your old password " & vbNewLine &
                                         "Your current password is " & userpassword & vbNewLine & " However, we ask you to change your current password immediately when you enter our system.",
                                         receiverMail:=New List(Of String) From {useremail})
                    Return "Hi " & fullname & vbNewLine & "We find that you request for your old password " & vbNewLine &
                                         "Please check your current email " & useremail & " to get your old password."

                Else
                    Return "Sorry, you don't have an account with that email or username"

                End If
            End Using
        End Using
    End Function

    Public Function Login(username As String, password As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand
                command.Connection = connection
                command.CommandText = "SELECT * FROM `account` WHERE `Username`=@username AND `password`=@password"

                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.CommandType = CommandType.Text

                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.userId = reader.GetInt32(0)
                        ActiveUser.username = reader.GetString(1)
                        ActiveUser.password = reader.GetString(2)
                        ActiveUser.firstName = reader.GetString(3)
                        ActiveUser.lastName = reader.GetString(4)
                        ActiveUser.email = reader.GetString(6)
                        ActiveUser.level = reader.GetString(5)
                        ActiveUser.logout = reader.GetDateTime(7)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function ExistUser(id As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand
                command.Connection = connection
                command.CommandText = "SELECT * FROM account where id_account=@userId"
                command.Parameters.AddWithValue("@userId", id)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    Return True
                Else
                    Return False
                End If

            End Using
        End Using
    End Function

    Public Sub AnyMethode3()
        If ActiveUser.level = levelUser.superadmin Then

        End If
        If ActiveUser.level = levelUser.admin Then

        End If
        If ActiveUser.level = levelUser.review Then

        End If
        If ActiveUser.level = levelUser.input Then

        End If
    End Sub

    ''''new

    Protected parameters As List(Of MySqlParameter)

    Protected Function ExecuteNonQuery(transactSql As String) As Integer
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = transactSql
                command.CommandType = CommandType.Text
                For Each item As MySqlParameter In parameters
                    command.Parameters.Add(item)
                Next
                Dim result = command.ExecuteNonQuery()
                parameters.Clear()
                Return result
            End Using
        End Using
    End Function

    Protected Function executeReader(transactsql As String) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New MySqlCommand
                command.Connection = connection
                command.CommandText = transactsql
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                Using table = New DataTable()
                    table.Load(reader)
                    reader.Dispose()
                    Return table

                End Using
            End Using
        End Using
    End Function

End Class
