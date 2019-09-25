using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Doan.Class
{
    class Class_kho:connect
    {
        public DataSet ds_kho = new DataSet();
        public SqlDataAdapter da_kho;
        public Class_kho()
        {
            //string sql1 = "Select * from KHO ";
            //da_kho = new SqlDataAdapter(sql1, conn);
            LoadKho();
        }
        public DataTable LoadKho()
        {
            da_kho = new SqlDataAdapter("select * from KHO", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_kho.Fill(ds_kho, "KHO");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_kho.Tables["KHO"].Columns[0];
            ds_kho.Tables["KHO"].PrimaryKey = khoachinh;
            return ds_kho.Tables["KHO"];
        }
        public DataTable LoadBangKho_GhepBang()
        {
            SqlDataAdapter daSach_ghepbang = new SqlDataAdapter("Select KHO.MASH, KHO.SOLUONG, SACH.TENSH, LOAISACH.TENLOAISH,SACH.GIATIEN,SACH.NAMXB FROM SACH,LOAISACH,KHO WHERE KHO.MASH=SACH.MASH AND SACH.MALOAISH=LOAISACH.MALOAISH", conn);
            daSach_ghepbang.Fill(ds_kho, "kho_ghep");
            return ds_kho.Tables["kho_ghep"];
        }

        public DataTable LoadBangKho_GhepBang2()
        {
            SqlDataAdapter daSach_ghepbang = new SqlDataAdapter("Select KHO.MASH, KHO.SOLUONG, SACH.TENSH FROM SACH,KHO WHERE KHO.MASH=SACH.MASH ", conn);
            daSach_ghepbang.Fill(ds_kho, "kho_ghep");
            return ds_kho.Tables["kho_ghep"];
        }

        public DataTable LoadBangSach()
        {
            SqlDataAdapter datensach = new SqlDataAdapter("Select * from SACH", conn);
            datensach.Fill(ds_kho,"SACH");
            return ds_kho.Tables["SACH"];
        }
        public bool KTKC(string pMasach)
        {
            return KTKC_New(pMasach, ds_kho.Tables["KHO"]);
        }
        public string layMASH(string pbien)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from SACH where TENSH=N'" + pbien + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            string kq = " ";
            while (dr.Read())
            {
                kq = dr["MASH"].ToString();
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq;
        }
        public int them(string pMasach, string pSL)
        {
            try
            {

                da_kho = new SqlDataAdapter("select * from KHO", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_kho.Fill(ds_kho, "KHO");

                if (KTKC(pMasach) == true)
                {
                    return 2;
                }
                else
                {
                    DataRow dtThem = ds_kho.Tables["KHO"].NewRow();
                    dtThem[0] = pMasach;
                    dtThem[1] = pSL;
                    ds_kho.Tables["KHO"].Rows.Add(dtThem);
                    SqlCommandBuilder builda = new SqlCommandBuilder(da_kho);
                    da_kho.Update(ds_kho, "KHO");
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int tinhTongSoLuong(string pMaSH, string pSoLuong)
        {
            da_kho = new SqlDataAdapter("select * from KHO", conn);
            DataRow dr = ds_kho.Tables["KHO"].Rows.Find(pMaSH);
            if (dr != null)
            {
                dr["SOLUONG"] = float.Parse(dr["SOLUONG"].ToString()) + int.Parse(pSoLuong);
            }
            //ds_HD.Tables["HOADON"].Rows.Add(dr);
            SqlCommandBuilder builda = new SqlCommandBuilder(da_kho);
            da_kho.Update(ds_kho, "KHO");

            return 1;
        }

        public int xoa(string pMasach)
        {
            try
            {

                da_kho = new SqlDataAdapter("select * from KHO", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_kho.Tables["KHO"].Rows.Find(pMasach);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_kho);
                da_kho.Update(ds_kho, "KHO");
                return 1;

            }
            catch
            {
                return 0;
            }
        }
        public int sua(string pMasach, string pSL)
        {
            try
            {

                da_kho = new SqlDataAdapter("select * from KHO", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_kho.Tables["KHO"].Rows.Find(pMasach);
                if (dts != null)
                {
                    dts[1] = pSL;
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_kho);
                da_kho.Update(ds_kho, "KHO");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int luu()
        {
            SqlCommandBuilder duilda = new SqlCommandBuilder(da_kho);
            da_kho.Update(ds_kho, "KHO");
            return 1;
        }
            
        }
    }

