using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NCKH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            hideBut();
            if(Program.Quyen=="Kĩ thuật viên")
            {
                button2.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button10.Visible = false;
                button12.Visible = false;
            }
        }
        private void hideBut()
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            

        }

        private void hidePanel3()
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
            //if(panel4.Visible == true)
            //panel4.Visible = false;
            //if(panel5.Visible == true) 
            //panel5.Visible = false;
        }
        private void hidePanel4()
        {
            //if (panel3.Visible == true)
            //panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            //if (panel5.Visible == true)
            //panel5.Visible = false;
        }
        private void hidePanel5()
        {
            //if (panel3.Visible == true)
            panel3.Visible = false;
            //if (panel4.Visible == true)
            panel4.Visible = false;
            if (panel5.Visible == true)
                panel5.Visible = false;
        }
        private void showPanel3(Panel panel3)
        {
            if (panel3.Visible == false)
            {
                hidePanel3();
                panel3.Visible = true;
            }
            else
                panel3.Visible = false;
        }
        private void showPanel4(Panel panel4)
        {
            if (panel4.Visible == false)
            {
                hidePanel4();
                panel4.Visible = true;
            }
            else
                panel4.Visible = false;
        }
        private void showPanel5(Panel panel5)
        {
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
                button11.Hide();
                button13.Hide();
            }
            else
                panel5.Visible = false;
        }
        private void mniDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmDMK = new FrmDoiMatKhau();
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i].Text == frmDMK.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            frmDMK.MdiParent = this;
            frmDMK.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frmDMK = new frmQuanLyTaiKhoan();

            frmDMK.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            showPanel3(panel3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hidePanel3();
            OpenChildForm(new frmQuanLyTaiKhoan());
            if (Program.Quyen == "Admin")
            {
                OpenChildForm(new frmQuanLyTaiKhoan());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDoiMatKhau());
            //hidePanel3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showPanel4(panel4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showPanel5(panel5);
            if (Program.Quyen == "Admin")
            {
                OpenChildForm(new frmphongmay());
            }
            else 
            {
                OpenChildForm(new FrmQuanLyPhongChoKTV());
                
            }           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button11.Visible == false)
            {
                button11.Show();
            }
            else
                button11.Hide();
            if (Program.Quyen == "Admin")
            {
                OpenChildForm(new FrmTrangThietBi());
            }
        }


        private void button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMayTinh());
            if (button13.Visible == false)
            {
                button13.Show();
            }
            else
                button13.Hide();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel8.Controls.Add(childForm);
            panel8.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.vimaru.edu.vn/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyThietBiMayTinh());
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {                 
                OpenChildForm(new frmKhoa());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMonHoc());
            if (Program.Quyen == "Kĩ thuật viên")
            {
                OpenChildForm(new FrmQuanLyPhongChoKTV());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhanMem());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonVi());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiTrangThietBi());
        }
    }
}
