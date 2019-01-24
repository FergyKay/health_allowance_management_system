Imports MySql.Data.MySqlClient
Public Class ModWard
    Private Sub ModWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLCommand = "select `staff_ID` FROM `staff` ORDER BY `staff_ID` ASC"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        parentCombo.Items.Clear()
        adapter.Fill(SQLDataset)

        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            parentCombo.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0))
        Next
    End Sub

    Private Sub parentCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles parentCombo.SelectedIndexChanged
        firstNameField.Clear()
        surnameField.Clear()
        emailField.Clear()
        maleRadio.Checked = False
        femaleRadio.Checked = False
        wardCombo.Items.Clear()
        SQLCommand = "select `ward_id` FROM `ward` where `parent_ID` LIKE '" & parentCombo.SelectedItem & "'"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        wardCombo.Items.Clear()
        adapter.Fill(SQLDataset)
        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            wardCombo.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0))
        Next
        Try
            wardCombo.SelectedIndex = 0
        Catch ex As Exception

        End Try

    End Sub


    Private Sub wardCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wardCombo.SelectedIndexChanged
        firstNameField.Clear()
        surnameField.Clear()
        emailField.Clear()
        maleRadio.Checked = False
        femaleRadio.Checked = False
        Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
        Dim pid As String() = parentCombo.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
        Dim idFinal As String = pid(0)
        cmd = New MySqlCommand("select * FROM `ward` WHERE `ward_id` LIKE '" & wardCombo.SelectedItem & "'", SQLConnection)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read
            surnameField.Text = reader(3).ToString
            firstNameField.Text = reader(2).ToString
            dob.Value = reader(4).ToString
            If (reader(6).ToString = "Male") Then
                maleRadio.Checked = True
            Else
                femaleRadio.Checked = True
            End If
            If (reader(7).ToString = "NULL") Then
                emailField.Text = " "
            Else
                emailField.Text = reader(7).ToString
            End If
        End While
        reader.Close()
    End Sub

    Private Sub AddWardButton_Click(sender As Object, e As EventArgs) Handles AddWardButton.Click
        Dim Age As Integer
        Dim dobB As String = dob.Value.Year & "-" & dob.Value.Month & "-" & dob.Value.Day
        Dim DOBBB As New Date(dob.Value.Year.ToString, dob.Value.Month.ToString, dob.Value.Day.ToString)

        'Dim year As Integer = DateDiff(DateInterval.Year, DOBBB, Now) - 1
        'Dim month As Integer = DateDiff(DateInterval.Month, DOBBB, Now) Mod 12
        'Dim day As Integer = DateDiff(DateInterval.Day, DOBBB, Now) Mod 30 - 10

        Age = dhAge(DOBBB, Now)

        Dim sex As String = ""
        If (maleRadio.Checked = True) Then
            sex = maleRadio.Text
        ElseIf (femaleRadio.Checked = True)
            sex = femaleRadio.Text
        Else

        End If
        If (firstNameField.Text = "" Or surnameField.Text = "" Or parentCombo.SelectedIndex.ToString = "") Then
            MsgBox("Check inputted data for correctness!", MsgBoxStyle.Exclamation)
        Else
            If (Age >= 18) Then
                MsgBox("Age exceeds 18 years", MsgBoxStyle.Exclamation)
            Else
                Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
                Dim pid As String() = parentCombo.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)

                Dim idFinal As String = pid(0)

                Home_DiffUI.getData("UPDATE `ward` SET `first_name` = '" & firstNameField.Text & "', `last_name` = '" & surnameField.Text & "', `date_of_birth` = '" & dobB & "', `sex` = '" & sex & "',`Age` = '" & Age & "', `email` = '" & emailField.Text & "' WHERE `ward`.`ward_ID` LIKE '" & wardCombo.SelectedItem & "' ")

                If (MsgBox("Success! Modify another Ward record?", MsgBoxStyle.YesNo)) = DialogResult.No Then
                    Me.Close()
                Else
                    Me.Controls.Clear()
                    InitializeComponent()
                    ModWard_Load(e, e)
                End If
                Home_DiffUI.WardRadio_CheckedChanged(e, e)

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
End Class