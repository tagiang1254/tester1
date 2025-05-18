using System;
using System.Data;
using System.Windows.Forms;

namespace QLXM
{
    public partial class FrmTimKiemHoaDonBanHang : Form
    {
        public FrmTimKiemHoaDonBanHang()
        {
            InitializeComponent();
            this.Load += FrmTimKiemHoaDonBanHang_Load;
            btnTimKiem.Click += btnTimKiem_Click;
            btnTimLai.Click += btnTimLai_Click;
            btnDong.Click += btnDong_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Định dạng DateTimePicker để không hiển thị mặc định
            dateNgayBan.Format = DateTimePickerFormat.Custom;
            dateNgayBan.CustomFormat = " ";
            dateNgayBan.ShowUpDown = true;
            dateNgayBan.ValueChanged += (s, e) =>
            {
                dateNgayBan.CustomFormat = "dd/MM/yyyy";
            };
        }

        private void FrmTimKiemHoaDonBanHang_Load(object sender, EventArgs e)
        {
            Load_DonDatHang();
        }

        private void Load_DonDatHang()
        {
            string sql = "SELECT d.soddh, nv.tennv, kh.tenkhach,d.ngaynmua, d.datcoc, d.thue, d.tongtien " +
                         "FROM tbldondathang d " +
                         "INNER JOIN tblnhanvien nv ON d.manv = nv.manv " +
                         "INNER JOIN tblkhachhang kh ON d.makhach = kh.makhach";

            DataTable dt = Function.GetDataToTable(sql);
            dataGridView1.DataSource = dt;
            Format_DataGridView();
        }

        private void Format_DataGridView()
        {
            dataGridView1.Columns["soddh"].HeaderText = "Số HĐ";
            dataGridView1.Columns["ngaynmua"].HeaderText = "Ngày Bán";
            dataGridView1.Columns["datcoc"].HeaderText = "Đặt Cọc";
            dataGridView1.Columns["thue"].HeaderText = "Thuế (%)";
            dataGridView1.Columns["tongtien"].HeaderText = "Tổng Tiền";
            dataGridView1.Columns["tennv"].HeaderText = "Nhân Viên";
            dataGridView1.Columns["tenkhach"].HeaderText = "Khách Hàng";

            // Format có dấu chấm
            dataGridView1.Columns["tongtien"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["datcoc"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["thue"].DefaultCellStyle.Format = "N0";

            // Căn phải các số
            dataGridView1.Columns["tongtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["datcoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["thue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sohd = txtSoHoaDon.Text.Trim();

            string sql = "SELECT d.soddh, d.ngaynmua, d.datcoc, d.thue, d.tongtien, nv.tennv, kh.tenkhach " +
                         "FROM tbldondathang d " +
                         "INNER JOIN tblnhanvien nv ON d.manv = nv.manv " +
                         "INNER JOIN tblkhachhang kh ON d.makhach = kh.makhach " +
                         "WHERE 1=1";

            if (!string.IsNullOrEmpty(sohd))
                sql += $" AND d.soddh LIKE N'%{sohd}%'";

            DataTable dt = Function.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                Format_DataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_DonDatHang(); // Trả về toàn bộ dữ liệu
            }
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            txtSoHoaDon.Clear();
            txtDatCoc.Clear();
            txtThue.Clear();
            txtTongTien.Clear();
            cboMaKH.Text = "";
            cboMaNV.Text = "";
            dateNgayBan.CustomFormat = " ";
            Load_DonDatHang();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtSoHoaDon.Text = row.Cells["soddh"].Value?.ToString();
                cboMaNV.Text = row.Cells["tennv"].Value?.ToString();
                cboMaKH.Text = row.Cells["tenkhach"].Value?.ToString();
                txtDatCoc.Text = string.Format("{0:N0}", row.Cells["datcoc"].Value);
                txtThue.Text = string.Format("{0:N0}", row.Cells["thue"].Value);
                txtTongTien.Text = string.Format("{0:N0}", row.Cells["tongtien"].Value);

                if (DateTime.TryParse(row.Cells["ngaynmua"].Value?.ToString(), out DateTime ngayban))
                {
                    dateNgayBan.Value = ngayban;
                    dateNgayBan.CustomFormat = "dd/MM/yyyy";
                }
                else
                {
                    dateNgayBan.CustomFormat = " ";
                }
            }
        }

        private void lblThue_Click(object sender, EventArgs e)
        {
            // Không cần xử lý gì nếu bạn không dùng sự kiện này
        }
    }
}
