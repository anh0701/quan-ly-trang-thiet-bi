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

        
        private DataTable BanPhimMayTinh = new DataTable();
        private DataTable ChuotMayTinh = new DataTable();
        private DataTable ManHinhMayTinh = new DataTable();
        private DataTable CaseMayTinh = new DataTable();

        private void loaddtgvThietBiMayTinh()
        {
            string strQuery = "SELECT * FROM ChuotMayTinh";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgvThietBiMayTinh.DataSource = table;
            
            

        }
        
        public frmQuanLyThietBiMayTinh()
        {
            InitializeComponent();
            loaddtgvThietBiMayTinh();
            cbloaithietbi.DataSource = listcbloaithietbi;
        }
 
    }
}
