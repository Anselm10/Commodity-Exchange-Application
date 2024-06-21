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
    public partial class FormAccountSettings : Form
    {
        private string tentaikhoan;
        public FormAccountSettings()
        {
            InitializeComponent();
        }
        public FormAccountSettings(string TenTaiKhoan)
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
        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            AddControls(new FormPersonal_Information(tentaikhoan));
        }
    }
}
