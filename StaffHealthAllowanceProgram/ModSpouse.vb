Imports MySql.Data.MySqlClient
Public Class ModSpouse
    Private Sub ModSpouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLDataset As New DataSet
        SQLCommand = "select `staff_ID`, `last_name` FROM `staff` ORDER BY `staff_ID` ASC"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)

        PartnerID.Items.Clear()
        adapter.Fill(SQLDataset)

        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            PartnerID.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0) & ", " & (SQLDataset.Tables(0).Rows(i)).Item(1))
        Next
    End Sub

    Private Sub PartnerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PartnerID.SelectedIndexChanged
        firstNameField.Clear()
        surnameField.Clear()
        emailField.Clear()
        maleRadio.Checked = False
        femaleRadio.Checked = False
        Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
        Dim pid As String() = PartnerID.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
        Dim idFinal As String = pid(0)
        cmd = New MySqlCommand("select * FROM `spouse` WHERE `partner_id` LIKE '" & idFinal & "'", SQLConnection)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read
            surnameField.Text = reader(3).ToString
            firstNameField.Text = reader(2).ToString
            If (reader(4).ToString = "Male") Then
                maleRadio.Checked = True
            Else
                femaleRadio.Checked = True
            End If
            If (reader(6).ToString = "NULL") Then
                emailField.Text = " "
            Else
                emailField.Text = reader(6).ToString
            End If
        End While
        reader.Close()
    End Sub

    Private Sub AddSpouseButton_Click(sender As Object, e As EventArgs) Handles AddSpouseButton.Click
        Dim sex As String = ""
        If (maleRadio.Checked = True) Then
            sex = maleRadio.Text
        ElseIf (femaleRadio.Checked = True)
            sex = femaleRadio.Text
        Else

        End If
        If (firstNameField.Text = "" Or surnameField.Text = "" Or PartnerID.SelectedIndex.ToString = "") Then
            MsgBox("All Fields Required", MsgBoxStyle.Exclamation)
        Else
            Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
            Dim pid As String() = PartnerID.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            Dim idFinal As String = pid(0)
            Home_DiffUI.refreshSettings()
            Home_DiffUI.getData("UPDATE `spouse` SET `first_name` = '" & firstNameField.Text & "', `last_name` = '" & surnameField.Text & "', `sex` = '" & sex & "' WHERE `spouse`.`Partner_ID` LIKE '" & idFinal & "'")
            Home_DiffUI.SpouseRadio_CheckedChanged(e, e)

            If (MsgBox("Success! Modify another Spouse record?", MsgBoxStyle.YesNo)) = DialogResult.No Then
                Me.Close()
            Else
                Me.Controls.Clear()
                    InitializeComponent()
                ModSpouse_Load(e, e)
            End If
            End If

    End Sub
End Class