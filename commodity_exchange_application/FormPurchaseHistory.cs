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
    public partial class FormPurchaseHistory : Form
    {
        private string tentaikhoan;
        List<string> tenSanPhamList = new List<string>();
        Product product = new Product();
        productDAO productDAO = new productDAO();
        public FormPurchaseHistory()
        {
            InitializeComponent();
        }
        public FormPurchaseHistory(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }

        private void Uc_TickboxCheckedChanged(object sender, EventArgs e)
        {
            var uc = sender as ucDonHang;
            if (uc != null && uc.IsTickboxChecked)
            {
                // Lấy tên sản phẩm từ UserControl
                string tenSanPham = uc.PostName.Text;

                // Thêm tên sản phẩm vào danh sách
                tenSanPhamList.Add(tenSanPham);

                // Thực hiện các hành động khác cần thiết với thông tin sản phẩm đã được tick
            }
        }
        public void AddItems(string name, string price, Image pimage)
        {
            var w = new ucDonHang(tentaikhoan)
            {
                ItemLabel = name,
                ItemPrice = price,
                ItemImage = pimage,

            };
            w.TickboxCheckedChanged += Uc_TickboxCheckedChanged;
            postpanel.Controls.Add(w);


        }

        private void loadSP()
        {
            string qry = "select * from donhang where TenTaiKhoan = @Username and TrangThai = 0";
            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Username", tentaikhoan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["HinhAnh"];
                byte[] imagebytearray = imagearray;

                AddItems(item["TenSanPham"].ToString(),
                    item["GiaTienBan"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }
        private void FormPurchaseHistory_Load(object sender, EventArgs e)
        {
            postpanel.Controls.Clear();
            loadSP();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormThanhToan formThanhToan = new FormThanhToan(tentaikhoan, tenSanPhamList);

            formThanhToan.ShowDialog();
            postpanel.Controls.Clear();
            loadSP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (string sp in tenSanPhamList)
            {
                product = new Product(sp, tentaikhoan);

                // Thêm người dùng mới vào cơ sở dữ liệu
                if (productDAO.DeleteProduct(product))
                {
                    
                }
                else
                {
                    MessageBox.Show("Mua không thành công! Vui lòng thử lại.");
                }
            }
            MessageBox.Show("Xóa sản phẩm khỏi giỏ hàng thành công!");
            postpanel.Controls.Clear();
            loadSP();
        }
    }
}
