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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLXM
{
    public partial class FrmHoaDonNhapHang : Form
    {

        public FrmHoaDonNhapHang()
        {
            InitializeComponent();
        }
        DataTable chitietnhap;
        private void FrmHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;
            txtsohdn.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtTenhang.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtGiamgia.Text = "0";
            txtTongtien.Text = "0";
            Function.FillCombo("select mancc,tenncc from tblnhacungcap", cboMaNCC, "mancc", "mancc");
            cboMaNCC.SelectedIndex = -1;
            Function.FillCombo("select manv,tennv from tblnhanvien", cboMaNV, "manv", "manv");
            cboMaNV.SelectedIndex = -1;
            Function.FillCombo("select mahang,tenhang from tbldmhang", cboMahang, "mahang", "mahang");
            cboMahang.SelectedIndex = -1;
            Function.FillCombo("select sohdn from tblchitiethdn", cboMaHD, "sohdn", "sohdn");
            cboMaHD.SelectedIndex = -1;
            if (txtsohdn.Text != "")
            {
                Load_ThongtinHD();
                btnXoa.Enabled = true;
                btnIn.Enabled = true;
            }
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT a.Mahang, b.Tenhang, a.Soluong, a.Dongia, a.Giamgia, a.Thanhtien FROM tblchitiethdn AS a, tbldmhang AS b WHERE a.sohdn = N'" + txtsohdn.Text + "' AND a.Mahang=b.Mahang";
            chitietnhap = Function.GetDataToTable(sql);
            dataGridView1.DataSource = chitietnhap;
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá nhập";
            dataGridView1.Columns[4].HeaderText = "Giảm giá (%)";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_ThongtinHD()
        {
            string str, d;
            str = "SELECT ngaynhap FROM tblhoadonnhap WHERE sohdn = N'" + txtsohdn.Text + "'";
            d = Function.GetFieldValues(str);
            string[] parts = d.Split(' ');
            txtNgay.Text = parts[0];
            str = "SELECT manv FROM tblhoadonnhap WHERE sohdn = N'" + txtsohdn.Text + "'";
            cboMaNV.Text = Function.GetFieldValues(str);
            str = "SELECT mancc FROM tblhoadonnhap WHERE sohdn = N'" + txtsohdn.Text + "'";
            cboMaNCC.Text = Function.GetFieldValues(str);
            str = "SELECT Tongtien FROM tblhoadonnhap WHERE sohdn = N'" + txtsohdn.Text + "'";
            txtTongtien.Text = Function.GetFieldValues(str);
        }
        private void ResetValues()
        {
            txtsohdn.Text = "";
            txtNgay.Text = DateTime.Now.ToShortDateString();
            cboMaNV.Text = "";
            cboMaNCC.Text = "";
            txtTongtien.Text = "0";
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            cboMaHD.Text = "";
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtsohdn.Text = Function.CreateKey("HDN");
            Load_DataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT sohdn FROM tblhoadonnhap WHERE sohdn=N'" + txtsohdn.Text + "'";
            if (!Function.CheckKey(sql))
            {
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                if (txtNgay.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgay.Focus();
                    return;
                }
                if (Function.IsDate(txtNgay.Text) == false)
                {
                    MessageBox.Show("Bạn nhập sai ngày nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgay.Text = "";
                    txtNgay.Focus();
                    return;
                }
                if (cboMaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNCC.Focus();
                    return;
                }
                sql = "INSERT INTO tblhoadonnhap(sohdn, manv, ngaynhap, mancc, tongtien) VALUES (N'" + txtsohdn.Text.Trim() + "',N'" + cboMaNV.SelectedValue + "',N'" +
                        Function.ConvertDateTime(txtNgay.Text.Trim()) + "',N'" + cboMaNCC.SelectedValue + "'," + txtTongtien.Text + ")";
                Function.runsql(sql);
            }
            if (cboMahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMahang.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongia.Focus();
                return;
            }
            sql = "SELECT mahang FROM tblchitiethdn WHERE mahang=N'" + cboMahang.SelectedValue + "' AND sohdn = N'" + txtsohdn.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                if ((MessageBox.Show("Mã hàng này đã có, bạn có muốn lưu lại dữ liệu mới này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    //Xóa hàng và cập nhật lại số lượng hàng 
                    DelHang(txtsohdn.Text, dataGridView1.CurrentRow.Cells["Mahang"].Value.ToString());
                    // Cập nhật lại tổng tiền cho hóa đơn bán
                    DelUpdateTongtien(txtsohdn.Text, Convert.ToDouble(dataGridView1.CurrentRow.Cells["Thanhtien"].Value.ToString()));
                }
                else
                {
                    cboMahang.SelectedIndex = -1;
                    cboMahang.Focus();
                    return;
                }
            }
            sql = "INSERT INTO tblchitiethdn VALUES(N'" + txtsohdn.Text.Trim() + "',N'" + cboMahang.SelectedValue + "'," + txtSoluong.Text + "," + txtDongia.Text + "," + txtGiamgia.Text + "," + txtThanhtien.Text + ")";
            Function.runsql(sql);
            Load_DataGridView();
            // Cập nhật lại số lượng xe máy vào bảng tbldmhang
            sl = Convert.ToDouble(Function.GetFieldValues("SELECT soluong FROM tbldmhang WHERE mahang = N'" + cboMahang.SelectedValue + "'"));
            SLcon = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tbldmhang SET soluong=" + SLcon + " WHERE mahang= N'" + cboMahang.SelectedValue + "'";
            Function.runsql(sql);
            // Cập nhật đơn giá nhập và đơn giá bán cho bảng tbldmhang
            double dgnhap = Convert.ToDouble(txtDongia.Text);
            sql = "UPDATE tbldmhang SET dongianhap=" + dgnhap + "WHERE mahang= N'" + cboMahang.SelectedValue + "'";
            Function.runsql(sql);
            sql = "UPDATE tbldmhang SET dongiaban=" + dgnhap * 1.1 + "WHERE mahang= N'" + cboMahang.SelectedValue + "'";
            Function.runsql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn nhập
            tong = Convert.ToDouble(Function.GetFieldValues("SELECT tongtien FROM tblhoadonnhap WHERE sohdn = N'" + txtsohdn.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblhoadonnhap SET tongtien=" + Tongmoi + " WHERE sohdn = N'" + txtsohdn.Text + "'";
            Function.runsql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            ResetValuesHang();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnIn.Enabled = true;
        }
        private void ResetValuesHang()
        {
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }
        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT soluong FROM tblchitiethdn WHERE sohdn = N'" + Mahoadon + "' AND mahang=N'" + Mahang + "'";
            s = Convert.ToDouble(Function.GetFieldValues(sql));
            sql = "DELETE tblchitiethdn WHERE sohdn=N'" + Mahoadon + "' AND mahang = N'" + Mahang + "'";
            Function.RunSqlDel(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT soluong FROM tbldmhang WHERE mahang = N'" + Mahang + "'";
            sl = Convert.ToDouble(Function.GetFieldValues(sql));
            SLcon = sl - s;
            sql = "UPDATE tbldmhang SET soluong =" + SLcon + " WHERE mahang= N'" + Mahang + "'";
            Function.runsql(sql);
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT tongtien FROM tblhoadonnhap WHERE sohdn = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Function.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblhoadonnhap SET tongtien =" + Tongmoi + " WHERE sohdn = N'" + Mahoadon + "'";
            Function.runsql(sql);
            txtTongtien.Text = Tongmoi.ToString();
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "") txtTenNV.Text = "";
            else
            {
                str = "Select tennv from tblnhanvien where manv =N'" + cboMaNV.SelectedValue + "'";
                txtTenNV.Text = Function.GetFieldValues(str);
            }
        }
        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                txtDiachi.Text = "";
                txtSdt.Text = "";
            }
            else
            {
                str = "Select tenncc from tblnhacungcap where mancc = N'" + cboMaNCC.SelectedValue + "'";
                txtTenNCC.Text = Function.GetFieldValues(str);
                str = "Select diachi from tblnhacungcap where mancc = N'" + cboMaNCC.SelectedValue + "'";
                txtDiachi.Text = Function.GetFieldValues(str);
                str = "Select sdt from tblnhacungcap where mancc= N'" + cboMaNCC.SelectedValue + "'";
                txtSdt.Text = Function.GetFieldValues(str);
            }
        }
        private void cboMahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMahang.Text == "")
            {
                txtTenhang.Text = "";
                txtDongia.Text = "";
            }
            else
            {
                str = "SELECT tenhang FROM tbldmhang WHERE mahang =N'" + cboMahang.SelectedValue + "'";
                txtTenhang.Text = Function.GetFieldValues(str);
                str = "SELECT dongianhap FROM tbldmhang WHERE mahang =N'" + cboMahang.SelectedValue + "'";
                txtDongia.Text = Function.GetFieldValues(str);
            }
        }
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }
        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }
        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void HoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng bán xe máy";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 046868686";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.sohdn, a.ngaynhap, a.Tongtien, b.tenncc, b.Diachi, b.sdt, c.tennv FROM tblhoadonnhap AS a, tblnhacungcap AS b, tblNhanvien AS c WHERE a.sohdn = N'" + txtsohdn.Text + "' AND a.mancc = b.mancc AND a.manv =c.manv";
            tblThongtinHD = Function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Số hóa đơn nhập:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = "'" + tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tenhang, a.Soluong, a.dongia, a.Giamgia, a.Thanhtien FROM tblchitiethdn AS a , tbldmHang AS b WHERE a.sohdn = N'" + txtsohdn.Text + "' AND a.Mahang = b.Mahang";
            tblThongtinHang = Function.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaHD.Focus();
                return;
            }
            if (Function.CheckKey("select * from tblhoadonnhap where sohdn like N'" + cboMaHD.Text + "%'") == false)
            {
                MessageBox.Show("Không tồn tại hóa đơn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaHD.Focus();
                return;
            }
            txtsohdn.Text = cboMaHD.Text;
            Load_ThongtinHD();
            Load_DataGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            cboMaHD.SelectedIndex = -1;
        }
        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void cboMaHD_DropDown(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT sohdn FROM tblhoadonnhap", cboMaHD, "sohdn", "sohdn");
            cboMaHD.SelectedIndex = -1;

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip5_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip7_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip8_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip9_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip10_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip11_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip12_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip13_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip14_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip15_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (e.KeyChar == '/'))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chitietnhap.Rows.Count == 0)//
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboMahang.Text = dataGridView1.CurrentRow.Cells["mahang"].Value.ToString();
            txtTenhang.Text = dataGridView1.CurrentRow.Cells["tenhang"].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells["soluong"].Value.ToString();
            txtDongia.Text = dataGridView1.CurrentRow.Cells["dongia"].Value.ToString();
            txtGiamgia.Text = dataGridView1.CurrentRow.Cells["giamgia"].Value.ToString();
            txtThanhtien.Text = dataGridView1.CurrentRow.Cells["thanhtien"].Value.ToString();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT mahang FROM tblchitiethdn WHERE sohdn = N'" + txtsohdn.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Function.conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtsohdn.Text, Mahang[i]);
                //Xóa hóa đơn
                sql = "DELETE tblhoadonnhap WHERE sohdn=N'" + txtsohdn.Text + "'";
                Function.RunSqlDel(sql);
                ResetValues();
                Load_DataGridView();
                btnIn.Enabled = false;
            }
        }
    }
}


