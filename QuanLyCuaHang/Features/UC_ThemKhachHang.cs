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
    public partial class UC_ThemKhachHang : UserControl
    {
        public UC_ThemKhachHang()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new EventArgs());
            guna2ComboBox2_Load(this, new EventArgs());
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        public void clearData()
        {
            txt_diachikhachhangcanthem.Clear();
            txt_emailkhachhangcanthem.Clear();
            txt_sodienthoaikhachhangcanthem.Clear();
            txt_tenkhachhangcanthem.Clear();
        }

        private void themKhachHang()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Insert_KhachHang " +
                               $"N'{txt_tenkhachhangcanthem.Text.Trim()}', " +
                               $"N'{guna2ComboBox1.SelectedItem.ToString().Trim()}', " +
                               $"N'{txt_diachikhachhangcanthem.Text.Trim()}', " +
                               $"N'{txt_sodienthoaikhachhangcanthem.Text.Trim()}', " +
                               $"N'{txt_emailkhachhangcanthem.Text.Trim()}', " +
                               $"N'{guna2ComboBox2.SelectedItem.ToString().Trim()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            themKhachHang();
            RefreshData();
            clearData();
        }

        private void btn_huythemthongtinkhachhang_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void UC_ThemKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
