using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Class
{
    class Class_Tacgia:connect
    {
        public DataSet ds_tg = new DataSet();
        public SqlDataAdapter da_tg;
        public Class_Tacgia()
        {

        }
        public DataTable LoadTacgia()
        {
            da_tg = new SqlDataAdapter("select * from TACGIA", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_tg.Fill(ds_tg, "TACGIA");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_tg.Tables["TACGIA"].Columns[0];
            ds_tg.Tables["TACGIA"].PrimaryKey = khoachinh;
            return ds_tg.Tables["TACGIA"];
        }
        public bool KTKC(string pMatg)
        {
            return KTKC_New(pMatg, ds_tg.Tables["TACGIA"]);
        }
        public int them(string pMatg, string pTentg)
        {
            try
            {

                da_tg = new SqlDataAdapter("select * from TACGIA", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_tg.Fill(ds_tg, "TACGIA");

                if (KTKC(pMatg) == true)
                {
                    return 2;
                }
                else
                {
                    DataRow dtThem = ds_tg.Tables["TACGIA"].NewRow();
                    dtThem[0] = pMatg;
                    dtThem[1] = pTentg;
                    ds_tg.Tables["TACGIA"].Rows.Add(dtThem);
                    SqlCommandBuilder builda = new SqlCommandBuilder(da_tg);
                    da_tg.Update(ds_tg, "TACGIA");
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int xoa(string pMatg)
        {
            try
            {

                da_tg = new SqlDataAdapter("select * from TACGIA", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_tg.Tables["TACGIA"].Rows.Find(pMatg);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_tg);
                da_tg.Update(ds_tg, "TACGIA");
                return 1;

            }
            catch
            {
                return 0;
            }
        }
        public int sua(string pMatg, string pTentg)
        {
            try
            {

                da_tg = new SqlDataAdapter("select * from TACGIA", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_tg.Tables["TACGIA"].Rows.Find(pMatg);
                if (dts != null)
                {
                    dts[1] = pTentg;
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_tg);
                da_tg.Update(ds_tg, "TACGIA");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
