using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class ListDoUongDAO
    {
        private static ListDoUongDAO instance;
        public static ListDoUongDAO Instance
        {
            get { if (instance == null) instance = new ListDoUongDAO(); return ListDoUongDAO.instance; }
            private set { ListDoUongDAO.instance = value; }
        }
        private ListDoUongDAO() { }
        public List<ListDoUong> getListtblDuongBytblLDuong(int loaiDoUong_ID)
        {
            List<ListDoUong> list = new List<ListDoUong>();
            string query = "select * from DoUong where LoaiDoUong_ID =" + loaiDoUong_ID;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ListDoUong tblduong = new ListDoUong(item);
                list.Add(tblduong);
            }
            return list;
        }
    }
}
