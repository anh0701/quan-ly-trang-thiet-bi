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
            string strCommand = "EXEC spSuaPhong @maPhong, @tenPhong, @maChucNangPhong, @trangThai, @maKhoa ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txtMaPM.Text);
            parameters.Add("@tenPhong", txtTenPM.Text);
            parameters.Add("@maChucNangPhong", cbbMaChucNang.Text);
            parameters.Add("@trangThai",cbbTrangThai.Text);
            parameters.Add("@maKhoa", Program.Khoa);
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
            string strCommand = "EXEC spThemPhong @maPhong, @tenPhong, @maChucNangPhong, @trangThai, @maKhoa ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txtMaPM.Text);
            parameters.Add("@tenPhong", txtTenPM.Text);
            parameters.Add("@maChucNangPhong", cbbMaChucNang.Text);
            parameters.Add("@trangThai",cbbTrangThai.Text);
            parameters.Add("@maKhoa", Program.Khoa);
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
            string strQuery = "SELECT *  FROM Phong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            // parameters.Add("@email", "");
            dtgPhongMay.DataSource = Database.Query(strQuery, parameters);

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string str = "Select * from Phong where MaPhong = @maPhong or TenPhong like @tenPhong  or MaChucNang = @maChucNangPhong or TrangThai = @trangThai ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txtMaPM.Text);
            parameters.Add("@tenPhong", txtTenPM.Text);
            parameters.Add("@maChucNangPhong", cbbMaChucNang.Text);           
            parameters.Add("@trangThai", cbbTrangThai.Text);
            DataTable table = Database.Query(str, parameters);
            dtgPhongMay.DataSource = table;
        }

        private void dtgPhongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clMaPM"].Value.ToString();
            txtTenPM.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clTenPM"].Value.ToString();
            cbbMaChucNang.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clCN"].Value.ToString();            
            cbbTrangThai.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clTrangThai"].Value.ToString();
        }

        private void frmphongmay_Load(object sender, EventArgs e)
        {

        }
    }
}
