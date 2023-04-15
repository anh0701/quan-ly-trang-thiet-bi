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
            this.dtgPhongMay = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTenPM = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clMaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbMaChucNang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongMay)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPhongMay
            // 
            this.dtgPhongMay.AllowUserToAddRows = false;
            this.dtgPhongMay.AllowUserToDeleteRows = false;
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
            this.dtgPhongMay.Size = new System.Drawing.Size(1028, 510);
            this.dtgPhongMay.TabIndex = 0;
            this.dtgPhongMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhongMay_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgPhongMay);
            this.panel2.Location = new System.Drawing.Point(51, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 436);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã chức năng phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên phòng máy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật phòng máy";
            // 
            // btnTK
            // 
            this.btnTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTK.Location = new System.Drawing.Point(702, 95);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(79, 29);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTenPM
            // 
            this.txtTenPM.Location = new System.Drawing.Point(148, 94);
            this.txtTenPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPM.Name = "txtTenPM";
            this.txtTenPM.Size = new System.Drawing.Size(138, 22);
            this.txtTenPM.TabIndex = 10;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(148, 57);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(138, 22);
            this.txtMaPM.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(806, 95);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 29);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(806, 47);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 29);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(702, 47);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 29);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 147);
            this.panel1.TabIndex = 3;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(494, 92);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(139, 24);
            this.cbbTrangThai.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trạng thái";
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
            // cbbMaChucNang
            // 
            this.cbbMaChucNang.FormattingEnabled = true;
            this.cbbMaChucNang.Location = new System.Drawing.Point(494, 55);
            this.cbbMaChucNang.Name = "cbbMaChucNang";
            this.cbbMaChucNang.Size = new System.Drawing.Size(139, 24);
            this.cbbMaChucNang.TabIndex = 12;
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
            this.Load += new System.EventHandler(this.frmphongmay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongMay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgPhongMay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTenPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaChucNang;
    }
}