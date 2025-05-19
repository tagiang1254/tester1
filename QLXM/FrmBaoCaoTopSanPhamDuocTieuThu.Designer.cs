namespace QLXM
{
    partial class FrmBaoCaoTopSanPhamTieuThu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSP = new System.Windows.Forms.RadioButton();
            this.rdoThoigian = new System.Windows.Forms.RadioButton();
            this.rdoHSX = new System.Windows.Forms.RadioButton();
            this.rdoMau = new System.Windows.Forms.RadioButton();
            this.rdoTheloai = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo top sản phẩm được tiêu thụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTheloai);
            this.groupBox1.Controls.Add(this.rdoMau);
            this.groupBox1.Controls.Add(this.rdoHSX);
            this.groupBox1.Controls.Add(this.rdoSP);
            this.groupBox1.Location = new System.Drawing.Point(72, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục báo cáo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNam);
            this.groupBox2.Controls.Add(this.txtThang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdoThoigian);
            this.groupBox2.Location = new System.Drawing.Point(56, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tuỳ chọn thời gian";
            // 
            // rdoSP
            // 
            this.rdoSP.AutoSize = true;
            this.rdoSP.Location = new System.Drawing.Point(18, 26);
            this.rdoSP.Name = "rdoSP";
            this.rdoSP.Size = new System.Drawing.Size(107, 24);
            this.rdoSP.TabIndex = 0;
            this.rdoSP.TabStop = true;
            this.rdoSP.Text = "Sản phẩm";
            this.rdoSP.UseVisualStyleBackColor = true;
            // 
            // rdoThoigian
            // 
            this.rdoThoigian.AutoSize = true;
            this.rdoThoigian.Location = new System.Drawing.Point(18, 25);
            this.rdoThoigian.Name = "rdoThoigian";
            this.rdoThoigian.Size = new System.Drawing.Size(154, 24);
            this.rdoThoigian.TabIndex = 1;
            this.rdoThoigian.TabStop = true;
            this.rdoThoigian.Text = "Theo tháng, năm";
            this.rdoThoigian.UseVisualStyleBackColor = true;
            this.rdoThoigian.CheckedChanged += new System.EventHandler(this.rdoThoigian_CheckedChanged);
            // 
            // rdoHSX
            // 
            this.rdoHSX.AutoSize = true;
            this.rdoHSX.Location = new System.Drawing.Point(18, 56);
            this.rdoHSX.Name = "rdoHSX";
            this.rdoHSX.Size = new System.Drawing.Size(137, 24);
            this.rdoHSX.TabIndex = 2;
            this.rdoHSX.TabStop = true;
            this.rdoHSX.Text = "Hãng sản xuất";
            this.rdoHSX.UseVisualStyleBackColor = true;
            // 
            // rdoMau
            // 
            this.rdoMau.AutoSize = true;
            this.rdoMau.Location = new System.Drawing.Point(18, 86);
            this.rdoMau.Name = "rdoMau";
            this.rdoMau.Size = new System.Drawing.Size(65, 24);
            this.rdoMau.TabIndex = 3;
            this.rdoMau.TabStop = true;
            this.rdoMau.Text = "Màu";
            this.rdoMau.UseVisualStyleBackColor = true;
            // 
            // rdoTheloai
            // 
            this.rdoTheloai.AutoSize = true;
            this.rdoTheloai.Location = new System.Drawing.Point(18, 118);
            this.rdoTheloai.Name = "rdoTheloai";
            this.rdoTheloai.Size = new System.Drawing.Size(89, 24);
            this.rdoTheloai.TabIndex = 2;
            this.rdoTheloai.TabStop = true;
            this.rdoTheloai.Text = "Thể loại";
            this.rdoTheloai.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(72, 56);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(49, 26);
            this.txtThang.TabIndex = 4;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(208, 56);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(49, 26);
            this.txtNam.TabIndex = 5;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(72, 450);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(93, 37);
            this.btnHienthi.TabIndex = 3;
            this.btnHienthi.Text = "Tìm kiếm";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(225, 504);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 35);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(225, 450);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(75, 37);
            this.btnTimlai.TabIndex = 5;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(72, 504);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(93, 35);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(360, 289);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(428, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // FrmBaoCaoTopSanPhamTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaoCaoTopSanPhamTieuThu";
            this.Text = "FrmBaoCaoTopSanPhamTieuThu";
            this.Load += new System.EventHandler(this.FrmBaoCaoTopSanPhamTieuThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTheloai;
        private System.Windows.Forms.RadioButton rdoMau;
        private System.Windows.Forms.RadioButton rdoHSX;
        private System.Windows.Forms.RadioButton rdoSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoThoigian;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
