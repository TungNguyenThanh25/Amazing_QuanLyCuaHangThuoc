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
    public partial class UC_LichSuMua : UserControl
    {
        public UC_LichSuMua()
        {
            InitializeComponent();
            InitializeUC_TimHoaDon(); // Gọi hàm khởi tạo
            // Event for hover effect
            this.guna2DataGridView1.RowPrePaint += Guna2DataGridView1_RowPrePaint;
            loadData();
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

        private void InitializeUC_TimHoaDon()
        {
            var ucTimHoaDon = new UC_TimHoaDon();
            ucTimHoaDon.OnDataUpdated += UcTimHoaDon_OnDataUpdated;
        }

        public void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }
        private void loadData()
        {
            getData();
        }

        public void clearData()
        {
            uC_TimHoaDon2.Visible = false;
            uC_XoaHoaDon2.Visible = false;
            btn_timHoaDon.PerformClick();

            loadData();
        }

        private void UcTimHoaDon_OnDataUpdated(object sender, DataTable newData)
        {
            // Cập nhật DataGridView với dữ liệu mới
            guna2DataGridView1.DataSource = newData;
        }

        private void UcTimHoaDon_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        private void UcXoaHoaDon_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void text_ngaymuahangtimHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_LichSuHoaDon";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        private void btn_timHoaDon_Click(object sender, EventArgs e)
        {
            uC_XoaHoaDon2.Visible = false;
            panel_movinglichsuHoaDon.Left = btn_timHoaDon.Left;
            uC_TimHoaDon2.Visible = true;
            uC_TimHoaDon2.BringToFront();

            loadData();

            // Đăng ký sự kiện OnDataUpdated
            uC_TimHoaDon2.OnDataUpdated += UcTimHoaDon_OnDataUpdated;
            uC_TimHoaDon2.OnRefreshData += UcTimHoaDon_OnRefreshData;
            uC_TimHoaDon2.clearData();
        }

        private void uC_XoaHoaDon1_Load(object sender, EventArgs e)
        {

        }

        private void UC_LichSuMua_Load(object sender, EventArgs e)
        {
            uC_TimHoaDon2.Visible=false;
            uC_XoaHoaDon2.Visible = false;
            btn_timHoaDon.PerformClick();

            //uC_TimHoaDon1.Visible=false;
            //uC_XoaHoaDon1.Visible = false;
            //btn_timHoaDon.PerformClick();
        }

        private void btn_xoaHoaDon_Click(object sender, EventArgs e)
        {
            uC_TimHoaDon2.Visible = false;
            //panel_movinglíchuHoaDon.Left = btn_xoaHoaDon.Left;
            //uC_XoaHoaDon1.Visible = true;
            //uC_XoaHoaDon1.BringToFront();
            panel_movinglichsuHoaDon.Left = btn_xoaHoaDon.Left;
            uC_XoaHoaDon2.Visible = true;
            uC_XoaHoaDon2.BringToFront();

            loadData();

            uC_XoaHoaDon2.OnRefreshData += UcXoaHoaDon_OnRefreshData;
        }

        private void panel_movinglíchuHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_TimHoaDon2_Load(object sender, EventArgs e)
        {

        }

        private void uC_XoaHoaDon2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
