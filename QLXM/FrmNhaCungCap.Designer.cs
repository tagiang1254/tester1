using System.Drawing;
using System.Windows.Forms;

namespace QLXM
{
    partial class FrmNhaCungCap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.lblTkMaNCC = new System.Windows.Forms.Label();
            this.txtTimkiemNCC = new System.Windows.Forms.TextBox();
            this.grpThongtinchung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongtinchung
            // 
            this.grpThongtinchung.Controls.Add(this.dataGridView1);
            this.grpThongtinchung.Controls.Add(this.btnLuu);
            this.grpThongtinchung.Controls.Add(this.btnThem);
            this.grpThongtinchung.Controls.Add(this.btnXoa);
            this.grpThongtinchung.Controls.Add(this.btnSua);
            this.grpThongtinchung.Controls.Add(this.lblDiachi);
            this.grpThongtinchung.Controls.Add(this.txtDiaChi);
            this.grpThongtinchung.Controls.Add(this.mskSDT);
            this.grpThongtinchung.Controls.Add(this.lblSDT);
            this.grpThongtinchung.Controls.Add(this.txtTenNCC);
            this.grpThongtinchung.Controls.Add(this.lblTenNCC);
            this.grpThongtinchung.Controls.Add(this.txtMaNCC);
            this.grpThongtinchung.Controls.Add(this.lblMaNCC);
            this.grpThongtinchung.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongtinchung.Location = new System.Drawing.Point(20, 41);
            this.grpThongtinchung.Name = "grpThongtinchung";
            this.grpThongtinchung.Size = new System.Drawing.Size(658, 307);
            this.grpThongtinchung.TabIndex = 0;
            this.grpThongtinchung.TabStop = false;
            this.grpThongtinchung.Text = "Thông tin chung";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 130);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(215, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 20);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 281);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 20);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(499, 280);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 20);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(349, 280);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 20);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(33, 107);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(49, 15);
            this.lblDiachi.TabIndex = 14;
            this.lblDiachi.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(114, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 21);
            this.txtDiaChi.TabIndex = 13;
            // 
            // mskSDT
            // 
            this.mskSDT.Location = new System.Drawing.Point(114, 77);
            this.mskSDT.Mask = "(84+) 000-0000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(121, 21);
            this.mskSDT.TabIndex = 12;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(33, 80);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(32, 15);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "SDT";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(114, 48);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(121, 21);
            this.txtTenNCC.TabIndex = 3;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(33, 53);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(58, 15);
            this.lblTenNCC.TabIndex = 2;
            this.lblTenNCC.Text = "Tên NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(114, 17);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(86, 21);
            this.txtMaNCC.TabIndex = 1;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.ForeColor = System.Drawing.Color.Black;
            this.lblMaNCC.Location = new System.Drawing.Point(33, 23);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(54, 15);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã NCC";
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(231, 17);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(142, 24);
            this.lblNhaCungCap.TabIndex = 1;
            this.lblNhaCungCap.Text = "Nhà Cung Cấp";
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
            this.btnTimkiem.Size = new System.Drawing.Size(94, 20);
            this.btnTimkiem.TabIndex = 38;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // lblTkMaNCC
            // 
            this.lblTkMaNCC.AutoSize = true;
            this.lblTkMaNCC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTkMaNCC.Location = new System.Drawing.Point(161, 387);
            this.lblTkMaNCC.Name = "lblTkMaNCC";
            this.lblTkMaNCC.Size = new System.Drawing.Size(54, 15);
            this.lblTkMaNCC.TabIndex = 17;
            this.lblTkMaNCC.Text = "Mã NCC";
            // 
            // txtTimkiemNCC
            // 
            this.txtTimkiemNCC.Location = new System.Drawing.Point(216, 382);
            this.txtTimkiemNCC.Name = "txtTimkiemNCC";
            this.txtTimkiemNCC.Size = new System.Drawing.Size(179, 20);
            this.txtTimkiemNCC.TabIndex = 17;
            // 
            // FrmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 411);
            this.Controls.Add(this.txtTimkiemNCC);
            this.Controls.Add(this.lblTkMaNCC);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblNhaCungCap);
            this.Controls.Add(this.grpThongtinchung);
            this.Name = "FrmNhaCungCap";
            this.Text = "Nhà Cung Cấp";
            this.grpThongtinchung.ResumeLayout(false);
            this.grpThongtinchung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpThongtinchung;
        private Label lblNhaCungCap;
        private TextBox txtMaNCC;
        private Label lblMaNCC;
        private TextBox txtTenNCC;
        private Label lblTenNCC;
        private Label lblSDT;
        private MaskedTextBox mskSDT;
        private Label lblDiachi;
        private TextBox txtDiaChi;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnThoat;
        private Button btnTimkiem;
        private Label lblTkMaNCC;
        private TextBox txtTimkiemNCC;
        private DataGridView dataGridView1;
    }
}
