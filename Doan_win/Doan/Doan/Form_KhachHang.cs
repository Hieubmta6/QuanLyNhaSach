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
    public partial class frm_KH : Form
    {
        KHDAL doiTuongKH = new KHDAL();
        public frm_KH()
        {
            InitializeComponent();
        }

        private void frm_KH_Load(object sender, EventArgs e)
        {
            dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
            loadgt();
            STT();
            dtgv_KH.Columns["NGAYSINH"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void loadgt()
        {
            cb_GT.Items.Add("Nam");
            cb_GT.Items.Add("Nữ");
            cb_GT.SelectedItem = "Nam";
        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            if (ktdl())
            {
                string maKH = txt_maKH.Text;
                string tenKH = txt_HoTenKH.Text;
                string ngaySinh = mtxt_ngaySinh.Text;
                string gioiTinh = cb_GT.SelectedItem.ToString();
                string diaChi = txt_DCKH.Text;
                string dienThoai = txt_soDT.Text;

                int kq = doiTuongKH.Them(maKH, tenKH, ngaySinh, gioiTinh, diaChi, dienThoai);

                if (kq == 2)
                {
                    MessageBox.Show("Trùng khóa chính");
                }
                else
                    if (kq == 1)
                    {
                        //-	Hiển thị thông tin sinh viên trên datagridview.
                        dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
                        MessageBox.Show("Thêm thành công");
                        STT();

                    }
                    else
                    {
                        MessageBox.Show("thất bại");
                    }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void btn_luuKH_Click(object sender, EventArgs e)
        {
            doiTuongKH.luu(); 
            MessageBox.Show("Đã lưu");
        }

        private void btn_xoaKH_click(object sender, EventArgs e)
        {
           string maKHCanXoa = dtgv_KH.CurrentRow.Cells[1].Value.ToString();
           doiTuongKH.Xoa(maKHCanXoa);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void STT()
        {
            for (int i = 0; i < dtgv_KH.Rows.Count-1; i++)
            {
                dtgv_KH.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_maKH.Text = "";
            txt_soDT.Text = "";
            txt_DCKH.Text = "";
            txt_HoTenKH.Text = "";
            mtxt_ngaySinh.Text = "";
        }

        private void dtgv_KH_SelectionChanged(object sender, EventArgs e)
        {
            txt_maKH.Text = dtgv_KH.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_HoTenKH.Text = dtgv_KH.CurrentRow.Cells[2].Value.ToString();
            txt_DCKH.Text = dtgv_KH.CurrentRow.Cells[5].Value.ToString();
            txt_soDT.Text = dtgv_KH.CurrentRow.Cells[6].Value.ToString().Trim();
            mtxt_ngaySinh.Text = dtgv_KH.CurrentRow.Cells[3].Value.ToString().Trim();
            cb_GT.Text = dtgv_KH.CurrentRow.Cells[4].Value.ToString();     
        }

        private void mtxt_ngaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txt_soDT_TextChanged(object sender, EventArgs e)
        //{
        //    Control ctr = (Control)sender;
        //    if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
        //    {
        //        this.errorProvider1.SetError(ctr, "Đây không phải là số");
        //        MessageBox.Show("Đây không phải là số");
        //        txt_soDT.Clear();
        //    }
        //    else
        //        this.errorProvider1.Clear();
        //}
        private bool ktdl()
        {
            if (txt_maKH.Text.Length == 0 || txt_soDT.Text.Length == 0 || txt_HoTenKH.Text.Length == 0 || txt_DCKH.Text.Length == 0 || mtxt_ngaySinh.Text.Length != 10)
                return false;
            return true;
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (ktdl())
                {
                    string maKHCanSua = dtgv_KH.CurrentRow.Cells[1].Value.ToString();
                    int kq = doiTuongKH.Sua(maKHCanSua, txt_HoTenKH.Text, mtxt_ngaySinh.Text, cb_GT.SelectedItem.ToString(), txt_DCKH.Text, txt_soDT.Text);
                    if (kq == 1)
                    {
                        //doiTuongKH.LoadBangKH().Clear();
                        //dtgv_KH.Refresh();
                        dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
                        STT();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!!!");
                    }
                }
                else{

                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }
                
            }
            catch 
            {
                MessageBox.Show("Lỗi!!");
            }
        }

        private void txt_soDT_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
               if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(ctr, "Đây không phải là số");
                    MessageBox.Show("Đây không phải là số");
                    txt_soDT.Clear();
                }
                else
                    this.errorProvider1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

    }
}
