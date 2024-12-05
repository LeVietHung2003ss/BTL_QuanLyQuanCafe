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
    public partial class FormDoanhThu : Form
    {
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f=new FormAdmin();
            f.ShowDialog();
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}
