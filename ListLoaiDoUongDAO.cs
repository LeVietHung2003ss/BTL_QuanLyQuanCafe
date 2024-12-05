using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class ListLoaiDoUongDAO
    {
        private static ListLoaiDoUongDAO instance;
        public static ListLoaiDoUongDAO Instance
        {
            get { if (instance == null) instance = new ListLoaiDoUongDAO(); return ListLoaiDoUongDAO.instance; }
            private set { ListLoaiDoUongDAO.instance = value; }
        }
        private ListLoaiDoUongDAO() { }
        public List<ListLoaiDoUong> getListtblLDuong()
        {
            List<ListLoaiDoUong> list = new List<ListLoaiDoUong>();
            string query = "select * from LoaiDoUong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ListLoaiDoUong tbllduong = new ListLoaiDoUong(item);
                list.Add(tbllduong);
            }
            return list;
        }
    }
}
