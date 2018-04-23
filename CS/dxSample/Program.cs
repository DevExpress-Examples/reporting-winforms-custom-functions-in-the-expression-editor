using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dxSample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(new NewLineConstant());
            DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(new CustomFormatFunction());
            Application.Run(new Form1());
        }
    }
}
