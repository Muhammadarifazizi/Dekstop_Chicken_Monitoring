Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class DeplesiModel
    Private _id As Integer
    Private _tanggal As Date
    Private _kandang_id As String
    Private _jlh_mati As Integer
    Private _jlh_afkir As Integer
    Private _state As EntityState
    Private deplesiRepo As IDeplesi
    Private listViewDeplesi As List(Of DeplesiModel)



    Public Sub New()
        deplesiRepo = New DataDeplesi()
    End Sub

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
    <Required(ErrorMessage:="The field identification number is required")>
    <RegularExpression("([0-9])+", ErrorMessage:="the field must be only number")>
    Public Property Jlh_mati As Integer
        Get
            Return _jlh_mati
        End Get
        Set(value As Integer)
            _jlh_mati = value
        End Set
    End Property
    <Required(ErrorMessage:="The field identification number is required")>
    <RegularExpression("([0-9])+", ErrorMessage:="the field must be only number")>
    Public Property Jlh_afkir As Integer
        Get
            Return _jlh_afkir
        End Get
        Set(value As Integer)
            _jlh_afkir = value
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

    'methode
    Public Function saveChange() As String
        Dim message As String = Nothing
        Try
            Dim dataDeplesiModel As New Deplesi()
            dataDeplesiModel.id = Id
            dataDeplesiModel.tanggal = tanggal
            dataDeplesiModel.kandang_id = Kandang_id
            dataDeplesiModel.jlh_mati = Jlh_mati
            dataDeplesiModel.jlh_afkir = Jlh_afkir

            Select Case State
                Case EntityState.added
                    Dim result = deplesiRepo.Add(dataDeplesiModel)
                    message = "Successfully add data"
                Case EntityState.modified
                    Dim result = deplesiRepo.Edit(dataDeplesiModel)
                    message = "Successfully modified data"
                Case EntityState.deleted
                    Dim result = deplesiRepo.Remove(Id)
                    message = "Successfully Delete data"
            End Select
        Catch ex As Exception

        End Try
        Return message
    End Function

    Public Function getDeplesi() As List(Of DeplesiModel)
        Dim listDataDeplesi = deplesiRepo.GetAll()
        listViewDeplesi = New List(Of DeplesiModel)

        For Each item As Deplesi In listDataDeplesi
            listViewDeplesi.Add(New DeplesiModel With {
            .Id = item.id,
            .Tanggal = item.tanggal,
            .Kandang_id = item.kandang_id,
            .Jlh_mati = item.jlh_mati,
            .Jlh_afkir = item.jlh_afkir
            })
        Next
        Return listViewDeplesi
    End Function
    Public Function FindData(value As String) As IEnumerable(Of DeplesiModel)
        Return getDeplesi.FindAll(Function(idk) idk.Kandang_id.Contains(value))
    End Function
End Class
