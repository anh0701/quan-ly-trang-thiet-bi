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
        private static string strConnection = @"Data Source=DESKTOP-PHTHSKI\SQLEXPRESS;Initial Catalog=QuanLyTrangThietBi;Integrated Security=True";
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
