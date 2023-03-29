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
    public partial class FrmThemTTBVaoCase : Form
    {
        public FrmThemTTBVaoCase()
        {
            InitializeComponent();
            loaddtgvChiTietTrangThietBiCoTrongCase();
        }
        private void loaddtgvChiTietTrangThietBiCoTrongCase()
        {
            string strQuery = "SELECT * FROM ChiTietTrangThietBiCoTrongCase";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dataGridView1.DataSource = table;

        }
        private void FrmThemTTBVaoCase_Load(object sender, EventArgs e)
        {

        }
    }
}
