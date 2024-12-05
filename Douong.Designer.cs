namespace BTL_QuanLyQuanCafe_Nhom_1
{
    partial class FormDuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenDuong = new System.Windows.Forms.TextBox();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.txtTimDuong = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDuong = new System.Windows.Forms.DataGridView();
            this.banSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoUong_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(42, 33);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 46);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(214, 33);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(376, 33);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(753, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm đồ uống:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(763, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã đồ uống:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(763, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đồ uống:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(763, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá tiền:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(876, 375);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(152, 27);
            this.txtGia.TabIndex = 11;
            // 
            // txtTenDuong
            // 
            this.txtTenDuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDuong.Location = new System.Drawing.Point(876, 284);
            this.txtTenDuong.Name = "txtTenDuong";
            this.txtTenDuong.Size = new System.Drawing.Size(152, 27);
            this.txtTenDuong.TabIndex = 12;
            // 
            // txtDuong
            // 
            this.txtDuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDuong.Location = new System.Drawing.Point(876, 202);
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(152, 27);
            this.txtDuong.TabIndex = 13;
            // 
            // txtTimDuong
            // 
            this.txtTimDuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimDuong.Location = new System.Drawing.Point(876, 118);
            this.txtTimDuong.Name = "txtTimDuong";
            this.txtTimDuong.Size = new System.Drawing.Size(152, 27);
            this.txtTimDuong.TabIndex = 14;
            this.txtTimDuong.TextChanged += new System.EventHandler(this.txtTimDuong_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(541, 33);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 46);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.dgvDuong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(39, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 504);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị thông tin";
            // 
            // dgvDuong
            // 
            this.dgvDuong.AllowUserToAddRows = false;
            this.dgvDuong.AllowUserToDeleteRows = false;
            this.dgvDuong.AllowUserToResizeColumns = false;
            this.dgvDuong.AllowUserToResizeRows = false;
            this.dgvDuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDuong.ColumnHeadersHeight = 29;
            this.dgvDuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.banSTT,
            this.DoUong_ID,
            this.TenDoUong,
            this.Gia});
            this.dgvDuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuong.Location = new System.Drawing.Point(3, 23);
            this.dgvDuong.Name = "dgvDuong";
            this.dgvDuong.ReadOnly = true;
            this.dgvDuong.RowHeadersVisible = false;
            this.dgvDuong.RowHeadersWidth = 51;
            this.dgvDuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuong.Size = new System.Drawing.Size(696, 478);
            this.dgvDuong.TabIndex = 12;
            this.dgvDuong.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuong_RowEnter);
            this.dgvDuong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDuong_RowPrePaint);
            // 
            // banSTT
            // 
            this.banSTT.FillWeight = 56.63107F;
            this.banSTT.HeaderText = "STT";
            this.banSTT.MinimumWidth = 10;
            this.banSTT.Name = "banSTT";
            this.banSTT.ReadOnly = true;
            // 
            // DoUong_ID
            // 
            this.DoUong_ID.DataPropertyName = "DoUong_ID";
            this.DoUong_ID.FillWeight = 73.60036F;
            this.DoUong_ID.HeaderText = "Mã đồ uống";
            this.DoUong_ID.MinimumWidth = 6;
            this.DoUong_ID.Name = "DoUong_ID";
            this.DoUong_ID.ReadOnly = true;
            // 
            // TenDoUong
            // 
            this.TenDoUong.DataPropertyName = "TenDoUong";
            this.TenDoUong.FillWeight = 90.44991F;
            this.TenDoUong.HeaderText = "Tên đồ uống";
            this.TenDoUong.MinimumWidth = 6;
            this.TenDoUong.Name = "TenDoUong";
            this.TenDoUong.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // FormDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTimDuong);
            this.Controls.Add(this.txtDuong);
            this.Controls.Add(this.txtTenDuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDuong";
            this.Text = "Đồ uống";
            this.Load += new System.EventHandler(this.FormMonAn_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenDuong;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.TextBox txtTimDuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn banSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoUong_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}