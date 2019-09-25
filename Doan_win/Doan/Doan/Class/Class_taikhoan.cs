using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Class
{
    class Class_taikhoan:connect
    {
        public DataSet ds_TK = new DataSet();
        public SqlDataAdapter da_TK;
        public Class_taikhoan()
        {

        }
        public DataTable Loadtk()
        {
            da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_TK.Fill(ds_TK, "TAIKHOAN");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_TK.Tables["TAIKHOAN"].Columns[0];
            ds_TK.Tables["TAIKHOAN"].PrimaryKey = khoachinh;
            return ds_TK.Tables["TAIKHOAN"];
        }
        public bool KTKC(string pManv)
        {
            return KTKC_New(pManv, ds_TK.Tables["TAIKHOAN"]);
        }
        public int themtk(string pManv, string pquyen, string ptentaikhoan, string pmk, string pngaylap)
        {
            try
            {

                da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_TK.Fill(ds_TK, "TAIKHOAN");
                DataRow dtThem = ds_TK.Tables["TAIKHOAN"].NewRow();
                dtThem[0] = pManv;
                dtThem[1] = pquyen;
                dtThem[2] = ptentaikhoan;
                dtThem[3] = pmk;
                dtThem[4] = pngaylap;
                ds_TK.Tables["TAIKHOAN"].Rows.Add(dtThem);
                SqlCommandBuilder builda = new SqlCommandBuilder(da_TK);
                da_TK.Update(ds_TK, "TAIKHOAN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int sua(string pma, string pquyen, string pmk)
        {
            try
            {

                da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_TK.Tables["TAIKHOAN"].Rows.Find(pma);
                if (dts != null)
                {
                    dts[1] = pquyen;
                    dts[3] = pmk;         
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_TK);
                da_TK.Update(ds_TK, "TAIKHOAN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int xoa(string pMatk)
        {
            

                da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_TK.Tables["TAIKHOAN"].Rows.Find(pMatk);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_TK);
                da_TK.Update(ds_TK, "TAIKHOAN");
                return 1;

            
        }
         
    }
}
