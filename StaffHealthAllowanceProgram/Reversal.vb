Imports MySql.Data.MySqlClient
Public Class Reversal
    Dim Description As String = ""
    Dim hosp As String = ""
    Dim age As Integer = 0
    Dim amountBalance As Double = 0
    Dim wardcount As Integer = 0

    Private Sub Reversal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rev_dateD.Value = Date.Now

        SQLCommand = "select `hospital_name` FROM `hospital`"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        transactingHospital.Items.Clear()
        adapter.Fill(SQLDataset)
        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            transactingHospital.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0))
        Next

        SQLCommand = "select `benefit_description` FROM `benefits`"
        Dim adapter2 As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset2 As New DataSet
        ' serviceType.Items.Clear()
        adapter2.Fill(SQLDataset2)
        For i = 0 To SQLDataset2.Tables(0).Rows.Count - 1
            serviceType.Items.Add((SQLDataset2.Tables(0).Rows(i)).Item(0))
        Next

        SQLCommand = "select `benefactory_description` FROM `benefactories`"
        Dim adapter3 As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset3 As New DataSet
        benefactorType.Items.Clear()
        adapter3.Fill(SQLDataset3)
        For i = 0 To SQLDataset3.Tables(0).Rows.Count - 1
            benefactorType.Items.Add((SQLDataset3.Tables(0).Rows(i)).Item(0))
        Next
        BenfactorID.Text = "NULL"
        serviceType.SelectedIndex = 0
        benefactorType.SelectedText = "Staff"
    End Sub

    Private Sub benefactorType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles benefactorType.SelectedIndexChanged
        SQLCommand = "select `first_name`,`last_name` FROM `" & benefactorType.SelectedItem.ToString & "`  ORDER BY `first_name` ASC"
        Dim adapter3 As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset3 As New DataSet
        benefactor.Items.Clear()
        adapter3.Fill(SQLDataset3)
        For i = 0 To SQLDataset3.Tables(0).Rows.Count - 1
            benefactor.Items.Add((SQLDataset3.Tables(0).Rows(i)).Item(0) & " " & (SQLDataset3.Tables(0).Rows(i)).Item(1))
        Next
        serviceType_SelectedIndexChanged(e, e)
        If (benefactorType.SelectedItem = "SPOUSE" Or benefactorType.SelectedItem = "WARD") Then
            serviceType.SelectedIndex = 0
            serviceType.Enabled = False
        Else
            serviceType.Enabled = True
        End If
    End Sub

    Private Sub serviceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles serviceType.SelectedIndexChanged
        SQLCommand = "SELECT  " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " from " & benefactorType.SelectedItem & " WHERE " & benefactorType.SelectedItem & "." & benefactorType.SelectedItem & "_ID LIKE '" & BenfactorID.Text & "'"
        Try
            Dim adapter3 As New MySqlDataAdapter(SQLCommand, SQLConnection)
            Dim SQLDataset3 As New DataSet
            adapter3.Fill(SQLDataset3)
            For i = 0 To SQLDataset3.Tables(0).Rows.Count - 1
                funds.Text = "$" & SQLDataset3.Tables(0).Rows(i).Item(0)
            Next
        Catch ex As Exception
            '  MsgBox("No " & serviceType.SelectedItem & " Entry For " & benefactorType.SelectedItem & "")
        End Try
    End Sub

    Private Sub benefactor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles benefactor.SelectedIndexChanged
        Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
        Dim names As String() = benefactor.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
        Dim len As Integer = names.Length
        Dim fname As String = names(0)
        Dim lname As String = names(len - 1)
        SQLCommand = "SELECT " & benefactorType.Text & "." & benefactorType.Text & "_ID FROM " & benefactorType.Text & " WHERE " & benefactorType.Text & ".first_name REGEXP '" & fname & "' AND " & benefactorType.Text & ".last_name REGEXP '" & lname & "'"
        Dim adapter3 As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset3 As New DataSet
        adapter3.Fill(SQLDataset3)
        For i = 0 To SQLDataset3.Tables(0).Rows.Count - 1
            BenfactorID.Text = SQLDataset3.Tables(0).Rows(i).Item(0)
        Next
        serviceType_SelectedIndexChanged(e, e)

        If (benefactorType.SelectedItem = "WARD") Then
            Dim dob As String = ""
            SQLCommand = "SELECT date_of_birth FROM ward WHERE ward_ID =" & BenfactorID.Text & ""
            Dim adapterr As New MySqlDataAdapter(SQLCommand, SQLConnection)
            Dim SQLDatasett As New DataSet

            adapterr.Fill(SQLDatasett)
            For i = 0 To SQLDatasett.Tables(0).Rows.Count - 1
                dob = (SQLDatasett.Tables(0).Rows(i)).Item(0)
            Next



            Dim dateOB As Date = Convert.ToDateTime(dob)
            age = dhAge(dateOB, Now)
            Home_DiffUI.getData("Update ward set age = " & age & " where ward.ward_id=" & BenfactorID.Text & "")


            Home_DiffUI.WardRadio_CheckedChanged(e, e)

            'Dim year As Integer = DateDiff(DateInterval.Year, dateOB, Now) - 1
            'Dim month As Integer = DateDiff(DateInterval.Month, dateOB, Now) Mod 12
            'Dim day As Integer = DateDiff(DateInterval.Day, dateOB, Now) Mod 30 - 10
            'MsgBox(year & "-" & month & "-" & day)
            'age = year
            'Dim dt As Date
            'If Date.TryParseExact(dob, "m/d/yyyy", Nothing, Globalization.DateTimeStyles.None, dt) Then
            'Dim Age As New Date(Now.Subtract(dt).Ticks)
            'Console.WriteLine(((Age.Days / 365.2425) - 1) & "----------------" & ((Age.Days / 365.2425)))
            'MsgBox(String.Format("Your age is : {0} Years and {1} Months", Age.Year - 1, Age.Month - 1))
            'Else
            'MsgBox("Birth Date is in wrong format")
            'End If

            'SQLCommand = "SELECT SUM(health_allowance) FROM ward WHERE ward.parent_ID LIKE ( SELECT ward.parent_ID FROM ward WHERE ward_ID =" & BenfactorID.Text & ")"
            'Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
            '    Dim SQLDataset As New DataSet

            '    adapter.Fill(SQLDataset)
            '    For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            '        amountBalance = (SQLDataset.Tables(0).Rows(i)).Item(0)
            '    Next
            '    funds.Text = "$" & amountBalance

            'SQLCommand = "SELECT COUNT(*) FROM ward WHERE ward.parent_ID LIKE ( SELECT ward.parent_ID FROM ward WHERE ward_ID =" & BenfactorID.Text & ")"
            '    Dim adapter6 As New MySqlDataAdapter(SQLCommand, SQLConnection)
            '    Dim SQLDataset6 As New DataSet

            '    adapter6.Fill(SQLDataset6)
            '    For i = 0 To SQLDataset6.Tables(0).Rows.Count - 1
            '        wardcount = (SQLDataset6.Tables(0).Rows(i)).Item(0)
            '    Next

            SQLCommand = "select `age` from `ward` where ward_id = " & BenfactorID.Text & ""

                Dim adapter4 As New MySqlDataAdapter(SQLCommand, SQLConnection)
                Dim sqldataset4 As New DataSet

                adapter4.Fill(sqldataset4)
                For i = 0 To sqldataset4.Tables(0).Rows.Count - 1
                    age = ((sqldataset4.Tables(0).Rows(i)).Item(0))
                Next

                If (age >= 18) Then
                    MsgBox("Ward is now 18 years Old", MsgBoxStyle.Critical)
                    MaterialFlatButton1.Enabled = False
                Else
                    MaterialFlatButton1.Enabled = True
                End If
            End If
    End Sub

    Function dhAge(dtmBD As Date, dtmDate As Date) As Integer
        ' This procedure is stored as dhAgeUnused in the sample
        ' module.
        Dim intAge As Integer
        intAge = DateDiff("yyyy", dtmBD, dtmDate)
        If dtmDate < DateSerial(Year(dtmDate), Month(dtmBD), dtmBD.Day) Then
            intAge = intAge - 1
        End If
        dhAge = intAge
    End Function

    'Private Sub transactingHospital_SelectedIndexChanged(sender As Object, e As EventArgs) Handles transactingHospital.SelectedIndexChanged
    '    If (transactingHospital.SelectedItem = "Other") Then
    '        Description = InputBox("Please specify!", "Specify for " & serviceType.SelectedItem, "Please enter description")
    '    Else
    '        Description = ""
    '    End If
    '    hosp = transactingHospital.SelectedIndex + 1
    'End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim entryDate As String = Now.Date.Year & "-" & Now.Date.Month & "-" & Now.Date.Day
        If (transactingHospital.SelectedItem = "" Or serviceType.SelectedItem = "" Or ReversalAmount.Text = "" Or benefactorType.SelectedItem = "" Or benefactor.SelectedItem = "" Or IsNumeric(ReversalAmount.Text) = False) Then
            MsgBox("Fill all fields required", MsgBoxStyle.Exclamation)
        Else
            Dim txn_date As String = rev_dateD.Value.Year & "-" & rev_dateD.Value.Month & "-" & rev_dateD.Value.Day
            Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
            Dim name As String() = benefactor.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            Dim nameLength As Integer = name.Length
            Dim fname As String = name(0)
            Dim lname As String = name(nameLength - 1)
            Dim dataTable As New DataTable

            Try
                If (ReversalAmount.Text <= 0) Then
                    MsgBox("Amount cannot be 0!!", MsgBoxStyle.Exclamation)
                Else
                    Home_DiffUI.refreshSettings()

                    If (benefactorType.SelectedItem = "WARD") Then
                        Dim balance = amountBalance / wardcount
                        Dim pID As String

                        SQLCommand = "SELECT ward.parent_ID FROM `ward` WHERE ward_ID = " & BenfactorID.Text & " "
                        Dim adapter3 As New MySqlDataAdapter(SQLCommand, SQLConnection)
                        Dim SQLDataset3 As New DataSet
                        adapter3.Fill(SQLDataset3)
                        For i = 0 To SQLDataset3.Tables(0).Rows.Count - 1
                            pID = ((SQLDataset3.Tables(0).Rows(i)).Item(0))

                        Next
                        'Console.WriteLine(amountBalance)
                        'Console.WriteLine(wardcount)
                        ' Using cmd As New MySqlCommand("UPDATE " & benefactorType.SelectedItem & " SET " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " = " & ((((amountBalance * Home_DiffUI.conv_rate) - transactionAmount.Text) / wardcount) / Home_DiffUI.conv_rate) & "  WHERE " & benefactorType.SelectedItem & "." & "parent_ID LIKE'" & pID & "' AND ward.age < 18", SQLConnection)
                        Using cmd As New MySqlCommand("UPDATE " & benefactorType.SelectedItem & " SET " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " = " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " + " & (ReversalAmount.Text / Home_DiffUI.conv_rate) & "  WHERE " & benefactorType.SelectedItem & "." & benefactorType.SelectedItem & "_ID LIKE'" & BenfactorID.Text & "'", SQLConnection)
                            cmd.CommandType = CommandType.Text
                            Using adapter As New MySqlDataAdapter(cmd)
                                adapter.Fill(dataTable)
                                Home_DiffUI.DataGridView1.DataSource = dataTable
                            End Using
                        End Using
                    Else

                        Using cmd As New MySqlCommand("UPDATE " & benefactorType.SelectedItem & " SET " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " = " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " + " & (ReversalAmount.Text / Home_DiffUI.conv_rate) & "  WHERE " & benefactorType.SelectedItem & "." & benefactorType.SelectedItem & "_ID LIKE'" & BenfactorID.Text & "'", SQLConnection)
                            cmd.CommandType = CommandType.Text
                            Using adapter As New MySqlDataAdapter(cmd)
                                adapter.Fill(dataTable)
                                Home_DiffUI.DataGridView1.DataSource = dataTable
                            End Using
                        End Using
                    End If
                    hosp = transactingHospital.SelectedIndex + 1
                    Description = "REVERSAL ON PREVIOUS DEBIT"
                    Home_DiffUI.getData("INSERT INTO `transaction` (`transaction_location_ID`, `transaction_type_ID`, `transaction_value`, `txn_benefactor_type`, `benefactor`, `txn_date`, `entryDate`, `description`) VALUES ('" & hosp & "', '" & serviceType.SelectedIndex + 1 & "', '" & ReversalAmount.Text & "', '" & benefactorType.SelectedIndex + 1 & "', '" & benefactor.SelectedItem.ToString & "', '" & txn_date & "', '" & entryDate & "', '" & Description & "')")
                    'If (MsgBox("Success! Add another record?", MsgBoxStyle.YesNo)) = DialogResult.No Then
                    '    'Transaction_Load(e, e)
                    '    Me.Close()
                    'Else
                    '    Me.Controls.Clear()
                    '    InitializeComponent()
                    '    Reversal_Load(e, e)
                    'End If
                    MsgBox("Success!", MsgBoxStyle.Information)
                    Me.Close()
                    Home_DiffUI.txns_CheckedChanged(e, e)
                End If

            Catch ex As MySqlException
                MsgBox("Debit amount exceeds balance!!!", MsgBoxStyle.Exclamation)
            End Try
            Home_DiffUI.DataGridView1.Show()
            ' Home_DiffUI.getData("UPDATE " & benefactorType.SelectedItem & " SET " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " = " & benefactorType.SelectedItem & "." & serviceType.SelectedItem & " - " & transactionAmount.Text & "  WHERE " & benefactorType.SelectedItem & ".first_name='" & fname & "' and " & benefactorType.SelectedItem & ".last_name='" & lname & "'")

        End If
    End Sub

    Private Sub MaterialLabel6_Click(sender As Object, e As EventArgs) Handles MaterialLabel6.Click

    End Sub
End Class