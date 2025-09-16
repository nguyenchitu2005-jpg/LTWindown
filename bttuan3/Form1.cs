using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bttuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDanhSachSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            String tenKH=txtKhachHang.Text;
            String SDT=txtDienThoai .Text;

            // Lấy sản phẩm đã chọn
            StringBuilder spDaMua = new StringBuilder();
            foreach (var item in lstDanhSachSanPham.SelectedItems)
            {
                spDaMua.AppendLine("- " + item.ToString());
            }

            // Lấy phương thức thanh toán
            string thanhToan = cboThanhToan.SelectedItem?.ToString();

            // Hiển thị thông tin đơn hàng
            txtThongTinDonHang.Text =
                "Thông tin đặt hàng\r\n" +
                "Khách hàng: " + tenKH + "\r\n" +
                "Điện thoại: " + SDT + "\r\n" +
                "Sản phẩm đã mua:\r\n" + spDaMua.ToString() +
                "Cách thanh toán: " + thanhToan;

        }
    }
}
