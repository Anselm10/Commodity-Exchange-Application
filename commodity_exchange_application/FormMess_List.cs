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
    public partial class FormMess_List : Form
    {
        public FormMess_List()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2GradientPanel)sender).ShadowDecoration.Color = Color.DeepPink;
        }

        private void guna2GradientPanel1_MouseLeave(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2GradientPanel)sender).ShadowDecoration.Color = Color.FromArgb(17,22,32) ;
        }
    }
}
