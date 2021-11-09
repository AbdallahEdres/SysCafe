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
    public partial class delivery_takeaway_form : Form
    {
        public int order_id;
        customer_info c = new customer_info(1);

        public delivery_takeaway_form()
        {
            InitializeComponent();
            c.FormClosed += new FormClosedEventHandler(copy_id);

        }
        public void copy_id(object sender, EventArgs e)
        {
            order_id = c.order_id;
        }

        private void takeaway_but_Click(object sender, EventArgs e)
        {
            this.Close();
           order_id= model.new_tkt_delivry_takeaway("takeaway", 1);
            MessageBox.Show("" + order_id);
        }

        private void delievry_but_Click(object sender, EventArgs e)
        {
            
          
            c.ShowDialog();
            MessageBox.Show("" + order_id);
            this.Close();
        }
    }
}
