
namespace NCKH
{
    partial class FrmThemTrangThietBi
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
            this.tabContraol = new System.Windows.Forms.TabControl();
            this.tabTrangThietBi = new System.Windows.Forms.TabPage();
            this.tabMayTinh = new System.Windows.Forms.TabPage();
            this.tabMonHoc = new System.Windows.Forms.TabPage();
            this.tabPhanMem = new System.Windows.Forms.TabPage();
            this.tabContraol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContraol
            // 
            this.tabContraol.Controls.Add(this.tabTrangThietBi);
            this.tabContraol.Controls.Add(this.tabMayTinh);
            this.tabContraol.Controls.Add(this.tabMonHoc);
            this.tabContraol.Controls.Add(this.tabPhanMem);
            this.tabContraol.Location = new System.Drawing.Point(-4, 1);
            this.tabContraol.Name = "tabContraol";
            this.tabContraol.SelectedIndex = 0;
            this.tabContraol.Size = new System.Drawing.Size(1156, 642);
            this.tabContraol.TabIndex = 0;
            // 
            // tabTrangThietBi
            // 
            this.tabTrangThietBi.Location = new System.Drawing.Point(4, 25);
            this.tabTrangThietBi.Name = "tabTrangThietBi";
            this.tabTrangThietBi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrangThietBi.Size = new System.Drawing.Size(1148, 613);
            this.tabTrangThietBi.TabIndex = 0;
            this.tabTrangThietBi.Text = "Trang thiết bị";
            this.tabTrangThietBi.UseVisualStyleBackColor = true;
            // 
            // tabMayTinh
            // 
            this.tabMayTinh.Location = new System.Drawing.Point(4, 25);
            this.tabMayTinh.Name = "tabMayTinh";
            this.tabMayTinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabMayTinh.Size = new System.Drawing.Size(1148, 613);
            this.tabMayTinh.TabIndex = 1;
            this.tabMayTinh.Text = "Máy tính";
            this.tabMayTinh.UseVisualStyleBackColor = true;
            // 
            // tabMonHoc
            // 
            this.tabMonHoc.Location = new System.Drawing.Point(4, 25);
            this.tabMonHoc.Name = "tabMonHoc";
            this.tabMonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonHoc.Size = new System.Drawing.Size(1148, 613);
            this.tabMonHoc.TabIndex = 2;
            this.tabMonHoc.Text = "Môn học";
            this.tabMonHoc.UseVisualStyleBackColor = true;
            // 
            // tabPhanMem
            // 
            this.tabPhanMem.Location = new System.Drawing.Point(4, 25);
            this.tabPhanMem.Name = "tabPhanMem";
            this.tabPhanMem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhanMem.Size = new System.Drawing.Size(1148, 613);
            this.tabPhanMem.TabIndex = 3;
            this.tabPhanMem.Text = "Phần mềm";
            this.tabPhanMem.UseVisualStyleBackColor = true;
            // 
            // FrmThemTrangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 646);
            this.Controls.Add(this.tabContraol);
            this.Name = "FrmThemTrangThietBi";
            this.Text = "FrmThemTrangThietBi";
            this.tabContraol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContraol;
        private System.Windows.Forms.TabPage tabTrangThietBi;
        private System.Windows.Forms.TabPage tabMayTinh;
        private System.Windows.Forms.TabPage tabMonHoc;
        private System.Windows.Forms.TabPage tabPhanMem;
    }
}