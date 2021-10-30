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
    
    public partial class orders_cont : UserControl
    {
        DataSet ds;
        int num_tables = manager_model.num_table();

        private void creat_table(int id)
        {
            Guna.UI2.WinForms.Guna2Button freetabla = new Guna.UI2.WinForms.Guna2Button();
            freetabla.Image =imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = id.ToString() ;
            freetabla.Font = new Font("Inter Semi Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location =new Point(19, 45);
            freetabla.Size = new Size (285, 150);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5,-20);
            freetabla.Margin = new Padding(10);
            freetabla.Click += new EventHandler(table_Click);
            if (manager_model.table_status(id) == 0)
            {
                freetabla.FillColor = Color.FromArgb(159, 159, 158);

            }else if(manager_model.table_status(id) == 1)
            {
                freetabla.FillColor = Color.FromArgb(9, 170, 41);

            }

            flowLayoutPanel1.Controls.Add(freetabla);

        }
        public orders_cont()
        {
            InitializeComponent();
            for(int i =1; i <= num_tables; i++)
            {
                creat_table(i);
            }
            
        }

        private void table_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            MessageBox.Show("" + clickedButton.Text);
            manager_model.orders_grid_fill(ref ds, Convert.ToInt32(clickedButton.Text));
            orders_grid.DataSource = ds.Tables[0].DefaultView;

        }

        private void orders_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ticket_id =Convert.ToInt32( orders_grid.Rows[e.RowIndex].Cells[0].Value);
            manager_model.details_grid_fill(ref ds, ticket_id);
            details_grid.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
