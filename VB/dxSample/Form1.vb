Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraReports.UI

Namespace dxSample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private reportDefinitionFilePath As String = "..\..\Reports\XtraReport1.repx"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            reportDesigner1.OpenReport(reportDefinitionFilePath)
        End Sub
    End Class
End Namespace
