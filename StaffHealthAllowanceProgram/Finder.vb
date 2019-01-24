Public Class FInd
    Public findCommand As String
    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        findCommand = "SELECT * FROM `" & Home_DiffUI.GetGroupBoxCheckedButton(Home_DiffUI.RadioPanel) & "` WHERE `last_name` LIKE '%" & searchText.Text & "%'"
        Home_DiffUI.getData(findCommand)
    End Sub
End Class