using System.ComponentModel;

namespace CustomFunctionForExpressionEditorExample.Functions
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
            DevExpress.XtraReports.Expressions.CustomFunctions.Register(new NewLineConstant());
            DevExpress.XtraReports.Expressions.CustomFunctions.Register(new CustomFormatFunction());
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
