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
    public partial class FormProductInfo : Form
    {
        private string tentaikhoan;
        private string var;
        
        public FormProductInfo(string TenTk, string variableValue)
        {
            InitializeComponent();
            this.tentaikhoan = TenTk;
            this.var = variableValue;
        }
        public FormProductInfo(string variableValue)
        {
            InitializeComponent();
            this.var = variableValue;
            
        }
        public FormProductInfo()
        {
            InitializeComponent();
 

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void AddItems(string name, string price, Image pimage, string diachi, string giagoc, string ngaymua, string tinhtrang, string huhai, string tennguoiban, string motachitiet)
        {
            var w = new ucChiTietSP(tentaikhoan)
            {
                ItemNameCT = name,
                ItemPriceCT = price,
                ItemImageCT = pimage,
                ItemDiaChi = diachi,
                ItemGiaCu = giagoc,
                ItemGiaGoc = giagoc,
                ItemNgayMua = ngaymua,
                ItemTinhTrang = tinhtrang,
                ItemHuHai = huhai,
                ItemTenNguoiBan = tennguoiban,
                ItemMoTaChiTiet = motachitiet,
            };
            ProductCTPanel.Controls.Add(w);


        }
        private void FormProductInfo_Load(object sender, EventArgs e)
        {

            string qry = string.Format("select * from products where TenSanPham = N'{0}'", var);
            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            //cmd.Parameters.AddWithValue("@Name", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["HinhAnh"];
                byte[] imagebytearray = imagearray;

                AddItems(item["TenSanPham"].ToString(),
                    item["GiaTienMoi"].ToString(), 
                    Image.FromStream(new MemoryStream(imagearray)),
                    item["DiaChi"].ToString(),
                    item["GiaGoc"].ToString(),
                    item["NgayMua"].ToString(),
                    item["TinhTrangMathang"].ToString(),
                    item["MoTaHuHai"].ToString(),
                    item["TenTaiKhoan"].ToString(),
                    item["MoTaChiTiet"].ToString()
                    );
            }
        }
    }
}
