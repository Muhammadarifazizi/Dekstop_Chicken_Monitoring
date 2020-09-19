Imports Domain
Imports Common
Public Class FormDeplesi
    Dim deplesiModel As New DeplesiModel()

    Private Sub listDeplesi()
        Try
            DataGridView1.DataSource = deplesiModel.getDeplesi
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
    Private Sub FormDeplesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listDeplesi()
        ManagePermission()
        Panel2.Enabled = False
        DateTimePicker.Value = DateTime.Now
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = deplesiModel.FindData(TextBox1.Text)
    End Sub

    Private Sub IconButtonSave_Click(sender As Object, e As EventArgs) Handles IconButtonSave.Click
        deplesiModel.Kandang_id = ComboBoxFarmId.SelectedItem
        deplesiModel.Tanggal = DateTimePicker.Value
        deplesiModel.Jlh_mati = TextBoxJlhMati.Text
        deplesiModel.Jlh_afkir = TextBoxJlhAfkir.Text

        Dim valid = New DataValidation(deplesiModel).validate()
        If valid = True Then
            Dim result = deplesiModel.saveChange()
            MessageBox.Show(result)
            listDeplesi()
            restart()
        End If
    End Sub
    Private Sub restart()
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedValue = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxJlhMati.Clear()
        TextBoxJlhAfkir.Clear()
    End Sub
    Private Sub IconButtonCancel_Click(sender As Object, e As EventArgs) Handles IconButtonCancel.Click
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedValue = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxJlhMati.Clear()
        TextBoxJlhAfkir.Clear()
    End Sub

    Private Sub IconButtonAdd_Click(sender As Object, e As EventArgs) Handles IconButtonAdd.Click
        deplesiModel.State = EntityState.added
        Panel2.Enabled = True
    End Sub

    Private Sub IconButtonUpdate_Click(sender As Object, e As EventArgs) Handles IconButtonUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Panel2.Enabled = True
            deplesiModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            deplesiModel.State = EntityState.modified
            ComboBoxFarmId.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
            DateTimePicker.Value = DataGridView1.CurrentRow.Cells(1).Value
            TextBoxJlhMati.Text = DataGridView1.CurrentRow.Cells(3).Value
            TextBoxJlhAfkir.Text = DataGridView1.CurrentRow.Cells(4).Value
        Else
            MessageBox.Show("Selected Row")
        End If
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            deplesiModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            deplesiModel.State = EntityState.deleted
            Dim result = deplesiModel.saveChange()
            MessageBox.Show(result)
            listDeplesi()
        Else
            MessageBox.Show("Delete Row")
        End If
    End Sub
End Class