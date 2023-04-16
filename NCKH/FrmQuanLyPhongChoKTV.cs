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
    public partial class FrmQuanLyPhongChoKTV : Form
    {
        public FrmQuanLyPhongChoKTV()
        {
            InitializeComponent();
        }

        private void FrmQuanLyPhongChoKTV_Load(object sender, EventArgs e)
        {
            TenKhoa.Text = Program.Khoa;
            TenKTV.Text = Program.TenKiThuatVien;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string strQuery = "SELECT Phong.MaPhong,Phong.TenPhong,Phong.MaChucNang,Phong.TrangThai FROM Phong inner join QuanLyNhieuPhong on Phong.MaPhong= QuanLyNhieuPhong.MaPhong where 1=1 ";
            if(Program.Quyen == "KTV")
            {
                strQuery += " and TenDangNhap = '" + Program.TenDangNhap + "'";
            }
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    // Select the row
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[currentMouseOverRow].Selected = true;

                    // Create a new ContextMenuStrip
                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    // Add some options to the menu
                    ToolStripMenuItem chinhSua = new ToolStripMenuItem("Chỉnh sửa");
                    contextMenu.Items.Add(chinhSua);
                    ToolStripMenuItem Xoa = new ToolStripMenuItem("Xóa");
                    contextMenu.Items.Add(Xoa);

                    chinhSua.Click += new EventHandler(chinhSua_Click);

                    // Show the menu at the location of the mouse click
                    contextMenu.Show(dataGridView1, e.Location);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow i = dataGridView1.Rows[e.RowIndex];
            MaPhong = i.Cells["ColMaPhong"].Value.ToString();
            TenPhong = i.Cells["ColTenPhong"].Value.ToString();
        }
    }
}
