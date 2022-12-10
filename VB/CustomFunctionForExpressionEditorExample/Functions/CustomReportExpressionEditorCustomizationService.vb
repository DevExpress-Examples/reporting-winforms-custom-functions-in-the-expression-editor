Imports DevExpress.Data.Controls.ExpressionEditor
Imports DevExpress.XtraReports.UserDesigner

Public Class CustomReportExpressionEditorCustomizationService
	Inherits ReportExpressionEditorCustomizationService

	Public Sub New()
	End Sub
	Public Overrides Sub BeforeRun(ByVal expressionString As String,
								   ByVal expressionEditorView As IExpressionEditorView,
								   ByVal expressionEditorContext As ExpressionEditorContext)
		Dim formatStringFunc As FunctionInfo =
			expressionEditorContext.Functions.FirstOrDefault(Function(x) x.Name = "Abs")
		expressionEditorContext.Functions.Remove(formatStringFunc)
		MyBase.BeforeRun(expressionString, expressionEditorView, expressionEditorContext)
	End Sub
End Class
