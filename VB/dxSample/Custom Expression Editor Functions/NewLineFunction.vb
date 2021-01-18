Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Data.Filtering

Namespace dxSample
    Public Class NewLineConstant
        Implements ICustomFunctionOperatorBrowsable

        Public ReadOnly Property Category() As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.Text
            End Get
        End Property
        Public ReadOnly Property Description() As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "NewLineConstant()" & ControlChars.CrLf & "Inserts a new line."
            End Get
        End Property
        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 0
        End Function
        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return True
        End Function
        Public ReadOnly Property MaxOperandCount() As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return 0
            End Get
        End Property
        Public ReadOnly Property MinOperandCount() As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return -1
            End Get
        End Property
        Public Function Evaluate(ByVal ParamArray operands() As Object) As Object Implements ICustomFunctionOperatorBrowsable.Evaluate
            Return Environment.NewLine
        End Function
        Public ReadOnly Property Name() As String Implements ICustomFunctionOperatorBrowsable.Name
            Get
                Return "NewLineConstant"
            End Get
        End Property
        Public Function ResultType(ByVal ParamArray operands() As Type) As Type Implements ICustomFunctionOperatorBrowsable.ResultType
            Return GetType(String)
        End Function
    End Class

End Namespace
