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

        List<string> listcbquyen = new List<string> { "admin","Trưởng khoa","Kĩ thuật viên" };
        List<string> listcbtrangthai = new List<string> { "Hoạt động", "Khóa" };
        List<string> listcbtimkiem = new List<string> { "None","Tên đăng nhập", "Tên người dùng", "Quyền" ,"Khoa","Phòng", "Trạng thái" };
        List<string> listcbkhoa = new List<string> { "None","CNTT", "KT", "CT"};
        List<string> listcbphongquanly = new List<string> { "None","P305", "P306", "P307", "P308" };
        


        private DataTable TaiKhoan = new DataTable();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            loaddtgvTaiKhoan();
            cbquyen.DataSource = listcbquyen;
            cbtrangthai.DataSource = listcbtrangthai;
            cbtimkiem.DataSource = listcbtimkiem;
            cbkhoa.DataSource = listcbkhoa;
            cbphongquanly.DataSource = listcbphongquanly;
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
            else if (txbtendangnhap.Text.Length > 30)
            {
                MessageBox.Show("Tên đăng nhập quá dài");
                eprError.SetError(txbtendangnhap, "Tên đăng nhập quá dài (tối đa 30 ký tự)");
                ketQua = false;
            }

            if (txbtennguoidung.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền tên người dùng");
                eprError.SetError(txbtennguoidung, "Chưa điền tên người dùng");
                ketQua = false;
            }
            else if (txbtennguoidung.Text.Length > 50)
            {
                MessageBox.Show("Tên người dùng quá dài");
                eprError.SetError(txbtennguoidung, "Tên người dùng quá dài (tối đa 50 ký tự)");
                ketQua = false;
            }

            if (txbmatkhau.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền mật khẩu");
                eprError.SetError(txbmatkhau, "Chưa điền mật khẩu");
                ketQua = false;
            }
            else if (txbmatkhau.Text.Length > 128)
            {
                MessageBox.Show("Mật khẩu quá dài");
                eprError.SetError(txbmatkhau, "Mật khẩu quá dài (tối đa 128 ký tự)");
                ketQua = false;
            }

            if (ketQua == false)
                lblStatus.Text = "Thông báo: lỗi";
            return ketQua;

        }
                
        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow i = dtgvTaiKhoan.Rows[e.RowIndex];
                txbtendangnhap.Text = i.Cells["colTenDangNhap"].Value.ToString();
                txbtennguoidung.Text = i.Cells["colTenNguoiDung"].Value.ToString();
                txbmatkhau.Text = i.Cells["colMatKhau"].Value.ToString();
                cbquyen.Text = i.Cells["colQuyen"].Value.ToString();
                cbkhoa.Text = i.Cells["colKhoa"].Value.ToString();
                cbphongquanly.Text = i.Cells["colPhongQuanLy"].Value.ToString();

                if (i.Cells["colTrangThai"].Value.ToString() == "True")
                {
                    cbtrangthai.Text = "Hoạt động";
                }
                if (i.Cells["colTrangThai"].Value.ToString() == "False")
                {
                    cbtrangthai.Text = "Khóa";
                }
            }
        }

        private void txbtimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (cbtimkiem.Text == "Tên đăng nhập")
            {
                string str = "Select *from TaiKhoan where TenDangNhap LIKE '%' + N'" + txbtimkiem.Text + "' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(str, parameters);
                dtgvTaiKhoan.DataSource = table;
            }
            if (cbtimkiem.Text == "Tên người dùng")
            {
                string str = "Select *from TaiKhoan where TenNguoiDung LIKE '%' + N'" + txbtimkiem.Text + "' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(str, parameters);
                dtgvTaiKhoan.DataSource = table;
            }
            if (cbtimkiem.Text == "Trạng thái")
            {
                string trangThai = txbtimkiem.Text.Trim();
                bool? isActive = null;
                if (trangThai == "Hoạt động")
                {
                    isActive = true;
                }
                else if (trangThai == "Khóa")
                {
                    isActive = false;
                }
                string str;
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (isActive != null)
                {
                    str = "SELECT * FROM TaiKhoan WHERE TrangThai = @trangThai";
                    parameters.Add("@trangThai", isActive);
                }
                else
                {
                    str = "SELECT * FROM TaiKhoan";
                }
                DataTable table = Database.Query(str, parameters);
                dtgvTaiKhoan.DataSource = table;
            }

            if (cbtimkiem.Text == "Quyền")
            {
                string str = "Select *from TaiKhoan where Quyen LIKE '%' + N'" + txbtimkiem.Text + "' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(str, parameters);
                dtgvTaiKhoan.DataSource = table;
            }
            if (cbtimkiem.Text == "Khoa")
            {
                string str = "Select *from TaiKhoan where MaKhoa LIKE '%' + N'" + txbtimkiem.Text + "' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(str, parameters);
                dtgvTaiKhoan.DataSource = table;
            }
            if (cbtimkiem.Text == "Phòng")
            {
                string str = "Select *from TaiKhoan where MaPhong LIKE '%' + N'" + txbtimkiem.Text + "' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(str, parameters);
                dtgvTaiKhoan.DataSource = table;
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (checkForm() == false)
                return;
            string strQuery = "SELECT * FROM TaiKhoan WHERE TenDangNhap<>@tenDangNhap ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", dtgvTaiKhoan.CurrentRow.Cells["colTenDangNhap"].Value.ToString());
            parameters.Add("@matKhau", txbmatkhau.Text);
            parameters.Add("@tenNguoiDung", txbtennguoidung.Text);
            parameters.Add("@quyen", cbquyen.Text);
            parameters.Add("@maKhoa", cbkhoa.Text);
            parameters.Add("@maPhong", cbphongquanly.Text);
            if (cbtrangthai.Text == "Hoạt động")
            {
                parameters.Add("@trangThai", 1);
            }
            if (cbtrangthai.Text == "Khóa")
            {
                parameters.Add("@trangThai", 0);
            }
            DataTable table = Database.Query(strQuery, parameters);

            string strCommand = "UPDATE TaiKhoan SET MatKhau=@matKhau, TenNguoiDung=@tenNguoiDung, Quyen=@quyen,MaKhoa=@maKhoa,MaPhong=@maPhong, TrangThai=@trangThai WHERE TenDangNhap=@tenDangNhap";
            Database.Execute(strCommand, parameters);
            loaddtgvTaiKhoan();
            lblStatus.Text = "Thông báo: Sửa dữ liệu thành công";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            eprError.Clear();
            if (checkForm() == false)
                return;
            string strCommand = "EXEC spThemTaiKhoan @tenDangNhap, @matKhau, @tenNguoiDung, @quyen,@maKhoa, @maPhong, @trangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", txbtendangnhap.Text);
            parameters.Add("@matKhau", txbmatkhau.Text);
            parameters.Add("@tenNguoiDung", txbtennguoidung.Text);
            parameters.Add("@quyen", cbquyen.Text);
            parameters.Add("@maKhoa", cbkhoa.Text);
            parameters.Add("@maPhong", cbphongquanly.Text);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

