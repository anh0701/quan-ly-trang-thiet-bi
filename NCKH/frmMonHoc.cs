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
    public partial class frmMonHoc : Form
    {
        private DataTable MonHoc = new DataTable();
        public frmMonHoc()
        {
            InitializeComponent();
            loaddtgrvMonHoc();
        }
        private void loaddtgrvMonHoc()
        {
            string strQuery = "SELECT * FROM MonHoc";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvMonHoc.DataSource = table;

        }
    }
}
