using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
     public class Menu
    {
        public Menu(string tenDoUong,int soLuong,float gia,float thanhTien = 0) 
        { 
            this.TenDoUong = tenDoUong;
            this.SoLuong = soLuong;
            this.Gia = gia;
            this.ThanhTien = thanhTien;
        }
        public Menu(DataRow row)
        {
            this.TenDoUong = row["tenDoUong"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.Gia =(float)Convert.ToDouble(row["gia"].ToString());
            this.ThanhTien =(float)Convert.ToDouble(row["thanhTien"].ToString());

        }
        private float thanhTien;
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value;}
        }
        private float gia;
        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private string tenDoUong;
        public string TenDoUong
        {
            get { return tenDoUong; }
            set { tenDoUong = value; }
        }
    }
}
