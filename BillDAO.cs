using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class BillDAO
    {
        private static BillDAO instance;
		

		public static BillDAO Instance
		{
			get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
			private set { BillDAO.instance = value; }
		}
		private BillDAO() { }
		// thành công HoaDon_ID;
		// thất bại trả về null;
		public int GetHoaDonByBanID(int ban_ID)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("select * from HoaDon where Ban_ID=" + ban_ID + " AND TinhTrang=0");
			if(data.Rows.Count > 0)
			{
				HoaDon hoadon = new HoaDon(data.Rows[0]);
				return hoadon.HoaDon_ID;
			}
			return -1;
		} 
		public void CheckOut(int hoadon_id)
		{
			string query = "UPDATE HoaDon SET TinhTrang = 1 WHERE HoaDon_ID = "+hoadon_id;
			DataProvider.Instance.ExecuteNonQuery(query);

		}
		public void InsertHoaDon(int ban_id)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery(" EXEC USP_InsertHoaDon @Ban_ID", new object[] {ban_id});
		}
		public int GetMaxHoaDon()
		{
			try
			{
				return (int)DataProvider.Instance.ExecuteScalar("select MAX(HoaDon_ID) from HoaDon");

			}
			catch
			{
				return 1;
			}
		}
	}
}
