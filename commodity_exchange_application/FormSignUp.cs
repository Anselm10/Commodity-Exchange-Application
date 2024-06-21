using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace commodity_exchange_application
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        User user = new User();
        UserDAO userDAO = new UserDAO();
        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            user = new User(txtTaiKhoan.Text, txtEmail.Text, txtMatKhau.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtHoTen.Text);
            userDAO = new UserDAO();
            if (!userDAO.ValidateInput(user))
                return;
            
            // Thêm người dùng mới vào cơ sở dữ liệu
            if (userDAO.RegisterUser(user))
            {
                MessageBox.Show("Đăng ký thành công!");
                // Reset các control trên form sau khi đăng ký thành công
                txtHoTen.Text = "";
                txtTaiKhoan.Text = "";
                txtEmail.Text = "";
                txtMatKhau.Text = "";
                txtSoDienThoai.Text = "";
                txtDiaChi.Text = "";
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công! Vui lòng thử lại.");
            }
            this.Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.ShowDialog();
            this.Close();
        }
    }
}
