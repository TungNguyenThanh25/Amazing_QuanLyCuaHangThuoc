using System.Windows.Forms;

namespace QuanLyCuaHang
{
    partial class UC_KhuyenMai
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_themkhuyenmaisanpham = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoakhuyenmaisanpham = new Guna.UI2.WinForms.Guna2Button();
            this.panel_movingkhuyenmai = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_xoakhuyenmaiHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btn_themkhuyenmaiHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.uC_XoaKhuyenMaiHoaDon1 = new QuanLyCuaHang.UC_XoaKhuyenMaiHoaDon();
            this.uC_ThemKhuyenMaiHoaDon1 = new QuanLyCuaHang.UC_ThemKhuyenMaiHoaDon();
            this.uC_XoaMaKhuyenMaiSanPham1 = new QuanLyCuaHang.UC_XoaMaKhuyenMaiSanPham();
            this.uC_ThemMaKhuyenMaiSanPham1 = new QuanLyCuaHang.UC_ThemMaKhuyenMaiSanPham();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khuyến mãi\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_themkhuyenmaisanpham
            // 
            this.btn_themkhuyenmaisanpham.BorderRadius = 5;
            this.btn_themkhuyenmaisanpham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkhuyenmaisanpham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkhuyenmaisanpham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themkhuyenmaisanpham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themkhuyenmaisanpham.FillColor = System.Drawing.Color.LightBlue;
            this.btn_themkhuyenmaisanpham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themkhuyenmaisanpham.ForeColor = System.Drawing.Color.Black;
            this.btn_themkhuyenmaisanpham.Location = new System.Drawing.Point(53, 56);
            this.btn_themkhuyenmaisanpham.Name = "btn_themkhuyenmaisanpham";
            this.btn_themkhuyenmaisanpham.Size = new System.Drawing.Size(316, 37);
            this.btn_themkhuyenmaisanpham.TabIndex = 3;
            this.btn_themkhuyenmaisanpham.Text = "Thêm khuyến mãi sản phẩm";
            this.btn_themkhuyenmaisanpham.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn_xoakhuyenmaisanpham
            // 
            this.btn_xoakhuyenmaisanpham.BorderRadius = 5;
            this.btn_xoakhuyenmaisanpham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoakhuyenmaisanpham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoakhuyenmaisanpham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoakhuyenmaisanpham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoakhuyenmaisanpham.FillColor = System.Drawing.Color.LightBlue;
            this.btn_xoakhuyenmaisanpham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoakhuyenmaisanpham.ForeColor = System.Drawing.Color.Black;
            this.btn_xoakhuyenmaisanpham.Location = new System.Drawing.Point(371, 56);
            this.btn_xoakhuyenmaisanpham.Name = "btn_xoakhuyenmaisanpham";
            this.btn_xoakhuyenmaisanpham.Size = new System.Drawing.Size(316, 37);
            this.btn_xoakhuyenmaisanpham.TabIndex = 4;
            this.btn_xoakhuyenmaisanpham.Text = "Xóa khuyến mãi sản phẩm";
            this.btn_xoakhuyenmaisanpham.Click += new System.EventHandler(this.btn_xoakhuyenmaisanpham_Click);
            // 
            // panel_movingkhuyenmai
            // 
            this.panel_movingkhuyenmai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movingkhuyenmai.BorderRadius = 5;
            this.panel_movingkhuyenmai.Location = new System.Drawing.Point(53, 97);
            this.panel_movingkhuyenmai.Name = "panel_movingkhuyenmai";
            this.panel_movingkhuyenmai.Size = new System.Drawing.Size(316, 10);
            this.panel_movingkhuyenmai.TabIndex = 5;
            // 
            // btn_xoakhuyenmaiHoaDon
            // 
            this.btn_xoakhuyenmaiHoaDon.BorderRadius = 5;
            this.btn_xoakhuyenmaiHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoakhuyenmaiHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoakhuyenmaiHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoakhuyenmaiHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoakhuyenmaiHoaDon.FillColor = System.Drawing.Color.LightBlue;
            this.btn_xoakhuyenmaiHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoakhuyenmaiHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btn_xoakhuyenmaiHoaDon.Location = new System.Drawing.Point(1013, 56);
            this.btn_xoakhuyenmaiHoaDon.Name = "btn_xoakhuyenmaiHoaDon";
            this.btn_xoakhuyenmaiHoaDon.Size = new System.Drawing.Size(316, 37);
            this.btn_xoakhuyenmaiHoaDon.TabIndex = 7;
            this.btn_xoakhuyenmaiHoaDon.Text = "Xóa khuyến mãi hóa đơn";
            this.btn_xoakhuyenmaiHoaDon.Click += new System.EventHandler(this.btn_xoakhuyenmaiHoaDon_Click);
            // 
            // btn_themkhuyenmaiHoaDon
            // 
            this.btn_themkhuyenmaiHoaDon.BorderRadius = 5;
            this.btn_themkhuyenmaiHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkhuyenmaiHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themkhuyenmaiHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themkhuyenmaiHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themkhuyenmaiHoaDon.FillColor = System.Drawing.Color.LightBlue;
            this.btn_themkhuyenmaiHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themkhuyenmaiHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btn_themkhuyenmaiHoaDon.Location = new System.Drawing.Point(691, 56);
            this.btn_themkhuyenmaiHoaDon.Name = "btn_themkhuyenmaiHoaDon";
            this.btn_themkhuyenmaiHoaDon.Size = new System.Drawing.Size(316, 37);
            this.btn_themkhuyenmaiHoaDon.TabIndex = 6;
            this.btn_themkhuyenmaiHoaDon.Text = "Thêm khuyến mãi hóa đơn";
            this.btn_themkhuyenmaiHoaDon.Click += new System.EventHandler(this.btn_themkhuyenmaiHoaDon_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Controls.Add(this.uC_XoaKhuyenMaiHoaDon1);
            this.guna2Panel2.Controls.Add(this.uC_ThemKhuyenMaiHoaDon1);
            this.guna2Panel2.Controls.Add(this.uC_XoaMaKhuyenMaiSanPham1);
            this.guna2Panel2.Controls.Add(this.uC_ThemMaKhuyenMaiSanPham1);
            this.guna2Panel2.Location = new System.Drawing.Point(40, 113);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1289, 521);
            this.guna2Panel2.TabIndex = 8;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.Location = new System.Drawing.Point(581, 27);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(693, 465);
            this.guna2Panel1.TabIndex = 4;
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
            //this.guna2DataGridView1.ColumnHeadersHeight = 4;
            //this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            //dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            //this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.Location = new System.Drawing.Point(4, 3);
            //this.guna2DataGridView1.Name = "guna2DataGridView1";
            //this.guna2DataGridView1.RowHeadersVisible = false;
            //this.guna2DataGridView1.Size = new System.Drawing.Size(686, 453);
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
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            //this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);

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
            this.guna2DataGridView1.Location = new System.Drawing.Point(4, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false; // Hide row headers
            this.guna2DataGridView1.ReadOnly = true; // Disable editing
            this.guna2DataGridView1.Size = new System.Drawing.Size(686, 453);
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
            // uC_XoaKhuyenMaiHoaDon1
            // 
            this.uC_XoaKhuyenMaiHoaDon1.BackColor = System.Drawing.Color.Transparent;
            this.uC_XoaKhuyenMaiHoaDon1.Location = new System.Drawing.Point(0, -1);
            this.uC_XoaKhuyenMaiHoaDon1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_XoaKhuyenMaiHoaDon1.Name = "uC_XoaKhuyenMaiHoaDon1";
            this.uC_XoaKhuyenMaiHoaDon1.Size = new System.Drawing.Size(576, 520);
            this.uC_XoaKhuyenMaiHoaDon1.TabIndex = 3;
            // 
            // uC_ThemKhuyenMaiHoaDon1
            // 
            this.uC_ThemKhuyenMaiHoaDon1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ThemKhuyenMaiHoaDon1.Location = new System.Drawing.Point(2, 2);
            this.uC_ThemKhuyenMaiHoaDon1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_ThemKhuyenMaiHoaDon1.Name = "uC_ThemKhuyenMaiHoaDon1";
            this.uC_ThemKhuyenMaiHoaDon1.Size = new System.Drawing.Size(578, 517);
            this.uC_ThemKhuyenMaiHoaDon1.TabIndex = 2;
            this.uC_ThemKhuyenMaiHoaDon1.Load += new System.EventHandler(this.uC_ThemKhuyenMaiHoaDon1_Load);
            // 
            // uC_XoaMaKhuyenMaiSanPham1
            // 
            this.uC_XoaMaKhuyenMaiSanPham1.BackColor = System.Drawing.Color.Transparent;
            this.uC_XoaMaKhuyenMaiSanPham1.Location = new System.Drawing.Point(0, 0);
            this.uC_XoaMaKhuyenMaiSanPham1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_XoaMaKhuyenMaiSanPham1.Name = "uC_XoaMaKhuyenMaiSanPham1";
            this.uC_XoaMaKhuyenMaiSanPham1.Size = new System.Drawing.Size(580, 519);
            this.uC_XoaMaKhuyenMaiSanPham1.TabIndex = 1;
            this.uC_XoaMaKhuyenMaiSanPham1.Load += new System.EventHandler(this.uC_XoaMaKhuyenMaiSanPham1_Load);
            // 
            // uC_ThemMaKhuyenMaiSanPham1
            // 
            this.uC_ThemMaKhuyenMaiSanPham1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ThemMaKhuyenMaiSanPham1.Location = new System.Drawing.Point(0, 0);
            this.uC_ThemMaKhuyenMaiSanPham1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_ThemMaKhuyenMaiSanPham1.Name = "uC_ThemMaKhuyenMaiSanPham1";
            this.uC_ThemMaKhuyenMaiSanPham1.Size = new System.Drawing.Size(580, 519);
            this.uC_ThemMaKhuyenMaiSanPham1.TabIndex = 0;
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
            // UC_KhuyenMai
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btn_xoakhuyenmaiHoaDon);
            this.Controls.Add(this.btn_themkhuyenmaiHoaDon);
            this.Controls.Add(this.panel_movingkhuyenmai);
            this.Controls.Add(this.btn_xoakhuyenmaisanpham);
            this.Controls.Add(this.btn_themkhuyenmaisanpham);
            this.Controls.Add(this.label1);
            this.Name = "UC_KhuyenMai";
            this.Size = new System.Drawing.Size(1347, 650);
            this.Load += new System.EventHandler(this.UC_KhuyenMai_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panel_movingkhuyenmai;
        private Guna.UI2.WinForms.Guna2Button btn_xoakhuyenmaisanpham;
        private Guna.UI2.WinForms.Guna2Button btn_themkhuyenmaisanpham;
        private Guna.UI2.WinForms.Guna2Button btn_xoakhuyenmaiHoaDon;
        private Guna.UI2.WinForms.Guna2Button btn_themkhuyenmaiHoaDon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_ThemMaKhuyenMaiSanPham uC_ThemMaKhuyenMaiSanPham1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_XoaMaKhuyenMaiSanPham uC_XoaMaKhuyenMaiSanPham1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UC_ThemKhuyenMaiHoaDon uC_ThemKhuyenMaiHoaDon1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private UC_XoaKhuyenMaiHoaDon uC_XoaKhuyenMaiHoaDon1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
