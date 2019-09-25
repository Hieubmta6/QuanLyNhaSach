using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Doan.Class
{
    public class KHDAL : connect
    {
        public DataSet ds_KH = new DataSet();
        public SqlDataAdapter daKH;
        /// <summary>
        /// 
        /// </summary>
        public KHDAL()
        {
            daKH = new SqlDataAdapter("select * from KHACHHANG", conn);
            LoadBangKH();
        }

        public DataTable LoadBangKH()
        {
            // Ánh xạ dữ liệu từ DB vào dataset
            daKH.Fill(ds_KH, "KHACHHANG");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = ds_KH.Tables["KHACHHANG"].Columns[0];

            ds_KH.Tables["KHACHHANG"].PrimaryKey = khoachinh;

            return ds_KH.Tables["KHACHHANG"];
        }

        public bool KTKC(string pMaKH)
        {
            DataRow dtKiemTra = ds_KH.Tables["KHACHHANG"].Rows.Find(pMaKH);

            if (dtKiemTra != null)
            {
                return true;
            }
            else
            {
                return false;
            }
           // return KTKC_New(pMaSV, ds_SinhVien.Tables["SinhVien"]);
        }

        public int Them(string pMaKH, string pHoTen, string pNgaySinh, string pGioiTinh, string pDiaChi, string pDienThoai)
        {
            try
            {
                if (KTKC(pMaKH) == true)
                    return 2;

                DataRow dtThem = ds_KH.Tables["KHACHHANG"].NewRow();
                dtThem[0] = pMaKH;
                dtThem[1] = pHoTen;
                dtThem[2] = pNgaySinh;
                dtThem[3] = pGioiTinh;
                dtThem[4] = pDiaChi;
                dtThem[5] = pDienThoai;


                ds_KH.Tables["KHACHHANG"].Rows.Add(dtThem);

                SqlCommandBuilder builda = new SqlCommandBuilder(daKH);

                daKH.Update(ds_KH, "KHACHHANG");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int luu()
        {
            SqlCommandBuilder duilda = new SqlCommandBuilder(daKH);
            //daKH.Fill(ds_KH, "KHACHHANG"); 
            daKH.Update(ds_KH, "KHACHHANG");
            return 1;
        }


        public int Sua(string maKH,string hoTen,string ngaySinh,string gioiTinh,string diaChi,string dienThoai)
        {
            daKH = new SqlDataAdapter("select * from KHACHHANG", conn);

            DataRow dtKiemTra = ds_KH.Tables["KHACHHANG"].Rows.Find(maKH);
            if (dtKiemTra != null)
            {
                dtKiemTra["HOTEN"] = hoTen;
                dtKiemTra["NGAYSINH"] = ngaySinh;
                dtKiemTra["GIOITINH"] = gioiTinh;
                dtKiemTra["DIACHI"] = diaChi;
                dtKiemTra["DTKH"] = dienThoai;

                SqlCommandBuilder builda = new SqlCommandBuilder(daKH);
                daKH.Update(ds_KH, "KHACHHANG");
                return 1;
            }
            return 0;
        }


        public int Xoa(string maKH)
        {         
                DataRow dtKiemTra = ds_KH.Tables["KHACHHANG"].Rows.Find(maKH);
                if (dtKiemTra != null)
                {
                    dtKiemTra.Delete();
                    return 1;
                }       
                return 0;           
        }

        //public int DemSV(string pMaLop)
        //{
        // //   int dem=0;
        // //for(int i=0;i< ds_SinhVien.Tables["SinhVien"].Rows.Count;i++)
        // //{
        // //    if (ds_SinhVien.Tables["SinhVien"].Rows[i][3].ToString() == pMaLop)
        // //        dem++;
        // //}
        // //return dem;

        //    SqlDataAdapter daDem = new SqlDataAdapter("select * from SinhVien where MaLop='"+pMaLop+"'", conn);
        //    // Ánh xạ dữ liệu từ DB vào dataset, đặt tên SinhVien
        //  ///  DataTable dt = new DataTable();

        //    daDem.Fill(ds_SinhVien,"DemSV");

        //    return ds_SinhVien.Tables["DemSV"].Rows.Count;

        //}

    }
}
