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
    public partial class UC_XoaHoaDon : UserControl
    {
        public UC_XoaHoaDon()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        public void clearData()
        {
            text_maHoaDonxoaHoaDon.Clear();
        }

        private void btn_huyxoaHoaDon_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }

        private void XoaHoaDon()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Delete_HoaDon '{text_maHoaDonxoaHoaDon.Text.Trim()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
            }
            catch (Exception ex) {
                MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo");
            }
        }

        private void btn_xoaHoaDonHoaDon_Click(object sender, EventArgs e)
        {
            XoaHoaDon();
            RefreshData();
            clearData();
        }
    }
}
