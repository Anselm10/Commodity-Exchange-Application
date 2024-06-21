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
    public partial class FormLichSuMuaHang : Form
    {
        private string tentaikhoan;

        public FormLichSuMuaHang()
        {
            InitializeComponent();
        }
        public FormLichSuMuaHang(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }

        public void AddItems(string name, string price, Image pimage)
        {
            var w = new ucLSMua()
            {
                ItemLabel = name,
                ItemPrice = price,
                ItemImage = pimage,

            };
            postpanel.Controls.Add(w);


        }
       
        private void FormLichSuMuaHang_Load(object sender, EventArgs e)
        {
            string qry = "select * from donhang where TenTaiKhoan = @Username and TrangThai = 1";
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
    }
}
