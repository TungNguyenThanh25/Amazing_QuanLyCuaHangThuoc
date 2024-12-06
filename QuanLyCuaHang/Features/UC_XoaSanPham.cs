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
    public partial class UC_XoaSanPham : UserControl
    {
        public UC_XoaSanPham()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new EventArgs());
        }

        private void XoaSanPham()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Delete_Thuoc '{txt_masanphamxoa.Text.Trim()}'";
                dbExec.executeQueryCommand();

                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo");
            }
            catch (Exception ex) { }
        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {
            XoaSanPham();
            RefreshData();
            clearData();
        }

        public void clearData()
        {
            txt_masanphamxoa.Clear();
        }

        private void btn_huyxoakhoikho_Click(object sender, EventArgs e)
        {
            RefreshData();
            clearData();
        }
    }
}
