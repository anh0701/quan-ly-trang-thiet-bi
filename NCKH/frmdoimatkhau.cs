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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txbMatKhauCu.Text == "")
            {
                MessageBox.Show("Chưa điền mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMatKhauCu.Focus();
            }
            else if (txbMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa điền mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMatKhauMoi.Focus();
            }
            else if (txbNhapLaiMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbNhapLaiMatKhauMoi.Focus();
            }
            else if (txbMatKhauCu.Text == txbMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMatKhauMoi.Focus();
            }
            else if (txbNhapLaiMatKhauMoi.Text != txbMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbNhapLaiMatKhauMoi.Focus();
            }
            else
            {
                string strCommand = "EXEC spDoiMatKhau @tenDangNhap,@matKhau,@matKhauMoi";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", "admin");
                parameters.Add("@matKhau", txbMatKhauCu.Text);
                parameters.Add("@matKhauMoi", txbMatKhauMoi.Text);
                try
                {
                    Database.Execute(strCommand, parameters);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
