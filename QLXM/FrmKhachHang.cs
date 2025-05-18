using System;
using System.Data;
using System.Windows.Forms;

namespace QLXM
{
    public partial class FrmKhachHang : Form
    {
        DataTable tblKhachHang;

        public FrmKhachHang()
        {
            InitializeComponent();
            this.Load += FrmKhachHang_Load;
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
            btnLuu.Click += btnLuu_Click;
            btnThoat.Click += btnDong_Click;
            btnTimkiem.Click += btnTimkiem_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            Function.connect();
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql = "SELECT * FROM tblkhachhang";
            tblKhachHang = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tblKhachHang;

            // Đổi tên hiển thị các cột
            dataGridView1.Columns["makhach"].HeaderText = "Mã KH";
            dataGridView1.Columns["tenkhach"].HeaderText = "Tên khách hàng";
            dataGridView1.Columns["diachi"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["sdt"].HeaderText = "Số điện thoại";

            // Tùy chọn: Căn độ rộng
            dataGridView1.Columns["makhach"].Width = 100;
            dataGridView1.Columns["tenkhach"].Width = 200;
            dataGridView1.Columns["diachi"].Width = 250;
            dataGridView1.Columns["sdt"].Width = 120;
        }

        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtHoten.Text = "";
            txtDiaChi.Text = "";
            mskSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaKH.Text = Function.CreateKey("KH");
            txtHoten.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoten.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO tblkhachhang (makhach, tenkhach, sdt, diachi) " +
                         "VALUES (N'" + txtMaKH.Text + "', N'" + txtHoten.Text + "', '" + mskSDT.Text + "', N'" + txtDiaChi.Text + "')";
            Function.runsql(sql);
            Load_DataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tblkhachhang WHERE makhach = N'" + txtMaKH.Text + "'";
                Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để sửa!", "Thông báo");
                return;
            }

            string sql = "UPDATE tblkhachhang SET tenkhach=N'" + txtHoten.Text +
                         "', sdt='" + mskSDT.Text +
                         "', diachi=N'" + txtDiaChi.Text +
                         "' WHERE makhach=N'" + txtMaKH.Text + "'";
            Function.runsql(sql);
            Load_DataGridView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiemKH.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                Load_DataGridView();
                return;
            }

            string sql = "SELECT * FROM tblkhachhang WHERE makhach LIKE N'%" + keyword + "%'";
            tblKhachHang = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tblKhachHang;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtMaKH.Text = row.Cells["makhach"].Value?.ToString() ?? "";
                    txtHoten.Text = row.Cells["tenkhach"].Value?.ToString() ?? "";
                    txtDiaChi.Text = row.Cells["diachi"].Value?.ToString() ?? "";
                    mskSDT.Text = row.Cells["sdt"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu từ dòng: " + ex.Message);
                }
            }
        }
    }
}
