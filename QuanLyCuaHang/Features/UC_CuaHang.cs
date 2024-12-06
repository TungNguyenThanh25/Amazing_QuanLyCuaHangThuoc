using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UC_CuaHang : UserControl
    {
        public UC_CuaHang()
        {
            InitializeComponent();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Insert_GioHang '{User.username}'";
                dbExec.executeQueryCommand();
            }
            catch (Exception ex) { }
            UC_CuaHang_Load(this, new EventArgs());
            guna2ComboBox1_Load(this, new EventArgs());
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

        private void guna2ComboBox1_Load(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] medicine = GetMaSanPham();
            guna2ComboBox1.DataSource = medicine;
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
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_CuaHang";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        // Lấy dữ liệu cho tìm sản phẩm
        private DataTable GetDataFromLocSanPham()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Loc_SanPham_CuaHang N'{txt_tensanphamcantim.Text.Trim()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        public void loadData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }
        public void clearData()
        {
            txt_tensanphamcantim.Clear();
            text_soluongsanphamcanthem.Clear();
            loadData();
        }

        private void UC_CuaHang_Load(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_xoakhoikho_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void bnt_timsanpham_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataFromLocSanPham();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tên sản phẩm cần tìm");
                return;
            }
            guna2DataGridView1.DataSource = dataTable;
        }

        private void AddCart()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Insert_ChiTietGioHang '{User.username}', '{guna2ComboBox1.SelectedItem.ToString()}', {text_soluongsanphamcanthem.Text.Trim()}";
                dbExec.executeQueryCommand();

                MessageBox.Show("Thêm vào giỏ hàng thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_theogiohang_Click(object sender, EventArgs e)
        {
            AddCart();
            clearData();
        }
    }
}
