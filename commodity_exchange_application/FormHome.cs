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
    public partial class FormHome : Form
    {
        private string tentaikhoan;
        public FormHome()
        {
            InitializeComponent();
        }
        public FormHome(string TenTaiKhoan)
        {
            InitializeComponent();
            this.tentaikhoan = TenTaiKhoan;
        }

        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            AddControls(new FormMatHang(tentaikhoan));
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            AddControls(new FormPersonal_Information(tentaikhoan));
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            AddControls(new FormMessenger());
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            AddControls(new FormPostManagement(tentaikhoan));
        }

        private void btnLichSuMua_Click(object sender, EventArgs e)
        {
            AddControls(new FormLichSuMuaHang(tentaikhoan));
        }

        private void btn_Click(object sender, EventArgs e)
        {
            AddControls(new FormPurchaseHistory(tentaikhoan));
        }
    }
}
