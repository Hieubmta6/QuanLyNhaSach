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
    public partial class Form_Kho : Form
    {
        Class_kho k = new Class_kho();
        int flag;
        public Form_Kho()
        {
            InitializeComponent();
        }

        private void Form_Kho_Load(object sender, EventArgs e)
        {
            dtgv_kho.DataSource = k.LoadBangKho_GhepBang();
            stt();
            cmb_tensach.ValueMember = "TENSH".Trim();
            cmb_tensach.DataSource = k.LoadBangSach();
            txt_Ma.Enabled = false;
            
        }
        private void stt()
        {
            for (int i = 0; i < dtgv_kho.Rows.Count - 1; i++)
            {
                dtgv_kho.Rows[i].Cells[0].Value = i + 1;
            }

        }

        private void dtgv_kho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_nk_Click(object sender, EventArgs e)
        {
            string pMasach = k.layMASH(cmb_tensach.Text);
            string pSL = txt_sl.Text;


                   
               //     //tinh tong tien
               //     int kq = k.tinhTongTien(pMasach, pSL);
               //     k.LoadBangKho_GhepBang().Clear();
               //     dtgv_kho.Refresh();
               //     dtgv_kho.DataSource = k.LoadBangKho_GhepBang();
               //// }
               // //else
               // //    MessageBox.Show("Chưa nhập đủ thông tin");
                    if (int.Parse(pSL) == 0)
                    {
                        if (cmb_tensach.Text.Length > 0 && txt_sl.Text.Length > 0)
                        {
                            int kq = k.them(pMasach, pSL);

                            if (kq == 2)
                            {
                                MessageBox.Show("Trùng khóa chính");
                            }
                            if (kq == 1)
                            {
                                // -	Hiển thị thông tin sách trên datagridview
                                k.LoadBangKho_GhepBang().Clear();
                                dtgv_kho.Refresh();
                                dtgv_kho.DataSource = k.LoadBangKho_GhepBang();
                                MessageBox.Show("Thành công");
                                stt();
                                flag = 1;
                            }
                            else
                            {
                                MessageBox.Show("thất bại");
                            }

                        }
                        else
                        {
                            MessageBox.Show("dữ liệu đầu vào chưa đủ");
                        }
                    }
                    else
                    {
                        btn_nk.Enabled = false;
                        btn_cnk.Enabled = true;
                        flag = 2;
                        MessageBox.Show("bạn phải thực hiện chức năng cập nhập kho");
                    }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string pMasach = k.layMASH(cmb_tensach.Text);
            string pSL = txt_sl.Text;
            int kq = k.xoa(pMasach);
           
            if (kq == 2)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            if (kq == 1)
            {
                // -	Hiển thị thông tin sách trên datagridview
                k.LoadBangKho_GhepBang().Clear();
                dtgv_kho.Refresh();
                dtgv_kho.DataSource = k.LoadBangKho_GhepBang();
                MessageBox.Show("Thành công");
                stt();
                flag = 2;
            }
            else
            {
                MessageBox.Show("thất bại");
            }
        }

        private void dtgv_kho_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_kho.CurrentRow != null)
            {
                txt_Ma.Text = dtgv_kho.CurrentRow.Cells["MASH"].Value.ToString().Trim();
                cmb_tensach.Text = dtgv_kho.CurrentRow.Cells["TENSH"].Value.ToString().Trim();
                txt_sl.Text = dtgv_kho.CurrentRow.Cells["KHO"].Value.ToString().Trim();
            }

        }

        private void btn_cnk_Click(object sender, EventArgs e)
        {
            cmb_tensach.SelectedItem = 0;
            txt_sl.Clear();
            string pMasach = k.layMASH(cmb_tensach.Text);
            string pSL = txt_sl.Text;
           
            int kq = k.sua(pMasach,pSL);

            if (kq == 2)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            if (kq == 1)
            {
                // -	Hiển thị thông tin sách trên datagridview
                k.LoadBangKho_GhepBang().Clear();
                dtgv_kho.Refresh();
                dtgv_kho.DataSource = k.LoadBangKho_GhepBang();
                stt();
                MessageBox.Show("Thành công");
                
                flag = 3;
            }
            else
            {
                MessageBox.Show("thất bại");
            }
        }

        private void Form_Kho_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("bạn co muốn đóng (bạn hãy đảm bảo đã lưu các thay đổi)", "thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
            if (r == DialogResult.Yes)
            {
                if (flag == 1)
                {
                    DialogResult r1;
                    r1 = MessageBox.Show("bạn có muốn lưu thay đổi", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r1 == DialogResult.OK)
                        btn_nk.PerformClick();
                }
                else
                    if (flag == 2)
                    {
                        DialogResult r1;
                        r1 = MessageBox.Show("bạn có muốn lưu thay đổi", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r1 == DialogResult.OK)
                            btn_xoa.PerformClick();
                    }
                else
                        if (flag == 3)
                        {
                            DialogResult r1;
                            r1 = MessageBox.Show("bạn có muốn lưu thay đổi", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (r1 == DialogResult.OK)
                                btn_cnk.PerformClick();
                        }
            }
        }

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true)
                e.Handled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                grb_dssach.Enabled = false;
                flag = 0;
            }
            else
                return;
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_nk.PerformClick();
        }

        private void cnkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_cnk.PerformClick();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_xoa.PerformClick();
        }

        private void hủyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnHuy.PerformClick();
        }

        

        

       
    }
}
