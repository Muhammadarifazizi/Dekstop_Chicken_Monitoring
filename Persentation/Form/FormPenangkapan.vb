Imports FontAwesome.Sharp
Imports Common
Imports Domain

Public Class FormPenangkapan

    Dim penangkapanModel As New PenangkapanModel()

    Private currentBtn As IconButton
    'Constructor
    Public Sub New()
        'thid call required by design
        InitializeComponent()
        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DissableButton()
            'customazing Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(51, 51, 76)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

        End If
    End Sub

    Private Sub DissableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(51, 51, 76)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub listPenangkapan()
        Try
            DataGridView1.DataSource = penangkapanModel.getPenangkapan()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub FormPenangkapan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManagePermission()
        listPenangkapan()
        Panel2.Enabled = False
        DateTimePicker.Value = DateTime.Now
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "dd/MM/yyyy"

    End Sub

    Private Sub ManagePermission()
        If ActiveUser.level = levelUser.input Then
            IconButtonDelete.Enabled = False
            IconButtonUpdate.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = penangkapanModel.FindData(TextBox1.Text)
    End Sub

    Private Sub IconButtonDelete_Click_1(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            penangkapanModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            penangkapanModel.State = EntityState.deleted
            Dim result = penangkapanModel.saveChange()
            MessageBox.Show(result)
            listPenangkapan()
        Else
            MessageBox.Show("Delete Row")
        End If
    End Sub

    Private Sub IconButtonUpdate_Click_1(sender As Object, e As EventArgs) Handles IconButtonUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Panel2.Enabled = True
            penangkapanModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            penangkapanModel.State = EntityState.modified
            ComboBoxFarmId.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
            DateTimePicker.Value = DataGridView1.CurrentRow.Cells(1).Value
            TextBoxJlhKecil.Text = DataGridView1.CurrentRow.Cells(3).Value
            TextBoxJlhSedang.Text = DataGridView1.CurrentRow.Cells(4).Value
            TextBoxJlhBesar.Text = DataGridView1.CurrentRow.Cells(5).Value
            TextBoxTtlBerat.Text = DataGridView1.CurrentRow.Cells(6).Value
        Else
            MessageBox.Show("Selected Row")
        End If
    End Sub

    Private Sub IconButtonAdd_Click_1(sender As Object, e As EventArgs) Handles IconButtonAdd.Click
        penangkapanModel.State = EntityState.added
        Panel2.Enabled = True
    End Sub

    Private Sub IconButtonCancel_Click(sender As Object, e As EventArgs) Handles IconButtonCancel.Click
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedItem = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxJlhKecil.Clear()
        TextBoxJlhSedang.Clear()
        TextBoxJlhBesar.Clear()
        TextBoxTtlBerat.Clear()
    End Sub

    Private Sub IconButtonSave_Click(sender As Object, e As EventArgs) Handles IconButtonSave.Click
        penangkapanModel.Kandang_id = ComboBoxFarmId.SelectedItem
        penangkapanModel.Tanggal = DateTimePicker.Value
        penangkapanModel.Jlh_kecil = TextBoxJlhKecil.Text
        penangkapanModel.Jlh_sedang = TextBoxJlhSedang.Text
        penangkapanModel.Jlh_besar = TextBoxJlhBesar.Text
        penangkapanModel.Ttl_berat = TextBoxTtlBerat.Text

        Dim valid = New DataValidation(penangkapanModel).validate()
        If valid = True Then
            Dim result = penangkapanModel.saveChange()
            MessageBox.Show(result)
            listPenangkapan()
            restart()
        End If
    End Sub
    Private Sub restart()
        Panel2.Enabled = False
        ComboBoxFarmId.SelectedText = ""
        DateTimePicker.Value = DateTime.Now
        TextBoxJlhKecil.Clear()
        TextBoxJlhSedang.Clear()
        TextBoxJlhBesar.Clear()
        TextBoxTtlBerat.Clear()
    End Sub
End Class