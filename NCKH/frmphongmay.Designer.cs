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
            this.clNgQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPhongMay = new System.Windows.Forms.DataGridView();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBaoTri = new System.Windows.Forms.RadioButton();
            this.rdSanSang = new System.Windows.Forms.RadioButton();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtNQL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtTenPM = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongMay)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clNgQL
            // 
            this.clNgQL.DataPropertyName = "MaNguoiQuanLy";
            this.clNgQL.HeaderText = "Mã người quản lý";
            this.clNgQL.MinimumWidth = 8;
            this.clNgQL.Name = "clNgQL";
            this.clNgQL.Width = 150;
            // 
            // clCN
            // 
            this.clCN.DataPropertyName = "MaChucNang";
            this.clCN.HeaderText = "Mã chức năng";
            this.clCN.MinimumWidth = 8;
            this.clCN.Name = "clCN";
            this.clCN.Width = 150;
            // 
            // clTenPM
            // 
            this.clTenPM.DataPropertyName = "TenPhong";
            this.clTenPM.HeaderText = "Tên phòng máy";
            this.clTenPM.MinimumWidth = 8;
            this.clTenPM.Name = "clTenPM";
            this.clTenPM.Width = 150;
            // 
            // clMaPM
            // 
            this.clMaPM.DataPropertyName = "MaPhong";
            this.clMaPM.HeaderText = "Mã phòng máy";
            this.clMaPM.MinimumWidth = 8;
            this.clMaPM.Name = "clMaPM";
            this.clMaPM.Width = 150;
            // 
            // dtgPhongMay
            // 
            this.dtgPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPM,
            this.clTenPM,
            this.clCN,
            this.clTrangThai,
            this.clNgQL});
            this.dtgPhongMay.Location = new System.Drawing.Point(47, 19);
            this.dtgPhongMay.Name = "dtgPhongMay";
            this.dtgPhongMay.RowHeadersWidth = 62;
            this.dtgPhongMay.RowTemplate.Height = 28;
            this.dtgPhongMay.Size = new System.Drawing.Size(687, 427);
            this.dtgPhongMay.TabIndex = 0;
            this.dtgPhongMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhongMay_CellClick);
            // 
            // clTrangThai
            // 
            this.clTrangThai.DataPropertyName = "TrangThai";
            this.clTrangThai.HeaderText = "Trạng thái";
            this.clTrangThai.MinimumWidth = 8;
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgPhongMay);
            this.panel2.Location = new System.Drawing.Point(299, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 545);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã chức năng phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên phòng máy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật phòng máy";
            // 
            // rdBaoTri
            // 
            this.rdBaoTri.AutoSize = true;
            this.rdBaoTri.Location = new System.Drawing.Point(21, 56);
            this.rdBaoTri.Name = "rdBaoTri";
            this.rdBaoTri.Size = new System.Drawing.Size(80, 24);
            this.rdBaoTri.TabIndex = 1;
            this.rdBaoTri.TabStop = true;
            this.rdBaoTri.Text = "Bảo trì";
            this.rdBaoTri.UseVisualStyleBackColor = true;
            // 
            // rdSanSang
            // 
            this.rdSanSang.AutoSize = true;
            this.rdSanSang.Location = new System.Drawing.Point(21, 26);
            this.rdSanSang.Name = "rdSanSang";
            this.rdSanSang.Size = new System.Drawing.Size(102, 24);
            this.rdSanSang.TabIndex = 0;
            this.rdSanSang.TabStop = true;
            this.rdSanSang.Text = "Sẵn sàng";
            this.rdSanSang.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(62, 486);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(124, 36);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtNQL
            // 
            this.txtNQL.Location = new System.Drawing.Point(167, 208);
            this.txtNQL.Name = "txtNQL";
            this.txtNQL.Size = new System.Drawing.Size(100, 26);
            this.txtNQL.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã người quản lý";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(167, 161);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(100, 26);
            this.txtCNP.TabIndex = 11;
            // 
            // txtTenPM
            // 
            this.txtTenPM.Location = new System.Drawing.Point(167, 117);
            this.txtTenPM.Name = "txtTenPM";
            this.txtTenPM.Size = new System.Drawing.Size(100, 26);
            this.txtTenPM.TabIndex = 10;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(167, 71);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(100, 26);
            this.txtMaPM.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(187, 428);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(94, 428);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 428);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBaoTri);
            this.groupBox1.Controls.Add(this.rdSanSang);
            this.groupBox1.Location = new System.Drawing.Point(18, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTK);
            this.panel1.Controls.Add(this.txtNQL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCNP);
            this.panel1.Controls.Add(this.txtTenPM);
            this.panel1.Controls.Add(this.txtMaPM);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 545);
            this.panel1.TabIndex = 3;
            // 
            // frmphongmay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmphongmay";
            this.Text = "frmphongmay";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongMay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clNgQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPM;
        private System.Windows.Forms.DataGridView dtgPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBaoTri;
        private System.Windows.Forms.RadioButton rdSanSang;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtNQL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtTenPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}