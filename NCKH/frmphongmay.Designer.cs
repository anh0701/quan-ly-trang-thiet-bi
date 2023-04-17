namespace NCKH
{
    partial class frmphongmay
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgPhongMay = new System.Windows.Forms.DataGridView();
            this.clMaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTenPM = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMaChucNang = new System.Windows.Forms.ComboBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongMay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtgPhongMay);
            this.panel2.Location = new System.Drawing.Point(12, 157);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 478);
            this.panel2.TabIndex = 4;
            // 
            // dtgPhongMay
            // 
            this.dtgPhongMay.AllowUserToAddRows = false;
            this.dtgPhongMay.AllowUserToDeleteRows = false;
            this.dtgPhongMay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPM,
            this.clTenPM,
            this.clCN,
            this.clTrangThai});
            this.dtgPhongMay.Location = new System.Drawing.Point(3, 2);
            this.dtgPhongMay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPhongMay.Name = "dtgPhongMay";
            this.dtgPhongMay.ReadOnly = true;
            this.dtgPhongMay.RowHeadersWidth = 62;
            this.dtgPhongMay.RowTemplate.Height = 28;
            this.dtgPhongMay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPhongMay.Size = new System.Drawing.Size(1123, 483);
            this.dtgPhongMay.TabIndex = 2;
            this.dtgPhongMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhongMay_CellClick);
            this.dtgPhongMay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgPhongMay_MouseDown);
            // 
            // clMaPM
            // 
            this.clMaPM.DataPropertyName = "MaPhong";
            this.clMaPM.HeaderText = "Mã phòng máy";
            this.clMaPM.MinimumWidth = 8;
            this.clMaPM.Name = "clMaPM";
            this.clMaPM.ReadOnly = true;
            this.clMaPM.Width = 150;
            // 
            // clTenPM
            // 
            this.clTenPM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenPM.DataPropertyName = "TenPhong";
            this.clTenPM.HeaderText = "Tên phòng máy";
            this.clTenPM.MinimumWidth = 8;
            this.clTenPM.Name = "clTenPM";
            this.clTenPM.ReadOnly = true;
            // 
            // clCN
            // 
            this.clCN.DataPropertyName = "MaChucNang";
            this.clCN.HeaderText = "Mã chức năng";
            this.clCN.MinimumWidth = 8;
            this.clCN.Name = "clCN";
            this.clCN.ReadOnly = true;
            this.clCN.Width = 150;
            // 
            // clTrangThai
            // 
            this.clTrangThai.DataPropertyName = "TrangThai";
            this.clTrangThai.HeaderText = "Trạng thái";
            this.clTrangThai.MinimumWidth = 8;
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.ReadOnly = true;
            this.clTrangThai.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã chức năng phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên phòng máy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng máy";
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(907, 78);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(85, 24);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // txtTenPM
            // 
            this.txtTenPM.Location = new System.Drawing.Point(152, 69);
            this.txtTenPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPM.Name = "txtTenPM";
            this.txtTenPM.Size = new System.Drawing.Size(138, 22);
            this.txtTenPM.TabIndex = 10;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(152, 32);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(138, 22);
            this.txtMaPM.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1011, 78);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 24);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1011, 30);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 24);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(907, 30);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 24);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbbMaChucNang);
            this.panel1.Controls.Add(this.cbbTrangThai);
            this.panel1.Controls.Add(this.btnTK);
            this.panel1.Controls.Add(this.txtTenPM);
            this.panel1.Controls.Add(this.txtMaPM);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 142);
            this.panel1.TabIndex = 3;
            // 
            // cbbMaChucNang
            // 
            this.cbbMaChucNang.DisplayMember = "MaChucNangPhong";
            this.cbbMaChucNang.FormattingEnabled = true;
            this.cbbMaChucNang.Location = new System.Drawing.Point(565, 27);
            this.cbbMaChucNang.Name = "cbbMaChucNang";
            this.cbbMaChucNang.Size = new System.Drawing.Size(139, 24);
            this.cbbMaChucNang.TabIndex = 12;
            this.cbbMaChucNang.ValueMember = "MaChucNang";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(565, 64);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(139, 24);
            this.cbbTrangThai.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trạng thái";
            // 
            // frmphongmay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmphongmay";
            this.Text = "Phòng máy";
            this.Load += new System.EventHandler(this.frmphongmay_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongMay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTenPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaChucNang;
        private System.Windows.Forms.DataGridView dtgPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
    }
}