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
    public partial class frmQuanLyThietBiMayTinh : Form
    {
        private void loaddtgrvChuot()
        {
            string strQuery = "SELECT * FROM ChuotMayTinh";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvChuot.DataSource = table;

        }
        private void loaddtgrvBanPhim()
        {
            string strQuery = "SELECT * FROM BanPhimMayTinh";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvBanPhim.DataSource = table;

        }
        private void loaddtgrvManHinh()
        {
            string strQuery = "SELECT * FROM ManHinhMayTinh";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvManHinh.DataSource = table;

        }
        private void loaddtgrvCase()
        {
            string strQuery = "SELECT * FROM CaseMayTinh";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvCase.DataSource = table;

        }
        List<string> listLoc = new List<string> { "None", "Kho", "Đang sử dụng","Bảo trì" };
        public frmQuanLyThietBiMayTinh()
        {
            InitializeComponent();
            loaddtgrvChuot();
            loaddtgrvBanPhim();
            loaddtgrvManHinh();
            loaddtgrvCase();
            comboBox4.DataSource = listLoc;
            comboBox3.DataSource = listLoc;
            comboBox2.DataSource = listLoc;
            comboBox1.DataSource = listLoc;

        }
        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox4.Text == "None")
            {
                string strQuery = "SELECT * FROM ChuotMayTinh";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else if (comboBox4.Text == "Kho")
            {
                string strQuery = "SELECT * FROM ChuotMayTinh where TrangThai = N'Sẵn Sàng'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else if (comboBox4.Text == "Bảo trì")
            {
                string strQuery = "SELECT * FROM ChuotMayTinh where TrangThai = N'Bảo trì'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else
            {
                string strQuery = "SELECT * FROM ChuotMayTinh where TrangThai = N'Đang sử dụng'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "None")
            {
                string strQuery = "SELECT * FROM BanPhimMayTinh";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else if (comboBox1.Text == "Kho")
            {
                string strQuery = "SELECT * FROM BanPhimMayTinh where TrangThai = N'Sẵn Sàng'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else if (comboBox1.Text == "Bảo trì")
            {
                string strQuery = "SELECT * FROM BanPhimMayTinh where TrangThai = N'Bảo trì'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else
            {
                string strQuery = "SELECT * FROM BanPhimMayTinh where TrangThai = N'Đang sử dụng'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
        }
        private void frmQuanLyThietBiMayTinh_Load(object sender, EventArgs e)
        {

        }

    

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "None")
            {
                string strQuery = "SELECT * FROM ManHinhMayTinh";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else if (comboBox2.Text == "Kho")
            {
                string strQuery = "SELECT * FROM ManHinhMayTinh where TrangThai = N'Sẵn Sàng'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else if (comboBox2.Text == "Bảo trì")
            {
                string strQuery = "SELECT * FROM ManHinhMayTinh where TrangThai = N'Bảo trì'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
            else
            {
                string strQuery = "SELECT * FROM ManHinhMayTinh where TrangThai = N'Đang sử dụng'";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable table = Database.Query(strQuery, parameters);
                dtgrvChuot.DataSource = table;
            }
        }
    }
}
