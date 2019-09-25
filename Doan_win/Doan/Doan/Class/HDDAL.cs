using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Doan.Class
{
    class HDDAL : connect
    {
        public DataSet ds_HD = new DataSet();
       // public DataSet ds_HD2 = new DataSet();
        public SqlDataAdapter daHD;
       // public SqlDataAdapter daCTHD;
       // public DataTable tb=new DataTable("HOADON");

        public HDDAL()
        {
            daHD = new SqlDataAdapter("select * from HOADON", conn);
           // daCTHD = new SqlDataAdapter("select * from CHITIETHD", conn);
            LoadBangHD();
           // LoadBangCTHD();
        }

        //load du lieu
        public DataTable LoadBangHD()
        {
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên S
            daHD.Fill(ds_HD, "HOADON");
            ////////Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = ds_HD.Tables["HOADON"].Columns[0];

            ds_HD.Tables["HOADON"].PrimaryKey = khoachinh;

            return ds_HD.Tables["HOADON"];
        }

        //public DataTable LoadBangCTHD()
        //{
        //    // Ánh xạ dữ liệu từ DB vào dataset, đặt tên S
        //    daCTHD.Fill(ds_HD, "CHITIETHD");
        //    ////////Set Khóa chính
        //    DataColumn[] khoachinh1 = new DataColumn[2];

        //    khoachinh1[0] = ds_HD.Tables["CHITIETHD"].Columns[0];
        //    khoachinh1[1] = ds_HD.Tables["CHITIETHD"].Columns[1];

        //    ds_HD.Tables["CHITIETHD"].PrimaryKey = khoachinh1;

        //    return ds_HD.Tables["CHITIETHD"];
        //}


        public DataTable LoadBangHD_GhepBang()
        {
            SqlDataAdapter daHD_ghepbang = new SqlDataAdapter("select hd.MAHD,hd.NGAYLAP,kh.MAKH,kh.HOTEN,hd.TONGTIEN,nv.MANV,nv.HOTENNV  from HOADON hd,KHACHHANG kh,NHANVIEN nv where hd.MAKH=kh.MAKH and hd.MANV=nv.MANV  ", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            daHD_ghepbang.Fill(ds_HD, "HD_CT_NV_SH_KH");
            return ds_HD.Tables["HD_CT_NV_SH_KH"];
        }



        public DataTable LoadBangKhachHang()
        {
            SqlDataAdapter daKH = new SqlDataAdapter(" select * from KHACHHANG ", conn);
            daKH.Fill(ds_HD, "KHACHHANG");

            return ds_HD.Tables["KHACHHANG"];
        }

        public DataTable LoadBangNhanVien()
        {
            SqlDataAdapter daNV = new SqlDataAdapter(" select * from NHANVIEN ", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên SinhVien
            daNV.Fill(ds_HD, "NHANVIEN");

            return ds_HD.Tables["NHANVIEN"];
        }

        public DataTable LoadBangTenSach()
        {
            SqlDataAdapter daSH = new SqlDataAdapter(" select * from SACH ", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên SinhVien
            daSH.Fill(ds_HD, "SACH");

            return ds_HD.Tables["SACH"];
        }

        public DataTable LoadBangGiaTien()
        {
            SqlDataAdapter daSH = new SqlDataAdapter(" select MASH,GIATIEN from SACH ", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên SinhVien
            daSH.Fill(ds_HD, "SACH");

            return ds_HD.Tables["SACH"];
        }

        public bool KTKC_HD(string pMaHD)
        {
            DataRow dtKiemTra = ds_HD.Tables["HOADON"].Rows.Find(pMaHD);

            if (dtKiemTra != null)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }  

        public int ThemHD2(string pMaHD, string pMaKH, string pNgayLap, string pMaNV)
        {
            try
            {
                if (KTKC_HD(pMaHD) == true)
                {
                    return 2;
                }
                //them hoa don vao gridview
                daHD = new SqlDataAdapter("select * from HOADON", conn);
                DataRow dtThem = ds_HD.Tables["HOADON"].NewRow();
                dtThem["MAHD"] = pMaHD;
                dtThem["NGAYLAP"] = pNgayLap;
                dtThem["MAKH"] = pMaKH;
                dtThem["TONGTIEN"] = 0;
                dtThem["MANV"] = pMaNV;

                ds_HD.Tables["HOADON"].Rows.Add(dtThem);
                SqlCommandBuilder builda = new SqlCommandBuilder(daHD);
                daHD.Update(ds_HD, "HOADON");

                return 1;      
            }
            catch
            {
                return 0;
            }
        }

        public int tinhTongTien(string pMaHD,string pSoLuong,float pDonGia)
        {
            daHD = new SqlDataAdapter("select * from HOADON", conn);
            DataRow dr = ds_HD.Tables["HOADON"].Rows.Find(pMaHD);
            if (dr != null)
            {
                dr["TONGTIEN"]=float.Parse(dr["TONGTIEN"].ToString()) + pDonGia * float.Parse(pSoLuong);
            }
            //ds_HD.Tables["HOADON"].Rows.Add(dr);
            SqlCommandBuilder builda = new SqlCommandBuilder(daHD);
            daHD.Update(ds_HD, "HOADON");

            return 1;     
        }

        public int tinhTongTienXoa(string pMaHD, string pSoLuong, float pDonGia)
        {
            daHD = new SqlDataAdapter("select * from HOADON", conn);
            DataRow dr = ds_HD.Tables["HOADON"].Rows.Find(pMaHD);
            if (dr != null)
            {
                dr["TONGTIEN"] = float.Parse(dr["TONGTIEN"].ToString()) - pDonGia * float.Parse(pSoLuong);
            }
            //ds_HD.Tables["HOADON"].Rows.Add(dr);
            SqlCommandBuilder builda = new SqlCommandBuilder(daHD);
            daHD.Update(ds_HD, "HOADON");

            return 1;
        }

        public int Sua(string pMaHD,string pNgayLap,string pMaKH,string pMaNV)
        {
            daHD = new SqlDataAdapter("select * from HOADON", conn);

            DataRow dtKiemTra = ds_HD.Tables["HOADON"].Rows.Find(pMaHD);
            
            if (dtKiemTra != null)
            {
                dtKiemTra["MAHD"] = pMaHD;
                dtKiemTra["NGAYLAP"] = pNgayLap;
                dtKiemTra["MAKH"] = pMaKH;
                dtKiemTra["MANV"] = pMaNV;

                SqlCommandBuilder builda = new SqlCommandBuilder(daHD);
                daHD.Update(ds_HD, "HOADON");
                return 1;
            }
            return 0;
        }

        public int luu()
        {
            SqlCommandBuilder duilda = new SqlCommandBuilder(daHD);
            //daKH.Fill(ds_KH, "KHACHHANG"); 
            daHD.Update(ds_HD, "HOADON");
            return 1;
        }

        public int Xoa(string pMaHD)
        {
            try
            {

                daHD = new SqlDataAdapter("select * from HOADON", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_HD.Tables["HOADON"].Rows.Find(pMaHD);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(daHD);
                daHD.Update(ds_HD, "HOADON");
                return 1;

            }
            catch
            {
                return 0;
            }
        }
    }
}
