using Guna.UI2.WinForms;
using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UC_GioHang : UserControl
    {
        public UC_GioHang()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new  EventArgs());
            guna2ComboBox2_Load(this, new  EventArgs());
            guna2ComboBox3_Load(this, new  EventArgs());

            // Event for hover effect
            this.guna2DataGridView1.RowPrePaint += Guna2DataGridView1_RowPrePaint;
        }

        private void Guna2DataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201); // Green hover
                row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
        }

        private void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }

        public void loadData()
        {
            getData();

            // Get the quantity and update the respective field
            txt_tongsoluongmathang.Text = getSoLuongMatHang().ToString();

            // Get the total price (tongTien)
            decimal tongTien = getTongTien();

            // Check if the total price is not zero
            if (tongTien != decimal.Zero)
            {
                // Set the total price text
                txt_tongtien.Text = tongTien.ToString("F2");

                // Calculate the total including tax and display it
                decimal thanhTien = tongTien + (tongTien * 0.05m);
                txt_thanhtien.Text = thanhTien.ToString("F2");
            }
            else
            {
                // If no total amount, set both fields to zero
                txt_tongtien.Text = decimal.Zero.ToString("F2");
                txt_thanhtien.Text = decimal.Zero.ToString("F2");
            }
        }


        public void clearData()
        {
            txt_SoDienThoai_HD.Clear();
            txt_thanhtien.Clear();
            txt_tongtien.Clear();
            txt_tongsoluongmathang.Clear();
            guna2ComboBox1_Load(this, new EventArgs());
            guna2ComboBox2_Load(this, new EventArgs());
            guna2ComboBox3_Load(this, new EventArgs());
            loadData();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_GioHang_Detail '{User.username}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        //Lấy dữ liệu từng bảng
        private string[] GetThuoc()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_MaThuoc_GioHang '{User.username}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }

            if (dataTable.Rows.Count > 0)
            {
                // Filter out DBNull values and convert valid data to an array
                string[] medicine = dataTable.AsEnumerable()
                                             .Where(row => row["MaThuoc"] != DBNull.Value)
                                             .Select(row => row.Field<string>("MaThuoc"))
                                             .ToArray();
                return medicine;
            }

            return new string[] { "No data" };
        }

        //Lấy dữ liệu từng bảng
        private List<string> GetMaKhuyenMaiHoaDon()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_KhuyenMaiHoaDon_Ma";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }

            // Nếu dữ liệu có sẵn, chuyển đổi các năm vào mảng string[]
            if (dataTable.Rows.Count > 0)
            {
                List<string> medicine = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("MaKhuyenMaiHoaDon"))
                                          .ToList();
                return medicine;
            }

            return new List<string>() {"No data"}; // Trả về mảng rỗng nếu không có dữ liệu
        }

        private int getSoLuongMatHang()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_SoLuongThuoc_GioHang '{User.username}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }

            if (dataTable.Rows.Count == 0 || dataTable.Rows[0]["Số lượng thuốc"] == DBNull.Value)
                return 0;

            // Return the value or 0 if it's DBNull
            return dataTable.Rows[0].Field<int>("Số lượng thuốc");
        }

        private decimal getTongTien()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_TongTien_GioHang '{User.username}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }

            if (dataTable.Rows.Count == 0 || dataTable.Rows[0]["Tổng tiền"] == DBNull.Value)
                return decimal.Zero;

            // Return the value or decimal.Zero if it's DBNull
            return dataTable.Rows[0].Field<decimal>("Tổng tiền");
        }


        private void UC_GioHang_Load(object sender, EventArgs e)
        {
            clearData();
            loadData();
        }

        private void guna2ComboBox1_Load(object sender, EventArgs e)
        {
            List<string> coupon = GetMaKhuyenMaiHoaDon();
            guna2ComboBox1.DataSource = coupon;
        }

        private void guna2ComboBox2_Load(object sender, EventArgs e)
        {
            string[] methodPay = { "Tiền mặt", "Thẻ" };
            guna2ComboBox2.DataSource = methodPay;
        }

        private void guna2ComboBox3_Load(object sender, EventArgs e)
        {
            string[] medicine = GetThuoc();
            guna2ComboBox3.DataSource = medicine;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_ngaymuahang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadData();
            clearData();
        }

        private void txt_thanhtoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void XuatHoaDon()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                DataTable dt = new DataTable();

                // Thêm hóa đơn mới
                dbExec.Query = $"EXEC SP_Insert_HoaDon " +
                               $"'{txt_SoDienThoai_HD.Text.Trim()}', " + // Số điện thoại khách hàng
                               $"'{User.username}', " +                 // Tên tài khoản nhân viên
                               $"N'{guna2ComboBox2.SelectedItem.ToString()}', " + // Phương thức thanh toán
                               $"'{guna2ComboBox1.SelectedItem.ToString()}'";     // Mã khuyến mãi (nếu có)

                dbExec.executeQueryDataAdapter().Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Lấy mã hóa đơn mới từ kết quả trả về
                    string maHDMoi = dt.Rows[0]["MaHoaDonMoi"].ToString();

                    // Lấy dữ liệu chi tiết hóa đơn từ bảng hoặc nguồn
                    DataTable dt2 = GetDataFromTable();

                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        // Check if the fields are DBNull
                        if (dr2["Thông tin thuốc"] == DBNull.Value ||
                            dr2["Số lượng"] == DBNull.Value ||
                            dr2["Thành tiền"] == DBNull.Value)
                        {
                            MessageBox.Show("Dữ liệu trong bảng không đầy đủ. Vui lòng kiểm tra lại.", "Thông báo lỗi");
                            return;
                        }

                        // Continue processing if not DBNull
                        string thongTinThuoc = dr2["Thông tin thuốc"].ToString(); // Example: "THUOC003 - Amoxicillin"
                        string maThuoc = thongTinThuoc.Split('-')[0].Trim(); // Get part before the "-" and remove spaces

                        // Try parsing the values
                        if (!int.TryParse(dr2["Số lượng"].ToString(), out int soLuong))
                        {
                            MessageBox.Show($"Dữ liệu 'Số lượng' không hợp lệ: {dr2["Số lượng"]}", "Thông báo lỗi");
                            return;
                        }

                        string thanhTienRaw = dr2["Thành tiền"].ToString().Replace(",", ""); // Remove commas
                        if (!decimal.TryParse(thanhTienRaw, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal donGia))
                        {
                            MessageBox.Show($"Dữ liệu 'Thành tiền' không hợp lệ: {dr2["Thành tiền"]}", "Thông báo lỗi");
                            return;
                        }

                        // Gọi stored procedure thêm chi tiết hóa đơn
                        dbExec.Query = $"EXEC SP_Insert_ChiTietHoaDon " +
                                       $"'{maHDMoi}', " +  // Mã hóa đơn
                                       $"'{maThuoc}', " +  // Mã thuốc
                                       $"{soLuong}, " +    // Số lượng
                                       $"{thanhTienRaw}";        // Đơn giá

                        dbExec.executeQueryCommand();
                    }

                    // Xóa giỏ hàng nếu cần
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        // Lấy mã thuốc từ "Thông tin thuốc"
                        string thongTinThuoc = dr2["Thông tin thuốc"].ToString(); // Ví dụ: "THUOC003 - Amoxicillin"
                        string maThuoc = thongTinThuoc.Split('-')[0].Trim();      // Lấy phần trước dấu "-" và loại bỏ khoảng trắng

                        dbExec.Query = $"EXEC SP_Delete_ChiTietGioHang '{User.username}', '{maThuoc}'";
                        dbExec.executeQueryCommand();
                    }

                    MessageBox.Show("Xuất hóa đơn thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thể tạo hóa đơn mới!", "Thông báo lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo lỗi");
            }
        }

        // Xuat hoa don
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            XuatHoaDon();
            loadData();
            clearData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCart()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Delete_ChiTietGioHang '{User.username}', '{guna2ComboBox3.SelectedItem.ToString()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("Xóa thuốc thành công!", "Thông báo");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\n" + "Xóa thuốc thát bại!", "Thông báo");
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            DeleteCart();
            loadData();
            clearData();
        }

        private void txt_tongsoluongmathang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
