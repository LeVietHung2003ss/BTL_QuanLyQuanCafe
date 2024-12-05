using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class ListDoUong
    {
        public ListDoUong(int doUong_ID, string tenDoUong, int loaiDoUong_ID, float gia)
        {
            this.DoUong_ID = doUong_ID;
            this.TenDoUong = tenDoUong;
            this.LoaiDoUong_ID = loaiDoUong_ID;
            this.Gia = gia;
        }
        public ListDoUong(DataRow row)
        {
            this.DoUong_ID = (int)row["doUong_ID"];
            this.TenDoUong = row["tenDoUong"].ToString();
            this.LoaiDoUong_ID = (int)row["loaiDoUong_ID"];
            this.Gia = (float)Convert.ToDouble(row["gia"].ToString());
        }

        private int doUong_ID;
        public int DoUong_ID
        {
            get { return doUong_ID; }
            set { doUong_ID = value; }
        }

        private   string tenDoUong;
        public string TenDoUong
        {
            get { return tenDoUong; }
            set { tenDoUong = value; }
        }
        private int loaiDoUong_ID;
        public int LoaiDoUong_ID
        {
            get { return loaiDoUong_ID; }
            set { loaiDoUong_ID = value; }
        }
        private float gia;
        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
    }
}
