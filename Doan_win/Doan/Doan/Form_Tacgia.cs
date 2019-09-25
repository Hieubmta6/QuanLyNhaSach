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
    public partial class Form_Tacgia : Form
    {
        Class_Tacgia tg = new Class_Tacgia();
        int flag;
        public Form_Tacgia()
        {
            InitializeComponent();
        }

        private void Form_Tacgia_Load(object sender, EventArgs e)
        {
            dtgv_tacgia.DataSource = tg.LoadTacgia();
            stt();
            grb_tg.Enabled = false;
        }
        private void stt()
        {
            for (int i = 0; i < dtgv_tacgia.Rows.Count - 1; i++)
            {
                dtgv_tacgia.Rows[i].Cells[0].Value = i + 1;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                grb_tg.Enabled = false;
                btn_luu.Enabled = btnHuy.Enabled = false;
                btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
                flag = 0;
            }
            else
                return;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            grb_tg.Enabled = true;
            txt_Matg.Clear();
            txt_tentg.Clear();
            btn_luu.Enabled = btnHuy.Enabled = true;
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            flag = 1;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string pMatg = txt_Matg.Text;
                string pTentg = txt_tentg.Text;
                if (flag == 1)
                {
                    int kq = tg.them(pMatg, pTentg);

                    if (kq == 2)
                    {
                        MessageBox.Show("Trùng khóa chính");
                    }
                    if (kq == 1)
                    {
                        // -	Hiển thị thông tin sách trên datagridview
                        tg.LoadTacgia().Clear();
                        dtgv_tacgia.Refresh();
                        dtgv_tacgia.DataSource = tg.LoadTacgia();
                        stt();
                        MessageBox.Show("Thêm Thành công");
                        btn_luu.Enabled = btnHuy.Enabled = false;
                        btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = true;
                    }
                    else
                    {
                        tg.LoadTacgia().Clear();
                        dtgv_tacgia.Refresh();
                        dtgv_tacgia.DataSource = tg.LoadTacgia();
                        stt();
                        MessageBox.Show("thất bại");
                    }
                }
                if (flag == 2)
                {
                    int kq = tg.xoa(pMatg);
                    if (kq == 1)
                    {
                        tg.LoadTacgia().Clear();
                        dtgv_tacgia.Refresh();
                        dtgv_tacgia.DataSource = tg.LoadTacgia();
                        stt();
                        MessageBox.Show("Xóa Thành công");
                        btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                if (flag == 3)
                {
                    int kq = tg.sua(pMatg, pTentg);
                    if (kq == 1)
                    {
                        tg.LoadTacgia().Clear();
                        dtgv_tacgia.Refresh();
                        dtgv_tacgia.DataSource = tg.LoadTacgia();
                        stt();
                        MessageBox.Show("Sửa Thành công");
                        btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = true;
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            grb_tg.Enabled = true;
            btn_luu.Enabled = btnHuy.Enabled = true;
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            flag = 3;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            grb_tg.Enabled = true;
            btn_luu.Enabled = btnHuy.Enabled = true;
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            flag = 2;
        }

        private void dtgv_tacgia_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_tacgia.CurrentRow != null)
            {
                txt_Matg.Text = dtgv_tacgia.CurrentRow.Cells["MATG"].Value.ToString().Trim();
                txt_tentg.Text = dtgv_tacgia.CurrentRow.Cells["TENTG"].Value.ToString().Trim();
            }

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_them.PerformClick();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_xoa.PerformClick();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_sua.PerformClick();
        }

        private void hủyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        private void Form_Tacgia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("bạn co muốn đóng", "thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
            if (r == DialogResult.Yes)
            {
                if (flag == 2 || flag == 3 || flag == 1)
                {
                    DialogResult r1;
                    r1 = MessageBox.Show("bạn có muốn lưu thay đổi", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r1 == DialogResult.OK)
                        btn_luu.PerformClick();
                }
            }
        }

        private void txt_tentg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_luu.PerformClick();
            }
        }
    }
}
