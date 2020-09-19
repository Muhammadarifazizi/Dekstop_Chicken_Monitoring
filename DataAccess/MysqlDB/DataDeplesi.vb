Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DataDeplesi
    Inherits UserData
    Implements IDeplesi

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String
    Private logInsert As String
    Public Sub New()
        selectAll = "SELECT * FROM deplesi"
        insert = " INSERT INTO deplesi (tanggal, kandang_id, jlh_mati, jlh_afkir)values(@tanggal, @kandang_id, @jlh_mati, @jlh_afkir)"
        update = "UPDATE deplesi SET tanggal=@tanggal, kandang_id=@kandang_id, jlh_mati=@jlh_mati, jlh_afkir=@jlh_afkir where id=@id"
        delete = "DELETE FROM deplesi where id=@id"
        logInsert = "INSERT INTO log_activity(DateTimeLog, ActivityLog, UserLog, PCLog) VALUES (@DateTimeLog, @ActivityLog, @UserLog, @PCLog)"
    End Sub


    Public Function GetAll() As IEnumerable(Of Deplesi) Implements IGenericRepository(Of Deplesi).GetAll
        Dim resultTable = executeReader(selectAll)
        Dim listOfDeplesi = New List(Of Deplesi)
        For Each item As DataRow In resultTable.Rows
            listOfDeplesi.Add(New Deplesi With {
            .id = item(0),
            .tanggal = item(1),
            .kandang_id = item(2),
            .jlh_mati = item(3),
            .jlh_afkir = item(4)
            })
        Next
        Return listOfDeplesi
    End Function

    Public Function Add(entity As Deplesi) As Integer Implements IGenericRepository(Of Deplesi).Add
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_mati", entity.jlh_mati))
        parameters.Add(New MySqlParameter("@jlh_afkir", entity.jlh_afkir))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Deplesi) As Integer Implements IGenericRepository(Of Deplesi).Edit
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", entity.id))
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_mati", entity.jlh_mati))
        parameters.Add(New MySqlParameter("@jlh_afkir", entity.jlh_afkir))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Deplesi).Remove
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", id))
        Return ExecuteNonQuery(delete)
    End Function

End Class
