Imports MySql.Data.MySqlClient
Imports System.Configuration

Public MustInherit Class ConnectionToSQL
    Private ConnectionString As String
    'access DB
    Protected Sub New()
        ConnectionString = "server=localhost;database=ayambrowler;username=root;password=;"
    End Sub

    Protected Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function


End Class
