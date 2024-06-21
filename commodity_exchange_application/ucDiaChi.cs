using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static commodity_exchange_application.FormDiaChiGiaoHang;

namespace commodity_exchange_application
{
    public partial class ucDiaChi : UserControl
    {
        private string tentaikhoan;
        // Khai báo sự kiện ItemDeleted
        public event EventHandler ItemDeleted;
        public event EventHandler TickboxCheckedChanged;
        public ucDiaChi()
        {
            InitializeComponent();
        }


        
        public ucDiaChi(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }

        public string ItemTenNguoiDung
        {
            get
            {
                return lblTenNguoiDung.Text;
            }
            set
            {
                lblTenNguoiDung.Text = value;
            }
        }
        public string ItemSDT
        {
            get
            {
                return lblSDT.Text;
            }
            set
            {
                lblSDT.Text = value;
            }
        }
        public string ItemDiaChi
        {
            get
            {
                return lblDiaChi.Text;
            }
            set
            {
                lblDiaChi.Text = value;
            }
        }

        private void ucDiaChi_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối nếu chưa mở
                if (DBConnection.con.State != ConnectionState.Open)
                    DBConnection.con.Open();

                string deleteQuery = "DELETE FROM diachi WHERE TaiKhoan = @Username AND HoTen = @HoTen";
                SqlCommand cmd = new SqlCommand(deleteQuery, DBConnection.con);
                cmd.Parameters.AddWithValue("@Username", tentaikhoan);
                cmd.Parameters.AddWithValue("@HoTen", lblTenNguoiDung.Text);
                cmd.ExecuteNonQuery();
                OnItemDeleted(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin người dùng: " + ex.Message);
            }
        }
        // Phương thức kích hoạt sự kiện ItemDeleted
        protected virtual void OnItemDeleted(EventArgs e)
        {
            ItemDeleted?.Invoke(this, e);
        }

        public bool IsTickboxChecked // Tạo một thuộc tính để kiểm tra trạng thái của tickbox từ bên ngoài
        {
            get { return tickbox.Checked; }
        }
  

        private void tickbox_CheckedChanged(object sender, EventArgs e)
        {
            TickboxCheckedChanged?.Invoke(this, e);
        }
    }
}
