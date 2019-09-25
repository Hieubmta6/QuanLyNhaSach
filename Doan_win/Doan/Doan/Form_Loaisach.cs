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
    public partial class Form_Loaisach : Form
    {
        Class_loaisach lsach = new Class_loaisach();
        int flag;
        public Form_Loaisach()
        {
            InitializeComponent();
        }

        private void Form_Loaisach_Load(object sender, EventArgs e)
        {
            dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
            stt();
            //-	Đỗ dữ liệu lên combobox Lớp, thông tin lớp lấy từ cơ sở dữ liệu với tên lớp là nhãn hiển thị, mã lớp là giá trị khi nhấn chọn item, trong đó dòng đầu tiên là “Tất cả lớp”. Khi chọn tên lớp trên combobox Lớp, datagridview sẽ được lọc dữ liệu theo.
            
        }
        private void stt()
        {
            for (int i = 0; i < dtgv_loaisach.Rows.Count - 1; i++)
            {
                dtgv_loaisach.Rows[i].Cells[0].Value = i + 1;
            }

        }

        private void grb_thongnxb_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_maloaish.Clear();
            txt_tenloaish.Clear();
            grb_loaisach.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txt_maloaish.Clear();
            txt_tenloaish.Clear();
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grb_loaisach.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            flag = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grb_loaisach.Enabled = true;
            txt_maloaish.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            flag = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string pMaloai = txt_maloaish.Text;
                string pTenloai = txt_tenloaish.Text;
                if (flag == 1)
                {
                    if (txt_maloaish.Text.Length > 0 && txt_tenloaish.Text.Length > 0 )
                    {
                        int kq = lsach.them(pMaloai, pTenloai);
                        if (kq == 2)
                        {
                            MessageBox.Show("Trùng khóa chính");
                        }
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            
                            lsach.LoadBangLoaiSach().Clear();
                            dtgv_loaisach.Refresh();
                            dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                            MessageBox.Show("Thành công");
                            stt();
                            grb_loaisach.Enabled = false;
                            btnLuu.Enabled = btnHuy.Enabled = false;
                            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                        }
                        else
                        {
                            lsach.LoadBangLoaiSach().Clear();
                            dtgv_loaisach.Refresh();
                            dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                            stt();
                            MessageBox.Show("thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu thêm vào chưa đủ");
                    }

                }
                if (flag == 2)
                {
                    int kq = lsach.xoa(pMaloai);
                    if (kq == 1)
                    {
                        lsach.LoadBangLoaiSach().Clear();
                        dtgv_loaisach.Refresh();
                        dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                        stt();
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                    }
                    else
                    {
                        lsach.LoadBangLoaiSach().Clear();
                        dtgv_loaisach.Refresh();
                        dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                        stt();
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                if (flag == 3)
                {
                    int kq = lsach.sua(pMaloai,pTenloai);
                    if (kq == 1)
                    {
                        lsach.LoadBangLoaiSach().Clear();
                        dtgv_loaisach.Refresh();
                        dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                        stt();
                        grb_loaisach.Enabled = false;
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("loi!!!");
                    }
                }
                flag = 0;
            }
            catch
            {
                flag = 0;
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                grb_loaisach.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                flag = 0;
            }
            else
                return;
        }

        private void dtgv_loaisach_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_loaisach.CurrentRow != null)
            {
                txt_maloaish.Text = dtgv_loaisach.CurrentRow.Cells["MALOAISH"].Value.ToString().Trim();
                txt_tenloaish.Text = dtgv_loaisach.CurrentRow.Cells["TENLOAISH"].Value.ToString().Trim();
            }
        }

        private void Form_Loaisach_FormClosing(object sender, FormClosingEventArgs e)
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
                        btnLuu.PerformClick();
                }
            }
        }

        private void txt_tenloaish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
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
