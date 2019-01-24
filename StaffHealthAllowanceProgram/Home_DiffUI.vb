Imports MySql.Data.MySqlClient
Public Class Home_DiffUI
    Public conv_rate, staff_health, staff_dental, staff_optical, spouse_health, ward_health, staff_health_old, staff_dental_old, staff_optical_old, spouse_health_old, ward_health_old As Decimal
    Public code As Integer

    Private Sub HomeDiffUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        RadioPanel.Enabled = False
        DataGridView1.Hide()
        searchPanel.Hide()
        findButton.Hide()
        'UpdatePanel.Hide()
        ' AddOptions.Hide()
        settingsPanel.Hide()
        Panel1.Hide()
        ViewRecords_Click(e, e)
        If (GetGroupBoxCheckedButton(LoginPage.FlowLayoutPanel1) = "User") Then
            Me.SetttingsToolStripMenuItem.Enabled = False
            Me.UpdateRecordsToolStripMenuItem.Enabled = False
        End If
    End Sub

    Public Sub refreshSettings()
        SQLCommand = "SELECT * FROM `settings` ORDER by date DESC limit 1 "
        Dim adapter2 As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset2 As New DataSet

        adapter2.Fill(SQLDataset2)
        conv_rate = SQLDataset2.Tables(0).Rows(0).Item(1)
        staff_health = SQLDataset2.Tables(0).Rows(0).Item(2)
        staff_dental = SQLDataset2.Tables(0).Rows(0).Item(3)
        staff_optical = SQLDataset2.Tables(0).Rows(0).Item(4)
        spouse_health = SQLDataset2.Tables(0).Rows(0).Item(5)
        ward_health = SQLDataset2.Tables(0).Rows(0).Item(6)
    End Sub

    Public Function GetGroupBoxCheckedButton(RadioPanel As FlowLayoutPanel) As String
        For Each ctrl As RadioButton In RadioPanel.Controls
            If ctrl.Checked Then
                Return ctrl.Text
            End If
        Next
        Return False
    End Function

    Private Sub ViewRecords_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        RadioPanel.Enabled = True
        StaffRadio.Checked = True
        findButton.Show()
        Panel1.Hide()
        settingsPanel.Hide()
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
            code = 1
        Catch ex As Exception
            'MsgBox(ex.Message)
            code = 0
        End Try
        DataGridView1.Show()
    End Sub

    Public Sub StaffRadio_CheckedChanged(sender As Object, e As EventArgs) Handles StaffRadio.CheckedChanged
        Dim comm As String = "select * from `staff`"
        getData(comm)
        findButton.Enabled = True
    End Sub

    Public Sub SpouseRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SpouseRadio.CheckedChanged
        Dim comm As String = "Select * from `spouse`"
        getData(comm)
        findButton.Enabled = True
    End Sub

    Public Sub WardRadio_CheckedChanged(sender As Object, e As EventArgs) Handles WardRadio.CheckedChanged
        Dim comm As String = "Select * from `WARD`"
        getData(comm)
        findButton.Enabled = True
    End Sub

    Private Sub DepartmentRadio_CheckedChanged(sender As Object, e As EventArgs) Handles DepartmentRadio.CheckedChanged
        findButton.Enabled = False
        getData("Select * from `department`")
    End Sub

    Private Sub HospitalRadio_CheckedChanged(sender As Object, e As EventArgs) Handles HospitalRadio.CheckedChanged
        findButton.Enabled = False
        getData("Select * from `hospital`")
    End Sub

    Public Sub txns_CheckedChanged(sender As Object, e As EventArgs) Handles txns.CheckedChanged
        Dim comm As String = "Select transaction.benefactor, hospital.hospital_name,transaction.description, transaction.transaction_value, transaction.txn_date, transaction.entryDate FROM transaction INNER JOIN hospital On transaction.transaction_location_ID=hospital.hospital_ID"
        findButton.Enabled = False
        getData(comm)
    End Sub

    Private Sub UpdateRecords_Click(sender As Object, e As EventArgs) Handles UpdateRecordsToolStripMenuItem.Click
        ' UpdatePanel.Show()
        'DataGridView1.Hide()
        settingsPanel.Hide()
        'RadioPanel.Enabled = False
    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If (MsgBox("Are you sure?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            disConnectFromDatabase()
            connectToDatabase()
            InitializeComponent()
            LoginPage.Username.Clear()
            LoginPage.PassWord.Clear()
            ' LoginPage.Dispose()
            LoginPage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        staffIDSearchCriteria.Checked = True
        searchPanel.Visible = Not searchPanel.Visible
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (GetGroupBoxCheckedButton(RadioPanel) = "Staff") Then
            Dim findCommand As String = "SELECT * FROM `" & GetGroupBoxCheckedButton(RadioPanel) & "` WHERE `" & GetGroupBoxCheckedButton(FlowLayoutPanel1) & "` LIKE '%" & searchString.Text & "%'"
            getData(findCommand)
        ElseIf (GetGroupBoxCheckedButton(RadioPanel) = "Spouse") Then
            If (GetGroupBoxCheckedButton(FlowLayoutPanel1) = "Staff_ID") Then
                Dim findCommand As String = "SELECT * FROM `" & GetGroupBoxCheckedButton(RadioPanel) & "` WHERE `partner_ID` LIKE '%" & searchString.Text & "%'"
                getData(findCommand)
            Else
                Dim findCommand As String = "SELECT * FROM `" & GetGroupBoxCheckedButton(RadioPanel) & "` WHERE `last_name` LIKE '%" & searchString.Text & "%'"
                getData(findCommand)
            End If
        Else
            If (GetGroupBoxCheckedButton(FlowLayoutPanel1) = "Staff_ID") Then
                Dim findCommand As String = "SELECT * FROM `" & GetGroupBoxCheckedButton(RadioPanel) & "` WHERE `parent_ID` LIKE '%" & searchString.Text & "%'"
                getData(findCommand)
            Else
                Dim findCommand As String = "SELECT * FROM `" & GetGroupBoxCheckedButton(RadioPanel) & "` WHERE `last_name` LIKE '%" & searchString.Text & "%'"
                getData(findCommand)
            End If
        End If

    End Sub


    Private Sub StaffSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffSummaryToolStripMenuItem.Click
        Dim staff As New Printer
        staff.name = "Staff Records"
        staff.SQLCommand = "Select * From `" & StaffSummaryToolStripMenuItem.Text & "`"
        staff.Source = StaffSummaryToolStripMenuItem.Text
        staff.Show()
    End Sub

    Private Sub SpouseSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpouseSummaryToolStripMenuItem.Click
        Dim spouse As New Printer
        spouse.SQLCommand = "Select * From `" & SpouseSummaryToolStripMenuItem.Text & "`"
        spouse.name = "Spouse Records"
        spouse.Source = SpouseSummaryToolStripMenuItem.Text
        spouse.Show()
    End Sub

    Private Sub WardSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WardSummaryToolStripMenuItem.Click
        Dim ward As New Printer
        ward.name = "Ward Records"
        ward.SQLCommand = "Select * From `" & WardSummaryToolStripMenuItem.Text & "`"
        ward.Source = WardSummaryToolStripMenuItem.Text
        ward.Show()
    End Sub

    Private Sub UpdateRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRecordToolStripMenuItem.Click
        Transaction.Show()
    End Sub

    Private Sub WardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WardToolStripMenuItem.Click
        AddWardForm.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        AddStaffForm.Show()
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim today As String = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day
        getData("INSERT INTO `settings` (`date`, `conv_rate`, `staff_health_allowance`, `staff_dental_allowance`, `staff_optical_allowance`, `spouse_health_allowance`, `ward_health_allowance`) VALUES ('" & today & "', '" & ex_rate.Text & "', '" & StaffHealth.Text & "', '" & staffDental.Text & "', '" & StaffOptical.Text & "', '" & spouseHealth.Text & "', '" & WardHealth.Text & "')")
        If (code = 1) Then
            UpdateDB(StaffHealth.Text, staffDental.Text, StaffOptical.Text, spouseHealth.Text, WardHealth.Text)
            settingsPanel.Hide()
        Else
            settingsPanel.Hide()
            MsgBox("Operation Not Permitted")
        End If
        settings_CheckedChanged(e, e)
        RadioPanel.Enabled = True
    End Sub

    Private Sub UpdateDB(sHealth As String, sDental As String, sOptical As String, spHealth As String, wHealth As String)
        SQLCommand = "SELECT * FROM `settings` ORDER by date DESC limit 2 "
        Dim adapter2 As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset2 As New DataSet

        adapter2.Fill(SQLDataset2)
        staff_health = SQLDataset2.Tables(0).Rows(0).Item(2)
        staff_dental = SQLDataset2.Tables(0).Rows(0).Item(3)
        staff_optical = SQLDataset2.Tables(0).Rows(0).Item(4)
        spouse_health = SQLDataset2.Tables(0).Rows(0).Item(5)
        ward_health = SQLDataset2.Tables(0).Rows(0).Item(6)

        staff_health_old = SQLDataset2.Tables(0).Rows(1).Item(2)
        staff_dental_old = SQLDataset2.Tables(0).Rows(1).Item(3)
        staff_optical_old = SQLDataset2.Tables(0).Rows(1).Item(4)
        spouse_health_old = SQLDataset2.Tables(0).Rows(1).Item(5)
        ward_health_old = SQLDataset2.Tables(0).Rows(1).Item(6)


        If ((staff_health - staff_health_old) > 0) Then
            getData("update staff set staff.health_allowance = staff.healthallowance + " + (staff_health - staff_health_old))
            MsgBox("Staff Health Allowance Quota succesfully changed from $" & staff_health_old & " to $" & staff_health & " and all records updated to reflect change", MsgBoxStyle.Information)
        Else
            MsgBox("No Changes Made to Staff Health Allowance Quota", MsgBoxStyle.Information)
        End If

        If ((staff_dental - staff_dental_old) > 0) Then
            getData("update staff set staff.dental_allowance = staff.dental_allowance + " & (staff_dental - staff_dental_old))
            MsgBox("Staff Dental Allowance Quota succesfully changed from $" & staff_dental_old & " to $" & staff_dental & " and all records updated to reflect change", MsgBoxStyle.Information)

        Else
            MsgBox("No Changes Made to Staff Dental Allowance Quota", MsgBoxStyle.Information)
        End If

        If ((staff_optical - staff_optical_old) > 0) Then
            getData("update staff set staff.optical_allowance = staff.optical_allowance + " & (staff_optical - staff_optical_old))
            MsgBox("Staff Optical Allowance Quota succesfully changed from $" & staff_optical_old & " to $" & staff_optical & " and all records updated to reflect change", MsgBoxStyle.Information)
        Else
            MsgBox("No Changes Made to Staff Optical Allowance Quota", MsgBoxStyle.Information)
        End If

        If ((spouse_health - spouse_health_old) > 0) Then
            getData("update spouse set spouse.health_allowance = spouse.healthallowance + " + (spouse_health - spouse_health_old))
            MsgBox("Spouse Health Allowance Quota succesfully changed from $" & spouse_health_old & " to $" & spouse_health & " and all records updated to reflect change", MsgBoxStyle.Information)
        Else
            MsgBox("No Changes Made to Spouse Health Allowance Quota", MsgBoxStyle.Information)
        End If

        If ((ward_health - ward_health_old) > 0) Then
            getData("update ward set ward.health_allowance = ward.healthallowance + " + (ward_health - ward_health_old))
            MsgBox("Ward Health Allowance Quota succesfully changed from $" & ward_health_old & " to $" & ward_health & " and all records updated to reflect change", MsgBoxStyle.Information)
        Else
            MsgBox("No Changes Made to Ward Health Allowance Quota", MsgBoxStyle.Information)
        End If






    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Panel1.Visible = Not Panel1.Visible
    End Sub

    Private Sub ExpensesSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesSummaryToolStripMenuItem.Click
        Dim qwery As New Printer
        qwery.SQLCommand = "Select * From `staff`"
        qwery.name = "Expenses Summary"
        qwery.Source = "Expenses"
        qwery.Show()
    End Sub

    Private Sub DetailedRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailedRecordToolStripMenuItem.Click
        Dim qwery As New Printer
        qwery.SQLCommand = "Select * From `staff`"
        qwery.name = "Detailed Record"
        qwery.Source = "QueryRecord"
        qwery.Show()

    End Sub

    Private Sub StaffToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem1.Click
        ModStaff.Show()
    End Sub

    Private Sub SpouseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SpouseToolStripMenuItem1.Click
        ModSpouse.Show()
    End Sub

    Private Sub WardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WardToolStripMenuItem1.Click
        ModWard.Show()
    End Sub

    Private Sub ReversalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReversalToolStripMenuItem.Click
        Reversal.Show()
    End Sub

    Private Sub SpouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpouseToolStripMenuItem.Click
        AddSpouseForm.Show()
    End Sub

    Private Sub TransactionSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionSummaryToolStripMenuItem.Click
        Dim txn As New Printer
        txn.name = "Transactions"
        txn.SQLCommand = "Select * From `" & TransactionSummaryToolStripMenuItem.Text & "`"
        txn.Source = TransactionSummaryToolStripMenuItem.Text
        txn.Show()
    End Sub

    Private Sub settings_CheckedChanged(sender As Object, e As EventArgs) Handles settings.CheckedChanged
        Dim comm As String = "select * from `settings`"
        getData(comm)
        findButton.Enabled = False
    End Sub

    Private Sub SetttingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetttingsToolStripMenuItem.Click
        RadioPanel.Enabled = False
        settingsPanel.Show()
        DataGridView1.Hide()
        Panel1.Hide()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control) Then
            findButton_Click(e, e)
        End If
    End Sub
End Class
