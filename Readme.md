<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598133/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T211298)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - How to Implement Custom Functions in the Expression Editor

This example adds custom functions to the list of functions available in the [Expression Editor](https://docs.devexpress.com/WindowsForms/6212/common-features/expressions/expression-editor)
invoked in the [WinForms End-User Report Designer](https://docs.devexpress.com/XtraReports/10715/winforms-reporting/end-user-report-designer).

![A Custom Function in Expression Editor](./Images/custom-function-in-expression-editor.png)

This example implements the following functions:

1. The **NewLineConstant** function allows you to insert a new line into a string.

    This function uses the [Environment.NewLine](https://learn.microsoft.com/en-us/dotnet/api/system.environment.newline) constant that returns a new line string defined for the current environment.
    You should enable the [XRLabel.Multiline](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRLabel.Multiline) property to enable line breaks in the XRLabel text.

1. The **CustomFormatFunction(string format, object arg0)** function accepts a format string and a value to format.

    The function's Evaluate method uses the [String.Format](https://learn.microsoft.com/en-us/dotnet/api/system.string.format) method to format a static string, data field, or a calculated field value.

Do the following to add a custom function to the End-User Report Designer's Expression Editor:

1. Implement the [ICustomFunctionOperatorBrowsable](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.ICustomFunctionOperatorBrowsable) interface to define your new custom function.
1. Call the [CustomFunctions.Register](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Expressions.CustomFunctions.Register(DevExpress.Data.Filtering.ICustomFunctionOperator--)) method to register the implemented interface in the Report Designer.

## Files to Review

* [CustomFormatFunction.cs](./CS/CustomFunctionForExpressionEditorExample/Functions/CustomFormatFunction.cs) (VB: [CustomFormatFunction.vb](./VB/CustomFunctionForExpressionEditorExample/Functions/CustomFormatFunction.vb))
* [NewLineFunction.cs](./CS/CustomFunctionForExpressionEditorExample/Functions/NewLineConstant.cs) (VB: [NewLineFunction.vb](./VB/CustomFunctionForExpressionEditorExample/Functions/NewLineConstant.vb))
* [Form1.cs](./CS/CustomFunctionForExpressionEditorExample/Form1.cs) (VB: [Form1.vb](./VB/CustomFunctionForExpressionEditorExample/Form1.vb))

## Documentation

* [Custom Functions in the Expression Editor (WinForms)](https://docs.devexpress.com/XtraReports/403294/winforms-reporting/end-user-report-designer-for-winforms/api-and-customization/custom-functions-in-the-expression-editor)
* [How to use a custom function in a query expression](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-custom-function-in-a-query-expression-t352441)
* [Custom Functions](https://docs.devexpress.com/WindowsForms/9947/common-features/expressions/implementing-custom-functions)
* [How to: Implement a Custom Criteria Language Function Operator](https://docs.devexpress.com/XPO/5206/examples/how-to-implement-a-custom-criteria-language-function-operator)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-custom-functions-in-the-expression-editor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-custom-functions-in-the-expression-editor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
