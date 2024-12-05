namespace BTL_QuanLyQuanCafe_Nhom_1
{
    partial class FormBanAn
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBanan = new System.Windows.Forms.DataGridView();
            this.banSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ban_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTtrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(15, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 47);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(148, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 47);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(298, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 47);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(443, 32);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(600, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(600, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Bàn:";
            // 
            // txtMaban
            // 
            this.txtMaban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaban.Location = new System.Drawing.Point(702, 154);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(171, 30);
            this.txtMaban.TabIndex = 8;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenBan.Location = new System.Drawing.Point(702, 233);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(171, 30);
            this.txtTenBan.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.dgvBanan);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 398);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị thông tin";
            // 
            // dgvBanan
            // 
            this.dgvBanan.AllowUserToAddRows = false;
            this.dgvBanan.AllowUserToDeleteRows = false;
            this.dgvBanan.AllowUserToResizeColumns = false;
            this.dgvBanan.AllowUserToResizeRows = false;
            this.dgvBanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanan.ColumnHeadersHeight = 29;
            this.dgvBanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.banSTT,
            this.Ban_ID,
            this.TenBan,
            this.TinhTrang});
            this.dgvBanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanan.Location = new System.Drawing.Point(3, 23);
            this.dgvBanan.Name = "dgvBanan";
            this.dgvBanan.ReadOnly = true;
            this.dgvBanan.RowHeadersVisible = false;
            this.dgvBanan.RowHeadersWidth = 51;
            this.dgvBanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanan.Size = new System.Drawing.Size(576, 372);
            this.dgvBanan.TabIndex = 12;
            this.dgvBanan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanan_RowEnter);
            this.dgvBanan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvBanan_RowPrePaint);
            // 
            // banSTT
            // 
            this.banSTT.FillWeight = 56.63107F;
            this.banSTT.HeaderText = "STT";
            this.banSTT.MinimumWidth = 10;
            this.banSTT.Name = "banSTT";
            this.banSTT.ReadOnly = true;
            // 
            // Ban_ID
            // 
            this.Ban_ID.DataPropertyName = "Ban_ID";
            this.Ban_ID.FillWeight = 73.60036F;
            this.Ban_ID.HeaderText = "Mã bàn ăn";
            this.Ban_ID.MinimumWidth = 6;
            this.Ban_ID.Name = "Ban_ID";
            this.Ban_ID.ReadOnly = true;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.FillWeight = 90.44991F;
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.MinimumWidth = 6;
            this.TenBan.Name = "TenBan";
            this.TenBan.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // txtTtrang
            // 
            this.txtTtrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTtrang.Location = new System.Drawing.Point(702, 312);
            this.txtTtrang.Name = "txtTtrang";
            this.txtTtrang.Size = new System.Drawing.Size(171, 30);
            this.txtTtrang.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(597, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tình trạng:";
            // 
            // FormBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 492);
            this.Controls.Add(this.txtTtrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.txtMaban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FormBanAn";
            this.Text = "BanAn";
            this.Load += new System.EventHandler(this.FormBanAn_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn banSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ban_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.TextBox txtTtrang;
        private System.Windows.Forms.Label label3;
    }
}