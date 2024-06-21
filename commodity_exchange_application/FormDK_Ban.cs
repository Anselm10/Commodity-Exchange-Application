using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commodity_exchange_application
{
    public partial class FormDK_Ban : Form
    {
        private string tentaikhoan;
        public FormDK_Ban()
        {
            InitializeComponent();
        }
        public FormDK_Ban(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan; 
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        string filePath;
        Byte[] imageByteArray;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "Insert into products(TenSanPham,GiaTienMoi,HinhAnh,TenTaiKhoan,LoaiMatHang,GiaGoc,TinhTrangMathang,MoTaHuHai,MoTaChiTiet,NgayMua,DiaChi) " +
                "Values(@Name, @price, @img,@tentaikhoan,@loaimathang,@giagoc,@tinhtrangmathang,@motahuhai,@motachitiet,@ngaymua,@diachi)";

            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();


            Hashtable ht = new Hashtable();
            ht.Add("@Name", txtName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@img", imageByteArray);
            ht.Add("@tentaikhoan", tentaikhoan);
            ht.Add("@loaimathang", cbLoaiMatHang.Text);
            ht.Add("@tinhtrangmathang", txtTinhTrang.Text);
            ht.Add("@giagoc", txtGiaGoc.Text);
            ht.Add("@motahuhai", txtMoTaHuHai.Text);
            ht.Add("@diachi", txtDiaChi.Text);
            ht.Add("@ngaymua", txtNgayMua.Value);
            ht.Add("@motachitiet", txtMoTaChiTiet.Text);
            if (DBConnection.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Save successfully");


            }
        }
    }
}
