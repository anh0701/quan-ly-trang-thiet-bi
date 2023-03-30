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
    public partial class frmDonVi : Form
    {
        private DataTable DonVi = new DataTable();
        private void loaddtgvDonVi()
        {
            string strQuery = "SELECT * FROM DonVi";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgvDonVi.DataSource = table;

        }
        public frmDonVi()
        {
            InitializeComponent();
            loaddtgvDonVi();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
