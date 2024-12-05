namespace BTL_QuanLyQuanCafe_Nhom_1
{
    partial class FormDanhMuc
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
            this.txtLDuong = new System.Windows.Forms.TextBox();
            this.txtTenLDuong = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLDuong = new System.Windows.Forms.DataGridView();
            this.banSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDoUong_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(32, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 46);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(159, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(287, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(627, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã loại đồ uống:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(627, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại đồ uống:";
            // 
            // txtLDuong
            // 
            this.txtLDuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLDuong.Location = new System.Drawing.Point(796, 165);
            this.txtLDuong.Name = "txtLDuong";
            this.txtLDuong.Size = new System.Drawing.Size(189, 27);
            this.txtLDuong.TabIndex = 7;
            // 
            // txtTenLDuong
            // 
            this.txtTenLDuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLDuong.Location = new System.Drawing.Point(796, 232);
            this.txtTenLDuong.Name = "txtTenLDuong";
            this.txtTenLDuong.Size = new System.Drawing.Size(189, 27);
            this.txtTenLDuong.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(424, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 46);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.dgvLDuong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(29, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 433);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị thông tin";
            // 
            // dgvLDuong
            // 
            this.dgvLDuong.AllowUserToAddRows = false;
            this.dgvLDuong.AllowUserToDeleteRows = false;
            this.dgvLDuong.AllowUserToResizeColumns = false;
            this.dgvLDuong.AllowUserToResizeRows = false;
            this.dgvLDuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDuong.ColumnHeadersHeight = 29;
            this.dgvLDuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLDuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.banSTT,
            this.LoaiDoUong_ID,
            this.LoaiDoUong});
            this.dgvLDuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLDuong.Location = new System.Drawing.Point(3, 23);
            this.dgvLDuong.Name = "dgvLDuong";
            this.dgvLDuong.ReadOnly = true;
            this.dgvLDuong.RowHeadersVisible = false;
            this.dgvLDuong.RowHeadersWidth = 51;
            this.dgvLDuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDuong.Size = new System.Drawing.Size(555, 407);
            this.dgvLDuong.TabIndex = 12;
            this.dgvLDuong.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLDuong_RowEnter);
            this.dgvLDuong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLDuong_RowPrePaint);
            // 
            // banSTT
            // 
            this.banSTT.FillWeight = 56.63107F;
            this.banSTT.HeaderText = "STT";
            this.banSTT.MinimumWidth = 10;
            this.banSTT.Name = "banSTT";
            this.banSTT.ReadOnly = true;
            // 
            // LoaiDoUong_ID
            // 
            this.LoaiDoUong_ID.DataPropertyName = "LoaiDoUong_ID";
            this.LoaiDoUong_ID.FillWeight = 73.60036F;
            this.LoaiDoUong_ID.HeaderText = "Mã loại đồ uống";
            this.LoaiDoUong_ID.MinimumWidth = 6;
            this.LoaiDoUong_ID.Name = "LoaiDoUong_ID";
            this.LoaiDoUong_ID.ReadOnly = true;
            // 
            // LoaiDoUong
            // 
            this.LoaiDoUong.DataPropertyName = "LoaiDoUong";
            this.LoaiDoUong.FillWeight = 90.44991F;
            this.LoaiDoUong.HeaderText = "Tên loại đồ uống";
            this.LoaiDoUong.MinimumWidth = 6;
            this.LoaiDoUong.Name = "LoaiDoUong";
            this.LoaiDoUong.ReadOnly = true;
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTenLDuong);
            this.Controls.Add(this.txtLDuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FormDanhMuc";
            this.Text = "Loại đồ uống ";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLDuong;
        private System.Windows.Forms.TextBox txtTenLDuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLDuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn banSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDoUong_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDoUong;
    }
}