Imports DevExpress.Data.Filtering
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace dxSample
    Public Class CustomFormatFunction
        Implements ICustomFunctionOperatorBrowsable

        Public ReadOnly Property Category() As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.Text
            End Get
        End Property
        Public ReadOnly Property Description() As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "CustomFormatFunction(string format, object arg0)" & ControlChars.CrLf & "Converts an arg0 value to a string based on a specified format"
            End Get
        End Property
        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 2
        End Function
        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return True
        End Function
        Public ReadOnly Property MaxOperandCount() As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return 2
            End Get
        End Property
        Public ReadOnly Property MinOperandCount() As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return 2
            End Get
        End Property
        Public Function Evaluate(ByVal ParamArray operands() As Object) As Object Implements ICustomFunctionOperatorBrowsable.Evaluate
            Dim res As String = String.Format(operands(0).ToString(), operands(1))
            Return res
        End Function
        Public ReadOnly Property Name() As String Implements ICustomFunctionOperatorBrowsable.Name
            Get
                Return "CustomFormatFunction"
            End Get
        End Property
        Public Function ResultType(ByVal ParamArray operands() As Type) As Type Implements ICustomFunctionOperatorBrowsable.ResultType
            Return GetType(String)
        End Function
    End Class
End Namespace
