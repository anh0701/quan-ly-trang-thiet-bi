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
    public partial class frmDangNhap : Form
    {
        private bool authentication = false;
        public bool Authentication
        {
            get { return authentication; }
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void bDN_Click(object sender, EventArgs e)
        {
            eprError.Clear();
            string strCommand = "EXEC spDangNhap @tenDangNhap, @matKhau";
            string strcmd = "SELECT * from dbo.ufLayPhanQuyen ((select Quyen from TaiKhoan where TenDangNhap = @tenDangNhap))";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", txtUsername.Text);
            parameters.Add("@matKhau", txtPass.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                DataTable cn = Database.Query(strcmd, parameters);
                int number_cols = cn.Columns.Count;
                List<string> list = new List<string>();
                foreach (DataRow row in cn.Rows)
                {
                    for (int i = 0; i < number_cols; i++)
                    {
                        list.Add(row[i].ToString());
                    }
                }
                authentication = true;
                Program.TenDangNhap = txtUsername.Text;
                Program.Khoa = Database.LayMaKhoa(txtUsername.Text);
                Program.TenKiThuatVien = Database.LayTenKTV(txtUsername.Text);
                Program.Quyen = Database.LayQuyen(txtUsername.Text);
                frmMain f = new frmMain();
                f.Show();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Sai mật khẩu")
                    eprError.SetError(txtPass, ex.Message);
                //  lblStatus.Text = "Thông báo: " + ex.Message;
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load_1(object sender, EventArgs e)
        {

        }
    }
}
