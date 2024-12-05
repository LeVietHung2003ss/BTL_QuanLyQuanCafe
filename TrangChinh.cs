using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyQuanCafe_Nhom_1
{
    public partial class FormTrangChinh : Form
    {
  
        public bool isThoat = true;
        public FormTrangChinh()
        {
            InitializeComponent();
            LoadTable();
            LoadListLoaiDoAn();
            LoadComboboxTable(cbSwitchTable);
           
        }
        #region Method
        void LoadListLoaiDoAn()
        {
            List<ListLoaiDoUong> listtbllduong = ListLoaiDoUongDAO.Instance.getListtblLDuong();
            cbLoaiDoUong.DataSource = listtbllduong;
            cbLoaiDoUong.DisplayMember = "loaiDoUong";
        }
        void LoadlistDoAnByListLoaiDoAnID(int loaiDoUong_ID)
        {
            List<ListDoUong> listduong = ListDoUongDAO.Instance.getListtblDuongBytblLDuong(loaiDoUong_ID);
            cbDoUong.DataSource = listduong;
            cbDoUong.DisplayMember = "tenDoUong";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.tenBan + Environment.NewLine + item.tinhTrang;
                btn.Click  += Click;
                btn.Tag = item;
                switch (item.tinhTrang)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink; 
                        break;
                }
                flpTable.Controls.Add(btn);

            }

        }
        void ShowHoaDon(int ban_id)
        {
            lsvBill.Items.Clear();
           List<Menu> listChiTietHoaDon = MenuDAO.Instance.GetlistMenuByTable(ban_id);
            float TongTien = 0;
            foreach(Menu item in listChiTietHoaDon)
            {
                ListViewItem lsvItem =new ListViewItem(item.TenDoUong.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                TongTien += item.ThanhTien;
                lsvBill.Items.Add(lsvItem);

            }
            CultureInfo culture=new CultureInfo("vi-VN");
            txtTongTien.Text=TongTien.ToString("c",culture);
            
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "tenBan";
        }
        #endregion
        #region Events
        void Click(object sender, EventArgs e)
        {
            int ban_id = ((sender as Button).Tag as Table).Ban_ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowHoaDon(ban_id);
        }
        private void FormTrangChinh_Load(object sender, EventArgs e)
        {
           

        }
       
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhapAdmin f = new dangnhapAdmin();
            f.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                if (isThoat)
                Application.Exit();
        }

        private void FormTrangChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
                if (isThoat)
                Application.Exit();
        }

        private void FormTrangChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbLoaiDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loaiDoUong_ID = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == null)
                return;

            ListLoaiDoUong selected = cb.SelectedItem as ListLoaiDoUong;
            loaiDoUong_ID = selected.LoaiDoUong_ID;
            LoadlistDoAnByListLoaiDoAnID(loaiDoUong_ID);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Table table=lsvBill.Tag as Table;
            int hoaDon_ID = BillDAO.Instance.GetHoaDonByBanID(table.Ban_ID);
            int doUong_ID=(cbDoUong.SelectedItem as ListDoUong).DoUong_ID;
            int soLuong =(int)nmFoodCount.Value;
            if (hoaDon_ID==-1)
            {
                BillDAO.Instance.InsertHoaDon(table.Ban_ID);
                ChiTietHoaDonDAO.Instance.InsertChiTietHoaDon(BillDAO.Instance.GetMaxHoaDon(), doUong_ID, soLuong);
            }
            else
            {
                ChiTietHoaDonDAO.Instance.InsertChiTietHoaDon(hoaDon_ID, doUong_ID, soLuong);
            }
            ShowHoaDon(table.ban_ID);
            LoadTable();

        }
        private void btnthanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int hoaDon_ID = BillDAO.Instance.GetHoaDonByBanID(table.Ban_ID);

            if (hoaDon_ID != -1)
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn cho bàn " + table.tenBan, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) ;
                {
                     BillDAO.Instance.CheckOut(hoaDon_ID);
                     ShowHoaDon(table.ban_ID);
                    LoadTable();
                }
            }
          
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            int ban_id1 = (lsvBill.Tag as Table).Ban_ID;
            int ban_id2 = (cbSwitchTable.SelectedItem as Table).Ban_ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1} ", (lsvBill.Tag as Table).TenBan, (cbSwitchTable.SelectedItem as Table).TenBan),"Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
                TableDAO.Instance.SwitchTable(ban_id1,ban_id2);
            LoadTable();
        }
        #endregion


    }
}
