using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class MenuDAO
    {
        private static MenuDAO instance;


        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetlistMenuByTable(int ban_id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT du.TenDoUong,ct.SoLuong,du.Gia,du.Gia*ct.SoLuong AS ThanhTien FROM ChiTietHoaDon AS ct,HoaDon AS hd, DoUong AS du WHERE ct.HoaDon_ID=hd.HoaDon_ID AND ct.DoUong_ID=du.DoUong_ID AND hd.TinhTrang = 0 AND hd.Ban_ID = " + ban_id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu); 
            }
            return listMenu;
        }
    }
}
