using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
        }
        string reportDefinitionFilePath = "..\\..\\Reports\\XtraReport1.repx";
        private void Form1_Load(object sender, EventArgs e) {
            reportDesigner1.OpenReport(reportDefinitionFilePath);
        }
    }
}
