using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commodity_exchange_application
{
    public partial class ucLSMua : UserControl
    {
        public ucLSMua()
        {
            InitializeComponent();
        }
        public Image ItemImage
        {
            get
            {
                return PostPic.Image;
            }
            set
            {
                PostPic.Image = value;
            }
        }
        public string ItemLabel
        {
            get
            {
                return PostName.Text;
            }
            set
            {
                PostName.Text = value;
            }
        }
        public string ItemPrice
        {
            get
            {
                return PostPrice.Text;
            }
            set
            {
                PostPrice.Text = value;
            }
        }

        private void PostPrice_MouseClick(object sender, MouseEventArgs e)
        {
            FormProductInfo formProductInfo = new FormProductInfo(PostName.Text);

            formProductInfo.ShowDialog();
        }

        private void ucPost_Click(object sender, EventArgs e)
        {
            FormProductInfo formProductInfo = new FormProductInfo(PostName.Text);

            formProductInfo.ShowDialog();
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
                    MessageBox.Show("Xác nhận mua sản phẩm thành công");
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

        private void btnDelPost_Click(object sender, EventArgs e)
        {
            string tenSanPham = PostName.Text; // Lấy tên sản phẩm từ TextBox
            DeletePost(tenSanPham);
        }

    }
}
