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
    public partial class frmchucnangphong : Form
    {
        public frmchucnangphong()
        {
            InitializeComponent();
            loaddgv();
        }
        private void loaddgv()
        {
            string strQuery = "SELECT * FROM ChucNangPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(strQuery, parameters);
            dtgCN.DataSource = table;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spThemChucNangPhong @maChucNang, @tenChucNang  ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maChucNang", txtMaCN.Text);
            parameters.Add("@tenChucNang", txtTenCN.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                DataTable cn = Database.Query(strCommand, parameters);
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /*  private void frmchucnangphong_Load(object sender, EventArgs e)
          {
              string strQuery = "SELECT MaChucNang, TenChucNang  FROM ChucNangPhong";
              Dictionary<string, object> parameters = new Dictionary<string, object>();

              // parameters.Add("@email", "");
              dtgCN.DataSource = Database.Query(strQuery, parameters);
          }*/

        private void dtgCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCN.Text = dtgCN.Rows[e.RowIndex].Cells["clMaCN"].Value.ToString();
            txtTenCN.Text = dtgCN.Rows[e.RowIndex].Cells["colTenCN"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string strCommand = "EXEC spSuaChucNangPhong @maChucNang, @tenChucNang ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maChucNang", txtMaCN.Text);
            parameters.Add("@tenChucNang", txtTenCN.Text);
            try
            {
                Database.Execute(strCommand, parameters);
                DataTable cn = Database.Query(strCommand, parameters);
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
            string str = "Select * from ChucNangPhong where TenChucNang LIKE  N'" + txtTenCN.Text + "' or MaChucNang = '" + txtMaCN.Text + "'";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable table = Database.Query(str, parameters);
            dtgCN.DataSource = table;
            //MessageBox.Show("đã click");
        }

    }
}
