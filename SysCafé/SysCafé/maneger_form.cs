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
            supplier_cont1.Hide();
            new_supp_controler1.Hide();
            stock_cont21.Hide();
            orders_cont1.Hide();
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
            button_select(Home_button);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            button_select(suppliers_but);
            button_reset(stock_but);
            button_reset(materials_but);
            button_reset(orders_but);
            button_reset(Home_button);
            hide_cont();
            supplier_cont1.Show();
        }

        private void materials_but_Click(object sender, EventArgs e)
        {
            button_select(materials_but);
            button_reset(stock_but);
            button_reset(suppliers_but);
            button_reset(orders_but);
            button_reset(Home_button);
            hide_cont();
            new_supp_controler1.Show();
        }

        private void stock_but_Click(object sender, EventArgs e)
        {
            button_select(stock_but);
            button_reset(suppliers_but);
            button_reset(materials_but);
            button_reset(orders_but);
            button_reset(Home_button);
            hide_cont();
            stock_cont21.Show();           
        }

        private void orders_but_Click(object sender, EventArgs e)
        {
            button_select(orders_but);
            button_reset(suppliers_but);
            button_reset(materials_but);
            button_reset(stock_but);
            button_reset(Home_button);
            hide_cont();
            orders_cont1.Show();
        }

        private void maneger_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager_model.exit_delete_receipt();
            Application.OpenForms[0].Show();
        }

        private void logout_but_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            hide_cont();
            button_select(Home_button);
            button_reset(suppliers_but);
            button_reset(materials_but);
            button_reset(stock_but);
            button_reset(orders_but);
            hide_cont();
        }
    }
}
