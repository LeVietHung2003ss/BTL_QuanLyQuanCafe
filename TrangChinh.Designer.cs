namespace BTL_QuanLyQuanCafe_Nhom_1
{
    partial class FormTrangChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbDoUong = new System.Windows.Forms.ComboBox();
            this.cbLoaiDoUong = new System.Windows.Forms.ComboBox();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnthanhToan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lsvBill);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnThemMon);
            this.groupBox2.Controls.Add(this.cbDoUong);
            this.groupBox2.Controls.Add(this.cbLoaiDoUong);
            this.groupBox2.Controls.Add(this.nmFoodCount);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(568, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 439);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Món";
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 133);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(461, 306);
            this.lsvBill.TabIndex = 18;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Món";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn Giá";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành Tiền";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Lượng";
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemMon.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Location = new System.Drawing.Point(222, 40);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(122, 69);
            this.btnThemMon.TabIndex = 3;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cbDoUong
            // 
            this.cbDoUong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDoUong.FormattingEnabled = true;
            this.cbDoUong.Location = new System.Drawing.Point(6, 81);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(190, 27);
            this.cbDoUong.TabIndex = 2;
            // 
            // cbLoaiDoUong
            // 
            this.cbLoaiDoUong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiDoUong.FormattingEnabled = true;
            this.cbLoaiDoUong.Location = new System.Drawing.Point(6, 35);
            this.cbLoaiDoUong.Name = "cbLoaiDoUong";
            this.cbLoaiDoUong.Size = new System.Drawing.Size(190, 27);
            this.cbLoaiDoUong.TabIndex = 1;
            this.cbLoaiDoUong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDoUong_SelectedIndexChanged);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nmFoodCount.Location = new System.Drawing.Point(364, 62);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(45, 28);
            this.nmFoodCount.TabIndex = 0;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(1041, 190);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(138, 29);
            this.cbSwitchTable.TabIndex = 5;
            // 
            // btnthanhToan
            // 
            this.btnthanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnthanhToan.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthanhToan.ForeColor = System.Drawing.Color.White;
            this.btnthanhToan.Location = new System.Drawing.Point(1041, 275);
            this.btnthanhToan.Name = "btnthanhToan";
            this.btnthanhToan.Size = new System.Drawing.Size(161, 47);
            this.btnthanhToan.TabIndex = 6;
            this.btnthanhToan.Text = "Thanh Toán";
            this.btnthanhToan.UseVisualStyleBackColor = false;
            this.btnthanhToan.Click += new System.EventHandler(this.btnthanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(1041, 346);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(161, 38);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1126, 482);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 42);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDatBan
            // 
            this.btnDatBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDatBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatBan.ForeColor = System.Drawing.Color.White;
            this.btnDatBan.Location = new System.Drawing.Point(1041, 114);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(138, 47);
            this.btnDatBan.TabIndex = 16;
            this.btnDatBan.Text = "Chuyển Bàn";
            this.btnDatBan.UseVisualStyleBackColor = false;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 97);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(540, 424);
            this.flpTable.TabIndex = 17;
            // 
            // FormTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1254, 533);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnthanhToan);
            this.Controls.Add(this.cbSwitchTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrangChinh";
            this.Text = "TrangChinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrangChinh_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTrangChinh_FormClosed);
            this.Load += new System.EventHandler(this.FormTrangChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbDoUong;
        private System.Windows.Forms.ComboBox cbLoaiDoUong;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnthanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}