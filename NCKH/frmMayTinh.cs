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

    public partial class frmMayTinh : Form
    {
        private DataTable MayTinh = new DataTable();
        private void loaddtgrvMayTinh()
        {
            string strQuery = "SELECT * FROM MayTinh";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvMayTinh.DataSource = table;
        }
            public frmMayTinh()
        {
            InitializeComponent();
            loaddtgrvMayTinh();
        }
    }
}
