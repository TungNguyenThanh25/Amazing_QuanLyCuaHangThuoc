using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Database
{
    internal class DatabaseExecute
    {
        private string query; // Query để thực hiện sql
        public string Query { get => query; set => query = value; }

        public static string message;
        
        public static SqlConnection con = null;

        private static void turnOnMessage()
        {
            con.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
        }

        public void executeQueryCommand()
        {
            turnOnMessage();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }

        public SqlDataAdapter executeQueryDataAdapter()
        {
            return new SqlDataAdapter(Query, con);
        }
        // Hiện thông báo tự động khi bên sql có print
        private static void OnInfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            message = e.Message;
        }
    }
}
