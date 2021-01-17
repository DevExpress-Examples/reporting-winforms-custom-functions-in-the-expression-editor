Imports DevExpress.Data.Filtering
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace dxSample
	Public Class CustomFormatFunction
		Implements ICustomFunctionOperatorBrowsable

		Public ReadOnly Property Category() As FunctionCategory
			Get
				Return FunctionCategory.Text
			End Get
		End Property
		Public ReadOnly Property Description() As String
			Get
				Return "CustomFormatFunction(string format, object arg0)" & vbCrLf & "Converts an arg0 value to a string based on a specified format"
			End Get
		End Property
		Public Function IsValidOperandCount(ByVal count As Integer) As Boolean
			Return count = 2
		End Function
		Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean
			Return True
		End Function
		Public ReadOnly Property MaxOperandCount() As Integer
			Get
				Return 2
			End Get
		End Property
		Public ReadOnly Property MinOperandCount() As Integer
			Get
				Return 2
			End Get
		End Property
		Public Function Evaluate(ParamArray ByVal operands() As Object) As Object
			Dim res As String = String.Format(operands(0).ToString(), operands(1))
			Return res
		End Function
		Public ReadOnly Property Name() As String
			Get
				Return "CustomFormatFunction"
			End Get
		End Property
		Public Function ResultType(ParamArray ByVal operands() As Type) As Type
			Return GetType(String)
		End Function
	End Class
End Namespace
