using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class ListLoaiDoUong
    {
        public ListLoaiDoUong(int loaiDoUong_ID, string loaiDoUong)
        {
            this.LoaiDoUong_ID = loaiDoUong_ID;
            this.LoaiDoUong = loaiDoUong;
        }
        public ListLoaiDoUong(DataRow row)
        {
            this.LoaiDoUong_ID = (int)row["loaiDoUong_ID"];
            this.LoaiDoUong = row["loaiDoUong"].ToString();
        }
        private int loaiDoUong_ID;
        public int LoaiDoUong_ID
        {
            get { return loaiDoUong_ID; }
            set { loaiDoUong_ID = value; }
        }
        private string loaiDoUong;
        public string LoaiDoUong
        {
            get { return loaiDoUong; }
            set { loaiDoUong = value; }
        }
    }
}
