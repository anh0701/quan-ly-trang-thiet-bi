using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH
{
    static class Program
    {
        private static string tenDangNhap;
        private static string khoa;
        private static string tenkithuatvien;
        private static string quyen;
        public static string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        public static string Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }
        public static string TenKiThuatVien
        {
            get { return tenkithuatvien; }
            set { tenkithuatvien = value; }
        }
        public static string Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
