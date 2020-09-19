Imports Domain
Imports Common
Public Class FormLog
    Dim isCollapsedFarm As Boolean = True
    Dim isCollapsedKandang As Boolean = True

    Dim logActivityModel As New LogActivityModel()

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles ListFarmOption.Paint

    End Sub

    Private Sub FormPeformance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListFarmOption.Size = ListFarmOption.MinimumSize
        PanellListKandang.Size = PanellListKandang.MinimumSize
        listLogActivity()

    End Sub

    Private Sub IconButtonListFarm_Click(sender As Object, e As EventArgs) Handles IconButtonListFarm.Click
        ListFarm.Start()
    End Sub

    Private Sub ListFarm_Tick(sender As Object, e As EventArgs) Handles ListFarm.Tick
        If isCollapsedFarm Then
            IconButtonListFarm.IconChar = FontAwesome.Sharp.IconChar.SortUp
            ListFarmOption.Height += 10
            If ListFarmOption.Size = ListFarmOption.MaximumSize Then
                isCollapsedFarm = False
                ListFarm.Stop()
            End If
        Else
            IconButtonListFarm.IconChar = FontAwesome.Sharp.IconChar.SortDown
            ListFarmOption.Height -= 10
            If ListFarmOption.Size = ListFarmOption.MinimumSize Then
                isCollapsedFarm = True
                ListFarm.Stop()
            End If
        End If
    End Sub

    Private Sub IconButtonListKandang_Click(sender As Object, e As EventArgs) Handles IconButtonListKandang.Click
        ListKandang.Start()
    End Sub

    Private Sub ListKandang_Tick(sender As Object, e As EventArgs) Handles ListKandang.Tick
        If isCollapsedKandang Then
            IconButtonListKandang.IconChar = FontAwesome.Sharp.IconChar.SortUp
            PanellListKandang.Height += 10
            If PanellListKandang.Size = PanellListKandang.MaximumSize Then
                isCollapsedKandang = False
                ListKandang.Stop()
            End If
        Else
            IconButtonListKandang.IconChar = FontAwesome.Sharp.IconChar.SortDown
            PanellListKandang.Height -= 10
            If PanellListKandang.Size = PanellListKandang.MinimumSize Then
                isCollapsedKandang = True
                ListKandang.Stop()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = logActivityModel.FindData(TextBox1.Text)
    End Sub

    Private Sub listLogActivity()
        Try
            DataGridView1.DataSource = logActivityModel.getLogActivity
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class