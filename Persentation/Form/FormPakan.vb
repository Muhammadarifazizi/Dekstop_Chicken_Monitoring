Imports Domain
Imports Common
Imports FontAwesome.Sharp

Public Class FormPakan
    Dim pakanModel As New PakanModel()

    Private Sub listPakan()
        Try
            DataGridView1.DataSource = pakanModel.getPakan
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
    Private Sub FormPakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listPakan()
        ManagePermission()
        Panel2.Enabled = False
        DateTimePicker.Value = DateTime.Now
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = pakanModel.FindData(TextBox1.Text)
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            pakanModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            pakanModel.State = EntityState.deleted
            Dim result = pakanModel.saveChange()
            MessageBox.Show(result)
            listPakan()
        Else
            MessageBox.Show("Delete Row")
        End If
    End Sub

    Private Sub IconButtonUpdate_Click(sender As Object, e As EventArgs) Handles IconButtonUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Panel2.Enabled = True
            pakanModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            pakanModel.State = EntityState.modified
            ComboBoxFarmId.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
            DateTimePicker.Value = DataGridView1.CurrentRow.Cells(1).Value
            TextBoxPakanHarian.Text = DataGridView1.CurrentRow.Cells(3).Value
        Else
            MessageBox.Show("Selected Row")
        End If
    End Sub

    Private Sub IconButtonAdd_Click(sender As Object, e As EventArgs) Handles IconButtonAdd.Click
        pakanModel.State = EntityState.added
        Panel2.Enabled = True
    End Sub

    Private Sub IconButtonCancel_Click(sender As Object, e As EventArgs) Handles IconButtonCancel.Click
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedText = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxPakanHarian.Clear()
    End Sub

    Private Sub IconButtonSave_Click(sender As Object, e As EventArgs) Handles IconButtonSave.Click
        pakanModel.Kandang_id = ComboBoxFarmId.SelectedItem
        pakanModel.Tanggal = DateTimePicker.Value
        pakanModel.Pakan_harian = TextBoxPakanHarian.Text

        Dim valid = New DataValidation(pakanModel).validate()
        If valid = True Then
            Dim result = pakanModel.saveChange()
            MessageBox.Show(result)
            listPakan()
            restart()
        End If
    End Sub
    Private Sub restart()
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedText = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxPakanHarian.Clear()
    End Sub
End Class