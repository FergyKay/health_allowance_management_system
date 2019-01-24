Imports MySql.Data.MySqlClient

Module AuthLogin
    Public cmd As MySqlCommand
    Dim Username As String
    Dim Password As String

    Public Sub verifyLogin(ByVal Username, ByVal Password, ByVal Table)
        Dim finPass As String = "null"
        Try
            cmd = New MySqlCommand("Select `password` from `" & Table & "` WHERE `username` LIKE '" & Username & "'", SQLConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                finPass = reader(0)
            End While
            reader.Close()
            Home_DiffUI.Dispose()

            If (finPass = Password) Then
                LoginPage.Hide()
                Home_DiffUI.Show()
            Else
                MsgBox("Incorrect Details", MsgBoxStyle.Exclamation)
                LoginPage.Controls.Clear()
                LoginPage.InitializeComponent()
                LoginPage.RadioButton1.Checked = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




    End Sub



End Module
