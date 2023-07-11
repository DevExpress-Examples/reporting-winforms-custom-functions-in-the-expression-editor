using DevExpress.Data.Controls.ExpressionEditor;
using DevExpress.XtraReports.UserDesigner;
using System.Linq;

namespace CustomFunctionForExpressionEditorExample
{
    class CustomReportExpressionEditorCustomizationService : ReportExpressionEditorCustomizationService
    {
        public CustomReportExpressionEditorCustomizationService() {}
        public override void BeforeRun(string expressionString, 
            IExpressionEditorView expressionEditorView, 
            ExpressionEditorContext expressionEditorContext)
        {
            FunctionInfo formatStringFunc = expressionEditorContext.Functions
                .FirstOrDefault(x => x.Name == "Abs");
            expressionEditorContext.Functions.Remove(formatStringFunc);
            base.BeforeRun(expressionString, expressionEditorView, expressionEditorContext);
        }
    }
}
