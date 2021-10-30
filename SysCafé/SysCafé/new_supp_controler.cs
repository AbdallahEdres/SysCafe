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
    public partial class new_supp_controler : UserControl
    {
        DataSet ds;
        int supplier_id;
        int receipt_id;
        int counter = 1;
        int item_num = 0;
        int mat_id;
        public new_supp_controler()
        {
            InitializeComponent();
            receipt_date.Value = DateTime.Now;
            manager_model.fill_pre_receipt_grid(ref ds);
            
            oldreceipt_grid.DataSource = ds.Tables[0].DefaultView;
            oldreceipt_grid.Columns[0].HeaderText = "Receipt ID";
            oldreceipt_grid.Columns[1].HeaderText = "Date";
            oldreceipt_grid.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            oldreceipt_grid.Columns[2].HeaderText = "Number Of Items";
            oldreceipt_grid.Columns[3].HeaderText = "Total Price";
            oldreceipt_grid.Sort(oldreceipt_grid.Columns[0], ListSortDirection.Descending);
        }

        private void save_receipt_but_Click(object sender, EventArgs e)
        {
            manager_model.add_receipt(receipt_date.Value,Convert.ToDouble(price_num.Value),Convert.ToInt32(items_num.Value));
            content_panel.Enabled = true;
            new_receipt_panel.Enabled = false;
            if (items_num.Value == 1)
            {
                finish_but.Enabled = true;
                next_but.Enabled = false;
            }
            else
            {
                finish_but.Enabled = false;
                next_but.Enabled = true;
            }
            item_num =Convert.ToInt32( items_num.Value);
        }

        

        private void next_but_Click(object sender, EventArgs e)
        {
            mat_id = manager_model.get_mat_id(mat_combo.Text);
            if (counter < item_num)
            {
                supplier_id = manager_model.get_supplier_id(supp_name_combo.SelectedItem.ToString());
                receipt_id = manager_model.receipt_id();
                manager_model.insert_materials(mat_id, Convert.ToDouble(unite_price_num.Value), supplier_id, Convert.ToDouble(count_num.Value), Convert.ToDouble(weight_num.Value), receipt_date.Value, receipt_id);
                counter =counter+1;
                manager_model.add_inventor(manager_model.get_mat_id(mat_combo.Text), Convert.ToDouble(count_num.Value));
            }
            if(counter == item_num)
            {
                finish_but.Enabled = true;
                next_but.Enabled = false;
            }            
            mat_combo.Text = "";
            supp_name_combo.Text = "";
            unite_price_num.Value = 0;
            count_num.Value = 0;
/*            weight_num.Value = 0;
*/
        }

        private void finish_but_Click(object sender, EventArgs e)
        {
            mat_id = manager_model.get_mat_id(mat_combo.Text);

            supplier_id = manager_model.get_supplier_id(supp_name_combo.SelectedItem.ToString());
            receipt_id = manager_model.receipt_id();
            manager_model.insert_materials(mat_id, Convert.ToDouble(unite_price_num.Value), supplier_id, Convert.ToDouble(count_num.Value), Convert.ToDouble(weight_num.Value), receipt_date.Value, receipt_id);
            content_panel.Enabled = false;
            new_receipt_panel.Enabled = true;
            items_num.Value = 1;
            price_num.Value = 0;
            supp_name_combo.Text = "";
            unite_price_num.Value = 0;
            count_num.Value = 0;
            weight_num.Value = 0;
            counter = 1;
            manager_model.fill_pre_receipt_grid(ref ds);
            oldreceipt_grid.DataSource = ds.Tables[0].DefaultView;
            manager_model.add_inventor(manager_model.get_mat_id(mat_combo.Text), Convert.ToDouble(count_num.Value));
            mat_combo.Text = "";
            oldreceipt_grid.Sort(oldreceipt_grid.Columns[0], ListSortDirection.Descending);

        }

        private void oldreceipt_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1)
            {
                receipt_id = Convert.ToInt32(oldreceipt_grid.Rows[e.RowIndex].Cells[0].Value);
                manager_model.fill_content_grid(ref ds, receipt_id);
                content_grid.DataSource = ds.Tables[0].DefaultView;
                content_grid.Columns[0].HeaderText = "Name";
                content_grid.Columns[1].HeaderText = "Count";
                content_grid.Columns[2].HeaderText = "Weight/gm";
                content_grid.Columns[3].HeaderText = "Price";
                content_grid.Columns[4].HeaderText = "Supplier";
                content_grid.Columns[5].HeaderText = "Date";
                content_grid.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                content_grid.Columns[6].HeaderText = "Receipt ID";
            }
            
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            receipt_id = manager_model.receipt_id();
           DialogResult d= MessageBox.Show("Are you sure ypu want to cansel?" ," ", MessageBoxButtons.YesNo);
            if (d== DialogResult.Yes)
            {
                manager_model.delete_receipt(receipt_id);
                new_receipt_panel.Enabled = true;
                content_panel.Enabled = false;
            }
            
        }

        private void mat_combo_Click(object sender, EventArgs e)
        {
            manager_model.fill_mat_combo(mat_combo);
        }

        private void supp_name_combo_Click(object sender, EventArgs e)
        {
            manager_model.fill_suppliers_combo(supp_name_combo);
        }
    }
}
