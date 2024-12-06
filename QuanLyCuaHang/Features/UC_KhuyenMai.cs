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
    public partial class UC_KhuyenMai : UserControl
    {
        public UC_KhuyenMai()
        {
            InitializeComponent();
            // Event for hover effect
            this.guna2DataGridView1.RowPrePaint += Guna2DataGridView1_RowPrePaint;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromKhuyenMaiThuoc()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_KMT";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            
            return dataTable;
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromKhuyenMaiHoaDon()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_KMHD";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }

            return dataTable;
        }

        private void loadMaThuoc()
        {
            guna2DataGridView1.DataSource = GetDataFromKhuyenMaiThuoc();
        }

        private void loadMaHoaDon()
        {
            guna2DataGridView1.DataSource = GetDataFromKhuyenMaiHoaDon();
        }


        private void UC_KhuyenMai_Load(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible=false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible=false;
            btn_themkhuyenmaisanpham.PerformClick();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UcThemMaKhuyenMaiSanPham_OnRefreshData(object sender, EventArgs e)
        {
            loadMaThuoc();
        }
        private void UcThemMaKhuyenMaiHoaDon_OnRefreshData(object sender, EventArgs e)
        {
            loadMaHoaDon();
        }
        private void UcXoaMaKhuyenMaiSanPham_OnRefreshData(object sender, EventArgs e)
        {
            loadMaThuoc();
        }
        private void UcXoaMaKhuyenMaiHoaDon_OnRefreshData(object sender, EventArgs e)
        {
            loadMaHoaDon();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible = false;

            loadMaThuoc();
            uC_ThemMaKhuyenMaiSanPham1.OnRefreshData += UcThemMaKhuyenMaiSanPham_OnRefreshData;
            uC_ThemMaKhuyenMaiSanPham1.clearData();

            panel_movingkhuyenmai.Left = btn_themkhuyenmaisanpham.Left;
            uC_ThemMaKhuyenMaiSanPham1.Visible = true;
            uC_ThemMaKhuyenMaiSanPham1.BringToFront();
        }

        private void btn_xoakhuyenmaisanpham_Click(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            //uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible = false;

            loadMaThuoc();
            uC_XoaMaKhuyenMaiSanPham1.OnRefreshData += UcXoaMaKhuyenMaiSanPham_OnRefreshData;
            uC_XoaMaKhuyenMaiSanPham1.clearData();

            panel_movingkhuyenmai.Left = btn_xoakhuyenmaisanpham.Left;
            uC_XoaMaKhuyenMaiSanPham1.Visible = true;
            uC_XoaMaKhuyenMaiSanPham1.BringToFront();
        }

        private void btn_themkhuyenmaiHoaDon_Click(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            //uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible = false;

            loadMaHoaDon();
            uC_ThemKhuyenMaiHoaDon1.OnRefreshData += UcThemMaKhuyenMaiHoaDon_OnRefreshData;
            uC_ThemKhuyenMaiHoaDon1.clearData();

            panel_movingkhuyenmai.Left = btn_themkhuyenmaiHoaDon.Left;
            uC_ThemKhuyenMaiHoaDon1.Visible = true;
            uC_ThemKhuyenMaiHoaDon1.BringToFront();
        }

        private void btn_xoakhuyenmaiHoaDon_Click(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            //uC_XoaKhuyenMaiHoaDon1.Visible = false;

            loadMaHoaDon();
            uC_XoaKhuyenMaiHoaDon1.OnRefreshData += UcXoaMaKhuyenMaiHoaDon_OnRefreshData;
            uC_XoaKhuyenMaiHoaDon1.clearData();

            panel_movingkhuyenmai.Left = btn_xoakhuyenmaiHoaDon.Left;
            uC_XoaKhuyenMaiHoaDon1.Visible = true;
            uC_XoaKhuyenMaiHoaDon1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_ThemKhuyenMaiHoaDon1_Load(object sender, EventArgs e)
        {

        }

        private void uC_XoaMaKhuyenMaiSanPham1_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
