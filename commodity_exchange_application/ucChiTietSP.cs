using Microsoft.VisualBasic.ApplicationServices;
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

namespace commodity_exchange_application
{
    public partial class ucChiTietSP : UserControl
    {
        private string tentaikhoan;
        public ucChiTietSP()
        {
            InitializeComponent();
        }

        public ucChiTietSP(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }

        public static readonly string con_string = "Data Source=THEBIN\\THEBIN;Initial Catalog=commodity_exchange_application;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        Product product = new Product();
        productDAO productDAO = new productDAO();
        public Image ItemImageCT
        {
            get
            {
                return txtImageCT.Image;
            }
            set
            {
                txtImageCT.Image = value;
            }
        }
        public string ItemNameCT
        {
            get
            {
                return lblNameCT.Text;
            }
            set
            {
                lblNameCT.Text = value;
            }
        }
        public string ItemPriceCT
        {
            get
            {
                return lblPrice.Text;
            }
            set
            {
                lblPrice.Text = value;
            }
        }
        public string ItemGiaCu
        {
            get
            {
                return lblGiaCu.Text;
            }
            set
            {
                lblGiaCu.Text = value;
            }
        }
        public string ItemGiaGoc
        {
            get
            {
                return lblGiaGoc.Text;
            }
            set
            {
                lblGiaGoc.Text = value;
            }
        }
        public string ItemDiaChi
        {
            get
            {
                return lblDiaChi.Text;
            }
            set
            {
                lblDiaChi.Text = value;
            }
        }
        public string ItemNgayMua
        {
            get
            {
                return lblNgayMua.Text;
            }
            set
            {
                lblNgayMua.Text = value;
            }
        }
        public string ItemTinhTrang
        {
            get
            {
                return lblTinhTrang.Text;
            }
            set
            {
                lblTinhTrang.Text = value;
            }
        }

        public string ItemHuHai
        {
            get
            {
                return lblHuHai.Text;
            }
            set
            {
                lblHuHai.Text = value;
            }
        }

        public string ItemTenNguoiBan
        {
            get
            {
                return lblTenNguoiBan.Text;
            }
            set
            {
                lblTenNguoiBan.Text = value;
            }
        }

        public string ItemMoTaChiTiet
        {
            get
            {
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
            }
        }


        private void buttonMuaHang_Click(object sender, EventArgs e)
        {
            product = new Product(ItemNameCT, ItemImageCT, ItemPriceCT,tentaikhoan);

            // Thêm người dùng mới vào cơ sở dữ liệu
            if (productDAO.RegisterUser(product))
            {
                MessageBox.Show("Thêm vào giỏ hàng thành công!");
            }
            else
            {
                MessageBox.Show("Mua không thành công! Vui lòng thử lại.");
            }

        }

        // Phương thức kiểm tra xem sản phẩm đã được đánh dấu ưu tiên hay chưa
        private bool IsUuTien(string tenTaiKhoan, string tenSanPham)
        {
            string qry = "SELECT COUNT(*) FROM UuTien WHERE TenTaiKhoan = @TenTaiKhoan AND TenSanPham = @TenSanPham";
            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
            cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);

            try
            {
                DBConnection.con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                DBConnection.con.Close();
            }
        }

        // Phương thức hủy đánh dấu ưu tiên cho sản phẩm
        private void HuyUuTien(string tenTaiKhoan, string tenSanPham)
        {
            string qry = "DELETE FROM UuTien WHERE TenTaiKhoan = @TenTaiKhoan AND TenSanPham = @TenSanPham";
            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
            cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);

            try
            {
                DBConnection.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hủy ưu tiên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DBConnection.con.Close();
            }
        }

        private void btnTym_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm được chọn
            string tenSanPham = lblNameCT.Text;
            string tenTaiKhoan = tentaikhoan;

            // Kiểm tra xem sản phẩm đã được đánh dấu ưu tiên hay chưa
            if (IsUuTien(tenTaiKhoan, tenSanPham))
            {
                // Nếu đã đánh dấu ưu tiên trước đó, thì hủy ưu tiên
                HuyUuTien(tenTaiKhoan, tenSanPham);
            }
            else
            {
                // Nếu chưa đánh dấu ưu tiên, thì thêm vào danh sách ưu tiên
                AddToUuTien(tenTaiKhoan, tenSanPham);
            };
        }
        private void AddToUuTien(string tenTaiKhoan, string tenSanPham)
        {
            // Kết nối CSDL và thêm sản phẩm vào bảng "Ưu Tiên" sử dụng câu lệnh SQL INSERT
            string qry = "INSERT INTO UuTien (TenTaiKhoan, TenSanPham) VALUES (@TenTaiKhoan, @TenSanPham)";
            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
            cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);

            try
            {
                // Mở kết nối và thực thi câu lệnh SQL
                DBConnection.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sản phẩm vào danh sách ưu tiên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                DBConnection.con.Close();
            }
        }
    }
}
