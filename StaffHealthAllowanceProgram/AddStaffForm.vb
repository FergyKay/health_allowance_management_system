Imports MySql.Data.MySqlClient
Public Class AddStaffForm
    Private Sub AddStaffButton_Click(sender As Object, e As EventArgs) Handles AddStaffButton.Click
        Home_DiffUI.refreshSettings()
        Dim dobB As String = dob.Value.Year & "-" & dob.Value.Month & "-" & dob.Value.Day
        Dim sex As String = " "
        If (maleRadio.Checked = True) Then
            sex = maleRadio.Text
        ElseIf (femaleRadio.Checked = True)
            sex = femaleRadio.Text
        Else

        End If

        If (firstNameField.Text = "" Or surnameField.Text = "" Or Staff_ID.Text = "" Or SectorField.Text = "" Or PositionField.Text = "") Then
            MsgBox("All Fields Required", MsgBoxStyle.Exclamation)
        Else
            Try
                Home_DiffUI.getData("INSERT INTO `staff` (`staff_ID`,`first_name`, `last_name`, `date_of_birth`, `department_ID`, `sex`, `sector`, `position`, `email`, `health_allowance`, `dental_allowance`, `optical_allowance`) VALUES ('" & Staff_ID.Text & "','" & firstNameField.Text & "', '" & surnameField.Text & "', '" & dobB & "'," & departmentCombo.SelectedIndex + 1 & ",'" & sex & "', '" & SectorField.SelectedItem & "','" & PositionField.Text & "','" & emailField.Text & "','" & (Home_DiffUI.staff_health) & "', '" & (Home_DiffUI.staff_dental) & "','" & (Home_DiffUI.staff_optical) & "')")
                If (MsgBox("Success! Add another record?", MsgBoxStyle.YesNo)) = DialogResult.No Then
                    Me.Close()

                Else
                    Me.Controls.Clear()
                    InitializeComponent()
                    AddStaffForm_Load(e, e)
                End If
                Home_DiffUI.Panel1.Hide()
                Home_DiffUI.StaffRadio_CheckedChanged(e, e)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub AddStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maleRadio.Checked = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class