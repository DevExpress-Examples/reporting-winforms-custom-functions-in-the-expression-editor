using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dxSample {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }
        string reportDefinitionFilePath = "..\\..\\Reports\\XtraReport1.repx";
        private void Form2_Load(object sender, EventArgs e) {
            reportDesigner1.OpenReport(reportDefinitionFilePath);
        }
    }
}
