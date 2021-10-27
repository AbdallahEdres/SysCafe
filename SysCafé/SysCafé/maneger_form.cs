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
        private void hide_cont()
        {
            supplier_cont1.Visible = false;
            new_supp_controler1.Visible = false;
        }
        private void button_reset(Guna.UI2.WinForms.Guna2Button b)
        {
            b.FillColor = Color.Transparent;
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 0;
        }
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
            button_select(suppliers_but);
            button_reset(stock_but);
            button_reset(materials_but);
            hide_cont();
            supplier_cont1.Visible = true;
        }

        private void materials_but_Click(object sender, EventArgs e)
        {
            button_select(materials_but);
            button_reset(stock_but);
            button_reset(suppliers_but);
            hide_cont();
            new_supp_controler1.Visible = true;


        }

        private void stock_but_Click(object sender, EventArgs e)
        {
            button_select(stock_but);
            button_reset(suppliers_but);
            button_reset(materials_but);

        }

       
    }
}
