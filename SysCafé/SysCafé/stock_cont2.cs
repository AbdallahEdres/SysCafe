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
        string name_stock="",name_kitchen="";
        public void fill_grids(string condetion)
        {
            model.fill_kitchen_grid(ref ds,condetion);
            kitchen_grid.DataSource = ds.Tables[0].DefaultView;
            kitchen_grid.Columns[0].HeaderText = "Name";
            kitchen_grid.Columns[1].HeaderText = "Count";
            model.fill_inven_grid(ref ds,condetion);
            ineventory_grid.DataSource = ds.Tables[0].DefaultView;
            ineventory_grid.Columns[0].HeaderText = "Name";
            ineventory_grid.Columns[1].HeaderText = "Count";
        }
        public stock_cont2()
        {
            InitializeComponent();
            fill_grids(" ");
        }

        private void ineventory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                inventory_count.Maximum = Convert.ToDecimal(ineventory_grid.Rows[e.RowIndex].Cells[1].Value);
                inventory_count.Value = Convert.ToDecimal(ineventory_grid.Rows[e.RowIndex].Cells[1].Value);
                name_stock = ineventory_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void send_kitchen_but_Click(object sender, EventArgs e)
        {
            if (name_stock == "")
            {
                MessageBox.Show("Select material from the stock");
            }
            else
            {
                model.add_ketchin(model.get_mat_id(name_stock), Convert.ToDouble(inventory_count.Value));
                model.remov_inventory(model.get_mat_id(name_stock), Convert.ToDouble(inventory_count.Value));
                fill_grids(" ");
            }
            inventory_count.Value = 0;
           
        }

        private void send_inven_but_Click(object sender, EventArgs e)
        {
            if (name_kitchen == "")
            {
                MessageBox.Show("Select material from kitchen");
            }
            else
            {
                model.add_inventor(model.get_mat_id(name_kitchen), Convert.ToDouble(kitchen_count.Value));
                model.remov_kitchen(model.get_mat_id(name_kitchen), Convert.ToDouble(kitchen_count.Value));
                fill_grids(" ");
            }
            kitchen_count.Value = 0;
        }

        private void kitchen_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                kitchen_count.Maximum = Convert.ToDecimal(kitchen_grid.Rows[e.RowIndex].Cells[1].Value);
                kitchen_count.Value = Convert.ToDecimal(kitchen_grid.Rows[e.RowIndex].Cells[1].Value);
                name_kitchen = kitchen_grid.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
           
        }

        private void supplier_serach_txt_TextChanged(object sender, EventArgs e)
        {
            fill_grids(" where material_list.material_name like  '" + supplier_serach_txt.Text + "%'");
            
        }
        
        public void refresh()
        {
            fill_grids(" ");
        }
    }
}
