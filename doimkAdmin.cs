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
    public partial class FormDoiMatKhauAdmin : Form
    {
        public FormDoiMatKhauAdmin()
        {
            InitializeComponent();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe_1;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Câu lệnh update mật khẩu
                string sql = "UPDATE TaiKhoan_Ad SET MatKhau_ad = @newPassword WHERE MatKhau_ad = @MatKhau_ad";

                // Thiết lập parameter
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add("@MatKhau_ad", SqlDbType.Int).Value = txtMatkhau.Text;
                    cmd.Parameters.Add("@newPassword", SqlDbType.Int).Value = txtMatKhauMoi.Text;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mật khẩu đã được đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f = new FormAdmin();
            f.ShowDialog();
        }

        private void FormDoiMatKhauAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
