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
    public partial class maneger_form : Form
    {
        List<int> tables_id;
        string num_order = "0", income = "0";


        private void get_icome_num_order()
        {
            model.orders_income(ref num_order, ref income);
            income_val.Text = income+" $";
            order_num_val.Text = num_order;
            date_valu.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void creat_table(int id)
        {
            Guna2Button freetabla = new Guna2Button();
            freetabla.Image = imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = id.ToString();
            freetabla.Font = new Font("Inter Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location = new Point(19, 45);
            freetabla.Size = new Size(380, 250);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5, -20);
            freetabla.Margin = new Padding(80);


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
        public void fill_tables_panel()
        {
            tables_id = model.get_table_id();
            for (int i = 0; i < tables_id.Count; i++)
            {
                creat_table(tables_id[i]);
            }
        }
        private void hide_cont()
        {
            supplier_cont1.Hide();
            new_supp_controler1.Hide();
            stock_cont21.Hide();
            workers_cont1.Hide();
            ticket_cont2.Hide();
        }
        private void button_reset(Guna.UI2.WinForms.Guna2Button b)
        {
            b.FillColor = Color.Transparent;
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 0;
        }
        private void button_select(Guna.UI2.WinForms.Guna2Button b)
        {
            button_reset(stock_but);
            button_reset(materials_but);
            button_reset(orders_but);
            button_reset(Home_button);
            button_reset(suppliers_but);
            button_reset(workers_but);
            b.FillColor = Color.FromArgb(100, 252, 128, 25);
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 2;
            
        }
        public maneger_form()
        {
            // add special functions spicific to this form to tickets_casheir controler
            ticket_cont2.tabels_grid.CellDoubleClick += new DataGridViewCellEventHandler(ticket_cont2.tabels_grid_CellDoubleClick_1);
            ticket_cont2.takeaway_grid.CellDoubleClick += new DataGridViewCellEventHandler(ticket_cont2.takeaway_grid_CellDoubleClick_1);
            ticket_cont2.delivery_grid.CellDoubleClick += new DataGridViewCellEventHandler(ticket_cont2.delivery_grid_CellDoubleClick_1);

            InitializeComponent();
            hide_cont();
            button_select(Home_button);
            get_icome_num_order();
            fill_tables_panel();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            button_select(suppliers_but);
            hide_cont();
            supplier_cont1.Show();
        }

        private void materials_but_Click(object sender, EventArgs e)
        {
            button_select(materials_but);     
            hide_cont();
            new_supp_controler1.Show();
        }

        private void stock_but_Click(object sender, EventArgs e)
        {
            button_select(stock_but);
            hide_cont();
            stock_cont21.Show();
            stock_cont21.fill_grids();
        }

        private void orders_but_Click(object sender, EventArgs e)
        {
            button_select(orders_but);            
            hide_cont();
            ticket_cont2.Show();
        }

        private void maneger_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            model.exit_delete_receipt();
            Application.OpenForms[0].Show();
        }

        private void logout_but_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            hide_cont();
            button_select(Home_button);
        }

        private void workers_but_Click(object sender, EventArgs e)
        {
            button_select(workers_but);
            hide_cont();
            workers_cont1.Show();
        }

        private void refresh_but_Click(object sender, EventArgs e)
        {
            supplier_cont1.refresh();
            stock_cont21.refresh();
            ticket_cont2.refresh();
            workers_cont1.refresh();
            fill_tables_panel();
            get_icome_num_order();

        }
    }
}
