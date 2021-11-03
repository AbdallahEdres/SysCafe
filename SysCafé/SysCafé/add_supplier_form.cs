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
    public partial class add_supplier_form : Form
    {
        public add_supplier_form()
        {
            InitializeComponent();
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            model.add_supplier(sup_name_txt.Text, sup_phone_txt.Text,sup_phonne2.Text, sup_address_txt.Text,sup_adress2.Text);
            MessageBox.Show("Done!");
            this.Close();
        }
    }
}
