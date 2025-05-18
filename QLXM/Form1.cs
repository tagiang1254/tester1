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

namespace QLXM
{
    public partial class Frmchinh : Form
    {
        public Frmchinh()
        {
            InitializeComponent();
        }

        private void Frmchinh_Load(object sender, EventArgs e)
        {
            try
            {
                Function.connect();
                MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frm = new FrmNhaCungCap();
            frm.Show();
        }

        private void hàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHangHoa frm = new FrmHangHoa();
            frm.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTheLoai frm = new FrmTheLoai();
            frm.Show();
        }

        private void tìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTrang frm = new FrmTinhTrang();
            frm.Show();
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMauSac frm = new FrmMauSac();
            frm.Show();
        }

        private void hoáĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhapHang frm = new FrmHoaDonNhapHang();
            frm.Show();
        }

        private void hoáĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonBanHang frm = new FrmHoaDonBanHang();
            frm.Show();
        }

        private void tìmKiếmHoáĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemHoaDonNhapHang frm = new FrmTimKiemHoaDonNhapHang();
            frm.Show();
        }

        private void tìmKiếmHoáĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemHoaDonBanHang frm = new FrmTimKiemHoaDonBanHang();
            frm.Show();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemKhachHang frm = new FrmTimKiemKhachHang();
            frm.Show();
        }

        private void tìmKiếmHàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemHangHoa frm = new FrmTimKiemHangHoa();
            frm.Show();
        }

        private void báoCáoNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoNhapHang frm = new FrmBaoCaoNhapHang();
            frm.Show();
        }

        private void báoCáoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoBanHang frm = new FrmBaoCaoBanHang();
            frm.Show();
        }

        private void báoCáoKếtQuảHoạtĐộngKinhDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoKetQuaHoatDongKinhDoanh frm = new FrmBaoCaoKetQuaHoatDongKinhDoanh();
            frm.Show();
        }

        private void báoCáoTopSảnPhẩmĐượcTiêuThụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoTopSanPhamDuocTieuThu frm = new FrmBaoCaoTopSanPhamDuocTieuThu();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
