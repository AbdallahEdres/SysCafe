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
    public partial class supplier_cont : UserControl
    {
        public supplier_cont()
        {
            InitializeComponent();
        }

        private void supplier_serach_txt_Click(object sender, EventArgs e)
        {
            supplier_serach_txt.Text = "";
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            add_supplier_form add = new add_supplier_form();
            add.Show();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {

        }
    }
}
