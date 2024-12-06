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
    public partial class UC_KhoHang : UserControl
    {
        public UC_KhoHang()
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

        private void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }
        private void loadData()
        {
            getData();
        }

        public void clearData()
        {
            uC_ThemSanPham1.Visible = false;
            uC_XoaSanPham1.Visible = false;
            uC_SuaSanPham1.Visible = false;
            btn_themsanphamkhohang.PerformClick();

            loadData();
        }

        private void UC_KhoHang_Load(object sender, EventArgs e)
        {
            uC_ThemSanPham1.Visible = false;
            uC_XoaSanPham1.Visible=false;
            uC_SuaSanPham1.Visible=false;
            btn_themsanphamkhohang.PerformClick();
        }

        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_Kho";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void UcThemSanPham_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        private void UcXoaSanPham_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        private void UcSuaSanPham_OnRefreshData(object sender, EventArgs e)
        {
            loadData();
        }

        // Them san pham
        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
            //uC_ThemSanPham1.Visible = false;
            uC_XoaSanPham1.Visible = false;
            uC_SuaSanPham1.Visible = false;
            panel_movingkhohang.Left = btn_themsanphamkhohang.Left;
            uC_ThemSanPham1.Visible = true;
            uC_ThemSanPham1.BringToFront();
            
            loadData();

            uC_ThemSanPham1.OnRefreshData += UcThemSanPham_OnRefreshData;
            uC_ThemSanPham1.clearData();

        }

        // Xoa san pham
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_ThemSanPham1.Visible = false;
            //uC_XoaSanPham1.Visible = false;
            uC_SuaSanPham1.Visible = false;
            panel_movingkhohang.Left = btn_xoasanphamkhohang.Left;
            uC_XoaSanPham1.Visible = true;
            uC_XoaSanPham1.BringToFront();

            loadData();

            uC_XoaSanPham1.OnRefreshData += UcXoaSanPham_OnRefreshData;
            uC_XoaSanPham1.clearData();
        }

        // Sua san pham
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_ThemSanPham1.Visible = false;
            uC_XoaSanPham1.Visible = false;
            //uC_SuaSanPham1.Visible = false;
            panel_movingkhohang.Left = btn_suasanphamkhohang.Left;
            uC_SuaSanPham1.Visible=true;
            uC_SuaSanPham1.BringToFront();
            
            loadData();

            uC_SuaSanPham1.OnRefreshData += UcSuaSanPham_OnRefreshData;
            uC_SuaSanPham1.clearData();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_ThemSanPham1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_XoaSanPham1_Load(object sender, EventArgs e)
        {

        }

        private void uC_SuaSanPham1_Load(object sender, EventArgs e)
        {

        }
    }
}
