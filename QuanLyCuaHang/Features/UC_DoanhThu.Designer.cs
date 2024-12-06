using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHang
{
    partial class UC_DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uC_DoanhThuNam1 = new QuanLyCuaHang.UC_DoanhThuNam();
            this.uC_DoanhThuThang1 = new QuanLyCuaHang.UC_DoanhThuThang();
            this.btn_doanhthunam = new Guna.UI2.WinForms.Guna2Button();
            this.btn_doanhthuthang = new Guna.UI2.WinForms.Guna2Button();
            this.panel_movingdoanhthu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.chart1);
            this.guna2Panel1.Controls.Add(this.uC_DoanhThuNam1);
            this.guna2Panel1.Controls.Add(this.uC_DoanhThuThang1);
            this.guna2Panel1.Location = new System.Drawing.Point(28, 194);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1298, 439);
            this.guna2Panel1.TabIndex = 14;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            //// 
            //// chart1
            //// 
            //this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.chart1.BorderlineColor = System.Drawing.Color.Silver;
            //this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            //this.chart1.BorderlineWidth = 2;
            //chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 10F);
            //chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            //chartArea1.AxisX.Title = "Thời gian (Ngày/Tháng)";
            //chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            //chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 10F);
            //chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            //chartArea1.AxisY.Title = "Doanh thu (VND)";
            //chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            //chartArea1.BackColor = System.Drawing.Color.White;
            //chartArea1.Name = "ChartArea1";
            //this.chart1.ChartAreas.Add(chartArea1);
            //legend1.Alignment = System.Drawing.StringAlignment.Center;
            //legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            //legend1.Font = new System.Drawing.Font("Arial", 8F);
            //legend1.Name = "Legend1";
            //this.chart1.Legends.Add(legend1);
            //this.chart1.Location = new System.Drawing.Point(10, 10);
            //this.chart1.Name = "chart1";
            //series1.BorderWidth = 2;
            //series1.ChartArea = "ChartArea1";
            //series1.Color = System.Drawing.Color.SteelBlue;
            //series1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            //series1.IsValueShownAsLabel = true;
            //series1.LabelForeColor = System.Drawing.Color.DarkBlue;
            //series1.Legend = "Legend1";
            //series1.Name = "Series1";
            //this.chart1.Series.Add(series1);
            //this.chart1.Size = new System.Drawing.Size(750, 425);
            //this.chart1.TabIndex = 2;
            //this.chart1.Text = "Biểu đồ Doanh Thu";

            // Cấu hình chung cho biểu đồ
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BorderlineColor = System.Drawing.Color.Silver;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;

            // Cấu hình vùng biểu đồ
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 10F);
            chartArea1.AxisX.LabelStyle.Angle = -45; // Nghiêng nhãn trục X 45 độ
            chartArea1.AxisX.Interval = 3; // Hiển thị nhãn cách nhau 3 ngày
            chartArea1.AxisX.MajorGrid.Enabled = false; // Ẩn lưới dọc
            chartArea1.AxisX.Title = "Thời gian (Ngày)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);

            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 10F);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Title = "Doanh thu (VND)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);

            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);

            // Cấu hình chú thích (Legend)
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Arial", 8F);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);

            // Cấu hình series
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu tháng 10, năm 2024";
            series1.Color = System.Drawing.Color.SteelBlue; // Đổi màu cột chính
            series1.BorderWidth = 2;
            series1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.DarkBlue;

            // Làm cho các giá trị hiển thị rõ hơn
            series1["PointWidth"] = "0.5"; // Thu hẹp cột để tăng khoảng cách
            series1.SmartLabelStyle.Enabled = true; // Tự động điều chỉnh vị trí label để không bị chồng chéo
            series1.LabelFormat = "N0"; // Định dạng số (ví dụ: 1,000,000)

            // Tạo thêm một màu gradient để làm nổi bật
            series1.BackSecondaryColor = System.Drawing.Color.LightSkyBlue;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;

            this.chart1.Series.Add(series1);

            // Cấu hình vị trí và kích thước của biểu đồ
            this.chart1.Location = new System.Drawing.Point(0, 15);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(775, 420);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "Biểu đồ Doanh Thu";

            // 
            // uC_DoanhThuNam1
            // 
            this.uC_DoanhThuNam1.BackColor = System.Drawing.Color.Silver;
            this.uC_DoanhThuNam1.Location = new System.Drawing.Point(778, 1);
            this.uC_DoanhThuNam1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_DoanhThuNam1.Name = "uC_DoanhThuNam1";
            this.uC_DoanhThuNam1.Size = new System.Drawing.Size(531, 435);
            this.uC_DoanhThuNam1.TabIndex = 1;
            this.uC_DoanhThuNam1.Load += new System.EventHandler(this.uC_DoanhThuNam1_Load);
            // 
            // uC_DoanhThuThang1
            // 
            this.uC_DoanhThuThang1.BackColor = System.Drawing.Color.Silver;
            this.uC_DoanhThuThang1.Location = new System.Drawing.Point(778, 1);
            this.uC_DoanhThuThang1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_DoanhThuThang1.Name = "uC_DoanhThuThang1";
            this.uC_DoanhThuThang1.Size = new System.Drawing.Size(518, 436);
            this.uC_DoanhThuThang1.TabIndex = 0;
            this.uC_DoanhThuThang1.Load += new System.EventHandler(this.uC_DoanhThuThang1_Load);
            // 
            // btn_doanhthunam
            // 
            this.btn_doanhthunam.BackColor = System.Drawing.Color.Transparent;
            this.btn_doanhthunam.BorderRadius = 5;
            this.btn_doanhthunam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthunam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthunam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_doanhthunam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_doanhthunam.FillColor = System.Drawing.Color.LightBlue;
            this.btn_doanhthunam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthunam.ForeColor = System.Drawing.Color.Black;
            this.btn_doanhthunam.Location = new System.Drawing.Point(679, 142);
            this.btn_doanhthunam.Name = "btn_doanhthunam";
            this.btn_doanhthunam.Size = new System.Drawing.Size(647, 39);
            this.btn_doanhthunam.TabIndex = 17;
            this.btn_doanhthunam.Text = "Doanh thu năm";
            this.btn_doanhthunam.Click += new System.EventHandler(this.btn_doanhthunam_Click);
            // 
            // btn_doanhthuthang
            // 
            this.btn_doanhthuthang.BackColor = System.Drawing.Color.Transparent;
            this.btn_doanhthuthang.BorderRadius = 5;
            this.btn_doanhthuthang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthuthang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthuthang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_doanhthuthang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_doanhthuthang.FillColor = System.Drawing.Color.LightBlue;
            this.btn_doanhthuthang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthuthang.ForeColor = System.Drawing.Color.Black;
            this.btn_doanhthuthang.Location = new System.Drawing.Point(28, 142);
            this.btn_doanhthuthang.Name = "btn_doanhthuthang";
            this.btn_doanhthuthang.Size = new System.Drawing.Size(647, 39);
            this.btn_doanhthuthang.TabIndex = 18;
            this.btn_doanhthuthang.Text = "Doanh thu tháng";
            this.btn_doanhthuthang.Click += new System.EventHandler(this.btn_doanhthuthang_Click);
            // 
            // panel_movingdoanhthu
            // 
            this.panel_movingdoanhthu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movingdoanhthu.BorderRadius = 5;
            this.panel_movingdoanhthu.Location = new System.Drawing.Point(28, 182);
            this.panel_movingdoanhthu.Name = "panel_movingdoanhthu";
            this.panel_movingdoanhthu.Size = new System.Drawing.Size(647, 10);
            this.panel_movingdoanhthu.TabIndex = 30;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // UC_DoanhThu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel_movingdoanhthu);
            this.Controls.Add(this.btn_doanhthuthang);
            this.Controls.Add(this.btn_doanhthunam);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_DoanhThu";
            this.Size = new System.Drawing.Size(1347, 650);
            this.Load += new System.EventHandler(this.UC_DoanhThu_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panel_movingdoanhthu;
        private Guna.UI2.WinForms.Guna2Button btn_doanhthuthang;
        private Guna.UI2.WinForms.Guna2Button btn_doanhthunam;
        private UC_DoanhThuThang uC_DoanhThuThang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_DoanhThuNam uC_DoanhThuNam1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
