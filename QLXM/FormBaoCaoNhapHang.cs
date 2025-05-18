using System;
using System.Windows.Forms;

namespace BTL1
{
    public partial class frmBaoCaoNhapHang : Form
    {
        public frmBaoCaoNhapHang()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // TODO: Code truy vấn dữ liệu theo điều kiện lọc
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            // TODO: Xóa các giá trị đã chọn
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            // TODO: Hiện form in báo cáo hoặc xuất file
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
