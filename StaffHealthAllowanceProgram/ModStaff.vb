Imports MySql.Data.MySqlClient
Public Class ModStaff
    Dim reader As MySqlDataReader
    Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
    Dim SQLDataset As New DataSet


    Private Sub ModStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLCommand = "select `staff_ID` FROM `staff` ORDER BY `staff_ID` ASC"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        staffID.Items.Clear()
        adapter.Fill(SQLDataset)
        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            staffID.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0))
        Next
    End Sub

    Private Sub staffID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles staffID.SelectedIndexChanged
        cmd = New MySqlCommand("select * FROM `staff` WHERE `staff_id` LIKE '" & staffID.SelectedItem & "'", SQLConnection)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read
            surnameField.Text = reader(1).ToString
            firstNameField.Text = reader(2).ToString
            If (reader(3).ToString = "none") Then
            Else
                dob.Value = reader(3).ToString
            End If

            If (reader(5).ToString = "Male") Then
                maleRadio.Checked = True
            Else
                femaleRadio.Checked = True
            End If
            departmentCombo.SelectedIndex = reader(4) - 1
            SectorField.Text = reader(6).ToString
            PositionField.Text = reader(7).ToString
            If (reader(8).ToString = "NULL") Then
                emailField.Text = " "
            Else
                emailField.Text = reader(8).ToString
            End If
        End While
        reader.Close()
    End Sub

    Private Sub AddStaffButton_Click(sender As Object, e As EventArgs) Handles AddStaffButton.Click
        Dim dobB As String = dob.Value.Year & "-" & dob.Value.Month & "-" & dob.Value.Day
        Dim sex As String = " "
        If (maleRadio.Checked = True) Then
            sex = maleRadio.Text
        ElseIf (femaleRadio.Checked = True)
            sex = femaleRadio.Text
        Else

        End If

        If (firstNameField.Text = "" Or surnameField.Text = "" Or SectorField.Text = "" Or PositionField.Text = "") Then
            MsgBox("All Fields Required", MsgBoxStyle.Exclamation)
        Else
            Try
                Home_DiffUI.getData("Update `staff` Set `first_name` = '" & firstNameField.Text & "', `last_name` = '" & surnameField.Text & "', `date_of_birth` = '" & dobB & "', `department_ID` = '" & departmentCombo.SelectedIndex + 1 & "', `sex` = '" & sex & "', `sector` = '" & SectorField.SelectedItem & "', `position` = '" & PositionField.Text & "', `email` = '" & emailField.Text & "' WHERE `staff`.`staff_ID` = '" & staffID.SelectedItem & "'")
                If (MsgBox("Success! Modify another Staff entry?", MsgBoxStyle.YesNo)) = DialogResult.No Then
                    Me.Close()
                Else
                    Me.Controls.Clear()
                    InitializeComponent()
                    ModStaff_Load(e, e)
                End If
                Home_DiffUI.Panel1.Hide()
                Home_DiffUI.StaffRadio_CheckedChanged(e, e)
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class