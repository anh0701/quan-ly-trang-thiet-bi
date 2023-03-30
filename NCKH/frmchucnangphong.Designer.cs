namespace NCKH
{
    partial class frmchucnangphong
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
            this.dtgCN = new System.Windows.Forms.DataGridView();
            this.clMaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCN)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCN
            // 
            this.dtgCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCN,
            this.colTenCN});
            this.dtgCN.Location = new System.Drawing.Point(32, 32);
            this.dtgCN.Name = "dtgCN";
            this.dtgCN.RowHeadersWidth = 62;
            this.dtgCN.RowTemplate.Height = 28;
            this.dtgCN.Size = new System.Drawing.Size(687, 394);
            this.dtgCN.TabIndex = 0;
            this.dtgCN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCN_CellClick);
            // 
            // clMaCN
            // 
            this.clMaCN.DataPropertyName = "MaChucNang";
            this.clMaCN.HeaderText = "Mã chức năng";
            this.clMaCN.MinimumWidth = 8;
            this.clMaCN.Name = "clMaCN";
            this.clMaCN.Width = 150;
            // 
            // colTenCN
            // 
            this.colTenCN.DataPropertyName = "TenChucNang";
            this.colTenCN.HeaderText = "Tên chức năng";
            this.colTenCN.MinimumWidth = 8;
            this.colTenCN.Name = "colTenCN";
            this.colTenCN.Width = 150;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(167, 114);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(100, 26);
            this.txtTenCN.TabIndex = 10;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(167, 71);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(100, 26);
            this.txtMaCN.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(192, 271);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(81, 327);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(124, 36);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên chức năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật chức năng phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgCN);
            this.panel2.Location = new System.Drawing.Point(328, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 545);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtTenCN);
            this.panel1.Controls.Add(this.txtMaCN);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnTK);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 545);
            this.panel1.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(100, 271);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 271);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmchucnangphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmchucnangphong";
            this.Text = "frmchucnangphong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCN;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}