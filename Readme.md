<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598133/21.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T211298)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-custom-functions-in-the-expression-editor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-custom-functions-in-the-expression-editor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
