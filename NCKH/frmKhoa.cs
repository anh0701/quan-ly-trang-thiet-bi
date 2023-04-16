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
    public partial class frmKhoa : Form
    {
        private DataTable Khoa = new DataTable();
        private void loaddtgrvKhoa()
        {
            string strQuery = "SELECT * FROM Khoa";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvKhoa.DataSource = table;

        }
        public frmKhoa()
        {
            InitializeComponent();
            loaddtgrvKhoa();
        }
    }
}
