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
    public partial class FormBanAn : Form
    {
        BLL blldt;
        public FormBanAn()
        {
            InitializeComponent();
            blldt = new BLL();
        }

        public void ShowAllBanan()
        {
            DataTable dta = blldt.GetallBanan();
            dgvBanan.DataSource = dta;
        }
        private void FormBanAn_Load(object sender, EventArgs e)
        {
            ShowAllBanan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f=new FormAdmin();
            f.ShowDialog();
        }

        private void dgvBanan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaban.Text = dgvBanan.Rows[dong].Cells[1].Value.ToString();
            this.txtTenBan.Text = dgvBanan.Rows[dong].Cells[2].Value.ToString();
            this.txtTtrang.Text = dgvBanan.Rows[dong].Cells[3].Value.ToString();
        }

        private void dgvBanan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvBanan.RowCount; i++)
                dgvBanan.Rows[i].Cells[0].Value = i + 1;
        }
        public bool Checkdata()
        {
            if (string.IsNullOrEmpty(txtMaban.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã bàn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBan.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bàn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTtrang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tình trạng bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTtrang.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblBanan ba = new tblBanan();
                ba.Ban_ID = int.Parse(txtMaban.Text);
                ba.TenBan = txtTenBan.Text;
                ba.TinhTrang = txtTtrang.Text;
               if( blldt.InsertBanan(ba))
                ShowAllBanan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            if (Checkdata())
            {
                tblBanan ba = new tblBanan();
                ba.Ban_ID = int.Parse(txtMaban.Text);
                ba.TenBan = txtTenBan.Text;
                ba.TinhTrang = txtTtrang.Text;
                if (blldt.UpdateBanan(ba))
                    ShowAllBanan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblBanan ba = new tblBanan();
                ba.Ban_ID=int.Parse(txtMaban.Text);
                ba.TenBan = txtTenBan.Text;
                ba.TinhTrang = txtTtrang.Text;
                if (blldt.DeleteBanan(ba))
                    ShowAllBanan();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}
