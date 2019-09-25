using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Doan
{
    public class connect
    {
        public SqlConnection conn;
        public connect()
        {
            string sql = @"Data Source=DESKTOP-MEPOI64\SQLEXPRESS;Initial Catalog=quanlynhasach;User ID=sa;Password=sa2012";
            conn = new SqlConnection(sql);
        }
        public bool KTKC_New(string pKhoaChinh, DataTable pdt)
        {
            DataRow dtKiemTra = pdt.Rows.Find(pKhoaChinh);//cai này false lắm viết trong kia luon .xài sqlconect khác ,xong sqlcommand .coi bai tao di .tao về cái uk  taov có 62 vieêiết cai này ròi
            //xem đi


            if (dtKiemTra != null)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
       
    }
}
