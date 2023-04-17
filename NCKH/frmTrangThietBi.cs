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
    public partial class FrmTrangThietBi : Form
    {
        public FrmTrangThietBi()
        {
            InitializeComponent();
        }
        List<string> listLoc = new List<string> { "None", "Kho", "Đang sử dụng" };
        private void loaddtgrvTrangThietBi()
        {
            string strQuery = "SELECT MaTrangThietBi,TenTrangThietBi,Hang,SoLuong,MaDonVi,MaLoaiTrangThietBi,ThongSoKiThuat,TrangThai FROM TrangThietBi";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dataGridView1.DataSource = table;

        }
        private void FrmTrangThietBi_Load(object sender, EventArgs e)
        {
            loaddtgrvTrangThietBi();
            comboBox4.DataSource = listLoc;
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "None")
            {
                string strQuery = "SELECT MaTrangThietBi,TenTrangThietBi,Hang,SoLuong,MaDonVi,MaLoaiTrangThietBi,ThongSoKiThuat,TrangThai FROM TrangThietBi";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dataGridView1.DataSource = table;
            }
            else if(comboBox4.Text == "Kho")
            {
                string strQuery = "SELECT MaTrangThietBi,TenTrangThietBi,Hang,SoLuong,MaDonVi,MaLoaiTrangThietBi,ThongSoKiThuat,TrangThai FROM TrangThietBi where TrangThai = @trangThai";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@trangThai","Sẵn Sàng");
                DataTable table = Database.Query(strQuery, parameters);
                dataGridView1.DataSource = table;
            }
            else
            {
                string strQuery = "SELECT MaTrangThietBi,TenTrangThietBi,Hang,SoLuong,MaDonVi,MaLoaiTrangThietBi,ThongSoKiThuat,TrangThai FROM TrangThietBi where TrangThai = @trangThai";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@trangThai","Đang sử dụng");
                DataTable table = Database.Query(strQuery, parameters);
                dataGridView1.DataSource = table;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
