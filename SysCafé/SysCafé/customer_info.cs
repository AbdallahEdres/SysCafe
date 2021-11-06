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
    public partial class customer_info : Form
    {

        string name;
        string phone;
        string adress;
        string pin;
        string email;
        int id;
        public int order_id;

        public customer_info()
        {
            InitializeComponent();
            saved_radio.Checked = true;
        }

        

        private void phone_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                phone = phone_txt.Text;
              if(model.check_customer(phone) == 1)
              {
                    model.get_customer_info(phone, ref name, ref adress, ref pin, ref email, ref id);
                    name_txt.Text = name;
                    adress_txt.Text = adress;
                    pincode_txt.Text = pin;
                    email_txt.Text = email;
                    saved_radio.Enabled = true;
                    another_radio.Enabled = true;
                }
                else
               if(model.check_customer(phone) == 0)
               {
                    MessageBox.Show("First time");
                    name_txt.Enabled = true;
                    adress_txt.Enabled = true;
                    pincode_txt.Enabled = true;
                    email_txt.Enabled = true;
                    saved_radio.Enabled = true;
                    another_radio.Enabled =false;
                }
            }
        }

        private void another_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (another_radio.Checked == true)
            {
                adress_txt.Enabled = false;
                sub_adress.Enabled = true;
            } else
            {
                
                sub_adress.Enabled = false;
            }
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            phone = phone_txt.Text;
            name = name_txt.Text;
            adress = adress_txt.Text;
            pin = pincode_txt.Text;
            email = email_txt.Text;
            if (model.check_customer(phone) == 1)
            {
                order_id = model.new_tkt_delivry_takeaway("delivery", 1);
                if (another_radio.Checked == true && sub_adress.Text != "")
                {
                    adress = sub_adress.Text;
                    model.add_delivery_order(order_id, id, adress);

                }
                else if (another_radio.Checked == false)
                {
                    adress = adress_txt.Text;
                    model.add_delivery_order(order_id, id, adress);

                }
                else if (another_radio.Checked == true && sub_adress.Text == "")
                {
                    MessageBox.Show("Enter adress");
                }
            }
            else
            {
              id=  model.add_new_customer(phone, name, adress, pin, email);
                add_but.PerformClick();
            }
            this.Close();
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
