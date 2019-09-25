using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Class
{
    class Class_NXB:connect
    {
        public DataSet ds_nxb = new DataSet();
        public SqlDataAdapter da_nxb;
        public Class_NXB()
        {

        }
         public DataTable LoadNhaxuatban()
        {
            da_nxb = new SqlDataAdapter("select * from NHAXUATBAN", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_nxb.Fill(ds_nxb, "NHAXUATBAN");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_nxb.Tables["NHAXUATBAN"].Columns[0];
            ds_nxb.Tables["NHAXUATBAN"].PrimaryKey = khoachinh;
            return ds_nxb.Tables["NHAXUATBAN"];
        }
        public bool KTKC(string pManxb)
        {
            return KTKC_New(pManxb, ds_nxb.Tables["NHAXUATBAN"]);
        }
        public int them(string pManxb, string pTennxb, string pDcnxb, string pDtnxb)
        {
            try
            {

                da_nxb = new SqlDataAdapter("select * from NHAXUATBAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_nxb.Fill(ds_nxb, "NHAXUATBAN");

                if (KTKC(pManxb) == true)
                {
                    return 2;
                }
                else
                {
                    DataRow dtThem = ds_nxb.Tables["NHAXUATBAN"].NewRow();
                    dtThem[0] = pManxb;
                    dtThem[1] = pTennxb;
                    dtThem[2] = pDcnxb;
                    dtThem[3] = pDtnxb;
                    ds_nxb.Tables["NHAXUATBAN"].Rows.Add(dtThem);
                    SqlCommandBuilder builda = new SqlCommandBuilder(da_nxb);
                    da_nxb.Update(ds_nxb, "NHAXUATBAN");
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int xoa(string pManxb)
        {
            try
            {

                da_nxb = new SqlDataAdapter("select * from NHAXUATBAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_nxb.Tables["NHAXUATBAN"].Rows.Find(pManxb);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_nxb);
                da_nxb.Update(ds_nxb, "NHAXUATBAN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int sua(string pManxb, string pTennxb, string pDcnxb, string pDtnxb)
        {
            try
            {

                da_nxb = new SqlDataAdapter("select * from NHAXUATBAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_nxb.Tables["NHAXUATBAN"].Rows.Find(pManxb);
                if (dts != null)
                {
                    dts[1] = pTennxb;
                    dts[2] = pDcnxb;
                    dts[3] = pDtnxb;
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_nxb);
                da_nxb.Update(ds_nxb, "NHAXUATBAN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
