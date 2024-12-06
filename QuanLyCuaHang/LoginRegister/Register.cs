using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCuaHang
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private bool checkUsername(string username)
        {
            //Sau khi đăng nhập thành công thì tiếp theo là sẽ lưu dữ liệu User vào trong database
            DatabaseExecute dbExec = new DatabaseExecute();
            Console.WriteLine(DatabaseExecute.con);
            dbExec.Query = $"PRINT DBO.FUNC_CHECK_USER(" + $"'{username}')";
            dbExec.executeQueryCommand();

            string rs = DatabaseExecute.message;

            return rs.CompareTo("1") == 0;
        }

        private void button_dangki_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_password.Text != "")
            {
                string username = txt_user.Text.Trim();

                DatabaseExecute.con = DatabaseConnection.InitializeConnection("adminQL", "123");
                DatabaseExecute.con.Open();

                if (!checkUsername(username))
                {
                    if (txt_password.Text == txt_checkpassword.Text)
                    {
                        try
                        {
                            string password = txt_password.Text.Trim();

                            //Sau khi đăng nhập thành công thì tiếp theo là sẽ lưu dữ liệu User vào trong database
                            DatabaseExecute dbExec = new DatabaseExecute();
                            dbExec.Query = $"EXEC SP_Create_User " + $"'{username}', '{password}', '{DatabaseConnection.databaseName}'";
                            dbExec.executeQueryCommand();

                            MessageBox.Show("Đăng kí thành công");

                            Login lg = new Login();
                            lg.Show();
                            this.DestroyHandle();

                            DatabaseExecute.con = null;

                            MessageBox.Show("Đăng nhập");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            DatabaseExecute.con.Close();
                        }
                    }
                    else
                    {
                        txt_password.FillColor = Color.Red;
                        txt_checkpassword.FillColor = Color.Red;
                        DialogResult r = MessageBox.Show("Không trùng khớp", "Mật khẩu và nhập lại mật khẩu", MessageBoxButtons.OK);
                        if (r == DialogResult.OK)
                        {
                            txt_password.FillColor = Color.White;
                            txt_checkpassword.FillColor = Color.White;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!!!. Xin vui lòng nhập tên khác");
                }
            }
            else
            {
                txt_user.FillColor = Color.FromArgb(255, 128, 128);
                txt_password.FillColor = Color.FromArgb(255, 128, 128);
                txt_checkpassword.FillColor = Color.FromArgb(255, 128, 128);
                DialogResult r = MessageBox.Show("Điền dữ liệu vào chỗ trống", "Trống dữ liệu", MessageBoxButtons.OK);
                if (r == DialogResult.OK)
                {
                    txt_user.FillColor = Color.White;
                    txt_password.FillColor = Color.White;
                    txt_checkpassword.FillColor = Color.White;
                }
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_checkpasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn không?", "Thoát ứng dụng", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
