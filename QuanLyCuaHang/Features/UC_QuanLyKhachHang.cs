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

namespace QuanLyCuaHang.Features
{
    public partial class UC_QuanLyKhachHang : UserControl
    {
        public UC_QuanLyKhachHang()
        {
            InitializeComponent();
            loadData();
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

        private void InitializeUC_TimKhachHang()
        {
            var ucTimKhachHang = new UC_TimKhachHang();
            ucTimKhachHang.OnDataUpdated += UcTimKhachHang_OnDataUpdated;
        }

        private void UcTimKhachHang_OnDataUpdated(object sender, DataTable newData)
        {
            // Cập nhật DataGridView với dữ liệu mới
            guna2DataGridView1.DataSource = newData;
        }

        private void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }

        public void loadData()
        {
            getData();
        }

        private void UcTimKhachHang_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        private void UcThemKhachHang_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        private void UcXoaKhachHang_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        private void UcThayDoiThongTinKhachHang_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_QuanLyKhachHang";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_xoakhachhang.Left;
            uC_XoaKhachHang1.Visible = true;
            uC_XoaKhachHang1.BringToFront();
            
            loadData();

            uC_XoaKhachHang1.OnRefreshData += UcXoaKhachHang_OnRefreshData;
            uC_XoaKhachHang1.clearData();
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_themkhachhang.Left;
            uC_ThemKhachHang1.Visible = true;
            uC_ThemKhachHang1.BringToFront();

            loadData();

            uC_ThemKhachHang1.OnRefreshData += UcThemKhachHang_OnRefreshData;
            uC_ThemKhachHang1.clearData();
        }

        private void btn_timkhachang_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_timkhachang.Left;
            uC_TimKhachHang1.Visible=true;
            uC_TimKhachHang1.BringToFront();

            loadData();

            uC_TimKhachHang1.OnDataUpdated += UcTimKhachHang_OnDataUpdated;
            uC_TimKhachHang1.OnRefreshData += UcTimKhachHang_OnRefreshData;
            uC_TimKhachHang1.clearData();
        }

        private void btn_suathongtinkhachhang_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_suathongtinkhachhang.Left;
            uC_ThayDoiThongTinKhachHang1.Visible = true;   
            uC_ThayDoiThongTinKhachHang1.BringToFront() ;

            loadData();

            uC_ThayDoiThongTinKhachHang1.OnRefreshData += UcThayDoiThongTinKhachHang_OnRefreshData;
            uC_ThayDoiThongTinKhachHang1.clearData();
        }

        private void UC_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            uC_ThemKhachHang1.Visible = false;
            uC_TimKhachHang1.Visible = false;
            uC_ThayDoiThongTinKhachHang1.Visible = false;
            uC_XoaKhachHang1.Visible = false;

            btn_themkhachhang.PerformClick();
        }
    }
}
