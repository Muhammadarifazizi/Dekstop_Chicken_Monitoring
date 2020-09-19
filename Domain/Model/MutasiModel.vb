Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class MutasiModel
    Private _id As Integer
    Private _tgl_mutasi As Date
    Private _jlh_mutasi As Integer
    Private _kandang_id As String
    Private _tujuan_kandang As String
    Private mutasiRepo As IMutasi
    Private _state As EntityState
    Private listViewMutasi As List(Of MutasiModel)



    Public Sub New()
        MutasiRepo1 = New DataMutasi()
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Tgl_mutasi As Date
        Get
            Return _tgl_mutasi
        End Get
        Set(value As Date)
            _tgl_mutasi = value
        End Set
    End Property
    <Required(ErrorMessage:="The field identification number is required")>
    <RegularExpression("([0-9])+", ErrorMessage:="the field must be only number")>
    Public Property Jlh_mutasi As Integer
        Get
            Return _jlh_mutasi
        End Get
        Set(value As Integer)
            _jlh_mutasi = value
        End Set
    End Property

    Public Property Kandang_id As String
        Get
            Return _kandang_id
        End Get
        Set(value As String)
            _kandang_id = value
        End Set
    End Property

    Public Property Tujuan_kandang As String
        Get
            Return _tujuan_kandang
        End Get
        Set(value As String)
            _tujuan_kandang = value
        End Set
    End Property

    Private Property MutasiRepo1 As IMutasi
        Get
            Return mutasiRepo
        End Get
        Set(value As IMutasi)
            mutasiRepo = value
        End Set
    End Property

    Public Property State As EntityState
        Private Get
            Return _state
        End Get
        Set(value As EntityState)
            _state = value
        End Set
    End Property

    Public Property ListViewMutasi1 As List(Of MutasiModel)
        Get
            Return listViewMutasi
        End Get
        Set(value As List(Of MutasiModel))
            listViewMutasi = value
        End Set
    End Property

    Public Function saveChange() As String
        Dim message As String = Nothing
        Try
            Dim dataMutasiModel As New Mutasi()
            dataMutasiModel.id = Id
            dataMutasiModel.tgl_mutasi = Tgl_mutasi
            dataMutasiModel.jlh_mutasi = Jlh_mutasi
            dataMutasiModel.kandang_id = Kandang_id
            dataMutasiModel.tujuan_kandang = Tujuan_kandang

            Select Case State
                Case EntityState.added
                    Dim result = MutasiRepo1.Add(dataMutasiModel)
                    message = "Successfully add data"
                Case EntityState.modified
                    Dim result = MutasiRepo1.Edit(dataMutasiModel)
                    message = "Successfully modified data"
                Case EntityState.deleted
                    Dim result = MutasiRepo1.Remove(Id)
                    message = "Successfully Delete data"
            End Select
        Catch ex As Exception

        End Try
        Return message
    End Function

    Public Function getMutasi() As List(Of MutasiModel)
        Dim listDataMutasi = MutasiRepo1.GetAll()
        ListViewMutasi1 = New List(Of MutasiModel)

        For Each item As Mutasi In listDataMutasi
            ListViewMutasi1.Add(New MutasiModel With {
            .Id = item.id,
            .Tgl_mutasi = item.tgl_mutasi,
            .Jlh_mutasi = item.jlh_mutasi,
            .Kandang_id = item.kandang_id,
            .Tujuan_kandang = item.tujuan_kandang
            })
        Next
        Return ListViewMutasi1
    End Function
    Public Function FindData(value As String) As IEnumerable(Of MutasiModel)
        Return getMutasi.FindAll(Function(idk) idk.Kandang_id.Contains(value))
    End Function
End Class
