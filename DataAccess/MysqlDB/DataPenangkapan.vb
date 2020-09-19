Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DataPenangkapan
    Inherits UserData
    Implements IPenangkapan

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    'constructor
    Public Sub New()
        selectAll = "SELECT * FROM penangkapan"
        insert = " INSERT INTO penangkapan (tanggal, kandang_id, jlh_kecil, jlh_sedang, jlh_besar, ttl_berat) values(@tanggal, @kandang_id, @jlh_kecil, @jlh_sedang, @jlh_besar, @ttl_berat)"
        update = "UPDATE penangkapan SET tanggal=@tanggal, kandang_id=@kandang_id, jlh_kecil=@jlh_kecil, jlh_sedang=@jlh_sedang, jlh_besar=@jlh_besar, ttl_berat=@ttl_berat where id=@id"
        delete = "DELETE FROM penangkapan where id=@id"
    End Sub

    Public Function GetAll() As IEnumerable(Of Penangkapan) Implements IGenericRepository(Of Penangkapan).GetAll
        Dim resultTable = executeReader(selectAll)
        Dim listOfPenangkapan = New List(Of Penangkapan)
        For Each item As DataRow In resultTable.Rows
            listOfPenangkapan.Add(New Penangkapan With {
            .id = item(0),
            .tanggal = item(1),
            .kandang_id = item(2),
            .jlh_kecil = item(3),
            .jlh_sedang = item(4),
            .jlh_besar = item(5),
            .ttl_berat = item(6)
            })
        Next
        Return listOfPenangkapan
    End Function

    Public Function Add(entity As Penangkapan) As Integer Implements IGenericRepository(Of Penangkapan).Add
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_kecil", entity.jlh_kecil))
        parameters.Add(New MySqlParameter("@jlh_sedang", entity.jlh_sedang))
        parameters.Add(New MySqlParameter("@jlh_besar", entity.jlh_besar))
        parameters.Add(New MySqlParameter("@ttl_berat", entity.ttl_berat))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Penangkapan) As Integer Implements IGenericRepository(Of Penangkapan).Edit
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", entity.id))
        parameters.Add(New MySqlParameter("@tanggal", entity.tanggal))
        parameters.Add(New MySqlParameter("@kandang_id", entity.kandang_id))
        parameters.Add(New MySqlParameter("@jlh_kecil", entity.jlh_kecil))
        parameters.Add(New MySqlParameter("@jlh_sedang", entity.jlh_sedang))
        parameters.Add(New MySqlParameter("@jlh_besar", entity.jlh_besar))
        parameters.Add(New MySqlParameter("@ttl_berat", entity.ttl_berat))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Penangkapan).Remove
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@id", id))
        Return ExecuteNonQuery(delete)
    End Function

End Class
