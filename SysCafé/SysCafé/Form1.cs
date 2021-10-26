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
            maneger_form m = new maneger_form();
            m.Show();
            this.Hide();
        }
    }
}
