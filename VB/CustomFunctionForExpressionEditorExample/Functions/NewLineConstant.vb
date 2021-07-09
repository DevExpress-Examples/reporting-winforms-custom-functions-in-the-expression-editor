#Region "#usings"
Imports DevExpress.XtraReports.Expressions
Imports System
#End Region
Namespace CustomFunctionForExpressionEditorExample
	#Region "#NewLineConstant"
	Public Class NewLineConstant
		Inherits ReportCustomFunctionOperatorBase

		Public Overrides ReadOnly Property FunctionCategory() As String
			Get
				Return "String"
			End Get
		End Property
		Public Overrides ReadOnly Property Description() As String
			Get
				Return "NewLineConstant()" & ControlChars.CrLf & "Inserts a new line."
			End Get
		End Property
		Public Overrides Function IsValidOperandCount(ByVal count As Integer) As Boolean
			Return count = 0
		End Function
		Public Overrides Function IsValidOperandType(ByVal operandIndex As Integer,
													 ByVal operandCount As Integer,
													 ByVal type As Type) As Boolean
			Return True
		End Function
		Public Overrides ReadOnly Property MaxOperandCount() As Integer
			Get
				Return 0
			End Get
		End Property
		Public Overrides ReadOnly Property MinOperandCount() As Integer
			Get
				Return -1
			End Get
		End Property
		Public Overrides Function Evaluate(ParamArray ByVal operands() As Object) As Object
			Return Environment.NewLine
		End Function
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "NewLineConstant"
			End Get
		End Property
		Public Overrides Function ResultType(ParamArray ByVal operands() As Type) As Type
			Return GetType(String)
		End Function
	End Class
	#End Region
End Namespace
