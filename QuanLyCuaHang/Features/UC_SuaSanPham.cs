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
    public partial class UC_SuaSanPham : UserControl
    {
        public UC_SuaSanPham()
        {
            InitializeComponent();
            guna2Combox1_Load(this, new EventArgs());
            guna2Combox2_Load(this, new EventArgs());
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

        private string[] getLoai()
        {
            string[] loai = { "viên", "gói" };
            return loai;
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
            string[] loai = getLoai();
            guna2ComboBox2.DataSource = loai;
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        public void clearData()
        {
            DataTable data = loadThongTinSanPham();
            if (data.Rows.Count == 0)
            {
                //MessageBox.Show("Không tồn tại khách hàng", "Thông báo");
                return;
            }

            DataRow row = data.Rows[0];

            txt_soluongsanphamchinhsua.Text = row["SoLuongVienTrenHop"].ToString();
            txt_tenSanPham.Text = row["TenThuoc"].ToString();
            txt_hoatchat.Text = row["HoatChat"].ToString();
            txt_hamLuong.Text = row["HamLuong"].ToString();
            guna2ComboBox2.SelectedItem = row["DonViTinh"].ToString();
        }

        private void btn_huychinhsuathongtinsanpham_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            updateThongSanPham();
            RefreshData();
            clearData();
        }

        private void txt_quycachdonggoichinhsua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateThongSanPham()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Update_Thuoc " +
                               $"'{guna2ComboBox1.SelectedItem.ToString()}', " +
                               $"N'{txt_tenSanPham.Text.Trim()}', " +
                               $"N'{txt_hoatchat.Text.Trim()}', " +
                               $"N'{txt_hamLuong.Text.ToString()}', " +
                               $"N'{guna2ComboBox2.SelectedItem.ToString()}', " +
                               $"{int.Parse(txt_soluongsanphamchinhsua.Text.Trim())}";
                dbExec.executeQueryCommand();

                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private DataTable loadThongTinSanPham()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            DataTable dataTable = new DataTable();
            try
            {
                dbExec.Query = $"EXEC SP_Select_Thuoc_ByMaThuoc " +
                               $"'{guna2ComboBox1.SelectedItem.ToString()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }

            return dataTable;
        }

        private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
