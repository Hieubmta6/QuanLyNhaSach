using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class Form_report : Form
    {
        public Form_report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_CTHD rp = new Report_CTHD();
            crystalReportViewer1.ReportSource = rp;
            rp.SetDatabaseLogon("sa", "sa2012", @"DESKTOP-MEPOI64\SQLEXPRESS", "quanlynhasach");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
           
        }
    }
}
