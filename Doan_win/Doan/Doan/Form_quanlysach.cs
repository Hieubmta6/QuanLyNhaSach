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
using Doan.Resources;
using System.Data.SqlTypes;
using Doan.Class;

namespace Doan
{
    public partial class Form_quanlysach : Form
    {
        Class_sach sach = new Class_sach();
        Class_kho kho = new Class_kho();
        int flag;
        public Form_quanlysach()
        {
            InitializeComponent();
        }
       
        private void Form_quanlysach_Load(object sender, EventArgs e)
        {
            
            dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
            stt();
            //-	Đỗ dữ liệu lên combobox Lớp, thông tin lớp lấy từ cơ sở dữ liệu với tên lớp là nhãn hiển thị, mã lớp là giá trị khi nhấn chọn item, trong đó dòng đầu tiên là “Tất cả lớp”. Khi chọn tên lớp trên combobox Lớp, datagridview sẽ được lọc dữ liệu theo.
            cmb_nxb.ValueMember = "TENNXB".Trim();
            cmb_nxb.DataSource = sach.LoadBangNhaXuatBan();
            cmb_tl.ValueMember = "TENLOAISH";
            cmb_tl.DataSource = sach.LoadBangLoaiSach();
            cmb_ttg.ValueMember = "TENTG";
            cmb_ttg.DataSource = sach.LoadBangTacGia();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grb_thongtinsach.Enabled=true;
            btnLuu.Enabled = btnHuy.Enabled=true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtMa.Clear();
            txtTen.Clear();
            txt_nanxb.Clear();
            txtgia.Clear();
            flag = 1;
        }
        

        private void stt()
        {
            for (int i = 0; i < dtgv_sach.Rows.Count - 1; i++)
            {
                dtgv_sach.Rows[i].Cells[0].Value = i + 1;
            }
           
        }
        
        private void dtgv_sach_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_sach.CurrentRow != null)
            {
                txtMa.Text = dtgv_sach.CurrentRow.Cells["MASH"].Value.ToString().Trim();
                txtTen.Text = dtgv_sach.CurrentRow.Cells["TENSH"].Value.ToString().Trim();
                cmb_tl.Text = dtgv_sach.CurrentRow.Cells["TENLOAISH"].Value.ToString().Trim();
                cmb_ttg.Text = dtgv_sach.CurrentRow.Cells["TENTG"].Value.ToString().Trim();
                txt_nanxb.Text = dtgv_sach.CurrentRow.Cells["NAMXB"].Value.ToString().Trim();
                cmb_nxb.Text = dtgv_sach.CurrentRow.Cells["TENNXB"].Value.ToString().Trim();
                txtgia.Text = dtgv_sach.CurrentRow.Cells["GIATIEN"].Value.ToString().Trim();
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            { 
                string pMasach = txtMa.Text;
                string pTensach = txtTen.Text;
                string pMaTG = sach.layMATG(cmb_ttg.Text.ToString());
                string pMaNXB = sach.layMANXB(cmb_nxb.Text.ToString());
                string pNamxb = txt_nanxb.Text;
                string pMaTL = sach.layMALOAISH(cmb_tl.Text.ToString());  
                float pGiatien = float.Parse(txtgia.Text);
                if (flag == 1)
                {
                    if (txtMa.Text.Length > 0 && txtTen.Text.Length > 0 && cmb_ttg.Text.Length > 0 && cmb_nxb.Text.Length > 0 && cmb_tl.Text.Length > 0 && txtgia.Text.Length>0)
                    {
                        string pSL = "Hàng chưa về";
                        int kq = sach.them(pMasach, pTensach, pMaTG, pNamxb, pGiatien, pMaNXB, pMaTL);
                        int kq1 = kho.them(pMasach, pSL);
                        if (kq == 2)
                        {
                            MessageBox.Show("Trùng khóa chính");
                        }
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            sach.LoadBangSach_GhepBang().Clear();
                            dtgv_sach.Refresh();
                            dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
                            MessageBox.Show("Thành công");
                            stt();
                            grb_thongtinsach.Enabled = false;
                            btnLuu.Enabled = btnHuy.Enabled = false;
                            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                            
                        }
                        else
                        {
                            sach.LoadBangSach_GhepBang().Clear();
                            dtgv_sach.Refresh();
                            dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
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
                    int kq = sach.xoa(pMasach);
                    if (kq == 1)
                    {
                        sach.LoadBangSach_GhepBang().Clear();
                        dtgv_sach.Refresh();
                        dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
                        stt();
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                        
                    }
                    else
                    {
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                if (flag == 3)
                {
                    int kq = sach.sua(pMasach, pTensach, pMaTG, pNamxb, pGiatien, pMaNXB, pMaTL);
                    if (kq == 1)
                    {
                        sach.LoadBangSach_GhepBang().Clear();
                        dtgv_sach.Refresh();
                        dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
                        stt();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grb_thongtinsach.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            flag = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grb_thongtinsach.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtMa.Enabled = false;
            flag = 3;
        }

        private void dtgv_sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Form_quanlysach_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                grb_thongtinsach.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                flag = 0;
            }
            else
                return;
        }

        private void hủyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true)
                e.Handled = true;
        }

        private void txtgia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }
    }
}
