using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace QLXM
{
    public partial class FrmBaoCaoTopSanPhamDuocTieuThu : Form
    {
        public FrmBaoCaoTopSanPhamDuocTieuThu()
        {
            InitializeComponent();
        }
        System.Data.DataTable baocao;
        string dk = "";
        string sql = "";
        private void FrmBaoCaoTopSanPhamDuocTieuThu_Load(object sender, EventArgs e)
        {
            Function.connect();
            btnIn.Enabled = false;
            txtNam.Enabled = false;
            txtThang.Enabled = false;
            chart1.Visible = false;
            btnTimlai.Enabled = false;
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            // Kiểm tra tiêu chí báo cáo
            if (!rdoSP.Checked && !rdoHSX.Checked && !rdoMau.Checked && !rdoTheloai.Checked)
            {
                MessageBox.Show("Bạn chưa chọn tiêu chí báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra thời gian
            if (!rdoThoigian.Checked)
            {
                MessageBox.Show("Bạn chưa chọn thời gian của báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdoThoigian.Checked) // Theo tháng cụ thể
            {
                if (string.IsNullOrEmpty(txtThang.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tháng báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtThang.Focus();
                    return;
                }

                if (!int.TryParse(txtThang.Text, out int thang) || thang < 1 || thang > 12)
                {
                    MessageBox.Show("Bạn nhập sai tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtThang.Text = "";
                    txtThang.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtNam.Text))
                {
                    MessageBox.Show("Bạn chưa nhập năm báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNam.Focus();
                    return;
                }

                if (!int.TryParse(txtNam.Text, out int nam) || nam < 2022 || nam > DateTime.Today.Year)
                {
                    MessageBox.Show("Bạn nhập sai năm\n Cửa hàng mở từ năm 2022, vui lòng không nhập các năm trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNam.Text = "";
                    txtNam.Focus();
                    return;
                }

                dk = $"WHERE MONTH(ngaynmua) = {thang} AND YEAR(ngaynmua) = {nam}";
            }

            chart1.Visible = true;

            if (rdoSP.Checked)
            {
                sql = "SELECT tenhang, SUM(C.soluong) AS tsl FROM (tbldondathang D JOIN tblchitietddh C ON D.soddh = C.soddh) JOIN tbldmhang H ON C.mahang = H.mahang "
                      + dk + " GROUP BY tenhang ORDER BY tsl DESC";
                Load_Chart(sql, "Sản phẩm(%)", "tenhang", "tsl");
                Load_DataGridView(sql, "Sản phẩm", "Số lượng");
            }
            else if (rdoHSX.Checked)
            {
                sql = "SELECT tenhangsx, SUM(C.soluong) AS tsl FROM ((tbldondathang D JOIN tblchitietddh C ON D.soddh = C.soddh) JOIN tbldmhang H ON C.mahang = H.mahang) JOIN tblhangsx S ON H.mahangsx = S.mahangsx "
                      + dk + " GROUP BY tenhangsx ORDER BY tsl DESC";
                Load_Chart(sql, "Hãng sản xuất(%)", "tenhangsx", "tsl");
                Load_DataGridView(sql, "Hãng", "Số lượng");
            }
            else if (rdoTheloai.Checked)
            {
                sql = "SELECT tenloai, SUM(C.soluong) AS tsl FROM ((tbldondathang D JOIN tblchitietddh C ON D.soddh = C.soddh) JOIN tbldmhang H ON C.mahang = H.mahang) JOIN tbltheloai S ON H.maloai = S.maloai "
                      + dk + " GROUP BY tenloai ORDER BY tsl DESC";
                Load_Chart(sql, "Thể loại(%)", "tenloai", "tsl");
                Load_DataGridView(sql, "Thể loại", "Số lượng");
            }
            else // rdoMau.Checked
            {
                sql = "SELECT tenmau, SUM(C.soluong) AS tsl FROM ((tbldondathang D JOIN tblchitietddh C ON D.soddh = C.soddh) JOIN tbldmhang H ON C.mahang = H.mahang) JOIN tblmausac S ON H.mamau = S.mamau "
                      + dk + " GROUP BY tenmau ORDER BY tsl DESC";
                Load_Chart(sql, "Màu sắc(%)", "tenmau", "tsl");
                Load_DataGridView(sql, "Màu sắc", "Số lượng");
            }

            btnIn.Enabled = true;
            btnTimlai.Enabled = true;
            btnHienthi.Enabled = false;

            // Vô hiệu hóa các control để tránh sửa đổi sau khi đã hiển thị báo cáo
            foreach (Control Ctl in this.Controls)
            {
                if ((Ctl is System.Windows.Forms.TextBox) || (Ctl is MaskedTextBox))
                {
                    Ctl.Enabled = false;
                }
            }
            rdoThoigian.Enabled = false;
            rdoHSX.Enabled = false;
            rdoMau.Enabled = false;
            rdoTheloai.Enabled = false;
            rdoSP.Enabled = false;
        }
        private void rdoThoigian_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThoigian.Checked == true)
            {
                txtThang.Enabled = true;
                txtNam.Enabled = true;
            }
            else
            {
                txtThang.Text = "";
                txtNam.Text = "";
                txtThang.Enabled = false;
                txtNam.Enabled = false;
            }
        }
        private void Load_DataGridView(string sql, string tc, string sl)
        {
            baocao = Function.GetDataToTable(sql);
            if (baocao.Rows.Count == 0)
            {
                return;
            }
            dataGridView1.DataSource = baocao;
            dataGridView1.Columns[0].HeaderText = tc;
            dataGridView1.Columns[1].HeaderText = sl;
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 80;
        }
        private void Load_Chart(string sql, string ten, string tc, string sl)
        {
            baocao = Function.GetDataToTable(sql);
            if (baocao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double tong = Convert.ToDouble(Function.GetFieldValues("select sum(C.soluong) as tsl from (tbldondathang D join tblchitietddh C on D.soddh=C.soddh)join tbldmhang H on C.mahang=H.mahang " + dk));
            for (int i = 0; i < baocao.Rows.Count; i++)
            {
                baocao.Rows[i][1] = Math.Round(Convert.ToDouble(baocao.Rows[i][1]) * 100 / tong);
            }
            // Gán nguồn dữ liệu
            chart1.DataSource = baocao;

            // Nếu Series "baocao" đã tồn tại thì xoá nó trước
            int index = chart1.Series.IndexOf("baocao");
            if (index != -1)
            {
                chart1.Series.RemoveAt(index);
            }

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("baocao");
            series.XValueMember = tc;
            series.YValueMembers = sl;
            series.IsValueShownAsLabel = true;
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart1.Series.Add(series);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add();
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["B1:B1"].ColumnWidth = 16;
            exRange.Range["A2:F2"].Font.Size = 16;
            exRange.Range["A2:F2"].Font.Name = "Times new roman";
            exRange.Range["A2:F2"].Font.Bold = true;
            exRange.Range["A2:F2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["A2:F2"].MergeCells = true;
            exRange.Range["A2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:F2"].Value = "BÁO CÁO TOP SẢN PHẨM";

            exRange.Range["B5:C6"].Font.Size = 12;
            exRange.Range["B5:C6"].Font.Name = "Times new roman";
            if (rdoThoigian.Checked == true)
            {
                exRange.Range["B5:B5"].Value = "Tháng báo cáo:";
                exRange.Range["C5:C5"].Value = txtThang.Text;
                exRange.Range["B6:B6"].Value = "Năm báo cáo:";
                exRange.Range["C6:C6"].Value = txtNam.Text;
            }

            exRange.Range["B8:C8"].Font.Bold = true;
            exRange.Range["B8:C8"].Font.Size = 14;
            exRange.Range["B8:C8"].MergeCells = true;
            exRange.Range["B8:C8"].Font.Name = "Times new roman";
            string x;
            if (rdoSP.Checked == true)
            {
                exRange.Range["B8:C8"].Value = "Theo sản phẩm";
                x = "Sản phẩm";
            }
            else if (rdoHSX.Checked == true)
            {
                exRange.Range["B8:C8"].Value = "Theo hãng sản xuất";
                x = "Hãng sản xuất";
            }
            else if (rdoMau.Checked == true)
            {
                exRange.Range["B8:C8"].Value = "Theo màu sắc";
                x = "Màu sắc";
            }
            else
            {
                exRange.Range["B8:C8"].Value = "Theo thể loại";
                x = "Thể loại";
            }


            exRange.Range["C10:E10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D10:E10"].ColumnWidth = 12;
            exRange.Range["C10:C10"].ColumnWidth = 6;
            exRange.Range["C10:C10"].Value = "STT";
            if (rdoSP.Checked == true) exRange.Range["D10:D10"].Value = "Sản phẩm";
            else if (rdoHSX.Checked == true) exRange.Range["D10:D10"].Value = "Hãng sản xuất";
            else if (rdoMau.Checked == true) exRange.Range["D10:D10"].Value = "Màu sắc";
            else exRange.Range["D10:D10"].Value = "Thể loại";
            exRange.Range["E10:E10"].Value = "Số lượng";

            for (hang = 0; hang <= baocao.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[3][hang + 11] = hang + 1;
                for (cot = 0; cot <= baocao.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 4][hang + 11] = baocao.Rows[hang][cot].ToString();
            }
            COMExcel.ChartObjects exCharrt;
            COMExcel.ChartObject mychart;
            COMExcel.Chart chartPage;
            exCharrt = (COMExcel.ChartObjects)exSheet.ChartObjects(Type.Missing);
            mychart = exCharrt.Add(60, (hang + 10) * 16, 300, 200);
            chartPage = mychart.Chart;
            chartPage.SetSourceData(exRange.Range["D11:E" + (hang + 10).ToString()]);
            chartPage.ChartType = COMExcel.XlChartType.xlPie;
            chartPage.HasTitle = true;
            chartPage.ChartTitle.Text = x + " (%)";

            COMExcel.Series series = chartPage.SeriesCollection(1);
            series.HasDataLabels = true;
            COMExcel.DataLabels dataLabels = series.DataLabels();
            dataLabels.ShowPercentage = true;
            dataLabels.ShowValue = false;  // Không hiển thị giá trị số gốc
            dataLabels.NumberFormat = "0%";
            exApp.Visible = true;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            rdoThoigian.Enabled = true;
            rdoHSX.Enabled = true;
            rdoMau.Enabled = true;
            rdoTheloai.Enabled = true;
            rdoSP.Enabled = true;
            rdoThoigian.Checked = false;
            rdoHSX.Checked = false;
            rdoMau.Checked = false;
            rdoSP.Checked = false;
            rdoTheloai.Checked = false;
            btnHienthi.Enabled = true;
            btnIn.Enabled = false;
            btnTimlai.Enabled = false;
            dataGridView1.DataSource = null;
            chart1.Visible = false;
        }
    }
}


