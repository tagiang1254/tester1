using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXM
{
    public partial class FrmTimKiemHoaDonNhapHang : Form
    {
        public FrmTimKiemHoaDonNhapHang()
        {
            InitializeComponent();
        }
        DataTable hoadonnhap;
        private void FrmTimKiemHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Function.FillCombo("select mancc,tenncc from tblnhacungcap", cboMaNCC, "mancc", "mancc");
            cboMaNCC.SelectedIndex = -1;
            Function.FillCombo("select manv,tennv from tblnhanvien", cboMaNV, "manv", "manv");
            cboMaNV.SelectedIndex = -1;
            Function.FillCombo("select sohdn from tblchitiethdn", cboMaHDN, "sohdn", "sohdn");
            cboMaHDN.SelectedIndex = -1;
            for (int i = 1; i < 13; i++) cboThang.Items.Add(i.ToString());
            cboThang.SelectedIndex = -1;
            for (int i = 2020; i <= DateTime.Now.Year; i++) cboNam.Items.Add(i.ToString());
            cboNam.SelectedIndex = -1;
            btnTimlai.Enabled = false;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is ComboBox)
                    Ctl.Text = "";
            cboMaHDN.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaHDN.Text == "") && (cboThang.Text == "") && (cboNam.Text == "") &&
               (cboMaNV.Text == "") && (cboMaNCC.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT distinct a.* FROM tblhoadonnhap a join tblchitiethdn b on a.sohdn=b.sohdn WHERE 1=1";
            if (cboMaHDN.Text != "")
                sql = sql + " AND a.sohdn Like N'" + cboMaHDN.Text + "'";
            if (cboThang.Text != "")
            {
                if ((Convert.ToInt32(cboThang.Text) < 13) && (Convert.ToInt32(cboThang.Text) > 0))
                    sql = sql + " AND MONTH(ngaynhap) =" + cboThang.Text;
                else
                {
                    MessageBox.Show("Bạn nhập sai tháng, hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboThang.Text = "";
                    cboThang.Focus();
                    return;
                }
            }
            if (cboNam.Text != "")
            {
                if ((Convert.ToInt32(cboNam.Text) >= 2020) && (Convert.ToInt32(cboNam.Text) <= DateTime.Today.Year))
                    sql = sql + " AND YEAR(ngaynhap) =" + cboNam.Text;
                else
                {
                    MessageBox.Show("Bạn nhập sai năm, hãy nhập lại\n Cửa hàng mở từ năm 2020, vui lòng không nhập các năm trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNam.Text = "";
                    cboNam.Focus();
                    return;
                }
            }
            if (cboMaNV.Text != "")
                sql = sql + " AND manv Like N'" + cboMaNV.Text + "'";
            if (cboMaNCC.Text != "")
                sql = sql + " AND mancc Like N'" + cboMaNCC.Text + "'";

            hoadonnhap = Function.GetDataToTable(sql);
            if (hoadonnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                return;
            }
            else
            {
                MessageBox.Show("Có " + hoadonnhap.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.DataSource = hoadonnhap;
                Load_DataGridView();
            }
            foreach (Control Ctl in this.Controls)
                if ((Ctl is TextBox) || (Ctl is ComboBox))
                    Ctl.Enabled = false;
            btnTimlai.Enabled = true;
            btnTimkiem.Enabled = false;
        }
        private void Load_DataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Mã hoá đơn nhập";
            dataGridView1.Columns[1].HeaderText = "Ngày nhập";
            dataGridView1.Columns[2].HeaderText = "Tổng tiền";
            dataGridView1.Columns[3].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[4].HeaderText = "Mã nhà cung cấp";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            foreach (Control Ctl in this.Controls)
                if ((Ctl is TextBox) || (Ctl is ComboBox))
                    Ctl.Enabled = true;
            dataGridView1.DataSource = null;
            btnTimlai.Enabled = false;
            btnTimkiem.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cboNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}

