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
    public partial class FrmThemTrangThietBi : Form
    {
        
        List<string> listTK = new List<string> { "Tên", "Trạng thái" };
        public FrmThemTrangThietBi()
        {
            InitializeComponent();
            cbMaTrangThietBi.DataSource = Database.Query("SELECT * FROM TrangThietBi", new Dictionary<string, object>());
            cbMaMayTinh.DataSource = Database.Query("SELECT * FROM MayTinh", new Dictionary<string, object>());
            cbMaMonHoc.DataSource = Database.Query("SELECT * FROM MonHoc", new Dictionary<string, object>());
            cbMaPhanMem.DataSource = Database.Query("SELECT * FROM PhanMem", new Dictionary<string, object>());
            cbtimkiemTTB.DataSource = listTK;
        }
        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            
            if (cbtimkiemTTB.Text == "Tên")
            {
                string strQuery = "SELECT Phong.TenPhong, TrangThietBi.TenTrangThietBi,TrangThietBi.Hang, ChiTietTrangThietBiCoTrongPhong.SoLuong,ChiTietTrangThietBiCoTrongPhong.MaDonVi ,TrangThietBi.ThongSoKiThuat,TrangThietBi.TrangThai FROM TrangThietBi INNER JOIN ChiTietTrangThietBiCoTrongPhong ON TrangThietBi.MaTrangThietBi = ChiTietTrangThietBiCoTrongPhong.MaTrangThietBi INNER JOIN Phong ON ChiTietTrangThietBiCoTrongPhong.MaPhong = Phong.MaPhong WHERE Phong.MaPhong = @maPhong";
                strQuery += " and TrangThietBi.TenTrangThietBi LIKE '%' + N'"+txbtimkiemTTB.Text+"' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maPhong", txbMaPhongTTB.Text);
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChiTietTTB.DataSource = table;
            }
            else if (cbtimkiemTTB.Text == "Trạng thái")
            {
                string strQuery = "SELECT Phong.TenPhong, TrangThietBi.TenTrangThietBi,TrangThietBi.Hang, ChiTietTrangThietBiCoTrongPhong.SoLuong,ChiTietTrangThietBiCoTrongPhong.MaDonVi ,TrangThietBi.ThongSoKiThuat,TrangThietBi.TrangThai FROM TrangThietBi INNER JOIN ChiTietTrangThietBiCoTrongPhong ON TrangThietBi.MaTrangThietBi = ChiTietTrangThietBiCoTrongPhong.MaTrangThietBi INNER JOIN Phong ON ChiTietTrangThietBiCoTrongPhong.MaPhong = Phong.MaPhong WHERE Phong.MaPhong = @maPhong";
                strQuery += " and TrangThietBi.TrangThai LIKE '%' + N'" + txbtimkiemTTB.Text + "' + '%'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@maPhong", txbMaPhongTTB.Text);
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChiTietTTB.DataSource = table;
            }           
        }
        private void loaddtgvTTB()
        {
            string strQuery = "SELECT Phong.TenPhong, TrangThietBi.TenTrangThietBi,TrangThietBi.Hang, ChiTietTrangThietBiCoTrongPhong.SoLuong,ChiTietTrangThietBiCoTrongPhong.MaDonVi ,TrangThietBi.ThongSoKiThuat,TrangThietBi.TrangThai FROM TrangThietBi INNER JOIN ChiTietTrangThietBiCoTrongPhong ON TrangThietBi.MaTrangThietBi = ChiTietTrangThietBiCoTrongPhong.MaTrangThietBi INNER JOIN Phong ON ChiTietTrangThietBiCoTrongPhong.MaPhong = Phong.MaPhong WHERE Phong.MaPhong = @maPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txbMaPhongTTB.Text);
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvChiTietTTB.DataSource = table;

        }
        private void loaddtgvMT()
        {
            string strQuery = "SELECT Phong.TenPhong, MayTinh.TenMayTinh,MayTinh.ChucNangMayTinh,MayTinh.MaBanPhimMayTinh,MayTinh.MaChuotMayTinh,MayTinh.MaCaseMayTinh,MayTinh.MaManHinhMayTinh, ChiTietMayTinhCoTrongPhong.SoLuong,ChiTietMayTinhCoTrongPhong.MaDonVi, MayTinh.TrangThai FROM MayTinh INNER JOIN ChiTietMayTinhCoTrongPhong ON MayTinh.MaMayTinh = ChiTietMayTinhCoTrongPhong.MaMayTinh INNER JOIN Phong ON ChiTietMayTinhCoTrongPhong.MaPhong = Phong.MaPhong WHERE Phong.MaPhong = @maPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", txbMaPhongTTB.Text);
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvChiTietMT.DataSource = table;

        }
        private void loaddtgvMH()
        {
            string strQuery = "SELECT * FROM TaiKhoan";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvChiTietMH.DataSource = table;

        }
        private void loaddtgvPM()
        {
            string strQuery = "SELECT * FROM TaiKhoan";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvChiTietPM.DataSource = table;

        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string LayTen(string Ten,string maTTB)
        {
            string str = "select * from " + Ten + " where Ma"+Ten+" = @maTTB";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maTTB", maTTB);
            DataTable result = Database.Query(str, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0][1].ToString();
            }
            else
            {
                string tr = "Bảng chưa có dữ liệu";
                return tr; // hoặc trả về một giá trị khác tùy thuộc vào yêu cầu
            }
        }
        public static string LayDonVi(string maTTB)
        {
            string str = "select * from TrangThietBi where MaTrangThietBi = @maTTB";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maTTB", maTTB);
            DataTable result = Database.Query(str, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0][3].ToString();
            }
            else
            {
                string tr = "Bảng chưa có dữ liệu";
                return tr; // hoặc trả về một giá trị khác tùy thuộc vào yêu cầu
            }
        }
        private void cbMaTrangThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTenTrangThietBi.Text = LayTen("TrangThietBi",cbMaTrangThietBi.Text);
            txbDonViTTB.Text = LayDonVi(cbMaTrangThietBi.Text);
        }

        private void cbMaMayTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTenMayTinh.Text = LayTen("MayTinh", cbMaMayTinh.Text);
        }

        private void cbMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTenMonHoc.Text = LayTen("MonHoc", cbMaMonHoc.Text);
        }

        private void cbMaPhanMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTenPhanMem.Text = LayTen("PhanMem", cbMaPhanMem.Text);
        }

        private void FrmThemTrangThietBi_Load(object sender, EventArgs e)
        {
            loaddtgvTTB();
        }

        private void cbtimkiemTTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
