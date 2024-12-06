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
    public partial class UC_DoanhThuThang : UserControl
    {
        public UC_DoanhThuThang()
        {
            InitializeComponent();
            guna2Combox1_Load(this, new EventArgs());
            guna2Combox2_Load(this, new EventArgs());
        }

        public void clearData()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            // Kiểm tra nếu ComboBox chứa giá trị năm
            if (guna2ComboBox2.Items.Contains(year.ToString()))
            {
                // Nếu có, chọn giá trị đó
                guna2ComboBox2.SelectedItem = year.ToString();
            }

            // Kiểm tra nếu có mục được chọn
            if (guna2ComboBox2.SelectedItem != null)
            {
                year = int.Parse(guna2ComboBox2.SelectedItem.ToString());
            }

            // Thực hiện các tác vụ khác
            LoadChartDataThang(month, year);
            guna2TextBox4.Text = GetSoLuongGioHang(month, year).ToString();
            guna2TextBox3.Text = GetTongDoanhThu(month, year).ToString();
            guna2ComboBox1.SelectedItem = month.ToString();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Lấy dữ liệu từng bảng
        private string[] GetYear()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_Year_HD";  // Gọi Stored Procedure để lấy năm
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");  // Xử lý lỗi nếu có
            }

            // Nếu dữ liệu có sẵn, chuyển đổi các năm vào mảng string[]
            if (dataTable.Rows.Count > 0)
            {
                // Thay "Năm" bằng tên cột thực tế trong bảng của bạn
                string[] years = dataTable.AsEnumerable()
                                          .Select(row => row.Field<int>("Năm").ToString())
                                          .ToArray();
                return years;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        private int GetSoLuongGioHang(int thang, int nam)
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"SELECT dbo.FUNC_Get_TongSoLuongHD_Thang({thang}, {nam}) AS N'Số lượng hóa đơn';";  // Gọi Stored Procedure để lấy năm
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");  // Xử lý lỗi nếu có
            }

            return dataTable.Rows[0].Field<int>("Số lượng hóa đơn");
        }

        private decimal GetTongDoanhThu(int thang, int nam)
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"SELECT dbo.FUNC_Get_TongDoanhThu_Thang({thang}, {nam}) AS [Tổng doanh thu]";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Log lỗi (nếu cần)
                //MessageBox.Show($"Error: {ex.Message}");
            }

            return dataTable.Rows[0].Field<decimal>("Tổng doanh thu"); // Trả dữ liệu
        }

        public void guna2Combox1_Load(object sender, EventArgs e)
        {
            string[] thang = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            guna2ComboBox1.DataSource = thang;
        }

        public void guna2Combox2_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] years = GetYear();
            if (years.Length > 0)
            {
                guna2ComboBox2.DataSource = years;
            }
            else
            {
                // Nếu không có năm nào, bạn có thể hiển thị một thông báo hoặc xử lý theo cách khác
                guna2ComboBox2.DataSource = new string[] { "No data" };
            }
        }

        public int getThang()
        {
            return int.Parse(guna2ComboBox1.SelectedItem.ToString());
        }

        public int getNam()
        {
            return int.Parse(guna2ComboBox2.SelectedItem.ToString());
        }

        public event EventHandler<Tuple<int, int>> OnLoadChartDataThang;

        private void LoadChartDataThang(int thang, int nam)
        {
            // Kích hoạt sự kiện và truyền dữ liệu bằng Tuple
            OnLoadChartDataThang?.Invoke(this, Tuple.Create(thang, nam));
        }

        private void changeLoad()
        {
            int thang = getThang();
            int nam = getNam();

            LoadChartDataThang(thang, nam);
            guna2TextBox4.Text = GetSoLuongGioHang(thang, nam).ToString();
            guna2TextBox3.Text = GetTongDoanhThu(thang, nam).ToString();
        }

        private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            changeLoad();
        }

        private void guna2ComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            changeLoad();
        }
    }
}
