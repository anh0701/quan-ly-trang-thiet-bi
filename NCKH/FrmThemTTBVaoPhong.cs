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
    public partial class FrmThemTTBVaoPhong : Form
    {
        List<string> listcbtimkiem = new List<string> { "None", "Mã phòng", "Mã ", "Quyền", "Khoa", "Phòng", "Trạng thái" };
        public FrmThemTTBVaoPhong()
        {
            InitializeComponent();
            loaddtgvChiTietTrangThietBiCoTrongPhong();
            cbtimkiem.DataSource = listcbtimkiem;
        }
        public static string LayTenPhong(string a)
        {
          
            string str = "select * from Phong where MaPhong = '" + a + "'";
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader RD = command.ExecuteReader();
            if (RD.Read())
            {
                str = RD[6].ToString();
            }
            connection.Close();
            return str;
        }
        private void loaddtgvChiTietTrangThietBiCoTrongPhong()
        {
            string strQuery = "SELECT * FROM ChiTietTrangThietBiCoTrongPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvChiTiet.DataSource = table;

        }
        private void FrmThemTTBVaoPhong_Load(object sender, EventArgs e)
        {

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
    }
}
