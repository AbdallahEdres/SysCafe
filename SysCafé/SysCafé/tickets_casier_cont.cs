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
    public partial class tickets_casier_cont : UserControl
    {
        DataSet ds;
        string status_cond = " and ticket_status= 'open'";
        string type_cond = "";
        public int ticket_id=404;
        List<int> tables_id;
        int table_id;
        string table_condtion="";

        #region functions


        private void creat_table(int id)
        {
            Guna2Button freetabla = new Guna2Button();
            freetabla.Image = tabel_image.Images[0];
            freetabla.ImageSize = new Size(45, 45);
            freetabla.Text = id.ToString();
            freetabla.Font = new Font("Inter Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 10;
            freetabla.Name = "table1";
            freetabla.Location = new Point(20, 20);
            freetabla.Size = new Size(135, 70);
            freetabla.TextOffset = new Point(0, 20);
            freetabla.ImageOffset = new Point(35, -10);
            freetabla.Margin = new Padding(10);
            freetabla.ImageAlign = HorizontalAlignment.Right;
            freetabla.Click += new EventHandler(grid_fill);
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
        public void grid_fill(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            table_id = Convert.ToInt32(clickedButton.Text);
            table_condtion = " and table_num = " + table_id ;
            fill_tables_grids(table_condtion);
        }
        private void fill_tabl_panel()
        {
            flowLayoutPanel1.Controls.Clear();
            tables_id = model.get_table_id();
            for (int i = 0; i < tables_id.Count; i++)
            {
                creat_table(tables_id[i]);

            }
        }
        private void fill_tables_grids(string condtion)
        {
            type_cond = " and ticket_type ='table' "+condtion+"";
            model.fill_payment_open_tkt(ref ds, status_cond, type_cond);
            tabels_grid.DataSource = ds.Tables[0].DefaultView;
            grid_naming(tabels_grid);
        }

        private void fill_takeaway_grid()
        {
            type_cond = " and ticket_type ='takeaway'";
            model.fill_payment_open_tkt(ref ds, status_cond, type_cond);
            takeaway_grid.DataSource = ds.Tables[0].DefaultView;
            grid_naming(takeaway_grid);
            takeaway_grid.Columns[1].Visible = false;
        }

        private void fill_delivery_grid()
        {
            type_cond = " and ticket_type ='delivery'";
            model.fill_delivery(ref ds, status_cond, type_cond);
            delivery_grid.DataSource = ds.Tables[0].DefaultView;
            delivery_grid.Columns[0].HeaderText = "Ticket ID";
            delivery_grid.Columns[1].HeaderText = "Opened At"; 
            delivery_grid.Columns[2].HeaderText = "Closed At"; 
            delivery_grid.Columns[3].HeaderText = "Status"; 
            delivery_grid.Columns[4].HeaderText = "Worker";
            delivery_grid.Columns[5].Visible = false;
            delivery_grid.Columns[6].HeaderText = "Total $"; 
            delivery_grid.Columns[7].HeaderText = "Delivery $";
            delivery_grid.Columns[8].HeaderText = "Adress";
            delivery_grid.Columns[9].HeaderText = "Customer";
            delivery_grid.Columns[10].HeaderText = "Phone";
            delivery_grid.Columns[11].Visible = false;

        }
        public void refresh()
        {
            fill_delivery_grid();
            table_condtion = "";
            fill_tables_grids(table_condtion);
            fill_takeaway_grid();
            fill_tabl_panel();
        }

        #endregion
        #region buttons

        public tickets_casier_cont()
        {
            InitializeComponent();
            fill_delivery_grid();
            table_condtion = "";
            fill_tables_grids(table_condtion);
            fill_takeaway_grid();
            fill_tabl_panel();
            
        }
        private void grid_naming(Guna2DataGridView grid)
        {
            grid.Columns[0].HeaderText = "Ticket ID";
            grid.Columns[1].HeaderText = "Table";
            grid.Columns[2].HeaderText = "Opend at";
            grid.Columns[3].HeaderText = "Closed at";
            grid.Columns[4].Visible = false;
            grid.Columns[5].HeaderText = "Worker";
            grid.Columns[6].HeaderText = "Status";
            grid.Columns[7].Visible = false;
            grid.Columns[8].HeaderText = "Total $";
            
        }

        #endregion

        private void delivery_togel_CheckedChanged(object sender, EventArgs e)
        {
            if (delivery_togel.Checked == true)
            {
                status_cond = " and ticket_status= 'closed'";
            }
            else
            {
                status_cond = " and ticket_status= 'open'";

            }
            fill_delivery_grid();
        }

        private void takaway_togel_CheckedChanged(object sender, EventArgs e)
        {
            if (takaway_togel.Checked == true)
            {
                status_cond = " and ticket_status= 'closed'";
            }
            else
            {
                status_cond = " and ticket_status= 'open'";

            }
            fill_takeaway_grid();
        }

        private void openclose_table_togel_CheckedChanged(object sender, EventArgs e)
        {
            if (openclose_table_togel.Checked == true)
            {
                status_cond = " and ticket_status= 'closed'";
            }
            else
            {
                status_cond = " and ticket_status= 'open'";

            }
            table_condtion = "";
            fill_tables_grids(table_condtion);
        }

        public void tabels_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ticket_id = Convert.ToInt32(tabels_grid.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("" + ticket_id);
            }
        }

       

        public void takeaway_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                ticket_id = Convert.ToInt32(takeaway_grid.Rows[e.RowIndex].Cells[0].Value);

            }
        }

        public void delivery_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                ticket_id = Convert.ToInt32(delivery_grid.Rows[e.RowIndex].Cells[0].Value);

            }
        }

        private void all_tables_but_Click(object sender, EventArgs e)
        {
            table_condtion = "";
            fill_tables_grids(table_condtion);
        }

        public void takeaway_grid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                close_ticket_content_form _Ticket_Content_Form = new close_ticket_content_form(Convert.ToInt32(takeaway_grid.Rows[e.RowIndex].Cells[0].Value));
                _Ticket_Content_Form.ShowDialog();
            }

        }

        public void tabels_grid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                close_ticket_content_form _Ticket_Content_Form = new close_ticket_content_form(Convert.ToInt32(tabels_grid.Rows[e.RowIndex].Cells[0].Value));
                _Ticket_Content_Form.ShowDialog();
            }

        }

        public void delivery_grid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                close_ticket_content_form _Ticket_Content_Form = new close_ticket_content_form(Convert.ToInt32(delivery_grid.Rows[e.RowIndex].Cells[0].Value));
                _Ticket_Content_Form.ShowDialog();
            }
            
        }
    }
}
