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
    public partial class ThemPhongQuanLy : Form
    {
        public ThemPhongQuanLy()
        {
            InitializeComponent();
        }
        private static string tendn;
        public static string TenDN
        {
            get { return tendn; }
            set { tendn = value; }
        }
        private void ThemPhongQuanLy_Load(object sender, EventArgs e)
        {
            string str1 = "select * from PhongQuanLy ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();           
            DataTable result1 = Database.Query(str1, parameters);
            for(int i = 0; i < result1.Rows.Count; i++)
            {
                listBox1.Items.Add((string)result1.Rows[i][1]);
            }
            string str2 = "select * from QuanLyNhieuPhong where TenDangNhap='"+TenDN+"'";           
            DataTable result2 = Database.Query(str2, parameters);
            for (int i = 0; i < result2.Rows.Count; i++)
            {
                listBox2.Items.Add(LayTenPhong((string)result2.Rows[i][2]));
            }
        }
        public static string LayMaPhong(string tenPhong)
        {
            string str = "select * from Phong where TenPhong = @tenPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenPhong", tenPhong);
            DataTable result = Database.Query(str, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            else
            {
                string tr = "Bảng chưa có dữ liệu";
                return tr; 
            }
        }
        public static string LayTenPhong(string maPhong)
        {
            string str = "select * from Phong where MaPhong = @maPhong";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhong", maPhong);
            DataTable result = Database.Query(str, parameters);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0][1].ToString();
            }
            else
            {
                string tr = "Bảng chưa có dữ liệu";
                return tr;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != "")
            {
                string str1 = "insert QuanLyNhieuPhong values(@tenDangNhap,@maPhong)";
                string str2 = "delete PhongQuanLy where TenPhong=@tenPhong";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@tenDangNhap", TenDN);
                parameters.Add("@maPhong", LayMaPhong(listBox1.SelectedItem.ToString()));
                parameters.Add("@tenPhong", listBox1.SelectedItem.ToString());
                Database.Execute(str1, parameters);
                Database.Execute(str2, parameters);
            }
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != "")
            {
                string str1 = "insert PhongQuanLy values(@tenPhong)";
                string str2 = "delete QuanLyNhieuPhong where MaPhong=@maPhong";
                Dictionary<string, object> parameters = new Dictionary<string, object>();               
                parameters.Add("@maPhong", LayMaPhong(listBox2.SelectedItem.ToString()));
                parameters.Add("@tenPhong", listBox2.SelectedItem.ToString());
                Database.Execute(str1, parameters);
                Database.Execute(str2, parameters);
            }
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

 
    }
}
