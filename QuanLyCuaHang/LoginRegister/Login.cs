using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHang;
using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;

namespace QuanLyCuaHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn không?", "Thoát ứng dụng", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_password.Text != "")
            {
                try
                {
                    User.username = txt_user.Text.Trim();
                    User.password = txt_password.Text.Trim();
                    
                    DatabaseExecute.con = DatabaseConnection.InitializeConnection(User.username, User.password);
                    DatabaseExecute.con.Open();
                    
                    //Sau khi đăng nhập thành công thì tiếp theo là sẽ lưu dữ liệu User vào trong database
                    DatabaseExecute dbExec = new DatabaseExecute();
                    dbExec.Query = $"EXEC SP_Insert_UserSessions '{User.username}'";
                    dbExec.executeQueryCommand();
                    dbExec.Query = $"EXEC SP_Insert_StatusDangNhap '{User.username}'";
                    dbExec.executeQueryCommand();

                    Dashboard dashBoard = new Dashboard();
                    dashBoard.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Sai thông tin đăng nhập");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                txt_user.FillColor = Color.FromArgb(255, 128, 128);
                txt_password.FillColor = Color.FromArgb(255, 128, 128);
                DialogResult r = MessageBox.Show("Điền dữ liệu vào chỗ trống", "Trống dữ liệu", MessageBoxButtons.OK);
                if (r == DialogResult.OK)
                {
                    txt_user.FillColor = Color.White;
                    txt_password.FillColor = Color.White;
                }
            }    

        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            this.Hide();
            rg.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
