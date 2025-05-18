using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLXM
{
    public partial class FrmBaoCaoNhapHang : Form
    {
        DataTable dtHoaDonNhap;
        DataTable dtChiTietHang;

        public FrmBaoCaoNhapHang()
        {
            InitializeComponent();

            this.Load += FrmBaoCaoNhapHang_Load;

            dateTuKhoang.ValueChanged += (s, e) =>
            {
                dateTuKhoang.CustomFormat = "dd/MM/yyyy";
                FilterChanged(s, e);
            };

            dateDenKhoang.ValueChanged += (s, e) =>
            {
                dateDenKhoang.CustomFormat = "dd/MM/yyyy";
                FilterChanged(s, e);
            };

            cboMaHD.SelectedIndexChanged += FilterChanged;
            cboNhanVien.SelectedIndexChanged += FilterChanged;
            cboTenHang.SelectedIndexChanged += FilterChanged;
            cboNhaCungCap.SelectedIndexChanged += FilterChanged;

            btnTimKiem.Click += BtnTimKiem_Click;
            btnTimLai.Click += BtnTimLai_Click;
            btnDong.Click += BtnDong_Click;

            // Thêm sự kiện cho nút In báo cáo
            btnInBaoCao.Click += btnInBaoCao_Click;

            dgvDanhSach.CellClick += dgvDanhSach_CellClick;
            dgvHang.CellClick += dgvHang_CellClick;
        }

        private void FrmBaoCaoNhapHang_Load(object sender, EventArgs e)
        {
            dateTuKhoang.Format = DateTimePickerFormat.Custom;
            dateTuKhoang.CustomFormat = " ";
            dateDenKhoang.Format = DateTimePickerFormat.Custom;
            dateDenKhoang.CustomFormat = " ";

            dgvDanhSach.AutoGenerateColumns = true;
            dgvHang.AutoGenerateColumns = true;

            LoadCombos();
            LoadDataHoaDonNhap();
            LoadDataChiTietHang();
        }

        private void LoadCombos()
        {
            using (SqlConnection conn = new SqlConnection(Function.ConnectString))
            {
                conn.Open();

                cboMaHD.SelectedIndexChanged -= FilterChanged;
                cboNhanVien.SelectedIndexChanged -= FilterChanged;
                cboTenHang.SelectedIndexChanged -= FilterChanged;
                cboNhaCungCap.SelectedIndexChanged -= FilterChanged;

                Function.FillCombo("SELECT DISTINCT sohdn FROM tblhoadonnhap", cboMaHD, "sohdn", "sohdn");
                cboMaHD.SelectedIndex = -1;

                Function.FillCombo("SELECT manv, tennv FROM tblnhanvien", cboNhanVien, "manv", "tennv");
                cboNhanVien.SelectedIndex = -1;

                Function.FillCombo("SELECT mahang, tenhang FROM tbldmhang", cboTenHang, "mahang", "tenhang");
                cboTenHang.SelectedIndex = -1;

                Function.FillCombo("SELECT mancc, tenncc FROM tblnhacungcap", cboNhaCungCap, "mancc", "tenncc");
                cboNhaCungCap.SelectedIndex = -1;

                cboMaHD.SelectedIndexChanged += FilterChanged;
                cboNhanVien.SelectedIndexChanged += FilterChanged;
                cboTenHang.SelectedIndexChanged += FilterChanged;
                cboNhaCungCap.SelectedIndexChanged += FilterChanged;
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadDataHoaDonNhap();
            LoadDataChiTietHang();
        }

        private void LoadDataHoaDonNhap()
        {
            using (SqlConnection conn = new SqlConnection(Function.ConnectString))
            {
                conn.Open();

                string sql = @"
                    SELECT hdn.sohdn, hdn.ngaynhap, ncc.tenncc, nv.tennv, hdn.tongtien
                    FROM tblhoadonnhap hdn
                    INNER JOIN tblnhacungcap ncc ON hdn.mancc = ncc.mancc
                    INNER JOIN tblnhanvien nv ON hdn.manv = nv.manv
                    WHERE 1=1";

                if (dateTuKhoang.CustomFormat != " ")
                    sql += " AND hdn.ngaynhap >= @TuNgay";
                if (dateDenKhoang.CustomFormat != " ")
                    sql += " AND hdn.ngaynhap <= @DenNgay";
                if (cboMaHD.SelectedIndex != -1)
                    sql += " AND hdn.sohdn = @sohdn";
                if (cboNhanVien.SelectedIndex != -1)
                    sql += " AND hdn.manv = @manv";
                if (cboNhaCungCap.SelectedIndex != -1)
                    sql += " AND hdn.mancc = @mancc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (dateTuKhoang.CustomFormat != " ")
                        cmd.Parameters.AddWithValue("@TuNgay", dateTuKhoang.Value.Date);
                    if (dateDenKhoang.CustomFormat != " ")
                        cmd.Parameters.AddWithValue("@DenNgay", dateDenKhoang.Value.Date);
                    if (cboMaHD.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@sohdn", cboMaHD.SelectedValue.ToString());
                    if (cboNhanVien.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@manv", cboNhanVien.SelectedValue.ToString());
                    if (cboNhaCungCap.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@mancc", cboNhaCungCap.SelectedValue.ToString());

                    dtHoaDonNhap = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtHoaDonNhap);
                    dgvDanhSach.DataSource = dtHoaDonNhap;

                    // Đổi tên cột header dgvDanhSach
                    dgvDanhSach.Columns["sohdn"].HeaderText = "Mã HĐN";
                    dgvDanhSach.Columns["ngaynhap"].HeaderText = "Ngày Nhập";
                    dgvDanhSach.Columns["ngaynhap"].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgvDanhSach.Columns["tenncc"].HeaderText = "Nhà Cung Cấp";
                    dgvDanhSach.Columns["tennv"].HeaderText = "Nhân Viên";
                    dgvDanhSach.Columns["tongtien"].HeaderText = "Tổng Tiền";

                    // Định dạng cột tổng tiền
                    dgvDanhSach.Columns["tongtien"].DefaultCellStyle.Format = "#,##0";
                    dgvDanhSach.Columns["tongtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void LoadDataChiTietHang()
        {
            using (SqlConnection conn = new SqlConnection(Function.ConnectString))
            {
                conn.Open();

                string sql = @"
                    SELECT DISTINCT dm.mahang, dm.tenhang, dm.namsx, dm.dongianhap, dm.dongiaban, dm.soluong
                    FROM tbldmhang dm
                    INNER JOIN tblchitiethdn ct ON dm.mahang = ct.mahang
                    INNER JOIN tblhoadonnhap hdn ON hdn.sohdn = ct.sohdn
                    WHERE 1=1";

                if (dateTuKhoang.CustomFormat != " ")
                    sql += " AND hdn.ngaynhap >= @TuNgay";
                if (dateDenKhoang.CustomFormat != " ")
                    sql += " AND hdn.ngaynhap <= @DenNgay";
                if (cboMaHD.SelectedIndex != -1)
                    sql += " AND hdn.sohdn = @sohdn";
                if (cboTenHang.SelectedIndex != -1)
                    sql += " AND dm.mahang = @mahang";
                if (cboNhaCungCap.SelectedIndex != -1)
                    sql += " AND hdn.mancc = @mancc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (dateTuKhoang.CustomFormat != " ")
                        cmd.Parameters.AddWithValue("@TuNgay", dateTuKhoang.Value.Date);
                    if (dateDenKhoang.CustomFormat != " ")
                        cmd.Parameters.AddWithValue("@DenNgay", dateDenKhoang.Value.Date);
                    if (cboMaHD.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@sohdn", cboMaHD.SelectedValue.ToString());
                    if (cboTenHang.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@mahang", cboTenHang.SelectedValue.ToString());
                    if (cboNhaCungCap.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@mancc", cboNhaCungCap.SelectedValue.ToString());

                    dtChiTietHang = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtChiTietHang);
                    dgvHang.DataSource = dtChiTietHang;

                    // Đổi tên cột header dgvHang
                    dgvHang.Columns["mahang"].HeaderText = "Mã Hàng";
                    dgvHang.Columns["tenhang"].HeaderText = "Tên Hàng";
                    dgvHang.Columns["namsx"].HeaderText = "Năm SX";
                    dgvHang.Columns["dongianhap"].HeaderText = "Đơn Giá Nhập";
                    dgvHang.Columns["dongiaban"].HeaderText = "Đơn Giá Bán";
                    dgvHang.Columns["soluong"].HeaderText = "Số Lượng";

                    // Định dạng cột tiền
                    dgvHang.Columns["dongianhap"].DefaultCellStyle.Format = "#,##0";
                    dgvHang.Columns["dongianhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvHang.Columns["dongiaban"].DefaultCellStyle.Format = "#,##0";
                    dgvHang.Columns["dongiaban"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
            string sohdn = row.Cells[0].Value?.ToString();
            string ngaynhapStr = row.Cells[1].Value?.ToString();

            string manv = Function.GetFieldValues($"SELECT manv FROM tblhoadonnhap WHERE sohdn = '{sohdn}'");
            string mancc = Function.GetFieldValues($"SELECT mancc FROM tblhoadonnhap WHERE sohdn = '{sohdn}'");

            cboMaHD.SelectedValue = sohdn;
            cboNhanVien.SelectedValue = manv;
            cboNhaCungCap.SelectedValue = mancc;

            if (DateTime.TryParse(ngaynhapStr, out DateTime d))
            {
                dateTuKhoang.CustomFormat = "dd/MM/yyyy";
                dateTuKhoang.Value = d;
                dateDenKhoang.CustomFormat = "dd/MM/yyyy";
                dateDenKhoang.Value = d;
            }

            // Lấy tổng tiền từ database cho chính xác và format
            string tongtienStr = Function.GetFieldValues($"SELECT tongtien FROM tblhoadonnhap WHERE sohdn = '{sohdn}'");
            if (decimal.TryParse(tongtienStr, out decimal tongtienDecimal))
                txtDongia.Text = tongtienDecimal.ToString("#,##0");
            else
                txtDongia.Clear();

            LoadChiTietHangTheoHoaDon(sohdn);

            // Chọn dòng đầu tiên chi tiết để cập nhật cboTenHang
            if (dgvHang.Rows.Count > 0)
            {
                dgvHang.CurrentCell = dgvHang.Rows[0].Cells[0];
                string firstMaHang = dgvHang.Rows[0].Cells["mahang"].Value?.ToString();
                if (!string.IsNullOrEmpty(firstMaHang))
                {
                    cboTenHang.SelectedValue = firstMaHang;
                }
            }
            else
            {
                cboTenHang.SelectedIndex = -1;
            }
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvHang.Rows[e.RowIndex];
            string mahang = row.Cells[0].Value?.ToString();

            if (!string.IsNullOrEmpty(mahang))
            {
                cboTenHang.SelectedValue = mahang;
            }
        }

        private void LoadChiTietHangTheoHoaDon(string sohdn)
        {
            using (SqlConnection conn = new SqlConnection(Function.ConnectString))
            {
                conn.Open();

                string sql = @"
                    SELECT dm.mahang, dm.tenhang, dm.namsx, dm.dongianhap, dm.dongiaban, ct.soluong
                    FROM tbldmhang dm
                    INNER JOIN tblchitiethdn ct ON dm.mahang = ct.mahang
                    WHERE ct.sohdn = @sohdn";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sohdn", sohdn);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    dgvHang.DataSource = dt;
                }
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string inputSoHD = ShowInputDialog("Nhập số hóa đơn cần tìm:", "Tìm kiếm hóa đơn");

            if (!string.IsNullOrWhiteSpace(inputSoHD))
            {
                // Tìm kiếm hóa đơn theo số nhập vào
                using (SqlConnection conn = new SqlConnection(Function.ConnectString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT hdn.sohdn, hdn.ngaynhap, ncc.tenncc, nv.tennv, hdn.tongtien
                        FROM tblhoadonnhap hdn
                        INNER JOIN tblnhacungcap ncc ON hdn.mancc = ncc.mancc
                        INNER JOIN tblnhanvien nv ON hdn.manv = nv.manv
                        WHERE hdn.sohdn = @sohdn";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@sohdn", inputSoHD);

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvDanhSach.DataSource = dt;

                            // Tự động chọn hóa đơn vừa tìm để hiển thị chi tiết và các trường
                            dgvDanhSach_CellClick(null, new DataGridViewCellEventArgs(0, 0));
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn với số này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string ShowInputDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 320,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 260 };
            Button confirmation = new Button() { Text = "OK", Left = 200, Width = 80, Top = 80, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text.Trim() : "";
        }

        private void BtnTimLai_Click(object sender, EventArgs e)
        {
            cboMaHD.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboTenHang.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;
            txtDongia.Clear();
            dateTuKhoang.CustomFormat = " ";
            dateDenKhoang.CustomFormat = " ";

            LoadDataHoaDonNhap();
            LoadDataChiTietHang();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xử lý in báo cáo ra Excel
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Microsoft Excel không được cài đặt trên máy tính này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlSheetHoaDon = (Excel.Worksheet)xlWorkBook.Worksheets[1];
                xlSheetHoaDon.Name = "Hóa đơn nhập";

                // Tiêu đề báo cáo
                Excel.Range titleRange = xlSheetHoaDon.Range[xlSheetHoaDon.Cells[1, 1], xlSheetHoaDon.Cells[1, dgvDanhSach.Columns.Count]];
                titleRange.Merge();
                titleRange.Value2 = "BÁO CÁO NHẬP HÀNG";
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                int startRow = 3;

                // Header dgvDanhSach
                for (int col = 0; col < dgvDanhSach.Columns.Count; col++)
                {
                    Excel.Range headerCell = (Excel.Range)xlSheetHoaDon.Cells[startRow, col + 1];
                    headerCell.Value2 = dgvDanhSach.Columns[col].HeaderText;
                    headerCell.Font.Bold = true;
                    headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                // Dữ liệu dgvDanhSach
                for (int row = 0; row < dgvDanhSach.Rows.Count; row++)
                {
                    for (int col = 0; col < dgvDanhSach.Columns.Count; col++)
                    {
                        object val = dgvDanhSach.Rows[row].Cells[col].Value;
                        xlSheetHoaDon.Cells[row + startRow + 1, col + 1] = val ?? "";
                    }
                }

                // Sheet 2: Chi tiết hàng nhập
                Excel.Worksheet xlSheetChiTiet = (Excel.Worksheet)xlWorkBook.Worksheets.Add();
                xlSheetChiTiet.Name = "Chi tiết hàng nhập";

                // Tiêu đề sheet 2
                Excel.Range titleRange2 = xlSheetChiTiet.Range[xlSheetChiTiet.Cells[1, 1], xlSheetChiTiet.Cells[1, dgvHang.Columns.Count]];
                titleRange2.Merge();
                titleRange2.Value2 = "CHI TIẾT HÀNG NHẬP";
                titleRange2.Font.Size = 16;
                titleRange2.Font.Bold = true;
                titleRange2.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Header dgvHang
                for (int col = 0; col < dgvHang.Columns.Count; col++)
                {
                    Excel.Range headerCell = (Excel.Range)xlSheetChiTiet.Cells[startRow, col + 1];
                    headerCell.Value2 = dgvHang.Columns[col].HeaderText;
                    headerCell.Font.Bold = true;
                    headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                // Dữ liệu dgvHang
                for (int row = 0; row < dgvHang.Rows.Count; row++)
                {
                    for (int col = 0; col < dgvHang.Columns.Count; col++)
                    {
                        object val = dgvHang.Rows[row].Cells[col].Value;
                        xlSheetChiTiet.Cells[row + startRow + 1, col + 1] = val ?? "";
                    }
                }

                // Autofit cột cho 2 sheet
                xlSheetHoaDon.Columns.AutoFit();
                xlSheetChiTiet.Columns.AutoFit();

                // Hiển thị Excel
                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
