using System.Windows.Forms;

namespace QuanLyCuaHang.Features
{
    partial class UC_QuanLyNhanVien
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel_movingquanlynhanvien = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_xoanhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_suathongtinnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_timnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_themnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.uC_XoaNhanVien1 = new QuanLyCuaHang.Features.UC_XoaNhanVien();
            this.uC_ThayDoiThongTinNhanVien1 = new QuanLyCuaHang.Features.UC_ThayDoiThongTinNhanVien();
            this.uC_TimNhanVien1 = new QuanLyCuaHang.Features.UC_TimNhanVien();
            this.uC_ThemNhanVien1 = new QuanLyCuaHang.Features.UC_ThemNhanVien();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.Location = new System.Drawing.Point(23, 67);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(746, 555);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.panel_movingquanlynhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_xoanhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_suathongtinnhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_timnhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_themnhanvien);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(773, 67);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(557, 44);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // panel_movingquanlynhanvien
            // 
            this.panel_movingquanlynhanvien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movingquanlynhanvien.Location = new System.Drawing.Point(2, 36);
            this.panel_movingquanlynhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.panel_movingquanlynhanvien.Name = "panel_movingquanlynhanvien";
            this.panel_movingquanlynhanvien.Size = new System.Drawing.Size(136, 8);
            this.panel_movingquanlynhanvien.TabIndex = 0;
            this.panel_movingquanlynhanvien.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_movingquanlynhanvien_Paint);
            // 
            // btn_xoanhanvien
            // 
            this.btn_xoanhanvien.BorderRadius = 5;
            this.btn_xoanhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoanhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoanhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoanhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoanhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_xoanhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoanhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_xoanhanvien.Location = new System.Drawing.Point(421, 2);
            this.btn_xoanhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoanhanvien.Name = "btn_xoanhanvien";
            this.btn_xoanhanvien.Size = new System.Drawing.Size(136, 32);
            this.btn_xoanhanvien.TabIndex = 3;
            this.btn_xoanhanvien.Text = "Xóa nhân viên";
            this.btn_xoanhanvien.Click += new System.EventHandler(this.btn_xoanhanvien_Click);
            // 
            // btn_suathongtinnhanvien
            // 
            this.btn_suathongtinnhanvien.BorderRadius = 5;
            this.btn_suathongtinnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suathongtinnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_suathongtinnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_suathongtinnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_suathongtinnhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_suathongtinnhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suathongtinnhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_suathongtinnhanvien.Location = new System.Drawing.Point(280, 2);
            this.btn_suathongtinnhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_suathongtinnhanvien.Name = "btn_suathongtinnhanvien";
            this.btn_suathongtinnhanvien.Size = new System.Drawing.Size(136, 32);
            this.btn_suathongtinnhanvien.TabIndex = 2;
            this.btn_suathongtinnhanvien.Text = "Sửa thông tin";
            this.btn_suathongtinnhanvien.Click += new System.EventHandler(this.btn_suathongtinnhanvien_Click);
            // 
            // btn_timnhanvien
            // 
            this.btn_timnhanvien.BorderRadius = 5;
            this.btn_timnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_timnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_timnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_timnhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_timnhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timnhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_timnhanvien.Location = new System.Drawing.Point(140, 2);
            this.btn_timnhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timnhanvien.Name = "btn_timnhanvien";
            this.btn_timnhanvien.Size = new System.Drawing.Size(136, 32);
            this.btn_timnhanvien.TabIndex = 1;
            this.btn_timnhanvien.Text = "Tìm nhân viên";
            this.btn_timnhanvien.Click += new System.EventHandler(this.btn_timnhanvien_Click);
            // 
            // btn_themnhanvien
            // 
            this.btn_themnhanvien.BorderRadius = 5;
            this.btn_themnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themnhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_themnhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themnhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_themnhanvien.Location = new System.Drawing.Point(1, 2);
            this.btn_themnhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themnhanvien.Name = "btn_themnhanvien";
            this.btn_themnhanvien.Size = new System.Drawing.Size(136, 32);
            this.btn_themnhanvien.TabIndex = 0;
            this.btn_themnhanvien.Text = "Thêm nhân viên";
            this.btn_themnhanvien.Click += new System.EventHandler(this.btn_themnhanvien_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_XoaNhanVien1);
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_ThayDoiThongTinNhanVien1);
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_TimNhanVien1);
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_ThemNhanVien1);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(773, 116);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(557, 506);
            this.guna2CustomGradientPanel2.TabIndex = 3;
            // 
            // uC_XoaNhanVien1
            // 
            this.uC_XoaNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_XoaNhanVien1.Location = new System.Drawing.Point(1, 0);
            this.uC_XoaNhanVien1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_XoaNhanVien1.Name = "uC_XoaNhanVien1";
            this.uC_XoaNhanVien1.Size = new System.Drawing.Size(557, 506);
            this.uC_XoaNhanVien1.TabIndex = 3;
            // 
            // uC_ThayDoiThongTinNhanVien1
            // 
            this.uC_ThayDoiThongTinNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_ThayDoiThongTinNhanVien1.Location = new System.Drawing.Point(1, -2);
            this.uC_ThayDoiThongTinNhanVien1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_ThayDoiThongTinNhanVien1.Name = "uC_ThayDoiThongTinNhanVien1";
            this.uC_ThayDoiThongTinNhanVien1.Size = new System.Drawing.Size(557, 506);
            this.uC_ThayDoiThongTinNhanVien1.TabIndex = 2;
            // 
            // uC_TimNhanVien1
            // 
            this.uC_TimNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_TimNhanVien1.Location = new System.Drawing.Point(2, -2);
            this.uC_TimNhanVien1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_TimNhanVien1.Name = "uC_TimNhanVien1";
            this.uC_TimNhanVien1.Size = new System.Drawing.Size(555, 506);
            this.uC_TimNhanVien1.TabIndex = 1;
            this.uC_TimNhanVien1.Load += new System.EventHandler(this.uC_TimNhanVien1_Load);
            // 
            // uC_ThemNhanVien1
            // 
            this.uC_ThemNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_ThemNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.uC_ThemNhanVien1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_ThemNhanVien1.Name = "uC_ThemNhanVien1";
            this.uC_ThemNhanVien1.Size = new System.Drawing.Size(557, 506);
            this.uC_ThemNhanVien1.TabIndex = 0;
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
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý nhân viên";
            //// 
            //// guna2DataGridView1
            //// 
            //dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            //dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            //dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            //dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            //dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            //this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            //dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True
            //this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            //this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.Location = new System.Drawing.Point(3, 3);
            //this.guna2DataGridView1.Name = "guna2DataGridView1";
            //this.guna2DataGridView1.RowHeadersVisible = false;
            //this.guna2DataGridView1.Size = new System.Drawing.Size(740, 550);
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
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            //this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);

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
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false; // Hide row headers
            this.guna2DataGridView1.ReadOnly = true; // Disable editing
            this.guna2DataGridView1.Size = new System.Drawing.Size(740, 550);
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
            // UC_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1347, 650);
            this.Load += new System.EventHandler(this.UC_QuanLyNhanVien_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btn_xoanhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_suathongtinnhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_timnhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_themnhanvien;
        private Guna.UI2.WinForms.Guna2Panel panel_movingquanlynhanvien;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_ThemNhanVien uC_ThemNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_TimNhanVien uC_TimNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UC_ThayDoiThongTinNhanVien uC_ThayDoiThongTinNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private UC_XoaNhanVien uC_XoaNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
