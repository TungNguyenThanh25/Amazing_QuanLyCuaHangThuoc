using Guna.UI2.WinForms;
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

namespace QuanLyCuaHang
{
    public partial class UC_ThemMaKhuyenMaiSanPham : UserControl
    {
        public UC_ThemMaKhuyenMaiSanPham()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new EventArgs());
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_ThemMaKhuyenMaiSanPham_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        public void clearData()
        {
            guna2ComboBox1_Load(this, new EventArgs());
            txt_phantramgiamspthem.Clear();
            txt_ngaybatdaukhuyenmaispthem.Clear();
            txt_ngayketthuckhuyenmaispthem.Clear();
        }

        private void guna2ComboBox1_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] medicineInfo = GetMaThuoc();
            guna2ComboBox1.DataSource = medicineInfo;
        }

        //Lấy dữ liệu từng bảng
        private string[] GetMaThuoc()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_ThongTinThuoc";  // Gọi Stored Procedure để lấy năm
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");  // Xử lý lỗi nếu có
            }

            // Nếu dữ liệu có sẵn, chuyển đổi các năm vào mảng string[]
            if (dataTable.Rows.Count > 0)
            {
                string[] medicineInfo = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("Thông tin thuốc"))
                                          .ToArray();
                return medicineInfo;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        private void btn_huythemkhuyenmaisanpham_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void themKhuyenMaiThuoc()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Insert_KhuyenMaiThuoc " +
                               $"'{guna2ComboBox1.SelectedItem.ToString().Split('-')[0].Trim()}', " +
                               $"{txt_phantramgiamspthem.Text}, " +
                               $"'{DateTime.Parse(txt_ngaybatdaukhuyenmaispthem.Text).ToString("yyyy-MM-dd")}', " +
                               $"'{DateTime.Parse(txt_ngayketthuckhuyenmaispthem.Text).ToString("yyyy-MM-dd")}'";
                dbExec.executeQueryCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            themKhuyenMaiThuoc();
            RefreshData();
            clearData();
        }
    }
}
