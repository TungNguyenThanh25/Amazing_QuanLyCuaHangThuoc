using QuanLyCuaHang.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Features
{
    public partial class UC_TimKhachHang : UserControl
    {
        public UC_TimKhachHang()
        {
            InitializeComponent();
        }

        public void clearData()
        {
            txt_sodienthoaikhachhangcantim.Clear();
        }

        private void btn_huytimthongtinkhachhang_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetKhachHangDataByMaKH()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Loc_KhachHang_QuanLyKhachHang '{txt_sodienthoaikhachhangcantim.Text}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        public event EventHandler<DataTable> OnDataUpdated;

        private void UpdateData(DataTable newData)
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnDataUpdated?.Invoke(this, newData);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_timthongtinkhachhang_Click(object sender, EventArgs e)
        {
            DataTable data = GetKhachHangDataByMaKH();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateData(data);
            clearData();
        }
    }
}
