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
    public partial class FormItemsforSale : Form
    {
        public FormItemsforSale()
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
        private void guna2ShadowPanel1_MouseEnter(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2ShadowPanel)sender).FillColor = Color.LightBlue;
        }

        private void guna2ShadowPanel1_MouseLeave(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2ShadowPanel)sender).FillColor = Color.White;
        }

        private void guna2ShadowPanel4_MouseClick(object sender, MouseEventArgs e)
        {
            AddControls(new FormAccountSettings());
        }
    }
}
