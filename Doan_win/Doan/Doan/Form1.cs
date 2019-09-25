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
    public partial class Form_dangnhap : Form
    {
        Class_dangnhap dn = new Class_dangnhap();
        public Form_dangnhap()
        {
            InitializeComponent();
        } 
        SqlConnection conn;
        private void Form_dangnhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-MEPOI64\SQLEXPRESS;Initial Catalog=quanlynhasach;User ID=sa;Password=sa2012");
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form_main main = new Form_main();
            if (txt_dangnhap.Text.Length < 0)
            {
                MessageBox.Show("Chưa nhập tên user");
            }
            else
                if (txt_mk.Text.Length < 0)
                {
                    MessageBox.Show("Chưa nhập mật khẩu");
                }
                else
                {
                    try
                    {
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string src = "select * from TAIKHOAN where TAIKHOAN.TENTK='" + txt_dangnhap.Text + "' and TAIKHOAN.PASSWORK='" + txt_mk.Text + "'";
                        SqlCommand cmd = new SqlCommand(src, conn);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())//có tài khoản mật khẩu như vậy thì vào Main chính
                        {
                            //if (dr[1].ToString().CompareTo("admin") == 0)
                            //{
                                conn.Close();
                                //this.Hide();//form đăng nhập ẩn
                                //conn.Open();
                                //string srcq = "select TAIKHOAN.QUYEN from TAIKHOAN where TAIKHOAN.TENTK=N'" + txt_dangnhap.Text + "'and TAIKHOAN.PASSWORK=N'" + txt_mk.Text + "'";
                                //SqlCommand cmd1 = new SqlCommand(srcq, conn);
                                //SqlDataReader dr1 = cmd1.ExecuteReader();

                                //if (dr1.Read().ToString() == "admin")
                                //{

                                //MessageBox.Show(dn.layQuyen(txt_mk.Text).ToString());
                                //if(dr1.Read().ToString()=="admin")
                                //if (dn.layQuyen(txt_mk.Text)==1)
                                //{   
                                //conn.Close();
                                this.Hide();
                                main.ShowDialog();
                                //}
                            //}
                            //    else
                            //    {
                            //        conn.Close();
                            //        MessageBox.Show("ban ko co quyen truy cap");
                            //        this.Show();
                            //    }
                            //    }  
                            //}
                            //else
                            //{
                            //    conn.Close();
                            //    MessageBox.Show("Đăng Nhập Thất Bại");

                            //}
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!!!!!!!!");

                    }
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {
            txt_mk.PasswordChar = '*';
        }

        private void ptb_dangnhap_Click(object sender, EventArgs e)
        {

        }

        

      

       
    }
}
