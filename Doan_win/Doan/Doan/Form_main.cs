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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void quảnTrịHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_quantrihethong qtri = new Form_quantrihethong();
            qtri.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangxuatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_dangnhap dn = new Form_dangnhap();
            dn.Show();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void quảnLýNghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_HD hd= new frm_HD();
            hd.Show();
        }
    }
}
