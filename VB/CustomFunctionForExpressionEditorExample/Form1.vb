Imports System

Namespace CustomFunctionForExpressionEditorExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub
		#Region "#formload"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			DevExpress.XtraReports.Expressions.CustomFunctions.Register(New NewLineConstant())
			DevExpress.XtraReports.Expressions.CustomFunctions.Register(New CustomFormatFunction())
			reportDesigner1.OpenReport("Reports\XtraReport1.repx")
		End Sub
		#End Region
	End Class
End Namespace
