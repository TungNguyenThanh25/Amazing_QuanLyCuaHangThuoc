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
using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
using System.Windows.Forms;
using System.Data.Linq.Mapping;

namespace QuanLyCuaHang
{
    public partial class UC_ThemSanPham : UserControl
    {
        public UC_ThemSanPham()
        {
            InitializeComponent();
            guna2Combox1_Load(this, new EventArgs());
            guna2Combox2_Load(this, new EventArgs());
            guna2Combox3_Load(this, new EventArgs());
            guna2Combox4_Load(this, new EventArgs());
        }

        private void UC_ThemSanPham_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        //Lấy dữ liệu từng bảng
        private string[] GetMaSanPham()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_Thuoc_MaThuoc";  // Gọi Stored Procedure để lấy năm
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
                string[] medicine = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("MaThuoc"))
                                          .ToArray();
                return medicine;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        //Lấy dữ liệu từng bảng
        private string[] GetMaKhoHang()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_KhoHang_MaKhoHang";  // Gọi Stored Procedure để lấy năm
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
                string[] kho = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("MaKhoHang"))
                                          .ToArray();
                return kho;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        private string[] GetMaNhaCungCap()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_NhaCungCap_MaNhaCungCap";  // Gọi Stored Procedure để lấy năm
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
                string[] kho = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("MaNhaCungCap"))
                                          .ToArray();
                return kho;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        private string[] GetMaNhaSanXuat()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_NhaSanXuat_MaNhaSanXuat";  // Gọi Stored Procedure để lấy năm
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
                string[] kho = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("MaNhaSanXuat"))
                                          .ToArray();
                return kho;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        public void clearData()
        {
            txt_gianhapthem.Clear();
            txt_hansudungthem.Clear();
            txt_soluongpackthem.Clear();
        }

        private void guna2Combox1_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] medicine = GetMaSanPham();
            guna2ComboBox1.DataSource = medicine;
        }

        private void guna2Combox2_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] kho = GetMaKhoHang();
            guna2ComboBox2.DataSource = kho;
        }

        private void guna2Combox3_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] nsx = GetMaNhaSanXuat();
            guna2ComboBox3.DataSource = nsx;
        }

        private void guna2Combox4_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] ncc = GetMaNhaCungCap();
            guna2ComboBox4.DataSource = ncc;
        }

        private void btn_huythemsanpham_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThemSanPham()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                DataTable dt = new DataTable();
                dbExec.Query = $"EXEC SP_Insert_PhieuNhap " +
                               $"'{User.username}', " +
                               $"'{DateTime.Now}', " +
                               $"'{guna2ComboBox2.SelectedItem.ToString().Trim()}'";
                dbExec.executeQueryDataAdapter().Fill(dt);

                DataRow dr = dt.Rows[0];

                string maPNMoi = dr["MaPhieuNhapMoi"].ToString();
                MessageBox.Show(maPNMoi);

                dbExec.Query = $"EXEC SP_Insert_ChiTietPhieuNhap " +
                               $"'{maPNMoi}', " +
                               $"'{guna2ComboBox1.SelectedItem.ToString().Trim()}', " +
                               $"{int.Parse(txt_soluongpackthem.Text.Trim())}, " +
                               $"{decimal.Parse(txt_gianhapthem.Text.Trim())}, " +
                               $"'{DateTime.Parse(txt_hansudungthem.Text).ToString("yyyy-MM-dd")}', " +
                               $"'{guna2ComboBox3.SelectedItem.ToString().Trim()}', " +
                               $"'{guna2ComboBox4.SelectedItem.ToString().Trim()}'";

                dbExec.executeQueryCommand();

                MessageBox.Show("Thêm thông tin nhập kho thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo lỗi");
            }
        }

        private void btn_themkho_Click(object sender, EventArgs e)
        {
            ThemSanPham();
            RefreshData();
            clearData();
        }
    }
}





