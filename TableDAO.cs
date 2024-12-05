using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 90;
        public static int TableHeight =90;
        private TableDAO() { }
        public void SwitchTable(int ban_ID1, int ban_ID2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @Ban_ID1 , @Ban_ID2",new object[] {ban_ID1,ban_ID2});
        }
        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Ban");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
    }
}
