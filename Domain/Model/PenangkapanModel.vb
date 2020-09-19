Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class PenangkapanModel
    Private _id As Integer
    Private _tanggal As Date
    Private _kandang_id As String
    Private _jlh_kecil As Integer
    Private _jlh_sedang As Integer
    Private _jlh_besar As Integer
    Private _ttl_berat As Double
    Private _state As EntityState
    Private penangkapanRepo As IPenangkapan
    Private listViewpenangkapan As List(Of PenangkapanModel)

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Tanggal As Date
        Get
            Return _tanggal
        End Get
        Set(value As Date)
            _tanggal = value
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

    Public Property Jlh_kecil As Integer
        Get
            Return _jlh_kecil
        End Get
        Set(value As Integer)
            _jlh_kecil = value
        End Set
    End Property

    Public Property Jlh_sedang As Integer
        Get
            Return _jlh_sedang
        End Get
        Set(value As Integer)
            _jlh_sedang = value
        End Set
    End Property

    Public Property Jlh_besar As Integer
        Get
            Return _jlh_besar
        End Get
        Set(value As Integer)
            _jlh_besar = value
        End Set
    End Property

    Public Property Ttl_berat As Double
        Get
            Return _ttl_berat
        End Get
        Set(value As Double)
            _ttl_berat = value
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

    Public Property ListViewpenangkapan1 As List(Of PenangkapanModel)
        Get
            Return listViewpenangkapan
        End Get
        Set(value As List(Of PenangkapanModel))
            listViewpenangkapan = value
        End Set
    End Property


    Public Sub New()
        penangkapanRepo = New DataPenangkapan()
    End Sub

    'methode
    Public Function saveChange() As String
        Dim message As String = Nothing
        Try
            Dim dataPenangkapanModel As New Penangkapan()
            dataPenangkapanModel.id = Id
            dataPenangkapanModel.tanggal = Tanggal
            dataPenangkapanModel.kandang_id = Kandang_id
            dataPenangkapanModel.jlh_kecil = Jlh_kecil
            dataPenangkapanModel.jlh_sedang = Jlh_sedang
            dataPenangkapanModel.jlh_besar = Jlh_besar
            dataPenangkapanModel.ttl_berat = Ttl_berat

            Select Case State
                Case EntityState.added
                    penangkapanrepo.Add(dataPenangkapanModel)
                    message = "Successfully add data"
                Case EntityState.modified
                    penangkapanrepo.Edit(dataPenangkapanModel)
                    message = "Successfully modified data"
                Case EntityState.deleted
                    penangkapanrepo.Remove(Id)
                    message = "Successfully Delete data"
            End Select
        Catch ex As Exception

        End Try
        Return message
    End Function

    Public Function getPenangkapan() As List(Of PenangkapanModel)
        Dim listDataPenangkapan = penangkapanrepo.GetAll()
        listViewpenangkapan = New List(Of PenangkapanModel)

        For Each item As Penangkapan In listDataPenangkapan
            listViewpenangkapan.Add(New PenangkapanModel With {
            .Id = item.id,
            .Tanggal = item.tanggal,
            .Kandang_id = item.kandang_id,
            .Jlh_kecil = item.jlh_kecil,
            .Jlh_sedang = item.jlh_sedang,
            .Jlh_besar = item.jlh_besar,
            .Ttl_berat = item.ttl_berat
            })
        Next
        Return listViewpenangkapan
    End Function

    Public Function FindData(value As String) As IEnumerable(Of PenangkapanModel)
        Return getPenangkapan.FindAll(Function(idk) idk.Kandang_id.Contains(value))
    End Function
End Class
