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
    public partial class supplier_cont : UserControl
    {
        DataSet ds;
        int receipt_id=1;
        public supplier_cont()
        {
            InitializeComponent();
            manager_model.fill_grid(ref ds,supplier_serach_txt.Text);
            suplier_grid.DataSource = ds.Tables[0].DefaultView;
            suplier_grid.Columns[0].HeaderText = "Supplier ID";
            suplier_grid.Columns[1].HeaderText = "Supplier Name";
            suplier_grid.Columns[2].HeaderText = "Supplier Phone 1";
            suplier_grid.Columns[3].HeaderText = "Supplier Phone 2";
            suplier_grid.Columns[4].HeaderText = "Supplier Adress 1";
            suplier_grid.Columns[5].HeaderText = "Supplier Adress 2";
        }

        private void supplier_serach_txt_Click(object sender, EventArgs e)
        {
            supplier_serach_txt.Text = "";
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            add_supplier_form add = new add_supplier_form();
            add.Show();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            if (manager_model.supp_id != null)
            {
                supllier_edit_form Edit_Form = new supllier_edit_form();
                Edit_Form.Show();
            }

            
        }

        private void supplier_serach_txt_TextChanged(object sender, EventArgs e)
        {
            manager_model.fill_grid(ref ds, supplier_serach_txt.Text);
            suplier_grid.DataSource = ds.Tables[0].DefaultView;

        }

        private void suplier_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           manager_model.supp_id =Convert.ToInt32(suplier_grid.Rows[e.RowIndex].Cells[0].Value);

        }
    }
}
