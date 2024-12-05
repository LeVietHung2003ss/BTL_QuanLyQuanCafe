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
    public partial class FormDuong : Form
    {
        BLL blldt;
        public FormDuong()
        {
            InitializeComponent();
            blldt = new BLL();
        }
        public void ShowAllDuong()
        {
            DataTable dta = blldt.GetallDuong();
            dgvDuong.DataSource = dta;
        }
        private void FormMonAn_Load(object sender, EventArgs e)
        {
            ShowAllDuong();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f=new FormAdmin();
            f.ShowDialog();
        }

        private void dgvDuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtDuong.Text = dgvDuong.Rows[dong].Cells[1].Value.ToString();
            this.txtTenDuong.Text = dgvDuong.Rows[dong].Cells[2].Value.ToString();
            this.txtGia.Text = dgvDuong.Rows[dong].Cells[3].Value.ToString();
        }

        private void dgvDuong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvDuong.RowCount; i++)
                dgvDuong.Rows[i].Cells[0].Value = i + 1;
        }
        public bool Checkdata()
        {
            if (string.IsNullOrEmpty(txtDuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenDuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblDuong DU = new tblDuong();
                DU.DoUong_ID =int.Parse(txtDuong.Text);
                DU.TenDoUong = txtTenDuong.Text;
                DU.Gia = txtGia.Text;
                if (blldt.InsertDuong(DU))
                    ShowAllDuong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblDuong DU = new tblDuong();
                DU.DoUong_ID = int.Parse(txtDuong.Text);
                DU.TenDoUong = txtTenDuong.Text;
                DU.Gia = txtGia.Text;
                if (blldt.UpdateDuong(DU))
                    ShowAllDuong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblDuong DU = new tblDuong();
                DU.DoUong_ID = int.Parse(txtDuong.Text);
                DU.TenDoUong = txtTenDuong.Text;
                DU.Gia = txtGia.Text;
                if (blldt.DeleteDuong(DU))
                    ShowAllDuong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void txtTimDuong_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimDuong.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = blldt.TimDuong(value);
                dgvDuong.DataSource = dt;
            }
            else
                ShowAllDuong();
        }
    }
}
