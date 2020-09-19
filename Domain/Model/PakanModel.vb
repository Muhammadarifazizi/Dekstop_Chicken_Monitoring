Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class PakanModel

    Private _Id As Integer
    Private _Tanggal As Date
    Private _Kandang_id As String
    Private _Pakan_harian As Integer
    Private _state As EntityState
    Private pakanRepo As IPakanRepository
    Private listViewPakan As List(Of PakanModel)

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Tanggal As Date
        Get
            Return _Tanggal
        End Get
        Set(value As Date)
            _Tanggal = value
        End Set
    End Property

    Public Property Kandang_id As String
        Get
            Return _Kandang_id
        End Get
        Set(value As String)
            _Kandang_id = value
        End Set
    End Property
    <Required(ErrorMessage:="The field identification number is required")>
    <RegularExpression("([0-9])+", ErrorMessage:="the field must be only number")>
    Public Property Pakan_harian As Integer
        Get
            Return _Pakan_harian
        End Get
        Set(value As Integer)
            _Pakan_harian = value
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

    Private Property PakanRepo1 As IPakanRepository
        Get
            Return pakanRepo
        End Get
        Set(value As IPakanRepository)
            pakanRepo = value
        End Set
    End Property

    Public Property ListViewPakan1 As List(Of PakanModel)
        Get
            Return listViewPakan
        End Get
        Set(value As List(Of PakanModel))
            listViewPakan = value
        End Set
    End Property

    'constructor
    Public Sub New()
        pakanRepo = New DataPakan()
    End Sub

    'methode
    Public Function saveChange() As String
        Dim message As String = Nothing
        Try
            Dim dataPakanModel As New Pakan()
            dataPakanModel.id = Id
            dataPakanModel.tanggal = Tanggal
            dataPakanModel.kandang_id = Kandang_id
            dataPakanModel.pakan_harian = Pakan_harian

            Select Case State
                Case EntityState.added
                    Dim result = pakanRepo.Add(dataPakanModel)
                    message = "Successfully add data"
                Case EntityState.modified
                    Dim result = pakanRepo.Edit(dataPakanModel)
                    message = "Successfully modified data"
                Case EntityState.deleted
                    Dim result = pakanRepo.Remove(Id)
                    message = "Successfully Delete data"
            End Select
        Catch ex As Exception

        End Try
        Return message
    End Function

    Public Function getPakan() As List(Of PakanModel)
        Dim listDataPakan = pakanRepo.GetAll()
        listViewPakan = New List(Of PakanModel)

        For Each item As Pakan In listDataPakan
            listViewPakan.Add(New PakanModel With {
            .Id = item.id,
            .Tanggal = item.tanggal,
            .Kandang_id = item.kandang_id,
            .Pakan_harian = item.pakan_harian
            })
        Next
        Return listViewPakan
    End Function

    Public Function FindData(value As String) As IEnumerable(Of PakanModel)
        Return getPakan.FindAll(Function(idk) idk.Kandang_id.Contains(value))
    End Function

End Class
