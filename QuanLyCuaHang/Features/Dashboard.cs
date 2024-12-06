using QuanLyCuaHang;
using QuanLyCuaHang.Database;
using QuanLyCuaHang.Features;
using QuanLyCuaHang.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class Dashboard : Form
    {
        public Dashboard()
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = $"{User.username}";
            uC_CuaHang3.Visible = false;
            uC_GioHang2.Visible = false;
            uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;
            btn_cuahang.PerformClick();

            if (User.username == "sa")
            {
                button_doanhthu.Visible = true;
                uC_DoanhThu1.Visible = true;
                uC_QuanLyNhanVien1.Visible = true;
                uC_QuanLyKhachHang1.Visible = true;
                button_quanlynhanvien.Visible = true;
                button_quanlykhachhang.Visible = true;
            }
            else
            {
                button_doanhthu.Visible = false;
                uC_DoanhThu1.Visible = false;
                uC_QuanLyNhanVien1.Visible = false;
                button_quanlynhanvien.Visible = false;
                button_quanlynhanvien.Visible = false;
                button_quanlykhachhang.Visible = false; 
            }

        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            uC_CuaHang3.Visible = false;
            uC_GioHang2.Visible = false;
            //uC_GioHang1.Visible = false;
            //uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;

            //uC_KhoHang2.clearData();

            panel_moving.Left = btn_kho.Left + 1;
            uC_KhoHang2.Visible = true;
            uC_KhoHang2.BringToFront();
        }

        private void btn_GioHang_Click(object sender, EventArgs e)
        {
            uC_CuaHang3.Visible = false;
            //uC_GioHang1.Visible = false;
            uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;

            uC_GioHang2.clearData();

            panel_moving.Left = btn_GioHang.Left + 1;
            //uC_GioHang1.Visible = true;
            //uC_GioHang1.BringToFront();
            uC_GioHang2.Visible = true;
            uC_GioHang2.BringToFront();
        }

        private void btn_cuahang_Click(object sender, EventArgs e)
        {
            //uC_CuaHang3.Visible = false;
            //uC_GioHang1.Visible = false;
            uC_GioHang2.Visible = false;
            uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;

            uC_CuaHang3.clearData();

            panel_moving.Left = btn_cuahang.Left + 0;
            uC_CuaHang3.Visible = true;
            uC_CuaHang3.BringToFront();
        }

        private void button_khuyenmai_Click(object sender, EventArgs e)
        {
            uC_CuaHang3.Visible = false;
            //uC_GioHang1.Visible = false;
            uC_GioHang2.Visible = false;
            uC_KhoHang2.Visible = false;
            //uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;

            //uC_KhuyenMai1.clearData();

            panel_moving.Left = button_khuyenmai.Left + 1;
            uC_KhuyenMai1.Visible = true;
            uC_KhuyenMai1.BringToFront();
        }
        private void btn_minisize_Click(object sender, EventArgs e)
        {

        }

        private void button_doanhthu_Click(object sender, EventArgs e)
        {
            uC_CuaHang3.Visible = false;
            //uC_GioHang1.Visible = false;
            uC_GioHang2.Visible = false;
            uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            //uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;

            uC_DoanhThu1.clearData();

            panel_moving.Left = button_doanhthu.Left + 1;
            uC_DoanhThu1.Visible = true;
            uC_DoanhThu1.BringToFront();
        }
        //lịch sử mua
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_CuaHang3.Visible = false;
            //uC_GioHang1.Visible = false;
            uC_GioHang2.Visible = false;
            uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            //uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;

            uC_LichSuMua1.clearData();

            panel_moving.Left = btn_lichsumua.Left + 1;
            uC_LichSuMua1.Visible = true;
            uC_LichSuMua1.BringToFront();

        }

        private void uC_CuaHang1_Load(object sender, EventArgs e)
        {

        }

        private void panel_moving_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_CuaHang2_Load(object sender, EventArgs e)
        {

        }

        private void uC_CuaHang2_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_KhoHang2_Load(object sender, EventArgs e)
        {

        }

        private void timer_logout_Tick(object sender, EventArgs e)
        {
            try
            {
                //Lấy các dòng dữ liệu
                DatabaseExecute dbExc = new DatabaseExecute();
                dbExc.Query = $"EXEC SP_Select_UserSessions '{User.username}'";
                DataTable dTable = new DataTable();
                dbExc.executeQueryDataAdapter().Fill(dTable); // Trả dữ liệu vô bảng

                if (dTable.Rows.Count == 0)
                {
                    timer_logout.Stop();
                    Login login = new Login();
                    DatabaseExecute.con = null;
                    this.DestroyHandle();
                    login.Show();
                    MessageBox.Show($"Người dùng '{User.username}' đã đăng xuất", "Thông báo!");

                    //Console.WriteLine("Stop the checking!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error---> " + ex.Message);
            }
            //Console.WriteLine("We are checking login status!");
        }

        private void uC_CuaHang3_Load(object sender, EventArgs e)
        {

        }

        private void uC_GioHang1_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            //Dừng time lại
            timer_logout.Stop();

            //Xoá dữ liệu database của tài khoản đăng nhập sau khi đăng xuất
            DatabaseExecute dbExc = new DatabaseExecute();
            dbExc.Query = $"exec SP_Delete_UserSessions '{User.username}'";
            dbExc.executeQueryCommand();

            //Thực hiện ngắt kết nối và chuyển về trang Login
            Login login = new Login();
            DatabaseExecute.con = null;

            this.DestroyHandle();
            login.Show();
        }

        private void uC_LichSuMua1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uC_GioHang2_Load(object sender, EventArgs e)
        {

        }

        private void uC_KhuyenMai1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_quanlykhachhang_Click(object sender, EventArgs e)
        {
            uC_CuaHang3.Visible = false;
            //uC_GioHang1.Visible = false;
            uC_GioHang2.Visible = false;
            uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;
            
            //uC_QuanLyKhachHang1.clearData();

            panel_moving.Left = button_quanlykhachhang.Left;
            uC_QuanLyKhachHang1.Visible = true;
            uC_QuanLyKhachHang1.BringToFront();
        }

        private void button_quanlynhanvien_Click(object sender, EventArgs e)
        {
            uC_CuaHang3.Visible = false;
            //uC_GioHang1.Visible = false;
            uC_GioHang2.Visible = false;
            uC_KhoHang2.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_DoanhThu1.Visible = false;
            uC_LichSuMua1.Visible = false;
            uC_QuanLyKhachHang1.Visible=false;
            
            //uC_QuanLyNhanVien1.clearData();

            //uC_QuanLyNhanVien1.Visible = false;
            panel_moving.Left = button_quanlynhanvien.Left;
            uC_QuanLyNhanVien1.Visible = true;
            uC_QuanLyNhanVien1.BringToFront();
        }
    }
}
