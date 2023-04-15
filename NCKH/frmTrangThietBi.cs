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
        List<string> listcbloaithietbi = new List<string> { "Chuột", "Bàn phím", "màn hình","Case máy tính" };

        
        

        private void loaddtgvTrangThietBi()
        {
            string strQuery = "SELECT * FROM TrangThietBi;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgrvTrangThietBi.DataSource = table;
            
            

        }
        
        public frmQuanLyThietBiMayTinh()
        {
            InitializeComponent();
            loaddtgvTrangThietBi();
            cbLoaiThietBi.DataSource = listcbloaithietbi;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
