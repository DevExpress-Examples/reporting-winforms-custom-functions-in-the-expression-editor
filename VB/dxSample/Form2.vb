Public Class Form2
    Private reportDefinitionFilePath As String = "..\..\Reports\XtraReport1.repx"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportDesigner1.OpenReport(reportDefinitionFilePath)
    End Sub
End Class
