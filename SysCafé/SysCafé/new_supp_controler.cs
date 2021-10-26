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
    public partial class new_supp_controler : UserControl
    {
        public new_supp_controler()
        {
            InitializeComponent();
        }

        private void save_receipt_but_Click(object sender, EventArgs e)
        {
            content_panel.Enabled = true;
        }
    }
}
