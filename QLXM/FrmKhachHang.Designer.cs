using System.Drawing;
using System.Windows.Forms;

namespace QLXM
{
    partial class FrmKhachHang
    {
       
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
            this.grpThongtinchung = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblThongtinkhachhang = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.lblTkMaKh = new System.Windows.Forms.Label();
            this.txtTimkiemKH = new System.Windows.Forms.TextBox();
            this.grpThongtinchung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongtinchung
            // 
            this.grpThongtinchung.Controls.Add(this.btnLuu);
            this.grpThongtinchung.Controls.Add(this.dataGridView1);
            this.grpThongtinchung.Controls.Add(this.btnXoa);
            this.grpThongtinchung.Controls.Add(this.lbl);
            this.grpThongtinchung.Controls.Add(this.txtDiaChi);
            this.grpThongtinchung.Controls.Add(this.btnSua);
            this.grpThongtinchung.Controls.Add(this.mskSDT);
            this.grpThongtinchung.Controls.Add(this.lblSDT);
            this.grpThongtinchung.Controls.Add(this.btnThem);
            this.grpThongtinchung.Controls.Add(this.txtHoten);
            this.grpThongtinchung.Controls.Add(this.lblHoTen);
            this.grpThongtinchung.Controls.Add(this.txtMaKH);
            this.grpThongtinchung.Controls.Add(this.lblMaKH);
            this.grpThongtinchung.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongtinchung.Location = new System.Drawing.Point(26, 49);
            this.grpThongtinchung.Name = "grpThongtinchung";
            this.grpThongtinchung.Size = new System.Drawing.Size(639, 326);
            this.grpThongtinchung.TabIndex = 0;
            this.grpThongtinchung.TabStop = false;
            this.grpThongtinchung.Text = "Thông tin chung";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(514, 289);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 20);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(585, 112);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(365, 289);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 20);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(23, 119);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(49, 15);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(84, 113);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 21);
            this.txtDiaChi.TabIndex = 13;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(218, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 20);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // mskSDT
            // 
            this.mskSDT.Location = new System.Drawing.Point(84, 79);
            this.mskSDT.Mask = "(999) 000-0000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(121, 21);
            this.mskSDT.TabIndex = 12;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(23, 85);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(32, 15);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "SDT";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(65, 289);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 20);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(84, 52);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(121, 21);
            this.txtHoten.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(22, 58);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 15);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(84, 20);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(79, 21);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(23, 26);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(45, 15);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH";
            // 
            // lblThongtinkhachhang
            // 
            this.lblThongtinkhachhang.AutoSize = true;
            this.lblThongtinkhachhang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinkhachhang.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblThongtinkhachhang.Location = new System.Drawing.Point(231, 17);
            this.lblThongtinkhachhang.Name = "lblThongtinkhachhang";
            this.lblThongtinkhachhang.Size = new System.Drawing.Size(277, 24);
            this.lblThongtinkhachhang.TabIndex = 1;
            this.lblThongtinkhachhang.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(598, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(56, 20);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(428, 380);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 20);
            this.btnTimkiem.TabIndex = 38;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // lblTkMaKh
            // 
            this.lblTkMaKh.AutoSize = true;
            this.lblTkMaKh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTkMaKh.Location = new System.Drawing.Point(161, 387);
            this.lblTkMaKh.Name = "lblTkMaKh";
            this.lblTkMaKh.Size = new System.Drawing.Size(45, 15);
            this.lblTkMaKh.TabIndex = 17;
            this.lblTkMaKh.Text = "Mã KH";
            // 
            // txtTimkiemKH
            // 
            this.txtTimkiemKH.Location = new System.Drawing.Point(216, 382);
            this.txtTimkiemKH.Name = "txtTimkiemKH";
            this.txtTimkiemKH.Size = new System.Drawing.Size(179, 20);
            this.txtTimkiemKH.TabIndex = 17;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 411);
            this.Controls.Add(this.txtTimkiemKH);
            this.Controls.Add(this.lblTkMaKh);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblThongtinkhachhang);
            this.Controls.Add(this.grpThongtinchung);
            this.Name = "FrmKhachHang";
            this.Text = "Thông Tin Khách Hàng";
            this.grpThongtinchung.ResumeLayout(false);
            this.grpThongtinchung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpThongtinchung;
        private Label lblThongtinkhachhang;
        private TextBox txtMaKH;
        private Label lblMaKH;
        private TextBox txtHoten;
        private Label lblHoTen;
        private Label lblSDT;
        private MaskedTextBox mskSDT;
        private Label lbl;
        private TextBox txtDiaChi;
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