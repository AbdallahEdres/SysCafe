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
    public partial class tickets_cont : UserControl
    {
        int num_tables = manager_model.num_table();

        private void creat_table(int id)
        {
            Guna.UI2.WinForms.Guna2Button freetabla = new Guna.UI2.WinForms.Guna2Button();
            freetabla.Image = imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = id.ToString();
            freetabla.Font = new Font("Inter Semi Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location = new Point(19, 45);
            freetabla.Size = new Size(285, 150);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5, -20);
            freetabla.Margin = new Padding(10);
/*            freetabla.Click += new EventHandler(table_Click);
*/            if (manager_model.table_status(id) == 0)
            {
                freetabla.FillColor = Color.FromArgb(159, 159, 158);

            }
            else if (manager_model.table_status(id) == 1)
            {
                freetabla.FillColor = Color.FromArgb(9, 170, 41);

            }

            flowLayoutPanel1.Controls.Add(freetabla);

        }
        public tickets_cont()
        {
            InitializeComponent(); 
            for (int i = 1; i <= num_tables; i++)
            {
                creat_table(i);
            }
        }

        private void new_ticket_but_Click(object sender, EventArgs e)
        {
            new_ticket_panel.Visible = false;
            new_ticket_form new_Ticket = new new_ticket_form();
            new_Ticket.Show();
        }
    }
}
