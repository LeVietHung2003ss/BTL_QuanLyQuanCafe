using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public partial class FormThongTinTaiKhoan : Form
    {
        public FormThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f=new FormAdmin();
            f.ShowDialog();
        }
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe_1;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Câu lệnh update mật khẩu
                string sql = "insert into TaiKhoan(TenTK, MauKhau) VALUES(@TenTK, @MauKhau)";

                // Thiết lập parameter
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add("@TenTK", SqlDbType.VarChar).Value = txtTaikhoan.Text;
                    cmd.Parameters.Add("@MauKhau", SqlDbType.Int).Value = txtMatkhau.Text;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("tài khoản đã được tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Không tạo được khoản hoặc mật khẩu, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
        }

        private void FormThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
