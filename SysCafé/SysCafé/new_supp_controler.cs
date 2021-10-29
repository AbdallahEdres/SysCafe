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
        public new_supp_controler()
        {
            InitializeComponent();
            manager_model.fill_suppliers_combo(supp_name_combo);
            receipt_date.Value = DateTime.Now;
            manager_model.fill_pre_receipt_grid(ref ds);
            oldreceipt_grid.DataSource = ds.Tables[0].DefaultView;
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
        }

        

        private void next_but_Click(object sender, EventArgs e)
        {
            supplier_id = manager_model.get_supplier_id(supp_name_combo.SelectedItem.ToString());
            receipt_id = manager_model.receipt_id();
            manager_model.insert_materials(supp_name_txt.Text, Convert.ToDouble(unite_price_num.Value), supplier_id, Convert.ToDouble(count_num.Value), Convert.ToDouble(weight_num.Value), receipt_date.Value, receipt_id);
            do
            {
                counter += 1;
            }
            while (counter < items_num.Value);
            if (counter == items_num.Value)
            {
                next_but.Enabled = false;
                finish_but.Enabled = true;
            }
            supp_name_txt.Text = "";
            supp_name_combo.Text = "";
            unite_price_num.Value = 0;
            count_num.Value = 0;
            weight_num.Value = 0;

        }

        private void finish_but_Click(object sender, EventArgs e)
        {
            supplier_id = manager_model.get_supplier_id(supp_name_combo.SelectedItem.ToString());
            receipt_id = manager_model.receipt_id();
            manager_model.insert_materials(supp_name_txt.Text, Convert.ToDouble(unite_price_num.Value), supplier_id, Convert.ToDouble(count_num.Value), Convert.ToDouble(weight_num.Value), receipt_date.Value, receipt_id);
            content_panel.Enabled = false;
            new_receipt_panel.Enabled = true;
            items_num.Value = 1;
            price_num.Value = 0;
            supp_name_txt.Text = "";
            supp_name_combo.Text = "";
            unite_price_num.Value = 0;
            count_num.Value = 0;
            weight_num.Value = 0;
            counter = 1;
        }

        private void oldreceipt_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            receipt_id = Convert.ToInt32(oldreceipt_grid.Rows[e.RowIndex].Cells[0].Value);
            manager_model.fill_content_grid(ref ds, receipt_id);
            content_grid.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
