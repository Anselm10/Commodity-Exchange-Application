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
using System.Xml.Linq;
using static commodity_exchange_application.FormDiaChiGiaoHang;

namespace commodity_exchange_application
{
    public partial class FormThemDiaChi : Form
    {
        private string tentaikhoan;    
        public FormThemDiaChi(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }
        public FormThemDiaChi()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "Insert into DiaChi(HoTen,DiaChi,SDT,TaiKhoan) " +
                "Values(@hoten, @diachi, @sdt,@taikhoan)";
            Hashtable ht = new Hashtable();
            ht.Add("@hoten", txtHoTen.Text);
            ht.Add("@diachi", txtDiaChi.Text);
            ht.Add("@sdt", txtSDT.Text);
            ht.Add("@taikhoan", tentaikhoan);
            if (DBConnection.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công!");

            }
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
