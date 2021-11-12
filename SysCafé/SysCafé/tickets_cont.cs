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
        string tkt_valu="0";
        string tkt_id = " ";
        string worker = " ";
        string time = " ";

        #region Functions 
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
            closed_grid.Columns[0].HeaderText = "Ticket ID";
            closed_grid.Columns[1].HeaderText = "Table";
            closed_grid.Columns[2].HeaderText = "Opend at";
            closed_grid.Columns[3].HeaderText = "Closed at";
            closed_grid.Columns[4].Visible = false;
            closed_grid.Columns[5].HeaderText = "Worker";
            closed_grid.Columns[6].HeaderText = "Status";
            closed_grid.Columns[7].Visible = false;
            closed_grid.Columns[8].HeaderText = "Total $";
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
           
            fill_grids();
            check_but(clickedButton);
        }
        private void fill_grids()
        {
            ds = new DataSet();
            model.fill_open_ticket_grid(ref ds, Convert.ToInt32(table_id), ref tkt_id, ref worker, ref time, ref tkt_valu);
            model.fill_closed_tkt_grid(ref ds, Convert.ToInt32(table_id));
            if (ds.Tables.Count > 1)
            {
                new_ticket_panel.Hide();
                orders_grid.DataSource = ds.Tables["open ticket content"].DefaultView;
                table_id_label.Text = tkt_id;
                open_time_value.Text = time;
                waiter_iname_label.Text = worker;
                total_label.Text = tkt_valu;
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
            tables_orders_label.Text = "Table " + table_id + " Orders";
        }

        private void fill_table_banel()
        {
            flowLayoutPanel1.Controls.Clear();
            tables_id = model.get_table_id();
            for (int i = 0; i < tables_id.Count; i++)
            {
                creat_table(tables_id[i]);
            }
        }
        public void refresh()
        {
            fill_table_banel();
            fill_grids();
            foreach( Guna2Button but in but_list)
            {
                if(Convert.ToInt32(but.Text) == table_id)
                {
                    check_but(but);
                }
            }
        }

        #endregion


        #region Buttons

        public tickets_cont()
        {
            InitializeComponent();

            //create tables 
            fill_table_banel();
        }

        public void new_ticket_but_Click(object sender, EventArgs e)
        {
            if (table_id > 0)
            {
                model.new_tkt_table(table_id);
                new_ticket_panel.Visible = false;
                string tkt_id = " ";
                string worker = " ";
                string time = " ";
                ds = new DataSet();
                model.fill_open_ticket_grid(ref ds, Convert.ToInt32(table_id), ref tkt_id, ref worker, ref time,ref tkt_valu);
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

        private void closed_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                close_ticket_content_form _Ticket_Content_Form = new close_ticket_content_form(Convert.ToInt32(closed_grid.Rows[e.RowIndex].Cells[0].Value));
                _Ticket_Content_Form.ShowDialog();
            }
            
        }

        #endregion
    }
}
