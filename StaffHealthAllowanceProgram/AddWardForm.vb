Imports MySql.Data.MySqlClient
Public Class AddWardForm
    Private parentIDCount As Integer
    Private adapter As MySqlDataAdapter
    Private SQLDataset As DataSet
    Private Sub AddWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLCommand = "select `staff_ID`, `last_name` FROM `staff` ORDER BY `staff_ID` ASC"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        parentCombo.Items.Clear()
        adapter.Fill(SQLDataset)

        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            parentCombo.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0) & ", " & (SQLDataset.Tables(0).Rows(i)).Item(1))
        Next
    End Sub

    Private Sub AddWardButton_Click(sender As Object, e As EventArgs) Handles AddWardButton.Click
        Dim Age As Integer
        Dim dobB As String = dob.Value.Year & "-" & dob.Value.Month & "-" & dob.Value.Day
        Dim DOBBB As New DateTime(dob.Value.Year.ToString, dob.Value.Month.ToString, dob.Value.Day.ToString)

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
                Home_DiffUI.refreshSettings()
                Dim idFinal As String = pid(0)
                If (parentIDCount < 3) Then
                    Home_DiffUI.getData("INSERT INTO `ward` (`parent_ID`, `first_name`, `last_name`, `date_of_birth`,`age`,`sex`, `email`,`health_allowance`) VALUES ('" & idFinal & "','" & firstNameField.Text & "', '" & surnameField.Text & "','" & dobB & "','" & Age & "', '" & sex & "','" & emailField.Text & "','" & (Home_DiffUI.ward_health) & "')")
                    If (MsgBox("Success! Add another record?", MsgBoxStyle.YesNo)) = DialogResult.No Then
                        Me.Close()
                    Else
                        Me.Controls.Clear()
                        InitializeComponent()
                        AddWardForm_Load(e, e)
                    End If
                    Home_DiffUI.WardRadio_CheckedChanged(e, e)
                Else
                    MsgBox("Maximum Number of Wards Exceeded", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub parentCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles parentCombo.SelectedIndexChanged
        Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
        Dim pid As String() = parentCombo.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
        Dim idFinal As String = pid(0)
        SQLCommand = "select * FROM `ward` where `parent_ID` LIKE '" & idFinal & "'"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        adapter.Fill(SQLDataset)
        parentIDCount = SQLDataset.Tables(0).Rows.Count
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class