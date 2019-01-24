Imports MySql.Data.MySqlClient
Public Class AddSpouseForm
    Public PartnerIDCount As Integer


    Private Sub AddSpouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLDataset As New DataSet
        SQLCommand = "select `staff_ID`, `last_name` FROM `staff` ORDER BY `staff_ID` ASC"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)

        PartnerID.Items.Clear()
        adapter.Fill(SQLDataset)

        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            PartnerID.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0) & ", " & (SQLDataset.Tables(0).Rows(i)).Item(1))
        Next
        PartnerIDCount = SQLDataset.Tables(0).Rows.Count
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
            Home_DiffUI.getData("INSERT INTO `spouse` (`partner_ID`, `first_name`, `last_name`, `sex`,`health_allowance`, `email`) VALUES ('" & idFinal & "','" & firstNameField.Text & "', '" & surnameField.Text & "', '" & sex & "','" & (Home_DiffUI.spouse_health) & "','" & emailField.Text & "')")
            Home_DiffUI.SpouseRadio_CheckedChanged(e, e)
            If (PartnerIDCount = 0) Then
                If (MsgBox("Success! Add another record?", MsgBoxStyle.YesNo)) = DialogResult.No Then
                    Me.Close()
                Else
                    Me.Controls.Clear()
                    InitializeComponent()
                    AddSpouse_Load(e, e)
                End If
            End If

        End If
    End Sub

    Private Sub PartnerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PartnerID.SelectedIndexChanged
        Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
        Dim pid As String() = PartnerID.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
        Dim idFinal As String = pid(0)
        SQLCommand = "select * FROM `spouse` where `partner_ID` LIKE '" & idFinal & "'"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        adapter.Fill(SQLDataset)
        PartnerIDCount = SQLDataset.Tables(0).Rows.Count
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class