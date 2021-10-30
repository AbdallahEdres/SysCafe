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
    public partial class supllier_edit_form : Form
    {
        string name, phone, phone2, adrees, adrees2 = "";

        private void done_but_Click(object sender, EventArgs e)
        {
            manager_model.edit_sup_info(sup_name_txt.Text, sup_phone_txt.Text, sup_phonne2.Text, sup_address_txt.Text, sup_adress2.Text);
            MessageBox.Show("Done!");
            this.Close();
        }

        public supllier_edit_form()
        {
            InitializeComponent();
            manager_model.get_supplier_info(ref name,ref phone, ref phone2,ref adrees,ref adrees2);
            sup_phone_txt.Text = phone;
            sup_name_txt.Text = name;
            sup_address_txt.Text = adrees;
            sup_phonne2.Text = phone2;
            sup_adress2.Text = adrees2;
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
