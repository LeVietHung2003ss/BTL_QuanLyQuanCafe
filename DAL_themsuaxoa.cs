using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    internal class DAL_themsuaxoa
    {
        DataConnection ketnoi;
        SqlDataAdapter da;
        SqlCommand cmd;
        public DAL_themsuaxoa()
        {
            ketnoi = new DataConnection();
        }
        //lấy dữ liệu bàn
        public DataTable GetallBanan()
        {
            string sql = "select * from Ban";
            //tạo câu lệnh để lấy toàn bộ đề tài
            SqlConnection con = ketnoi.GetConnect();
            //tạo một kết nối đến sql
            da = new SqlDataAdapter(sql, con);
            //khởi tạo đối tượng của lớp SqlDataAdaper
            con.Open();
            //Mở kết nối
            DataTable dt = new DataTable();
            //Đẩy dữ liệu từ SqlDataAdaper vào DataTable
            da.Fill(dt);
            //đóng kết nối 
            con.Close();
            return dt;
        }
        //lấy dữ liệu loại đồ uống
        public DataTable GetallLDuong()
        {
            string sql = "select * from LoaiDoUong";
            SqlConnection con = ketnoi.GetConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        //lấy dữ liệu đồ uống
        public DataTable GetallDuong()
        {
            string sql = "select DoUong_ID,TenDoUong,Gia from DoUong";
            SqlConnection con = ketnoi.GetConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        //thêm sửa xóa banan----------------------------------------------
        public bool InsertBanan(tblBanan ba)
        {
            string sql = "insert into Ban(Ban_ID, TenBan, TinhTrang) VALUES(@Ban_ID, @TenBan, @TinhTrang)";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Ban_ID", SqlDbType.Int).Value = ba.Ban_ID;
                cmd.Parameters.Add("@TenBan", SqlDbType.NVarChar).Value = ba.TenBan;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = ba.TinhTrang;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateBanan(tblBanan ba)
        {
            string sql = "UPDATE Ban SET TenBan = @TenBan, Tinhtrang = @TinhTrang WHERE Ban_ID = @Ban_ID";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Ban_ID", SqlDbType.Int).Value = ba.Ban_ID;
                cmd.Parameters.Add("@TenBan", SqlDbType.NVarChar).Value = ba.TenBan;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = ba.TinhTrang;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public bool DeleteBanan(tblBanan ba)
        {
            string sql = "DELETE Ban WHERE Ban_ID = @Ban_ID";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Ban_ID", SqlDbType.Int).Value = ba.Ban_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        //--------------------------------------------------------------------------------------------
        //thêm sửa xóa Loại đồ uống
        public bool InsertLDuong(tblLDuong LDU)
        {
            string sql = "insert into LoaiDoUong(LoaiDoUong_ID, LoaiDoUong) VALUES(@LoaiDoUong_ID, @LoaiDoUong)";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@LoaiDoUong_ID", SqlDbType.Int).Value = LDU.LoaiDoUong_ID;
                cmd.Parameters.Add("@LoaiDoUong", SqlDbType.NVarChar).Value = LDU.LoaiDoUong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateLDuong(tblLDuong LDU)
        {
            string sql = "UPDATE LoaiDoUong SET LoaiDoUong = @LoaiDoUong WHERE LoaiDoUong_ID = @LoaiDoUong_ID";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@LoaiDoUong_ID", SqlDbType.Int).Value = LDU.LoaiDoUong_ID;
                cmd.Parameters.Add("@LoaiDoUong", SqlDbType.NVarChar).Value = LDU.LoaiDoUong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public bool DeleteLDuong(tblLDuong LDU)
        {
            string sql = "DELETE LoaiDoUong WHERE LoaiDoUong_ID = @LoaiDoUong_ID";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@LoaiDoUong_ID", SqlDbType.Int).Value = LDU.LoaiDoUong_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        //--------------------------------------------------------------------------------------------
        //thêm sửa xóa tìm kiếm đồ uống
        public bool InsertDuong(tblDuong DU)
        {
            string sql = "insert into DoUong(DoUong_ID, TenDoUong, Gia) VALUES(@DoUong_ID, @TenDoUong, @Gia)";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@DoUong_ID", SqlDbType.Int).Value = DU.DoUong_ID;
                cmd.Parameters.Add("@TenDoUong", SqlDbType.NVarChar).Value = DU.TenDoUong;
                cmd.Parameters.Add("@Gia", SqlDbType.NVarChar).Value = DU.Gia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateDuong(tblDuong DU)
        {
            string sql = "UPDATE DoUong SET TenDoUong = @TenDoUong, Gia = @Gia WHERE DoUong_ID = @DoUong_ID";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@DoUong_ID", SqlDbType.Int).Value = DU.DoUong_ID;
                cmd.Parameters.Add("@TenDoUong", SqlDbType.NVarChar).Value = DU.TenDoUong;
                cmd.Parameters.Add("@Gia", SqlDbType.NVarChar).Value = DU.Gia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public bool DeleteDuong(tblDuong DU)
        {
            string sql = "DELETE DoUong WHERE DoUong_ID = @DoUong_ID";
            SqlConnection con = ketnoi.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@DoUong_ID", SqlDbType.Int).Value = DU.DoUong_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public DataTable TimDuong(string DU)
        {
            string sql = "SELECT DoUong_ID,TenDoUong,Gia FROM DoUong WHERE TenDoUong like N'%" + DU + "%' ";
            SqlConnection con = ketnoi.GetConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
