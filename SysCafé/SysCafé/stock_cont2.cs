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
    public partial class stock_cont2 : UserControl
    {
        DataSet ds;
        string name;
        private void fill_grids()
        {
            manager_model.fill_kitchen_grid(ref ds);
            kitchen_grid.DataSource = ds.Tables[0].DefaultView;
            kitchen_grid.Columns[0].HeaderText = "Name";
            kitchen_grid.Columns[1].HeaderText = "Count";
            manager_model.fill_inven_grid(ref ds);
            ineventory_grid.DataSource = ds.Tables[0].DefaultView;
            ineventory_grid.Columns[0].HeaderText = "Name";
            ineventory_grid.Columns[1].HeaderText = "Count";
        }
        public stock_cont2()
        {
            InitializeComponent();
            fill_grids();
        }

        private void ineventory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                inventory_count.Maximum = Convert.ToDecimal(ineventory_grid.Rows[e.RowIndex].Cells[1].Value);
                inventory_count.Value = Convert.ToDecimal(ineventory_grid.Rows[e.RowIndex].Cells[1].Value);
                name = ineventory_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void send_kitchen_but_Click(object sender, EventArgs e)
        {
            manager_model.add_ketchin(manager_model.get_mat_id(name), Convert.ToDouble(inventory_count.Value));
            manager_model.remov_inventory(manager_model.get_mat_id(name), Convert.ToDouble(inventory_count.Value));
            fill_grids();
        }

        private void send_inven_but_Click(object sender, EventArgs e)
        {
            manager_model.add_inventor(manager_model.get_mat_id(name), Convert.ToDouble(kitchen_count.Value));
            manager_model.remov_kitchen(manager_model.get_mat_id(name), Convert.ToDouble(kitchen_count.Value));
            fill_grids();
        }

        private void kitchen_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                kitchen_count.Maximum = Convert.ToDecimal(kitchen_grid.Rows[e.RowIndex].Cells[1].Value);
                kitchen_count.Value = Convert.ToDecimal(kitchen_grid.Rows[e.RowIndex].Cells[1].Value);
                name = kitchen_grid.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
           
        }

        private void refresh_but_Click(object sender, EventArgs e)
        {
            fill_grids();
        }
    }
}
