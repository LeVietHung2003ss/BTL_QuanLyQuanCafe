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
    public partial class FormDanhMuc : Form
    {
        BLL blldt;
        public FormDanhMuc()
        {
            InitializeComponent();
            blldt = new BLL();
        }
        public void ShowAllLDuong()
        {
            DataTable dta = blldt.GetallLDuong();
            dgvLDuong.DataSource = dta;
        }
        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            ShowAllLDuong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f=new FormAdmin();
            f.ShowDialog();
        }

        private void dgvLDuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtLDuong.Text = dgvLDuong.Rows[dong].Cells[1].Value.ToString();
            this.txtTenLDuong.Text = dgvLDuong.Rows[dong].Cells[2].Value.ToString();
        }

        private void dgvLDuong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvLDuong.RowCount; i++)
                dgvLDuong.Rows[i].Cells[0].Value = i + 1;
        }
        public bool Checkdata()
        {
            if (string.IsNullOrEmpty(txtLDuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã loại đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLDuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLDuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên loại đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLDuong.Focus();
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblLDuong LDU = new tblLDuong();
                LDU.LoaiDoUong_ID=int.Parse(txtLDuong.Text);
                LDU.LoaiDoUong = txtTenLDuong.Text;
                if (blldt.InsertLDuong(LDU))
                    ShowAllLDuong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblLDuong LDU = new tblLDuong();
                LDU.LoaiDoUong_ID = int.Parse(txtLDuong.Text);
                LDU.LoaiDoUong = txtTenLDuong.Text;
                if (blldt.UpdateLDuong(LDU))
                    ShowAllLDuong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                tblLDuong LDU = new tblLDuong();
                LDU.LoaiDoUong_ID = int.Parse(txtLDuong.Text);
                LDU.LoaiDoUong = txtTenLDuong.Text;
                if (blldt.DeleteLDuong(LDU))
                    ShowAllLDuong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}
