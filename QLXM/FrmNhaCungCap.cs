using System;
using System.Data;
using System.Windows.Forms;

namespace QLXM
{
    public partial class FrmNhaCungCap : Form
    {
        DataTable tblNhaCungCap;

        public FrmNhaCungCap()
        {
            InitializeComponent();
            this.Load += FrmNhaCungCap_Load;
            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            btnTimkiem.Click += btnTimkiem_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            Function.connect();
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql = "SELECT * FROM tblnhacungcap";
            tblNhaCungCap = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tblNhaCungCap;

            // Đổi tên cột hiển thị
            dataGridView1.Columns["mancc"].HeaderText = "Mã NCC";
            dataGridView1.Columns["tenncc"].HeaderText = "Tên Nhà Cung Cấp";
            dataGridView1.Columns["diachi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["sdt"].HeaderText = "Số Điện Thoại";
        }

        private void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            mskSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaNCC.Text = Function.CreateKey("NCC");
            txtTenNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO tblnhacungcap (mancc, tenncc, diachi, sdt) " +
                         "VALUES (N'" + txtMaNCC.Text + "', N'" + txtTenNCC.Text + "', N'" + txtDiaChi.Text + "', '" + mskSDT.Text + "')";
            Function.runsql(sql);
            Load_DataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp để sửa.", "Thông báo");
                return;
            }

            string sql = "UPDATE tblnhacungcap SET tenncc=N'" + txtTenNCC.Text +
                         "', diachi=N'" + txtDiaChi.Text + "', sdt='" + mskSDT.Text +
                         "' WHERE mancc=N'" + txtMaNCC.Text + "'";
            Function.runsql(sql);
            Load_DataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp để xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tblnhacungcap WHERE mancc=N'" + txtMaNCC.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiemNCC.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                Load_DataGridView();
                return;
            }

            string sql = "SELECT * FROM tblnhacungcap WHERE mancc LIKE N'%" + keyword + "%'";
            tblNhaCungCap = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tblNhaCungCap;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaNCC.Text = row.Cells["mancc"].Value?.ToString() ?? "";
                txtTenNCC.Text = row.Cells["tenncc"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["diachi"].Value?.ToString() ?? "";
                mskSDT.Text = row.Cells["sdt"].Value?.ToString() ?? "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
