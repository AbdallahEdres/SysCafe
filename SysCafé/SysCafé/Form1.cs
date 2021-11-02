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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
        private void login_but_Click(object sender, EventArgs e)
        {
           string status= manager_model.login(username_txt.Text, Pasword_txt.Text);
            if (status == "manager")
            {
                maneger_form m = new maneger_form();
                m.Show();
                this.Hide();
                username_txt.Text = "";
                Pasword_txt.Text = "";
            }else if (status == "wrong")
            {
                MessageBox.Show("wrong");
            }else if (status == "waiter")
            {
                waiter_form w = new waiter_form();
                w.Show();
                
            }else if (status == "cashier")
            {
                cashier_form c = new cashier_form();
                c.Show();
            }
           
        }

        private void Pasword_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_but.PerformClick();

            }
        }

        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pasword_txt.Focus();

            }
        }
    }
}
