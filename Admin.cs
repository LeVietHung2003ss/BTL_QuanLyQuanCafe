using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoanhThu f=new FormDoanhThu();
            f.ShowDialog();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDuong f=new FormDuong();
            f.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhMuc f=new FormDanhMuc();
            f.ShowDialog();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBanAn f=new FormBanAn();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTrangChinh f=new FormTrangChinh(); 
            f.ShowDialog();
        }

        private void tạoTàiKhoảnChoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan f = new FormThongTinTaiKhoan();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuChoAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoiMatKhauAdmin f=new FormDoiMatKhauAdmin();
            f.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
