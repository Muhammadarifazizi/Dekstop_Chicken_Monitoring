Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DataLogActivity
    Inherits UserData
    Implements ILogActivity

    Private logInsert As String
    Private logSelectAll As String

    Public Sub New()
        logSelectAll = "SELECT * FROM log_activity"
        logInsert = "INSERT INTO log_activity (DateTimeLog, ActivityLog, UserLog, PCLog) VALUES (DateTimeLog=@DateTimeLog, ActivityLog=@ActivityLog, UserLog=@UserLog, PCLog=@PCLog) "
    End Sub

    Public Function Add(entity As LogActivity) As Integer Implements IGenericLog(Of LogActivity).Add
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@DateTimeLog", entity.DateTimeLog))
        parameters.Add(New MySqlParameter("@ActivityLog", entity.ActivityLog))
        parameters.Add(New MySqlParameter("@UserLog", entity.UserLog))
        parameters.Add(New MySqlParameter("@PCLog", entity.PCLog))
        Return ExecuteNonQuery(logInsert)
    End Function

    Public Function GetAll() As IEnumerable(Of LogActivity) Implements IGenericLog(Of LogActivity).GetAll
        Dim resultTable = executeReader(logSelectAll)
        Dim listOfDeplesi = New List(Of LogActivity)
        For Each item As DataRow In resultTable.Rows
            listOfDeplesi.Add(New LogActivity With {
            .AutoLog = item(0),
            .DateTimeLog = item(1),
            .ActivityLog = item(2),
            .UserLog = item(3),
            .PCLog = item(4)
            })
        Next
        Return listOfDeplesi
    End Function
End Class
