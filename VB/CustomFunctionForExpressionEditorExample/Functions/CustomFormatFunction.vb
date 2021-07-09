#Region "#usings"
Imports DevExpress.XtraReports.Expressions
Imports System
#End Region

Namespace CustomFunctionForExpressionEditorExample
	#Region "#CustomFormatFunction"
	Public Class CustomFormatFunction
		Inherits ReportCustomFunctionOperatorBase

		Public Overrides ReadOnly Property FunctionCategory() As String
			Get
				Return "String"
			End Get
		End Property
		Public Overrides ReadOnly Property Description() As String
			Get
				Return "CustomFormatFunction(string format, object arg0)" _
				& ControlChars.CrLf & "Converts an arg0 value to a string based on a specified format"
			End Get
		End Property
		Public Overrides Function IsValidOperandCount(ByVal count As Integer) As Boolean
			Return count = 2
		End Function
		Public Overrides Function IsValidOperandType(ByVal operandIndex As Integer,
			ByVal operandCount As Integer, ByVal type As Type) As Boolean
			Return True
		End Function
		Public Overrides ReadOnly Property MaxOperandCount() As Integer
			Get
				Return 2
			End Get
		End Property
		Public Overrides ReadOnly Property MinOperandCount() As Integer
			Get
				Return 2
			End Get
		End Property
		Public Overrides Function Evaluate(ParamArray ByVal operands() As Object) As Object
			Dim res As String = String.Format(operands(0).ToString(), operands(1))
			Return res
		End Function
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "CustomFormatFunction"
			End Get
		End Property
		Public Overrides Function ResultType(ParamArray ByVal operands() As Type) As Type
			Return GetType(String)
		End Function
	End Class
	#End Region
End Namespace
