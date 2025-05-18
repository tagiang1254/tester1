using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLXM
{
    public partial class FrmHoaDonNhapHang : Form
    {
        DataTable tblchitiethdn;
        public FrmHoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void LoadComboBoxMaHang()
        {
            string sql = "SELECT mahang, tenhang FROM tbldmhang";
            DataTable dt = Function.GetDataToTable(sql);
            cboMahang.DataSource = dt;
            cboMahang.DisplayMember = "mahang"; // Hiện mã hàng
            cboMahang.ValueMember = "mahang";   // Giá trị là mã hàng
            txtDongia.ReadOnly = true;
        }

        private void FrmHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            Function.connect();
            KhoiTaoBangChiTiet();
            DinhDangDataGridView();
            LoadComboBoxMaHang();
            Load_DataGridView();
        }

        private void cboMahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMahang.SelectedIndex != -1)
            {
                string mahang = cboMahang.SelectedValue.ToString();
                string sql = "SELECT tenhang, dongianhap FROM tbldmhang WHERE mahang = '" + mahang + "'";
                DataTable dt = Function.GetDataToTable(sql);

                if (dt.Rows.Count > 0)
                {
                    txtTenhang.Text = dt.Rows[0]["tenhang"].ToString();
                    txtDongia.Text = dt.Rows[0]["dongianhap"].ToString();
                }
                else
                {
                    txtTenhang.Clear();
                    txtDongia.Clear();
                }
            }
        }
        private void Load_DataGridView()
        {
            string sql = "SELECT * FROM tblchitiethdn";
            tblchitiethdn = Function.GetDataToTable(sql); // Functions là class dùng chung, mình sẽ viết cho bạn luôn
            dataGridView1.DataSource = tblchitiethdn;
        }
        private void KhoiTaoBangChiTiet()
        {
            tblchitiethdn = new DataTable();
            tblchitiethdn.Columns.Add("mahang");
            tblchitiethdn.Columns.Add("tenhang");
            tblchitiethdn.Columns.Add("soluong", typeof(int));
            tblchitiethdn.Columns.Add("dongianhap", typeof(decimal));
            tblchitiethdn.Columns.Add("giamgia", typeof(float));
            tblchitiethdn.Columns.Add("thanhtien", typeof(decimal));

            dataGridView1.DataSource = tblchitiethdn;
        }
        private void DinhDangDataGridView()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.Columns["soluong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dongianhap"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["thanhtien"].DefaultCellStyle.Format = "N0";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }
        private void ResetThongTinChung()
        {
            txtsohdn.Clear();
            txtNgay.Clear();
            cboMaNV.SelectedIndex = -1;
            txtTenNV.Clear();
            cboMaNCC.SelectedIndex = -1;
            txtTenNCC.Clear();
            txtDiachi.Clear();
            txtSdt.Clear();
            txtTongtien.Clear();
        }
        private void ResetThongTinMatHang()
        {
            cboMahang.SelectedIndex = -1;
            txtTenhang.Clear();
            txtSoluong.Clear();
            txtDongia.Clear();
            txtGiamgia.Clear();
            txtThanhtien.Clear();
            cboMahang.Focus();
        }
        private void TinhThanhTien()
        {
            if (txtSoluong.Text != "" && txtDongia.Text != "")
            {
                try
                {
                    int soLuong = int.Parse(txtSoluong.Text);
                    decimal donGia = decimal.Parse(txtDongia.Text);
                    float giamGia = txtGiamgia.Text != "" ? float.Parse(txtGiamgia.Text) : 0;

                    decimal thanhTien = soLuong * donGia * (decimal)(1 - giamGia / 100);
                    txtThanhtien.Text = thanhTien.ToString("N0");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in tblchitiethdn.Rows)
            {
                tong += Convert.ToDecimal(row["thanhtien"]);
            }
            txtTongtien.Text = tong.ToString("N0");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tạo hóa đơn mới không? Dữ liệu hiện tại sẽ mất!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetThongTinChung();
                KhoiTaoBangChiTiet();
                txtsohdn.Focus();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMahang.Text == "" || txtSoluong.Text == "" || txtDongia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string mahang = cboMahang.Text;
                bool daCo = false;

                foreach (DataRow row in tblchitiethdn.Rows)
                {
                    if (row["mahang"].ToString() == mahang)
                    {
                        row["soluong"] = Convert.ToInt32(row["soluong"]) + int.Parse(txtSoluong.Text);
                        decimal dongianhap = Convert.ToDecimal(row["dongianhap"]);
                        float giamgia = float.Parse(row["giamgia"].ToString());
                        int soluong = Convert.ToInt32(row["soluong"]);
                        row["thanhtien"] = soluong * dongianhap * (decimal)(1 - giamgia / 100);
                        daCo = true;
                        break;
                    }
                }

                if (!daCo)
                {
                    DataRow newRow = tblchitiethdn.NewRow();
                    newRow["mahang"] = cboMahang.Text;
                    newRow["tenhang"] = txtTenhang.Text;
                    newRow["soluong"] = int.Parse(txtSoluong.Text);
                    newRow["dongianhap"] = decimal.Parse(txtDongia.Text);
                    newRow["giamgia"] = txtGiamgia.Text != "" ? float.Parse(txtGiamgia.Text) : 0;
                    newRow["thanhtien"] = decimal.Parse(txtThanhtien.Text.Replace(",", ""));
                    tblchitiethdn.Rows.Add(newRow);
                }

                TinhTongTien();
                ResetThongTinMatHang();
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetThongTinChung();
                KhoiTaoBangChiTiet();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string sohdn = txtsohdn.Text;
                MessageBox.Show("Xuất hóa đơn mã: " + sohdn);
                // Gọi Report Viewer hoặc xuất PDF nếu có
            }
            LuuHoaDon();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Function.close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM tblchitiethdn WHERE sohdn = '{txtsohdn}'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Function.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        private void LuuHoaDon()
        {
            if (txtsohdn.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlCheck = "SELECT sohdn FROM tblhoadonnhap WHERE sohdn = '" + txtsohdn.Text.Trim() + "'";
            if (Function.CheckKey(sqlCheck))
            {
                MessageBox.Show("Số hóa đơn này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm vào bảng tblhdn
            string sqlInsertHDN = "INSERT INTO tblhoadonnhap(sohdn, ngaynhap, tongtien, manv, mancc ) " +
                                  "VALUES('" + txtsohdn.Text.Trim() + "', '" + txtNgay.Text.Trim() + "', '" + txtTongtien.Text + "', '" + cboMaNV.Text + "', " + cboMaNCC.Text.Replace(",", "") + ")";
            Function.runsql(sqlInsertHDN);

            // Thêm vào bảng tblchitiethdn
            foreach (DataRow row in tblchitiethdn.Rows)
            {
                string sqlInsertChiTiet = "INSERT INTO tblchitiethdn(sohdn, mahang, soluong, giamgia, thanhtien) " +
                                          "VALUES('" + txtsohdn.Text.Trim() + "', '" + row["mahang"] + "', " + row["soluong"] + ", "  + ", " + row["giamgia"] + ", " + row["thanhtien"] + ")";
                Function.runsql(sqlInsertChiTiet);
            }

            MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
