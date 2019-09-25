using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Doan.Class
{
    class CTHDDAL : connect
    {
        public DataSet ds_CTHD = new DataSet();
        public SqlDataAdapter daCTHD;
        /// <summary>
        /// 
        /// </summary>
        public CTHDDAL()
        {
            daCTHD = new SqlDataAdapter("select * from CHITIETHD", conn);
            LoadBangCTHD();
        }

        public DataTable LoadBangCTHD()
        {
            // Ánh xạ dữ liệu từ DB vào dataset
            daCTHD.Fill(ds_CTHD, "CHITIETHD");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[2];

            khoachinh[0] = ds_CTHD.Tables["CHITIETHD"].Columns[0];
            khoachinh[1] = ds_CTHD.Tables["CHITIETHD"].Columns[1];

            ds_CTHD.Tables["CHITIETHD"].PrimaryKey = khoachinh;

            return ds_CTHD.Tables["CHITIETHD"];
        }

        public DataTable LoadBangTenSach()
        {
            SqlDataAdapter daSH = new SqlDataAdapter(" select * from SACH ", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên SinhVien
            daSH.Fill(ds_CTHD, "SACH");

            return ds_CTHD.Tables["SACH"];
        }

        public int KiemTra(string maHD, string maSH)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "select * from CHITIETHD where MAHD='" + maHD + "' and MASH='" + maSH + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            int kq = 0;
            while (dr.Read())
            {
                kq = 1;
            }

            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }

        public int ThemCTHD(string pMaHD, string pMaSH,string pSoLuong,float pDonGia)
        {
            try
            {
                if (KiemTra(pMaHD, pMaSH) == 1)
                    return 2;

                DataRow dtThem = ds_CTHD.Tables["CHITIETHD"].NewRow();
                dtThem[0] = pMaHD;
                dtThem[1] = pMaSH;
                dtThem[2] = pSoLuong;
                dtThem[3] = pDonGia;


                ds_CTHD.Tables["CHITIETHD"].Rows.Add(dtThem);

                SqlCommandBuilder builda = new SqlCommandBuilder(daCTHD);

                daCTHD.Update(ds_CTHD, "CHITIETHD");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Sua(string maHD,string maSH,string soLuong,float donGia)
        {
            daCTHD = new SqlDataAdapter("select * from CHITIETHD", conn);

            DataRow dtKiemTra = ds_CTHD.Tables["CHITIETHD"].Rows.Find(maHD);
            if (dtKiemTra != null)
            {
                dtKiemTra["MAHD"] = maHD;
                dtKiemTra["MASH"] = maSH;
                dtKiemTra["SOLUONG"] = soLuong;
                dtKiemTra["DONGIA"] = donGia;

                SqlCommandBuilder builda = new SqlCommandBuilder(daCTHD);
                daCTHD.Update(ds_CTHD, "CHITIETHD");
                return 1;
            }
            return 0;
        }

        public int Xoa(string pMaHD,string pMaSH)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql = "delete from CHITIETHD where MAHD=N'" + pMaHD + "' and MASH=N'" + pMaSH + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
               

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int luu()
        {
            SqlCommandBuilder duilda = new SqlCommandBuilder(daCTHD);
            //daKH.Fill(ds_KH, "KHACHHANG"); 
            daCTHD.Update(ds_CTHD, "CHITIETHD");
            return 1;
        }
















        //public DataSet ds_CTHD = new DataSet();
        //public SqlDataAdapter daCTHD;
        ///// <summary>
        ///// 
        ///// </summary>
        //public CTHDDAL()
        //{
        //    daCTHD = new SqlDataAdapter("select * from CHITIETHD", conn);
        //    LoadBangCTHD();
        //}


        //public DataTable LoadBangTenSach()
        //{
        //    SqlDataAdapter daSH = new SqlDataAdapter(" select * from SACH ", conn);
        //    // Ánh xạ dữ liệu từ DB vào dataset, đặt tên SinhVien
        //    daSH.Fill(ds_CTHD, "SACH");

        //    return ds_CTHD.Tables["SACH"];
        //}
        //public DataTable LoadBangCTHD()
        //{
        //    // Ánh xạ dữ liệu từ DB vào dataset, đặt tên S
        //    daCTHD.Fill(ds_CTHD, "CHITIETHD");
        //    ////////Set Khóa chính
        //    DataColumn[] khoachinh = new DataColumn[2];

        //    khoachinh[0] = ds_CTHD.Tables["CHITIETHD"].Columns[0];
        //    khoachinh[1] = ds_CTHD.Tables["CHITIETHD"].Columns[1];

        //    ds_CTHD.Tables["CHITIETHD"].PrimaryKey = khoachinh;

        //    return ds_CTHD.Tables["CHITIETHD"];
        //}

        ////public DataTable LoadBangHD_GhepBang()
        ////{
        ////    SqlDataAdapter daHD_ghepbang = new SqlDataAdapter("select hd.MAHD,hd.NGAYLAP,kh.MAKH,kh.HOTEN,hd.TONGTIEN,nv.MANV,nv.HOTENNV,ct.MASH,sh.TENSH,ct.SOLUONG,ct.DONGIA  from HOADON hd,SACH sh,KHACHHANG kh,NHANVIEN nv,CHITIETHD ct where hd.MAKH=kh.MAKH and hd.MANV=nv.MANV and ct.MASH=sh.MASH and ct.MAHD=hd.MAHD", conn);
        ////    // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
        ////    daHD_ghepbang.Fill(ds_CTHD, "HD_CT_NV_SH_KH");
        ////    return ds_CTHD.Tables["HD_CT_NV_SH_KH"];
        ////}

        //public bool KTKC(string pMaHD)
        //{
        //    DataRow dtKiemTra = ds_CTHD.Tables["CHITIETHD"].Rows.Find(pMaHD);

        //    if (dtKiemTra != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool KTKC2(string pMaSH)
        //{
        //    DataRow dtKiemTra = ds_CTHD.Tables["CHITIETHD"].Rows.Find(pMaSH);

        //    if (dtKiemTra != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

       

        //public int ThemCTHD(string pMaHD, string pMaSH, string pSoLuong, float pDonGia)
        //{
        //    try
        //    {
        //        //if (KTKC(pMaHD) == true && KTKC2(pMaSH) == true)
        //        if (KiemTra(pMaHD,pMaSH)==1)
        //            return 2;

        //        DataRow dtThem = ds_CTHD.Tables["CHITIETHD"].NewRow();
        //        dtThem["MAHD"] = pMaHD;
        //        dtThem["MASH"] = pMaSH;
        //        dtThem["SOLUONG"] = pSoLuong;
        //        dtThem["DONGIA"] = pDonGia;

        //        ds_CTHD.Tables["CHITIETHD"].Rows.Add(dtThem);

        //        SqlCommandBuilder builda = new SqlCommandBuilder(daCTHD);

        //        daCTHD.Update(ds_CTHD, "CHITIETHD");
        //        return 1;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}
        //public void Sua()
        //{

        //}
        //public void Xoa()
        //{

        //}

        //public int luu()
        //{
        //    SqlCommandBuilder duilda = new SqlCommandBuilder(daCTHD);
        //    //daKH.Fill(ds_KH, "CHITIETHD"); 
        //    daCTHD.Update(ds_CTHD, "CHITIETHD");
        //    return 1;
        //}

    }
}
