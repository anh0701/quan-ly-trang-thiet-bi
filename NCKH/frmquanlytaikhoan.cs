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
    public partial class frmQuanLyTaiKhoan : Form
    {
        private DataTable TaiKhoan = new DataTable();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            loaddtgvTaiKhoan();
        }
        private void loaddtgvTaiKhoan()
        {
            string strQuery = "SELECT * FROM TaiKhoan";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgvTaiKhoan.DataSource = table;

        }
        private bool checkForm()
        {
            eprError.Clear();
            bool ketQua = true;
            if (txbtendangnhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền tên đăng nhập");
                eprError.SetError(txbtendangnhap, "Chưa điền tên đăng nhập");
                ketQua = false;
            }

            if (txbtennguoidung.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền tên người dùng");
                eprError.SetError(txbtennguoidung, "Chưa điền tên người dùng");
                ketQua = false;
            }
            if (txbmatkhau.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền mật khẩu");
                eprError.SetError(txbmatkhau, "Chưa điền mật khẩu");
                ketQua = false;
            }


            if (ketQua == false)
                lblStatus.Text = "Thông báo: lỗi";
            return ketQua;

        }
        

    

        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow i = dtgvTaiKhoan.Rows[e.RowIndex];

        }

       
        

     

        private void btnThem_Click(object sender, EventArgs e)
        {

            eprError.Clear();
            if (checkForm() == false)
                return;
            string strCommand = "EXEC spThemTaiKhoan @tenDangNhap, @matKhau, @tenNguoiDung, @quyen, @trangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", txbtendangnhap.Text);
            parameters.Add("@matKhau", txbmatkhau.Text);
            parameters.Add("@tenNguoiDung", txbtendangnhap.Text);
            parameters.Add("@quyen", cbquyen.Text);
            if (cbtrangthai.Text == "Hoạt động")
            {
                parameters.Add("@trangThai", 1);
            }
            if (cbtrangthai.Text == "Khóa")
            {
                parameters.Add("@trangThai", 0);
            }
            try
            {

                Database.Execute(strCommand, parameters);
                loaddtgvTaiKhoan();
                lblStatus.Text = "Thông báo: Thêm dữ liệu thành công";
            }
            catch (Exception ex)
            {
                if (ex.Message == "Trùng tên đăng nhập")
                    eprError.SetError(txbtendangnhap, ex.Message);
                lblStatus.Text = "Thông báo: " + ex.Message;
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkForm() == false)
                return;
            string strQuery = "SELECT * FROM TaiKhoan WHERE TenDangNhap<>@tenDangNhap ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", dtgvTaiKhoan.CurrentRow.Cells["colTenDangNhap"].Value.ToString());
            parameters.Add("@matKhau", txbmatkhau.Text);
            parameters.Add("@tenNguoiDung", txbtennguoidung.Text);
            parameters.Add("@quyen", cbquyen.Text);
            if (cbtrangthai.Text == "Hoạt động")
            {
                parameters.Add("@trangThai", 1);
            }
            if (cbtrangthai.Text == "Khóa")
            {
                parameters.Add("@trangThai", 0);
            }
            DataTable table = Database.Query(strQuery, parameters);

            string strCommand = "UPDATE TaiKhoan SET MatKhau=@matKhau, TenNguoiDung=@tenNguoiDung, Quyen=@quyen, TrangThai=@trangThai WHERE TenDangNhap=@tenDangNhap";
            Database.Execute(strCommand, parameters);
            loaddtgvTaiKhoan();
            lblStatus.Text = "Thông báo: Sửa dữ liệu thành công";
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

