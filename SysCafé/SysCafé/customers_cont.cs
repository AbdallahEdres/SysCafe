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
    public partial class customers_cont : UserControl
    {
        DataTable dt;
        string name = "", adress = "", phone = "", email = "", pin = "";
        int customer_id = -1,pic_id=-1;

        private void customer_list_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                customer_id = Convert.ToInt32(customer_list_grid.Rows[e.RowIndex].Cells[0].Value);
                model.get_customer_info(customer_id, ref  name, ref adress, ref pin, ref email, ref phone, ref pic_id);
                id_lable.Text = customer_id.ToString();
                name_txt.Text = name;
                phone_txt.Text = phone;
                pin_txt.Text = pin;
                adress_txt.Text = adress;
                email_txt.Text = email;
                customer_pic.Image = customer_piclist.Images[0];
            }

        }

        private void new_customer_but_Click(object sender, EventArgs e)
        {
            customer_info customer_Info1 = new customer_info(0);
            customer_Info1.ShowDialog();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            if (customer_id > 0)
            {
                name_txt.Enabled = true;
                phone_txt.Enabled = true;
                pin_txt.Enabled = true;
                adress_txt.Enabled = true;
                save_but.Visible = true;
                email_txt.Enabled = true;
            }
           
        }
        private void fill_customer_list()
        {
            model.get_customers_list(ref dt);
            customer_list_grid.DataSource = dt.DefaultView;
            customer_list_grid.Columns[0].HeaderText = "Customer ID";
            customer_list_grid.Columns[1].HeaderText = "Customer Name";
            customer_list_grid.Columns[2].HeaderText = "Customer Phone";

        }
        public void refresh()
        {
            fill_customer_list();
            name = "";
            adress = "";
            phone = "";
            email = "";
            pin = "";
            name_txt.Enabled = false;
            phone_txt.Enabled = false;
            pin_txt.Enabled = false;
            adress_txt.Enabled = false;
            save_but.Visible = false;
            email_txt.Enabled = false;
            name = name_txt.Text;
            phone = phone_txt.Text;
            adress = adress_txt.Text;
            pin = pin_txt.Text;
            email = email_txt.Text;
            customer_id = -1;
            pic_id = -1;
        }
        public customers_cont()
        {
            InitializeComponent();
            refresh();
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            fill_customer_list();
            name_txt.Enabled = false;
            phone_txt.Enabled = false;
            pin_txt.Enabled = false;
            adress_txt.Enabled = false;
            save_but.Visible = false;
            email_txt.Enabled = false;
            name = name_txt.Text;
            phone = phone_txt.Text;
            adress = adress_txt.Text;
            pin = pin_txt.Text;
            email = email_txt.Text;
            model.edit_customer(customer_id, name, adress, pin, email, phone, pic_id);
        }
    }
}
