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
    public partial class frmChucNangPhong : Form
    {
        private DataTable ChucNangPhong = new DataTable();
        public frmChucNangPhong()
        {
            InitializeComponent();
            loaddtgvChucNangPhong();
        }
        private void loaddtgvChucNangPhong()
        {
            string strQuery = "SELECT * FROM ChucNangPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgvChucNangPhong.DataSource = table;

        }

        private void dtgvChucNangPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
