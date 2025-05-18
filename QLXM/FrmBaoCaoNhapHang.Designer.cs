using System.Drawing;
using System.Windows.Forms;

namespace QLXM
{
    partial class FrmBaoCaoNhapHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DateTimePicker dateTuKhoang;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTuKhoang = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            this.dateDenKhoang = new System.Windows.Forms.DateTimePicker();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dateTuKhoang = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO NHẬP HÀNG";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.txtDongia);
            this.grpTimKiem.Controls.Add(this.lblDonGia);
            this.grpTimKiem.Controls.Add(this.lblTuKhoang);
            this.grpTimKiem.Controls.Add(this.lblDen);
            this.grpTimKiem.Controls.Add(this.dateDenKhoang);
            this.grpTimKiem.Controls.Add(this.lblNCC);
            this.grpTimKiem.Controls.Add(this.lblTenHang);
            this.grpTimKiem.Controls.Add(this.lblNhanVien);
            this.grpTimKiem.Controls.Add(this.lblMaHD);
            this.grpTimKiem.Controls.Add(this.cboMaHD);
            this.grpTimKiem.Controls.Add(this.cboTenHang);
            this.grpTimKiem.Controls.Add(this.cboNhaCungCap);
            this.grpTimKiem.Controls.Add(this.cboNhanVien);
            this.grpTimKiem.Controls.Add(this.dateTuKhoang);
            this.grpTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.Location = new System.Drawing.Point(30, 60);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(700, 150);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(110, 111);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.ReadOnly = true;
            this.txtDongia.Size = new System.Drawing.Size(121, 26);
            this.txtDongia.TabIndex = 18;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(-1, 117);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(66, 19);
            this.lblDonGia.TabIndex = 17;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // lblTuKhoang
            // 
            this.lblTuKhoang.AutoSize = true;
            this.lblTuKhoang.Location = new System.Drawing.Point(323, 115);
            this.lblTuKhoang.Name = "lblTuKhoang";
            this.lblTuKhoang.Size = new System.Drawing.Size(85, 19);
            this.lblTuKhoang.TabIndex = 16;
            this.lblTuKhoang.Text = "Từ Khoảng";
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(559, 117);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(37, 19);
            this.lblDen.TabIndex = 15;
            this.lblDen.Text = "Đến";
            // 
            // dateDenKhoang
            // 
            this.dateDenKhoang.CustomFormat = "_/__/____";
            this.dateDenKhoang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenKhoang.Location = new System.Drawing.Point(602, 111);
            this.dateDenKhoang.Name = "dateDenKhoang";
            this.dateDenKhoang.Size = new System.Drawing.Size(92, 26);
            this.dateDenKhoang.TabIndex = 14;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(312, 72);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(107, 19);
            this.lblNCC.TabIndex = 12;
            this.lblNCC.Text = "Nhà Cung Cấp";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(312, 39);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(75, 19);
            this.lblTenHang.TabIndex = 11;
            this.lblTenHang.Text = "Tên Hàng";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(0, 82);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(79, 17);
            this.lblNhanVien.TabIndex = 10;
            this.lblNhanVien.Text = "Nhân Viên ";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(0, 40);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(92, 17);
            this.lblMaHD.TabIndex = 9;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // cboMaHD
            // 
            this.cboMaHD.Location = new System.Drawing.Point(110, 33);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(121, 27);
            this.cboMaHD.TabIndex = 0;
            // 
            // cboTenHang
            // 
            this.cboTenHang.Location = new System.Drawing.Point(443, 33);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(121, 27);
            this.cboTenHang.TabIndex = 1;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Location = new System.Drawing.Point(443, 69);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(121, 27);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Location = new System.Drawing.Point(110, 72);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(121, 27);
            this.cboNhanVien.TabIndex = 3;
            // 
            // dateTuKhoang
            // 
            this.dateTuKhoang.CustomFormat = "_/__/____";
            this.dateTuKhoang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuKhoang.Location = new System.Drawing.Point(443, 111);
            this.dateTuKhoang.Name = "dateTuKhoang";
            this.dateTuKhoang.Size = new System.Drawing.Size(110, 26);
            this.dateTuKhoang.TabIndex = 7;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AllowUserToResizeColumns = false;
            this.dgvDanhSach.AllowUserToResizeRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(30, 220);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.Size = new System.Drawing.Size(500, 150);
            this.dgvDanhSach.TabIndex = 2;
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AllowUserToResizeColumns = false;
            this.dgvHang.AllowUserToResizeRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHang.Location = new System.Drawing.Point(550, 220);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.ReadOnly = true;
            this.dgvHang.Size = new System.Drawing.Size(200, 150);
            this.dgvHang.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(150, 380);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(300, 380);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(75, 23);
            this.btnTimLai.TabIndex = 5;
            this.btnTimLai.Text = "Tìm lại";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(450, 380);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnInBaoCao.TabIndex = 6;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(600, 380);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            // 
            // FrmBaoCaoNhapHang
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmBaoCaoNhapHang";
            this.Text = "Báo cáo nhập hàng";
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblMaHD;
        private Label lblNCC;
        private Label lblTenHang;
        private Label lblNhanVien;
        private DateTimePicker dateDenKhoang;
        private Label lblTuKhoang;
        private Label lblDen;
        private TextBox txtDongia;
        private Label lblDonGia;
    }
}
