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
    public partial class frmLoaiTrangThietBi : Form
    {
        private DataTable LoaiTrangThietBi = new DataTable();
        public frmLoaiTrangThietBi()
        {
            InitializeComponent();
            loaddtgvLoaiTrangThietBi();
        }
        private void loaddtgvLoaiTrangThietBi()
        {
            string strQuery = "SELECT * FROM LoaiTrangThietBi";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgvLoaiTrangThietBi.DataSource = table;

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
