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
    public partial class UC_XoaNhanVien : UserControl
    {
        public UC_XoaNhanVien()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        private void xoaNhanVien()
        {
            DatabaseExecute dbExec = new DatabaseExecute();
            try
            {
                dbExec.Query = $"EXEC SP_Delete_NhanVien " +
                               $"'{txt_manhanvienxoa.Text.Trim()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("xóa nhân viên thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void clearData()
        {
            txt_manhanvienxoa.Clear();
        }

        private void btn_huyxoathongtinnhanvien_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void btn_xoathongtinnhanvien_Click(object sender, EventArgs e)
        {
            xoaNhanVien();
            RefreshData();
            clearData();
        }
    }
}
