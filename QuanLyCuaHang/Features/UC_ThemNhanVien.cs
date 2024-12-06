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
    public partial class UC_ThemNhanVien : UserControl
    {
        public UC_ThemNhanVien()
        {
            InitializeComponent();
            guna2ComboBox1_Load(this, new EventArgs());
            guna2ComboBox2_Load(this, new EventArgs());
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void combobox_loainhanviencanthem_SelectedIndexChanged(object sender, EventArgs e)
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
            txt_luongnhanviencanthem.Clear();
            txt_maquanlynhanvienthem.Clear();
            txt_sodienthoainhanviencanthem.Clear();
            txt_tennhanviencanthem.Clear();
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

        private void themNhanVien()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Insert_NhanVien " +
                               $"N'{txt_tennhanviencanthem.Text.Trim()}', " +
                               $"N'{guna2ComboBox1.SelectedItem.ToString().Trim()}', " +
                               $"N'{guna2ComboBox2.SelectedItem.ToString().Trim()}', " +
                               $"{decimal.Parse(txt_luongnhanviencanthem.Text.Trim())}, " +
                               $"N'{txt_sodienthoainhanviencanthem.Text.Trim()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_huythemthongtinnhanvien_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_themthongtinnhanvien_Click(object sender, EventArgs e)
        {
            themNhanVien();
            RefreshData();
            clearData();
        }
    }
}
