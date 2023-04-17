namespace NCKH
{
    partial class frmQuanLyTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.cbquyen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSoDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbtennguoidung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmatkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbtendangnhap = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.StatusStrip();
            this.button4 = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.cbtimkiem = new System.Windows.Forms.ComboBox();
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.ColTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbTrangThai);
            this.panel1.Controls.Add(this.cbkhoa);
            this.panel1.Controls.Add(this.cbquyen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbSoDienThoai);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbtennguoidung);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbmatkhau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbtendangnhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 137);
            this.panel1.TabIndex = 64;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(504, 73);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(147, 24);
            this.cbbTrangThai.TabIndex = 18;
            // 
            // cbkhoa
            // 
            this.cbkhoa.DisplayMember = "MaKhoa";
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(1176, 73);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(147, 24);
            this.cbkhoa.TabIndex = 17;
            this.cbkhoa.ValueMember = "MaKhoa";
            // 
            // cbquyen
            // 
            this.cbquyen.FormattingEnabled = true;
            this.cbquyen.Location = new System.Drawing.Point(504, 32);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.Size = new System.Drawing.Size(147, 24);
            this.cbquyen.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1032, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1032, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(1176, 26);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(147, 22);
            this.txbEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số điện thoại";
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.Location = new System.Drawing.Point(839, 74);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.Size = new System.Drawing.Size(148, 22);
            this.txbSoDienThoai.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên người dùng";
            // 
            // txbtennguoidung
            // 
            this.txbtennguoidung.Location = new System.Drawing.Point(839, 29);
            this.txbtennguoidung.Name = "txbtennguoidung";
            this.txbtennguoidung.Size = new System.Drawing.Size(148, 22);
            this.txbtennguoidung.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // txbmatkhau
            // 
            this.txbmatkhau.Location = new System.Drawing.Point(167, 77);
            this.txbmatkhau.Name = "txbmatkhau";
            this.txbmatkhau.Size = new System.Drawing.Size(146, 22);
            this.txbmatkhau.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txbtendangnhap
            // 
            this.txbtendangnhap.Location = new System.Drawing.Point(167, 32);
            this.txbtendangnhap.Name = "txbtendangnhap";
            this.txbtendangnhap.Size = new System.Drawing.Size(146, 22);
            this.txbtendangnhap.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 38);
            this.panel2.TabIndex = 65;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.txbtimkiem);
            this.panel3.Controls.Add(this.cbtimkiem);
            this.panel3.Controls.Add(this.dtgvTaiKhoan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1339, 554);
            this.panel3.TabIndex = 66;
            // 
            // lblStatus
            // 
            this.lblStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lblStatus.Location = new System.Drawing.Point(0, 532);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1339, 22);
            this.lblStatus.TabIndex = 62;
            this.lblStatus.Text = "statusStrip1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 59;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Location = new System.Drawing.Point(344, 6);
            this.txbtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtimkiem.Multiline = true;
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(643, 25);
            this.txbtimkiem.TabIndex = 61;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // cbtimkiem
            // 
            this.cbtimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtimkiem.FormattingEnabled = true;
            this.cbtimkiem.Location = new System.Drawing.Point(91, 6);
            this.cbtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtimkiem.Name = "cbtimkiem";
            this.cbtimkiem.Size = new System.Drawing.Size(247, 24);
            this.cbtimkiem.TabIndex = 60;
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.AllowUserToAddRows = false;
            this.dtgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dtgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTenDangNhap,
            this.ColQuyen,
            this.ColTrangThai,
            this.ColTenNguoiDung,
            this.ColSDT,
            this.ColEmail,
            this.ColMaKhoa});
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(10, 35);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.ReadOnly = true;
            this.dtgvTaiKhoan.RowHeadersWidth = 51;
            this.dtgvTaiKhoan.RowTemplate.Height = 24;
            this.dtgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(1318, 514);
            this.dtgvTaiKhoan.TabIndex = 58;
            this.dtgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTaiKhoan_CellClick);
            this.dtgvTaiKhoan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgvTaiKhoan_MouseDown);
            // 
            // ColTenDangNhap
            // 
            this.ColTenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenDangNhap.DataPropertyName = "TenDangNhap";
            this.ColTenDangNhap.FillWeight = 50F;
            this.ColTenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.ColTenDangNhap.MinimumWidth = 6;
            this.ColTenDangNhap.Name = "ColTenDangNhap";
            this.ColTenDangNhap.ReadOnly = true;
            // 
            // ColQuyen
            // 
            this.ColQuyen.DataPropertyName = "Quyen";
            this.ColQuyen.HeaderText = "Quyền";
            this.ColQuyen.MinimumWidth = 6;
            this.ColQuyen.Name = "ColQuyen";
            this.ColQuyen.ReadOnly = true;
            this.ColQuyen.Width = 125;
            // 
            // ColTrangThai
            // 
            this.ColTrangThai.DataPropertyName = "TrangThai";
            this.ColTrangThai.HeaderText = "Trạng Thái";
            this.ColTrangThai.MinimumWidth = 6;
            this.ColTrangThai.Name = "ColTrangThai";
            this.ColTrangThai.ReadOnly = true;
            this.ColTrangThai.Width = 125;
            // 
            // ColTenNguoiDung
            // 
            this.ColTenNguoiDung.DataPropertyName = "TenNguoiDung";
            this.ColTenNguoiDung.HeaderText = "Tên Người Dùng";
            this.ColTenNguoiDung.MinimumWidth = 6;
            this.ColTenNguoiDung.Name = "ColTenNguoiDung";
            this.ColTenNguoiDung.ReadOnly = true;
            this.ColTenNguoiDung.Width = 125;
            // 
            // ColSDT
            // 
            this.ColSDT.DataPropertyName = "SDT";
            this.ColSDT.HeaderText = "Số Điện Thoại";
            this.ColSDT.MinimumWidth = 6;
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.ReadOnly = true;
            this.ColSDT.Width = 125;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEmail.DataPropertyName = "Email";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 6;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColMaKhoa
            // 
            this.ColMaKhoa.DataPropertyName = "MaKhoa";
            this.ColMaKhoa.HeaderText = "Mã Khoa";
            this.ColMaKhoa.MinimumWidth = 6;
            this.ColMaKhoa.Name = "ColMaKhoa";
            this.ColMaKhoa.ReadOnly = true;
            this.ColMaKhoa.Width = 125;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1339, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbtendangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSoDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbtennguoidung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmatkhau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.ComboBox cbtimkiem;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.ComboBox cbquyen;
        private System.Windows.Forms.StatusStrip lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKhoa;
    }
}