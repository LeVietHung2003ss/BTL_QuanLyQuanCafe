using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    internal class BLL
    {
        DAL_themsuaxoa dal;
        public BLL()
        {
            dal = new DAL_themsuaxoa();
        }
        //Bàn ăn-----------------------------------------------
        public DataTable GetallBanan()
        {
            return dal.GetallBanan();
        }
        public bool InsertBanan(tblBanan ba)
        {
            return dal.InsertBanan(ba);
        }
        public bool UpdateBanan(tblBanan ba)
        {
            return dal.UpdateBanan(ba);
        }
        public bool DeleteBanan(tblBanan ba)
        {
            return dal.DeleteBanan(ba);
        }
        //Loại đồ uống-------------------------------------------------
        public DataTable GetallLDuong()
        {
            return dal.GetallLDuong();
        }
        public bool InsertLDuong(tblLDuong LDU)
        {
            return dal.InsertLDuong(LDU);
        }
        public bool UpdateLDuong(tblLDuong LDU)
        {
            return dal.UpdateLDuong(LDU);
        }
        public bool DeleteLDuong(tblLDuong LDU)
        {
            return dal.DeleteLDuong(LDU);
        }
        //Đồ uống-------------------------------------------------
        public DataTable GetallDuong()
        {
            return dal.GetallDuong();
        }
        public bool InsertDuong(tblDuong DU)
        {
            return dal.InsertDuong(DU);
        }
        public bool UpdateDuong(tblDuong DU)
        {
            return dal.UpdateDuong(DU);
        }
        public bool DeleteDuong(tblDuong DU)
        {
            return dal.DeleteDuong(DU);
        }
        public DataTable TimDuong(string DB) 
        {
            return dal.TimDuong(DB);
        }
    }
}
