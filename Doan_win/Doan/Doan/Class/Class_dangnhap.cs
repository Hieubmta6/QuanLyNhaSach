using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Doan.Class
{
    public class Class_dangnhap:connect
    {
        public DataSet ds_PhanQuyen = new DataSet();
        public SqlDataAdapter daPhanQuyen;
        public Class_dangnhap()
        {
            daPhanQuyen = new SqlDataAdapter("select * from TAIKHOAN",conn);
        }
        public int layQuyen(string MAND)
        {
            daPhanQuyen = new SqlDataAdapter("select QUYEN from TAIKHOAN where PASSWORK=N'" + MAND + "'", conn);
            daPhanQuyen.Fill(ds_PhanQuyen, "TAIKHOAN");
            string an = " ";
            //if (ds_PhanQuyen.Tables["TAIKHOAN"].Rows.Count > 0)
                an= ds_PhanQuyen.Tables["TAIKHOAN"].ToString();
            if (an == "admin")
            {
                return 1;
            }
            return 0;
        }
        
    }
}
