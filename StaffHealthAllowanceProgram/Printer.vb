Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Printer
    Public SQLCommand As String
    Public Source As String
    Public name As String
    Private Sub Printer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = name
        Try
            Dim SQLDataset As New DataSet
            Dim SQLDA As New MySqlDataAdapter(SQLCommand, SQLConnection)
            SQLDA.Fill(SQLDataset)
            Dim reportName As String = Source & "SummaryReport"
            Dim reportPath As String = Application.StartupPath & "\" & reportName & ".rpt"

            If Not IO.File.Exists(reportPath) Then
                Throw (New Exception("Unable To locate report file" & vbCrLf & reportPath))
                Exit Sub
            End If
            Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrystalReportViewer1.ResetText()
            rptdocument.Load(reportPath)
            rptdocument.SetDataSource(SQLDataset.Tables(0))
            ' rptdocument.SetDatabaseLogon("root", "")
            CrystalReportViewer1.ReportSource = rptdocument
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class