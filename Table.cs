using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public class Table
    {
        public Table(int ban_ID, string tenBan, string tinhTrang)
        {
            this.Ban_ID = ban_ID;
            this.TenBan = tenBan;
            this.TinhTrang = tinhTrang;
        }

        public int ban_ID;
        public int Ban_ID
        {
            get { return ban_ID; }
            set { ban_ID = value; }
        }
        public string tenBan;
        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }
        public string tinhTrang;
        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public Table(DataRow row)
        {
            this.Ban_ID = (int)row["ban_ID"];
            this.TenBan = row["tenBan"].ToString();
            this.TinhTrang = row["tinhTrang"].ToString();
        }
    }
}
