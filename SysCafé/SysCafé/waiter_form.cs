using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SysCafé
{
    public partial class waiter_form : Form
    {
        // controllers declearation
        tickets_cont tickets_cont1 = new tickets_cont();
        menu_cont Menu_Cont1 = new menu_cont();
        List<int> tables_id;

        // hiding all controllers method
        private void hid_cont()
        {
            tickets_cont1.Hide();
            main_panel.Hide();
            Menu_Cont1.Hide();
        }

        //creating tables method
        private void creat_table(int id)
        {
            Guna2Button freetabla = new Guna2Button();
            freetabla.Image = imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = id.ToString();
            freetabla.Font = new Font("Inter Medium", 20.25F, FontStyle.Bold,GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location = new Point(19, 45);
            freetabla.Size = new Size(380, 250);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5, -20);
            freetabla.Margin = new Padding(80);
            freetabla.Click += new EventHandler(tickets_cont1.fill_open_ticket_content);
            freetabla.Click += new EventHandler(tickets_but_Click);
            freetabla.Click += new EventHandler(check_but_tkts);

            if (model.table_status(id) == 0)
            {
                freetabla.FillColor = Color.FromArgb(159, 159, 158);

            }
            else if (model.table_status(id) == 1)
            {
                freetabla.FillColor = Color.FromArgb(9, 170, 41);

            }

            flowLayoutPanel1.Controls.Add(freetabla);

        }

      private void check_but_tkts(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            foreach(Guna2Button but in tickets_cont1.but_list)
            {
                if (but.Text == clickedButton.Text)
                {
                    tickets_cont1.check_but(but);
                }
            }

        }
        private void check_but_menu(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            foreach (Guna2Button but in Menu_Cont1.flowLayoutPanel1.Controls)
            {
                if (but.Text == clickedButton.Text)
                {
                    Menu_Cont1.check_but(but);
                    
                }

            }

        }

        //reseting buttons method 
        private void button_reset(Guna2Button b)
        {
            b.FillColor = Color.Transparent;
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 0;
        }
 
        // select spacific button
        private void button_select(Guna2Button b)
        {
            button_reset(Home_button);
            button_reset(menu_but);
            button_reset(tickets_but);
            b.FillColor = Color.FromArgb(100, 252, 128, 25);
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 2;

        }
        // initialize component
        public waiter_form()
        {
            InitializeComponent();
            button_select(Home_button);
            tickets_cont1.new_ticket_but.Click += new EventHandler(new_tkt);
            tickets_cont1.new_ticket_but.Click += new EventHandler(check_but_menu);


            // add user controllers to the form
            this.Controls.Add(tickets_cont1);
            this.Controls.Add(Menu_Cont1);
            hid_cont();

            main_panel.Show();

            //create tables 
            tables_id = model.get_table_id();
            for (int i = 0; i <tables_id.Count; i++)
            {
                creat_table(tables_id[i]);
            }          
           
        }

        private void tickets_but_Click(object sender, EventArgs e)
        {
            hid_cont();
            tickets_cont1.Show();
            button_select(tickets_but);           
        }

        public void Home_button_Click(object sender, EventArgs e)
        {
            hid_cont();
            button_select(Home_button);
            main_panel.Show();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < tables_id.Count; i++)
            {
                creat_table(tables_id[i]);
            }
        }

        private void menu_but_Click(object sender, EventArgs e)
        {
            hid_cont();
            button_select(menu_but);
            Menu_Cont1.Show();
            Menu_Cont1.refresh();
            
        }

        private void waiter_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
        private void new_tkt(object sender, EventArgs e)
        {
            if (tickets_cont1.table_id > 0)
            {
                hid_cont();
                button_select(menu_but);
                Menu_Cont1.Show();
                Menu_Cont1.table_id = tickets_cont1.table_id;
                
            }
            else
            {
                MessageBox.Show("choose table");
            }
            Menu_Cont1.refresh();
        }
    }
}
