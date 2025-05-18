namespace BTL1
{
    partial class frmTimKiemHoaDonBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtSoHoaDon = new TextBox();
            txtDatCoc = new TextBox();
            txtThue = new TextBox();
            txtTongTien = new TextBox();
            cboMaNV = new ComboBox();
            cboMaKH = new ComboBox();
            dtgKetQua = new DataGridView();
            btnTimKiem = new Button();
            btnTimLai = new Button();
            btnDong = new Button();
            lblSoHoaDon = new Label();
            lblMaNV = new Label();
            lblMaKH = new Label();
            lblThang = new Label();
            lblDatCoc = new Label();
            lblThue = new Label();
            lblTongTien = new Label();
            lblTieuDe = new Label();
            dateNgayBan = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgKetQua).BeginInit();
            SuspendLayout();
            // 
            // txtSoHoaDon
            // 
            txtSoHoaDon.Location = new Point(140, 70);
            txtSoHoaDon.Name = "txtSoHoaDon";
            txtSoHoaDon.Size = new Size(100, 21);
            txtSoHoaDon.TabIndex = 0;
            // 
            // txtDatCoc
            // 
            txtDatCoc.Location = new Point(490, 70);
            txtDatCoc.Name = "txtDatCoc";
            txtDatCoc.Size = new Size(100, 21);
            txtDatCoc.TabIndex = 1;
            // 
            // txtThue
            // 
            txtThue.Location = new Point(490, 110);
            txtThue.Name = "txtThue";
            txtThue.Size = new Size(100, 21);
            txtThue.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(490, 150);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(100, 21);
            txtTongTien.TabIndex = 3;
            // 
            // cboMaNV
            // 
            cboMaNV.Location = new Point(140, 110);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(121, 23);
            cboMaNV.TabIndex = 4;
            // 
            // cboMaKH
            // 
            cboMaKH.Location = new Point(140, 150);
            cboMaKH.Name = "cboMaKH";
            cboMaKH.Size = new Size(121, 23);
            cboMaKH.TabIndex = 5;
            // 
            // dtgKetQua
            // 
            dtgKetQua.Location = new Point(40, 230);
            dtgKetQua.Name = "dtgKetQua";
            dtgKetQua.Size = new Size(600, 150);
            dtgKetQua.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(150, 400);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimLai
            // 
            btnTimLai.Location = new Point(270, 400);
            btnTimLai.Name = "btnTimLai";
            btnTimLai.Size = new Size(75, 23);
            btnTimLai.TabIndex = 10;
            btnTimLai.Text = "Tìm lại";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(390, 400);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(75, 23);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            // 
            // lblSoHoaDon
            // 
            lblSoHoaDon.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoHoaDon.Location = new Point(40, 70);
            lblSoHoaDon.Name = "lblSoHoaDon";
            lblSoHoaDon.Size = new Size(100, 23);
            lblSoHoaDon.TabIndex = 12;
            lblSoHoaDon.Text = "Số hóa đơn";
            // 
            // lblMaNV
            // 
            lblMaNV.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaNV.Location = new Point(40, 110);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(100, 23);
            lblMaNV.TabIndex = 13;
            lblMaNV.Text = "Mã nhân viên";
            // 
            // lblMaKH
            // 
            lblMaKH.Location = new Point(40, 150);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(100, 23);
            lblMaKH.TabIndex = 14;
            lblMaKH.Text = "Mã khách";
            // 
            // lblThang
            // 
            lblThang.Location = new Point(40, 190);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(100, 23);
            lblThang.TabIndex = 15;
            lblThang.Text = "Ngày Bán";
            // 
            // lblDatCoc
            // 
            lblDatCoc.Location = new Point(400, 70);
            lblDatCoc.Name = "lblDatCoc";
            lblDatCoc.Size = new Size(100, 23);
            lblDatCoc.TabIndex = 17;
            lblDatCoc.Text = "Đặt cọc";
            // 
            // lblThue
            // 
            lblThue.Location = new Point(400, 110);
            lblThue.Name = "lblThue";
            lblThue.Size = new Size(100, 23);
            lblThue.TabIndex = 18;
            lblThue.Text = "Thuế";
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(400, 150);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(100, 23);
            lblTongTien.TabIndex = 19;
            lblTongTien.Text = "Tổng tiền";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTieuDe.Location = new Point(180, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(315, 24);
            lblTieuDe.TabIndex = 20;
            lblTieuDe.Text = "TÌM KIẾM HÓA ĐƠN BÁN HÀNG";
            // 
            // dateNgayBan
            // 
            dateNgayBan.Format = DateTimePickerFormat.Short;
            dateNgayBan.Location = new Point(140, 192);
            dateNgayBan.Name = "dateNgayBan";
            dateNgayBan.Size = new Size(121, 21);
            dateNgayBan.TabIndex = 21;
            // 
            // frmTimKiemHoaDonBanHang
            // 
            ClientSize = new Size(700, 470);
            Controls.Add(dateNgayBan);
            Controls.Add(txtSoHoaDon);
            Controls.Add(txtDatCoc);
            Controls.Add(txtThue);
            Controls.Add(txtTongTien);
            Controls.Add(cboMaNV);
            Controls.Add(cboMaKH);
            Controls.Add(dtgKetQua);
            Controls.Add(btnTimKiem);
            Controls.Add(btnTimLai);
            Controls.Add(btnDong);
            Controls.Add(lblSoHoaDon);
            Controls.Add(lblMaNV);
            Controls.Add(lblMaKH);
            Controls.Add(lblThang);
            Controls.Add(lblDatCoc);
            Controls.Add(lblThue);
            Controls.Add(lblTongTien);
            Controls.Add(lblTieuDe);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmTimKiemHoaDonBanHang";
            Text = "Tìm kiếm Hóa đơn Bán hàng";
            ((System.ComponentModel.ISupportInitialize)dtgKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.TextBox txtDatCoc;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.DataGridView dtgKetQua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnDong;

        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblDatCoc;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTieuDe;
        private DateTimePicker dateNgayBan;
    }
}
