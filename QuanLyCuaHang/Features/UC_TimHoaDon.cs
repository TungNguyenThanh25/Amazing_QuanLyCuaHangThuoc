using Guna.UI2.WinForms;
using QuanLyCuaHang;
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
    public partial class UC_TimHoaDon : UserControl
    {
        public UC_TimHoaDon()
        {
            InitializeComponent();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetHoaDon()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Loc_HoaDon_LichSuHoaDon '{text_sdtKhachHang.Text}', '{guna2ComboBox1.SelectedItem.ToString()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        public void clearData()
        {
            text_sdtKhachHang.Clear();
            guna2ComboBox1.DataSource = new string[] { "No data" };
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        private void btn_huytimHoaDon_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        public event EventHandler<DataTable> OnDataUpdated;

        private void UpdateData(DataTable newData)
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnDataUpdated?.Invoke(this, newData);
        }

        private void btn_timHoaDon_Click(object sender, EventArgs e)
        {
            DataTable data = GetHoaDon();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateData(data);
            clearData();
        }

        private string[] GetDate()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Loc_NgayLap_LichSuHoaDon_Sdt '{text_sdtKhachHang.Text.Trim()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
            }

            // Lấy dữ liệu dưới dạng chuỗi
            if (dataTable.Rows.Count > 0)
            {
                string[] date = dataTable.AsEnumerable()
                                          .Select(row => row.Field<string>("Ngày lập")) // Không chuyển đổi trực tiếp
                                          .ToArray();
                return date;
            }

            return new string[] { "No data" };
        }


        private void text_sdtKhachHang_TextChanged(object sender, EventArgs e)
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] date = GetDate();
            if (date.Length > 0)
            {
                guna2ComboBox1.DataSource = date;
            }
            else
            {
                // Nếu không có năm nào, bạn có thể hiển thị một thông báo hoặc xử lý theo cách khác
                guna2ComboBox1.DataSource = new string[] { "No data" };
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
