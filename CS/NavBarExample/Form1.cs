using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavBarExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            myNavBarControl1.Resize += new EventHandler(myNavBarControl1_Resize);
        }

        void Form1_Load(object sender, EventArgs e) {
            myNavBarControl1.AddBar(new DevExpress.XtraNavBar.NavBarControl());
            myNavBarControl1.AddBar(new DevExpress.XtraNavBar.NavBarControl());
            myNavBarControl1.AddGroup(0, "Sales");
            myNavBarControl1.AddGroup(0, "System");
            myNavBarControl1.AddGroup(1, "Production");
            myNavBarControl1.AddGroup(1, "System Root");
            myNavBarControl1.ArrGroupItem(0, "Sales", "Materials");
            myNavBarControl1.ArrGroupItem(0, "Sales", "Operations");
            myNavBarControl1.ArrGroupItem(0, "Sales", "VAT Setup");
            myNavBarControl1.ArrGroupItem(0, "System", "Auto-Numbers");
            myNavBarControl1.ArrGroupItem(1, "Production", "Shifts");
            myNavBarControl1.ArrGroupItem(1, "Production", "Capacities");
            myNavBarControl1.ArrGroupItem(1, "System Root", "Queue Viewer");
        }

        void myNavBarControl1_Resize(object sender, EventArgs e) {
            dockPanel2.Width = myNavBarControl1.Width + 8;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            myNavBarControl1.AddBar(new DevExpress.XtraNavBar.NavBarControl());
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            myNavBarControl1.DeleteBar((int)spinEdit3.Value);
        }

        private void simpleButton3_Click(object sender, EventArgs e) {
            myNavBarControl1.AddGroup((int)spinEdit1.Value, textEdit1.Text);
        }

        private void simpleButton4_Click(object sender, EventArgs e) {
            myNavBarControl1.DeleteGroup((int)spinEdit1.Value, textEdit1.Text);
        }

        private void simpleButton5_Click(object sender, EventArgs e) {
            myNavBarControl1.ArrGroupItem((int)spinEdit2.Value, textEdit2.Text, textEdit3.Text);
        }

        private void simpleButton6_Click(object sender, EventArgs e) {
            myNavBarControl1.DeleteGroupItem((int)spinEdit2.Value, textEdit2.Text, textEdit3.Text);
        }

    }
}
