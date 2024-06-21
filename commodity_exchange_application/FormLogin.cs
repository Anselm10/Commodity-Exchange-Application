using Guna.UI2.WinForms;
using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        Account acc = new Account();
        AccountDAO accDAO = new AccountDAO();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            acc = new Account(txtUserName.Text, txtPassWord.Text);
            accDAO = new AccountDAO();
            if (accDAO.IsValidUser(acc) == false)
            {
                guna2MessageDialog1.Show("Sai tên tài khoản hoặc sai mật khẩu!\nVui lòng nhập lại!");
                return;
            }
            else
            {
                this.Hide();
                FormHome formHome = new FormHome(acc.Name);
                formHome.ShowDialog();
                this.Close();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp FormSignUp = new FormSignUp();
            FormSignUp.ShowDialog();
            this.Close();
        }
    }
}
