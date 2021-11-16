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
    public partial class workers_cont : UserControl
    {
        DataTable dt;
        string name = "", age = "", phone = "", type = "", adress = "";
        int worker_id = -1, pic_id = -1;
        private void edit_but_Click(object sender, EventArgs e)
        {
            name_txt.Enabled = true;
            phone_txt.Enabled = true;
            adress_txt.Enabled = true;
            age_txt.Enabled = true;
            save_but.Visible = true;
            type_txt.Enabled = true;
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
            model.edit_worker(worker_id,name, phone, adress, age, type);
            fill_worker_list();
            
        }

        private void worker_pic_DoubleClick(object sender, EventArgs e)
        {
            profile_pic_form pic_Form = new profile_pic_form(ref workers_pic, pic_id, worker_id);
            pic_Form.ShowDialog();
        }

        


        private void worker_list_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                worker_id = Convert.ToInt32(worker_list_grid.Rows[e.RowIndex].Cells[0].Value);
                model.get_worker_info(worker_id, ref name, ref age, ref adress, ref type, ref phone, ref pic_id);
                id_lable.Text = worker_id.ToString();
                name_txt.Text = name;
                phone_txt.Text = phone;
                adress_txt.Text = adress;
                age_txt.Text = age;
                type_txt.Text = type;
                worker_pic.Image = workers_pic.Images[pic_id];
            }
           
        }

        private void fill_worker_list()
        {
            model.get_workers_list(ref dt);
            worker_list_grid.DataSource = dt.DefaultView;
            worker_list_grid.Columns[0].HeaderText = "ID";
            worker_list_grid.Columns[1].HeaderText = "Name";
        }
        public workers_cont()
        {
            InitializeComponent();
            refresh();
        }
        public void refresh()
        {
            fill_worker_list();

        }
    }
}
