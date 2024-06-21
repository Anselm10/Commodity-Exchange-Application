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
    public partial class FormDiaChiGiaoHang : Form
    {
        private string tentaikhoan;
        public event EventHandler<ucDiaChiEventArgs> UcDiaChiSelected;
        private string Tensanpham;
        private List<string> Danhsachsanpham;
        private string HoTen;
        private string SDT;
        private string DiaChi;
        public FormDiaChiGiaoHang()
        {
            InitializeComponent();
        }
        public FormDiaChiGiaoHang(string TenTaiKhoan, string tensanpham, List<string> danhsachsanpham)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
            this.Tensanpham = tensanpham;
            this.Danhsachsanpham = danhsachsanpham;
        }
        private void Uc_TickboxCheckedChanged(object sender, EventArgs e)
        {
            var uc = sender as ucDiaChi;
            if (uc != null && uc.IsTickboxChecked)
            {
                // Lấy tên sản phẩm từ UserControl
                 HoTen = uc.ItemTenNguoiDung;
                 SDT = uc.ItemSDT;
                 DiaChi = uc.ItemDiaChi;

                // Thêm tên sản phẩm vào danh sách

                // Thực hiện các hành động khác cần thiết với thông tin sản phẩm đã được tick
            }
        }
        public void AddItems(string ten, string sdt, string diachi)
        {
            var w = new ucDiaChi(tentaikhoan)
            {
                ItemTenNguoiDung = ten,
                ItemSDT = sdt,
                ItemDiaChi = diachi,

            };
            // Đăng ký sự kiện ItemDeleted của UserControl
            w.TickboxCheckedChanged += Uc_TickboxCheckedChanged;
            w.ItemDeleted += UserControl_ItemDeleted;
            posPanel.Controls.Add(w);
        }
       

        private void FormDiaChiGiaoHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string qry = "select * from diachi where TaiKhoan = @Username";
            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Username", tentaikhoan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                AddItems(item["HoTen"].ToString(),
                    item["SDT"].ToString(),
                    item["DiaChi"].ToString());
            }
        }
        private void UserControl_ItemDeleted(object sender, EventArgs e)
        {
            // Xóa tất cả các UserControl hiện có trong posPanel
            posPanel.Controls.Clear();

            // Sau đó load lại dữ liệu
            LoadData();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        public class ucDiaChiEventArgs : EventArgs
        {
            public string TenNguoiDung { get; set; }
            public string SDT { get; set; }
            public string DiaChi { get; set; }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThanhToan thanhToan = new FormThanhToan(tentaikhoan,HoTen,SDT,DiaChi,Tensanpham,Danhsachsanpham);
            thanhToan.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThemDiaChi themdiachi = new FormThemDiaChi(tentaikhoan);
            themdiachi.ShowDialog();
            LoadData();
            this.Show();
        }
    }
}
