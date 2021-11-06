using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SysCafé
{
    public partial class payment_cont : UserControl
    {
        // data set decleartion 
        DataSet ds = new DataSet();

        // decleration for selecto conditions as strings
        string status_cond = "";
        string type_cond = "";

       public int ticket_id;
        double pay;
        int table_id;


        #region methods
        // naming grid view headers 
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

        // method to choose select condetion
        private void choose_cond(ref string status, ref string typ)
        {
            if (all_radio.Checked == true)
            {
                typ = "";
            }else if (tabels_radio.Checked == true)
            {
                typ = " and ticket_type ='table'";
            }else if (delivery_radio.Checked == true)
            {
                typ = " and ticket_type ='delivery'";
            }else if (takeaway_radio.Checked == true)
            {
                typ = " and ticket_type = 'takeaway'";
            }
            if (open_close_togel.Checked==true)
            {
                status = " ";
            }else if (open_close_togel.Checked == false)
            {
                status = " and ticket_status= 'open'";
            }
        }

        // method to get grid view data
        public void fill_tkts_grid()
        {
            ds.Clear();
            choose_cond(ref status_cond, ref type_cond);
            model.fill_payment_open_tkt(ref ds,status_cond ,type_cond );
            if (ds.Tables.Count > 0)
            {
                tickets_grid.DataSource = ds.Tables["payment tickets"];
                grid_naming(tickets_grid);

            }
        }

        private void receipt_grid_naming()
        {
            recipt_grid.Columns[0].HeaderText = "Ticket ID";
            recipt_grid.Columns[1].HeaderText = "Item";
            recipt_grid.Columns[2].HeaderText = "Size";
            recipt_grid.Columns[3].HeaderText = "Count";
            recipt_grid.Columns[4].HeaderText = "Price/1";


        }

        #endregion



        #region buttons
        public payment_cont()
        {
            InitializeComponent();
            fill_tkts_grid();
            all_radio.Checked = true;
        }

        

        private void open_close_togel_CheckedChanged(object sender, EventArgs e)
        {
 
            fill_tkts_grid();
        }

        private void tabels_radio_CheckedChanged(object sender, EventArgs e)
        {
            fill_tkts_grid();
        }

        private void delivery_radio_CheckedChanged(object sender, EventArgs e)
        {
            fill_tkts_grid();

        }

        private void takeaway_radio_CheckedChanged(object sender, EventArgs e)
        {
            fill_tkts_grid();
            price_label.Text =  "$";
        }

        private void tickets_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ticket_id = Convert.ToInt32(tickets_grid.Rows[e.RowIndex].Cells[0].Value);
                if (tickets_grid.Rows[e.RowIndex].Cells[1].Value.ToString() !="")
                {
                    table_id = Convert.ToInt32(tickets_grid.Rows[e.RowIndex].Cells[1].Value);

                }

                model.fill_recipt(ref ds, ticket_id);
                recipt_grid.DataSource = ds.Tables["receipt"].DefaultView;
                receipt_grid_naming();
                 pay = model.calc_payment(ticket_id);
                price_label.Text = pay.ToString() + "$";
            }
        }

        private void close_tkt_but_Click(object sender, EventArgs e)
        {
            model.close_tkt(ticket_id, pay,table_id);
            fill_tkts_grid();
        }
    }
    #endregion
}
