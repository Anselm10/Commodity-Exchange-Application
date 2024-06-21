using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commodity_exchange_application
{
    public partial class FormMatHang : Form
    {
        private string tentaikhoan;
        public FormMatHang()
        {
            InitializeComponent();
        }

        public FormMatHang(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }
        public void AddControls(Form f)
        {
            ProductPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ProductPanel.Controls.Add(f);
            f.Show();
        }
        private void DoiMau()
        {
            Color redColor = Color.FromArgb(94, 148, 255); // Màu đỏ
            btnThoiTrang.FillColor = redColor;
            btnDoGiaDung.FillColor = redColor;
            btnDienThoai.FillColor = redColor;
            btnDoDienTu.FillColor = redColor;
            btnDoDienMay.FillColor = redColor;
            btnDoDungVanPhong.FillColor = redColor;
        }
        private void btnDangBan_Click(object sender, EventArgs e)
        {
            FormDK_Ban ban = new FormDK_Ban(tentaikhoan);
            ban.ShowDialog();
            ProductPanel.Controls.Clear();
            LoadProducts(tentaikhoan);
        }

        private void ucProduct1_MouseClick(object sender, MouseEventArgs e)
        {
            var clickedProduct = (ucProduct)sender;
            string tenSanPham = clickedProduct.ItemLabel;
            FormProductInfo formProductInfo = new FormProductInfo(tentaikhoan,tenSanPham);

            formProductInfo.ShowDialog();
        }



        public void AddItems(string name, string price, Image pimage, string giacu, int uutien)
        {
            var w = new ucProduct(tentaikhoan)
            {
                ItemLabel = name,
                ItemPrice = price,
                ItemImage = pimage,
                ItemGiaCu = giacu,
            };
            if(uutien == 1)
            {
                w.BackColor = Color.LightPink;
            }    
            ProductPanel.Controls.Add(w);

        }
        public void LoadProducts(string tenTaiKhoan)
        {
            // Lấy danh sách sản phẩm từ bảng "Ưu Tiên" sắp xếp theo thứ tự ưu tiên của người dùng
            string qry = "SELECT *" +
                         "FROM UuTien u " +
                         "INNER JOIN products p ON u.TenSanPham = p.TenSanPham " +
                         "WHERE u.TenTaiKhoan = @TenTaiKhoan " +
                         "ORDER BY CASE WHEN u.UuTien = 1 THEN 0 ELSE 1 END"; // Giả sử có cột "Thứ tự ưu tiên" trong bảng UuTien để xác định thứ tự ưu tiên

            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                byte[] imagearray = (byte[])item["HinhAnh"];
                AddItems(item["TenSanPham"].ToString(),
                         item["GiaTienMoi"].ToString(),
                         Image.FromStream(new MemoryStream(imagearray)),
                         item["GiaGoc"].ToString(),1);
            }

            // Load các sản phẩm còn lại không có trong danh sách ưu tiên của người dùng
            LoadRemainingProducts(tenTaiKhoan);
        }

        private void LoadRemainingProducts(string tenTaiKhoan)
        {
            // Lấy danh sách sản phẩm từ bảng "products" mà không nằm trong danh sách ưu tiên của người dùng
            string qry = "SELECT * " +
                         "FROM products " +
                         "WHERE TenSanPham NOT IN (SELECT TenSanPham FROM UuTien WHERE TenTaiKhoan = @TenTaiKhoan)";

            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                byte[] imagearray = (byte[])item["HinhAnh"];
                AddItems(item["TenSanPham"].ToString(),
                         item["GiaTienMoi"].ToString(),
                         Image.FromStream(new MemoryStream(imagearray)),
                         item["GiaGoc"].ToString(),0);
            }
        }

        private void FormMatHang_Load(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadProducts(tentaikhoan);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.ItemLabel.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());
            }
        }

        public void LoadTheoLoai(string tenTaiKhoan, string loaimathang)
        {
            // Lấy danh sách sản phẩm từ bảng "Ưu Tiên" sắp xếp theo thứ tự ưu tiên của người dùng
            string qry = "SELECT * " +
                         "FROM products " +
                         "WHERE TenTaiKhoan = @TenTaiKhoan and LoaiMatHang = @loaimathang";

            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
            cmd.Parameters.AddWithValue("@loaimathang", loaimathang);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                byte[] imagearray = (byte[])item["HinhAnh"];
                AddItems(item["TenSanPham"].ToString(),
                         item["GiaTienMoi"].ToString(),
                         Image.FromStream(new MemoryStream(imagearray)),
                         item["GiaGoc"].ToString(),0);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadTheoLoai(tentaikhoan, "Thời trang");
            DoiMau();
            btnThoiTrang.FillColor = Color.Red;

        }

        private void btnDoGiaDung_Click(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadTheoLoai(tentaikhoan, "Đồ gia dụng");
            DoiMau();
            btnDoGiaDung.FillColor = Color.Red;
        }

        private void btnDienThoai_Click(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadTheoLoai(tentaikhoan, "Điện thoại");
            DoiMau();
            btnDienThoai.FillColor = Color.Red;
        }

        private void btnDoDienTu_Click(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadTheoLoai(tentaikhoan, "Đồ điện tử");
            DoiMau();
            btnDoDienTu.FillColor = Color.Red;
        }

        private void btnDoDienMay_Click(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadTheoLoai(tentaikhoan, "Đồ điện máy");
            DoiMau();
            btnDoDienMay.FillColor = Color.Red;
        }

        private void btnDoDungVanPhong_Click(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadTheoLoai(tentaikhoan, "Đồ dùng văn phòng");
            DoiMau();
            btnDoDungVanPhong.FillColor = Color.Red;
        }
    }
}
