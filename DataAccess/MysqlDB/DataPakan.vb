Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DataPakan
    Inherits UserData
    Implements IPakanRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String
    'constructor
    Public Sub New()
        selectAll = "SELECT * FROM pakan"
        insert = " INSERT INTO pakan (tanggal, kandang_id, pakan_harian)values(@tanggal, @kandang_id, @pakan_harian)"
        update = "UPDATE pakan SET tanggal=@tanggal, kandang_id=@kandang_id, pakan_harian=@pakan_harian where id=@id"
        delete = "DELETE FROM pakan where id=@id"
    End Sub


    Public Function GetAll() As IEnumerable(Of Pakan) Implements IGenericRepository(Of Pakan).GetAll
        Dim resultTable = executeReader(selectAll)
        Dim listOfPakan = New List(Of Pakan)
        For Each item As DataRow In resultTable.Rows
            listOfPakan.Add(New Pakan With {
            .id = item(0),
            .tanggal = item(1),
            .kandang_id = item(2),
            .pakan_harian = item(3)
            })
        Next
        Return listOfPakan
    End Function

    Public Function Add(entity As Pakan) As Integer Implements IGenericRepository(Of Pakan).Add
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@pakan_harian", entity.pakan_harian))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Pakan) As Integer Implements IGenericRepository(Of Pakan).Edit
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", entity.id))
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@pakan_harian", entity.pakan_harian))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Pakan).Remove
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", id))
        Return ExecuteNonQuery(delete)
    End Function
    Public Function getByKandangId() As IEnumerable(Of Pakan) Implements IPakanRepository.getByKandangId
        Throw New NotImplementedException()
    End Function

End Class
