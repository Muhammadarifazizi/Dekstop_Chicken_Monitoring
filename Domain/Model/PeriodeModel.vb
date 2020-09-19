Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class PeriodeModel
    'field
    Private _id As Integer
    Private _tanggal As Date
    Private _kandang_id As String
    Private _jlh_masuk As Integer
    Private _jlh_bonus As Integer
    Private _periode As Integer
    Private _close_periode As Date
    Private _state As EntityState
    Private dataFarm As IEmployeRepository
    Private listViewPeriodeFarm As List(Of PeriodeModel)

    'properties/ view Models / data Validation

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

    <Required(ErrorMessage:="The field kandang Id is required")>
    Public Property Kandang_id As String
        Get
            Return _kandang_id
        End Get
        Set(value As String)
            _kandang_id = value
        End Set
    End Property
    <Required(ErrorMessage:="The field jumlah masuk is required")>
    <RegularExpression("([0-9])+", ErrorMessage:="Identification must be only number")>
    Public Property Jlh_masuk As Integer
        Get
            Return _jlh_masuk
        End Get
        Set(value As Integer)
            _jlh_masuk = value
        End Set
    End Property


    <Required(ErrorMessage:="The field bonus is required")>
    <RegularExpression("([0-9])+", ErrorMessage:="Identification must be only number")>
    Public Property Jlh_bonus As Integer
        Get
            Return _jlh_bonus
        End Get
        Set(value As Integer)
            _jlh_bonus = value
        End Set
    End Property
    <Required(ErrorMessage:="The field periode is required")>
    Public Property Periode As Integer
        Get
            Return _periode
        End Get
        Set(value As Integer)
            _periode = value
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

    Public Property DataFarm1 As IEmployeRepository
        Private Get
            Return dataFarm
        End Get
        Set(value As IEmployeRepository)
            dataFarm = value
        End Set
    End Property

    Public Property Close_periode As Date
        Get
            Return _close_periode
        End Get
        Set(value As Date)
            _close_periode = value
        End Set
    End Property
    'constructor
    Public Sub New()
        dataFarm = New DataPeriodeFarm()
    End Sub
    'methode
    Public Function saveChange() As String
        Dim message As String = Nothing

        Try
            Dim farmDataModel As New Periode()
            farmDataModel.id = Id
            farmDataModel.tanggal = Tanggal
            farmDataModel.kandang_id = Kandang_id
            farmDataModel.jlh_masuk = Jlh_masuk
            farmDataModel.jlh_bonus = Jlh_bonus
            farmDataModel.periode = Periode
            farmDataModel.close_periode = Close_periode

            Select Case State
                Case EntityState.added
                    dataFarm.Add(farmDataModel)
                    message = "Successfully add data"
                Case EntityState.modified
                    dataFarm.Edit(farmDataModel)
                    message = "Successfully modified data"
                Case EntityState.deleted
                    dataFarm.Remove(Id)
                    message = "Successfully Delete data"
            End Select
        Catch ex As Exception
            Dim mySqlEx As MySql.Data.MySqlClient.MySqlException = TryCast(ex, MySql.Data.MySqlClient.MySqlException)
            If mySqlEx IsNot Nothing AndAlso mySqlEx.Number = 2627 Then
                message = "Duplicate Record!"
            Else
                message = ex.ToString()
            End If

        End Try

        Return message
    End Function

    Public Function GetPeriode() As List(Of PeriodeModel)
        Dim listDataPeriodeFarm = dataFarm.GetAll()
        listViewPeriodeFarm = New List(Of PeriodeModel)

        For Each item As Periode In listDataPeriodeFarm
            listViewPeriodeFarm.Add(New PeriodeModel With {
            .Id = item.id,
            .Tanggal = item.tanggal,
            .Kandang_id = item.kandang_id,
            .Jlh_masuk = item.jlh_masuk,
            .Jlh_bonus = item.jlh_masuk,
            .Periode = item.periode,
            .Close_periode = item.close_periode
            })

        Next
        Return listViewPeriodeFarm
    End Function

    Public Function FindData(value As String) As IEnumerable(Of PeriodeModel)
        Return GetPeriode().FindAll(Function(idk) idk.Kandang_id.Contains(value))
    End Function


End Class
