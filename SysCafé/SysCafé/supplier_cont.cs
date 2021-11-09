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
        public void refresh()
        {
            model.fill_grid(ref ds, supplier_serach_txt.Text);
            suplier_grid.DataSource = ds.Tables[0].DefaultView;
            suplier_grid.Columns[0].HeaderText = "Supplier ID";
            suplier_grid.Columns[1].HeaderText = "Supplier Name";
            suplier_grid.Columns[2].HeaderText = "Supplier Phone 1";
            suplier_grid.Columns[3].HeaderText = "Supplier Phone 2";
            suplier_grid.Columns[4].HeaderText = "Supplier Adress 1";
            suplier_grid.Columns[5].HeaderText = "Supplier Adress 2";
        }
     
        public supplier_cont()
        {
            InitializeComponent();
            refresh();
        }

        private void supplier_serach_txt_Click(object sender, EventArgs e)
        {
            supplier_serach_txt.Text = "";
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            add_supplier_form add = new add_supplier_form();
            add.Show();
            add.add_but.Click += new System.EventHandler(refresh_but_Click);

        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            if (model.supp_id !=-1)
            {
                supllier_edit_form Edit_Form = new supllier_edit_form();
                Edit_Form.done_but.Click += new System.EventHandler(refresh_but_Click);
                Edit_Form.Show();
            }
            else
            {
                MessageBox.Show("Choose suplier");
            }

            
        }

        private void supplier_serach_txt_TextChanged(object sender, EventArgs e)
        {
            model.fill_grid(ref ds, supplier_serach_txt.Text);
            suplier_grid.DataSource = ds.Tables[0].DefaultView;

        }

        private void suplier_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                model.supp_id = Convert.ToInt32(suplier_grid.Rows[e.RowIndex].Cells[0].Value);
            }

        }

        private void refresh_but_Click(object sender, EventArgs e)
        {
            model.fill_grid(ref ds, supplier_serach_txt.Text);
            suplier_grid.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
