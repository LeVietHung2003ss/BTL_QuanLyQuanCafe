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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe_1;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaikhoan.Text;
                string mk = txtMatkhau.Text;
                string sql = "select TenTK,MauKhau from TaiKhoan where TenTK = '"+ tk +"' and MauKhau = '"+ mk +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormTrangChinh f = new FormTrangChinh();
                    f.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
