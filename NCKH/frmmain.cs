using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
