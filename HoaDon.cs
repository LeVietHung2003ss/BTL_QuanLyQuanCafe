using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class HoaDon
    {
        public HoaDon(int hoaDon_ID,DateTime?ngayLap,DateTime?ngayKiemTra,int tinhTrang) 
        {
            this.HoaDon_ID = hoaDon_ID;
            this.NgayLap = ngayLap;
            this.NgayKiemTra = ngayKiemTra;
            this.TinhTrang = tinhTrang;
        }
        public HoaDon(DataRow row)
        {
            this.HoaDon_ID = (int)row["hoaDon_ID"];
            this.NgayLap = (DateTime?)row["ngayLap"];
            var ngayKiemTraTemp = row["ngayKiemTra"];
            if (ngayKiemTraTemp.ToString() != "")
                this.NgayKiemTra = (DateTime?)ngayKiemTraTemp;
            this.TinhTrang = (int)row["tinhTrang"];
        }

        private int tinhTrang;
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        private DateTime? ngayKiemTra;
        public DateTime? NgayKiemTra
        {
            get { return ngayKiemTra; }
            set { ngayKiemTra = value; }
        }
        private DateTime? ngayLap;
        public DateTime? NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        private int hoaDon_ID;
		public int HoaDon_ID
		{
			get { return hoaDon_ID; }
			set { hoaDon_ID = value; }
		}

       
    }
}
