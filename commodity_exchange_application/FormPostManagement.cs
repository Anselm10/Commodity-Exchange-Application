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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace commodity_exchange_application
{
    public partial class FormPostManagement : Form
    {

        private string tentaikhoan;
        public FormPostManagement()
        {
            InitializeComponent();
        }



        public FormPostManagement(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }


        private void PostPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AddItems(string name, string price, Image pimage)
        {
            var w = new ucPost()
            {
                ItemLabel = name,
                ItemPrice = price,
                ItemImage = pimage,

            };
            PostPanel.Controls.Add(w);


        }

        private void FormPostManagement_Load(object sender, EventArgs e)
        {
            string qry = "select * from products where TenTaiKhoan = @Username";
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
                    item["GiaTienMoi"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }
    }
}
