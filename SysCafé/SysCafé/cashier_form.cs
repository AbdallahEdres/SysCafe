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
    public partial class cashier_form : Form
    {
        // data set declearation
        DataSet ds;

        // string declearation 
        string num_order = "0", income = "0";

        //user controls declearation
        tickets_casier_cont tickets_cont1 = new tickets_casier_cont();
        payment_cont pa = new payment_cont();
        menu_cashier_cont menu_cont1 = new menu_cashier_cont();


        #region Methods
        // naming data grid views columns 
        private void grid_naming(Guna2DataGridView grid)
        {
            grid.Columns[0].HeaderText = "Ticket ID";
            grid.Columns[1].HeaderText = "Table";
            grid.Columns[2].HeaderText = "Opend at";
            grid.Columns[3].HeaderText = "Closed at";
            grid.Columns[4].HeaderText = "Type";
            grid.Columns[5].HeaderText = "Worker";
            grid.Columns[6].Visible = false;
            grid.Columns[7].Visible = false;
        }

        //creating data grid views
        private void grid_view_fill()
        {
            // filling grid views
            model.fill_home_grid(ref ds);
            open_tkt_grid.DataSource = ds.Tables["open tickets"].DefaultView;
            Closed_tkt_grid.DataSource = ds.Tables["closed tickets"].DefaultView;
            history_grid.DataSource = ds.Tables["history"].DefaultView;

            // nameing columns headers 
            grid_naming(open_tkt_grid);
            grid_naming(Closed_tkt_grid);
            history_grid.Columns[0].HeaderText = "Day";
            history_grid.Columns[1].HeaderText = "Income";
        }

        // user controls adding to form 
        private void user_control_create()
        {
            this.Controls.Add(pa);
            pa.Hide();
            this.Controls.Add(menu_cont1);
            menu_cont1.Hide();
            this.Controls.Add(tickets_cont1);
            tickets_cont1.Hide();

        }

        // hides all user conrtols 
        private void hide_all()
        {
            pa.Hide();
            menu_cont1.Hide();
            tickets_cont1.Hide();
            main_panel.Hide();
        }

        // change button to selected status

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
            button_reset(payment_but);
            b.FillColor = Color.FromArgb(100, 252, 128, 25);
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 2;

        }

        // sets number of order of today and total income unteil now
        private void get_icome_num_order()
        {
            model.orders_income(ref num_order, ref income);
            income_val.Text = income;
            order_num_val.Text = num_order;
        }

        #endregion

        #region Butoons
        public cashier_form()
        {
            InitializeComponent();
            
            time_label.Text = DateTime.Now.ToString("hh : mm tt");
            timer1.Start();
            date_valu.Text= DateTime.Now.ToString("yyyy / MM /dd");


            grid_view_fill();

            user_control_create();

            get_icome_num_order();
            button_select(Home_button);
        }

        // timer for the clock
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("hh:mm");

        }

        public void Home_button_Click(object sender, EventArgs e)
        {
            hide_all();
            main_panel.Show();
            button_select(Home_button);
        }

        private void tickets_but_Click(object sender, EventArgs e)
        {
            hide_all();
            tickets_cont1.Show();
            button_select(tickets_but);
            
        }

        private void new_ticket_Click(object sender, EventArgs e)
        {
            delivery_takeaway_form delivery_Takeaway_Form = new delivery_takeaway_form();
            delivery_Takeaway_Form.takeaway_but.Click += new EventHandler(menu_but_Click);
            delivery_Takeaway_Form.ShowDialog();
        }

        private void menu_but_Click(object sender, EventArgs e)
        {
            hide_all();
            menu_cont1.Show();
            button_select(menu_but);
        }

        private void payment_but_Click(object sender, EventArgs e)
        {
            hide_all();
            pa.Show();
            button_select(payment_but);
        }

        private void cashier_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
    #endregion
}
