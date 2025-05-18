namespace BTL1
{
    partial class frmKhachHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpThongtinchung = new GroupBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lbl = new Label();
            txtDiaChi = new TextBox();
            mskSDT = new MaskedTextBox();
            lblSDT = new Label();
            dateNamSinh = new DateTimePicker();
            lblNamSinh = new Label();
            rdbtnNu = new RadioButton();
            rdbtnNam = new RadioButton();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            lblGioitinh = new Label();
            txtHoten = new TextBox();
            lblHoTen = new Label();
            txtMaKH = new TextBox();
            lblMaKH = new Label();
            lblThongtinkhachhang = new Label();
            btnDong = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            btnThoat = new Button();
            btnTimkiem = new Button();
            lblTkMaKh = new Label();
            txtTimkiemKH = new TextBox();
            grpThongtinchung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpThongtinchung
            // 
            grpThongtinchung.Controls.Add(btnDong);
            grpThongtinchung.Controls.Add(txtEmail);
            grpThongtinchung.Controls.Add(lblEmail);
            grpThongtinchung.Controls.Add(btnLuu);
            grpThongtinchung.Controls.Add(dataGridView1);
            grpThongtinchung.Controls.Add(btnXoa);
            grpThongtinchung.Controls.Add(lbl);
            grpThongtinchung.Controls.Add(txtDiaChi);
            grpThongtinchung.Controls.Add(btnSua);
            grpThongtinchung.Controls.Add(mskSDT);
            grpThongtinchung.Controls.Add(lblSDT);
            grpThongtinchung.Controls.Add(btnThem);
            grpThongtinchung.Controls.Add(dateNamSinh);
            grpThongtinchung.Controls.Add(lblNamSinh);
            grpThongtinchung.Controls.Add(rdbtnNu);
            grpThongtinchung.Controls.Add(rdbtnNam);
            grpThongtinchung.Controls.Add(txtCCCD);
            grpThongtinchung.Controls.Add(lblCCCD);
            grpThongtinchung.Controls.Add(lblGioitinh);
            grpThongtinchung.Controls.Add(txtHoten);
            grpThongtinchung.Controls.Add(lblHoTen);
            grpThongtinchung.Controls.Add(txtMaKH);
            grpThongtinchung.Controls.Add(lblMaKH);
            grpThongtinchung.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpThongtinchung.Location = new Point(30, 57);
            grpThongtinchung.Name = "grpThongtinchung";
            grpThongtinchung.Size = new Size(746, 376);
            grpThongtinchung.TabIndex = 0;
            grpThongtinchung.TabStop = false;
            grpThongtinchung.Text = "Thông tin chung";
            grpThongtinchung.Enter += grpThongtinchung_Enter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(319, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 21);
            txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(252, 115);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(252, 87);
            lbl.Name = "lbl";
            lbl.Size = new Size(49, 15);
            lbl.TabIndex = 14;
            lbl.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(319, 84);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 21);
            txtDiaChi.TabIndex = 13;
            // 
            // mskSDT
            // 
            mskSDT.Location = new Point(319, 51);
            mskSDT.Mask = "(84+) 000 000 000";
            mskSDT.Name = "mskSDT";
            mskSDT.Size = new Size(200, 21);
            mskSDT.TabIndex = 12;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(252, 57);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(32, 15);
            lblSDT.TabIndex = 11;
            lblSDT.Text = "SDT";
            lblSDT.Click += label1_Click_1;
            // 
            // dateNamSinh
            // 
            dateNamSinh.Format = DateTimePickerFormat.Short;
            dateNamSinh.Location = new Point(319, 20);
            dateNamSinh.Name = "dateNamSinh";
            dateNamSinh.Size = new Size(79, 21);
            dateNamSinh.TabIndex = 10;
            // 
            // lblNamSinh
            // 
            lblNamSinh.AutoSize = true;
            lblNamSinh.Location = new Point(252, 26);
            lblNamSinh.Name = "lblNamSinh";
            lblNamSinh.Size = new Size(61, 15);
            lblNamSinh.TabIndex = 9;
            lblNamSinh.Text = "Năm Sinh";
            lblNamSinh.Click += label1_Click;
            // 
            // rdbtnNu
            // 
            rdbtnNu.AutoSize = true;
            rdbtnNu.Location = new Point(156, 83);
            rdbtnNu.Name = "rdbtnNu";
            rdbtnNu.Size = new Size(41, 19);
            rdbtnNu.TabIndex = 8;
            rdbtnNu.TabStop = true;
            rdbtnNu.Text = "Nữ";
            rdbtnNu.UseVisualStyleBackColor = true;
            // 
            // rdbtnNam
            // 
            rdbtnNam.AutoSize = true;
            rdbtnNam.Location = new Point(72, 83);
            rdbtnNam.Name = "rdbtnNam";
            rdbtnNam.Size = new Size(50, 19);
            rdbtnNam.TabIndex = 7;
            rdbtnNam.TabStop = true;
            rdbtnNam.Text = "Nam";
            rdbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(57, 112);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(140, 21);
            txtCCCD.TabIndex = 6;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(6, 118);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(43, 15);
            lblCCCD.TabIndex = 5;
            lblCCCD.Text = "CCCD";
            // 
            // lblGioitinh
            // 
            lblGioitinh.AutoSize = true;
            lblGioitinh.Location = new Point(6, 87);
            lblGioitinh.Name = "lblGioitinh";
            lblGioitinh.Size = new Size(60, 15);
            lblGioitinh.TabIndex = 4;
            lblGioitinh.Text = "Giới Tính";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(57, 51);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(140, 21);
            txtHoten.TabIndex = 3;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(6, 57);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(46, 15);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ Tên";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(57, 20);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(100, 21);
            txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(6, 26);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(45, 15);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã KH";
            // 
            // lblThongtinkhachhang
            // 
            lblThongtinkhachhang.AutoSize = true;
            lblThongtinkhachhang.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongtinkhachhang.Location = new Point(270, 20);
            lblThongtinkhachhang.Name = "lblThongtinkhachhang";
            lblThongtinkhachhang.Size = new Size(277, 24);
            lblThongtinkhachhang.TabIndex = 1;
            lblThongtinkhachhang.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(648, 334);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(65, 23);
            btnDong.TabIndex = 35;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(510, 334);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(65, 23);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(351, 334);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(65, 23);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(198, 334);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(65, 23);
            btnSua.TabIndex = 32;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(30, 334);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(65, 23);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(683, 129);
            dataGridView1.TabIndex = 30;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(698, 439);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(65, 23);
            btnThoat.TabIndex = 37;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimkiem.Location = new Point(499, 439);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(88, 23);
            btnTimkiem.TabIndex = 38;
            btnTimkiem.Text = "Tìm Kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // lblTkMaKh
            // 
            lblTkMaKh.AutoSize = true;
            lblTkMaKh.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTkMaKh.Location = new Point(188, 447);
            lblTkMaKh.Name = "lblTkMaKh";
            lblTkMaKh.Size = new Size(45, 15);
            lblTkMaKh.TabIndex = 17;
            lblTkMaKh.Text = "Mã KH";
            // 
            // txtTimkiemKH
            // 
            txtTimkiemKH.Location = new Point(252, 441);
            txtTimkiemKH.Name = "txtTimkiemKH";
            txtTimkiemKH.Size = new Size(208, 23);
            txtTimkiemKH.TabIndex = 17;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 474);
            Controls.Add(txtTimkiemKH);
            Controls.Add(lblTkMaKh);
            Controls.Add(btnTimkiem);
            Controls.Add(btnThoat);
            Controls.Add(lblThongtinkhachhang);
            Controls.Add(grpThongtinchung);
            Name = "frmKhachHang";
            Text = "Thông Tin Khách Hàng";
            grpThongtinchung.ResumeLayout(false);
            grpThongtinchung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongtinchung;
        private Label lblThongtinkhachhang;
        private TextBox txtMaKH;
        private Label lblMaKH;
        private Label lblNamSinh;
        private RadioButton rdbtnNu;
        private RadioButton rdbtnNam;
        private TextBox txtCCCD;
        private Label lblCCCD;
        private Label lblGioitinh;
        private TextBox txtHoten;
        private Label lblHoTen;
        private Label lblSDT;
        private DateTimePicker dateNamSinh;
        private MaskedTextBox mskSDT;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lbl;
        private TextBox txtDiaChi;
        private Button btnDong;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private Button btnThoat;
        private Button btnTimkiem;
        private Label lblTkMaKh;
        private TextBox txtTimkiemKH;
    }
}
