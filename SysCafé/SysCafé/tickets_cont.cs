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
    public partial class tickets_cont : UserControl
    {
        //list decleartion
        List<int> tables_id;
        DataSet ds;
       public List<Guna2Button> but_list = new List<Guna2Button>();
        public int table_id;
        private void creat_table(int id)
        {
            Guna2Button freetabla = new Guna2Button();
            freetabla.Image = imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = id.ToString();
            freetabla.Font = new Font("Inter Semi Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location = new Point(19, 45);
            freetabla.Size = new Size(285, 150);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5, -20);
            freetabla.Margin = new Padding(10);
            freetabla.Click += new EventHandler(fill_open_ticket_content);



            if (model.table_status(id) == 0)
            {
                freetabla.FillColor = Color.FromArgb(159, 159, 158);

            }
            else if (model.table_status(id) == 1)
            {
                freetabla.FillColor = Color.FromArgb(9, 170, 41);

            }

            flowLayoutPanel1.Controls.Add(freetabla);
            but_list.Add(freetabla);
        }

        private void order_column_naming()
        {
            orders_grid.Columns[0].HeaderText = "Item";
            orders_grid.Columns[1].HeaderText = "Size";
            orders_grid.Columns[2].HeaderText = "Count";
            orders_grid.Columns[3].HeaderText = "Price";
            orders_grid.Columns[4].HeaderText = "Category";

        }

        private void closed_grid_naming()
        {
            closed_grid.Columns[0].HeaderText = "Id";
            closed_grid.Columns[1].HeaderText = "Table";
            closed_grid.Columns[2].HeaderText = "Opend At";
            closed_grid.Columns[3].HeaderText = "Closed At";
            closed_grid.Columns[4].HeaderText = "Worker";
        }
        // change button to checked status
        public void check_but (Guna2Button but )
        {
            

            unchek_but();
            but.Checked = true;
            but.CheckedState.BorderColor = Color.FromArgb(252, 128, 25);
            but.BorderThickness = 5;
        }


        // uncheck all other buttons
        private void unchek_but()
        {
            foreach(Guna2Button but in but_list)
            {
                but.Checked = false;
                but.BorderThickness = 0;
            }
        }

        // getting tables orders 
       public  void fill_open_ticket_content(object sender, EventArgs e)
        {
            
            Guna2Button clickedButton = sender as Guna2Button;
            table_id = Convert.ToInt32(clickedButton.Text);
            check_but(clickedButton);
            string tkt_id =" ";
            string worker = " ";
            string time = " ";
            ds = new DataSet();
            model.fill_open_ticket_grid(ref ds, Convert.ToInt32(clickedButton.Text),ref tkt_id,ref worker,ref time);
            model.fill_closed_tkt_grid(ref ds, Convert.ToInt32(clickedButton.Text));
            if (ds.Tables.Count > 1)
            {
                new_ticket_panel.Hide();
                orders_grid.DataSource = ds.Tables["open ticket content"].DefaultView;
                table_id_label.Text = tkt_id;
                open_time_value.Text = time;
                waiter_iname_label.Text = worker;
                order_column_naming();

            }
            else
            {
                new_ticket_panel.Show();
                table_id_label.Text = " ";
                open_time_value.Text = " ";
                waiter_iname_label.Text = " ";
            }
            closed_grid.DataSource = ds.Tables["closed"];
            closed_grid_naming();
        }


        public tickets_cont()
        {
            InitializeComponent();

            //create tables 
            tables_id = model.get_table_id();
            for (int i = 0; i < tables_id.Count; i++)
            {
                creat_table(tables_id[i]);
            }
        }

        public void new_ticket_but_Click(object sender, EventArgs e)
        {
            if (table_id > 0)
            {
                model.new_tkt(table_id, 1);
                new_ticket_panel.Visible = false;
                string tkt_id = " ";
                string worker = " ";
                string time = " ";
                ds = new DataSet();
                model.fill_open_ticket_grid(ref ds, Convert.ToInt32(table_id), ref tkt_id, ref worker, ref time);
                orders_grid.DataSource = ds.Tables["open ticket content"].DefaultView;
                table_id_label.Text = tkt_id;
                open_time_value.Text = time;
                waiter_iname_label.Text = worker;
                order_column_naming();
                flowLayoutPanel1.Controls.Clear();
                tables_id = model.get_table_id();
                for (int i = 0; i < tables_id.Count; i++)
                {
                    creat_table(tables_id[i]);
                }
            }
            
           
        }


    }
}
