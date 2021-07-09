<!-- default file list -->
*Files to look at*:

* [CustomFormatFunction.cs](./CS/CustomFunctionForExpressionEditorExample/Functions/CustomFormatFunction.cs) (VB: [CustomFormatFunction.vb](./VB/CustomFunctionForExpressionEditorExample/Functions/CustomFormatFunction.vb))
* [NewLineConstant.cs](./CS/CustomFunctionForExpressionEditorExample/Functions/NewLineConstant.cs) (VB: [NewLineConstant.vb](./VB/CustomFunctionForExpressionEditorExample/Functions/NewLineConstant.vb))
* [Form1.cs](./CS/CustomFunctionForExpressionEditorExample/Form1.cs) (VB: [Form1.vb](./VB/CustomFunctionForExpressionEditorExample/Form1.vb))
<!-- default file list end -->
# Expression Editor - How to Implement a Custom Function

This example demonstrates how to implement custom functions for the <a href="https://docs.devexpress.com/WindowsForms/6212/common-features/expressions/expression-editor">Expression Editor</a> available in the <a href="https://docs.devexpress.com/XtraReports/10715/winforms-reporting/end-user-report-designer">WinForms End-User Report Designer.</a>

The following custom functions are implemented:
- The **NewLineConstant** function that allows you to insert a new line in a string. This function uses the <a href="https://msdn.microsoft.com/en-us//library/system.environment.newline(v=vs.110).aspx">Environment.NewLine</a><u> </u>constant, which returns a new line string defined for the current environment. You should enable the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRLabel.Multiline">XRLabel.Multiline</a> option so that the label recognizes this string as a line break.
- The **CustomFormatFunction** that formats a value with the specified format string.

This example also demonstrates how to use the **ReportExpressionEditorCustomizationService** to hide the `Abs` function in the Expression Editor in the End-User Report Designer.

For details review the following help topics:

- [CustomFunction](http://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Expressions.CustomFunction)
- [Remove a Function from the Expression Editor](http://docs.devexpress.com/XtraReports/403273)
