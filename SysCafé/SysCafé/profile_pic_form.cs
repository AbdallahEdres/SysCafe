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
    public partial class profile_pic_form : Form
    {
        int _pic_id;
        public profile_pic_form(ref ImageList pic_list,int pic_id ,int worker_id)
        {
            InitializeComponent();
            _pic_list = pic_list;
            _pic_id = pic_id;
            pictureBox1.Image = _pic_list.Images[pic_id];
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
            }

        }
    }
}
