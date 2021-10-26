using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCafé
{
    public partial class maneger_form : Form
    {
        private void button_select(Guna.UI2.WinForms.Guna2Button b)
        {
            b.FillColor = Color.FromArgb(100, 252, 128, 25);
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 2;
            
        }
        public maneger_form()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            button_select(guna2Button3);
            supplier_cont c = new supplier_cont();
            c.Dock = DockStyle.Fill;
            main_panel.Controls.Add(c);
            
        }
    }
}
