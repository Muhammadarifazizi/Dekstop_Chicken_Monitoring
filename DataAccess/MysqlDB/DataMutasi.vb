Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DataMutasi
    Inherits UserData
    Implements IMutasi

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String
    'constructor
    Public Sub New()
        selectAll = "SELECT * FROM mutasi"
        insert = " INSERT INTO mutasi(tgl_mutasi, jlh_mutasi, kandang_id, tujuan_kandang) values(@tgl_mutasi, @jlh_mutasi, @kandang_id, @tujuan_kandang)"
        update = "UPDATE mutasi SET tgl_mutasi=@tgl_mutasi, jlh_mutasi=@jlh_mutasi, kandang_id=@kandang_id, tujuan_kandang=@tujuan_kandang where id=@id"
        delete = "DELETE FROM mutasi where id=@id"
    End Sub


    Public Function GetAll() As IEnumerable(Of Mutasi) Implements IGenericRepository(Of Mutasi).GetAll
        Dim resultTable = executeReader(selectAll)
        Dim listOfMutasi = New List(Of Mutasi)
        For Each item As DataRow In resultTable.Rows
            listOfMutasi.Add(New Mutasi With {
            .id = item(0),
            .tgl_mutasi = item(1),
            .jlh_mutasi = item(2),
            .kandang_id = item(3),
            .tujuan_kandang = item(4)
            })
        Next
        Return listOfMutasi
    End Function

    Public Function Add(entity As Mutasi) As Integer Implements IGenericRepository(Of Mutasi).Add
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@tgl_mutasi", entity.tgl_mutasi))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_mutasi", entity.jlh_mutasi))
        parameters.Add(New MySqlParameter("@tujuan_kandang", entity.tujuan_kandang))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Mutasi) As Integer Implements IGenericRepository(Of Mutasi).Edit
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", entity.id))
        parameters.Add(New MySqlParameter("@tgl_mutasi", entity.tgl_mutasi))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_mutasi", entity.jlh_mutasi))
        parameters.Add(New MySqlParameter("@tujuan_kandang", entity.tujuan_kandang))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Mutasi).Remove
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", id))
        Return ExecuteNonQuery(delete)
    End Function

End Class
