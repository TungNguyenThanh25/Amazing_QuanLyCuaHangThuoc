using QuanLyCuaHang.LoginRegister;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Database
{
    internal class DatabaseConnection
    {
        public static string ipAddress = "26.219.81.74"; // Server name

        public static string databaseName = "QL_CUAHANG_THUOC"; // Database

        public static string trustServer = "TrustServerCertificate=True";

        // Khởi tạo chuỗi kết nối
        public static SqlConnection InitializeConnection(string username, string password)
        {
            string connectionString = $"Data Source={ipAddress};" +
                                      $"Initial Catalog={databaseName};" +
                                      $"User ID={username};" +
                                      $"Password={password};" +
                                      $"{trustServer}";
            return new SqlConnection(connectionString);
        }
    }
}
