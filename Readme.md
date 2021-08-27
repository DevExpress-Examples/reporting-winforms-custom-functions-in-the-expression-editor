<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T211298)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomFormatFunction.cs](.%2FCS%2FdxSample%2FCustom%20Expression%20Editor%20Functions%2FCustomFormatFunction.cs) (VB: [CustomFormatFunction.vb](.%2FVB%2FdxSample%2FCustom%20Expression%20Editor%20Functions%2FCustomFormatFunction.vb))
* [NewLineFunction.cs](.%2FCS%2FdxSample%2FCustom%20Expression%20Editor%20Functions%2FNewLineFunction.cs) (VB: [NewLineFunction.vb](.%2FVB%2FdxSample%2FCustom%20Expression%20Editor%20Functions%2FNewLineFunction.vb))
* [Form1.cs](./CS/dxSample/Form1.cs) (VB: [Form1.vb](./VB/dxSample/Form1.vb))
* [Program.cs](./CS/dxSample/Program.cs) (VB: [Program.vb](./VB/dxSample/Program.vb))
<!-- default file list end -->
# Expression Editor - How to implement a custom New Line and Format functions

<p>This example demonstrates how to implement custom functions for the <a href="https://docs.devexpress.com/WindowsForms/6212/common-features/expressions/expression-editor">Expression Editor</a> available in the <a href="https://docs.devexpress.com/XtraReports/10715/winforms-reporting/end-user-report-designer">WinForms End-User Report Designer.</a> In this example, we implement two custom functions.<br><br>1. The new line function allows you to insert a new line at the required place in a string. This function uses the <a href="https://msdn.microsoft.com/en-us//library/system.environment.newline(v=vs.110).aspx">Environment.NewLine</a><u> </u>constant, which returns a new line string defined for the current environment. Note that to make the label recognize this string as a line break, the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRLabel.Multiline">XRLabel.Multiline</a> option must be enabled.<br><br>2. The CustomFormatFunc(string format, object arg0) accepts a format string and a value that should be formatted. In this function's Evaluate method, we're using the <a href="https://msdn.microsoft.com/en-us/library/fht0f5be(v=vs.110).aspx">String.Format Method (String, Object)</a> method. By using this function, you can format a static string and/or a field / calculated field value.<br><br>See also:<br><strong><a href="https://www.devexpress.com/Support/Center/p/T352441">How to use a custom function in a query expression</a></strong><br><a href="https://docs.devexpress.com/WindowsForms/9947/common-features/expressions/implementing-custom-functions7">Custom Functions</a><br><a href="https://docs.devexpress.com/XPO/5206/examples/how-to-implement-a-custom-criteria-language-function-operator">How to: Implement a Custom Criteria Language Operator</a>
