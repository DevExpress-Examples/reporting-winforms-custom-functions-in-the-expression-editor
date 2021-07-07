using System;

namespace CustomFunctionForExpressionEditorExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.XtraReports.Expressions.CustomFunctions.Register(new NewLineConstant());
            DevExpress.XtraReports.Expressions.CustomFunctions.Register(new CustomFormatFunction());
            reportDesigner1.OpenReport("Reports\\XtraReport1.repx");
        }
    }
}
