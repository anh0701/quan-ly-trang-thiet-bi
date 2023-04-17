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

        List<string> listcbquyen = new List<string> { "Admin","Kĩ thuật viên" };
        List<string> listcbtrangthai = new List<string> { "Hoạt động", "Khóa" };
        List<string> listcbtimkiem = new List<string> { "None","Tên đăng nhập", "Tên người dùng", "Quyền" ,"Khoa","Phòng", "Trạng thái" };
        


        private DataTable TaiKhoan = new DataTable();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            loaddtgvTaiKhoan();
            cbquyen.DataSource = listcbquyen;
            cbbTrangThai.DataSource = listcbtrangthai;
            cbtimkiem.DataSource = listcbtimkiem;
            cbkhoa.DataSource = Database.Query("SELECT * FROM Khoa", new Dictionary<string, object>());
        }
        private void loaddtgvTaiKhoan()
        {
            string strQuery = "SELECT * FROM TaiKhoan";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgvTaiKhoan.DataSource = table;

        }
        private void dtgvTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dtgvTaiKhoan.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    // Select the row
                    dtgvTaiKhoan.ClearSelection();
                    dtgvTaiKhoan.Rows[currentMouseOverRow].Selected = true;

                    // Create a new ContextMenuStrip
                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    // Add some options to the menu
                    ToolStripMenuItem chinhSua = new ToolStripMenuItem("Thêm phòng quản lý");
                    contextMenu.Items.Add(chinhSua);
                    ToolStripMenuItem ChinhSua = new ToolStripMenuItem("Chỉnh sửa");
                    contextMenu.Items.Add(ChinhSua);
                    ToolStripMenuItem Xoa = new ToolStripMenuItem("Xóa");
                    contextMenu.Items.Add(Xoa);

                    chinhSua.Click += new EventHandler(chinhSua_Click);

                    // Show the menu at the location of the mouse click
                    contextMenu.Show(dtgvTaiKhoan, e.Location);
                }
            }
        }
        private void chinhSua_Click(object sender, EventArgs e)
        {
            ThemPhongQuanLy form2 = new ThemPhongQuanLy();
            form2.Text = ten;
            ThemPhongQuanLy.TenDN = ten;
            form2.ShowDialog();
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
         string ten;
        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow i = dtgvTaiKhoan.Rows[e.RowIndex];
                ten = txbtendangnhap.Text = i.Cells["ColTenDangNhap"].Value.ToString();
                txbtennguoidung.Text = i.Cells["ColTenNguoiDung"].Value.ToString();
                cbquyen.Text = i.Cells["ColQuyen"].Value.ToString();
                cbkhoa.Text = i.Cells["ColMaKhoa"].Value.ToString();
                cbbTrangThai.Text = i.Cells["ColTrangThai"].Value.ToString();
                txbEmail.Text = i.Cells["ColEmail"].Value.ToString();
                txbSoDienThoai.Text = i.Cells["ColSDT"].Value.ToString();

            }
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
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
                string str = "Select *from TaiKhoan where TrangThai LIKE '%' + N'" + cbbTrangThai.Text + "' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkForm() == false)
                return;
            string strQuery = "SELECT * FROM TaiKhoan WHERE TenDangNhap<>@tenDangNhap ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", dtgvTaiKhoan.CurrentRow.Cells["ColTenDangNhap"].Value.ToString());
            parameters.Add("@matKhau", txbmatkhau.Text);
            parameters.Add("@tenNguoiDung", txbtennguoidung.Text);
            parameters.Add("@sDT", txbSoDienThoai.Text);
            parameters.Add("@email", txbEmail.Text);
            parameters.Add("@quyen", cbquyen.Text);
            parameters.Add("@maKhoa", cbkhoa.Text);
            parameters.Add("@trangThai", cbbTrangThai.Text);

            DataTable table = Database.Query(strQuery, parameters);

            string strCommand = "UPDATE TaiKhoan SET MatKhau=@matKhau, TenNguoiDung=@tenNguoiDung,SDT=@sDT,Email=@email, Quyen=@quyen,MaKhoa=@maKhoa, TrangThai=@trangThai WHERE TenDangNhap=@tenDangNhap";
            Database.Execute(strCommand, parameters);
            loaddtgvTaiKhoan();
            lblStatus.Text = "Thông báo: Sửa dữ liệu thành công";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eprError.Clear();
            if (checkForm() == false)
                return;
            string strCommand = "EXEC spThemTaiKhoan @tenDangNhap, @matKhau, @tenNguoiDung,@sDT,@email, @quyen,@maKhoa, @trangThai";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDangNhap", dtgvTaiKhoan.CurrentRow.Cells["ColTenDangNhap"].Value.ToString());
            parameters.Add("@matKhau", txbmatkhau.Text);
            parameters.Add("@tenNguoiDung", txbtennguoidung.Text);
            parameters.Add("@sDT", txbSoDienThoai.Text);
            parameters.Add("@email", txbEmail.Text);
            parameters.Add("@quyen", cbquyen.Text);
            parameters.Add("@maKhoa", cbkhoa.Text);
            parameters.Add("@trangThai", cbbTrangThai.Text);
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

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}

