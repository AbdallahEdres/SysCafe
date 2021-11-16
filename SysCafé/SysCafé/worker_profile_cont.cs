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
    public partial class worker_profile_cont : UserControl
    {
        string name = "", age = "", phone = "", type = "", adress = "";
        int  pic_id = -1;

        public void refresh()
        {
            model.get_worker_info(model.worker_id, ref name, ref age, ref adress, ref type, ref phone, ref pic_id);
            id_lable.Text = model.worker_id.ToString();
            name_txt.Text = name;
            phone_txt.Text = phone;
            adress_txt.Text = adress;
            age_txt.Text = age;
            type_txt.Text = type;
            worker_pic.Image = workers_pic.Images[pic_id];
        }
        public worker_profile_cont()
        {
            InitializeComponent();
            refresh();
        }

        private void save_but_Click(object sender, EventArgs e)
        {

            name_txt.Enabled = false;
            phone_txt.Enabled = false;
            adress_txt.Enabled = false;
            age_txt.Enabled = false;
            save_but.Visible = false;
            type_txt.Enabled = false;
            name = name_txt.Text;
            phone = phone_txt.Text;
            age = age_txt.Text;
            adress = adress_txt.Text;
            type = type_txt.Text;
            model.edit_worker(model.worker_id, name, phone, adress, age, type);
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            name_txt.Enabled = true;
            phone_txt.Enabled = true;
            adress_txt.Enabled = true;
            age_txt.Enabled = true;
            save_but.Visible = true;
            type_txt.Enabled = true;
        }
    }
}
