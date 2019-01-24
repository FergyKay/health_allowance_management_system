Imports MySql.Data.MySqlClient
Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioPanel.Enabled = False
        DataGridView1.Hide()
        UpdatePanel.Hide()
        AddOptions.Hide()
        'settingsPane.Hide()
    End Sub

    Public Function GetGroupBoxCheckedButton(RadioPanel As FlowLayoutPanel) As String
        For Each ctrl As RadioButton In RadioPanel.Controls
            If ctrl.Checked Then
                Return ctrl.Text
            End If
        Next
    End Function

    Private Sub VIewRecords_Click(sender As Object, e As EventArgs) Handles VIewRecords.Click
        RadioPanel.Enabled = True
        StaffRadio.Checked = True
        UpdatePanel.Hide()
        ' settingsPane.Hide()
        getData("select * from `staff`")
    End Sub

    Public Sub getData(ByVal query)
        Dim dataTable As New DataTable
        Try
            Using cmd As New MySqlCommand(query, SQLConnection)
                cmd.CommandType = CommandType.Text
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGridView1.Show()
    End Sub

    Private Sub StaffRadio_CheckedChanged(sender As Object, e As EventArgs) Handles StaffRadio.CheckedChanged
        Dim comm As String = "select * from `staff`"
        getData(comm)
        print.Show()
    End Sub

    Private Sub SpouseRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SpouseRadio.CheckedChanged
        Dim comm As String = "Select * from `spouse`"
        getData(comm)
        print.Show()
    End Sub

    Private Sub WardRadio_CheckedChanged(sender As Object, e As EventArgs) Handles WardRadio.CheckedChanged
        Dim comm As String = "Select * from `WARD`"
        getData(comm)
        print.Show()
    End Sub

    Private Sub DepartmentRadio_CheckedChanged(sender As Object, e As EventArgs) Handles DepartmentRadio.CheckedChanged
        getData("Select * from `department`")
        print.Hide()
    End Sub

    Private Sub HospitalRadio_CheckedChanged(sender As Object, e As EventArgs) Handles HospitalRadio.CheckedChanged
        getData("Select * from `hospital`")
        print.Hide()
    End Sub

    Private Sub txns_CheckedChanged(sender As Object, e As EventArgs) Handles txns.CheckedChanged
        Dim comm As String = "Select transaction.benefactor, hospital.hospital_name, transaction.transaction_value, transaction.txn_date FROM transaction INNER JOIN hospital On transaction.transaction_location_ID=hospital.hospital_ID"
        getData(comm)
        print.Show()
    End Sub

    Private Sub UpdateRecords_Click(sender As Object, e As EventArgs) Handles UpdateRecords.Click
        UpdatePanel.Show()
        DataGridView1.Hide()
        'settingsPane.Hide()
        RadioPanel.Enabled = False
    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        If (MsgBox("Are you sure?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            InitializeComponent()
            LoginPage.Username.Clear()
            LoginPage.PassWord.Clear()
            LoginPage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AddOptions.Hide()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        AddStaffForm.Show()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        AddSpouseForm.Show()
    End Sub

    Private Sub AddButton_MouseClick(sender As Object, e As MouseEventArgs) Handles AddButton.MouseClick
        AddOptions.Show()
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        AddWardForm.Show()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs)
        DeleteRecords.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        RadioPanel.Enabled = False
        DataGridView1.Hide()
        UpdatePanel.Hide()
        AddOptions.Hide()
        'settingsPane.Show()
    End Sub

    Private Sub updateClient_Click(sender As Object, e As EventArgs) Handles updateClient.Click
        Transaction.Show()
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        Printer.SQLCommand = "Select * From `" & GetGroupBoxCheckedButton(RadioPanel) & "`"
        Printer.Source = GetGroupBoxCheckedButton(RadioPanel)
        Printer.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control) Then
            FInd.Show()
        End If
    End Sub
End Class