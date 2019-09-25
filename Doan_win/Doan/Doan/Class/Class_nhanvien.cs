using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Doan.Class
{
    class Class_nhanvien:connect
    {
        public DataSet ds_nv = new DataSet();
        public SqlDataAdapter da_nv;
        public Class_nhanvien()
        {
            Loadnv();
        }
        public DataTable Loadnv()
        {
            da_nv = new SqlDataAdapter("select * from NHANVIEN", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_nv.Fill(ds_nv, "NHANVIEN");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_nv.Tables["NHANVIEN"].Columns[0];
            ds_nv.Tables["NHANVIEN"].PrimaryKey = khoachinh;
            return ds_nv.Tables["NHANVIEN"];
        }
        public bool KTKC(string pManv)
        {
            return KTKC_New(pManv, ds_nv.Tables["NHANVIEN"]);
        }
        public int them(string pManv, string pTennv,string pngaysinh, string pngayvaolam, string pmnql,string pgt, string pdc, string pcv, float pluong)
        {
        //    try
        //    {

                da_nv = new SqlDataAdapter("select * from NHANVIEN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_nv.Fill(ds_nv, "NHANVIEN");

                if (KTKC(pManv) == true)
                {
                    return 2;
                }
                else
                {
                    DataRow dtThem = ds_nv.Tables["NHANVIEN"].NewRow();
                    dtThem[0] = pManv;
                    dtThem[1] = pTennv;
                    dtThem[2] = pngaysinh;
                    dtThem[3] = pngayvaolam;
                    dtThem[4] = pgt;
                    dtThem[5] = pdc;
                    dtThem[6] = pluong;
                    dtThem[7] = pcv;
                    dtThem[8] = pmnql;
                    ds_nv.Tables["NHANVIEN"].Rows.Add(dtThem);
                    SqlCommandBuilder builda = new SqlCommandBuilder(da_nv);
                    da_nv.Update(ds_nv, "NHANVIEN");
                    return 1;
                }
            //}
            //catch
            //{
            //    return 0;
            //}
        }
        public int xoa(string pManv)
        {
            try
            {
                da_nv = new SqlDataAdapter("select * from NHANVIEN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_nv.Tables["NHANVIEN"].Rows.Find(pManv);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_nv);
                da_nv.Update(ds_nv, "NHANVIEN");
                return 1;
               

            }
            catch
            {
                return 0;
            }
        }
        public int sua(string pManv, string pTennv, string pngaysinh, string pngayvaolam, string pmnql, string pgt, string pdc, string pcv, float pluong)
        {
            try
            {

                da_nv = new SqlDataAdapter("select * from NHANVIEN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_nv.Tables["NHANVIEN"].Rows.Find(pManv);
                if (dts != null)
                {
                    dts[1] = pTennv;
                    dts[2] = pngaysinh;
                    dts[3] = pngayvaolam;
                    dts[4] = pgt;
                    dts[5] = pdc;
                    dts[6] = pluong;
                    dts[7] = pcv;
                    dts[8] = pmnql;
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_nv);
                da_nv.Update(ds_nv, "NHANVIEN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int luu()
        {
            SqlCommandBuilder duilda = new SqlCommandBuilder(da_nv);
            da_nv.Update(ds_nv, "NHANVIEN");
            return 1;
        }
    }
}
