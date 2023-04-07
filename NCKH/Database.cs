using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH
{
    class Database
    {
        private static string strConnection = @"Data Source=LAPTOP-G10UU6CK\SQLEXPRESS;Initial Catalog=QuanLyTrangThietBi1;Integrated Security=True";
        public static void Execute(string strCommand, Dictionary<string, object> parameters)
        {
            //Bước 1: Sử dụng chuỗi kết nối để tạo đối tượng kết nối, và mở kết nối
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            //Bước 2: Tạo ra 1 đối tượng câu lệnh
            SqlCommand command = new SqlCommand(strCommand, connection);
            foreach (string key in parameters.Keys)
                command.Parameters.Add(new SqlParameter(key, parameters[key]));
            //Bước 3: Thực thi câu lệnh và đóng kết nối
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static string LayMaKhoa(string a)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            string str = "select * from TaiKhoan where TenDangNhap = '" + a + "'";
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader RD = command.ExecuteReader();
            if (RD.Read())
            {
                str = RD[6].ToString();
            }
            connection.Close();
            return str;
        }
        public static string LayQuyen(string a)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            string str = "select * from TaiKhoan where TenDangNhap = '" + a + "'";
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader RD = command.ExecuteReader();
            if (RD.Read())
            {
                str = RD[5].ToString();
            }
            connection.Close();
            return str;
        }
        public static string LayTenKTV(string a)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            string str = "select * from TaiKhoan where TenDangNhap = '" + a + "'";
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader RD = command.ExecuteReader();
            if (RD.Read())
            {
                str = RD[2].ToString();
            }
            connection.Close();
            return str;
        }
        public static DataTable Query(string strQuery, Dictionary<string, object> parameters)
        {
            //Bước 1: Sử dụng chuỗi kết nối để tạo đối tượng kết nối, và mở kết nối
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            //Bước 2: Tạo ra 1 đối tượng câu lệnh
            SqlCommand command = new SqlCommand(strQuery, connection);
            foreach (string key in parameters.Keys)
                command.Parameters.Add(new SqlParameter(key, parameters[key]));
            //Bước 3: Tạo ra 1 bộ nạp dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Bước 4: Tạo ra 1 bảng dữ liệu và đổ dữ liệu vào
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
