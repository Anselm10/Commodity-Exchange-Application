using System;
using System.Collections;
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
    public partial class FormThanhToan : Form
    {
        private string tentaikhoan;
        private string tensanpham;
        private List<string> danhsachsanpham;
        private string hoten;
        private string sdt;
        private string diachi;
        public FormThanhToan(string TenTaiKhoan, string tensanpham)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
            this.tensanpham = tensanpham;
        }
        public FormThanhToan(string TenTaiKhoan, List<string> danhSachSanPham)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
            this.danhsachsanpham = danhSachSanPham;
        }
        public FormThanhToan(string TenTaiKhoan, string HoTen, string SDT, string DiaChi, string Tensanpham, List<string>Danhsachsanpham)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
            this.hoten = HoTen;
            this.sdt = SDT;
            this.diachi = DiaChi;
            this.tensanpham = Tensanpham;
            this.danhsachsanpham = Danhsachsanpham;
        }

        public FormThanhToan()
        {
            InitializeComponent();
        }
        public void AddItems(string name, string price, Image pimage)
        {
            var w = new ucThanhToan(tentaikhoan)
            {
                ItemLabel = name,
                ItemPrice = price,
                ItemImage = pimage,

            };



            posPanel.Controls.Add(w);


        }
        private void LoadData()
        {
            decimal tongtienhang = 0;
            decimal tongthanhtoan = 0;
            try
            {
                if (hoten == null)
                {
                    // Mở kết nối nếu chưa mở
                    if (DBConnection.con.State != ConnectionState.Open)
                        DBConnection.con.Open();

                    string qry = "SELECT * FROM DangKy WHERE TenTaiKhoan = @Username";
                    SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
                    cmd.Parameters.AddWithValue("@Username", tentaikhoan);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblTenNguoiDung.Text = reader["HoTen"].ToString();
                        lblSDT.Text = reader["SDT"].ToString();
                        lblDiaChi.Text = reader["DiaChi"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    lblTenNguoiDung.Text = hoten;
                    lblSDT.Text = sdt;
                    lblDiaChi.Text = diachi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin người dùng: " + ex.Message);
            }
            try
            {
                // Mở kết nối nếu chưa mở
                if (DBConnection.con.State != ConnectionState.Open)
                    DBConnection.con.Open();

                if (!string.IsNullOrEmpty(tensanpham)) // Kiểm tra nếu biến là một chuỗi
                {
                    // Thực hiện truy vấn cho một sản phẩm duy nhất
                    string singleProductQuery = "select * from donhang where TenTaiKhoan = @Username and TenSanPham = @TenSanPham";
                    SqlCommand singleProductCmd = new SqlCommand(singleProductQuery, DBConnection.con);
                    singleProductCmd.Parameters.AddWithValue("@Username", tentaikhoan);
                    singleProductCmd.Parameters.AddWithValue("@TenSanPham", tensanpham);
                    SqlDataAdapter singleProductDa = new SqlDataAdapter(singleProductCmd);
                    DataTable singleProductDt = new DataTable();
                    singleProductDa.Fill(singleProductDt);

                    foreach (DataRow item in singleProductDt.Rows)
                    {
                        byte[] imagearray = (byte[])item["HinhAnh"];
                        decimal giaTien = Convert.ToDecimal(item["GiaTienBan"]); // Lấy giá tiền từ DataRow
                        tongtienhang += giaTien; // Cộng giá tiền vào tổng tiền hàng

                        AddItems(item["TenSanPham"].ToString(),
                                 giaTien.ToString(),
                                 Image.FromStream(new MemoryStream(imagearray)));

                    }
                }
                else if (danhsachsanpham != null && danhsachsanpham.Count > 0) // Kiểm tra nếu biến là một danh sách
                {
                    // Thực hiện truy vấn cho từng sản phẩm trong danh sách
                    foreach (string product in danhsachsanpham)
                    {
                        string multiProductQuery = "select * from donhang where TenTaiKhoan = @Username and TenSanPham = @TenSanPham";
                        SqlCommand multiProductCmd = new SqlCommand(multiProductQuery, DBConnection.con);
                        multiProductCmd.Parameters.AddWithValue("@Username", tentaikhoan);
                        multiProductCmd.Parameters.AddWithValue("@TenSanPham", product);
                        SqlDataAdapter multiProductDa = new SqlDataAdapter(multiProductCmd);
                        DataTable multiProductDt = new DataTable();
                        multiProductDa.Fill(multiProductDt);

                        foreach (DataRow item in multiProductDt.Rows)
                        {
                            byte[] imagearray = (byte[])item["HinhAnh"];
                            decimal giaTien = Convert.ToDecimal(item["GiaTienBan"]); // Lấy giá tiền từ DataRow
                            tongtienhang += giaTien; // Cộng giá tiền vào tổng tiền hàng

                            AddItems(item["TenSanPham"].ToString(),
                                     giaTien.ToString(),
                                     Image.FromStream(new MemoryStream(imagearray)));

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin người dùng: " + ex.Message);
            }

            tongthanhtoan = tongtienhang + 45;
            lblTongTienHang.Text = tongtienhang.ToString();
            lblTongThanhToan.Text = tongthanhtoan.ToString();
        }
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        
       

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeletePost(string tenSanPham)
        {
            try
            {
                string query = "DELETE FROM products WHERE TenSanPham = @TenSanPham";

                Hashtable ht = new Hashtable();
                ht.Add("@TenSanPham", tenSanPham);

                if (DBConnection.SQl(query, ht) > 0)
                {
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm từ cơ sở dữ liệu: " + ex.Message);
            }
        }
        private void UpdatePost(string tenSanPham)
        {
            try
            {
                string query = "UPDATE DONHANG SET TrangThai = 1 WHERE TenSanPham = @TenSanPham and TenTaiKhoan = @TenTaiKhoan";

                Hashtable ht = new Hashtable();
                ht.Add("@TenSanPham", tenSanPham);
                ht.Add("@TenTaiKhoan", tentaikhoan);
                if (DBConnection.SQl(query, ht) > 0)
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm từ cơ sở dữ liệu: " + ex.Message);
            }
        }
        private void btnDelPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tensanpham)) // Kiểm tra nếu biến là một chuỗi
            {
                UpdatePost(tensanpham);
                DeletePost(tensanpham);
                MessageBox.Show("Xác nhận mua sản phẩm thành công");
            }
            else if (danhsachsanpham != null && danhsachsanpham.Count > 0) // Kiểm tra nếu biến là một danh sách
            {
                foreach (string product in danhsachsanpham)
                {
                    UpdatePost(product);
                    DeletePost(product);
                    MessageBox.Show("Xác nhận mua sản phẩm thành công");
                }
            }
            this.Close();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDiaChiGiaoHang formGiaoHang = new FormDiaChiGiaoHang(tentaikhoan,tensanpham,danhsachsanpham);

            formGiaoHang.ShowDialog();
            /*LoadData();
            this.Show();*/

            this.Close();            
        }
    }
}
