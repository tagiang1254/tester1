namespace BTL1
{
    partial class frmBaoCaoNhapHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.RadioButton radTheoNgay;
        private System.Windows.Forms.RadioButton radTuKhoang;
        private System.Windows.Forms.DateTimePicker dateTuKhoang;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridView dgvTong;
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
            lblTitle = new Label();
            grpTimKiem = new GroupBox();
            cboMaHD = new ComboBox();
            cboTenHang = new ComboBox();
            cboNhaCungCap = new ComboBox();
            cboNhanVien = new ComboBox();
            radTheoNgay = new RadioButton();
            radTuKhoang = new RadioButton();
            dateNgay = new DateTimePicker();
            dateTuKhoang = new DateTimePicker();
            dgvDanhSach = new DataGridView();
            dgvTong = new DataGridView();
            btnTimKiem = new Button();
            btnTimLai = new Button();
            btnInBaoCao = new Button();
            btnDong = new Button();
            lblMaHD = new Label();
            lblNhanVien = new Label();
            lblTenHang = new Label();
            lblNCC = new Label();
            radDenkhoang = new RadioButton();
            dateDenKhoang = new DateTimePicker();
            grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(250, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÁO CÁO NHẬP HÀNG";
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(dateDenKhoang);
            grpTimKiem.Controls.Add(radDenkhoang);
            grpTimKiem.Controls.Add(lblNCC);
            grpTimKiem.Controls.Add(lblTenHang);
            grpTimKiem.Controls.Add(lblNhanVien);
            grpTimKiem.Controls.Add(lblMaHD);
            grpTimKiem.Controls.Add(cboMaHD);
            grpTimKiem.Controls.Add(cboTenHang);
            grpTimKiem.Controls.Add(cboNhaCungCap);
            grpTimKiem.Controls.Add(cboNhanVien);
            grpTimKiem.Controls.Add(radTheoNgay);
            grpTimKiem.Controls.Add(radTuKhoang);
            grpTimKiem.Controls.Add(dateNgay);
            grpTimKiem.Controls.Add(dateTuKhoang);
            grpTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            grpTimKiem.Location = new Point(30, 60);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new Size(700, 150);
            grpTimKiem.TabIndex = 1;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm";
            // 
            // cboMaHD
            // 
            cboMaHD.Location = new Point(110, 33);
            cboMaHD.Name = "cboMaHD";
            cboMaHD.Size = new Size(121, 27);
            cboMaHD.TabIndex = 0;           
            // cboTenHang
            // 
            cboTenHang.Location = new Point(443, 33);
            cboTenHang.Name = "cboTenHang";
            cboTenHang.Size = new Size(121, 27);
            cboTenHang.TabIndex = 1;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Location = new Point(443, 69);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(121, 27);
            cboNhaCungCap.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Location = new Point(110, 63);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(121, 27);
            cboNhanVien.TabIndex = 3;
            // 
            // radTheoNgay
            // 
            radTheoNgay.Location = new Point(0, 110);
            radTheoNgay.Name = "radTheoNgay";
            radTheoNgay.Size = new Size(114, 24);
            radTheoNgay.TabIndex = 4;
            radTheoNgay.Text = "Theo Ngày";
            // 
            // radTuKhoang
            // 
            radTuKhoang.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radTuKhoang.Location = new Point(256, 113);
            radTuKhoang.Name = "radTuKhoang";
            radTuKhoang.Size = new Size(104, 24);
            radTuKhoang.TabIndex = 5;
            radTuKhoang.Text = "Từ Khoảng";
            // 
            // dateNgay
            // 
            dateNgay.Format = DateTimePickerFormat.Short;
            dateNgay.Location = new Point(110, 110);
            dateNgay.Name = "dateNgay";
            dateNgay.Size = new Size(121, 26);
            dateNgay.TabIndex = 6;
            // 
            // dateTuKhoang
            // 
            dateTuKhoang.Format = DateTimePickerFormat.Short;
            dateTuKhoang.Location = new Point(366, 110);
            dateTuKhoang.Name = "dateTuKhoang";
            dateTuKhoang.Size = new Size(97, 26);
            dateTuKhoang.TabIndex = 7;
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.Location = new Point(30, 220);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.Size = new Size(500, 150);
            dgvDanhSach.TabIndex = 2;
            // 
            // dgvTong
            // 
            dgvTong.Location = new Point(550, 220);
            dgvTong.Name = "dgvTong";
            dgvTong.Size = new Size(200, 150);
            dgvTong.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(150, 380);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimLai
            // 
            btnTimLai.Location = new Point(300, 380);
            btnTimLai.Name = "btnTimLai";
            btnTimLai.Size = new Size(75, 23);
            btnTimLai.TabIndex = 5;
            btnTimLai.Text = "Tìm lại";
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.Location = new Point(450, 380);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new Size(75, 23);
            btnInBaoCao.TabIndex = 6;
            btnInBaoCao.Text = "In báo cáo";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(600, 380);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(75, 23);
            btnDong.TabIndex = 7;
            btnDong.Text = "Đóng";
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaHD.Location = new Point(0, 40);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(92, 17);
            lblMaHD.TabIndex = 9;
            lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.Location = new Point(0, 73);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(79, 17);
            lblNhanVien.TabIndex = 10;
            lblNhanVien.Text = "Nhân Viên ";
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Location = new Point(312, 39);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(75, 19);
            lblTenHang.TabIndex = 11;
            lblTenHang.Text = "Tên Hàng";
            // 
            // lblNCC
            // 
            lblNCC.AutoSize = true;
            lblNCC.Location = new Point(312, 72);
            lblNCC.Name = "lblNCC";
            lblNCC.Size = new Size(107, 19);
            lblNCC.TabIndex = 12;
            lblNCC.Text = "Nhà Cung Cấp";
            // 
            // radDenkhoang
            // 
            radDenkhoang.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radDenkhoang.Location = new Point(469, 113);
            radDenkhoang.Name = "radDenkhoang";
            radDenkhoang.Size = new Size(114, 24);
            radDenkhoang.TabIndex = 5;
            radDenkhoang.Text = "Đến Khoảng";
            // 
            // dateDenKhoang
            // 
            dateDenKhoang.Format = DateTimePickerFormat.Short;
            dateDenKhoang.Location = new Point(589, 113);
            dateDenKhoang.Name = "dateDenKhoang";
            dateDenKhoang.Size = new Size(101, 26);
            dateDenKhoang.TabIndex = 14;
            // 
            // frmBaoCaoNhapHang
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(grpTimKiem);
            Controls.Add(dgvDanhSach);
            Controls.Add(dgvTong);
            Controls.Add(btnTimKiem);
            Controls.Add(btnTimLai);
            Controls.Add(btnInBaoCao);
            Controls.Add(btnDong);
            Name = "frmBaoCaoNhapHang";
            Text = "Báo cáo nhập hàng";
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaHD;
        private Label lblNCC;
        private Label lblTenHang;
        private Label lblNhanVien;
        private DateTimePicker dateDenKhoang;
        private RadioButton radDenkhoang;
    }
}
