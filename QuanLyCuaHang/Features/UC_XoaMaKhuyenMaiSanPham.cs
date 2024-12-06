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
    public partial class UC_XoaMaKhuyenMaiSanPham : UserControl
    {
        public UC_XoaMaKhuyenMaiSanPham()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new EventArgs());
        }

        public void clearData()
        {
            guna2ComboBox1_Load(this, new EventArgs());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        //Lấy dữ liệu từng bảng
        private string[] GetMaKhuyenMaiThuoc()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_MaKhuyenMaiThuoc";  // Gọi Stored Procedure để lấy năm
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
                                          .Select(row => row.Field<string>("Mã khuyến mãi sản phẩm"))
                                          .ToArray();
                return coupon;
            }

            return new string[] { "No data" }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        private void guna2ComboBox1_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu cho ComboBox từ dữ liệu đã lấy
            string[] coupon = GetMaKhuyenMaiThuoc();
            guna2ComboBox1.DataSource = coupon;
        }

        private void xoaKhuyenMaiThuoc()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Delete_KhuyenMaiThuoc " +
                               $"'{guna2ComboBox1.SelectedItem.ToString()}'";
                dbExec.executeQueryCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            xoaKhuyenMaiThuoc();
            RefreshData();
            clearData();
        }

        private void btn_huyxoamakhuyenmaisanpham_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
