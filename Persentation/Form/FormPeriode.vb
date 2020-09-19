Imports Common
Imports Domain
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class FormPeriode
    Dim periodeModel As New PeriodeModel()

    Private Sub FormPeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listPeriode()
        Panel2.Enabled = False
        DateTimePicker.Value = DateTime.Now
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "dd/MM/yyyy"
        DateTimePickerClose.Value = DateTime.Now.AddDays(60)
        DateTimePickerClose.Format = DateTimePickerFormat.Custom
        DateTimePickerClose.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub listPeriode()
        Try
            DataGridView1.DataSource = periodeModel.GetPeriode()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub IconButtonAdd_Click(sender As Object, e As EventArgs) Handles IconButtonAdd.Click
        'Dim addPeriode As New AddPakan()
        'addPeriode.ShowDialog()
        periodeModel.State = EntityState.added
        Panel2.Enabled = True
    End Sub

    Private Sub IconButtonUpdate_Click(sender As Object, e As EventArgs)
        'Dim editPeriode As New FormEditPakan()
        'editPeriode.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = periodeModel.FindData(TextBox1.Text)
    End Sub

    Private Sub IconButtonUpdate_Click_1(sender As Object, e As EventArgs) Handles IconButtonUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Panel2.Enabled = True
            periodeModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            periodeModel.State = EntityState.modified
            ComboBoxFarmId.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
            DateTimePicker.Value = DataGridView1.CurrentRow.Cells(1).Value
            TextBoxMasuk.Text = DataGridView1.CurrentRow.Cells(3).Value
            TextBoxBonus.Text = DataGridView1.CurrentRow.Cells(4).Value
            ComboBoxPer.Text = DataGridView1.CurrentRow.Cells(5).Value
            DateTimePickerClose.Value = DataGridView1.CurrentRow.Cells(6).Value

        Else
            MessageBox.Show("Selected Row")
        End If
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            periodeModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            periodeModel.State = EntityState.deleted
            Dim result = periodeModel.saveChange()
            MessageBox.Show(result)
            listPeriode()
        Else
            MessageBox.Show("Delete Row")
        End If
    End Sub

    Private Sub IconButtonSave_Click(sender As Object, e As EventArgs) Handles IconButtonSave.Click
        periodeModel.Tanggal = DateTimePicker.Value
        periodeModel.Kandang_id = ComboBoxFarmId.SelectedItem
        periodeModel.Jlh_masuk = TextBoxMasuk.Text
        periodeModel.Jlh_bonus = TextBoxBonus.Text
        periodeModel.Periode = ComboBoxPer.Text
        periodeModel.Close_periode = DateTimePickerClose.Value
        Dim valid = New DataValidation(periodeModel).validate()
        If valid = True Then
            Dim result = periodeModel.saveChange()
            MessageBox.Show(result)
            listPeriode()
            restart()
        End If
    End Sub

    Private Sub restart()
        Panel2.Enabled = False
        ComboBoxFarmId.Text = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxMasuk.Clear()
        TextBoxBonus.Clear()
        ComboBoxPer.Text = ""
    End Sub

    Private Sub IconButtonCancel_Click(sender As Object, e As EventArgs) Handles IconButtonCancel.Click
        Panel2.Enabled = False
        ComboBoxFarmId.Text = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxMasuk.Clear()
        TextBoxBonus.Clear()
        ComboBoxPer.Text = ""
    End Sub
End Class