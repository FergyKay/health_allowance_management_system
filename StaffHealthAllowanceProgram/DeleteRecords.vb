Imports MySql.Data.MySqlClient
Public Class DeleteRecords
    Private adapter As MySqlDataAdapter
    Private SQLDataset As DataSet
    Private Sub DeleteRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLCommand = "select `staff_ID`, `last_name` FROM `staff`"
        Dim adapter As New MySqlDataAdapter(SQLCommand, SQLConnection)
        Dim SQLDataset As New DataSet
        idToBeDeleted.Items.Clear()
        adapter.Fill(SQLDataset)

        For i = 0 To SQLDataset.Tables(0).Rows.Count - 1
            idToBeDeleted.Items.Add((SQLDataset.Tables(0).Rows(i)).Item(0) & ", " & (SQLDataset.Tables(0).Rows(i)).Item(1))
        Next
        idToBeDeleted.SelectedIndex = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Delete_Click_1(sender As Object, e As EventArgs) Handles Delete.Click
        Dim separators() As String = {",", ".", "!", "?", ";", ":", " "}
        Dim pid As String() = idToBeDeleted.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
        Dim idFinal As String = pid(0)
        If (MsgBox("Deleting this record will remove all information such as beneficiary data and spouse data! Still want to delete record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Home_DiffUI.getData("Delete staff, spouse From `staff` INNER Join spouse ON `staff_ID` = `partner_ID` WHERE `staff_ID` ='" & idFinal & "'")
            Home_DiffUI.getData("Delete ward From ward Where `parent_ID` Like '" & idFinal & "'")
            MsgBox("Success", MsgBoxStyle.OkOnly)
            Me.Controls.Clear()
            InitializeComponent()
            DeleteRecords_Load(e, e)
        End If
    End Sub
End Class