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
    public partial class close_ticket_content_form : Form
    {
        DataSet ds = new DataSet();
        public close_ticket_content_form(int id)
        {
            InitializeComponent();
            model.fill_recipt(ref ds, id);
            details_grid.DataSource = ds.Tables[0].DefaultView;
            ticket_id_label.Text = id.ToString();
            details_grid.Columns[0].HeaderText = "Ticket ID";
            details_grid.Columns[1].HeaderText = "Item";
            details_grid.Columns[2].HeaderText = "Size";
            details_grid.Columns[3].HeaderText = "Count";
            details_grid.Columns[4].HeaderText = "Price/1";

        }
    }
}
