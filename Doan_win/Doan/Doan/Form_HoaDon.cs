using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Class;

namespace Doan
{
    public partial class frm_HD : Form
    {
        HDDAL doiTuongHD = new HDDAL();
        CTHDDAL doiTuongCHTD = new CTHDDAL();

        public frm_HD()
        {
            InitializeComponent();
        }

        private void frm_HD_Load(object sender, EventArgs e)
        {
            dtgv_HD.DataSource = doiTuongHD.LoadBangHD_GhepBang();
            dtgv_CTHD.DataSource = doiTuongCHTD.LoadBangCTHD();
            cb_KH.DisplayMember = "HOTEN";
            cb_KH.ValueMember = "MAKH";
            cb_KH.DataSource = doiTuongHD.LoadBangKhachHang();
            cb_NV.DisplayMember = "HOTENNV";
            cb_NV.ValueMember = "MANV";
            cb_NV.DataSource = doiTuongHD.LoadBangNhanVien();
            cb_SH.DisplayMember = "TENSH";
            cb_SH.ValueMember = "MASH";
            cb_SH.DataSource = cb_donGia.DataSource = doiTuongHD.LoadBangTenSach();
            cb_donGia.ValueMember = "GIATIEN";
            cb_donGia.DisplayMember = "GIATIEN";
            btn_xuLiHD.PerformClick();
            dtgv_HD.Columns["NGAYLAP"].DefaultCellStyle.Format = "dd/MM/yyyy";
            
        }

