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
    public partial class cashier_form : Form
    {
        
        public cashier_form()
        {
            InitializeComponent();
            time_label.Text = DateTime.Now.ToString("hh : mm tt");
            timer1.Start();
            date_label.Text = date_label.Text +" "+ DateTime.Now.ToString("yyyy / MM /dd");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("hh:mm");

        }

        public void Home_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("عظيييييم");
        }

        private void tickets_but_Click(object sender, EventArgs e)
        {

            
        }

        private void new_ticket_Click(object sender, EventArgs e)
        {
            delivery_takeaway_form delivery_Takeaway_Form = new delivery_takeaway_form();
            delivery_Takeaway_Form.takeaway_but.Click += new EventHandler(menu_but_Click);
            delivery_Takeaway_Form.ShowDialog();
        }

        private void menu_but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        }

        private void payment_but_Click(object sender, EventArgs e)
        {
            payment_cont pa = new payment_cont();
            this.Controls.Add(pa);
            pa.Show();
            pa.BringToFront();

        }
    }
}
