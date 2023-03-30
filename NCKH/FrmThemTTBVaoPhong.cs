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
        public FrmThemTTBVaoPhong()
        {
            InitializeComponent();
            loaddtgvChiTietTrangThietBiCoTrongPhong();
        }
        private void loaddtgvChiTietTrangThietBiCoTrongPhong()
        {
            string strQuery = "SELECT * FROM ChiTietTrangThietBiCoTrongPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dataGridView1.DataSource = table;

        }
        private void FrmThemTTBVaoPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
