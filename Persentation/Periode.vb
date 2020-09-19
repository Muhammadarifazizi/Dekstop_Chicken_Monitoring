'Imports System.Data
'Imports MySql.Data.MySqlClient
'Imports Common

'Public Class Periodefarm
'Inherits ConnectionToSQL
'
'Public Property id As Integer
'Public Property tanggal As Date
'Public Property kandang_id As String
'Public Property jlh_masuk As Integer
'Public Property jlh_bonus As Integer
'Public Property periode As Integer
'Dim strQuery As String
'Dim dt As New DataTable
'Dim db As New BindingSource

'Public Function Add() As Boolean
'Using connection = GetConnection()
'connection.Open()
'Using Command As New MySqlCommand
'Command.Connection = connection
'Command.CommandText = "INSERT INTO periode_kandang values (@tanggal, @kandang_id, @jlh_masuk, @jlh_bonus, @periode"
'Command.Parameters.AddWithValue("@tanggal", tanggal)
'Command.Parameters.AddWithValue("@kandang_id", kandang_id)
''Command.Parameters.AddWithValue("@jlh_masuk", jlh_masuk)
'Command.Parameters.AddWithValue("jlh_bonus", jlh_bonus)
'Command.Parameters.AddWithValue("@periode", periode)
'Command.CommandType = CommandType.Text
'Command.ExecuteNonQuery()
'End Using
'End Using
'End Function

'End Class
