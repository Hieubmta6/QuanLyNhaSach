using Doan.Class;
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
    public partial class Form_taikhoan : Form
    {
        Class_taikhoan tk = new Class_taikhoan();
        int flag;
        public Form_taikhoan()
        {
            InitializeComponent();
        }

        private void Form_taikhoan_Load(object sender, EventArgs e)
        {
            dtgv_tk.DataSource = tk.Loadtk();
            STT();
            btnLuu.Enabled = btnHuy.Enabled = false;

        }
        public void STT()
        {
            for (int i = 0; i < dtgv_tk.Rows.Count - 1; i++)
            {
                dtgv_tk.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag=1;
            btnSua.Enabled=btn_xoa.Enabled = false;
            grb_THONGTINTK.Enabled = true;
            btnLuu.Enabled =btnHuy.Enabled= true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (flag == 1)
                {
                    string pma = txt_matk.Text;
                    string pquyen = txt_quyen.Text;
                    string pmk = txt_mk.Text;
                    int kq = tk.sua(pma, pquyen, pmk);
                    if (kq == 1)
                    {
                        tk.Loadtk().Clear();
                        dtgv_tk.Refresh();
                        dtgv_tk.DataSource = tk.Loadtk();
                        STT();
                        MessageBox.Show("Sửa Thành công");
                        btnSua.Enabled=btnHuy.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        flag = 0;
                        MessageBox.Show(" Lưu thất bại!!!");
                    }
                }
                if (flag == 2)
                {
                    string pma = txt_matk.Text;
                    string pquyen = txt_quyen.Text;
                    string pmk = txt_mk.Text;
                    int kq = tk.xoa(pma);
                    if (kq == 1)
                    {
                        tk.Loadtk().Clear();
                        dtgv_tk.Refresh();
                        dtgv_tk.DataSource = tk.Loadtk();
                        STT();
                        MessageBox.Show("Xóa Thành công");
                        btnSua.Enabled =btnHuy.Enabled= true;
                        flag = 0;
                    }
                    else
                    {
                        flag = 0;
                        MessageBox.Show(" Lưu thất bại!!!");
                    }
                }
            //}
            //catch
            //{
            //    flag = 0;
            //    MessageBox.Show("Lỗi!!!");
            //}
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSua.Enabled = btn_xoa.Enabled = false;
            grb_THONGTINTK.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void dtgv_tk_SelectionChanged(object sender, EventArgs e)
        {
            txt_matk.Text = dtgv_tk.CurrentRow.Cells["MATK"].Value.ToString().Trim();
            txt_quyen.Text = dtgv_tk.CurrentRow.Cells["QUYEN"].Value.ToString().Trim();
            txt_tentk.Text = dtgv_tk.CurrentRow.Cells["TENTK"].Value.ToString().Trim();
            txt_mk.Text = dtgv_tk.CurrentRow.Cells["PASSWORK"].Value.ToString().Trim();
            dtp_ngaylap.Text = dtgv_tk.CurrentRow.Cells["NGAYLAP"].Value.ToString().Trim();
        }
    }
}
