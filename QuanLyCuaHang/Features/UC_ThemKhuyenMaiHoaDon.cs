using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
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
    public partial class UC_ThemKhuyenMaiHoaDon : UserControl
    {
        public UC_ThemKhuyenMaiHoaDon()
        {
            InitializeComponent();
        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
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
            txt_phanTramGiam.Clear();
            txt_tongTienToiThieu.Clear();
            txt_tongTienToiDa.Clear();
            txt_SoLuongKhuyenMai.Clear();
            txt_ngaybatdaukhuyenmaihdthem.Clear();
            txt_ngayketthuckhuyenmaihdthem.Clear();            
        }

        private void btn_huythemkhuyenmaiHoaDon_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void UC_ThemKhuyenMaiHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void themKhuyenMaiHoaDon()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Insert_KhuyenMaiHoaDon " +
                               $"{txt_phanTramGiam.Text}, " +
                               $"{txt_tongTienToiThieu.Text}, " +
                               $"{txt_tongTienToiDa.Text}, " +
                               $"{txt_SoLuongKhuyenMai.Text}, " +
                               $"'{DateTime.Parse(txt_ngaybatdaukhuyenmaihdthem.Text).ToString("yyyy-MM-dd")}', " +
                               $"'{DateTime.Parse(txt_ngayketthuckhuyenmaihdthem.Text).ToString("yyyy-MM-dd")}'";
                dbExec.executeQueryCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            themKhuyenMaiHoaDon();
            RefreshData();
            clearData();
        }
    }
}
