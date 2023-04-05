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
    public partial class frmPhanMem : Form
    {
        private DataTable PhanMem = new DataTable();
        public frmPhanMem()
        {
            InitializeComponent();
            loaddtgvPhanMem();
        }
        private void loaddtgvPhanMem()
        {
            string strQuery = "SELECT * FROM PhanMem";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgvPhanMem.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btoXoa_Click(object sender, EventArgs e)
        {

        }

        
    }
}
