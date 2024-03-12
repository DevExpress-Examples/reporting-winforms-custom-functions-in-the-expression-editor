<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598133/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T211298)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Custom Functions in the Expression Editor

This example demonstrates how to implement custom functions for the [Expression Editor](https://docs.devexpress.com/WindowsForms/6212/common-features/expressions/expression-editor)
available in the [WinForms End-User Report Designer](https://docs.devexpress.com/XtraReports/10715/winforms-reporting/end-user-report-designer).

![A Custom Function in Expression Editor](./Images/custom-function-in-expression-editor.png)

This example implements the following custom functions:

1. The **NewLineConstant** function allows you to insert a new line into a string.

    This function uses the [Environment.NewLine](https://msdn.microsoft.com/en-us//library/system.environment.newline(v=vs.110).aspx) constant that returns a new line string defined for the current environment.
    To make the label recognize this string as a line break, the [XRLabel.Multiline](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRLabel.Multiline) property should be enabled.

1. The **CustomFormatFunction(string format, object arg0)** function accepts a format string and a value to format.

    In this function's Evaluate method, we use the [String.Format](https://msdn.microsoft.com/en-us/library/fht0f5be(v=vs.110).aspx) method.
    Use this function to format a static string, data field, or calculated field value.

Do the following to add a custom function to the End-User Report Designer's Expression Editor:

1. Implement the [ICustomFunctionOperatorBrowsable](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.ICustomFunctionOperatorBrowsable) interface to define your new custom function.
1. Call the [CustomFunctions.Register](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Expressions.CustomFunctions.Register(DevExpress.Data.Filtering.ICustomFunctionOperator--)) method to register the implemented interface in the Report Designer.

<!-- default file list -->
## Files to Look At

* [CustomFormatFunction.cs](./CS/CustomFunctionForExpressionEditorExample/Functions/CustomFormatFunction.cs) (VB: [CustomFormatFunction.vb](./VB/CustomFunctionForExpressionEditorExample/Functions/CustomFormatFunction.vb))
* [NewLineFunction.cs](./CS/CustomFunctionForExpressionEditorExample/Functions/NewLineConstant.cs) (VB: [NewLineFunction.vb](./VB/CustomFunctionForExpressionEditorExample/Functions/NewLineConstant.vb))
* [Program.cs](./CS/CustomFunctionForExpressionEditorExample/Program.cs) (VB: [Program.vb](./VB/CustomFunctionForExpressionEditorExample/Program.vb))
<!-- default file list end -->

## Documentation

* [Custom Functions in the Expression Editor (WinForms)](https://docs.devexpress.com/XtraReports/403294/winforms-reporting/end-user-report-designer-for-winforms/api-and-customization/custom-functions-in-the-expression-editor)
* [How to use a custom function in a query expression](https://supportcenter.devexpress.com/ticket/details/t352441/how-to-use-a-custom-function-in-a-query-expression)
* [Custom Functions](https://docs.devexpress.com/WindowsForms/9947/common-features/expressions/implementing-custom-functions)
* [How to: Implement a Custom Criteria Language Function Operator](https://docs.devexpress.com/XPO/5206/examples/how-to-implement-a-custom-criteria-language-function-operator)
