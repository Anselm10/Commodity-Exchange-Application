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
    public partial class FormPersonal_Information : Form
    {
        private string tentaikhoan;
        public FormPersonal_Information(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }
        public FormPersonal_Information()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }

       
        private void FormPersonal_Information_Load(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text=tentaikhoan.ToString();
        }

        private void btnGiayTo_Click(object sender, EventArgs e)
        {
            AddControls(new FormPersonalIdentification(tentaikhoan));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            FormLogin FormLogin = new FormLogin();
            // this.Visible = false;
            FormLogin.ShowDialog();
            this.ParentForm.Close();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            AddControls(new FormAccountSettings(tentaikhoan));
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
