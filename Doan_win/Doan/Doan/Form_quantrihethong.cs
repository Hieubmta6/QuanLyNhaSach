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
    public partial class Form_quantrihethong : Form
    {
        public Form_quantrihethong()
        {
            InitializeComponent();
        }
        private void ptb_qlnv_Click(object sender, EventArgs e)
        {
            Form_nhanvien nhanvien = new Form_nhanvien();
            nhanvien.ShowDialog();         
        }

        private void ptb_qlsach_Click(object sender, EventArgs e)
        {
            Form_quanlysach sach = new Form_quanlysach();
            sach.ShowDialog();
        }

        private void ptb_qltg_Click(object sender, EventArgs e)
        {
            Form_Tacgia tacgia = new Form_Tacgia();
            tacgia.ShowDialog();
        }

        private void ptb_qlnxb_Click(object sender, EventArgs e)
        {
            Form_nhaxuatban nhaxuatban = new Form_nhaxuatban();
            nhaxuatban.ShowDialog();
        }

        private void ptb_qlkho_Click(object sender, EventArgs e)
        {
            Form_Kho2 kho = new Form_Kho2();
            kho.Show();
        }
        private void ptb_qlpq_Click(object sender, EventArgs e)
        {
            Form_Loaisach loaisach = new Form_Loaisach();
            loaisach.ShowDialog();
        }

        private void ptb_qltk_Click(object sender, EventArgs e)
        {
            Form_taikhoan taikhoan = new Form_taikhoan();
            taikhoan.ShowDialog();
        }

        private void ptb_qlkh_Click(object sender, EventArgs e)
        {
            frm_KH kh = new frm_KH();
            kh.Show();
            //kh.ShowDialog();
        }

       

    }
}
