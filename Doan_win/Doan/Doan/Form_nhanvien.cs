using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Doan.Class;


namespace Doan
{
    public partial class Form_nhanvien : Form
    {
        SqlConnection data = new SqlConnection();
        DataSet da;
        Class_nhanvien nv = new Class_nhanvien();
        Class_taikhoan tk = new Class_taikhoan();
        public Form_nhanvien()
        {
            InitializeComponent();

        }
        int flag;
        private void Form_nhanvien_Load(object sender, EventArgs e)
        {
            dtgvDS.DataSource = nv.Loadnv();
            //dtgvDS.Columns["NGAYSINH"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dtgvDS.Columns["NGAYVL"].DefaultCellStyle.Format = "dd/MM/yyyy";
            stt();
            DisEnl(false);
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.SelectedItem = 0;
            dt_nvl.Value = DateTime.Now.Date;
        }


        private void stt()
        {
            for (int i = 0; i < dtgvDS.Rows.Count - 1; i++)
            {
                dtgvDS.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMa.Enabled = e;
            txtTen.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMNQL.Enabled = e;
            txtcv.Enabled = e;
            txtluong.Enabled = e;
            msk_ngaysinh.Enabled = e;
            cmbGioiTinh.Enabled = e;
            dt_nvl.Enabled = e;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            clearData();
            DisEnl(true);

        }
        private void clearData()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtMNQL.Text = "";
            txtcv.Text = "";
            txtluong.Text = "";
            msk_ngaysinh.Text = "";
            dt_nvl.Value = DateTime.Now.Date;
            cmbGioiTinh.SelectedValue = true;
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DisEnl(false);
                flag = 0;
                Form_nhanvien_Load(sender, e);
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string pManv = txtMa.Text;
                string pTennv = txtTen.Text;
                string pngaysinh = msk_ngaysinh.Text;
                string pngayvaolam = dt_nvl.Text;
                string pmnql = txtMNQL.Text;
                string pgt = cmbGioiTinh.Text;
                string pdc = txtDiaChi.Text;
                string pcv = txtcv.Text;
                string pquyen = " ";
                if (pcv.CompareTo("Nhân viên") == 0)
                {
                    pquyen = "user";
                }
                float pluong = float.Parse(txtluong.Text.ToString());
                string pmk = "123456789";
                string pTentaikhoan = pManv;
                string pngaylap = pngayvaolam;
                if (flag == 1)
                {
                    if (txtMa.Text.Length > 0 && txtTen.Text.Length > 0 && dt_nvl.Text.Length > 0 && msk_ngaysinh.Text.Length > 0 && cmbGioiTinh.Text.Length > 0 && txtDiaChi.Text.Length > 0 && txtluong.Text.Length > 0 && txtcv.Text.Length > 0 && txtMNQL.Text.Length > 0)
                    {

                        int kq = nv.them(pManv, pTennv, pngaysinh, pngayvaolam, pmnql, pgt, pdc, pcv, pluong);
                        int kq1 = tk.themtk(pManv, pquyen, pTentaikhoan, pmk, pngaylap);
                        if (kq == 2)
                        {
                            MessageBox.Show("Trùng khóa chính");
                        }
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            nv.Loadnv().Clear();
                            dtgvDS.Refresh();
                            dtgvDS.DataSource = nv.Loadnv();
                            stt();
                            MessageBox.Show("Thêm Thành công");
                            btnLuu.Enabled = btnHuy.Enabled = false;
                            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                            flag = 0;
                        }
                        else
                        {
                            
                            MessageBox.Show("thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu thêm chưa đủ ");
                    }
                }
                if (flag == 2)
                {
                    pManv = dtgvDS.CurrentRow.Cells[1].Value.ToString();
                    int kq = nv.xoa(pManv);
                    if (kq == 1)
                    {
                        
                        nv.Loadnv().Clear();
                        dtgvDS.Refresh();
                        nv.luu();
                        dtgvDS.DataSource = nv.Loadnv();
                        stt();
                        MessageBox.Show("Xóa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        nv.Loadnv().Clear();
                        dtgvDS.Refresh();
                        dtgvDS.DataSource = nv.Loadnv();
                        stt();
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }

                }
                if (flag == 3)
                {
                    int kq = nv.sua(pManv, pTennv, pngaysinh, pngayvaolam, pmnql, pgt, pdc, pcv, pluong);
                    if (kq == 1)
                    {
                        nv.Loadnv().Clear();
                        dtgvDS.Refresh();
                        dtgvDS.DataSource = nv.Loadnv();
                        stt();
                        MessageBox.Show("Sửa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }

            }
            catch
            {
                flag = 0;
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void txtluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)==false)
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            DisEnl(true);
            grb_thongtinnhanvien.Enabled = true;
        }
        private void Form_nhanvien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLuu.PerformClick();
        }

        private void hủyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            DisEnl(true);
            grb_thongtinnhanvien.Enabled = false;
        }

        private void txtluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }

        private void dtgvDS_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDS.CurrentRow != null)
            {
                txtMa.Text = dtgvDS.CurrentRow.Cells["MANV"].Value.ToString();
                txtTen.Text = dtgvDS.CurrentRow.Cells["HOTENNV"].Value.ToString();
                msk_ngaysinh.Text = dtgvDS.CurrentRow.Cells["NGAYSINH"].Value.ToString();
                dt_nvl.Text = dtgvDS.CurrentRow.Cells["NGAYVL"].Value.ToString();
                cmbGioiTinh.Text = dtgvDS.CurrentRow.Cells["GIOITINH"].Value.ToString();
                txtDiaChi.Text = dtgvDS.CurrentRow.Cells["DIACHINV"].Value.ToString();
                txtluong.Text = dtgvDS.CurrentRow.Cells["LUONG"].Value.ToString();
                txtcv.Text = dtgvDS.CurrentRow.Cells["CHUCVU"].Value.ToString();
                txtMNQL.Text = dtgvDS.CurrentRow.Cells["MANQL"].Value.ToString();
            }
        }
    }
}
