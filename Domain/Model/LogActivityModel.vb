Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class LogActivityModel
    Private _AutoLog As Integer
    Private _DateTimeLog As Date
    Private _ActivityLog As String
    Private _UserLog As String
    Private _PCLog As String
    Private _state As EntityState
    Private logActivityRepo As ILogActivity
    Private listViewLogActivity As List(Of LogActivityModel)

    Public Property AutoLog As Integer
        Get
            Return _AutoLog
        End Get
        Set(value As Integer)
            _AutoLog = value
        End Set
    End Property

    Public Property DateTimeLog As Date
        Get
            Return _DateTimeLog
        End Get
        Set(value As Date)
            _DateTimeLog = value
        End Set
    End Property

    Public Property ActivityLog As String
        Get
            Return _ActivityLog
        End Get
        Set(value As String)
            _ActivityLog = value
        End Set
    End Property

    Public Property UserLog As String
        Get
            Return _UserLog
        End Get
        Set(value As String)
            _UserLog = value
        End Set
    End Property

    Public Property PCLog As String
        Get
            Return _PCLog
        End Get
        Set(value As String)
            _PCLog = value
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

    Public Sub New()
        logActivityRepo = New DataLogActivity()
    End Sub

    Public Function saveChange() As String
        Dim message As String = Nothing
        Try
            Dim dataLogActivityModel As New LogActivity()
            dataLogActivityModel.AutoLog = AutoLog
            dataLogActivityModel.DateTimeLog = DateTimeLog
            dataLogActivityModel.ActivityLog = ActivityLog
            dataLogActivityModel.UserLog = UserLog
            dataLogActivityModel.PCLog = PCLog

            logActivityRepo.Add(dataLogActivityModel)
            message = "Successfully add log"

        Catch ex As Exception

        End Try
        Return message
    End Function
    Public Function getLogActivity() As List(Of LogActivityModel)
        Dim listDataLogActivity = logActivityRepo.GetAll()
        listViewLogActivity = New List(Of LogActivityModel)

        For Each item As LogActivity In listDataLogActivity
            listViewLogActivity.Add(New LogActivityModel With {
            .AutoLog = item.AutoLog,
            .DateTimeLog = item.DateTimeLog,
            .ActivityLog = item.ActivityLog,
            .UserLog = item.UserLog,
            .PCLog = item.PCLog
            })
        Next
        Return listViewLogActivity
    End Function

    Public Function FindData(value As String) As IEnumerable(Of LogActivityModel)
        Return getLogActivity.FindAll(Function(user) user.UserLog.Contains(value) OrElse user.DateTimeLog.CompareTo(value))
    End Function
End Class
