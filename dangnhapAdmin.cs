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
    public partial class dangnhapAdmin : Form
    {
        public dangnhapAdmin()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe_1;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaikhoan.Text;
                string mk = txtMatkhau.Text;
                string sql = "select TenTKhoan_ad,MatKhau_ad from TaiKhoan_Ad where TenTKhoan_ad = '" + tk + "' and MatKhau_ad = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormAdmin f = new FormAdmin();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTrangChinh f = new FormTrangChinh();
            f.ShowDialog();
        }

        private void dangnhapAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
