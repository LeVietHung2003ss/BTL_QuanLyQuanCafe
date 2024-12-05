using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(int chiTietHoaDon_ID,int hoaDon_ID,int doUong_ID,int soLuong) 
        {
            this.ChiTietHoaDon_ID=chiTietHoaDon_ID;
            this.HoaDon_ID = hoaDon_ID;
            this.DoUong_ID=doUong_ID;
            this.SoLuong = soLuong;
        }
        public ChiTietHoaDon(DataRow row)
        {
            this.ChiTietHoaDon_ID = (int)row["chiTietHoaDon_ID"];
            this.HoaDon_ID = (int)row["hoaDon_ID"];
            this.DoUong_ID = (int)row["doUong_ID"];
            this.SoLuong = (int)row["soLuong"];
        }
        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private int doUong_ID;
        public int DoUong_ID
        {
            get { return doUong_ID; }
            set { doUong_ID = value;}
        }
        private int hoaDon_ID;
        public int HoaDon_ID
        {
            get { return hoaDon_ID; }
            set { hoaDon_ID = value;}
        }
        private int chiTietHoaDon_ID;
        public int ChiTietHoaDon_ID
        {
            get { return chiTietHoaDon_ID; }
            set { chiTietHoaDon_ID = value; }
        }

    }
}
