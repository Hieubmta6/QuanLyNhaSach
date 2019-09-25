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
    public partial class Form_nhaxuatban : Form
    {
        Class_NXB nxb = new Class_NXB();
        int flag;
        public Form_nhaxuatban()
        {
            InitializeComponent();
        }

        private void Form_nhaxuatban_Load(object sender, EventArgs e)
        {
            dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
            stt();
            grb_thongnxb.Enabled = false;
        }
        private void stt()
        {
            for (int i = 0; i < dtgv_nxb.Rows.Count - 1; i++)
            {
                dtgv_nxb.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grb_thongnxb.Enabled = true;
            txt_manxb.Clear();
            txt_tennxb.Clear();
            txt_dcnxb.Clear();
            txt_dtnxb.Clear();
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grb_thongnxb.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            flag = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grb_thongnxb.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            flag = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string pManxb = txt_manxb.Text;
                string pTennxb = txt_tennxb.Text;
                string pDcnxb = txt_dcnxb.Text;
                string pDtnxb = txt_dtnxb.Text;
                if (flag == 1)
                {
                    if (txt_manxb.Text.Length > 0 && txt_tennxb.Text.Length > 0 && txt_dcnxb.Text.Length > 0 && txt_dtnxb.Text.Length > 0)
                    {
                        int kq = nxb.them(pManxb, pTennxb, pDcnxb, pDtnxb);
                        if (kq == 2)
                        {
                            MessageBox.Show("Trùng khóa chính");
                        }
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            nxb.LoadNhaxuatban().Clear();
                            dtgv_nxb.Refresh();
                            dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                            stt();
                            MessageBox.Show("Thêm Thành công");
                            btnLuu.Enabled = btnHuy.Enabled = false;
                            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        }
                        else
                        {
                            nxb.LoadNhaxuatban().Clear();
                            dtgv_nxb.Refresh();
                            dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                            stt();
                            MessageBox.Show("thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("dữ liệu đầu vào chưa đủ");
                    }
                }
                if (flag == 2)
                {
                    int kq = nxb.xoa(pManxb);
                    if (kq == 1)
                    {
                        nxb.LoadNhaxuatban().Clear();
                        dtgv_nxb.Refresh();
                        dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                        stt();
                        MessageBox.Show("Xóa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                if (flag == 3)
                {
                    int kq = nxb.sua(pManxb, pTennxb, pDcnxb, pDtnxb);
                    if (kq == 1)
                    {
                        nxb.LoadNhaxuatban().Clear();
                        dtgv_nxb.Refresh();
                        dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                        stt();
                        MessageBox.Show("Sửa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                flag = 0;
            }
            catch
            {
                flag = 0;
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                grb_thongnxb.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                flag = 0;
            }
            else
                return;
        }

        private void dtgv_nxb_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_nxb.CurrentRow != null)
            {
                txt_manxb.Text = dtgv_nxb.CurrentRow.Cells["MANXB"].Value.ToString().Trim();
                txt_tennxb.Text = dtgv_nxb.CurrentRow.Cells["TENNXB"].Value.ToString().Trim();
                txt_dcnxb.Text = dtgv_nxb.CurrentRow.Cells["DCNXB"].Value.ToString().Trim();
                txt_dtnxb.Text = dtgv_nxb.CurrentRow.Cells["DTNXB"].Value.ToString().Trim();
            }
        }

        private void txt_dtnxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }

        private void txt_dtnxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
                e.Handled = true;
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();

        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void hủyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }
    }
}
