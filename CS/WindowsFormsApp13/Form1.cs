using DevExpress.XtraEditors;
using System;

namespace WindowsFormsApp13 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.reportDesigner1.OpenReport("CityOrders.repx");
        }
    }
}
