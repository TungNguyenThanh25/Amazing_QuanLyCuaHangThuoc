using QuanLyCuaHang.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Features
{
    public partial class UC_ThayDoiThongTinKhachHang : UserControl
    {
        public UC_ThayDoiThongTinKhachHang()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new EventArgs());
            guna2ComboBox2_Load(this, new EventArgs());
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        private void guna2ComboBox1_Load(object sender, EventArgs e)
        {
            string[] gender = { "Nam", "Nữ" };
            guna2ComboBox1.DataSource = gender;
        }

        private void guna2ComboBox2_Load(object sender, EventArgs e)
        {
            string[] type = { "Vip", "Thường" };
            guna2ComboBox2.DataSource = type;
        }

        public void clearData()
        {
            txt_diachikhachhangcanthaydoi.Clear();
            txt_emailkhachhangcanthaydoi.Clear();
            txt_makhachhangcantimthaydoi.Clear();
            txt_sodienthoaikhachhangcanthaydoi.Clear();
            txt_tenkhachhangcanthaydoi.Clear();
        }

        private void btn_huythemthongtinkhachhang_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private DataTable loadThongTinKhachHang()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            DataTable dataTable = new DataTable();
            try
            {
                dbExec.Query = $"EXEC SP_Select_KhachHang_ByMaKhachHang " +
                               $"'{txt_makhachhangcantimthaydoi.Text.Trim()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return dataTable;
        }

        private void updateThongTinKhachHang()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            DataTable dataTable = new DataTable();
            try
            {
                dbExec.Query = $"EXEC SP_Update_KhachHang " +
                               $"'{txt_makhachhangcantimthaydoi.Text.Trim()}', " +
                               $"N'{txt_tenkhachhangcanthaydoi.Text.Trim()}', " +
                               $"N'{guna2ComboBox1.SelectedItem.ToString().Trim()}', " +
                               $"'{txt_diachikhachhangcanthaydoi.Text.Trim()}', " +
                               $"'{txt_sodienthoaikhachhangcanthaydoi.Text.Trim()}', " +
                               $"'{txt_emailkhachhangcanthaydoi.Text.Trim()}', " +
                               $"'{guna2ComboBox2.SelectedItem.ToString().Trim()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_thongtinkhachhangthaydoi_Click(object sender, EventArgs e)
        {
            updateThongTinKhachHang();
            RefreshData();
            clearData();
        }

        private void txt_makhachhangcantimthaydoi_TextChanged(object sender, EventArgs e)
        {
            DataTable data = loadThongTinKhachHang();
            if (data.Rows.Count == 0)
            {
                //MessageBox.Show("Không tồn tại khách hàng", "Thông báo");
                return;
            }

            DataRow row = data.Rows[0];

            txt_makhachhangcantimthaydoi.Text = row["MaKhachHang"].ToString();
            txt_tenkhachhangcanthaydoi.Text = row["TenKhachHang"].ToString();
            txt_diachikhachhangcanthaydoi.Text = row["DiaChi"].ToString();
            txt_emailkhachhangcanthaydoi.Text = row["Email"].ToString();
            txt_sodienthoaikhachhangcanthaydoi.Text = row["SoDienThoai"].ToString();

            guna2ComboBox1.SelectedItem = row["GioiTinh"].ToString(); ;

            guna2ComboBox2.SelectedItem = row["Loai"].ToString();
        }
    }
}
