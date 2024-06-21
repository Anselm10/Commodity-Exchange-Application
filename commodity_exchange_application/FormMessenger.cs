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
    public partial class FormMessenger : Form
    {
        public FormMessenger()
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

        private void btnALL_Click(object sender, EventArgs e)
        {
            AddControls(new FormMess_List());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new FormMess_List());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddControls(new FormMess_List());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddControls(new FormMess_List());
        }
    }
}
