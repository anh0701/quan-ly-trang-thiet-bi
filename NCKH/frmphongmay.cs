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
    public partial class frmphongmay : Form
    {
        public frmphongmay()
        {
            InitializeComponent();
            loaddgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spXoaPhong @maPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txtMaPM.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                DataTable cn = Database.Query(strCommand, parameters);
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spSuaPhong @maPhong, @tenPhong, @maNguoiQuanLy, @maChucNangPhong, @trangThai, @maKhoa ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txtMaPM.Text);
            parameters.Add("@tenPhong", txtMaPM.Text);
            parameters.Add("@maNguoiQuanLy", txtMaPM.Text);
            parameters.Add("@maChucNangPhong", txtMaPM.Text);
            parameters.Add("@trangThai", txtMaPM.Text);
            parameters.Add("@maKhoa", txtMaPM.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                DataTable cn = Database.Query(strCommand, parameters);
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spThemPhong @maPhong, @tenPhong, @maNguoiQuanLy, @maChucNangPhong, @trangThai, @maKhoa ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txtMaPM.Text);
            parameters.Add("@tenPhong", txtTenPM.Text);
            parameters.Add("@maNguoiQuanLy", txtNQL.Text);
            parameters.Add("@maChucNangPhong", txtCNP.Text);
            string check = "1";
            if (rdBaoTri.Checked)
            {
                check = "0";
            }
            parameters.Add("@trangThai", check);
            try
            {
                Database.Execute(strCommand, parameters);
                DataTable cn = Database.Query(strCommand, parameters);
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loaddgv()
        {
            string strQuery = "SELECT MaPhong, TenPhong, MaNguoiQuanLy, MaChucNang, TrangThai, MaKhoa  FROM Phong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            // parameters.Add("@email", "");
            dtgPhongMay.DataSource = Database.Query(strQuery, parameters);

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string str = "Select * from Phong where MaPhong = @maPhong or TenPhong like @tenPhong or MaNguoiQuanLy = @maNguoiQuanLy or MaChucNang = @maChucNangPhong or TrangThai = @trangThai ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txtMaPM.Text);
            parameters.Add("@tenPhong", txtTenPM.Text);
            parameters.Add("@maNguoiQuanLy", txtNQL.Text);
            parameters.Add("@maChucNangPhong", txtCNP.Text);
            string check = "1";
            if (rdBaoTri.Checked)
            {
                check = "0";
            }
            parameters.Add("@trangThai", check);
            DataTable table = Database.Query(str, parameters);
            dtgPhongMay.DataSource = table;
        }

        private void dtgPhongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clMaPM"].Value.ToString();
            txtTenPM.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clTenPM"].Value.ToString();
            txtCNP.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clCN"].Value.ToString();
            txtNQL.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clNgQL"].Value.ToString();
            string trangthai = dtgPhongMay.Rows[e.RowIndex].Cells["clTrangThai"].Value.ToString();
            if (trangthai == "1")
            {
                rdSanSang.Checked = true;
            }
            else
            {
                rdBaoTri.Checked = true;
            }

        }
    }
}
}
