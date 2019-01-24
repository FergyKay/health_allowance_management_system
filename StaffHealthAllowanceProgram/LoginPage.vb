Public Class LoginPage
    Private Sub PassWord_Click(sender As Object, e As EventArgs) Handles PassWord.Click
        PassWord.Clear()
        PassWord.UseSystemPasswordChar = True
    End Sub



    Private Sub Username_Click(sender As Object, e As EventArgs) Handles Username.Click
        Username.Clear()
    End Sub

    Public Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home_DiffUI.Close()
        RadioButton1.Checked = True
        'MetroProgressSpinner1.Spinning = False
        'MetroProgressSpinner1.Visible = False
        connectToDatabase()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'MetroProgressSpinner1.Visible = True
        'While (MetroProgressSpinner1.Value < MetroProgressSpinner1.Maximum)
        '    MetroProgressSpinner1.Value += 1
        'End While
        verifyLogin(Username.Text, SHA1Hash(PassWord.Text), GetGroupBoxCheckedButton(FlowLayoutPanel1))
    End Sub

    Public Function GetGroupBoxCheckedButton(RadioPanel As FlowLayoutPanel) As String
        For Each ctrl As RadioButton In RadioPanel.Controls
            If ctrl.Checked Then
                Return ctrl.Text
            End If
        Next
    End Function

    Private Function SHA1Hash(ByVal rawPword) As String
        Dim sha1 As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(rawPword)
        bytesToHash = sha1.ComputeHash(bytesToHash)

        Dim hashedPword As String = ""
        For Each b As Byte In bytesToHash
            hashedPword += b.ToString("x2")
        Next
        Return hashedPword

    End Function

    Private Sub PassWord_GotFocus(sender As Object, e As EventArgs) Handles PassWord.GotFocus
        PassWord.Clear()
        PassWord.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        disConnectFromDatabase()
        Me.Close()
    End Sub
End Class
