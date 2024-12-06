using QuanLyCuaHang.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyCuaHang.Features
{
    public partial class UC_ThayDoiThongTinNhanVien : UserControl
    {
        public UC_ThayDoiThongTinNhanVien()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new EventArgs());
            guna2ComboBox2_Load(this, new EventArgs());
        }

        private void btn_huythaydoithongtinnhanvien_Click(object sender, EventArgs e)
        {
            clearData();
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        public void clearData()
        {
            txt_manhanvientimthaydoi.Clear();
            txt_luongnhanviencanthaydoi.Clear();
            txt_maquanlynhanvienthaydoi.Clear();
            txt_sodienthoainhanviencanthaydoi.Clear();
            txt_tennhanviencanthaydoi.Clear();
            txt_taikhoandangnhap.Clear();
        }

        private void guna2ComboBox1_Load(object sender, EventArgs e)
        {
            string[] gender = { "Nam", "Nữ" };
            guna2ComboBox1.DataSource = gender;
        }

        private void guna2ComboBox2_Load(object sender, EventArgs e)
        {
            string[] type = { "Quản lý", "Nhân viên" };
            guna2ComboBox2.DataSource = type;
        }

        private DataTable loadThongTinNhanVien()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            DataTable dataTable = new DataTable();
            try
            {
                dbExec.Query = $"EXEC SP_Select_NhanVien_ByMaNhanVien " +
                               $"'{txt_manhanvientimthaydoi.Text.Trim()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return dataTable;
        }

        private void updateThongTinNhanVien()
        {   
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                // Prepare input values
                string maQuanLy = string.IsNullOrWhiteSpace(txt_maquanlynhanvienthaydoi.Text)
                    ? "NULL"
                    : $"'{txt_maquanlynhanvienthaydoi.Text.Trim()}'";

                string taiKhoan = string.IsNullOrWhiteSpace(txt_taikhoandangnhap.Text)
                    ? "NULL"
                    : $"'{txt_taikhoandangnhap.Text.Trim()}'";

                // Extract and clean up raw salary input
                string thanhTienRaw = txt_luongnhanviencanthaydoi.Text.Trim();

                thanhTienRaw = thanhTienRaw.Substring(0, thanhTienRaw.Length - 3);

                // Remove commas (thousands separators)
                thanhTienRaw = thanhTienRaw.Replace(",", "");

                // Build query
                dbExec.Query = $"EXEC SP_Update_NhanVien " +
                               $"'{txt_manhanvientimthaydoi.Text.Trim()}', " +
                               $"N'{txt_tennhanviencanthaydoi.Text.Trim()}', " +
                               $"N'{guna2ComboBox1.SelectedItem?.ToString()?.Trim()}', " +
                               $"N'{guna2ComboBox2.SelectedItem?.ToString()?.Trim()}', " +
                               $"{decimal.Parse(thanhTienRaw)}, " +
                               $"'{txt_sodienthoainhanviencanthaydoi.Text.Trim()}', " +
                               $"{maQuanLy}, " +
                               $"{taiKhoan}";

                // Execute query
                dbExec.executeQueryCommand();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo lỗi");
            }
        }

        private void UC_ThayDoiThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_thaydoithongtinnhanvien_Click(object sender, EventArgs e)
        {
            updateThongTinNhanVien();
            RefreshData();
            clearData();
        }

        private void txt_manhanvientimthaydoi_TextChanged(object sender, EventArgs e)
        {
            // Lấy thông tin nhân viên dựa trên mã đã nhập
            DataTable data = loadThongTinNhanVien();

            if (data.Rows.Count == 0)
            {
                // Không tìm thấy dữ liệu
                //MessageBox.Show("Không tồn tại nhân viên", "Thông báo");
                return;
            }

            // Lấy dòng dữ liệu đầu tiên
            DataRow row = data.Rows[0];

            // Gán dữ liệu từ DataRow vào các control
            txt_manhanvientimthaydoi.Text = row["MaNhanVien"].ToString();
            txt_tennhanviencanthaydoi.Text = row["TenNhanVien"].ToString();
            guna2ComboBox1.SelectedItem = row["GioiTinh"].ToString();
            guna2ComboBox2.SelectedItem = row["ChucVu"].ToString();
            txt_luongnhanviencanthaydoi.Text = decimal.Parse(row["Luong"].ToString()).ToString("N2");
            txt_sodienthoainhanviencanthaydoi.Text = row["SoDienThoai"].ToString();

            // Kiểm tra giá trị NULL cho MaNhanVienQuanLy và TenTaiKhoan
            txt_maquanlynhanvienthaydoi.Text = row["MaNhanVienQuanLi"] == DBNull.Value ? string.Empty : row["MaNhanVienQuanLi"].ToString();
            txt_taikhoandangnhap.Text = row["TenTaiKhoan"] == DBNull.Value ? string.Empty : row["TenTaiKhoan"].ToString();
        }

    }
}
