using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;
        public static ChiTietHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonDAO(); return ChiTietHoaDonDAO.instance; }
            private set { ChiTietHoaDonDAO.instance = value; }
        }
        private ChiTietHoaDonDAO() { }
        public List<ChiTietHoaDon>  GetListBillInfo(int hoaDon_ID)
        {
            List<ChiTietHoaDon> listchitiethoadon = new List<ChiTietHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ChiTietHoaDon where HoaDon_ID = "+hoaDon_ID);
            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(item);
                listchitiethoadon.Add(chiTietHoaDon);
            }
            return listchitiethoadon;
        }
        public void InsertChiTietHoaDon(int hoadon_ID,int douong_ID,int soluong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_InsertChiTietHoaDon @HoaDon_ID , @DoUong_ID , @SoLuong", new object[] { hoadon_ID,douong_ID,soluong });
        }
    }
}
