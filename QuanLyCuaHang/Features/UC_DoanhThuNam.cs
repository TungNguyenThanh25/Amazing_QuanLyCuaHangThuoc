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
    public partial class UC_DoanhThuNam : UserControl
    {
        public UC_DoanhThuNam()
        {
            InitializeComponent();
            guna2Combox2_Load(this, new EventArgs());
            clearData();
        }

        public void clearData()
        {
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
            LoadChartDataNam(year);
            guna2TextBox6.Text = GetSoLuongGioHang(year).ToString();
            guna2TextBox5.Text = GetTongDoanhThu(year).ToString();
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


        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int GetSoLuongGioHang(int nam)
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"SELECT dbo.FUNC_Get_TongSoLuongHD_Nam({nam}) AS N'Số lượng hóa đơn';";  // Gọi Stored Procedure để lấy năm
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");  // Xử lý lỗi nếu có
            }

            return dataTable.Rows[0].Field<int>("Số lượng hóa đơn");
        }

        private decimal GetTongDoanhThu(int nam)
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"SELECT dbo.FUNC_Get_TongDoanhThu_Nam({nam}) AS [Tổng doanh thu]";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Log lỗi (nếu cần)
                //MessageBox.Show($"Error: {ex.Message}");
            }
            
            return dataTable.Rows[0].Field<decimal>("Tổng doanh thu"); // Lấy giá trị kiểu decimal
        }


        public event EventHandler<int> OnLoadChartDataNam;

        private void LoadChartDataNam(int nam)
        {
            // Kích hoạt sự kiện và truyền dữ liệu bằng Tuple
            OnLoadChartDataNam?.Invoke(this, nam);
        }

        public int getNam()
        {
            return int.Parse(guna2ComboBox2.SelectedItem.ToString());
        }

        private void guna2Combox2_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] years = GetYear();
            guna2ComboBox2.DataSource = years;
        }

        private void guna2ComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int nam = getNam();

            LoadChartDataNam(nam);
            guna2TextBox6.Text = GetSoLuongGioHang(nam).ToString();
            guna2TextBox5.Text = GetTongDoanhThu(nam).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
