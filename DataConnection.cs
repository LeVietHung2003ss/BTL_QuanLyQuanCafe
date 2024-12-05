using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    internal class DataConnection
    {
        string chuoiketnoi;
        public DataConnection()
        {
            chuoiketnoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe_1;Integrated Security=True" ;
        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(chuoiketnoi);
        }
    }
}
