namespace NCKH
{
    partial class frmPhanMem
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txbtimkiemTTB = new System.Windows.Forms.TextBox();
            this.cbtimkiemTTB = new System.Windows.Forms.ComboBox();
            this.dtgvPhanMem = new System.Windows.Forms.DataGridView();
            this.MaPhanMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhanMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhanMem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 198);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(713, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 27);
            this.button3.TabIndex = 101;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(188, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 27);
            this.textBox2.TabIndex = 94;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(831, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 27);
            this.button5.TabIndex = 99;
            this.button5.Text = "Đóng";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "ID Phần Mềm";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(831, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 27);
            this.button2.TabIndex = 100;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tên Phần Mềm";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(713, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 27);
            this.button4.TabIndex = 98;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(188, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 27);
            this.textBox1.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txbtimkiemTTB);
            this.panel2.Controls.Add(this.cbtimkiemTTB);
            this.panel2.Controls.Add(this.dtgvPhanMem);
            this.panel2.Location = new System.Drawing.Point(0, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 449);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 98;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbtimkiemTTB
            // 
            this.txbtimkiemTTB.Location = new System.Drawing.Point(352, 7);
            this.txbtimkiemTTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtimkiemTTB.Multiline = true;
            this.txbtimkiemTTB.Name = "txbtimkiemTTB";
            this.txbtimkiemTTB.Size = new System.Drawing.Size(643, 25);
            this.txbtimkiemTTB.TabIndex = 100;
            // 
            // cbtimkiemTTB
            // 
            this.cbtimkiemTTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtimkiemTTB.FormattingEnabled = true;
            this.cbtimkiemTTB.Location = new System.Drawing.Point(99, 7);
            this.cbtimkiemTTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtimkiemTTB.Name = "cbtimkiemTTB";
            this.cbtimkiemTTB.Size = new System.Drawing.Size(247, 24);
            this.cbtimkiemTTB.TabIndex = 99;
            // 
            // dtgvPhanMem
            // 
            this.dtgvPhanMem.AllowUserToAddRows = false;
            this.dtgvPhanMem.AllowUserToDeleteRows = false;
            this.dtgvPhanMem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvPhanMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhanMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhanMem,
            this.TenPhanMem});
            this.dtgvPhanMem.Location = new System.Drawing.Point(3, 37);
            this.dtgvPhanMem.Name = "dtgvPhanMem";
            this.dtgvPhanMem.RowHeadersWidth = 51;
            this.dtgvPhanMem.RowTemplate.Height = 24;
            this.dtgvPhanMem.Size = new System.Drawing.Size(1224, 400);
            this.dtgvPhanMem.TabIndex = 97;
            // 
            // MaPhanMem
            // 
            this.MaPhanMem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhanMem.DataPropertyName = "MaPhanMem";
            this.MaPhanMem.HeaderText = "Mã Phần Mềm";
            this.MaPhanMem.MinimumWidth = 6;
            this.MaPhanMem.Name = "MaPhanMem";
            // 
            // TenPhanMem
            // 
            this.TenPhanMem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhanMem.DataPropertyName = "TenPhanMem";
            this.TenPhanMem.HeaderText = "Tên Phần Mềm";
            this.TenPhanMem.MinimumWidth = 6;
            this.TenPhanMem.Name = "TenPhanMem";
            // 
            // frmPhanMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhanMem";
            this.Text = "Cập Nhật Phần Mềm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhanMem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvPhanMem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhanMem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhanMem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbtimkiemTTB;
        private System.Windows.Forms.ComboBox cbtimkiemTTB;
    }
}