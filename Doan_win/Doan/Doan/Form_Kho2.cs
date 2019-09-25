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
    public partial class Form_Kho2 : Form
    {
        Class_kho k = new Class_kho();
        public Form_Kho2()
        {
            InitializeComponent();
        }

        

        

        private void Form_Kho2_Load(object sender, EventArgs e)
        {
            dtgv_kho.DataSource = k.LoadBangKho_GhepBang2();
            stt();
            cb_TenSH.ValueMember = "MASH".Trim();
            cb_TenSH.DisplayMember = "TENSH".Trim();
            cb_TenSH.DataSource = k.LoadBangSach();
            //txt_Ma.Enabled = false;
        }

        private void stt()
        {
            for (int i = 0; i < dtgv_kho.Rows.Count - 1; i++)
            {
                dtgv_kho.Rows[i].Cells[0].Value = i + 1;
            }

        }

        private void btn_themsl_Click(object sender, EventArgs e)
        {
            //day lỗi sao giờ lỗi rồi
            if (ktdl())
            {
                int kq = k.tinhTongSoLuong(cb_TenSH.SelectedValue.ToString(), txt_soLuong.Text);
                k.LoadBangKho_GhepBang2().Clear();
                dtgv_kho.Refresh();
                dtgv_kho.DataSource = k.LoadBangKho_GhepBang2();
                stt();
            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin");
        }

        private bool ktdl()
        {
            if (txt_soLuong.Text.Length == 0 )//sao khác 10 nhap zo masked lenght full = 10 j
                return false;
            return true;
        }

        private void btn_suasl_Click(object sender, EventArgs e)
        {
            try
            {
                if (ktdl())
                {
                    string maSHCanSua = dtgv_kho.CurrentRow.Cells[1].Value.ToString();
                    int kq = k.sua(maSHCanSua,txt_soLuong.Text);
                    if (kq == 1)
                    {
                        k.LoadBangKho_GhepBang2().Clear();
                        dtgv_kho.Refresh();
                        dtgv_kho.DataSource = k.LoadBangKho_GhepBang2();
                        stt();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!!!");
                    }
                }
                else
                {

                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi!!");
            }
        }

        private void btn_xoasl_Click(object sender, EventArgs e)
        {
            try
            {
                string maSHCanXoa = dtgv_kho.CurrentRow.Cells[1].Value.ToString();
                k.xoa(maSHCanXoa);
                k.LoadBangKho_GhepBang2().Clear();//sao xáo kho dc kho ko dc xóa phải xóa sách trc code của mày đang xóa dc kho sách còn số lượng ko có
                dtgv_kho.Refresh();
                dtgv_kho.DataSource = k.LoadBangKho_GhepBang2();
                stt();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_luusl_Click(object sender, EventArgs e)
        {
            k.luu();
            MessageBox.Show("Đã lưu");
        }

        private void dtgv_kho_SelectionChanged(object sender, EventArgs e)
        {
            txt_soLuong.Text = dtgv_kho.CurrentRow.Cells[2].Value.ToString().Trim();
            cb_TenSH.SelectedItem = dtgv_kho.CurrentRow.Cells[2].Value.ToString().Trim();
            cb_TenSH.SelectedValue = dtgv_kho.CurrentRow.Cells[1].Value.ToString().Trim();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            k.luu();
            MessageBox.Show("Đã lưu");
            this.Close();
        }

        private void Form_Kho2_FormClosing(object sender, FormClosingEventArgs e)
        {
            k.luu();
            MessageBox.Show("Đã lưu");
        }

    }
}
