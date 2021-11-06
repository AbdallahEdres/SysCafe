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


        #region functions
        private void fill_tables_grids()
        {
            type_cond = " and ticket_type ='table'";
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
        }

        private void fill_delivery_grid()
        {
            type_cond = " and ticket_type ='delivery'";
            model.fill_payment_open_tkt(ref ds, status_cond, type_cond);
            delivery_grid.DataSource = ds.Tables[0].DefaultView;
            grid_naming(delivery_grid);
        }
        public void refresh()
        {
            fill_delivery_grid();
            fill_tables_grids();
            fill_takeaway_grid();
        }

        #endregion
        #region buttons

        public tickets_casier_cont()
        {
            InitializeComponent();
            fill_delivery_grid();
            fill_tables_grids();
            fill_takeaway_grid();
        }
        private void grid_naming(Guna2DataGridView grid)
        {
            grid.Columns[0].HeaderText = "Ticket ID";
            grid.Columns[1].HeaderText = "Table";
            grid.Columns[2].HeaderText = "Opend at";
            grid.Columns[3].HeaderText = "Closed at";
            grid.Columns[4].HeaderText = "Type";
            grid.Columns[5].HeaderText = "Worker";
            grid.Columns[6].HeaderText = "Status";
            grid.Columns[7].Visible = false;
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
            fill_tables_grids();
        }

        private void tabels_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ticket_id = Convert.ToInt32(tabels_grid.Rows[e.RowIndex].Cells[0].Value);
            }
        }

       

        private void takeaway_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                ticket_id = Convert.ToInt32(takeaway_grid.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void delivery_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                ticket_id = Convert.ToInt32(delivery_grid.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
