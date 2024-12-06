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
    public partial class UC_XoaKhuyenMaiHoaDon : UserControl
    {
        public UC_XoaKhuyenMaiHoaDon()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new EventArgs());
        }

        public void clearData()
        {
            guna2ComboBox1_Load(this, new EventArgs());
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        private void btn_huyxoamakhuyenmaiHoaDon_Click(object sender, EventArgs e)
        {
            clearData();
        }

        //Lấy dữ liệu từng bảng
        private string[] GetMaKhuyenMaiHoaDon()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_MaKhuyenMaiHoaDon";  // Gọi Stored Procedure để lấy năm
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");  // Xử lý lỗi nếu có
            }

            // Nếu dữ liệu có sẵn, chuyển đổi các năm vào mảng string[]
            if (dataTable.Rows.Count > 0)
            {
                string[] coupon = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("Mã khuyến mãi hóa đơn"))
                                          .ToArray();
                return coupon;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu cho ComboBox từ dữ liệu đã lấy
            string[] coupon = GetMaKhuyenMaiHoaDon();
            guna2ComboBox1.DataSource = coupon;
        }

        private void xoaKhuyenMaiHoaDon()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Delete_KhuyenMaiHoaDon " +
                               $"'{guna2ComboBox1.SelectedItem.ToString()}'";
                dbExec.executeQueryCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            xoaKhuyenMaiHoaDon();
            RefreshData();
            clearData();
        }
    }
}
