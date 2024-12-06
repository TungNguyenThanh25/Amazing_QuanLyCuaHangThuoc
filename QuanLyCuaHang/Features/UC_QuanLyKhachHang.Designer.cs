using System.Windows.Forms;

namespace QuanLyCuaHang.Features
{
    partial class UC_QuanLyKhachHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_movingquanlykhachhang = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_xoakhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_suathongtinkhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_timkhachang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_themkhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_XoaKhachHang1 = new QuanLyCuaHang.Features.UC_XoaKhachHang();
            this.uC_ThayDoiThongTinKhachHang1 = new QuanLyCuaHang.Features.UC_ThayDoiThongTinKhachHang();
            this.uC_TimKhachHang1 = new QuanLyCuaHang.Features.UC_TimKhachHang();
            this.uC_ThemKhachHang1 = new QuanLyCuaHang.Features.UC_ThemKhachHang();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panel_movingquanlykhachhang);
            this.guna2Panel1.Controls.Add(this.btn_xoakhachhang);
            this.guna2Panel1.Controls.Add(this.btn_suathongtinkhachhang);
            this.guna2Panel1.Controls.Add(this.btn_timkhachang);
            this.guna2Panel1.Controls.Add(this.btn_themkhachhang);
            this.guna2Panel1.Location = new System.Drawing.Point(686, 68);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(642, 37);
            this.guna2Panel1.TabIndex = 1;
            // 
            // panel_movingquanlykhachhang
            // 
            this.panel_movingquanlykhachhang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movingquanlykhachhang.Location = new System.Drawing.Point(2, 28);
            this.panel_movingquanlykhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.panel_movingquanlykhachhang.Name = "panel_movingquanlykhachhang";
            this.panel_movingquanlykhachhang.Size = new System.Drawing.Size(156, 6);
            this.panel_movingquanlykhachhang.TabIndex = 2;
            // 
            // btn_xoakhachhang
            // 
            this.btn_xoakhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoakhachhang.BorderRadius = 5;
            this.btn_xoakhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoakhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoakhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoakhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoakhachhang.FillColor = System.Drawing.Color.SkyBlue;
            this.btn_xoakhachhang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoakhachhang.ForeColor = System.Drawing.Color.Black;
            this.btn_xoakhachhang.Location = new System.Drawing.Point(484, 3);
            this.btn_xoakhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoakhachhang.Name = "btn_xoakhachhang";
            this.btn_xoakhachhang.Size = new System.Drawing.Size(156, 24);
            this.btn_xoakhachhang.TabIndex = 3;
            this.btn_xoakhachhang.Text = "Xóa khách hàng";
            this.btn_xoakhachhang.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btn_suathongtinkhachhang
            // 
            this.btn_suathongtinkhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btn_suathongtinkhachhang.BorderRadius = 5;
            this.btn_suathongtinkhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suathongtinkhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_suathongtinkhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_suathongtinkhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_suathongtinkhachhang.FillColor = System.Drawing.Color.SkyBlue;
            this.btn_suathongtinkhachhang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suathongtinkhachhang.ForeColor = System.Drawing.Color.Black;
            this.btn_suathongtinkhachhang.Location = new System.Drawing.Point(323, 3);
            this.btn_suathongtinkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_suathongtinkhachhang.Name = "btn_suathongtinkhachhang";
            this.btn_suathongtinkhachhang.Size = new System.Drawing.Size(156, 24);
            this.btn_suathongtinkhachhang.TabIndex = 2;
            this.btn_suathongtinkhachhang.Text = "Sửa thông tin";
            this.btn_suathongtinkhachhang.Click += new System.EventHandler(this.btn_suathongtinkhachhang_Click);
            // 
            // btn_timkhachang
            // 
            this.btn_timkhachang.BackColor = System.Drawing.Color.Transparent;
            this.btn_timkhachang.BorderRadius = 5;
            this.btn_timkhachang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timkhachang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_timkhachang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_timkhachang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_timkhachang.FillColor = System.Drawing.Color.SkyBlue;
            this.btn_timkhachang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkhachang.ForeColor = System.Drawing.Color.Black;
            this.btn_timkhachang.Location = new System.Drawing.Point(163, 3);
            this.btn_timkhachang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timkhachang.Name = "btn_timkhachang";
            this.btn_timkhachang.Size = new System.Drawing.Size(156, 24);
            this.btn_timkhachang.TabIndex = 1;
            this.btn_timkhachang.Text = "Tìm khách hàng";
            this.btn_timkhachang.Click += new System.EventHandler(this.btn_timkhachang_Click);
            // 
            // btn_themkhachhang
            // 
            this.btn_themkhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btn_themkhachhang.BorderRadius = 5;
            this.btn_themkhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themkhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themkhachhang.FillColor = System.Drawing.Color.SkyBlue;
            this.btn_themkhachhang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themkhachhang.ForeColor = System.Drawing.Color.Black;
            this.btn_themkhachhang.Location = new System.Drawing.Point(2, 3);
            this.btn_themkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themkhachhang.Name = "btn_themkhachhang";
            this.btn_themkhachhang.Size = new System.Drawing.Size(156, 24);
            this.btn_themkhachhang.TabIndex = 0;
            this.btn_themkhachhang.Text = "Thêm khách hàng";
            this.btn_themkhachhang.Click += new System.EventHandler(this.btn_themkhachhang_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Location = new System.Drawing.Point(686, 110);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(0, 0);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel4.Location = new System.Drawing.Point(9, 68);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(672, 551);
            this.guna2Panel4.TabIndex = 3;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.uC_XoaKhachHang1);
            this.guna2Panel5.Controls.Add(this.uC_ThayDoiThongTinKhachHang1);
            this.guna2Panel5.Controls.Add(this.uC_TimKhachHang1);
            this.guna2Panel5.Controls.Add(this.uC_ThemKhachHang1);
            this.guna2Panel5.Location = new System.Drawing.Point(686, 112);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(640, 507);
            this.guna2Panel5.TabIndex = 4;
            // 
            // uC_XoaKhachHang1
            // 
            this.uC_XoaKhachHang1.BackColor = System.Drawing.Color.LightGray;
            this.uC_XoaKhachHang1.Location = new System.Drawing.Point(0, -5);
            this.uC_XoaKhachHang1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_XoaKhachHang1.Name = "uC_XoaKhachHang1";
            this.uC_XoaKhachHang1.Size = new System.Drawing.Size(640, 512);
            this.uC_XoaKhachHang1.TabIndex = 3;
            // 
            // uC_ThayDoiThongTinKhachHang1
            // 
            this.uC_ThayDoiThongTinKhachHang1.BackColor = System.Drawing.Color.LightGray;
            this.uC_ThayDoiThongTinKhachHang1.Location = new System.Drawing.Point(0, -5);
            this.uC_ThayDoiThongTinKhachHang1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_ThayDoiThongTinKhachHang1.Name = "uC_ThayDoiThongTinKhachHang1";
            this.uC_ThayDoiThongTinKhachHang1.Size = new System.Drawing.Size(640, 512);
            this.uC_ThayDoiThongTinKhachHang1.TabIndex = 2;
            // 
            // uC_TimKhachHang1
            // 
            this.uC_TimKhachHang1.BackColor = System.Drawing.Color.LightGray;
            this.uC_TimKhachHang1.Location = new System.Drawing.Point(0, -5);
            this.uC_TimKhachHang1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_TimKhachHang1.Name = "uC_TimKhachHang1";
            this.uC_TimKhachHang1.Size = new System.Drawing.Size(642, 512);
            this.uC_TimKhachHang1.TabIndex = 1;
            // 
            // uC_ThemKhachHang1
            // 
            this.uC_ThemKhachHang1.BackColor = System.Drawing.Color.LightGray;
            this.uC_ThemKhachHang1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThemKhachHang1.Location = new System.Drawing.Point(0, -2);
            this.uC_ThemKhachHang1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uC_ThemKhachHang1.Name = "uC_ThemKhachHang1";
            this.uC_ThemKhachHang1.Size = new System.Drawing.Size(640, 509);
            this.uC_ThemKhachHang1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý khách hàng";
            //// 
            //// guna2DataGridView1
            //// 
            //dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            //dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            //dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            //dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            //dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            //this.guna2DataGridView1.ColumnHeadersHeight = 4;
            //this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            //dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            //this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.Location = new System.Drawing.Point(2, 3);
            //this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            //this.guna2DataGridView1.Name = "guna2DataGridView1";
            //this.guna2DataGridView1.RowHeadersVisible = false;
            //this.guna2DataGridView1.RowTemplate.Height = 24;
            //this.guna2DataGridView1.Size = new System.Drawing.Size(668, 545);
            //this.guna2DataGridView1.TabIndex = 0;
            //this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            //this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            //this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            //this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            //this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            //this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));

            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            // Header style
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(33, 150, 243); // Modern blue
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(25, 118, 210); // Darker blue on select
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 50;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            // Cell style
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33); // Neutral dark text
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201); // Highlighted row (green tint)
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5); // Add padding for clarity
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;

            // Grid styling
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(224, 224, 224); // Light gray grid lines

            // Properties
            this.guna2DataGridView1.Location = new System.Drawing.Point(2, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false; // Hide row headers
            this.guna2DataGridView1.ReadOnly = true; // Disable editing
            this.guna2DataGridView1.Size = new System.Drawing.Size(668, 545);
            this.guna2DataGridView1.AllowUserToAddRows = false; // Disable adding new rows
            this.guna2DataGridView1.AllowUserToDeleteRows = false; // Disable deleting rows
            this.guna2DataGridView1.AllowUserToResizeRows = false; // Disable row resizing
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Select the full row

            // Theming
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;

            // 
            // UC_QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_QuanLyKhachHang";
            this.Size = new System.Drawing.Size(1348, 656);
            this.Load += new System.EventHandler(this.UC_QuanLyKhachHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_suathongtinkhachhang;
        private Guna.UI2.WinForms.Guna2Button btn_timkhachang;
        private Guna.UI2.WinForms.Guna2Button btn_themkhachhang;
        private Guna.UI2.WinForms.Guna2Button btn_xoakhachhang;
        private Guna.UI2.WinForms.Guna2Panel panel_movingquanlykhachhang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC_ThemKhachHang uC_ThemKhachHang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_TimKhachHang uC_TimKhachHang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_ThayDoiThongTinKhachHang uC_ThayDoiThongTinKhachHang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UC_XoaKhachHang uC_XoaKhachHang1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
