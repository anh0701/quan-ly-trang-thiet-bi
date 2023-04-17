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
            cbbMaChucNang.DataSource = Database.Query("Select*from ChucNangPhong", new Dictionary<string, object>());
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
            MaPhong= txtMaPM.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clMaPM"].Value.ToString();
            TenPhong= txtTenPM.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clTenPM"].Value.ToString();
            cbbMaChucNang.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clCN"].Value.ToString();            
            cbbTrangThai.Text = dtgPhongMay.Rows[e.RowIndex].Cells["clTrangThai"].Value.ToString();
        }

        private void frmphongmay_Load(object sender, EventArgs e)
        {

        }
        private void dtgPhongMay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dtgPhongMay.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    // Select the row
                    dtgPhongMay.ClearSelection();
                    dtgPhongMay.Rows[currentMouseOverRow].Selected = true;

                    // Create a new ContextMenuStrip
                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    // Add some options to the menu
                    ToolStripMenuItem chinhSua = new ToolStripMenuItem("Chỉnh sửa");
                    contextMenu.Items.Add(chinhSua);
                    ToolStripMenuItem Xoa = new ToolStripMenuItem("Xóa");
                    contextMenu.Items.Add(Xoa);

                    chinhSua.Click += new EventHandler(chinhSua_Click);

                    // Show the menu at the location of the mouse click
                    contextMenu.Show(dtgPhongMay, e.Location);
                }
            }
        }
        private void chinhSua_Click(object sender, EventArgs e)
        {
            FrmThemTrangThietBi form2 = new FrmThemTrangThietBi();
            form2.txbMaPhongMH.Text = form2.txbMaPhongMT.Text = form2.txbMaPhongPM.Text = form2.txbMaPhongTTB.Text = MaPhong;
            form2.txbTenPhongMH.Text = form2.txbTenPhongMT.Text = form2.txbTenPhongPM.Text = form2.txbTenPhongTTB.Text = TenPhong;
            form2.ShowDialog();
        }
        string MaPhong;
        string TenPhong;
        
        private void frmphongmay_Load_1(object sender, EventArgs e)
        {

        }
    }
}