        private void btn_themHD_Click(object sender, EventArgs e)
        {
            if (dtgv_HD.Enabled == false)
            {
                if (ktdl2())
                {
                    string maHD = txt_maHD.Text;
                    string maSH = cb_SH.SelectedValue.ToString();
                    string soLuong = txt_soLuong.Text;
                    float donGia = float.Parse(cb_donGia.SelectedValue.ToString());

                    int kq1 = doiTuongCHTD.ThemCTHD(maHD, maSH, soLuong, donGia);

                    if (kq1 == 2)
                    {
                        MessageBox.Show("Trùng khóa chính MAHD,MASH trong CHITIETHOADON");
                    }
                    else
                        if (kq1 == 1)
                        {
                            //-	Hiển thị thông tin sinh viên trên datagridview.
                            dtgv_CTHD.DataSource = doiTuongCHTD.LoadBangCTHD();
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("thất bại");
                        }
                    //tinh tong tien
                    int kq = doiTuongHD.tinhTongTien(maHD, soLuong, donGia);
                    doiTuongHD.LoadBangHD_GhepBang().Clear();
                    dtgv_HD.Refresh();
                    dtgv_HD.DataSource = doiTuongHD.LoadBangHD_GhepBang();
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");
            }
            if (dtgv_HD.Enabled == true)
            {
                if (ktdl() == true)
                {
                    string maHD = txt_maHD.Text;
                    string maKH = cb_KH.SelectedValue.ToString();
                    string maNV = cb_NV.SelectedValue.ToString();
                    string maSH = cb_SH.SelectedValue.ToString();
                    string ngayLap = mtxt_ngayLap.Text;

                    int kq = doiTuongHD.ThemHD2(maHD, maKH, ngayLap, maNV);
                    if (kq == 2)
                    {
                        MessageBox.Show("Trùng khóa chính MAHD trong HOADON");
                    }
                    else
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            doiTuongHD.LoadBangHD_GhepBang().Clear();
                            dtgv_HD.Refresh();
                            dtgv_HD.DataSource = doiTuongHD.LoadBangHD_GhepBang();
                            MessageBox.Show("Thành công");
                            //stt();
                        }
                        else
                        {
                            MessageBox.Show("thất bại");
                        }
                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void btn_xoaHD_Click(object sender, EventArgs e)
        {
            if (dtgv_HD.Enabled == false)
            {
                string maHDCanXoa = dtgv_CTHD.CurrentRow.Cells[0].Value.ToString();
                string maSHCanXoa = dtgv_CTHD.CurrentRow.Cells[1].Value.ToString();
                string soLuong = dtgv_CTHD.CurrentRow.Cells[3].Value.ToString();
                float donGia = float.Parse(dtgv_CTHD.CurrentRow.Cells[2].Value.ToString());
                int kq1 = doiTuongCHTD.Xoa(maHDCanXoa, maSHCanXoa);
                if (kq1 == 1)
                {
                    doiTuongCHTD.LoadBangCTHD().Clear();
                    dtgv_CTHD.Refresh();
                    dtgv_CTHD.DataSource = doiTuongCHTD.LoadBangCTHD();
                    //tinh tong tien
                    int kq = doiTuongHD.tinhTongTienXoa(maHDCanXoa, soLuong, donGia);
                    doiTuongHD.LoadBangHD_GhepBang().Clear();
                    dtgv_HD.Refresh();
                    dtgv_HD.DataSource = doiTuongHD.LoadBangHD_GhepBang();
                }

            }
            else
            {

                string pMasach = dtgv_HD.CurrentRow.Cells[0].Value.ToString();
                int kq = doiTuongHD.Xoa(pMasach);
                if (kq == 1)
                {
                    doiTuongHD.LoadBangHD_GhepBang().Clear();
                    dtgv_HD.Refresh();
                    dtgv_HD.DataSource = doiTuongHD.LoadBangHD_GhepBang();
                    // stt();
                }
                else
                {
                    MessageBox.Show("Còn HOADON trong CHITIETHD");
                }
            }
        }

        private void btn_xuLiCTHD_Click(object sender, EventArgs e)
        {
            cb_KH.Enabled = false;
            cb_NV.Enabled = false;
            mtxt_ngayLap.Enabled = false;
            dtgv_HD.Enabled = false;
            dtgv_CTHD.Enabled = true;
            txt_soLuong.Enabled = true;
            btn_xuLiHD.BackColor = Color.Empty;
            btn_xuLiCTHD.BackColor = Color.Bisque;
            btn_suaHD.Enabled = false;
            cb_SH.Enabled = true;
            txt_maHD.Enabled = true;
        }

        private void btn_xuLiHD_Click(object sender, EventArgs e)
        {
            cb_KH.Enabled = true;
            cb_NV.Enabled = true;
            mtxt_ngayLap.Enabled = true;
            dtgv_HD.Enabled = true;
            dtgv_CTHD.Enabled = false;
            txt_soLuong.Enabled = false;
            btn_xuLiHD.BackColor = Color.Bisque;
            btn_xuLiCTHD.BackColor = Color.Empty;
            btn_suaHD.Enabled = true;
            cb_SH.Enabled = false;
        }

        private void btn_luuHD_Click(object sender, EventArgs e)
        {
            doiTuongCHTD.luu();
            doiTuongHD.luu();
            MessageBox.Show("Đã lưu");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            doiTuongCHTD.luu();
            doiTuongHD.luu();
            MessageBox.Show("Đã lưu");
            this.Close();
        }

        private bool ktdl()
        {
            if (txt_maHD.Text.Length == 0 || mtxt_ngayLap.Text.Length != 10)//sao khác 10 nhap zo masked lenght full = 10 j
                return false;
            return true;
        }

        private bool ktdl2()
        {
            if (txt_maHD.Text.Length == 0 || txt_soLuong.Text.Length == 0)
                return false;
            return true;
        }

        private void btn_suaHD_Click(object sender, EventArgs e)
        {
            if (ktdl())
            {
                string maHDCanSua = dtgv_HD.CurrentRow.Cells[0].Value.ToString();
                int kq = doiTuongHD.Sua(maHDCanSua, mtxt_ngayLap.Text, cb_KH.SelectedValue.ToString(), cb_NV.SelectedValue.ToString());
                if (kq == 1)
                {
                    doiTuongHD.LoadBangHD_GhepBang().Clear();
                    dtgv_HD.Refresh();
                    dtgv_HD.DataSource = doiTuongHD.LoadBangHD_GhepBang();
                    //STT();
                }
                else
                {
                    MessageBox.Show("loi!!!");
                }

            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin");
        }

        private void dtgv_HD_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_maHD.Enabled = false;
                txt_maHD.Text = dtgv_HD.CurrentRow.Cells[0].Value.ToString().Trim();
                cb_KH.SelectedItem = dtgv_HD.CurrentRow.Cells[2].Value.ToString().Trim();
                cb_KH.SelectedValue = dtgv_HD.CurrentRow.Cells[1].Value.ToString().Trim();

                cb_NV.SelectedItem = dtgv_HD.CurrentRow.Cells[6].Value.ToString().Trim();//
                cb_NV.SelectedValue = dtgv_HD.CurrentRow.Cells[5].Value.ToString().Trim();
                cb_KH.SelectedItem = dtgv_HD.CurrentRow.Cells[2].Value.ToString().Trim();
                cb_KH.SelectedValue = dtgv_HD.CurrentRow.Cells[1].Value.ToString().Trim();
                mtxt_ngayLap.Text = dtgv_HD.CurrentRow.Cells["NGAYLAP"].Value.ToString().Trim();
            }
            catch
            {
                return;
            } 
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_maHD.Text = "";
            txt_soLuong.Text = "";
            mtxt_ngayLap.Text = "";
            txt_maHD.Enabled = true;
        }

        private void frm_HD_FormClosed(object sender, FormClosedEventArgs e)//closing chứ
        {
            doiTuongCHTD.luu();
            doiTuongHD.luu();      
        }
        
    }
}
