<!-- default file list -->
*Files to look at*:

* [CustomFormatFunction.cs](./CS/dxSample/Custom Expression Editor Functions/CustomFormatFunction.cs) (VB: [CustomFormatFunction.vb](./VB/dxSample/Custom Expression Editor Functions/CustomFormatFunction.vb))
* [NewLineFunction.cs](./CS/dxSample/Custom Expression Editor Functions/NewLineFunction.cs) (VB: [NewLineFunction.vb](./VB/dxSample/Custom Expression Editor Functions/NewLineFunction.vb))
* [Form1.cs](./CS/dxSample/Form1.cs) (VB: [Form1.vb](./VB/dxSample/Form1.vb))
* [Program.cs](./CS/dxSample/Program.cs) (VB: [Program.vb](./VB/dxSample/Program.vb))
<!-- default file list end -->
# Expression Editor - How to implement a custom New Line and Format functions


<p>This example demonstrates how to implement custom functions for the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument6212">Expression Editor</a> available in the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument10715">WinForms End-User Report Designer.</a> In this example, we implement two custom functions. <br><br>1. The new line function allows you to insert a new line at the required place in a string. This function uses the <a href="https://msdn.microsoft.com/en-us//library/system.environment.newline(v=vs.110).aspx">Environment.NewLine</a><u> </u>constant, which returns a new line string defined for the current environment. Note that to make the label recognize this string as a line break, the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRLabel_Multilinetopic">XRLabel.Multiline</a> option must be enabled. <br><br>2. The CustomFormatFunc(string format, object arg0) accepts a format string and a value that should be formatted. In this function's Evaluate method, we're using the <a href="https://msdn.microsoft.com/en-us/library/fht0f5be(v=vs.110).aspx">String.Format Method (String, Object)</a> method. By using this function, you can format a static string and/or a field / calculated field value. <br><br>See also:<br><strong><a href="https://www.devexpress.com/Support/Center/p/T352441">How to use a custom function in a query expression</a></strong><br><br><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument9947">Implementing Custom Functions</a> <br><a href="https://documentation.devexpress.com/#CoreLibraries/CustomDocument5206">How to: Implement a Custom Criteria Language Operator</a> <br><a href="https://msdn.microsoft.com/en-us/library/system.string.format(v=vs.110).aspx">String.Format Method</a></p>

<br/>


