Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Data.Filtering

Namespace dxSample
	Public Class NewLineConstant
		Implements ICustomFunctionOperatorBrowsable

		Public ReadOnly Property Category() As FunctionCategory
			Get
				Return FunctionCategory.Text
			End Get
		End Property
		Public ReadOnly Property Description() As String
			Get
				Return "NewLineConstant()" & vbCrLf & "Inserts a new line."
			End Get
		End Property
		Public Function IsValidOperandCount(ByVal count As Integer) As Boolean
			Return count = 0
		End Function
		Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean
			Return True
		End Function
		Public ReadOnly Property MaxOperandCount() As Integer
			Get
				Return 0
			End Get
		End Property
		Public ReadOnly Property MinOperandCount() As Integer
			Get
				Return -1
			End Get
		End Property
		Public Function Evaluate(ParamArray ByVal operands() As Object) As Object
			Return Environment.NewLine
		End Function
		Public ReadOnly Property Name() As String
			Get
				Return "NewLineConstant"
			End Get
		End Property
		Public Function ResultType(ParamArray ByVal operands() As Type) As Type
			Return GetType(String)
		End Function
	End Class

End Namespace
