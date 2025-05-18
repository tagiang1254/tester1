using System;
using System.Windows.Forms;

namespace BTL1
{
    public partial class frmTimKiemHoaDonBanHang : Form
    {
        public frmTimKiemHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void frmTimKiemHoaDonBanHang_Load(object sender, EventArgs e)
        {
            // Code xử lý khi load form, ví dụ: đổ dữ liệu vào ComboBox
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Code tìm kiếm
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            // Code reset các ô tìm kiếm
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
