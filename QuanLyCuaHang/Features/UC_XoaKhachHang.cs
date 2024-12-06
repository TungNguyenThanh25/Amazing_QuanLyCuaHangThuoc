using Guna.UI2.WinForms;
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
    public partial class UC_XoaKhachHang : UserControl
    {
        public UC_XoaKhachHang()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        private void xoaKhachHang()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Delete_KhachHang " +
                               $"'{txt_sodienthoaikhachhangcanxoa.Text.Trim()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("xóa khách hàng thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void clearData()
        {
            txt_sodienthoaikhachhangcanxoa.Clear();
        }

        private void btn_huyxoathongtinkhachhang_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void btn_xoathongtinkhachhang_Click(object sender, EventArgs e)
        {
            xoaKhachHang();
            RefreshData();
            clearData();
        }
    }
}
