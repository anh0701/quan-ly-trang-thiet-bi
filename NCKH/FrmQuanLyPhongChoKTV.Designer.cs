
namespace NCKH
{
    partial class FrmQuanLyPhongChoKTV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TenKhoa = new System.Windows.Forms.Label();
            this.TenKTV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChucNangPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TenKhoa);
            this.panel1.Controls.Add(this.TenKTV);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NCKH.Properties.Resources.tải_xuống_removebg_preview__1_;
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // TenKhoa
            // 
            this.TenKhoa.AutoSize = true;
            this.TenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhoa.Location = new System.Drawing.Point(131, 34);
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Size = new System.Drawing.Size(79, 29);
            this.TenKhoa.TabIndex = 0;
            this.TenKhoa.Text = "label1";
            // 
            // TenKTV
            // 
            this.TenKTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TenKTV.AutoSize = true;
            this.TenKTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKTV.Location = new System.Drawing.Point(832, 34);
            this.TenKTV.Name = "TenKTV";
            this.TenKTV.Size = new System.Drawing.Size(79, 29);
            this.TenKTV.TabIndex = 0;
            this.TenKTV.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 546);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaPhong,
            this.ColTenPhong,
            this.ColChucNangPhong,
            this.ColTrangThai});
            this.dataGridView1.Location = new System.Drawing.Point(4, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 525);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // ColMaPhong
            // 
            this.ColMaPhong.DataPropertyName = "MaPhong";
            this.ColMaPhong.HeaderText = "Mã Phòng";
            this.ColMaPhong.MinimumWidth = 6;
            this.ColMaPhong.Name = "ColMaPhong";
            this.ColMaPhong.ReadOnly = true;
            this.ColMaPhong.Width = 125;
            // 
            // ColTenPhong
            // 
            this.ColTenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenPhong.DataPropertyName = "TenPhong";
            this.ColTenPhong.HeaderText = "Tên Phòng";
            this.ColTenPhong.MinimumWidth = 6;
            this.ColTenPhong.Name = "ColTenPhong";
            this.ColTenPhong.ReadOnly = true;
            // 
            // ColChucNangPhong
            // 
            this.ColChucNangPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColChucNangPhong.DataPropertyName = "MaChucNang";
            this.ColChucNangPhong.HeaderText = "Chức năng phòng";
            this.ColChucNangPhong.MinimumWidth = 6;
            this.ColChucNangPhong.Name = "ColChucNangPhong";
            this.ColChucNangPhong.ReadOnly = true;
            // 
            // ColTrangThai
            // 
            this.ColTrangThai.DataPropertyName = "TrangThai";
            this.ColTrangThai.HeaderText = "Trạng thái";
            this.ColTrangThai.MinimumWidth = 6;
            this.ColTrangThai.Name = "ColTrangThai";
            this.ColTrangThai.ReadOnly = true;
            this.ColTrangThai.Width = 125;
            // 
            // FrmQuanLyPhongChoKTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuanLyPhongChoKTV";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.FrmQuanLyPhongChoKTV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TenKhoa;
        private System.Windows.Forms.Label TenKTV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChucNangPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrangThai;
    }
}