using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commodity_exchange_application
{
    public class User
    {


        private string _taikhoan;
        private string _email;
        private string _matkhau;
        private string _sodienthoai;
        private string _diachi;
        private string _hoten;

      

        public User () { }
        public User(string taikhoan, string email, string matkhau, string sodienthoai, string diachi, string hoten)
        {
            TaiKhoan = taikhoan;
            Email = email;
            MatKhau = matkhau;
            SoDienThoai = sodienthoai;
            DiaChi = diachi;
            HoTen = hoten;
        }

        public string TaiKhoan { get => _taikhoan; set => _taikhoan = value; }
        public string Email { get => _email; set => _email = value; }
        public string MatKhau { get => _matkhau; set => _matkhau = value; }
        public string SoDienThoai { get => _sodienthoai; set => _sodienthoai = value; }
        public string DiaChi { get => _diachi; set => _diachi = value; }
        public string HoTen { get => _hoten; set => _hoten = value; }
        // Hàm khởi tạo
    }
}
