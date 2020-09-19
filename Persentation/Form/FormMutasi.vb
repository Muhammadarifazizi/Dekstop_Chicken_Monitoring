Imports Domain
Imports Common
Public Class FormMutasi
    Dim mutasiModel As New MutasiModel()
    Dim logActivityModel As New LogActivityModel()

    Private Sub listMutasi()
        Try
            DataGridView1.DataSource = mutasiModel.getMutasi
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ManagePermission()
        If ActiveUser.level = levelUser.input Then
            IconButtonDelete.Enabled = False
            IconButtonUpdate.Enabled = False
        End If
    End Sub
    Private Sub FormMutasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listMutasi()
        ManagePermission()
        Panel2.Enabled = False
        DateTimePicker.Value = DateTime.Now
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = mutasiModel.FindData(TextBox1.Text)
    End Sub

    Private Sub IconButtonSave_Click(sender As Object, e As EventArgs) Handles IconButtonSave.Click
        mutasiModel.Kandang_id = ComboBoxFarmId.SelectedItem
        mutasiModel.Tgl_mutasi = DateTimePicker.Value
        mutasiModel.Jlh_mutasi = TextBoxJlhMutasi.Text
        mutasiModel.Tujuan_kandang = ComboBoxTujuanKandang.SelectedItem

        Dim valid = New DataValidation(mutasiModel).validate()
        If valid = True Then
            Dim result = mutasiModel.saveChange()
            MessageBox.Show(result)
            listMutasi()
            restart()
        End If
    End Sub

    Private Sub logAdd()
        Dim DateTimeSystem = Now
        Dim vActivity = "INSERT INTO mutasi (kandang_id, tgl_mutasi, jlh_mutasi, tujuan_kandang) values('" & mutasiModel.Kandang_id & "','" & mutasiModel.Tgl_mutasi & "','" & mutasiModel.Jlh_mutasi & "','" & mutasiModel.Tujuan_kandang & "') "
        Dim vUserLog = ActiveUser.firstName + " " + ActiveUser.lastName
        Dim vPCLog = "PC1"
        logActivityModel.DateTimeLog = DateTimeSystem
        logActivityModel.ActivityLog = vActivity
        logActivityModel.UserLog = vUserLog
        logActivityModel.PCLog = vPCLog

        Dim valid = New DataValidation(logActivityModel).validate()
        If valid = True Then
            Dim result = logActivityModel.saveChange()
            MessageBox.Show(result)
        End If
    End Sub

    Private Sub IconButtonCancel_Click(sender As Object, e As EventArgs) Handles IconButtonCancel.Click
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedItem = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxJlhMutasi.Clear()
        ComboBoxTujuanKandang.SelectedItem = ""
    End Sub

    Private Sub IconButtonAdd_Click(sender As Object, e As EventArgs) Handles IconButtonAdd.Click
        mutasiModel.State = EntityState.added
        Panel2.Enabled = True
    End Sub

    Private Sub IconButtonUpdate_Click(sender As Object, e As EventArgs) Handles IconButtonUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Panel2.Enabled = True
            mutasiModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            mutasiModel.State = EntityState.modified
            ComboBoxFarmId.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value
            DateTimePicker.Value = DataGridView1.CurrentRow.Cells(1).Value
            TextBoxJlhMutasi.Text = DataGridView1.CurrentRow.Cells(2).Value
            ComboBoxTujuanKandang.SelectedItem = DataGridView1.CurrentRow.Cells(4).Value
        Else
            MessageBox.Show("Selected Row")
        End If
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            mutasiModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            mutasiModel.State = EntityState.deleted
            Dim result = mutasiModel.saveChange()
            MessageBox.Show(result)
            listMutasi()
        Else
            MessageBox.Show("Delete Row")
        End If
    End Sub
    Private Sub restart()
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedItem = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxJlhMutasi.Clear()
        ComboBoxTujuanKandang.SelectedItem = ""
    End Sub
End Class