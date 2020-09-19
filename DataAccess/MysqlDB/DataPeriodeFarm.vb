Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DataPeriodeFarm
    Inherits UserData
    Implements IEmployeRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    'constructor
    Public Sub New()
        selectAll = "Select * from periode_kandang"
        insert = "Insert into periode_kandang (tanggal, kandang_id, jlh_masuk, jlh_bonus, periode, close_periode) values(@tanggal, @kandang_id, @jlh_masuk, @jlh_bonus, @periode,@close_periode )"
        update = "update periode_kandang set tanggal=@tanggal, kandang_id=@kandang_id, jlh_masuk=@jlh_masuk, jlh_bonus=@jlh_bonus, periode=@periode, close_periode=@close_periode where id=@id"
        delete = "delete from periode_kandang where id=@id"
    End Sub

    Public Function GetAll() As IEnumerable(Of Periode) Implements IGenericRepository(Of Periode).GetAll
        Dim resultTable = executeReader(selectAll)
        Dim ListOfPeriode = New List(Of Periode)
        For Each item As DataRow In resultTable.Rows
            ListOfPeriode.Add(New Periode With {
            .id = item(0),
            .tanggal = item(1),
            .kandang_id = item(2),
            .jlh_masuk = item(3),
            .jlh_bonus = item(4),
            .periode = item(5),
            .close_periode = item(6)
            })
        Next
        Return ListOfPeriode
    End Function

    Public Function Add(entity As Periode) As Integer Implements IGenericRepository(Of Periode).Add
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_masuk", entity.jlh_masuk))
        parameters.Add(New MySqlParameter("@jlh_bonus", entity.jlh_bonus))
        parameters.Add(New MySqlParameter("@periode", entity.periode))
        parameters.Add(New MySqlParameter("@close_periode", entity.close_periode))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Periode) As Integer Implements IGenericRepository(Of Periode).Edit
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", entity.id))
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_masuk", entity.jlh_masuk))
        parameters.Add(New MySqlParameter("@jlh_bonus", entity.jlh_bonus))
        parameters.Add(New MySqlParameter("@periode", entity.periode))
        parameters.Add(New MySqlParameter("@close_periode", entity.close_periode))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Periode).Remove
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", id))
        Return ExecuteNonQuery(delete)
    End Function

    Public Function GetByKandangId() As IEnumerable(Of Periode) Implements IEmployeRepository.GetByKandangId
        Throw New NotImplementedException()
    End Function

End Class
