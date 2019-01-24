Imports MySql.Data.MySqlClient
Imports MySql.Data

Module Module1
    Public SQLConnection As New MySqlConnection
    Public SQLCommand As String
    Public query As String

    Public Sub connectToDatabase()
        Try
            If SQLConnection.State = ConnectionState.Open Then
                SQLConnection.Close()
            End If

            SQLConnection.ConnectionString = "Data Source=localhost;Port=3307;Database=staff_health_allowance;Uid=root;Pwd="
            SQLConnection.Open()

            If SQLConnection.State = ConnectionState.Open Then
            End If

        Catch ex As Exception
            MsgBox("Server not available!", MsgBoxStyle.Exclamation)
            Application.Exit()
        End Try
    End Sub

    Public Sub disConnectFromDatabase()
        SQLConnection.Close()
        'MsgBox("Disconnected")
    End Sub
End Module
