using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commodity_exchange_application
{
    public partial class ucProduct : UserControl
    {
        private string tentaikhoan;
        public ucProduct()
        {
            InitializeComponent();
            // Đăng ký sự kiện Click cho UserControl
            this.Click += ucProduct_Click;

        }
        public ucProduct(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
            // Đăng ký sự kiện Click cho UserControl
            this.Click += ucProduct_Click;

        }

        public void ucProduct_Click(object sender, EventArgs e)
        {
            FormProductInfo frm = new FormProductInfo(tentaikhoan,label1.Text);

            frm.ShowDialog();
        }
        public event EventHandler onSelect = null;

        public Image ItemImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string ItemLabel
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string ItemPrice
        {
            get
            {
                return label14.Text;
            }
            set
            {
                label14.Text = value;
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

        private void label1_Click(object sender, EventArgs e)
        {
            FormProductInfo formProductInfo = new FormProductInfo(label1.Text);

            formProductInfo.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
