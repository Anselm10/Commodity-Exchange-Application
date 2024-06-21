using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace commodity_exchange_application
{
    public class Product
    {
        private string _tensanpham;
        private Image _hinhanh;
        private string _giatienban;
        private string _tentaikhoan;
        public Product() { }
        public Product(string tensanpham, Image hinhanh, string giatienban, string tentaikhoan)
        {
            TenSanPham = tensanpham;
            HinhAnh = hinhanh;
            GiaTienBan = giatienban;
            TenTaiKhoan = tentaikhoan; 
        }
        public Product(string tensanpham, string tentaikhoan)
        {
            TenSanPham = tensanpham;
            TenTaiKhoan = tentaikhoan;
        }
        public string TenSanPham { get => _tensanpham; set => _tensanpham = value; }
        public Image HinhAnh { get => _hinhanh; set => _hinhanh = value; }
        public string GiaTienBan { get => _giatienban; set => _giatienban = value; }
        public string TenTaiKhoan { get => _tentaikhoan;set => _tentaikhoan = value;}
    }
}
