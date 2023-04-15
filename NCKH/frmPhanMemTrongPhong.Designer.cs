namespace NCKH
{
    partial class frmPhanMemTrongPhong
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtgrvChiTiet = new System.Windows.Forms.DataGridView();
            this.txbTenPhanMem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMaPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbMaPhanMem = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ColMaChiTietPhanMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaPhanMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvChiTiet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã phần mềm:";
            // 
            // dtgrvChiTiet
            // 
            this.dtgrvChiTiet.AllowUserToAddRows = false;
            this.dtgrvChiTiet.AllowUserToDeleteRows = false;
            this.dtgrvChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaChiTietPhanMem,
            this.ColMaPhong,
            this.ColMaPhanMem});
            this.dtgrvChiTiet.Location = new System.Drawing.Point(3, 11);
            this.dtgrvChiTiet.Name = "dtgrvChiTiet";
            this.dtgrvChiTiet.RowHeadersWidth = 51;
            this.dtgrvChiTiet.RowTemplate.Height = 24;
            this.dtgrvChiTiet.Size = new System.Drawing.Size(977, 358);
            this.dtgrvChiTiet.TabIndex = 0;
            // 
            // txbTenPhanMem
            // 
            this.txbTenPhanMem.Location = new System.Drawing.Point(459, 79);
            this.txbTenPhanMem.Name = "txbTenPhanMem";
            this.txbTenPhanMem.ReadOnly = true;
            this.txbTenPhanMem.Size = new System.Drawing.Size(189, 22);
            this.txbTenPhanMem.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên phần mềm:";
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Location = new System.Drawing.Point(459, 25);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.ReadOnly = true;
            this.txbTenPhong.Size = new System.Drawing.Size(189, 22);
            this.txbTenPhong.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên phòng:";
            // 
            // txbMaPhong
            // 
            this.txbMaPhong.Location = new System.Drawing.Point(134, 26);
            this.txbMaPhong.Name = "txbMaPhong";
            this.txbMaPhong.ReadOnly = true;
            this.txbMaPhong.Size = new System.Drawing.Size(121, 22);
            this.txbMaPhong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã phòng:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(782, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(899, 79);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(899, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(782, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cbMaPhanMem
            // 
            this.cbMaPhanMem.FormattingEnabled = true;
            this.cbMaPhanMem.Location = new System.Drawing.Point(134, 77);
            this.cbMaPhanMem.Name = "cbMaPhanMem";
            this.cbMaPhanMem.Size = new System.Drawing.Size(121, 24);
            this.cbMaPhanMem.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtgrvChiTiet);
            this.panel2.Location = new System.Drawing.Point(2, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 372);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txbTenPhanMem);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbTenPhong);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txbMaPhong);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.cbMaPhanMem);
            this.panel3.Location = new System.Drawing.Point(1, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 138);
            this.panel3.TabIndex = 8;
            // 
            // ColMaChiTietPhanMem
            // 
            this.ColMaChiTietPhanMem.DataPropertyName = "MaChiTietPhanMemCoTrongPhong";
            this.ColMaChiTietPhanMem.FillWeight = 50F;
            this.ColMaChiTietPhanMem.HeaderText = "STT";
            this.ColMaChiTietPhanMem.MinimumWidth = 6;
            this.ColMaChiTietPhanMem.Name = "ColMaChiTietPhanMem";
            this.ColMaChiTietPhanMem.Width = 125;
            // 
            // ColMaPhong
            // 
            this.ColMaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaPhong.DataPropertyName = "MaPhong";
            this.ColMaPhong.HeaderText = "Mã Phòng";
            this.ColMaPhong.MinimumWidth = 6;
            this.ColMaPhong.Name = "ColMaPhong";
            // 
            // ColMaPhanMem
            // 
            this.ColMaPhanMem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaPhanMem.DataPropertyName = "MaPhanMem";
            this.ColMaPhanMem.HeaderText = "Mã phần mềm";
            this.ColMaPhanMem.MinimumWidth = 6;
            this.ColMaPhanMem.Name = "ColMaPhanMem";
            // 
            // frmPhanMemTrongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmPhanMemTrongPhong";
            this.Text = "Thêm phần mềm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvChiTiet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgrvChiTiet;
        private System.Windows.Forms.TextBox txbTenPhanMem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMaPhanMem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaChiTietPhanMem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaPhanMem;
    }
}