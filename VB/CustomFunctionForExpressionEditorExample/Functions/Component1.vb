Imports CustomFunctionForExpressionEditorExample

Public Class Component1
    Inherits System.ComponentModel.Component
    Public Sub New()
        DevExpress.XtraReports.Expressions.CustomFunctions.Register(New NewLineConstant())
        DevExpress.XtraReports.Expressions.CustomFunctions.Register(New CustomFormatFunction())
    End Sub
End Class
