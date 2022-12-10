using DevExpress.XtraReports.Expressions;
using System;
namespace CustomFunctionForExpressionEditorExample
{
    public class NewLineConstant : ReportCustomFunctionOperatorBase
    {
        public override string FunctionCategory 
			=> "String";
        public override string Description 
			=> "NewLineConstant()\r\nInserts a new line.";
        public override bool IsValidOperandCount(int count) 
			=> count == 0;
        public override bool IsValidOperandType(int operandIndex, int operandCount, Type type)
            => true;
        public override int MaxOperandCount => 0;
        public override int MinOperandCount
			=> -1;
        public override object Evaluate(params object[] operands)
        {
            return Environment.NewLine;
        }
        public override string Name
			=> "NewLineConstant";
        public override Type ResultType(params Type[] operands)
        {
            return typeof(string);
        }
    }
}
